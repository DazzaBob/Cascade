Namespace UI
    Friend NotInheritable Class FrmServer
        Private IsProcessing As Boolean = False

        Private MY_JOBLIST As Joblist

        Private WithEvents MY_MESSAGESTIMER As System.Timer
        '
        Private MY_POPUP As UserControls.PopUp
        Friend Shared Connection As Connection
        Friend Sub New()
            InitializeComponent()
            '
            Me.MY_JOBLIST = New Joblist(Me.DGV_JOBLIST)

            Connection = New Connection()
#If Not DEBUG Then
            Me.TSMI_ToolsEraseAllData.Visible = False
#End If
        End Sub
        Private Sub FORM_SERVERUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            MY_MESSAGESTIMER.Stop() : MY_MESSAGESTIMER.Dispose()
        End Sub
        Private Sub ME_Load(sender As Object, e As EventArgs) Handles Me.Load
            Call Messages.InMemory.Truncate()
            Me.TSPBMain.Visible = False
        End Sub
        ''' <summary>
        ''' Start the timers once we have prepared the form and shown it... We only want to see things once the form is ready.
        ''' </summary>
        ''' <param name="sender"></param>
        ''' <param name="e"></param>
        ''' <remarks></remarks>
        Private Sub FORM_SERVERUI_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Me.MY_JOBLIST.Start()

            MY_MESSAGESTIMER = New Timer
            MY_MESSAGESTIMER.Interval = 1000I
            MY_MESSAGESTIMER.Start()
        End Sub
        Private Sub TSB_PROCESS_JOBS_Click(sender As Object, e As EventArgs) Handles TSB_PROCESS_JOBS.Click
            If IsProcessing Then Return
            Me.Cursor = Cursors.AppStarting
            IsProcessing = True : Me.TSPBMain.Visible = True : Me.TSSLMain.Text = "Processing Jobs..." : Application.DoEvents()
            '
            Call ProcessJobs.Start(Me)
            '
            Me.TSPBMain.Visible = False : IsProcessing = False : Me.TSSLMain.Text = "Ready" : Application.DoEvents()
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TSDDB_SCHEDULE_DropDownOpening(sender As Object, e As EventArgs) Handles TSDDB_SCHEDULE.DropDownOpening
            Me.TSMI_ScheduleLoadToday.Text = "Load Today (" & FormatDateTime(Today, DateFormat.LongDate) & ")"
        End Sub
#Region "        Messages "
        Private Sub MY_MESSAGESTIMER_Tick(sender As Object, e As EventArgs) Handles MY_MESSAGESTIMER.Tick
            MY_MESSAGESTIMER.Stop()
            '
            Dim X As Int32 = 0, INClause As String = Nothing
            Me.Cursor = Cursors.WaitCursor
            '
            For Each ROW As Data.DataRow In Messages.InMemory.GetDataTable.Select("", "DATETIME ASC")
                Using DGVRow As New DataGridViewRow
                    DGVRow.CreateCells(DGV_MESSAGES)
                    '
                    DGVRow.Cells(DGV_MESSAGES_DATETIME.Index).Value = FormatDateTime(CDate(ROW.Item("DATETIME")), DateFormat.LongTime)
                    Dim Message As String = ROW.Item("MESSAGE").ToString
                    If Message.ToUpperInvariant.Contains("LOG: ") Then
                        DGVRow.Cells(DGV_MESSAGES_IMAGE.Index).Value = "NFO"
                    Else
                        DGVRow.Cells(DGV_MESSAGES_IMAGE.Index).Value = "ERR"
                    End If
                    Message = Strings.Mid(Message, 6)
                    Dim Thread As String = Strings.Left(Message, InStr(Message, ")"))
                    Thread = Replace(Thread, "Thread (", "")
                    Thread = Replace(Thread, ")", "")
                    Message = Replace(Message, "Thread " & Thread & " ", "")
                    '
                    DGVRow.Cells(DGV_MESSAGES_THREAD.Index).Value = Thread
                    Message = Strings.Mid(Message, InStr(Message, ") ") + 2)
                    DGVRow.Cells(DGV_MESSAGES_MESSAGE.Index).Value = Message
                    '
                    DGV_MESSAGES.Rows.Insert(0, DGVRow)
                End Using
                '
                INClause += CStr(ROW.Item("ID")) & ", "
                '
                If DGV_MESSAGES.RowCount >= 150 Then
                    DGV_MESSAGES.Rows.RemoveAt(DGV_MESSAGES.RowCount - 1)
                End If
                X += 1 : If X > 9 Then Application.DoEvents() : X = 0
                ' do nothing, go to the next record.
            Next ROW
            '
            If Not INClause Is Nothing Then
                INClause = Strings.Left(INClause, Len(INClause) - 2)
                Call Messages.InMemory.Delete(INClause)
            End If
            Me.Cursor = Cursors.Default
            '
            If Not MY_MESSAGESTIMER Is Nothing Then MY_MESSAGESTIMER.Start()
        End Sub
        Private Sub CMS_MESSAGES_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CMS_MESSAGES.Opening
            If DGV_MESSAGES.RowCount > 0 Then
                CMS_MESSAGES_CLEARLIST.Enabled = True
            Else
                CMS_MESSAGES_CLEARLIST.Enabled = False
            End If
        End Sub
        Private Sub CMS_MESSAGES_CLEARLIST_Click(sender As Object, e As EventArgs) Handles CMS_MESSAGES_CLEARLIST.Click
            Me.Cursor = Cursors.WaitCursor
            Me.DGV_MESSAGES.Rows.Clear()
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub CMS_MESSAGES_REFERSH_Click(sender As Object, e As EventArgs) Handles CMS_MESSAGES_REFERSH.Click
            Me.Cursor = Cursors.WaitCursor
            Me.MY_MESSAGESTIMER.Stop() : Me.MY_MESSAGESTIMER.Start()
            Call Me.MY_MESSAGESTIMER_Tick(sender, e)
            Me.Cursor = Cursors.Default
        End Sub
