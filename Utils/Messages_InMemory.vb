Partial Class Messages
    Public NotInheritable Class InMemory
        Private MY_DATATABLE As Data.DataTable = Nothing
        Private LockObject As New Object  ' Just so we dont try reading and writing the table at the same time.
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Public ReadOnly Property GetDataTable() As Data.DataTable
            Get
                If MY_DATATABLE Is Nothing Then Call SetDataTableColumns()
                Return MY_DATATABLE
            End Get
        End Property
        Public Sub AddNew(ByVal dateTime As Date, ByVal logthis As String)
            SyncLock LockObject
                Dim DR As Data.DataRow = GetDataTable.NewRow
                DR.Item("DATETIME") = dateTime
                DR.Item("MESSAGE") = logthis
                MY_DATATABLE.Rows.Add(DR)
                '
                MY_DATATABLE.AcceptChanges()
            End SyncLock
        End Sub
        Public Sub Truncate()
            SyncLock LockObject
                If Not GetDataTable Is Nothing Then GetDataTable.Clear() : GetDataTable.AcceptChanges()
            End SyncLock
        End Sub
        Public Sub Delete(ByVal inclause As String)
            If MY_DATATABLE Is Nothing Then Return
            '
            SyncLock LockObject
                Dim DR() As Data.DataRow = GetDataTable.Select("ID IN(" & inclause & ")")
                For Each ROW As Data.DataRow In DR
                    MY_DATATABLE.Rows.Remove(ROW)
                Next ROW
                '
                MY_DATATABLE.AcceptChanges()
            End SyncLock
        End Sub
        Public Sub SetDataTableColumns()
            MY_DATATABLE = New Data.DataTable("UIMessages")
            MY_DATATABLE.Locale = Globalization.CultureInfo.InvariantCulture
            Using Column As New Data.DataColumn("ID", GetType(Integer))
                Column.AutoIncrement = True
                Column.AutoIncrementSeed = 1L
                Column.Unique = True
                MY_DATATABLE.Columns.Add(Column)
            End Using
            MY_DATATABLE.Columns.Add(New Data.DataColumn("DATETIME", GetType(Date)))
            MY_DATATABLE.Columns.Add(New Data.DataColumn("MESSAGE", GetType(String)))
            '
            MY_DATATABLE.AcceptChanges()
        End Sub
    End Class
End Class