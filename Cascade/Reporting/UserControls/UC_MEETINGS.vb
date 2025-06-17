Namespace Reporting.UserControls
    Friend NotInheritable Class UC_MEETINGS
        Private MY_DISPLAYRACE As Cascade.UserControls.UC_DISPLAYRACE
        Private MY_CONNECTION As Connection
        Private MY_POPUP As Cascade.UserControls.PopUp
        Friend Sub New()
            InitializeComponent()
            '
            Me.DTPFrom.Value = Date.FromOADate(Today.ToOADate - 7)
            Me.DTPTo.Value = Date.FromOADate(Today.ToOADate + 1)
            MY_CONNECTION = Reporting.FORM_REPORTING.Connection
        End Sub
        Private Sub ButGO_Click(sender As Object, e As EventArgs) Handles ButGO.Click
            Me.Cursor = Cursors.WaitCursor
            Me.DGV_MEETINGS.SuspendLayout() : Me.DGV_MEETINGS.Rows.Clear() : Me.DGV_RACES.Rows.Clear()
            '
            For Each ROW As Data.DataRow In StoredProcedures.UC_MEETINGS.GetMeetingDataTable(CStr(CInt(Me.DTPFrom.Value.ToOADate)), CStr(CInt(Me.DTPTo.Value.ToOADate + 1)), MY_CONNECTION).Select("", "OADATE DESC")
                Using DGVRow As New DataGridViewRow
                    DGVRow.CreateCells(DGV_MEETINGS)
                    '
                    DGVRow.Cells(DGV_MEETINGS_DATE.Index).Value = Date.FromOADate(CDbl(ROW.Item("OADATE")))
                    DGVRow.Cells(DGV_MEETINGS_DATE.Index).Tag = CStr(ROW.Item("OADATE")) & "|" & CStr(ROW.Item("NUMBER"))
                    '
                    DGVRow.Cells(DGV_MEETINGS_NUMBER.Index).Value = CInt(ROW.Item("NUMBER"))
                    DGVRow.Cells(DGV_MEETINGS_NAME.Index).Value = Trim(CStr(ROW.Item("NAME")))
                    DGVRow.Cells(DGV_MEETINGS_STATUS.Index).Value = Trim(CStr(ROW.Item("STATUS")))
                    DGVRow.Cells(DGV_MEETINGS_TYPE.Index).Value = Trim(CStr(ROW.Item("TYPE")))
                    DGVRow.Cells(DGV_MEETINGS_VENUE.Index).Value = Trim(CStr(ROW.Item("VENUE")))
                    '
                    DGV_MEETINGS.Rows.Add(DGVRow)
                End Using
            Next
            Me.DGV_MEETINGS.ResumeLayout()
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub DGV_MEETINGS_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_MEETINGS.CellMouseUp
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            '
            Select Case e.ColumnIndex
                Case Me.DGV_MEETINGS_NAME.Index ' Name of the race
                    Dim Tag As String = Me.DGV_MEETINGS.Rows(e.RowIndex).Cells(Me.DGV_MEETINGS_DATE.Index).Tag.ToString
                    Dim PARAMETERS() As String = Split(Tag, "|")
                    '
                    Call PopulateRaces(PARAMETERS(0), PARAMETERS(1))
                    Exit Select
                Case Else
                    Exit Select
            End Select
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub DGV_RACES_CellMouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DGV_RACES.CellMouseUp
            If e.ColumnIndex <> Me.DGV_RACES_NAME.Index Then Return
            Me.Cursor = Cursors.WaitCursor
            '
            Dim PARAMETERS() As String = Split(Me.DGV_RACES.Rows(e.RowIndex).Cells(Me.DGV_RACES_TIME.Index).Tag.ToString, "|")
            MY_DISPLAYRACE = New Cascade.UserControls.UC_DISPLAYRACE(PARAMETERS(0), PARAMETERS(1), PARAMETERS(2), PARAMETERS(3), PARAMETERS(4), MY_CONNECTION)
            MY_DISPLAYRACE.Dock = DockStyle.Fill
            '
            MY_POPUP = New Cascade.UserControls.PopUp
            '
            'DGV_RACES_TIME.Index).Tag = CStr(Row.Item("MEETING_INFO_OADATE")) & "|" & CStr(Row.Item("MEETING_INFO_NUMBER")) & "|" & CStr(Row.Item("COUNTRY")) & "|" & CStr(Row.Item("TYPE")) & "|" & CStr(Row.Item("NUMBER"))
            Dim MeetingInfo() As String = Split(Me.DGV_RACES.Rows(e.RowIndex).Cells(Me.DGV_RACES_TIME.Index).Tag.ToString, "|")
            MY_POPUP.Text = "[REPORTING] M" & MeetingInfo(1) & "R" & MeetingInfo(4) & " on " & Me.DGV_RACES.Rows(e.RowIndex).Cells(Me.DGV_RACES_TIME.Index).Value.ToString & ": Display Race"
            MY_POPUP.SuspendLayout()
            MY_POPUP.WindowState = FormWindowState.Maximized
            MY_POPUP.Controls.Add(MY_DISPLAYRACE)
            MY_POPUP.ResumeLayout()
            MY_POPUP.Show(Me)
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub PopulateRaces(ByVal MEETING_OADATE As String, MEETING_NUMBER As String)
            ' Cursor is changed in calling method so no need to change it here.
            '
            Me.DGV_RACES.SuspendLayout() : Me.DGV_RACES.Rows.Clear()
            '
            Dim X As Int32 = 0
            For Each Row As Data.DataRow In StoredProcedures.UC_MEETINGS.GetVenueDataTable(MEETING_OADATE, MEETING_NUMBER, MY_CONNECTION).Select("")
                Using DGVRow As New DataGridViewRow
                    DGVRow.CreateCells(DGV_RACES)
                    '
                    DGVRow.Cells(DGV_RACES_TIME.Index).Value = Date.FromOADate(CDbl(Row.Item("NORM_TIME")))
                    DGVRow.Cells(DGV_RACES_TIME.Index).Tag = CStr(Row.Item("MEETING_INFO_OADATE")) & "|" & CStr(Row.Item("MEETING_INFO_NUMBER")) & "|" & CStr(Row.Item("COUNTRY")) & "|" & CStr(Row.Item("TYPE")) & "|" & CStr(Row.Item("NUMBER"))
                    '
                    DGVRow.Cells(DGV_RACES_NUMBER.Index).Value = CInt(Row.Item("NUMBER"))
                    Dim SCLASS As String = Nothing
                    If Not IsDBNull(Row.Item("CLASS")) Then SCLASS = Trim(CStr(Row.Item("CLASS")))
                    DGVRow.Cells(DGV_RACES_CLASS.Index).Value = SCLASS
                    DGVRow.Cells(DGV_RACES_NAME.Index).Value = Trim(CStr(Row.Item("NAME")))
                    DGVRow.Cells(DGV_RACE_STATUS.Index).Value = Trim(CStr(Row.Item("STATUS")))
                    DGVRow.Cells(DGV_RACES_LENGTH.Index).Value = CInt(Row.Item("LENGTH"))
                    '
                    DGVRow.Cells(DGV_RACES_TRACK.Index).Value = Trim(CStr(Row.Item("TRACK")))
                    DGVRow.Cells(DGV_RACES_WEATHER.Index).Value = Trim(CStr(Row.Item("WEATHER")))
                    DGVRow.Cells(DGV_RACES_RUNNERSINRACE.Index).Value = CInt(Row.Item("RUNNERSINRACE"))
                    '
                    If Row.Item("STATUS").ToString = "AB" Then
                        Call Cascade.UserControls.GridViewCellStyles.AddDefaultCellStyleToCells(DGVRow, Me.DGV_RACES)
                        Call Cascade.UserControls.GridViewCellStyles.MakeRowScratched(1, DGVRow, Me.DGV_RACES)
                    End If
                    '
                    DGV_RACES.Rows.Add(DGVRow)
                    If Not IsDBNull(Row.Item("HASMODEL")) AndAlso CBool(Row.Item("HASMODEL")) Then
                        Call Cascade.UserControls.GridViewCellStyles.AddDefaultCellStyleToCells(DGVRow, Me.DGV_RACES)
                        For Each Cell As DataGridViewCell In DGVRow.Cells
                            If Cell.ColumnIndex < 0 OrElse Cell.RowIndex < 0 Then Continue For
                            If Me.DGV_RACES.Columns(Cell.ColumnIndex).Visible = True Then
                                Cell.Style = Cascade.UserControls.GridViewCellStyles.HasModel(Cell, Me.DGV_RACES.Columns(Cell.ColumnIndex).DefaultCellStyle)
                            End If
                        Next
                    End If
                    '
                    If X > 150 Then Application.DoEvents() : X = 0
                    X += 1
                End Using
            Next
            Me.DGV_RACES.ResumeLayout()
            ' Cursor is changed in calling method, so no need to change it here.
        End Sub