#End Region
#Region "        Job List "
        Private Sub CMS_JOBLIST_DELETE_Click(sender As Object, e As EventArgs) Handles CMS_JOBLIST_DELETE.Click
            If Me.DGV_JOBLIST.SelectedRows.Count = 0 Then Return
            If MessageBox.Show("Are you sure you want to delete the selected item(s)?", AreYouSure, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return

            Me.Cursor = Cursors.WaitCursor

            For Each DGVROW As DataGridViewRow In Me.DGV_JOBLIST.SelectedRows
                Call Me.MY_JOBLIST.Remove(DGVROW.Cells(0).Value.ToString)
            Next

            Me.Cursor = Cursors.Default
        End Sub
        Private Sub CMS_JOBLIST_CLEAR_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CMS_JOBLIST_CLEAR.Click
            If MessageBox.Show("Are you sure you want to clear the queue?", AreYouSure, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            Call Me.MY_JOBLIST.Truncate()
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub CMS_JOBLIST_REFRESH_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CMS_JOBLIST_REFRESH.Click
            Me.DGV_JOBLIST.Rows.Clear()
            Me.MY_JOBLIST.Start()
        End Sub
#End Region
#Region "        Menu Strip Items "
        Private Sub TSMI_ToolsEraseAllData_Click(sender As Object, e As EventArgs) Handles TSMI_ToolsEraseAllData.Click
            If MessageBox.Show("Are you sure you want to clear all the data in the database?", AreYouSure, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.No Then Return
            If MessageBox.Show("Are you REALLY sure you want to clear all the data in the database?", "Are you REALLY sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.No Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            Dim CMDTEXT As String = "EXEC SP_CLEAR_DATABASE"
            FrmServer.Connection.Execute(CMDTEXT)
            Me.Cursor = Cursors.Default
            '
            MessageBox.Show("Clear Database Complete!", "Clear Database Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        End Sub
        Private Sub TSMI_ScheduleLoadALL_Click(sender As Object, e As EventArgs) Handles TSMI_ScheduleLoadAll.Click
            If MessageBox.Show("Are you sure you want to ""Load the All Data??""", AreYouSure, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.No Then Return
            '
            Dim Start As Date = Date.FromOADate(39765)
            Dim Finish As Date = Date.Today
            '
            Me.Cursor = Cursors.WaitCursor
            Call LogThreadDetails(Threading.Thread.CurrentThread)
            '
            Dim RebuildIndexCount As Int32 = 0
            For X As Int32 = CInt(Start.ToOADate) To CInt(Finish.ToOADate)
                Call ProcessJobs.AddToJobList("USER", "1", CStr(Requests.DownloadDay), "DAY=" & CStr(X))
                If RebuildIndexCount = 32 Then
                    Call ProcessJobs.AddToJobList("USER", "1", CStr(Requests.RebuildIndexes), "DAY=" & CStr(X))
                    RebuildIndexCount = 0
                End If
                RebuildIndexCount += 1
            Next X
            Me.Cursor = Cursors.Default
            '
            MessageBox.Show("Request to load data from: " & FormatDateTime(Start, DateFormat.GeneralDate) & " to: " & FormatDateTime(Finish, DateFormat.GeneralDate) & " has been sent to the server.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        End Sub
        Private Sub TSMI_ScheduleLoadSpecificRange_Click(sender As Object, e As EventArgs) Handles TSMI_ScheduleLoadSpecificRange.Click
            Dim DialogResult As DialogResult = Windows.Forms.DialogResult.No
            Using Question As New UI.Messages.FrmQuestion("Are you sure?", "Are you sure you want to ""Load the Schedule for the date range?""")
                DialogResult = Question.ShowDialog(Me)
            End Using
            If DialogResult <> Windows.Forms.DialogResult.Yes Then Return
            '
            Dim Start As Date = Nothing
            Dim Finish As Date = Nothing
            '
            Me.Cursor = Cursors.WaitCursor
            Using NewSDTR As New UserControls.SelectDayToLoad
                If NewSDTR.ShowDialog(Me) <> Windows.Forms.DialogResult.Cancel Then
                    Dim Parameters As String = ""
                    Start = NewSDTR.MonthCalendar1.SelectionRange.Start
                    Finish = NewSDTR.MonthCalendar1.SelectionRange.End
                    Dim REBUILDINDEXCOUNT As Int32 = 0
                    For X As Int32 = CInt(Start.ToOADate) To CInt(Finish.ToOADate)
                        Parameters = "DAY=" & CStr(X)
                        Call ProcessJobs.AddToJobList("USER", "2", CStr(Requests.DownloadDay), Parameters)
                        If REBUILDINDEXCOUNT = 32 Then
                            Call ProcessJobs.AddToJobList("USER", "2", CStr(Requests.RebuildIndexes), Parameters)
                            REBUILDINDEXCOUNT = 0
                        End If
                        REBUILDINDEXCOUNT += 1
                        Application.DoEvents()
                    Next X
                End If
            End Using
            Me.Cursor = Cursors.Default
            '
            Using Information As New UI.Messages.FrmInformation("Request Complete!", "Request to load data from: " & FormatDateTime(Start, DateFormat.GeneralDate) & " to: " & FormatDateTime(Finish, DateFormat.GeneralDate) & " has been sent to the server.")
                Information.ShowDialog(Me)
            End Using
        End Sub
        Private Sub TSMI_ScheduleLoadToday_Click(sender As Object, e As EventArgs) Handles TSMI_ScheduleLoadToday.Click
            If MessageBox.Show("Are you sure you want to ""Load the Schedule?""", AreYouSure, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.No Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            Dim Parameters As String = "DAY=" & CStr(CInt(Date.Today.ToOADate))
            Call ProcessJobs.AddToJobList("USER", "1", CStr(Requests.DownloadSchedule), Parameters)
            Call ProcessJobs.AddToJobList("USER", "2", CStr(Requests.RerunModels), Parameters)
            Me.Cursor = Cursors.Default
            '
            MessageBox.Show("Request to ""Load Schedule"" has been sent to the server.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        End Sub
        Private Sub TSMI_ScheduleLoadYesterday_Click(sender As Object, e As EventArgs) Handles TSMI_ScheduleLoadYesterday.Click
            If MessageBox.Show("Are you sure you want to load yesterdays results?", AreYouSure, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.No Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            Dim Parameters As String = "DAY=" & Date.Today.ToOADate - 1.0#.ToString(InvariantCulture)
            Call ProcessJobs.AddToJobList("USER", "1", CStr(Requests.DownloadYesterdaysResults), Parameters)
            '
            Me.Cursor = Cursors.Default
            MessageBox.Show("Request to ""Load Yesterdays Results"" has been sent to the server.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        End Sub
        Private Sub TSMI_LoadYesterdaysResultsForce_Click(sender As Object, e As EventArgs) Handles TSMI_LoadYesterdaysResultsForce.Click
            If MessageBox.Show("Are you sure you want to Force the of load yesterdays results?", AreYouSure, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.No Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            Dim Parameters As String = "DAY=" & Date.Today.ToOADate - 1.0#.ToString(InvariantCulture)
            Call ProcessJobs.AddToJobList("USER", "1", CStr(Requests.DownloadYesterdaysResultsForce), Parameters)
            '
            Me.Cursor = Cursors.Default
            MessageBox.Show("Request to ""Force, Load Yesterdays Results"" has been sent to the server.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        End Sub
        Private Sub TSMI_ScheduleDownloadOnly_Click(sender As Object, e As EventArgs) Handles TSMI_ScheduleDownloadOnly.Click
            If MessageBox.Show("Are you sure you want to ""Only download the Xml cache for the date range?""", AreYouSure, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.No Then Return
            '
            Dim Start As Date = Nothing
            Dim Finish As Date = Nothing
            '
            Me.Cursor = Cursors.WaitCursor
            Using NewSDTR As New UserControls.SelectDayToLoad
                If NewSDTR.ShowDialog(Me) <> Windows.Forms.DialogResult.Cancel Then
                    Start = NewSDTR.MonthCalendar1.SelectionRange.Start
                    Finish = NewSDTR.MonthCalendar1.SelectionRange.End
                    '
                    For X As Int32 = CInt(Start.ToOADate) To CInt(Finish.ToOADate)
                        Using XMLCache As New Cascade.Processing.XmlCache("schedule", CStr(X))
                            Dim XML As String = XMLCache.GetXml()
                        End Using
                        ' 
                        Threading.Thread.Sleep(1000)
                        '
                        Using XMLCache As New Cascade.Processing.XmlCache("results", CStr(X))
                            Dim XML As String = XMLCache.GetXml()
                        End Using
                        '
                        Application.DoEvents()
                    Next X
                End If
            End Using
            Me.Cursor = Cursors.Default
            '
            MessageBox.Show("Request to Only Download Xml from: " & FormatDateTime(Start, DateFormat.GeneralDate) & " to: " & FormatDateTime(Finish, DateFormat.GeneralDate) & " has been sent to the server.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        End Sub
        Private Sub TSMI_ModelRunAllRaces_Click(sender As Object, e As EventArgs) Handles TSMI_ModelRunAllRaces.Click
            If MessageBox.Show("Are you sure you want to Re-Run the models for all races?", AreYouSure, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.No Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            Call ProcessJobs.AddToJobList("USER", "2", CStr(Requests.RerunModelsAll), "DAY=0")
            Me.Cursor = Cursors.Default
            '
            MessageBox.Show("Request to Re-Run models for all races has been sent to the server.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
        End Sub
        Private Sub TSMI_ModelRunSpecificRange_Click(sender As Object, e As EventArgs) Handles TSMI_ModelRunSpecificRange.Click
            If MessageBox.Show("Are you sure you want to Run Models over the date range?""", AreYouSure, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = Windows.Forms.DialogResult.No Then Return
            '
            Using NewSDTR As New UserControls.SelectDayToLoad
                If NewSDTR.ShowDialog(Me) <> Windows.Forms.DialogResult.Cancel Then
                    Me.Cursor = Cursors.WaitCursor
                    Dim Parameters As String = ""
                    For X As Int32 = CInt(NewSDTR.MonthCalendar1.SelectionRange.Start.ToOADate) To CInt(NewSDTR.MonthCalendar1.SelectionRange.End.ToOADate)
                        Parameters = "DAY=" & CStr(X)
                        ' Priority 3 Job. (Lowest)
                        Call ProcessJobs.AddToJobList("USER", "3", CStr(Requests.RerunModels), Parameters)
                    Next X
                    '
                    Me.Cursor = Cursors.Default
                    MessageBox.Show("Request to Run Models Over the date range"" has been sent to the server.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                End If
            End Using
        End Sub
        Private Sub TSMI_ToolsRebuildIndexes_Click(sender As Object, e As EventArgs) Handles TSMI_ToolsRebuildIndexes.Click
            Me.Cursor = Cursors.WaitCursor
            Call ProcessJobs.AddToJobList("USER", "1", CStr(Requests.RebuildIndexes), "DAY=" & CStr(Today.ToOADate))
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TSMI_ToolsMappings_Click(sender As Object, e As EventArgs) Handles TSMI_ToolsMappings.Click
            Using UC_VENUE_MAPPINGS As New ServerUI.Mappings.UC_VENUE_MAPPINGS()
                UC_VENUE_MAPPINGS.Dock = DockStyle.Fill
                '
                MY_POPUP = New UserControls.PopUp
                MY_POPUP.StartPosition = FormStartPosition.CenterParent
                MY_POPUP.Text = "REMAP VENUES"
                MY_POPUP.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
                MY_POPUP.Size = New Size(800, 600)
                MY_POPUP.Controls.Add(UC_VENUE_MAPPINGS)
                MY_POPUP.ShowDialog(Me)
            End Using
        End Sub
#End Region
    End Class
End Namespace