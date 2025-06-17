Namespace ModelRun.Models
    Friend Class Common
        Private Sub New()
            'Just So the compiler doesnt create a default constructor
        End Sub
        Friend Shared Function TestColumn(DataTable As Data.DataTable, ColumnName As String, TestValue As Object, [Operator] As String, Value As Object, Optional Filter As String = Nothing, Optional Sort As String = Nothing) As Boolean
            Dim X As Integer
            Dim ThisFilter As String = String.Empty
            Dim ThisSort As String = String.Empty

            If Filter IsNot Nothing Then ThisFilter = Filter
            If Sort IsNot Nothing Then ThisSort = Sort

            For Each Row As Data.DataRow In DataTable.Select(ThisFilter, ThisSort)
                If Row.Item(ColumnName) = TestValue Then X += 1
            Next Row

            Select Case [Operator]
                Case "<"
                    If X < Value Then Return True Else Return False
                Case ">"
                    If X > Value Then Return True Else Return False
                Case "="
                    If X = Value Then Return True Else Return False
                Case Else
            End Select

            Return False
        End Function
    End Class
End Namespace