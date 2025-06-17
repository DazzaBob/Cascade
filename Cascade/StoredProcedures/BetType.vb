Namespace StoredProcedures
    Friend NotInheritable Class BetType
        Private Sub New()
            ' Just so the compiler wont create a default constructor
        End Sub
        Friend Shared ReadOnly Property GetDataTable(ByVal connection As Connection) As Data.DataTable
            Get
                If connection Is Nothing Then Return Nothing
                Dim CMDTEXT As String = "SELECT * FROM BET_TYPE"
                Return connection.GetDataTable(CMDTEXT)
            End Get
        End Property
    End Class
End Namespace