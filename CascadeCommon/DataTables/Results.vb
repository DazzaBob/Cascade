Namespace DataTables
    Public Class Results
        Private Shared ReadOnly ResultsLockObject As New Object
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared Function Results(OADate As String, MeetingNumber As String, RaceNumber As String, Connection As Utils.Connection) As Data.DataTable
            SyncLock ResultsLockObject
                Dim CMDTEXT As String = "SELECT ENTRY_XML.NUMBER, ENTRY_XML.BARRIER, ENTRY_XML.NAME, RESULTS_EXTENDED.FINISH_POSITION 
                    FROM ENTRY_XML LEFT OUTER JOIN RESULTS_EXTENDED ON ENTRY_XML.MEETING_XML_OADATE = RESULTS_EXTENDED.MEETING_XML_OADATE AND ENTRY_XML.MEETING_XML_NUMBER = RESULTS_EXTENDED.MEETING_XML_NUMBER AND ENTRY_XML.RACE_XML_NUMBER = RESULTS_EXTENDED.RACE_XML_NUMBER AND ENTRY_XML.NUMBER = RESULTS_EXTENDED.NUMBER 
                    WHERE (ENTRY_XML.MEETING_XML_OADATE = " & OADate & ") AND (ENTRY_XML.MEETING_XML_NUMBER = " & MeetingNumber & ") AND (ENTRY_XML.RACE_XML_NUMBER = " & RaceNumber & ") AND (ENTRY_XML.SCRATCHED=0) 
                    ORDER BY RESULTS_EXTENDED.FINISH_POSITION"

                Return Connection.GetDataTable(CMDTEXT)
            End SyncLock
        End Function
    End Class
End Namespace