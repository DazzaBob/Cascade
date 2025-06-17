Imports System
Namespace UI
    Partial Class FrmServer
        Friend Class Joblist
            Private ReadOnly File As String = Application.StartupPath & "Jobs.Xml"
            Private DATATABLE As Data.DataTable
            Private DGV As DataGridView
            Private Sub New()
                Me.DATATABLE = New Data.DataTable
            End Sub
            Friend Sub New(DataGridView As DataGridView)
                Me.New

                Me.DGV = DataGridView
            End Sub
            Friend Sub Start()
                If IO.File.Exists(Me.File) Then
                    Using SR As New IO.StreamReader(Me.File)
                        Me.DATATABLE.ReadXml(SR)
                    End Using

                    For Each ROW As Data.DataRow In Me.DATATABLE.Select("", "ID ASC")
                        Call AddDataGridviewRow(ROW)
                    Next ROW
                Else
                    Call CreateDataTable()
                End If
            End Sub
            Friend Sub Add(Requests As Requests, Parameters As String)
                Dim DR As Data.DataRow = Me.DATATABLE.NewRow
                DR.Item("DATETIME") = Date.Now
                DR.Item("REQUESTS") = Requests
                DR.Item("PARAMETERS") = Parameters

                Me.DATATABLE.Rows.Add(DR)
                Me.DATATABLE.AcceptChanges()
                Me.DATATABLE.WriteXml(File, True)

                Call AddDataGridviewRow(DR)
            End Sub
            Friend Sub Remove(Id As String)
                Dim DR() As Data.DataRow = Me.DATATABLE.Select("ID=" & Id)
                Me.DATATABLE.Rows.Remove(DR(0))
                Me.DATATABLE.AcceptChanges()
                Me.DATATABLE.WriteXml(File, True)

                Dim RemoveRows As New List(Of DataGridViewRow)
                For Each DGV_Row As DataGridViewRow In Me.DGV.Rows
                    If DR(0).Item("ID") = DGV_Row.Cells(0).Value Then
                        RemoveRows.Add(DGV_Row)
                        Exit For
                    End If
                Next DGV_Row

                For Each DGV_Row As DataGridViewRow In RemoveRows
                    Me.DGV.Rows.Remove(DGV_Row)
                Next
            End Sub
            Friend Sub Truncate()
                Me.DATATABLE.Dispose()
                Me.DGV.Rows.Clear()

                Call CreateDataTable()
            End Sub
            Private Sub CreateDataTable()
                Me.DATATABLE = New Data.DataTable("JobList")
                Me.DATATABLE.Locale = Globalization.CultureInfo.InvariantCulture
                Using Column As New Data.DataColumn("ID", GetType(Integer))
                    Column.AutoIncrement = True
                    Column.AutoIncrementSeed = 1L
                    Column.Unique = True
                    Me.DATATABLE.Columns.Add(Column)
                End Using

                Me.DATATABLE.Columns.Add(New Data.DataColumn("DATETIME", GetType(Date)))
                Me.DATATABLE.Columns.Add(New Data.DataColumn("REQUESTS", GetType(Requests)))
                Me.DATATABLE.Columns.Add(New Data.DataColumn("PARAMETERS", GetType(String)))
                Me.DATATABLE.AcceptChanges()
                Me.DATATABLE.WriteXml(File, True)
            End Sub
            Private Sub AddDataGridviewRow(DR As Data.DataRow)
                Using DGVRow As DataGridViewRow = New DataGridViewRow
                    DGVRow.CreateCells(Me.DGV)
                    DGVRow.Cells(0).Value = CInt(DR.Item("ID"))
                    DGVRow.Cells(1).Value = FormatDateTime(DR.Item("DATETIME"), DateFormat.GeneralDate)
                    DGVRow.Cells(2).Value = CType(DR.Item("REQUESTS"), Requests).ToString
                    DGVRow.Cells(3).Value = CStr(DR.Item("PARAMETERS"))
                    Me.DGV.Rows.Add(DGVRow)
                End Using
            End Sub
        End Class
    End Class
End Namespace