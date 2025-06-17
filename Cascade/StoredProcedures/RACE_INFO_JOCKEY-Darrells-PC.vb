Namespace StoredProcedures
    Friend NotInheritable Class RACE_INFO_JOCKEY
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public Shared ReadOnly Property GetDataTable(ByVal MEETING_INFO_OADATE As String, ByVal MEETING_INFO_NUMBER As String, ByVal RACE_INFO_NUMBER As String, ByVal Connection As Connection) As Data.DataTable
            Get
                Dim CMDTEXT As String = "SELECT RACE_INFO_JOCKEY.* "
                CMDTEXT += "FROM RACE_INFO_JOCKEY "
                CMDTEXT += "WHERE (MEETING_INFO_OADATE = " & MEETING_INFO_OADATE & ") AND (MEETING_INFO_NUMBER = " & MEETING_INFO_NUMBER & ") AND (RACE_INFO_NUMBER = " & RACE_INFO_NUMBER & ")"
                '
                Return Connection.GetDataTable(CMDTEXT)
            End Get
        End Property
    End Class
End Namespace
