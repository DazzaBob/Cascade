Namespace Reporting.UserControls
    Friend NotInheritable Class UC_MODELLED
        Private MY_CONNECTION As Connection
        Private MY_DISPLAYRACE As Cascade.UserControls.UC_DISPLAYRACE
        Private MY_POPUP As Cascade.UserControls.PopUp
        Private UC_MODEL_TOTALS1 As Cascade.UserControls.UC_Model_Totals
        '
        Private m_DataTable As Data.DataTable
        Friend Sub New(ByVal Connection As Connection)
            InitializeComponent()
            '
            MY_CONNECTION = Connection
            UC_MODEL_TOTALS1 = New Cascade.UserControls.UC_Model_Totals(MY_CONNECTION)
            '
            Me.DTP_TO.Value = Date.Today
            Me.DTP_FROM.Value = Date.FromOADate(Date.Today.ToOADate - 7)
            Me.CB_TYPE.Items.Add("{None}")
            If My.Settings.LoadGreyhounds Then Me.CB_TYPE.Items.Add("GR")
            If My.Settings.LoadGallops Then Me.CB_TYPE.Items.Add("G")
            If My.Settings.LoadHarness Then Me.CB_TYPE.Items.Add("H")
            Me.CB_TYPE.Text = "{None}"
            '
            '
            'UC_Model_Totals1
            '
            Me.UC_MODEL_TOTALS1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.UC_MODEL_TOTALS1.BackColor = System.Drawing.Color.Transparent
            Me.UC_MODEL_TOTALS1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.UC_MODEL_TOTALS1.Location = New System.Drawing.Point(2, 28)
            Me.UC_MODEL_TOTALS1.Margin = New System.Windows.Forms.Padding(0)
            Me.UC_MODEL_TOTALS1.Name = "UC_Model_Totals1"
            Me.UC_MODEL_TOTALS1.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.UC_MODEL_TOTALS1.Size = New System.Drawing.Size(712, 59)
            Me.UC_MODEL_TOTALS1.TabIndex = 42
            Me.Controls.Add(Me.UC_MODEL_TOTALS1)
        End Sub
        Private Sub ButGO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUT_GO.Click
            If Me.CB_TYPE.Text = "{None}" Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            '
            Me.DGV.Rows.Clear()
            Me.UC_MODEL_TOTALS1.ResetValues()
            '
            m_DataTable = StoredProcedures.UC_MODELLEDRACES.GetDataTable(CStr(Me.DTP_FROM.Value.ToOADate), CStr(Me.DTP_TO.Value.ToOADate), Me.CB_TYPE.Text, Reporting.FORM_REPORTING.Connection)
            '
            Dim WINRACES As Int64 = 0L, PLACERACES As Int64 = 0L, WINCOUNT As Int64 = 0L, PLACECOUNT As Int64 = 0L, PROFITLOSSWIN As Decimal = 0D, PROFITLOSSPLACE As Decimal = 0D
            Dim WINPERCENT As Decimal = 0D, PLACEPERCENT As Decimal = 0D
            '
            Dim Y As Int32
            For Each Row As Data.DataRow In m_DataTable.Select("")
                Using DGVRow As New DataGridViewRow
                    DGVRow.CreateCells(DGV)
                    DGVRow.HeaderCell.Value = CStr(Y + 1I)
                    '
                    DGVRow.Cells(DGV_RACE_TIME.Index).Value = FormatDateTime(Date.FromOADate(CDbl(Row.Item("NORM_TIME"))), DateFormat.GeneralDate)
                    DGVRow.Cells(DGV_RACE_TIME.Index).Tag = CStr(Row.Item("MEETING_INFO_OADATE")) & "|" & CStr(Row.Item("MEETING_INFO_NUMBER")) & "|" & CStr(Row.Item("COUNTRY")) & "|" & CStr(Row.Item("TYPE")) & "|" & CStr(Row.Item("RACE_INFO_NUMBER"))
                    '
                    DGVRow.Cells(DGV_RACE_NAME.Index).Value = "M" & CStr(Row.Item("MEETING_INFO_NUMBER")) & " R" & CStr(Row.Item("RACE_INFO_NUMBER")) & " E" & CStr(Row.Item("ENTRY_INFO_NUMBER"))
                    DGVRow.Cells(DGV_STATUS.Index).Value = Row.Item("STATUS").ToString
                    DGVRow.Cells(DGV_CLASS.Index).Value = CStr(Row.Item("CLASS"))
                    DGVRow.Cells(DGV_VENUE.Index).Value = Row.Item("VENUE").ToString
                    DGVRow.Cells(DGV_LENGTH.Index).Value = CInt(Row.Item("LENGTH"))
                    DGVRow.Cells(DGV_TRACK.Index).Value = Row.Item("TRACK").ToString
                    DGVRow.Cells(DGV_WEATHER.Index).Value = Row.Item("WEATHER").ToString
                    '
                    Dim BACKING As String = "PLC"
                    Dim CMDTEXT As String = "SELECT TOP (1) BETTYPE FROM RACE_MODEL_INFO "
                    CMDTEXT += "WHERE (MEETING_INFO_OADATE = " & CStr(Row.Item("MEETING_INFO_OADATE")) & ") AND (MEETING_INFO_NUMBER = " & CStr(Row.Item("MEETING_INFO_NUMBER")) & ") AND (RACE_INFO_NUMBER = " & CStr(Row.Item("RACE_INFO_NUMBER")) & ") "
                    CMDTEXT += "GROUP BY BETTYPE ORDER BY COUNT(BETTYPE) DESC"
                    BACKING = CStr(MY_CONNECTION.ExecuteScalar(CMDTEXT))
                    '
                    Dim WIN As Decimal = 0D, PLACE As Decimal = 0D
                    '
                    ' Populate the Paidwin Column
                    If Not IsDBNull(Row.Item("PAIDWIN")) AndAlso CDec(Row.Item("PAIDWIN")) >= 0 Then
                        DGVRow.Cells(DGV_WINS.Index).Value = FormatCurrency(CDec(Row.Item("PAIDWIN")), 2)
                        If BACKING <> "PLC" Then WINRACES += 1 : WINCOUNT += 1 : PROFITLOSSWIN += CDec(Row.Item("PAIDWIN"))
                        WIN = CDec(Row.Item("PAIDWIN"))
                    Else
                        DGVRow.Cells(DGV_WINS.Index).Value = FormatCurrency(-1D, 2)
                        If BACKING <> "PLC" Then WINRACES += 1 : PROFITLOSSWIN -= 1D
                        WIN = -1
                    End If
                    '
                    If Not IsDBNull(Row.Item("PAIDPLACE")) AndAlso CDec(Row.Item("PAIDPLACE")) >= 0 Then
                        DGVRow.Cells(DGV_PLACES.Index).Value = FormatCurrency(CDec(Row.Item("PAIDPLACE")), 2)
                        PLACERACES += 1 : PLACECOUNT += 1 : PROFITLOSSPLACE += CDec(Row.Item("PAIDPLACE"))
                        PLACE = CDec(Row.Item("PAIDPLACE"))
                    Else
                        DGVRow.Cells(DGV_PLACES.Index).Value = FormatCurrency(-1D, 2)
                        PLACERACES += 1 : PROFITLOSSPLACE -= 1D
                        PLACE = -1
                    End If
                    DGV.Rows.Add(DGVRow)
                    '
                    ' Now figure out if we won or lost the bet, then set color accordingly.
                    If BACKING <> "PLC" Then
                        Select Case WIN
                            Case Is < 0
                                Call Cascade.UserControls.GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_WINS.Index, Color.Red)
                            Case Is >= 1
                                Call Cascade.UserControls.GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_WINS.Index, Color.Green)
                            Case Else
                                Call Cascade.UserControls.GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_WINS.Index, Color.Black)
                        End Select
                    Else
                        Call Cascade.UserControls.GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_WINS.Index, Color.Gray)
                    End If
                    '
                    Select Case PLACE
                        Case Is < 0
                            Call Cascade.UserControls.GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_PLACES.Index, Color.Red)
                        Case Is >= 1
                            Call Cascade.UserControls.GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_PLACES.Index, Color.Green)
                        Case Else
                            Call Cascade.UserControls.GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_PLACES.Index, Color.Black)
                    End Select
                    '
                End Using
                Y += 1
            Next
            '
            If PLACERACES > 0 Then Me.UC_MODEL_TOTALS1.Populate(CStr(Me.DTP_FROM.Value.ToOADate), CStr(Me.DTP_TO.Value.ToOADate), Y - 1, WINRACES, PLACERACES, WINCOUNT, PLACECOUNT, PROFITLOSSWIN, PROFITLOSSPLACE, Nothing)
            '
            Me.DGV.Refresh()
            '
            Me.DGV.Cursor = Cursors.Default
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub DGV_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellContentClick
            Me.Cursor = Cursors.WaitCursor
            Select Case e.ColumnIndex
                Case Me.DGV_RACE_NAME.Index ' Name of the race
                    Dim PARAMETERS() As String = Split(Me.DGV.Rows(e.RowIndex).Cells(Me.DGV_RACE_TIME.Index).Tag.ToString, "|")
                    '
                    MY_DISPLAYRACE = New Cascade.UserControls.UC_DISPLAYRACE(PARAMETERS(0), PARAMETERS(1), PARAMETERS(2), PARAMETERS(3), PARAMETERS(4), MY_CONNECTION)
                    MY_DISPLAYRACE.Dock = DockStyle.Fill
                    '
                    MY_POPUP = New Cascade.UserControls.PopUp
                    '
                    MY_POPUP.Controls.Add(MY_DISPLAYRACE)
                    MY_POPUP.Size = MY_DISPLAYRACE.Size
                    MY_POPUP.WindowState = FormWindowState.Maximized
                    MY_POPUP.Text = "MODELLED RACES - (M" & PARAMETERS(1) & " R" & PARAMETERS(4) & "- " & PARAMETERS(2) & ", " & PARAMETERS(3) & ")"
                    MY_POPUP.Show(Me)
                Case Else
                    ' Do Nothing
            End Select
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TSMI_DGV_CMS_COPY_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TSMI_DGV_CMS_COPY.Click
            Dim DataObject As DataObject = Me.DGV.GetClipboardContent
            Clipboard.SetDataObject(DataObject, True)
            Me.DGV.ClearSelection()
        End Sub
        Private Sub DGV_CMS_Opening(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DGV_CMS.Opening
            Dim DataObject As DataObject = Me.DGV.GetClipboardContent
            If DataObject Is Nothing Then
                Me.TSMI_DGV_CMS_COPY.Enabled = False
            Else
                Me.TSMI_DGV_CMS_COPY.Enabled = True
            End If
        End Sub
        Private Sub DGV_DataError(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles DGV.DataError
            Me.DGV.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = e.Exception.ToString
        End Sub
        Private Sub TSMI_DGV_CMS_DELETE_Click(sender As Object, e As EventArgs) Handles TSMI_DGV_CMS_DELETE.Click
            If Me.DGV.SelectedRows.Count = 0 Then Return
            If MessageBox.Show("Are you sure you want to delete the selected item(s)?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return
            If MessageBox.Show("Are you really sure you want to delete the selected item(s)?", "Are you really sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            For Each DGVROW As DataGridViewRow In Me.DGV.SelectedRows
                Dim PARAMETERS() As String = Split(DGVROW.Cells(Me.DGV_RACE_TIME.Index).Tag.ToString, "|")
                Dim CMDTEXT As String = Nothing
                CMDTEXT = "DELETE RACE_INFO WHERE (MEETING_OADATE=" & PARAMETERS(0) & ") AND (MEETING_NUMBER=" & PARAMETERS(1) & ") AND (NUMBER=" & PARAMETERS(2) & ")"
                MY_CONNECTION.Execute(CMDTEXT)
                '
                Me.DGV.Rows.Remove(DGVROW)
            Next
            Me.Cursor = Cursors.Default
        End Sub
    End Class
End Namespace