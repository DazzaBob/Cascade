Imports System.Drawing
Imports Microsoft.Identity.Client

Namespace UserControls
    Friend Class UC_Model_Totals
        Friend Sub New()
            InitializeComponent()
            Call ResetValues()
        End Sub
        Friend Sub Populate(TotalRaces As Long, WinRaces As Long, PlaceRaces As Long, WinCount As Long, PlaceCount As Long, ProfitLossWin As Decimal, ProfitLossPlace As Decimal, Optional Length As String = Nothing)
            Me.LBL_DAYSVALUE.Text = FormatNumber((CInt(FinishOADate) - CInt(StartOADate)) + 1, 0)
            Me.LBL_MEETING_VALUE.Text = FormatNumber(Common.TotalMeetings, 0)
            Me.LBL_RACES_VALUE.Text = FormatNumber(Common.TotalRaces, 0)
            Me.LBL_ENTRIES_VALUE.Text = FormatNumber(Common.TotalEntries)
            '
            Me.LblTotalRacesValue.Text = "W: " & FormatNumber(WinRaces, 0) & " - P: " & FormatNumber(PlaceRaces, 0)
            Me.LblTotalWinsValue.Text = FormatNumber(WinCount, 0)
            Me.LblTotalPlacesValue.Text = FormatNumber(PlaceCount, 0)
            Me.LblWinRateValue.Text = FormatPercent(WinCount / WinRaces, 2)
            If (WinRaces > 0) AndAlso (CDec(WinCount / WinRaces) < 0) Then Me.LblWinRateValue.ForeColor = Color.Red Else Me.LblWinRateValue.ForeColor = Color.Black
            Me.LblPlaceRateValue.Text = FormatPercent(PlaceCount / PlaceRaces, 2) : If CDec(PlaceCount / PlaceRaces) < 0 Then Me.LblPlaceRateValue.ForeColor = Color.Red Else Me.LblPlaceRateValue.ForeColor = Color.Black

            '
            Me.LBLTotalPlacingPercentValue.Text = FormatPercent(ProfitLossPlace / PlaceRaces, 2) : If CDec(ProfitLossPlace / PlaceRaces) < 0 Then Me.LBLTotalPlacingPercentValue.ForeColor = Color.Red Else Me.LBLTotalPlacingPercentValue.ForeColor = Color.Black
            If WinRaces > 0 Then Me.LblPLWinPercentValue.Text = FormatPercent(ProfitLossWin / WinRaces, 2) : If CDec(ProfitLossWin / WinRaces) < 0 Then Me.LblPLWinPercentValue.ForeColor = Color.Red Else Me.LblPLWinPercentValue.ForeColor = Color.Black
            '
            Me.LBLTotalPlacingPercentValue.Text = FormatPercent((WinCount + PlaceCount) / TotalRaces, 2)
            Me.LBL_HITS_VALUE.Text = FormatPercent(TotalRaces / CInt(Me.LBL_RACES_VALUE.Text), 2)
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
            Me.LBLTotalPlacingPercentValue.Text = "0.00" : Me.LBLTotalPlacingPercentValue.ForeColor = Color.Black
            Me.LblPLWinPercentValue.Text = "0.00" : Me.LblPLWinPercentValue.ForeColor = Color.Black
        End Sub
    End Class
End Namespace