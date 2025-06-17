Imports System.Windows.Forms
Imports System.Drawing
Namespace UserControls
    Friend NotInheritable Class UC_RESULTS
        Private MY_POPUP As PopUp
        Private MY_DISPLAYRACE As UC_DISPLAYRACE
        Private MY_UI_MODEL_TOTALS As UC_Model_Totals
        Private MY_STARTDATE As String
        Private MY_FINSHDATE As String
        Private _Connection As Utils.Connection
        Friend Sub New()
            InitializeComponent()
            '
            Me._Connection = New Utils.Connection

            Me.Panel1.Height = Me.LBL_RANGE_HEADER.Height + 72
            MY_UI_MODEL_TOTALS = New UC_Model_Totals(Me._Connection)
            MY_UI_MODEL_TOTALS.BackColor = System.Drawing.Color.Transparent
            MY_UI_MODEL_TOTALS.Font = New Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            MY_UI_MODEL_TOTALS.Location = New Point(0, 19)
            MY_UI_MODEL_TOTALS.Margin = New Padding(0)
            MY_UI_MODEL_TOTALS.Name = "UC_Model_Totals1"
            MY_UI_MODEL_TOTALS.Size = New Size(663, 72)
            MY_UI_MODEL_TOTALS.TabIndex = 1
            MY_UI_MODEL_TOTALS.TabStop = False
            MY_UI_MODEL_TOTALS.Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Top
            '
            Me.Panel1.Controls.Add(MY_UI_MODEL_TOTALS)
            '
            Me.DGV_RESULTS.Location = New Drawing.Point(0, Me.Panel1.Height + 3)
        End Sub
        Friend Sub Populate(ByVal DataTable As Data.DataTable, ByVal StartDate As String, ByVal FinishDate As String, ByVal TabPage As UserControls.UserControlTabPage)
            Me.Cursor = Cursors.WaitCursor
            MY_STARTDATE = StartDate
            MY_FINSHDATE = FinishDate
            Me.DGV_RESULTS.Rows.Clear()

            Dim TOTALRACES As Int64 = 0L, WINCOUNT As Int64 = 0L, PLACECOUNT As Int64 = 0L, PROFITLOSSWIN As Decimal = 0D, PROFITLOSSPLACE As Decimal = 0D
            Dim WINPERCENT As Decimal = 0D, PLACEPERCENT As Decimal = 0D
            Call SetLabelValues(TOTALRACES, WINCOUNT, PLACECOUNT, PROFITLOSSWIN, PROFITLOSSPLACE)

            Me.LBL_RANGE_HEADER.Text = "RANGE: BETWEEN " & Date.FromOADate(CDbl(StartDate)).ToLongDateString & " AND " & Date.FromOADate(CDbl(FinishDate)).ToLongDateString

            Me.DGV_RESULTS.Rows.Clear()
            Dim RowCount As Int64 = 1
            For Each Row As Data.DataRow In DataTable.Select("", "MEETING_INFO_OADATE DESC")
                Dim RowAdd As Boolean = True
                Using DGVRow As New DataGridViewRow
                    DGVRow.CreateCells(DGV_RESULTS)
                    ' Default value is -1, loss or not run yet.
                    Dim WIN As Decimal = -1D, PLACE As Decimal = -1D
                    DGVRow.HeaderCell.Value = CStr(RowCount)
                    DGVRow.Cells(Me.DGV_DATE.Index).Value = Date.FromOADate(CDbl(Row.Item("MEETING_INFO_OADATE")))
                    DGVRow.Cells(Me.DGV_NUMBER.Index).Value = CInt(Row.Item("NUMBER"))
                    DGVRow.Cells(Me.DGV_NUMBER.Index).Tag = CStr(Row.Item("MEETING_INFO_OADATE")) & "|" & CStr(Row.Item("MEETING_INFO_NUMBER")) & "|" & CStr(Row.Item("COUNTRY")) & "|" & CStr(Row.Item("TYPE")) & "|" & CStr(Row.Item("RACE_INFO_NUMBER")) & "|" & CStr(Row.Item("VENUE"))
                    DGVRow.Cells(Me.DGV_BARRIER.Index).Value = CShort(Row.Item("BARRIER"))
                    DGVRow.Cells(Me.DGV_NAME.Index).Value = CStr(Row.Item("NAME"))
                    '
                    DGVRow.Cells(Me.DGV_CLASS.Index).Value = CStr(Row.Item("CLASS"))
                    DGVRow.Cells(Me.DGV_MEETINGNAME.Index).Value = "M" & CStr(Row.Item("MEETING_INFO_NUMBER")) & " R" & CStr(Row.Item("RACE_INFO_NUMBER"))
                    DGVRow.Cells(Me.DGV_RACELENGTH.Index).Value = CInt(Row.Item("LENGTH"))
                    DGVRow.Cells(Me.DGV_VENUE.Index).Value = CStr(Row.Item("VENUE"))
                    DGVRow.Cells(Me.DGV_WEATHER.Index).Value = CStr(Row.Item("WEATHER"))
                    DGVRow.Cells(Me.DGV_TRACK.Index).Value = CStr(Row.Item("TRACK"))
                    DGVRow.Cells(Me.DGV_FINISHPOSITION.Index).Value = CShort(Row.Item("RESULT_FINISH_POSITION"))
                    '
                    If Not IsDBNull(Row.Item("RESULT_POOL_WIN")) Then WIN += CDec(Row.Item("RESULT_POOL_WIN"))
                    DGVRow.Cells(Me.DGV_WINS.Index).Value = WIN
                    If WIN >= 0D Then WINCOUNT += 1
                    PROFITLOSSWIN += WIN
                    '
                    If Not IsDBNull(Row.Item("RESULT_POOL_PLACE")) Then PLACE += CDec(Row.Item("RESULT_POOL_PLACE"))
                    DGVRow.Cells(Me.DGV_PLACES.Index).Value = PLACE
                    If PLACE >= 0D Then PLACECOUNT += 1
                    PROFITLOSSPLACE += PLACE
                    '
                    DGV_RESULTS.Rows.Add(DGVRow) : TOTALRACES += 1
                    If Not IsDBNull(Row.Item("HASMODEL")) AndAlso CBool(Row.Item("HASMODEL")) Then
                        Call GridViewCellStyles.AddDefaultCellStyleToCells(DGVRow, Me.DGV_RESULTS)
                        For Each Cell As DataGridViewCell In DGVRow.Cells
                            If Cell.ColumnIndex < 0 OrElse Cell.RowIndex < 0 Then Continue For
                            If Me.DGV_RESULTS.Columns(Cell.ColumnIndex).Visible = True Then
                                Cell.Style = GridViewCellStyles.HasModel(Cell, Me.DGV_RESULTS.Columns(Cell.ColumnIndex).DefaultCellStyle)
                            End If
                        Next
                    End If
                    '
                    Select Case WIN
                        Case Is < 0
                            Call GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_WINS.Index, Color.Red)
                        Case Is >= 1
                            Call GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_WINS.Index, Color.Green)
                        Case Else
                            Call GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_WINS.Index, Color.Black)
                    End Select
                    Select Case PLACE
                        Case Is < 0
                            Call GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_PLACES.Index, Color.Red)
                        Case Is >= 1
                            Call GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_PLACES.Index, Color.Green)
                        Case Else
                            Call GridViewCellStyles.ChangeForeColor(DGVRow, Me.DGV_PLACES.Index, Color.Black)
                    End Select

                    If Not RowAdd Then
                        Call GridViewCellStyles.AddDefaultCellStyleToCells(DGVRow, Me.DGV_RESULTS)
                        Call GridViewCellStyles.MakeRowScratched(1, DGVRow, Me.DGV_RESULTS)
                    End If
                    RowCount += 1
                End Using
            Next

            Call SetLabelValues(TOTALRACES, WINCOUNT, PLACECOUNT, PROFITLOSSWIN, PROFITLOSSPLACE)

            Me.Cursor = Cursors.Default
        End Sub
        Private Sub SetLabelValues(TOTALRACES As Int64, WINCOUNT As Int64, PLACECOUNT As Int64, PROFITLOSSWIN As Decimal, PROFITLOSSPLACE As Decimal)
            Call MY_UI_MODEL_TOTALS.ResetValues()
            If TOTALRACES > 0 Then Call MY_UI_MODEL_TOTALS.Populate(MY_STARTDATE, MY_FINSHDATE, CInt(TOTALRACES), TOTALRACES, TOTALRACES, WINCOUNT, PLACECOUNT, PROFITLOSSWIN, PROFITLOSSPLACE, Nothing)
        End Sub
        Friend Sub Clear()
            Me.DGV_RESULTS.Rows.Clear()
            Call SetLabelValues(0, 0, 0, 0, 0)
        End Sub
        Private Sub DGV_RESULTS_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DGV_RESULTS.CellMouseClick
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            '
            Select Case e.ColumnIndex
                Case Me.DGV_NAME.Index ' Name of the race
                    MY_POPUP = New PopUp
                    '
                    Dim PARAMETERS() As String = Split(Me.DGV_RESULTS.Rows(e.RowIndex).Cells(Me.DGV_NUMBER.Index).Tag.ToString, "|")
                    MY_DISPLAYRACE = New UC_DISPLAYRACE(PARAMETERS(0), PARAMETERS(1), PARAMETERS(2), PARAMETERS(3), PARAMETERS(4), Me._Connection)
                    MY_DISPLAYRACE.Dock = DockStyle.Fill
                    '
                    MY_POPUP.Controls.Add(MY_DISPLAYRACE)
                    MY_POPUP.Size = MY_DISPLAYRACE.Size
                    MY_POPUP.WindowState = FormWindowState.Maximized
                    MY_POPUP.Text = "(M" & PARAMETERS(1) & " R" & PARAMETERS(4) & "- " & PARAMETERS(5) & ")"
                    MY_POPUP.Show(Me)
            End Select
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_RESULTS_CMS_CopyToolStripMenuItem.Click
            Dim DataObject As DataObject = Me.DGV_RESULTS.GetClipboardContent
            Clipboard.SetDataObject(DataObject, True)
            Me.DGV_RESULTS.ClearSelection()
        End Sub
        Private Sub DGV_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DGV_RESULTS.DataError
            ' Do Nothing
        End Sub
    End Class
End Namespace