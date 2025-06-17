Namespace DataTables
    Friend Class ModelExplorer
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared Function DataTable(Filter As String) As Data.DataTable
            Dim CMDTEXT As String = "SELECT * FROM MODEL_EXPLORER WHERE (" & Filter & ")"

            Return Connection.GetDataTable(CMDTEXT)
        End Function
    End Class
End Namespace