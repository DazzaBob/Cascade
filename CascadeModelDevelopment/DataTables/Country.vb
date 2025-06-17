Namespace Datatables
    Friend Class Country
        Private Const SelectCommand As String = "SELECT * FROM COUNTRIES"
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared Function DataTable(Connection As Utils.Connection) As Data.DataTable
            Return Connection.GetDataTable(SelectCommand)
        End Function
    End Class
End Namespace