Namespace SQL
    Public Class ENTRY_XML
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared Sub ScratchTheRunner(OADate As String, MeetingNumber As String, RaceNumber As String, EntryNumber As String, Connection As Utils.Connection)
            Dim CMDTEXT As String = "UPDATE ENTRY_XML SET SCRATCHED=1 
                WHERE [MEETING_XML_OADATE]=" & OADate & " AND [MEETING_XML_NUMBER]=" & MeetingNumber & " AND [RACE_XML_NUMBER]=" & RaceNumber & " AND [NUMBER]=" & EntryNumber

            Call Connection.Execute(CMDTEXT)
        End Sub
    End Class
End Namespace