#Region "       TSMI - COPY "
        Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
            Dim DataObject As DataObject = Me.DGV_MEETINGS.GetClipboardContent
            Clipboard.SetDataObject(DataObject, True)
            Me.DGV_MEETINGS.ClearSelection()
        End Sub
        Private Sub TSMI_CMS_DGV_RACES_COPY_Click(sender As Object, e As EventArgs) Handles TSMI_CMS_DGV_RACES_COPY.Click
            Dim DataObject As DataObject = Me.DGV_RACES.GetClipboardContent
            Clipboard.SetDataObject(DataObject, True)
            Me.DGV_RACES.ClearSelection()
        End Sub
#End Region
        Private Sub DeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem.Click
            If Me.DGV_MEETINGS.SelectedRows.Count = 0 Then Return
            If MessageBox.Show("Are you sure you want to delete the selected item(s)?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return
            If MessageBox.Show("Are you really sure you want to delete the selected item(s)?", "Are you really sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            For Each DGVROW As DataGridViewRow In Me.DGV_MEETINGS.SelectedRows
                Dim PARAMETERS() As String = Split(DGVROW.Cells(Me.DGV_MEETINGS_DATE.Index).Tag.ToString, "|")
                Dim CMDTEXT As String = Nothing
                CMDTEXT = "DELETE FROM MEETING_INFO WHERE (MEETING_OADATE=" & PARAMETERS(0) & ") AND (MEETING_NUMBER=" & PARAMETERS(1) & ")"
                MY_CONNECTION.Execute(CMDTEXT)
                '
                Me.DGV_MEETINGS.Rows.Remove(DGVROW)
            Next
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TSMI_CMS_DGV_RACES_DELETE_Click(sender As Object, e As EventArgs) Handles TSMI_CMS_DGV_RACES_DELETE.Click
            If Me.DGV_RACES.SelectedRows.Count = 0 Then Return
            If Me.DGV_RACES.SelectedRows.Count = Me.DGV_RACES.Rows.Count Then
                MessageBox.Show("It looks like you are trying to delete all races in the meeting, delete the meeting rather than deleting each race.", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                Return
            End If
            '
            If MessageBox.Show("Are you sure you want to delete the selected item(s)?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return
            If MessageBox.Show("Are you really sure you want to delete the selected item(s)?", "Are you really sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            For Each DGVROW As DataGridViewRow In Me.DGV_RACES.SelectedRows
                Dim PARAMETERS() As String = Split(DGVROW.Cells(Me.DGV_RACES_TIME.Index).Tag.ToString, "|")
                Dim CMDTEXT As String = Nothing
                CMDTEXT = "DELETE FROM RACE_INFO WHERE (MEETING_INFO_OADATE=" & PARAMETERS(0) & ") AND (MEETING_INFO_NUMBER=" & PARAMETERS(1) & ") AND (NUMBER=" & PARAMETERS(2) & ")"
                MY_CONNECTION.Execute(CMDTEXT)
                '
                Me.DGV_MEETINGS.Rows.Remove(DGVROW)
            Next
            Me.Cursor = Cursors.Default
        End Sub
    End Class
End Namespace