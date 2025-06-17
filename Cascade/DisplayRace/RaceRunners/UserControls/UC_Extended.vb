Namespace DisplayRace.RaceRunners.UserControls
    Friend Class UC_Extended
        Private MY_MEETINGOADATE As String = Nothing
        Private MY_MEETINGCOUNTRY As String = Nothing
        Private MY_MEETINGTYPE As String = Nothing
        Private MY_CONNECTION As Connection = Nothing
        '
        Private MY_RUNNERRACELIST As UC_RUNNERRACELIST
        Private MY_POPUP As Cascade.UserControls.PopUp
        Friend Sub New(ByVal MeetingOADate As String, ByVal MeetingCountry As String, ByVal MeetingType As String, ByVal Connection As Connection)
            InitializeComponent()
            MY_MEETINGOADATE = MeetingOADate
            MY_MEETINGCOUNTRY = MeetingCountry
            MY_MEETINGTYPE = MeetingType
            MY_CONNECTION = Connection
        End Sub
        Friend Sub Populate(ByVal ROW As Data.DataRow, ByVal DAY As String)
            If DAY <> "0" Then DAY += "_" Else DAY = ""
            Using DGVRow As Windows.Forms.DataGridViewRow = New Windows.Forms.DataGridViewRow
                DGVRow.CreateCells(Me.DGV_MAIN)
                DGVRow.Cells(Me.DGV_NUMBER.Index).Value = CShort(ROW.Item("NUMBER"))
                '
                DGVRow.Cells(Me.DGV_RUNS.Index).Value = CInt(ROW.Item(DAY & "RUNS"))
                '
                DGVRow.Cells(Me.DGV_FP_MIN.Index).Value = CDec(ROW.Item(DAY & "FINISH_POSITION_MIN"))
                DGVRow.Cells(Me.DGV_FP_AVG.Index).Value = CDec(ROW.Item(DAY & "FINISH_POSITION_AVG"))
                DGVRow.Cells(Me.DGV_FP_MAX.Index).Value = CDec(ROW.Item(DAY & "FINISH_POSITION_MAX"))
                '
                DGVRow.Cells(Me.DGV_SMX.Index).Value = CDec(ROW.Item(DAY & "SPEED_MAX"))
                DGVRow.Cells(Me.DGV_SAVG.Index).Value = CDec(ROW.Item(DAY & "SPEED_AVG"))
                DGVRow.Cells(Me.DGV_SMN.Index).Value = CDec(ROW.Item(DAY & "SPEED_MIN"))
                '
                DGVRow.Cells(Me.DGV_DB_MIN.Index).Value = CDec(ROW.Item(DAY & "DISTANCE_BEHIND_MIN"))
                DGVRow.Cells(Me.DGV_DB_AVG.Index).Value = CDec(ROW.Item(DAY & "DISTANCE_BEHIND_AVG"))
                DGVRow.Cells(Me.DGV_DB_MAX.Index).Value = CDec(ROW.Item(DAY & "DISTANCE_BEHIND_MAX"))
                '
                DGVRow.Cells(Me.DGV_WIN.Index).Value = CInt(ROW.Item(DAY & "WINS"))
                DGVRow.Cells(Me.DGV_PLC.Index).Value = CInt(ROW.Item(DAY & "PLACES"))
                '
                DGVRow.Cells(Me.DGV_TREND.Index).Value = CDec(ROW.Item(DAY & "TREND"))
                DGVRow.Cells(Me.DGV_TRENDSTATUS.Index).Value = CInt(ROW.Item(DAY & "TREND_STATUS"))
                '
                DGVRow.Cells(Me.DGV_SMINDAYSAGO.Index).Value = CInt(ROW.Item(DAY & "SPEED_MIN_DAYSAGO"))
                DGVRow.Cells(Me.DGV_SMAXDAYSAGO.Index).Value = CInt(ROW.Item(DAY & "SPEED_MAX_DAYSAGO"))
                '
                If Not IsDBNull(ROW.Item(DAY & "RANK")) Then
                    DGVRow.Cells(Me.DGV_SCORE_RANK.Index).Value = CDec(ROW.Item(DAY & "RANK"))
                Else
                    DGVRow.Cells(Me.DGV_SCORE_RANK.Index).ErrorText = "RANK IS NULL"
                End If
                If Not IsDBNull(ROW.Item(DAY & "RANK_PERCENT")) Then
                    DGVRow.Cells(Me.DGV_SCORE_RANK_PERCENT.Index).Value = CDec(ROW.Item(DAY & "RANK_PERCENT"))
                Else
                    DGVRow.Cells(Me.DGV_SCORE_RANK_PERCENT.Index).ErrorText = "RANK PERCENT IS NULL"
                End If
                If Not IsDBNull(ROW.Item(DAY & "RANK_DIFFERENCE")) Then
                    DGVRow.Cells(Me.DGV_SCORE_RANK_DIFFERENCE.Index).Value = CDec(ROW.Item(DAY & "RANK_DIFFERENCE"))
                Else
                    DGVRow.Cells(Me.DGV_SCORE_RANK_DIFFERENCE.Index).ErrorText = "RANK DIFFERENCE IS NULL"
                End If
                '
                DGVRow.Cells(Me.DGV_NAME.Index).Value = Trim(CStr(ROW.Item("NAME")))
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