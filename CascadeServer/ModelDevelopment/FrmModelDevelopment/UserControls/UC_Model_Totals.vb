Namespace ModelDevelopment
    Partial Class FrmModelDevelopment
        Partial Class UserControls
            Friend NotInheritable Class UC_Model_Totals
                Private _Connection As Utils.Connection
                Private Sub New()
                    InitializeComponent()
                End Sub
                Friend Sub New(Connection As Utils.Connection)
                    Me.New
                    Me._Connection = Connection

                    Call ResetValues()
                End Sub
                Friend Sub Populate(StartOADate As String, EndOADate As String, TotalRaces As Long, WinRaces As Long, PlaceRaces As Long, WinCount As Long, PlaceCount As Long, ProfitLossWin As Decimal, ProfitLossPlace As Decimal, Optional Length As String = Nothing)
                    Me.LBL_DAYSVALUE.Text = FormatNumber((CInt(EndOADate) - CInt(StartOADate)) + 1, 0)
                    Call PopulateDatabaseFields(StartOADate, EndOADate, Length)
                    '
                    Me.LblTotalRacesValue.Text = "W: " & FormatNumber(WinRaces, 0) & " - P: " & FormatNumber(PlaceRaces, 0)
                    Me.LblTotalWinsValue.Text = FormatNumber(WinCount, 0)
                    Me.LblTotalPlacesValue.Text = FormatNumber(PlaceCount, 0)
                    Me.LblWinRateValue.Text = FormatPercent(WinCount / WinRaces, 2)
                    If (WinRaces > 0) AndAlso (CDec(WinCount / WinRaces) < 0) Then Me.LblWinRateValue.ForeColor = Color.Red Else Me.LblWinRateValue.ForeColor = Color.Black
                    Me.LblPlaceRateValue.Text = FormatPercent(PlaceCount / PlaceRaces, 2) : If CDec(PlaceCount / PlaceRaces) < 0 Then Me.LblPlaceRateValue.ForeColor = Color.Red Else Me.LblPlaceRateValue.ForeColor = Color.Black
                    Me.LblProfitLossWinValue.Text = FormatCurrency(ProfitLossWin, 2) : If CDec(ProfitLossWin) < 0 Then Me.LblProfitLossWinValue.ForeColor = Color.Red Else Me.LblProfitLossWinValue.ForeColor = Color.Black
                    Me.LblProfitLossPlaceValue.Text = FormatCurrency(ProfitLossPlace, 2) : If CDec(ProfitLossPlace) < 0 Then Me.LblProfitLossPlaceValue.ForeColor = Color.Red Else Me.LblProfitLossPlaceValue.ForeColor = Color.Black
                    '
                    Me.LblPLPlacePercentValue.Text = FormatPercent(ProfitLossPlace / PlaceRaces, 2) : If CDec(ProfitLossPlace / PlaceRaces) < 0 Then Me.LblPLPlacePercentValue.ForeColor = Color.Red Else Me.LblPLPlacePercentValue.ForeColor = Color.Black
                    If WinRaces > 0 Then Me.LblPLWinPercentValue.Text = FormatPercent(ProfitLossWin / WinRaces, 2) : If CDec(ProfitLossWin / WinRaces) < 0 Then Me.LblPLWinPercentValue.ForeColor = Color.Red Else Me.LblPLWinPercentValue.ForeColor = Color.Black
                    '
                    Me.LBL_HITS_VALUE.Text = FormatPercent(TotalRaces / CInt(Me.LBL_RACES_VALUE.Text), 2)
                End Sub
                Private Sub PopulateDatabaseFields(ByVal STARTOADATE As String, ByVal ENDOADATE As String, ByVal Length As String)
                    '
                    Dim MY_FILTER As String = "WHERE (MEETING_INFO.OADATE >= " & STARTOADATE & ") AND (MEETING_INFO.OADATE <=" & ENDOADATE & ")"
                    '
                    Dim MeetingCount As Long, RaceCount As Long, EntryCount As Long
                    Dim CMDTEXT As String = "SELECT COUNT(MEETING_INFO.OADATE) AS COUNT FROM MEETING_INFO "
                    CMDTEXT += MY_FILTER

                    MeetingCount = CInt(Me._Connection.ExecuteScalar(CMDTEXT))
                    Me.LBL_MEETING_VALUE.Text = FormatNumber(MeetingCount, 0)
                    '
                    If Not Length Is Nothing Then MY_FILTER += " AND (RACE_INFO.LENGTH=" & Length & ")"
                    CMDTEXT = "SELECT COUNT(RACE_INFO.NUMBER) AS COUNT "
                    CMDTEXT = String.Concat(CMDTEXT, "FROM MEETING_INFO RIGHT OUTER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER ")
                    CMDTEXT = String.Concat(CMDTEXT, MY_FILTER)
                    RaceCount = CInt(Me._Connection.ExecuteScalar(CMDTEXT))
                    Me.LBL_RACES_VALUE.Text = FormatNumber(RaceCount, 0)
                    '
                    CMDTEXT = "SELECT COUNT(ENTRY_INFO.NUMBER) AS COUNT "
                    CMDTEXT = String.Concat(CMDTEXT, "FROM ENTRY_INFO LEFT OUTER JOIN RACE_INFO ON ENTRY_INFO.MEETING_INFO_OADATE = RACE_INFO.MEETING_INFO_OADATE AND ENTRY_INFO.MEETING_INFO_NUMBER = RACE_INFO.MEETING_INFO_NUMBER AND ENTRY_INFO.RACE_INFO_NUMBER = RACE_INFO.NUMBER LEFT OUTER JOIN MEETING_INFO ON RACE_INFO.MEETING_INFO_OADATE = MEETING_INFO.OADATE AND RACE_INFO.MEETING_INFO_NUMBER = MEETING_INFO.NUMBER ")
                    CMDTEXT = String.Concat(CMDTEXT, MY_FILTER)
                    EntryCount = CInt(Me._Connection.ExecuteScalar(CMDTEXT))
                    Me.LBL_ENTRIES_VALUE.Text = FormatNumber(EntryCount, 0)
                End Sub

                Public Sub ResetValues()
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
                End Sub
            End Class
        End Class
    End Class
End Namespace