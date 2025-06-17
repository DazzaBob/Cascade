Namespace UserControls.Models
    Friend Class UserControlResults
        Private _StartDate As String
        Private _FinishDate As String
        Private _Popup As CascadeCommon.PopUp
        Friend Sub New()
            InitializeComponent()

            Me.GroupBoxTotals.Top = Me.LBL_RANGE_HEADER.Height + 1
        End Sub
        Friend Sub Populate(DataTable As Data.DataTable, StartDate As String, FinishDate As String, TabPage As UserControls.UserControlTabPage)
            Me.Cursor = Cursors.WaitCursor

            _StartDate = StartDate
            _FinishDate = FinishDate
            Me.DGV_RESULTS.Rows.Clear()
            Call Me.ResetTotalsValues()

            Dim TOTALRACES As Long = 0L, WINCOUNT As Long = 0L, PLACECOUNT As Long = 0L, PROFITLOSSWIN As Decimal = 0D, PROFITLOSSPLACE As Decimal = 0D
            Dim WINPERCENT As Decimal = 0D, PLACEPERCENT As Decimal = 0D

            Using Connection As New Utils.Connection
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

                Call PopulateTotals(TOTALRACES, WINCOUNT, PLACECOUNT, WINCOUNT, PLACECOUNT, PROFITLOSSWIN, PROFITLOSSPLACE, Connection, Nothing)
            End Using
            Me.Cursor = Cursors.Default
        End Sub
#Region "       TOTALS "
        Private Sub PopulateTotals(TotalRaces As Long, WinRaces As Long, PlaceRaces As Long, WinCount As Long, PlaceCount As Long, ProfitLossWin As Decimal, ProfitLossPlace As Decimal, Connection As Utils.Connection, Optional Length As String = Nothing)
            Me.LBL_DAYSVALUE.Text = FormatNumber((CInt(Me._FinishDate) - CInt(Me._StartDate)) + 1, 0)
            Call PopulateDatabaseFields(Length, Connection)

            Me.LblTotalRacesValue.Text = "W: " & FormatNumber(WinRaces, 0) & " - P: " & FormatNumber(PlaceRaces, 0)
            Me.LblTotalWinsValue.Text = FormatNumber(WinCount, 0)
            Me.LblTotalPlacesValue.Text = FormatNumber(PlaceCount, 0)
            Me.LblWinRateValue.Text = FormatPercent(WinCount / WinRaces, 2)
            If (WinRaces > 0) AndAlso (CDec(WinCount / WinRaces) < 0) Then Me.LblWinRateValue.ForeColor = Color.Red Else Me.LblWinRateValue.ForeColor = Color.Black
            Me.LblPlaceRateValue.Text = FormatPercent(PlaceCount / PlaceRaces, 2) : If CDec(PlaceCount / PlaceRaces) < 0 Then Me.LblPlaceRateValue.ForeColor = Color.Red Else Me.LblPlaceRateValue.ForeColor = Color.Black
            Me.LblProfitLossWinValue.Text = FormatCurrency(ProfitLossWin, 2) : If CDec(ProfitLossWin) < 0 Then Me.LblProfitLossWinValue.ForeColor = Color.Red Else Me.LblProfitLossWinValue.ForeColor = Color.Black
            Me.LblProfitLossPlaceValue.Text = FormatCurrency(ProfitLossPlace, 2) : If CDec(ProfitLossPlace) < 0 Then Me.LblProfitLossPlaceValue.ForeColor = Color.Red Else Me.LblProfitLossPlaceValue.ForeColor = Color.Black

            Me.LblPLPlacePercentValue.Text = FormatPercent(ProfitLossPlace / PlaceRaces, 2) : If CDec(ProfitLossPlace / PlaceRaces) < 0 Then Me.LblPLPlacePercentValue.ForeColor = Color.Red Else Me.LblPLPlacePercentValue.ForeColor = Color.Black
            If WinRaces > 0 Then Me.LblPLWinPercentValue.Text = FormatPercent(ProfitLossWin / WinRaces, 2) : If CDec(ProfitLossWin / WinRaces) < 0 Then Me.LblPLWinPercentValue.ForeColor = Color.Red Else Me.LblPLWinPercentValue.ForeColor = Color.Black

            Me.LBL_HITS_VALUE.Text = FormatPercent(TotalRaces / CInt(Me.LBL_RACES_VALUE.Text), 2)
        End Sub
        Private Sub PopulateDatabaseFields(ByVal Length As String, Connection As Utils.Connection)
            Dim MY_FILTER As String = "WHERE (MEETING_INFO.OADATE >= " & Me._StartDate & ") AND (MEETING_INFO.OADATE <=" & Me._FinishDate & ")"

            Dim MeetingCount As Long, RaceCount As Long, EntryCount As Long
            Dim CMDTEXT As String = "SELECT COUNT(MEETING_INFO.OADATE) AS COUNT FROM MEETING_INFO "
            CMDTEXT += MY_FILTER

            MeetingCount = CLng(Connection.ExecuteScalar(CMDTEXT))
            Me.LBL_MEETING_VALUE.Text = FormatNumber(MeetingCount, 0)
            '
            If Length IsNot Nothing Then MY_FILTER += " AND (RACE_INFO.LENGTH=" & Length & ")"
            CMDTEXT = "SELECT COUNT(RACE_INFO.NUMBER) AS COUNT "
            CMDTEXT += "FROM MEETING_INFO RIGHT OUTER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER "
            CMDTEXT += MY_FILTER
            RaceCount = CLng(Connection.ExecuteScalar(CMDTEXT))
            Me.LBL_RACES_VALUE.Text = FormatNumber(RaceCount, 0)
            '
            CMDTEXT = "SELECT COUNT(ENTRY_INFO.NUMBER) AS COUNT "
            CMDTEXT += "FROM ENTRY_INFO LEFT OUTER JOIN RACE_INFO ON ENTRY_INFO.MEETING_INFO_OADATE = RACE_INFO.MEETING_INFO_OADATE AND ENTRY_INFO.MEETING_INFO_NUMBER = RACE_INFO.MEETING_INFO_NUMBER AND ENTRY_INFO.RACE_INFO_NUMBER = RACE_INFO.NUMBER LEFT OUTER JOIN MEETING_INFO ON RACE_INFO.MEETING_INFO_OADATE = MEETING_INFO.OADATE AND RACE_INFO.MEETING_INFO_NUMBER = MEETING_INFO.NUMBER "
            CMDTEXT += MY_FILTER
            EntryCount = CLng(Connection.ExecuteScalar(CMDTEXT))
            Me.LBL_ENTRIES_VALUE.Text = FormatNumber(EntryCount, 0)
        End Sub
        Friend Sub ResetTotalsValues()
            Me.LBL_DAYSVALUE.Text = "0" : Me.LBL_MEETING_VALUE.Text = "0" : Me.LBL_RACES_VALUE.Text = "0" : Me.LBL_ENTRIES_VALUE.Text = "0"
            Me.LblTotalRacesValue.Text = "0"
            Me.LblTotalWinsValue.Text = "0"
            Me.LblTotalPlacesValue.Text = "0"
            Me.LBL_HITS_VALUE.Text = "0 %" : Me.LBL_HITS_VALUE.ForeColor = Color.Black
            Me.LblWinRateValue.Text = "0 %" : Me.LblWinRateValue.ForeColor = Color.Black
            Me.LblPlaceRateValue.Text = "0 %" : Me.LblWinRateValue.ForeColor = Color.Black
            Me.LblProfitLossWinValue.Text = "$ 0.00" : Me.LblProfitLossWinValue.ForeColor = Color.Black
            Me.LblProfitLossPlaceValue.Text = "$ 0.00" : Me.LblProfitLossPlaceValue.ForeColor = Color.Black
            Me.LblPLPlacePercentValue.Text = "0.00" : Me.LblPLPlacePercentValue.ForeColor = Color.Black
            Me.LblPLWinPercentValue.Text = "0.00" : Me.LblPLWinPercentValue.ForeColor = Color.Black
            Me.DGV_RESULTS.Rows.Clear()
        End Sub
