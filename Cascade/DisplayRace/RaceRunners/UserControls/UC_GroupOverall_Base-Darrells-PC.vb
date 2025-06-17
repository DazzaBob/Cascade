Namespace DisplayRace.RaceRunners.UserControls
    Friend NotInheritable Class UC_GroupOverall_Base
        Private MY_POPUP As Cascade.UserControls.PopUp
        Private MY_RUNNERRACELIST As UC_RUNNERRACELIST
        '
        Private MY_MEETINGOADATE As String
        Private MY_MEETINGCOUNTRY As String
        Private MY_MEETINGTYPE As String
        Private MY_CONNECTION As Connection
        Friend Sub New(ByVal OADate As String, ByVal Country As String, ByVal Type As String, ByVal Connection As Connection)
            InitializeComponent()
            '
            MY_MEETINGOADATE = OADate
            MY_MEETINGCOUNTRY = Country
            MY_MEETINGTYPE = Type
            MY_CONNECTION = Connection
        End Sub
        Friend Sub Populate(ByVal Row As Data.DataRow)
            Using DGVRow As Windows.Forms.DataGridViewRow = New Windows.Forms.DataGridViewRow
                DGVRow.CreateCells(Me.DGV_MAIN_INFORMATION)
                '
                DGVRow.Cells(Me.DGV_NUMBER.Index).Value = CShort(Row.Item("NUMBER"))
                '
                DGVRow.Cells(Me.DGV_LASTRAN.Index).Value = CInt(Row.Item("LAST_RAN"))
                DGVRow.Cells(Me.DGV_LASTSPEED.Index).Value = CDec(Row.Item("LAST_SPEED"))
                DGVRow.Cells(Me.DGV_LASTDISTANCEBEHIND.Index).Value = CDec(Row.Item("LAST_DISTANCE_BEHIND"))
                '
                DGVRow.Cells(Me.DGV_LAST_PREVIOUS_RAN.Index).Value = CInt(Row.Item("LAST_PREVIOUS_RAN"))
                DGVRow.Cells(Me.DGV_LAST_PREVIOUS_SPEED.Index).Value = CDec(Row.Item("LAST_PREVIOUS_SPEED"))
                DGVRow.Cells(Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.Index).Value = CDec(Row.Item("LAST_PREVIOUS_DISTANCE_BEHIND"))
                '
                DGVRow.Cells(Me.DGV_DSLR.Index).Value = CInt(Row.Item("LAST_DSLR"))
                DGVRow.Cells(Me.DGV_DISTANCETORUN.Index).Value = CDec(Row.Item("DTR"))
                DGVRow.Cells(Me.DGV_NAME.Index).Value = Trim(CStr(Row.Item("NAME")))
                '
                DGV_MAIN_INFORMATION.Rows.Add(DGVRow)
            End Using
        End Sub
        Private Sub TSMI_MAIN_COPY_Click(sender As Object, e As EventArgs) Handles TSMI_COPY.Click
            Dim DataObject As Windows.Forms.DataObject = Me.DGV_MAIN_INFORMATION.GetClipboardContent
            Windows.Forms.Clipboard.SetDataObject(DataObject, True)
            Me.DGV_MAIN_INFORMATION.ClearSelection()
        End Sub
        Private Sub DGV_MAIN_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DGV_MAIN_INFORMATION.CellContentClick
            If e.ColumnIndex <> Me.DGV_NAME.Index Then Return
            If e.RowIndex < 0 Then Return
            '
            Dim RUNNERNAME As String = CStr(Me.DGV_MAIN_INFORMATION.Rows(e.RowIndex).Cells(Me.DGV_NAME.Index).Value.ToString)
            Call CreateAndOpenRunnerRaceListPopUp(RUNNERNAME)
        End Sub
        Private Sub CreateAndOpenRunnerRaceListPopUp(ByVal RUNNERNAME As String)
            Me.Cursor = Cursors.WaitCursor
            '
            MY_RUNNERRACELIST = New UC_RUNNERRACELIST(MY_MEETINGOADATE, MY_MEETINGCOUNTRY, MY_MEETINGTYPE, RUNNERNAME, MY_CONNECTION)
            MY_RUNNERRACELIST.Dock = DockStyle.Fill
            '
            MY_POPUP = New Cascade.UserControls.PopUp
            MY_POPUP.Text = "Runner Race List (" & RUNNERNAME & ")"
            MY_POPUP.Size = New Size(1024, 768)
            MY_POPUP.WindowState = FormWindowState.Maximized
            MY_POPUP.Controls.Add(MY_RUNNERRACELIST)
            '
            MY_POPUP.Show(Me)
            '
            Me.Cursor = Cursors.Default
        End Sub
    End Class
End Namespace