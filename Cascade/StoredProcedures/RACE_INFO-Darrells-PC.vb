Namespace StoredProcedures
    Friend NotInheritable Class RACE_INFO
        Private Sub New()
            ' Just so the compiler doesnt create a defualt constructor
        End Sub
        Friend Shared ReadOnly Property GetScalarFieldValue(ByVal Field As String, ByVal MeetingOADate As String, ByVal MeetingNumber As String, ByVal RaceNumber As String, ByVal Connection As Connection) As String
            Get
                Dim CMDTEXT As String = "SELECT [" & Field & "] "
                CMDTEXT += "FROM RACE_INFO "
                CMDTEXT += "WHERE (MEETING_INFO_OADATE=" & MeetingOADate & ") AND "
                CMDTEXT += "(MEETING_INFO_NUMBER=" & MeetingNumber & ") AND "
                CMDTEXT += "(NUMBER=" & RaceNumber & ")"
                '
                Dim VALUE As Object = Connection.ExecuteScalar(CMDTEXT)
                If IsDBNull(VALUE) Then Return Nothing
                Return CStr(VALUE)
            End Get
        End Property
        Friend Shared ReadOnly Property GetModelRunDataTable(ByVal Filter As String, ByVal Connection As Connection) As Data.DataTable
            Get
                Dim COMMANDTEXT As String = "SELECT RACE_INFO.*, MEETING_INFO.COUNTRY, MEETING_INFO.TYPE "
                COMMANDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER "
                COMMANDTEXT += Filter
                '
                Return Connection.GetDataTable(COMMANDTEXT)
            End Get
        End Property
    End Class
End Namespace