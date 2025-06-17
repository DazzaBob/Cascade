Imports CascadeServerStatistics.LastXRaces.EntryPoint

Namespace LastXRaces
    Friend Class RacesForRunners
        Private Shared RunnersForRaceLockObject As New Object
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared Sub RunnersForRace(OADate As String, MeetingNumber As String, RaceNumber As String, Messages As CascadeCommon.Messages, Connection As CascadeCommon.Utils.Connection)
            SyncLock RunnersForRaceLockObject
                Dim CMDTEXT As String = "SELECT MEETING_XML.COUNTRY_ID, MEETING_XML.TYPE, ENTRY_XML.SCRATCHED, RACE_XML.LENGTH, RACE_XML.VENUE_ID, RACE_XML.RUNNERSINRACE, ENTRY_XML.NAME, ENTRY_XML.MEETING_XML_OADATE, ENTRY_XML.MEETING_XML_NUMBER, ENTRY_XML.RACE_XML_NUMBER, ENTRY_XML.NUMBER 
                    FROM ENTRY_XML INNER JOIN MEETING_XML INNER JOIN RACE_XML ON MEETING_XML.OADATE = RACE_XML.MEETING_XML_OADATE AND MEETING_XML.NUMBER = RACE_XML.MEETING_XML_NUMBER ON ENTRY_XML.MEETING_XML_OADATE = RACE_XML.MEETING_XML_OADATE AND ENTRY_XML.MEETING_XML_NUMBER = RACE_XML.MEETING_XML_NUMBER AND ENTRY_XML.RACE_XML_NUMBER = RACE_XML.NUMBER 
                    WHERE (ENTRY_XML.MEETING_XML_OADATE = " & OADate & ") AND (ENTRY_XML.MEETING_XML_NUMBER = " & MeetingNumber & ") AND (ENTRY_XML.RACE_XML_NUMBER = " & RaceNumber & ") 
                    ORDER BY ENTRY_XML.MEETING_XML_NUMBER, ENTRY_XML.RACE_XML_NUMBER, ENTRY_XML.NUMBER"

                Dim MyDT As Data.DataTable = Nothing

                Try
                    For Each Row As Data.DataRow In Connection.GetDataTable(CMDTEXT).Select("")
                        If Not CBool(Row.Item("SCRATCHED")) Then
                            CMDTEXT = "SELECT RACE_XML.MEETING_XML_OADATE, RACE_XML.LENGTH, RACE_XML.VENUE_ID, ENTRY_XML.SCRATCHED, RESULTS_EXTENDED.FINISH_POSITION, RESULTS_EXTENDED.DISTANCE_BEHIND, RESULTS_EXTENDED.EXCEPTION, ENTRY_XML.NAME, RACE_XML.RUNNERSINRACE, 0.00 AS RANKED, 0.00 AS TOTAL_DISTANCEBEHIND 
                                FROM RACE_XML INNER JOIN ENTRY_XML ON RACE_XML.MEETING_XML_OADATE = ENTRY_XML.MEETING_XML_OADATE AND RACE_XML.MEETING_XML_NUMBER = ENTRY_XML.MEETING_XML_NUMBER AND RACE_XML.NUMBER = ENTRY_XML.RACE_XML_NUMBER INNER JOIN MEETING_XML ON RACE_XML.MEETING_XML_OADATE = MEETING_XML.OADATE AND RACE_XML.MEETING_XML_NUMBER = MEETING_XML.NUMBER LEFT OUTER JOIN RESULTS_EXTENDED ON ENTRY_XML.MEETING_XML_OADATE = RESULTS_EXTENDED.MEETING_XML_OADATE AND ENTRY_XML.MEETING_XML_NUMBER = RESULTS_EXTENDED.MEETING_XML_NUMBER AND ENTRY_XML.RACE_XML_NUMBER = RESULTS_EXTENDED.RACE_XML_NUMBER AND ENTRY_XML.NUMBER = RESULTS_EXTENDED.NUMBER 
                                WHERE (MEETING_XML.COUNTRY_ID = " & Row.Item("COUNTRY_ID").ToString & ") AND (MEETING_XML.TYPE = N'" & Row.Item("TYPE").ToString & "') AND (ENTRY_XML.NAME = N'" & Replace(Row.Item("NAME").ToString, "'", "' + CHAR(39) +'") & "') AND (ENTRY_XML.MEETING_XML_OADATE < " & OADate & ") AND (ENTRY_XML.MEETING_XML_OADATE > " & (CInt(OADate) - 184).ToString & ") 
                                ORDER BY ENTRY_XML.MEETING_XML_OADATE DESC"
                            If MyDT Is Nothing Then
                                MyDT = Connection.GetDataTable(CMDTEXT)
                                For Each DR As Data.DataRow In MyDT.Select("")
                                    Call RankRunner(DR, MyDT)
                                Next DR
                                Call MyDT.AcceptChanges()
                            Else
                                For Each ImportRow As Data.DataRow In Connection.GetDataTable(CMDTEXT).Select("")
                                    Call RankRunner(ImportRow, MyDT)
                                Next ImportRow
                                Call MyDT.AcceptChanges()
                            End If

                            Using L10R As New Last10Races(MyDT, String.Empty, OADate, MeetingNumber, Row.Item("TYPE").ToString, RaceNumber, Row.Item("NUMBER").ToString, Row.Item("NAME").ToString, Row.Item("LENGTH").ToString, Messages, Connection)
                                Call L10R.Start()
                            End Using

                            Using DT As Data.DataTable = New Data.DataView(MyDT, "VENUE_ID=" & Row.Item("VENUE_ID").ToString, String.Empty, Data.DataViewRowState.Unchanged).ToTable
                                Using L10R As New Last10Races(DT, "VENUE", OADate, MeetingNumber, Row.Item("TYPE").ToString, RaceNumber, Row.Item("NUMBER").ToString, Row.Item("NAME").ToString, Row.Item("LENGTH").ToString, Messages, Connection)
                                    Call L10R.Start()
                                End Using
                            End Using
                        End If
                    Next Row

                Catch ex As Exception
                    Call Messages.LogMessages(ex.ToString, CascadeCommon.Common.BroadcastTypes.Error)
                Finally
                    If MyDT IsNot Nothing Then MyDT.Dispose()
                    CMDTEXT = Nothing
                End Try
            End SyncLock
        End Sub
        Private Shared Sub RankRunner(ByRef ImportRow As Data.DataRow, ByRef DataTable As Data.DataTable)
            Try
                If Not Information.IsDBNull(ImportRow.Item("FINISH_POSITION")) Then
                    If CDbl(ImportRow.Item("FINISH_POSITION")) = 1.0# Then
                        ImportRow.Item("RANKED") = 100.0#
                        ImportRow.Item("DISTANCE_BEHIND") = 0#
                        Call DataTable.ImportRow(ImportRow)
                        Exit Sub
                    Else
                        If CDbl(ImportRow.Item("FINISH_POSITION")) > 0 Then
                            ImportRow.Item("RANKED") = 100 - (100 / CDbl(ImportRow.Item("RUNNERSINRACE")) * CDbl(ImportRow.Item("FINISH_POSITION")))
                            Call DataTable.ImportRow(ImportRow)
                            Exit Sub
                        Else
                            ImportRow.Item("RANKED") = 0
                            ImportRow.Item("DISTANCE_BEHIND") = 999.0#
                            Call DataTable.ImportRow(ImportRow)
                            Exit Sub
                        End If
                    End If
                End If

                ImportRow.Item("RANKED") = -1.0#
                ImportRow.Item("DISTANCE_BEHIND") = 999
                Call DataTable.ImportRow(ImportRow)

            Catch EX As Exception
                ImportRow.Item("RANKED") = -1.0#
                ImportRow.Item("DISTANCE_BEHIND") = 999
                Call DataTable.ImportRow(ImportRow)
            Finally
                Call DataTable.AcceptChanges()
            End Try
        End Sub
    End Class
End Namespace