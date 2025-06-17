Namespace DisplayRace
    Friend NotInheritable Class UC_RESULTS
        Private MY_MEETING_OADATE As String
        Private MY_MEETING_NUMBER As String
        Private MY_MEETING_COUNTRY As String
        Private MY_MEETING_TYPE As String
        Private MY_RACE_NUMBER As String
        Private MY_CONNECTION As Connection
        '
        Private MY_POPUP As UserControls.PopUp
        Private MY_RRL As UC_RUNNERRACELIST
        Friend Sub New()
            InitializeComponent()
        End Sub
        Friend Sub Populate(ByVal MEETING_OADATE As String, ByVal MEETING_NUMBER As String, ByVal MEETING_COUNTRY As String, ByVal MEETING_TYPE As String, ByVal RACE_NUMBER As String, ByVal Connection As Connection)
            '
            MY_MEETING_OADATE = MEETING_OADATE
            MY_MEETING_NUMBER = MEETING_NUMBER
            MY_MEETING_COUNTRY = MEETING_COUNTRY
            MY_MEETING_TYPE = MEETING_TYPE
            MY_RACE_NUMBER = RACE_NUMBER
            '
            MY_CONNECTION = Connection
            '
            Me.DGV.Rows.Clear()
            '
            Dim CMDTEXT As String = "EXEC SP_DISPLAYRACE_UC_RESULTS @MEETING_INFO_OADATE=" & MY_MEETING_OADATE & ", @MEETING_INFO_NUMBER=" & MY_MEETING_NUMBER & ", @RACE_NUMBER=" & MY_RACE_NUMBER
            For Each ROW As Data.DataRow In MY_CONNECTION.GetDataTable(CMDTEXT).Select("")
                Using DGVRow = New Windows.Forms.DataGridViewRow
                    DGVRow.CreateCells(Me.DGV)
                    '
                    DGVRow.Cells(Me.DGV_NUMBER.Index).Value = CInt(ROW.Item("NUMBER"))
                    DGVRow.Cells(Me.DGV_NAME.Index).Value = ROW.Item("NAME").ToString
                    DGVRow.Cells(Me.DGV_BARRIER.Index).Value = CShort(ROW.Item("BARRIER"))
                    DGVRow.Cells(Me.DGV_FINISH_TIME.Index).Value = CDec(ROW.Item("RESULT_TIME"))
                    DGVRow.Cells(Me.DGV_FINISHPOSITION.Index).Value = CShort(ROW.Item("RESULT_FINISH_POSITION"))
                    DGVRow.Cells(Me.DGV_DISTANCE_BEHIND.Index).Value = CDec(ROW.Item("RESULT_DISTANCE_BEHIND"))
                    DGVRow.Cells(Me.DGV_SPEED.Index).Value = CDec(ROW.Item("RESULT_SPEED"))
                    DGVRow.Cells(Me.DGV_WINS.Index).Value = CDec(ROW.Item("RESULT_POOL_WIN"))
                    DGVRow.Cells(Me.DGV_PLACES.Index).Value = CDec(ROW.Item("RESULT_POOL_PLACE"))
                    DGVRow.Cells(Me.DGV_THEO_TIME.Index).Value = CDec(ROW.Item("RESULT_THEO_TIME"))
                    DGVRow.Cells(Me.DGV_THEO_FINISH_POSITION.Index).Value = CDec(ROW.Item("RESULT_THEO_FINISH_POSITION"))
                    DGVRow.Cells(Me.DGV_THEO_SPEED.Index).Value = CDec(ROW.Item("RESULT_THEO_SPEED"))
                    DGVRow.Cells(Me.DGV_THEO_DISTANCE_RAN.Index).Value = CDec(ROW.Item("RESULT_THEO_DISTANCE_RAN"))
                    '
                    Me.DGV.Rows.Add(DGVRow)
                End Using
            Next ROW
            '
            Me.DGV_POOL.Rows.Clear()
            For Each ROW As Data.DataRow In StoredProcedures.RACE_INFO_RESULTS_POOLS.GetDataTable(MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_RACE_NUMBER, MY_CONNECTION).Select("")
                Using DGVRow = New Windows.Forms.DataGridViewRow
                    DGVRow.CreateCells(Me.DGV_POOL)
                    '
                    DGVRow.Cells(Me.DGV_POOLS_NUMBERS.Index).Value = CStr(ROW.Item("NUMBERS"))
                    DGVRow.Cells(Me.DGV_POOLS_NAME.Index).Value = ROW.Item("NAME").ToString
                    DGVRow.Cells(Me.DGV_POOLS_AMOUNT.Index).Value = CDec(ROW.Item("AMOUNT"))
                    DGVRow.Cells(Me.DGV_POOLS_TYPE.Index).Value = CStr(ROW.Item("TYPE"))
                    '
                    Me.DGV_POOL.Rows.Add(DGVRow)
                End Using
            Next ROW
        End Sub
        Private Sub DGView_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
            If e.ColumnIndex <> Me.DGV_NAME.Index Then Return
            Me.Cursor = Cursors.WaitCursor
            '
            Dim RUNNERNAME As String = CStr(Me.DGV.Rows(e.RowIndex).Cells(Me.DGV_NAME.Index).Value.ToString)
            MY_RRL = New UC_RUNNERRACELIST(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, RUNNERNAME, MY_CONNECTION)
            MY_RRL.Dock = DockStyle.Fill
            '
            MY_POPUP = New UserControls.PopUp
            MY_POPUP.Text = "Runner Race List (" & RUNNERNAME & ")"
            MY_POPUP.Size = New Size(1024, 768)
            MY_POPUP.WindowState = FormWindowState.Maximized
            MY_POPUP.Controls.Add(MY_RRL)
            '
            MY_POPUP.Show(Me)
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub DGV_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGV.DataError, DGV_POOL.DataError
            ' Do Nothing
        End Sub
        Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
            Dim DataObject As Windows.Forms.DataObject = Me.DGV.GetClipboardContent
            Windows.Forms.Clipboard.SetDataObject(DataObject, True)
            Me.DGV.ClearSelection()
        End Sub
    End Class
End Namespace