Namespace GreyhoundsBarrier
    Partial Class EntryPoint
        Friend Class DataTables : Implements IDisposable
            Private disposedValue As Boolean
            Private ReadOnly This_Messages As CascadeCommon.Messages
            Private Sub New()
                Me.disposedValue = False
            End Sub
            Friend Sub New(Messages As CascadeCommon.Messages)
                Me.New
                Me.This_Messages = Messages
            End Sub
            Friend Function Meeting(OADate As String, Connection As CascadeCommon.Utils.Connection) As Data.DataTable
                Dim CMDTEXT As String = "SELECT * FROM [MEETING_XML] WHERE ([OADATE] = " & OADate & ") AND ([TYPE]='GR') AND ([STATUS] NOT LIKE 'AB*') ORDER BY COUNTRY_ID ASC, NUMBER ASC"
                Try
                    Return Connection.GetDataTable(CMDTEXT)
                Catch ex As Exception
                    Call This_Messages.LogMessages(ex.ToString, CascadeCommon.Common.BroadcastTypes.Error)
                End Try

                Return New Data.DataTable
            End Function
            Friend Function Race(OADate As String, MeetingNumber As String, Connection As CascadeCommon.Utils.Connection) As Data.DataTable
                Dim CMDTEXT As String = "SELECT RACE_XML.*, VENUES.NAME AS VENUE_NAME FROM RACE_XML INNER JOIN VENUES ON RACE_XML.VENUE_ID = VENUES.VENUE_ID 
                    WHERE (RACE_XML.MEETING_XML_OADATE = " & OADate & ") AND (RACE_XML.MEETING_XML_NUMBER = " & MeetingNumber & ") AND (NOT (RACE_XML.STATUS LIKE N'AB*'))"
                Try
                    Return Connection.GetDataTable(CMDTEXT)
                Catch ex As Exception
                    Call This_Messages.LogMessages(ex.ToString, CascadeCommon.Common.BroadcastTypes.Error)
                End Try

                Return New Data.DataTable
            End Function
            Friend Function RaceResultsDT(OADate As String, VenueID As String, Length As String, Connection As CascadeCommon.Utils.Connection) As Data.DataTable
                Dim CMDTEXT As String = "SELECT ENTRY_XML.BARRIER, RESULTS_EXTENDED.FINISH_POSITION, RACE_XML.RUNNERSINRACE, 0.00 AS RANK 
                    FROM  RACE_XML INNER JOIN ENTRY_XML ON RACE_XML.MEETING_XML_OADATE = ENTRY_XML.MEETING_XML_OADATE AND RACE_XML.MEETING_XML_NUMBER = ENTRY_XML.MEETING_XML_NUMBER AND RACE_XML.NUMBER = ENTRY_XML.RACE_XML_NUMBER INNER JOIN RESULTS_EXTENDED ON ENTRY_XML.MEETING_XML_OADATE = RESULTS_EXTENDED.MEETING_XML_OADATE AND ENTRY_XML.MEETING_XML_NUMBER = RESULTS_EXTENDED.MEETING_XML_NUMBER AND ENTRY_XML.RACE_XML_NUMBER = RESULTS_EXTENDED.RACE_XML_NUMBER AND ENTRY_XML.NUMBER = RESULTS_EXTENDED.NUMBER 
                    WHERE (RACE_XML.MEETING_XML_OADATE IN (
                                                            SELECT DISTINCT TOP (10) RACE_XML_1.MEETING_XML_OADATE FROM RACE_XML AS RACE_XML_1 INNER JOIN VENUES ON RACE_XML_1.VENUE_ID = VENUES.VENUE_ID 
                                                            WHERE (RACE_XML_1.MEETING_XML_OADATE < " & OADate & ") AND (NOT (RACE_XML_1.STATUS LIKE N'AB*')) AND (VENUES.TRACK_TYPE = N'GR') AND (VENUES.VENUE_ID = " & VenueID & ") AND (RACE_XML_1.LENGTH = " & Length & ") AND (RACE_XML_1.MEETING_XML_OADATE > " & (CInt(OADate) - 120).ToString & ") 
                                                            ORDER BY RACE_XML_1.MEETING_XML_OADATE DESC
                                                           )
                           ) AND (RACE_XML.VENUE_ID = " & VenueID & ") AND (RACE_XML.LENGTH = " & Length & ") ORDER BY ENTRY_XML.BARRIER, RESULTS_EXTENDED.FINISH_POSITION"

                Dim DT As Data.DataTable = Connection.GetDataTable(CMDTEXT)
                Try
                    For Each Row As Data.DataRow In DT.Select("")
                        If CDbl(Row.Item("FINISH_POSITION")) = 1.0# Then Row.Item("RANK") = 100.0# : Continue For
                        Row.Item("RANK") = 100 - (100 / CDbl(Row.Item("RUNNERSINRACE")) * CDbl(Row.Item("FINISH_POSITION")))
                    Next Row
                Catch ex As Exception
                    Call This_Messages.LogMessages(ex.ToString, CascadeCommon.Common.BroadcastTypes.Error)
                End Try

                Return DT
            End Function
            Protected Overridable Sub Dispose(disposing As Boolean)
                If Not disposedValue Then
                    If disposing Then
                        ' TODO: dispose managed state (managed objects)
                    End If

                    ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
                    ' TODO: set large fields to null
                    disposedValue = True
                End If
            End Sub

            ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
            ' Protected Overrides Sub Finalize()
            '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            '     Dispose(disposing:=False)
            '     MyBase.Finalize()
            ' End Sub

            Public Sub Dispose() Implements IDisposable.Dispose
                ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
                Dispose(disposing:=True)
                GC.SuppressFinalize(Me)
            End Sub
        End Class
    End Class
End Namespace