#End Region
        Private Sub DGV_RESULTS_CellMouseClick(ByVal sender As Object, ByVal e As DataGridViewCellMouseEventArgs) Handles DGV_RESULTS.CellMouseClick
            If e.RowIndex < 0 OrElse e.ColumnIndex < 0 Then Exit Sub
            If e.ColumnIndex <> Me.DGV_NAME.Index Then

            End If
            Me.Cursor = Cursors.WaitCursor

            Me._Popup = New CascadeCommon.PopUp

            'Dim PARAMETERS() As String = Split(Me.DGV_RESULTS.Rows(e.RowIndex).Cells(Me.DGV_NUMBER.Index).Tag.ToString, "|")
            'MY_DISPLAYRACE = New UC_DISPLAYRACE(PARAMETERS(0), PARAMETERS(1), PARAMETERS(2), PARAMETERS(3), PARAMETERS(4), Me._Connection)
            'MY_DISPLAYRACE.Dock = DockStyle.Fill

            'MY_POPUP.Controls.Add(MY_DISPLAYRACE)
            'MY_POPUP.Size = MY_DISPLAYRACE.Size
            'MY_POPUP.WindowState = FormWindowState.Maximized
            'MY_POPUP.Text = "(M" & PARAMETERS(1) & " R" & PARAMETERS(4) & "- " & PARAMETERS(5) & ")"
            'MY_POPUP.Show(Me)

            Me.Cursor = Cursors.Default
        End Sub
    End Class
End Namespace