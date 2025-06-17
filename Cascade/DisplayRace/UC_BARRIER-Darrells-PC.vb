Namespace DisplayRace
    Friend NotInheritable Class UC_BARRIER
        Friend Sub New()
            InitializeComponent()
        End Sub
        Friend Sub Populate(ByVal Row As Data.DataRow, DAY As String)
            Using DGVRow As Windows.Forms.DataGridViewRow = New Windows.Forms.DataGridViewRow
                DGVRow.CreateCells(Me.DGV_MAIN)
                '
                DGVRow.Cells(Me.DGV_BARRIER.Index).Value = CShort(Row.Item("BARRIER"))
                DGVRow.Cells(Me.DGV_RUNS.Index).Value = CInt(Row.Item(DAY & "_RUNS"))
                '
                DGVRow.Cells(Me.DGV_SPEED_MIN.Index).Value = CDec(Row.Item(DAY & "_SPEED_MIN"))
                DGVRow.Cells(Me.DGV_SPEED_AVG.Index).Value = CDec(Row.Item(DAY & "_SPEED_AVG"))
                DGVRow.Cells(Me.DGV_SPEED_MAX.Index).Value = CDec(Row.Item(DAY & "_SPEED_MAX"))
                '
                DGVRow.Cells(Me.DGV_FINISHPOSITION_MIN.Index).Value = CDec(Row.Item(DAY & "_FINISH_POSITION_MIN"))
                DGVRow.Cells(Me.DGV_FINISHPOSITION_AVG.Index).Value = CDec(Row.Item(DAY & "_FINISH_POSITION_AVG"))
                DGVRow.Cells(Me.DGV_FINISHPOSITION_MAX.Index).Value = CDec(Row.Item(DAY & "_FINISH_POSITION_MAX"))
                '
                DGVRow.Cells(Me.DGV_DISTANCEBEHIND_MIN.Index).Value = CDec(Row.Item(DAY & "_DISTANCE_BEHIND_MIN"))
                DGVRow.Cells(Me.DGV_DISTANCEBEHIND_AVG.Index).Value = CDec(Row.Item(DAY & "_DISTANCE_BEHIND_AVG"))
                DGVRow.Cells(Me.DGV_DISTANCEBEHIND_MAX.Index).Value = CDec(Row.Item(DAY & "_DISTANCE_BEHIND_MAX"))
                '
                DGVRow.Cells(Me.DGV_WINS.Index).Value = CInt(Row.Item(DAY & "_WINS"))
                DGVRow.Cells(Me.DGV_PLACES.Index).Value = CInt(Row.Item(DAY & "_PLACES"))
                DGVRow.Cells(Me.DGV_RANK.Index).Value = CDec(Row.Item(DAY & "_RANK"))
                '
                DGV_MAIN.Rows.Add(DGVRow)
            End Using
        End Sub
        Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CMS_MI_TSMI_COPY.Click
            Dim DataObject As Windows.Forms.DataObject = Me.DGV_MAIN.GetClipboardContent
            Windows.Forms.Clipboard.SetDataObject(DataObject, True)
            Me.DGV_MAIN.ClearSelection()
        End Sub
    End Class
End Namespace