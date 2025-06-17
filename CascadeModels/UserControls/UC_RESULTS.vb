Imports System.Windows.Forms
Imports System.Drawing
Namespace UserControls
    Friend Class UC_RESULTS
        Private MY_POPUP As PopUp
        Private MY_UI_MODEL_TOTALS As UC_Model_Totals
        Private MY_STARTDATE As String
        Private MY_FINSHDATE As String
        Friend Sub New()
            InitializeComponent()

            MY_UI_MODEL_TOTALS = New UC_Model_Totals
            MY_UI_MODEL_TOTALS.Dock = DockStyle.Fill
            MY_UI_MODEL_TOTALS.TabIndex = 0
            MY_UI_MODEL_TOTALS.TabStop = False
            Me.Panel1.Controls.Add(MY_UI_MODEL_TOTALS)
        End Sub
        Friend Sub Populate(ByVal DataTable As Data.DataTable, ByVal StartDate As String, ByVal FinishDate As String)
            Me.Cursor = Cursors.WaitCursor
            MY_STARTDATE = StartDate
            MY_FINSHDATE = FinishDate
            Me.DGV_RESULTS.Rows.Clear()

            Dim TOTALRACES As Int64 = 0L, WINCOUNT As Int64 = 0L, PLACECOUNT As Int64 = 0L, PROFITLOSSWIN As Decimal = 0D, PROFITLOSSPLACE As Decimal = 0D
            Dim WINPERCENT As Decimal = 0D, PLACEPERCENT As Decimal = 0D
            Call SetLabelValues(TOTALRACES, WINCOUNT, PLACECOUNT, PROFITLOSSWIN, PROFITLOSSPLACE)

            Me.DGV_RESULTS.Rows.Clear()
            Dim RowCount As Int64 = 1
            For Each Row As Data.DataRow In DataTable.Select("", "MEETING_XML_OADATE DESC")
                Dim RowAdd As Boolean = True
                Try
                    Using DGVRow As New DataGridViewRow
                        DGVRow.CreateCells(DGV_RESULTS)
                        ' Default value is -1, loss or not run yet.
                        Dim WIN As Decimal = -1D, PLACE As Decimal = -1D
                        DGVRow.HeaderCell.Value = CStr(RowCount)
                        DGVRow.Cells(Me.DGV_DATE.Index).Value = Date.FromOADate(CDbl(Row.Item("MEETING_XML_OADATE")))
                        DGVRow.Cells(Me.DGV_NUMBER.Index).Value = CInt(Row.Item("NUMBER"))
                        DGVRow.Cells(Me.DGV_NUMBER.Index).Tag = Row.Item("COUNTRY_ID").ToString & "|" & Row.Item("MEETING_XML_OADATE").ToString & "|" & Row.Item("MEETING_XML_NUMBER").ToString & "|" & Row.Item("TRACK_TYPE").ToString & "|" & Row.Item("RACE_XML_NUMBER").ToString
                        DGVRow.Cells(Me.DGV_BARRIER.Index).Value = CShort(Row.Item("BARRIER"))
                        DGVRow.Cells(Me.DGV_NAME.Index).Value = Row.Item("NAME").ToString
                        If Not Information.IsDBNull(Row.Item("CLASS")) Then
                            DGVRow.Cells(Me.DGV_CLASS.Index).Value = Row.Item("CLASS")
                        End If
                        '
                        'DGVRow.Cells(Me.DGV_CLASS.Index).Value = CStr(Row.Item("CLASS"))
                        DGVRow.Cells(Me.DGV_MEETINGNAME.Index).Value = "M" & CStr(Row.Item("MEETING_XML_NUMBER")) & " R" & CStr(Row.Item("RACE_XML_NUMBER"))
                        DGVRow.Cells(Me.DGV_RACELENGTH.Index).Value = CInt(Row.Item("RACE_XML_LENGTH"))
                        DGVRow.Cells(Me.DGV_VENUE.Index).Value = Row.Item("VENUE_NAME").ToString
                        If Not Information.IsDBNull(Row.Item("FINISHPOSITION")) Then DGVRow.Cells(Me.DGV_FINISHPOSITION.Index).Value = CShort(Row.Item("FINISHPOSITION"))
                        '
                        If Not IsDBNull(Row.Item("FINISHPOSITION")) Then
                            Select Case Row.Item("FINISHPOSITION")
                                Case 1
                                    WINCOUNT += 1
                                Case 2, 3, 4
                                    PLACECOUNT += 1
                                Case Else
                                    ' Do Nothing
                            End Select
                        End If
                        '
                        DGV_RESULTS.Rows.Add(DGVRow) : TOTALRACES += 1
                        'If Not IsDBNull(Row.Item("HASMODEL")) AndAlso CBool(Row.Item("HASMODEL")) Then
                        'Call GridViewCellStyles.AddDefaultCellStyleToCells(DGVRow, Me.DGV_RESULTS)
                        'For Each Cell As DataGridViewCell In DGVRow.Cells
                        'If Cell.ColumnIndex < 0 OrElse Cell.RowIndex < 0 Then Continue For
                        'If Me.DGV_RESULTS.Columns(Cell.ColumnIndex).Visible = True Then
                        'Cell.Style = GridViewCellStyles.HasModel(Cell, Me.DGV_RESULTS.Columns(Cell.ColumnIndex).DefaultCellStyle)
                        'End If
                        'Next
                        '       End If
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
                Catch EX As Exception
                    Call Messages.LogMessages(EX.ToString, BroadcastTypes.Error)
                End Try
            Next

            Call SetLabelValues(TOTALRACES, WINCOUNT, PLACECOUNT, PROFITLOSSWIN, PROFITLOSSPLACE)

            Me.Cursor = Cursors.Default
        End Sub
        Private Sub SetLabelValues(TOTALRACES As Int64, WINCOUNT As Int64, PLACECOUNT As Int64, PROFITLOSSWIN As Decimal, PROFITLOSSPLACE As Decimal)
            Call MY_UI_MODEL_TOTALS.ResetValues()
            If TOTALRACES > 0 Then Call MY_UI_MODEL_TOTALS.Populate(CInt(TOTALRACES), TOTALRACES, TOTALRACES, WINCOUNT, PLACECOUNT, PROFITLOSSWIN, PROFITLOSSPLACE, Nothing)
        End Sub
        Friend Sub Clear()
            Me.DGV_RESULTS.Rows.Clear()
            Call SetLabelValues(0, 0, 0, 0, 0)
        End Sub
        Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles DGV_RESULTS_CMS_CopyToolStripMenuItem.Click
            Dim DataObject As DataObject = Me.DGV_RESULTS.GetClipboardContent
            Clipboard.SetDataObject(DataObject, True)
            Me.DGV_RESULTS.ClearSelection()
        End Sub
        Private Sub DGV_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DGV_RESULTS.DataError
            ' Do Nothing
        End Sub

        Private Sub DGV_RESULTS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_RESULTS.CellContentClick
            If e.RowIndex < 0 Or e.ColumnIndex < 0 Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            '
            Select Case e.ColumnIndex
                Case Me.DGV_NAME.Index ' Name of the race
                    MY_POPUP = New PopUp
                    Dim PARAMETERS() As String = Split(Me.DGV_RESULTS.Rows(e.RowIndex).Cells(Me.DGV_NUMBER.Index).Tag.ToString, "|")
                    Dim UCViewRace As New CascadeCommon.UserControls.ViewRace(PARAMETERS(0), PARAMETERS(1), PARAMETERS(2), PARAMETERS(3), PARAMETERS(4), "M" & PARAMETERS(2) & "R" & PARAMETERS(4), Connection)
                    UCViewRace.Dock = DockStyle.Fill
                    '
                    MY_POPUP.Controls.Add(UCViewRace)
                    MY_POPUP.Size = UCViewRace.Size
                    MY_POPUP.WindowState = FormWindowState.Maximized
                    MY_POPUP.Text = "(M" & PARAMETERS(2) & " R" & PARAMETERS(4) & ") - OADATE: " & PARAMETERS(1) & " TYPE:" & PARAMETERS(3)
                    MY_POPUP.Show(Me)
            End Select
            '
            Me.Cursor = Cursors.Default
        End Sub
    End Class
End Namespace