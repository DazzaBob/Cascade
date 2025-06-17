Namespace StoredProcedures
    Friend NotInheritable Class RACE_INFO_BARRIER
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared ReadOnly Property GetDataTable(ByVal MEETING_INFO_OADATE As String, ByVal MEETING_INFO_NUMBER As String, ByVal RACE_INFO_NUMBER As String, ByVal Connection As Connection) As Data.DataTable
            Get
                Dim CMDTEXT As String = "SELECT RACE_INFO_BARRIER.* "
                CMDTEXT = String.Concat(CMDTEXT, "FROM RACE_INFO_BARRIER ")
                CMDTEXT = String.Concat(CMDTEXT, "WHERE (MEETING_INFO_OADATE = " & MEETING_INFO_OADATE & ") AND (MEETING_INFO_NUMBER = " & MEETING_INFO_NUMBER & ") AND (RACE_INFO_NUMBER = " & RACE_INFO_NUMBER & ")")
                Return Connection.GetDataTable(CMDTEXT)
            End Get
        End Property
        Friend Shared ReadOnly Property GetDataTable(ByVal MEETING_INFO_OADATE As String, ByVal MEETING_INFO_NUMBER As String, ByVal RACE_INFO_NUMBER As String) As Data.DataTable
            Get
                Return GetDataTable(MEETING_INFO_OADATE, MEETING_INFO_NUMBER, RACE_INFO_NUMBER, ServerUI.FrmServer.Connection)
            End Get
        End Property
        Friend Shared ReadOnly Property GetModelRunDataTable(ByVal Filter As String, ByVal Connection As Connection) As Data.DataTable
            Get
                Dim COMMANDTEXT As String = "SELECT RACE_INFO_BARRIER.* "
                COMMANDTEXT += "FROM RACE_INFO LEFT OUTER JOIN RACE_INFO_BARRIER ON RACE_INFO.MEETING_INFO_OADATE = RACE_INFO_BARRIER.MEETING_INFO_OADATE AND RACE_INFO.MEETING_INFO_NUMBER = RACE_INFO_BARRIER.MEETING_INFO_NUMBER AND RACE_INFO.NUMBER = RACE_INFO_BARRIER.RACE_INFO_NUMBER RIGHT OUTER JOIN MEETING_INFO ON RACE_INFO.MEETING_INFO_OADATE = MEETING_INFO.OADATE AND RACE_INFO.MEETING_INFO_NUMBER = MEETING_INFO.NUMBER "
                COMMANDTEXT += Filter
                '
                Return Connection.GetDataTable(COMMANDTEXT)
            End Get
        End Property
    End Class
End Namespace