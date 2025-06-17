Namespace StoredProcedures
    Friend NotInheritable Class RACE_MODEL_INFO
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared ReadOnly Property GetDataTable(ByVal MeetingInfoOADate As String, ByVal MeetingNumber As String, ByVal RaceNumber As String, ByVal Connection As Connection) As Data.DataTable
            Get
                Dim CMDTEXT As String = "SELECT RACE_MODEL_INFO.* "
                CMDTEXT += "FROM RACE_MODEL_INFO "
                CMDTEXT += "WHERE (RACE_MODEL_INFO.MEETING_INFO_OADATE = " & MeetingInfoOADate & ") AND (RACE_MODEL_INFO.MEETING_INFO_NUMBER=" & MeetingNumber & ") AND (RACE_MODEL_INFO.RACE_INFO_NUMBER=" & RaceNumber & ")"
                '
                Return Connection.GetDataTable(CMDTEXT)
            End Get
        End Property
        Public Shared ReadOnly Property GetLiveModels(ByVal Connection As Connection) As Data.DataTable
            Get
                Dim CMDTEXT As String = "SELECT * FROM MODEL_EXPLORER "
                CMDTEXT += "WHERE (STATUS = 1) AND (TREE_NODE_TYPE = 2)"
                '
                Return Connection.GetDataTable(CMDTEXT)
            End Get
        End Property
    End Class
End Namespace