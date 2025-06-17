Namespace SQL
    Friend Module RaceXML
        Friend Sub DeleteRace(OADate As String, MeetingNumber As String, [Number] As String, Connection As Utils.Connection)
            Dim CommandText As String = "DELETE FROM RACE_XML WHERE (MEETING_XML_OADATE=" & OADate & ") AND (MEETING_XML_NUMBER=" & MeetingNumber & ") AND (NUMBER=" & Number & ")"
            Call Connection.Execute(CommandText)
        End Sub
    End Module
End Namespace