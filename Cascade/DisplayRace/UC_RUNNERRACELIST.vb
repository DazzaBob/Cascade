Imports System.Windows.Forms
Namespace DisplayRace
    Friend NotInheritable Class UC_RUNNERRACELIST
        Private MY_CONNECTION As Connection
        Private MY_MEETING_OADATE As String = Nothing
        Private MY_MEETING_INFO_COUNTRY As String
        Private MY_MEETING_TYPE As String = Nothing
        Private MY_NAME As String = Nothing
        '
        Private MY_DISPLAYRACE As UserControls.UC_DISPLAYRACE
        Private MY_POPUP As UserControls.PopUp
        Friend Sub New()
            InitializeComponent()
        End Sub
        Friend Sub New(ByVal MEETING_OADATE As String, ByVal MEETING_INFO_COUNTRY As String, ByVal MEETING_TYPE As String, ByVal RUNNERNAME As String, ByVal Connection As Connection)
            Me.New()
            '
            MY_MEETING_OADATE = MEETING_OADATE
            MY_MEETING_INFO_COUNTRY = MEETING_INFO_COUNTRY
            MY_MEETING_TYPE = MEETING_TYPE
            MY_NAME = RUNNERNAME
            MY_CONNECTION = Connection
        End Sub
        Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
            Me.DGV.Rows.Clear()
            '
            Dim RowCounter As Integer = 1, EventCounter As Integer = 1
            Dim CMDTEXT As String = "EXEC SP_DISPLAYRACE_UC_RUNNERRACELIST @MEETING_INFO_OADATE=" & MY_MEETING_OADATE & ", @MEETING_INFO_COUNTRY=N'" & MY_MEETING_INFO_COUNTRY & "', @MEETING_INFO_TYPE=N'" & MY_MEETING_TYPE & "', @NAME=N'" & MY_NAME & "'"
            For Each ROW As Data.DataRow In MY_CONNECTION.GetDataTable(CMDTEXT).Select("")
                Using DGVRow As New DataGridViewRow
                    DGVRow.CreateCells(DGV)
                    DGVRow.HeaderCell.Value = CStr(RowCounter)
                    DGVRow.Cells(Me.DGV_RACENAME.Index).Value = "M" & CStr(ROW.Item("MEETING_INFO_NUMBER")) & " R" & CStr(ROW.Item("RACE_INFO_NUMBER"))
                    DGVRow.Cells(Me.DGV_RACENAME.Index).Tag = CStr(ROW.Item("MEETING_INFO_OADATE")) & "|" & CStr(ROW.Item("MEETING_INFO_NUMBER")) & "|" & CStr(ROW.Item("COUNTRY")) & "|" & CStr(ROW.Item("TYPE")) & "|" & CStr(ROW.Item("RACE_INFO_NUMBER"))
                    '
                    DGVRow.Cells(Me.DGV_DATE.Index).Value = Date.FromOADate(CDbl(ROW.Item("NORM_TIME")))
                    'DGVRow.Cells(Me.DGV_CLASS.Index).Value = CInt(ROW.Item("CLASS"))
                    DGVRow.Cells(Me.DGV_BARRIER.Index).Value = CShort(ROW.Item("BARRIER"))
                    DGVRow.Cells(Me.DGV_VENUE.Index).Value = ROW.Item("VENUE").ToString
                    DGVRow.Cells(Me.DGV_LENGTH.Index).Value = CInt(ROW.Item("RACE_INFO_LENGTH"))
                    DGVRow.Cells(Me.DGV_WEATHER.Index).Value = ROW.Item("WEATHER").ToString
                    DGVRow.Cells(Me.DGV_TRACK.Index).Value = ROW.Item("TRACK").ToString
                    DGVRow.Cells(Me.DGV_FINISH_TIME.Index).Value = CDec(ROW.Item("RESULT_TIME"))
                    DGVRow.Cells(Me.DGV_FINISHPOSITION.Index).Value = CShort(ROW.Item("RESULT_FINISH_POSITION"))
                    DGVRow.Cells(Me.DGV_DISTANCE_BEHIND.Index).Value = CDec(ROW.Item("RESULT_DISTANCE_BEHIND"))
                    DGVRow.Cells(Me.DGV_SPEED.Index).Value = CDec(ROW.Item("RESULT_SPEED"))
                    DGVRow.Cells(Me.DGV_WINS.Index).Value = CDec(ROW.Item("RESULT_POOL_WIN"))
                    DGVRow.Cells(Me.DGV_PLACES.Index).Value = CDec(ROW.Item("RESULT_POOL_PLACE"))
                    DGVRow.Cells(Me.DGV_THEO_TIME.Index).Value = CDec(ROW.Item("RESULT_THEO_TIME"))
                    DGVRow.Cells(Me.DGV_THEO_FINISH_POSITION.Index).Value = CShort(ROW.Item("RESULT_THEO_FINISH_POSITION"))
                    DGVRow.Cells(Me.DGV_THEO_SPEED.Index).Value = CDec(ROW.Item("RESULT_THEO_SPEED"))
                    DGVRow.Cells(Me.DGV_THEO_DISTANCE_RAN.Index).Value = CDec(ROW.Item("RESULT_THEO_DISTANCE_RAN"))
                    Me.DGV.Rows.Add(DGVRow)
                    '
                    RowCounter += 1 : If EventCounter > 50 Then Application.DoEvents() : EventCounter = 1
                    EventCounter += 1
                End Using
            Next ROW
        End Sub
        Private Sub DGV_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
            If e.RowIndex < 0 Then Return
            '
            Select Case e.ColumnIndex
                Case Me.DGV_RACENAME.Index
                    Dim PARAMETERS() As String = Split(Me.DGV.Rows(e.RowIndex).Cells(Me.DGV_RACENAME.Index).Tag.ToString, "|")
                    MY_DISPLAYRACE = New UserControls.UC_DISPLAYRACE(PARAMETERS(0), PARAMETERS(1), PARAMETERS(2), PARAMETERS(3), PARAMETERS(4), MY_CONNECTION)
                    MY_DISPLAYRACE.Dock = DockStyle.Fill
                    '
                    MY_POPUP = New UserControls.PopUp
                    MY_POPUP.Text = Me.DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & ": Display Race"
                    MY_POPUP.SuspendLayout()
                    MY_POPUP.WindowState = FormWindowState.Maximized
                    MY_POPUP.Controls.Add(MY_DISPLAYRACE)
                    MY_POPUP.ResumeLayout()
                    MY_POPUP.Show(Me)
                    '
                    Me.Cursor = Cursors.WaitCursor
                    Exit Select
                Case Else
                    Return
            End Select
        End Sub
        Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
            Dim DataObject As DataObject = Me.DGV.GetClipboardContent
            Clipboard.SetDataObject(DataObject, True)
            Me.DGV.ClearSelection()
        End Sub
        Private Sub CMSRightClick_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CMSRightClick.Opening
            If Me.DGV.Rows.Count = 0 OrElse Me.DGV.SelectedRows.Count = 0 Then
                CopyToolStripMenuItem.Enabled = False
            Else
                CopyToolStripMenuItem.Enabled = True
            End If
        End Sub
    End Class
End Namespace