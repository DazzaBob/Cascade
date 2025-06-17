Namespace DisplayRace.RaceRunners
    Friend NotInheritable Class UC_DISTANCE_THEO
        Private MY_MEETING_OADATE As String
        Private MY_MEETING_NUMBER As String
        Private MY_MEETING_COUNTRY As String
        Private MY_MEETING_TYPE As String
        Private MY_RACE_NUMBER As String
        Private MY_CONNECTION As Connection
        '
        Private MY_RRL As UC_RUNNERRACELIST
        Private MY_POPUP As Cascade.UserControls.PopUp
        '
        Private UC_FAVOURITES As UserControls.UC_Favourites = Nothing
        Private UC_90 As UserControls.UC_Extended = Nothing
        Private UC_180 As UserControls.UC_Extended = Nothing
        Private UC_270 As UserControls.UC_Extended = Nothing
        Private UC_365 As UserControls.UC_Extended = Nothing
        Friend Sub New()
            InitializeComponent()
        End Sub
        Friend Sub New(ByVal Connection As Connection, ByVal MEETING_OADATE As String, ByVal MEETING_NUMBER As String, ByVal MEETING_COUNTRY As String, ByVal MEETING_TYPE As String, ByVal RACE_NUMBER As String)
            Me.New()
            '
            MY_CONNECTION = Connection
            MY_MEETING_OADATE = MEETING_OADATE
            MY_MEETING_NUMBER = MEETING_NUMBER
            MY_MEETING_COUNTRY = MEETING_COUNTRY
            MY_MEETING_TYPE = MEETING_TYPE
            MY_RACE_NUMBER = RACE_NUMBER
            '
            UC_FAVOURITES = New UserControls.UC_Favourites(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_CONNECTION) : UC_FAVOURITES.Dock = DockStyle.Fill
            UC_90 = New UserControls.UC_Extended(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_CONNECTION) : UC_90.Dock = DockStyle.Fill
            UC_180 = New UserControls.UC_Extended(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_CONNECTION) : UC_180.Dock = DockStyle.Fill
            UC_270 = New UserControls.UC_Extended(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_CONNECTION) : UC_270.Dock = DockStyle.Fill
            UC_365 = New UserControls.UC_Extended(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_CONNECTION) : UC_365.Dock = DockStyle.Fill
            '
            Me.TP_FAVOURITES.Controls.Add(UC_FAVOURITES)
            Me.TP_90DAYS.Controls.Add(UC_90)
            Me.TP_180DAYS.Controls.Add(UC_180)
            Me.TP_270DAYS.Controls.Add(UC_270)
            Me.TP_365DAYS.Controls.Add(UC_365)
        End Sub
        Private Sub ME_Load(sender As Object, e As EventArgs) Handles Me.Load
            For Each ENTRY_ROW As Data.DataRow In StoredProcedures.JoinedDataTable(MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_RACE_NUMBER, "DISTANCE_THEO", MY_CONNECTION).Select("")
                Using DGVRow As Windows.Forms.DataGridViewRow = New Windows.Forms.DataGridViewRow
                    DGVRow.CreateCells(Me.DGV_MAIN_INFORMATION)
                    '
                    DGVRow.Cells(Me.DGV_NUMBER.Index).Value = CShort(ENTRY_ROW.Item("NUMBER"))
                    '
                    DGVRow.Cells(Me.DGV_LASTRAN.Index).Value = CInt(ENTRY_ROW.Item("LAST_RAN"))
                    DGVRow.Cells(Me.DGV_LAST_SPEED.Index).Value = CDec(ENTRY_ROW.Item("LAST_SPEED"))
                    DGVRow.Cells(Me.DGV_LAST_DISTANCEBEHIND.Index).Value = CDec(ENTRY_ROW.Item("LAST_DISTANCE_BEHIND"))
                    '
                    DGVRow.Cells(Me.DGV_LAST_PREVIOUS_RAN.Index).Value = CInt(ENTRY_ROW.Item("LAST_PREVIOUS_RAN"))
                    DGVRow.Cells(Me.DGV_LAST_PREVIOUS_SPEED.Index).Value = CDec(ENTRY_ROW.Item("LAST_PREVIOUS_SPEED"))
                    DGVRow.Cells(Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.Index).Value = CDec(ENTRY_ROW.Item("LAST_PREVIOUS_DISTANCE_BEHIND"))
                    DGVRow.Cells(Me.DGV_NAME.Index).Value = Trim(CStr(ENTRY_ROW.Item("NAME")))
                    '
                    DGV_MAIN_INFORMATION.Rows.Add(DGVRow)
                End Using
                '
                Call PopulateInformationDetails(ENTRY_ROW)
            Next ENTRY_ROW
        End Sub
        Private Sub PopulateInformationDetails(ByVal ROW As Data.DataRow)
            Call UC_FAVOURITES.Populate(ROW)
            Call UC_90.Populate(ROW, "90")
            Call UC_180.Populate(ROW, "180")
            Call UC_270.Populate(ROW, "270")
            Call UC_365.Populate(ROW, "0")
        End Sub
        Private Sub CreateAndOpenRunnerRaceListPopUp(ByVal RUNNERNAME As String)
            Me.Cursor = Cursors.WaitCursor
            '
            MY_RRL = New UC_RUNNERRACELIST(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, RUNNERNAME, MY_CONNECTION)
            MY_RRL.Dock = DockStyle.Fill
            '
            MY_POPUP = New Cascade.UserControls.PopUp
            MY_POPUP.Text = "Runner Race List (" & RUNNERNAME & ")"
            MY_POPUP.Size = New Size(1024, 768)
            MY_POPUP.WindowState = FormWindowState.Maximized
            MY_POPUP.Controls.Add(MY_RRL)
            '
            MY_POPUP.Show(Me)
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub DGV_MAIN_INFORMATION_CellContentClick(sender As Object, e As Windows.Forms.DataGridViewCellEventArgs) Handles DGV_MAIN_INFORMATION.CellContentClick
            If e.ColumnIndex <> Me.DGV_NAME.Index Then Return
            Dim RUNNERNAME As String = CStr(Me.DGV_MAIN_INFORMATION.Rows(e.RowIndex).Cells(Me.DGV_NAME.Index).Value.ToString)
            Call CreateAndOpenRunnerRaceListPopUp(RUNNERNAME)
        End Sub
        Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CMS_MI_TSMI_COPY.Click
            Dim DataObject As Windows.Forms.DataObject = Me.DGV_MAIN_INFORMATION.GetClipboardContent
            Windows.Forms.Clipboard.SetDataObject(DataObject, True)
            Me.DGV_MAIN_INFORMATION.ClearSelection()
        End Sub
    End Class
End Namespace