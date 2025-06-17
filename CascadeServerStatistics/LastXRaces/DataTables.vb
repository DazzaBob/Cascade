Namespace LastXRaces
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
                Dim CMDTEXT As String = "SELECT * FROM [MEETING_XML] WHERE ([OADATE] = " & OADate & ") AND ([STATUS] NOT LIKE 'AB*') ORDER BY COUNTRY_ID ASC, NUMBER ASC"
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