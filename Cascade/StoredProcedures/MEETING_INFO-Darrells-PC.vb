' MEETINGS to loaded from XML in LOADER
Namespace StoredProcedures
    Friend NotInheritable Class MEETING_INFO
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
#Region "       METHODS FOR RESULTS "
        Friend Shared ReadOnly Property GetMeetingType(ByVal MeetingNumber As String, ByVal MeetingOADate As String, ByVal Connection As Connection) As String
            Get
                Dim CMDTEXT As String = "SELECT [TYPE] FROM MEETING_INFO WHERE (OADATE= " & MeetingOADate & ") AND (NUMBER=" & MeetingNumber & ")"
                Return CStr(Connection.ExecuteScalar(CMDTEXT))
            End Get
        End Property
        Friend Shared ReadOnly Property MeetingExists(ByVal MeetingNumber As Int16, ByVal MeetingOADate As Int32, ByVal Connection As Connection) As Boolean
            Get
                Dim This_MeetingNumber As Short = 0S
                Dim CMDTEXT As String = "SELECT NUMBER FROM MEETING_INFO WHERE (OADATE= " & CStr(MeetingOADate) & ") AND (NUMBER=" & CStr(MeetingNumber) & ")"
                If My.Settings.LoadGreyhounds Then
                    This_MeetingNumber = CShort(Connection.ExecuteScalar(CMDTEXT))
                End If
                If This_MeetingNumber > 0 Then Return True Else Return False
            End Get
        End Property
#End Region
 End Class
End Namespace