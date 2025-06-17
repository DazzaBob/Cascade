Namespace DisplayRace.RaceRunners.UserControls
    Friend NotInheritable Class UC_Favourites
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
                DGVRow.CreateCells(Me.DGV_MAIN)
                '
                DGVRow.Cells(Me.DGV_NUMBER.Index).Value = CShort(Row.Item("NUMBER"))
                DGVRow.Cells(Me.DGV_FAV_DISTANCE.Index).Value = CBool(Row.Item("IS_FAV_DISTANCE"))
                DGVRow.Cells(Me.DGV_FAV_DISTANCE_WINS.Index).Value = CBool(Row.Item("IS_FAV_DISTANCE_WINS"))
                DGVRow.Cells(Me.DGV_FAV_DISTANCE_PLACES.Index).Value = CBool(Row.Item("IS_FAV_DISTANCE_PLACES"))
                '
                DGVRow.Cells(Me.DGV_FAV_DISTANCE_TRACK.Index).Value = CBool(Row.Item("IS_FAV_DISTANCE_TRACK"))
                DGVRow.Cells(Me.DGV_FAV_DISTANCE_TRACK_WINS.Index).Value = CBool(Row.Item("IS_FAV_DISTANCE_TRACK_WINS"))
                DGVRow.Cells(Me.DGV_FAV_DISTANCE_TRACK_PLACES.Index).Value = CBool(Row.Item("IS_FAV_DISTANCE_TRACK_PLACES"))
                '
                DGVRow.Cells(Me.DGV_FAV_DISTANCE_WEATHER.Index).Value = CBool(Row.Item("IS_FAV_DISTANCE_WEATHER"))
                DGVRow.Cells(Me.DGV_FAV_DISTANCE_WEATHER_WINS.Index).Value = CBool(Row.Item("IS_FAV_DISTANCE_WEATHER_WINS"))
                DGVRow.Cells(Me.DGV_FAV_DISTANCE_WEATHER_PLACES.Index).Value = CBool(Row.Item("IS_FAV_DISTANCE_WEATHER_PLACES"))
                '
                DGVRow.Cells(Me.DGV_GROUP.Index).Value = CBool(Row.Item("IS_FAV_GROUP"))
                DGVRow.Cells(Me.DGV_GROUP_WINS.Index).Value = CBool(Row.Item("IS_FAV_GROUP_WINS"))
                DGVRow.Cells(Me.DGV_GROUP_PLACES.Index).Value = CBool(Row.Item("IS_FAV_GROUP_PLACES"))
                '
                DGVRow.Cells(Me.DGV_GROUP_TRACK.Index).Value = CBool(Row.Item("IS_FAV_GROUP_TRACK"))
                DGVRow.Cells(Me.DGV_GROUP_TRACK_WINS.Index).Value = CBool(Row.Item("IS_FAV_GROUP_TRACK_WINS"))
                DGVRow.Cells(Me.DGV_GROUP_TRACK_PLACES.Index).Value = CBool(Row.Item("IS_FAV_GROUP_TRACK_PLACES"))
                '
                DGVRow.Cells(Me.DGV_GROUP_WEATHER.Index).Value = CBool(Row.Item("IS_FAV_GROUP_WEATHER"))
                DGVRow.Cells(Me.DGV_GROUP_WEATHER_WINS.Index).Value = CBool(Row.Item("IS_FAV_GROUP_WEATHER_WINS"))
                DGVRow.Cells(Me.DGV_GROUP_WEATHER_PLACES.Index).Value = CBool(Row.Item("IS_FAV_GROUP_WEATHER_PLACES"))
                '
                DGVRow.Cells(Me.DGV_NAME.Index).Value = Trim(CStr(Row.Item("NAME")))
                '
                DGV_MAIN.Rows.Add(DGVRow)
            End Using
        End Sub
        Private Sub TSMI_MAIN_COPY_Click(sender As Object, e As EventArgs) Handles TSMI_MAIN_COPY.Click
            Dim DataObject As Windows.Forms.DataObject = Me.DGV_MAIN.GetClipboardContent
            Windows.Forms.Clipboard.SetDataObject(DataObject, True)
            Me.DGV_MAIN.ClearSelection()
        End Sub
        Private Sub DGV_MAIN_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DGV_MAIN.CellContentClick
            If e.ColumnIndex <> Me.DGV_NAME.Index Then Return
            If e.RowIndex < 0 Then Return
            '
            Dim RUNNERNAME As String = CStr(Me.DGV_MAIN.Rows(e.RowIndex).Cells(Me.DGV_NAME.Index).Value.ToString)
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