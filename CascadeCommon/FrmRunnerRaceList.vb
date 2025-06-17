Imports System.Drawing
Imports System.Windows.Forms

Public Class FrmRunnerRaceList
    Private MY_CONNECTION As Utils.Connection
    Private MY_MEETING_OADATE As String = Nothing
    Private MY_MEETING_INFO_COUNTRY As String
    Private MY_MEETING_TYPE As String = Nothing
    Private MY_NAME As String = Nothing

    Private MY_DISPLAYRACE As UserControls.ViewRace
    Private MY_POPUP As PopUp
    Private Sub New()
        InitializeComponent()
    End Sub
    Friend Sub New(MeetingOADate As String, CountryID As String, MeetingType As String, RunnerName As String, Connection As Utils.Connection)
        Me.New()
        Me.Text = "Runner Race List: " & RunnerName

        MY_MEETING_OADATE = MeetingOADate
        MY_MEETING_INFO_COUNTRY = CountryID
        MY_MEETING_TYPE = MeetingType
        MY_NAME = RunnerName
        MY_CONNECTION = Connection
    End Sub
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DGV.Rows.Clear()

        Dim RowCounter As Integer = 1, EventCounter As Integer = 1
        For Each ROW As Data.DataRow In SQL.View.Common.RunnerRaceList(MY_MEETING_INFO_COUNTRY, MY_MEETING_OADATE, MY_MEETING_TYPE, MY_NAME, MY_CONNECTION).Select("")
            Using DGVRow As New DataGridViewRow
                DGVRow.CreateCells(DGV)
                DGVRow.HeaderCell.Value = CStr(RowCounter)
                DGVRow.Cells(Me.DGV_RACENAME.Index).Value = "M" & ROW.Item("MEETING_XML_NUMBER").ToString & " R" & ROW.Item("RACE_XML_NUMBER").ToString
                DGVRow.Cells(Me.DGV_RACENAME.Index).Tag = ROW.Item("MEETING_XML_OADATE").ToString & "|" & ROW.Item("MEETING_XML_NUMBER").ToString & "|" & ROW.Item("COUNTRY_ID").ToString & "|" & ROW.Item("TYPE").ToString & "|" & ROW.Item("RACE_XML_NUMBER")

                DGVRow.Cells(Me.DGV_DATE.Index).Value = Date.FromOADate(CDbl(ROW.Item("START_TIME")))

                DGVRow.Cells(Me.DGV_BARRIER.Index).Value = CShort(ROW.Item("BARRIER"))
                DGVRow.Cells(Me.DGV_VENUE.Index).Value = ROW.Item("VENUE_NAME").ToString
                DGVRow.Cells(Me.DGV_LENGTH.Index).Value = CInt(ROW.Item("LENGTH"))
                If Not Information.IsDBNull(ROW.Item("EXCEPTION")) Then
                    DGVRow.Cells(Me.DGV_EXCEPTIONS.Index).Value = ROW.Item("EXCEPTION").ToString
                End If
                If Not Information.IsDBNull(ROW.Item("FINISH_POSITION")) Then
                    DGVRow.Cells(Me.DGV_FINISHPOSITION.Index).Value = CShort(ROW.Item("FINISH_POSITION"))
                End If
                If Not Information.IsDBNull(ROW.Item("DISTANCE_BEHIND")) Then
                    DGVRow.Cells(Me.DGV_DISTANCE_BEHIND.Index).Value = CDec(ROW.Item("DISTANCE_BEHIND"))
                End If

                If CBool(ROW.Item("SCRATCHED")) = True Then
                    For ColumnIndex As Integer = 0 To DGV.ColumnCount - 1
                        DGVRow.Cells(ColumnIndex).Style.Font = New Font(DGV.Font.FontFamily, DGV.Font.Size, FontStyle.Strikeout)
                    Next
                End If

                Me.DGV.Rows.Add(DGVRow)

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
                'MY_DISPLAYRACE = New UserControls.ViewRace(PARAMETERS(0), PARAMETERS(1), PARAMETERS(2), PARAMETERS(3), PARAMETERS(4), MY_CONNECTION)
                'MY_DISPLAYRACE.Dock = DockStyle.Fill
                '
                'MY_POPUP = New PopUp
                'MY_POPUP.Text = Me.DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString & ": Display Race"
                'MY_POPUP.SuspendLayout()
                'MY_POPUP.WindowState = FormWindowState.Maximized
                'MY_POPUP.Controls.Add(MY_DISPLAYRACE)
                'MY_POPUP.ResumeLayout()
                'MY_POPUP.Show(Me)
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
