Imports System.ComponentModel
Imports Microsoft.VisualBasic.Logging
Public Class FrmMain
    Private ReadOnly CONNECTION As CascadeCommon.Utils.Connection
    Private ReadOnly JOBLIST As Utils.Joblist
    Friend MESSAGES As CascadeCommon.Messages
    Private ReadOnly HTTPCLIENT As Net.Http.HttpClient
    Public Sub New()
        InitializeComponent()
        HTTPCLIENT = New Net.Http.HttpClient()

        MESSAGES = New CascadeCommon.Messages(RTBMessages, My.Settings.LogFolder, My.Settings.ErrorFolder)
        CONNECTION = New CascadeCommon.Utils.Connection(My.Settings.ConnectionString, MESSAGES)

        JOBLIST = New Utils.Joblist(DGV_Jobs, MESSAGES, CONNECTION, HTTPCLIENT)

#If DEBUG Then
        Me.Text += " [DEBUG]"
#End If
    End Sub
    Private Sub FrmMain_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        JOBLIST.Start()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
#Region "    Jobs Context Menu Items "
    Private Sub DeleteJobsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteJobsToolStripMenuItem.Click
        If DGV_Jobs.SelectedRows.Count = 0 Then Return
        If MessageBox.Show("Are you sure you want to delete the selected item(s)?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return

        Cursor = Cursors.WaitCursor
        JOBLIST.StopTimer()

        For Each DGVROW As DataGridViewRow In DGV_Jobs.SelectedRows
            Call JOBLIST.Remove(DGVROW.Cells(0).Value.ToString)
        Next

        JOBLIST.StartTimer()
        Cursor = Cursors.Default

        Activate()
    End Sub
    Private Sub TruncateJobsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TruncateJobsToolStripMenuItem.Click
        If MessageBox.Show("Are you sure you want to truncate the job queue?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return

        Cursor = Cursors.WaitCursor
        JOBLIST.StopTimer()

        Call JOBLIST.Truncate()

        JOBLIST.StartTimer()
        Cursor = Cursors.Default

        Activate()
    End Sub
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        JOBLIST.StopTimer()

        DGV_Jobs.Rows.Clear()
        JOBLIST.Refresh()

        JOBLIST.StartTimer()
        Cursor = Cursors.Default
        Activate()
    End Sub
    Private Sub ContextMenuStripJobs_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStripJobs.Opening
        DeleteJobsToolStripMenuItem.Enabled = JOBLIST.Count > 1
    End Sub
#End Region
    Private Sub DeleteXMLFilesForOADATE(OADate As String)
        If IO.File.Exists(My.Settings.ScheduleFolder & "\" & OADate & "\schedule.xml") Then
            Try
                IO.File.Delete(My.Settings.ScheduleFolder & "\" & OADate & "\schedule.xml")
            Catch ex As Exception
                Call Me.MESSAGES.LogMessages(ex.ToString, Utils.BroadcastTypes.Error)
            End Try
        End If
        If IO.File.Exists(My.Settings.ResultsFolder & "\" & OADate & "\results.xml") Then
            Try
                IO.File.Delete(My.Settings.ScheduleFolder & "\" & OADate & "\results.xml")
            Catch ex As Exception
                Call Me.MESSAGES.LogMessages(ex.ToString, Utils.BroadcastTypes.Error)
            End Try
        End If
    End Sub
#Region "        Processing Menu "
    Private Sub TodayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodayToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        JOBLIST.StopTimer()

        Call DeleteXMLFilesForOADATE(Date.Today.ToOADate.ToString)

        Dim Parameters As String = "DAY=" & Date.Today.ToOADate
        JOBLIST.Add(Utils.Requests.DownloadXMLSchedule, Parameters, False)
        JOBLIST.Add(Utils.Requests.LoadSQLSchedule, Parameters, False)
        JOBLIST.Add(Utils.Requests.LoadStats, Parameters, True)

        Call MessageBox.Show("Request to load todays schedule has been sent to the server.", "Request Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        JOBLIST.StartTimer()
        Cursor = Cursors.Default
    End Sub
    Private Sub YesterdayToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles YesterdayToolStripMenuItem1.Click
        Cursor = Cursors.WaitCursor
        JOBLIST.StopTimer()

        Dim OADATE As String = (Date.Today.ToOADate - 1).ToString
        Dim Parameters As String = "DAY=" & OADATE

        Call DeleteXMLFilesForOADATE(OADATE)

        JOBLIST.Add(Utils.Requests.DownloadXMLSchedule, Parameters, False)
        JOBLIST.Add(Utils.Requests.LoadSQLSchedule, Parameters, False)
        JOBLIST.Add(Utils.Requests.LoadStats, Parameters, False)
        JOBLIST.Add(Utils.Requests.DownloadXMLResults, Parameters, False)
        JOBLIST.Add(Utils.Requests.LoadSQLResults, Parameters, True)

        Call MessageBox.Show("Request to load Yesterday has been sent to the server.", "Request Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        JOBLIST.StartTimer()
        Cursor = Cursors.Default
    End Sub
    Private Sub DownloadXMLOnlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadXMLOnlyToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        JOBLIST.StopTimer()

        Using NewSDTR As New CascadeCommon.FrmSelectRange
            If NewSDTR.ShowDialog(Me) <> DialogResult.Cancel Then
                Dim Start As Date = NewSDTR.DateTimePickerFrom.Value
                Dim Finish As Date = NewSDTR.DateTimePickerTo.Value

                Dim WriteXMLFile As Boolean = False

                ' Basically we are doing a bulk insert, save the xmlfile once we get to the end of the selection.
                For X As Integer = Start.ToOADate To Finish.ToOADate
                    Dim Parameters As String = "DAY=" & X.ToString
                    JOBLIST.Add(Utils.Requests.DownloadXMLSchedule, Parameters, WriteXMLFile)
                    JOBLIST.Add(Utils.Requests.DownloadXMLResults, Parameters, WriteXMLFile)

                    If X >= (Finish.ToOADate - 1) Then WriteXMLFile = True
                    Application.DoEvents()
                Next X

                Call MessageBox.Show("Request to Download XML for: " & FormatDateTime(Start, DateFormat.GeneralDate) & " to: " & FormatDateTime(Finish, DateFormat.GeneralDate) & " has been sent to the server.", "Request Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using

        JOBLIST.StartTimer()
        Cursor = Cursors.Default
    End Sub
    Private Sub XMLToDatabaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XMLToDatabaseToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        JOBLIST.StopTimer()

        Using NewSDTR As New CascadeCommon.FrmSelectRange
            If NewSDTR.ShowDialog(Me) <> DialogResult.Cancel Then
                Dim Start As Date = NewSDTR.DateTimePickerFrom.Value
                Dim Finish As Date = NewSDTR.DateTimePickerTo.Value
                Dim REBUILDINDEXCOUNT As Integer = 0
                Dim WriteXMLFile As Boolean = False

                ' Basically we are doing a bulk insert, save the xmlfile once we get to the end of the selection.
                For X As Integer = Start.ToOADate To Finish.ToOADate
                    Dim Parameters As String = "DAY=" & X
                    JOBLIST.Add(Utils.Requests.LoadSQLSchedule, Parameters, WriteXMLFile)
                    JOBLIST.Add(Utils.Requests.LoadSQLResults, Parameters, WriteXMLFile)

                    If REBUILDINDEXCOUNT = 32 Then
                        JOBLIST.Add(Utils.Requests.RebuildIndexes, Parameters)
                        REBUILDINDEXCOUNT = 0
                    End If
                    REBUILDINDEXCOUNT += 1

                    If X >= (Finish.ToOADate - 1) Then WriteXMLFile = True

                    Application.DoEvents()
                Next X

                Call MessageBox.Show("Request to load data from: " & FormatDateTime(Start, DateFormat.GeneralDate) & " to: " & FormatDateTime(Finish, DateFormat.GeneralDate) & " has been sent to the server.", "Request Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using

        JOBLIST.StartTimer()
        Cursor = Cursors.Default
    End Sub
    Private Sub XMLToCBCreateStatsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles XMLToCBCreateStatsToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        JOBLIST.StopTimer()

        Using NewSDTR As New CascadeCommon.FrmSelectRange
            If NewSDTR.ShowDialog(Me) <> DialogResult.Cancel Then
                Dim Start As Date = NewSDTR.DateTimePickerFrom.Value
                Dim Finish As Date = NewSDTR.DateTimePickerTo.Value
                Dim REBUILDINDEXCOUNT As Integer = 0
                Dim WriteXMLFile As Boolean = False

                ' Basically we are doing a bulk insert, save the xmlfile once we get to the end of the selection.
                For X As Integer = Start.ToOADate To Finish.ToOADate
                    Dim Parameters As String = "DAY=" & X
                    JOBLIST.Add(Utils.Requests.LoadSQLSchedule, Parameters, WriteXMLFile)
                    JOBLIST.Add(Utils.Requests.LoadStats, Parameters, WriteXMLFile)
                    JOBLIST.Add(Utils.Requests.LoadSQLResults, Parameters, WriteXMLFile)

                    If REBUILDINDEXCOUNT = 32 Then
                        JOBLIST.Add(Utils.Requests.RebuildIndexes, Parameters)
                        REBUILDINDEXCOUNT = 0
                    End If
                    REBUILDINDEXCOUNT += 1

                    If X >= (Finish.ToOADate - 1) Then WriteXMLFile = True

                    Application.DoEvents()
                Next X

                Call MessageBox.Show("Request to load data from: " & FormatDateTime(Start, DateFormat.GeneralDate) & " to: " & FormatDateTime(Finish, DateFormat.GeneralDate) & " has been sent to the server.", "Request Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using

        JOBLIST.StartTimer()
        Cursor = Cursors.Default
    End Sub
    Private Sub CreateStatisticsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateStatisticsToolStripMenuItem.Click
        Cursor = Cursors.WaitCursor
        JOBLIST.StopTimer()

        Using NewSDTR As New CascadeCommon.FrmSelectRange
            If NewSDTR.ShowDialog(Me) <> DialogResult.Cancel Then
                Dim Start As Date = NewSDTR.DateTimePickerFrom.Value
                Dim Finish As Date = NewSDTR.DateTimePickerTo.Value
                Dim REBUILDINDEXCOUNT As Integer = 0
                Dim WriteXMLFile As Boolean = False

                ' Basically we are doing a bulk insert, save the xmlfile once we get to the end of the selection.
                For X As Integer = Start.ToOADate To Finish.ToOADate
                    Dim Parameters As String = "DAY=" & X
                    JOBLIST.Add(Utils.Requests.LoadStats, Parameters, WriteXMLFile)

                    If REBUILDINDEXCOUNT = 32 Then
                        JOBLIST.Add(Utils.Requests.RebuildIndexes, Parameters)
                        REBUILDINDEXCOUNT = 0
                    End If
                    REBUILDINDEXCOUNT += 1

                    If X >= (Finish.ToOADate - 1) Then WriteXMLFile = True

                    Application.DoEvents()
                Next X

                Call MessageBox.Show("Request to load data from: " & FormatDateTime(Start, DateFormat.GeneralDate) & " to: " & FormatDateTime(Finish, DateFormat.GeneralDate) & " has been sent to the server.", "Request Complete!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End Using

        JOBLIST.StartTimer()
        Cursor = Cursors.Default
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        JOBLIST.StopTimer()
        Using NewSDTR As New CascadeCommon.FrmSelectRange
            If NewSDTR.ShowDialog(Me) <> DialogResult.Cancel Then
                Dim Start As Date = NewSDTR.DateTimePickerFrom.Value
                Dim Finish As Date = NewSDTR.DateTimePickerTo.Value
                Using NewModelRun As New CascadeModels.EntryPoint(Me.CONNECTION.String, Me.MESSAGES, True, Start.ToOADate.ToString, Finish.ToOADate.ToString)
                    Call NewModelRun.Start()
                End Using
            End If
        End Using
        JOBLIST.StartTimer()
    End Sub
    Private Sub LiveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiveToolStripMenuItem.Click
        JOBLIST.StopTimer()
        Using NewSDTR As New CascadeCommon.FrmSelectRange
            If NewSDTR.ShowDialog(Me) <> DialogResult.Cancel Then
                Dim Start As Date = NewSDTR.DateTimePickerFrom.Value
                Dim Finish As Date = NewSDTR.DateTimePickerTo.Value
                Using NewModelRun As New CascadeModels.EntryPoint(Me.CONNECTION.String, Me.MESSAGES, False, Start.ToOADate.ToString, Finish.ToOADate.ToString)
                    Call NewModelRun.Start()
                End Using
            End If
        End Using
        JOBLIST.StartTimer()
    End Sub
#End Region
End Class
