' MEETINGS to loaded from XML in LOADER
Namespace SQL
    Friend Module MeetingXML
        Friend ReadOnly Property GetMeetingType(MeetingNumber As String, MeetingOADate As String, Connection As CascadeCommon.Utils.Connection) As String
            Get
                Dim CMDTEXT As String = "SELECT [TYPE] FROM MEETING_XML WHERE (OADATE= " & MeetingOADate & ") AND (NUMBER=" & MeetingNumber & ")"
                Return CStr(Connection.ExecuteScalar(CMDTEXT))
            End Get
        End Property
        Friend ReadOnly Property MeetingExists(MeetingNumber As String, MeetingOADate As String, Connection As CascadeCommon.Utils.Connection) As Boolean
            Get
                Dim This_MeetingNumber As Short
                Dim CMDTEXT As String = "SELECT NUMBER FROM MEETING_XML WHERE (OADATE= " & MeetingOADate & ") AND (NUMBER=" & MeetingNumber & ")"
                This_MeetingNumber = Connection.ExecuteScalar(CMDTEXT)

                If This_MeetingNumber > 0 Then Return True Else Return False
            End Get
        End Property
        Friend Sub DeleteMeeting(OADate As String, Connection As CascadeCommon.Utils.Connection)
            Dim CommandText As String
            CommandText = "DELETE FROM MEETING_XML WHERE (OADATE=" & OADate & ") "
            Call Connection.Execute(CommandText)
        End Sub
    End Module
End Namespace