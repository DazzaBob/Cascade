Namespace UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_Model_Totals
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            TLPModelTotals = New TableLayoutPanel()
            LBL_HITS_VALUE = New Label()
            LBL_HITS = New Label()
            LBL_ENTRIES_VALUE = New Label()
            LBL_ENTRIES = New Label()
            LBL_RACES_VALUE = New Label()
            LBL_RACES = New Label()
            LBL_MEETING_VALUE = New Label()
            LBL_MEETINGS = New Label()
            LBL_DAYSVALUE = New Label()
            LblProfitLossWinValue = New Label()
            LblProfitLossWin = New Label()
            LblTotalRaces = New Label()
            LblTotalWins = New Label()
            LblTotalPlaces = New Label()
            LblWinRate = New Label()
            LblPlaceRate = New Label()
            LblTotalRacesValue = New Label()
            LblTotalWinsValue = New Label()
            LblTotalPlacesValue = New Label()
            LblWinRateValue = New Label()
            LblPlaceRateValue = New Label()
            LblProfitLoss = New Label()
            LblPLWinPercent = New Label()
            LblPLPlacePercent = New Label()
            LblProfitLossPlaceValue = New Label()
            LblPLWinPercentValue = New Label()
            LblPLPlacePercentValue = New Label()
            LBL_DAYS = New Label()
            TLPModelTotals.SuspendLayout()
            SuspendLayout()
            ' 
            ' TLPModelTotals
            ' 
            TLPModelTotals.ColumnCount = 10
            TLPModelTotals.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            TLPModelTotals.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            TLPModelTotals.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            TLPModelTotals.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            TLPModelTotals.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            TLPModelTotals.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            TLPModelTotals.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            TLPModelTotals.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            TLPModelTotals.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            TLPModelTotals.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 10F))
            TLPModelTotals.Controls.Add(LBL_HITS_VALUE, 9, 0)
            TLPModelTotals.Controls.Add(LBL_HITS, 8, 0)
            TLPModelTotals.Controls.Add(LBL_ENTRIES_VALUE, 7, 0)
            TLPModelTotals.Controls.Add(LBL_ENTRIES, 6, 0)
            TLPModelTotals.Controls.Add(LBL_RACES_VALUE, 5, 0)
            TLPModelTotals.Controls.Add(LBL_RACES, 4, 0)
            TLPModelTotals.Controls.Add(LBL_MEETING_VALUE, 3, 0)
            TLPModelTotals.Controls.Add(LBL_MEETINGS, 2, 0)
            TLPModelTotals.Controls.Add(LBL_DAYSVALUE, 1, 0)
            TLPModelTotals.Controls.Add(LblProfitLossWinValue, 0, 2)
            TLPModelTotals.Controls.Add(LblProfitLossWin, 0, 2)
            TLPModelTotals.Controls.Add(LblTotalRaces, 0, 1)
            TLPModelTotals.Controls.Add(LblTotalWins, 2, 1)
            TLPModelTotals.Controls.Add(LblTotalPlaces, 4, 1)
            TLPModelTotals.Controls.Add(LblWinRate, 6, 1)
            TLPModelTotals.Controls.Add(LblPlaceRate, 8, 1)
            TLPModelTotals.Controls.Add(LblTotalRacesValue, 1, 1)
            TLPModelTotals.Controls.Add(LblTotalWinsValue, 3, 1)
            TLPModelTotals.Controls.Add(LblTotalPlacesValue, 5, 1)
            TLPModelTotals.Controls.Add(LblWinRateValue, 7, 1)
            TLPModelTotals.Controls.Add(LblPlaceRateValue, 9, 1)
            TLPModelTotals.Controls.Add(LblProfitLoss, 2, 2)
            TLPModelTotals.Controls.Add(LblPLWinPercent, 4, 2)
            TLPModelTotals.Controls.Add(LblPLPlacePercent, 6, 2)
            TLPModelTotals.Controls.Add(LblProfitLossPlaceValue, 3, 2)
            TLPModelTotals.Controls.Add(LblPLWinPercentValue, 5, 2)
            TLPModelTotals.Controls.Add(LblPLPlacePercentValue, 7, 2)
            TLPModelTotals.Controls.Add(LBL_DAYS, 0, 0)
            TLPModelTotals.Dock = DockStyle.Fill
            TLPModelTotals.Location = New Point(0, 0)
            TLPModelTotals.Margin = New Padding(0)
            TLPModelTotals.Name = "TLPModelTotals"
            TLPModelTotals.RowCount = 3
            TLPModelTotals.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
            TLPModelTotals.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
            TLPModelTotals.RowStyles.Add(New RowStyle(SizeType.Absolute, 20F))
            TLPModelTotals.Size = New Size(890, 244)
            TLPModelTotals.TabIndex = 0
            ' 
            ' LBL_HITS_VALUE
            ' 
            LBL_HITS_VALUE.AutoEllipsis = True
            LBL_HITS_VALUE.Cursor = Cursors.IBeam
            LBL_HITS_VALUE.Dock = DockStyle.Fill
            LBL_HITS_VALUE.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LBL_HITS_VALUE.Location = New Point(801, 0)
            LBL_HITS_VALUE.Margin = New Padding(0)
            LBL_HITS_VALUE.Name = "LBL_HITS_VALUE"
            LBL_HITS_VALUE.RightToLeft = RightToLeft.No
            LBL_HITS_VALUE.Size = New Size(89, 20)
            LBL_HITS_VALUE.TabIndex = 1095
            LBL_HITS_VALUE.Text = "000,000%"
            LBL_HITS_VALUE.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LBL_HITS
            ' 
            LBL_HITS.AutoEllipsis = True
            LBL_HITS.AutoSize = True
            LBL_HITS.Dock = DockStyle.Fill
            LBL_HITS.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_HITS.Location = New Point(712, 0)
            LBL_HITS.Margin = New Padding(0)
            LBL_HITS.Name = "LBL_HITS"
            LBL_HITS.Size = New Size(89, 20)
            LBL_HITS.TabIndex = 1094
            LBL_HITS.Text = "HITS:"
            LBL_HITS.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LBL_ENTRIES_VALUE
            ' 
            LBL_ENTRIES_VALUE.AutoEllipsis = True
            LBL_ENTRIES_VALUE.AutoSize = True
            LBL_ENTRIES_VALUE.Cursor = Cursors.IBeam
            LBL_ENTRIES_VALUE.Dock = DockStyle.Fill
            LBL_ENTRIES_VALUE.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LBL_ENTRIES_VALUE.Location = New Point(623, 0)
            LBL_ENTRIES_VALUE.Margin = New Padding(0)
            LBL_ENTRIES_VALUE.Name = "LBL_ENTRIES_VALUE"
            LBL_ENTRIES_VALUE.RightToLeft = RightToLeft.No
            LBL_ENTRIES_VALUE.Size = New Size(89, 20)
            LBL_ENTRIES_VALUE.TabIndex = 1093
            LBL_ENTRIES_VALUE.Text = "000,000"
            LBL_ENTRIES_VALUE.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LBL_ENTRIES
            ' 
            LBL_ENTRIES.AutoEllipsis = True
            LBL_ENTRIES.AutoSize = True
            LBL_ENTRIES.Dock = DockStyle.Fill
            LBL_ENTRIES.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_ENTRIES.Location = New Point(534, 0)
            LBL_ENTRIES.Margin = New Padding(0)
            LBL_ENTRIES.Name = "LBL_ENTRIES"
            LBL_ENTRIES.Size = New Size(89, 20)
            LBL_ENTRIES.TabIndex = 1092
            LBL_ENTRIES.Text = "ENTRIES:"
            LBL_ENTRIES.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LBL_RACES_VALUE
            ' 
            LBL_RACES_VALUE.AutoEllipsis = True
            LBL_RACES_VALUE.AutoSize = True
            LBL_RACES_VALUE.Cursor = Cursors.IBeam
            LBL_RACES_VALUE.Dock = DockStyle.Fill
            LBL_RACES_VALUE.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LBL_RACES_VALUE.Location = New Point(445, 0)
            LBL_RACES_VALUE.Margin = New Padding(0)
            LBL_RACES_VALUE.Name = "LBL_RACES_VALUE"
            LBL_RACES_VALUE.RightToLeft = RightToLeft.No
            LBL_RACES_VALUE.Size = New Size(89, 20)
            LBL_RACES_VALUE.TabIndex = 1091
            LBL_RACES_VALUE.Text = "000,000"
            LBL_RACES_VALUE.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LBL_RACES
            ' 
            LBL_RACES.AutoEllipsis = True
            LBL_RACES.AutoSize = True
            LBL_RACES.Dock = DockStyle.Fill
            LBL_RACES.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_RACES.Location = New Point(356, 0)
            LBL_RACES.Margin = New Padding(0)
            LBL_RACES.Name = "LBL_RACES"
            LBL_RACES.Size = New Size(89, 20)
            LBL_RACES.TabIndex = 1090
            LBL_RACES.Text = "RACES:"
            LBL_RACES.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LBL_MEETING_VALUE
            ' 
            LBL_MEETING_VALUE.AutoEllipsis = True
            LBL_MEETING_VALUE.AutoSize = True
            LBL_MEETING_VALUE.Cursor = Cursors.IBeam
            LBL_MEETING_VALUE.Dock = DockStyle.Fill
            LBL_MEETING_VALUE.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LBL_MEETING_VALUE.Location = New Point(267, 0)
            LBL_MEETING_VALUE.Margin = New Padding(0)
            LBL_MEETING_VALUE.Name = "LBL_MEETING_VALUE"
            LBL_MEETING_VALUE.RightToLeft = RightToLeft.No
            LBL_MEETING_VALUE.Size = New Size(89, 20)
            LBL_MEETING_VALUE.TabIndex = 1089
            LBL_MEETING_VALUE.Text = "000,000"
            LBL_MEETING_VALUE.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LBL_MEETINGS
            ' 
            LBL_MEETINGS.AutoEllipsis = True
            LBL_MEETINGS.AutoSize = True
            LBL_MEETINGS.Dock = DockStyle.Fill
            LBL_MEETINGS.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_MEETINGS.Location = New Point(178, 0)
            LBL_MEETINGS.Margin = New Padding(0)
            LBL_MEETINGS.Name = "LBL_MEETINGS"
            LBL_MEETINGS.Size = New Size(89, 20)
            LBL_MEETINGS.TabIndex = 1088
            LBL_MEETINGS.Text = "MEETINGS:"
            LBL_MEETINGS.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LBL_DAYSVALUE
            ' 
            LBL_DAYSVALUE.AutoEllipsis = True
            LBL_DAYSVALUE.AutoSize = True
            LBL_DAYSVALUE.Cursor = Cursors.IBeam
            LBL_DAYSVALUE.Dock = DockStyle.Fill
            LBL_DAYSVALUE.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LBL_DAYSVALUE.Location = New Point(89, 0)
            LBL_DAYSVALUE.Margin = New Padding(0)
            LBL_DAYSVALUE.Name = "LBL_DAYSVALUE"
            LBL_DAYSVALUE.RightToLeft = RightToLeft.No
            LBL_DAYSVALUE.Size = New Size(89, 20)
            LBL_DAYSVALUE.TabIndex = 1087
            LBL_DAYSVALUE.Text = "000,000"
            LBL_DAYSVALUE.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblProfitLossWinValue
            ' 
            LblProfitLossWinValue.AutoEllipsis = True
            LblProfitLossWinValue.Cursor = Cursors.IBeam
            LblProfitLossWinValue.Dock = DockStyle.Fill
            LblProfitLossWinValue.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LblProfitLossWinValue.Location = New Point(89, 40)
            LblProfitLossWinValue.Margin = New Padding(0)
            LblProfitLossWinValue.Name = "LblProfitLossWinValue"
            LblProfitLossWinValue.RightToLeft = RightToLeft.No
            LblProfitLossWinValue.Size = New Size(89, 204)
            LblProfitLossWinValue.TabIndex = 1082
            LblProfitLossWinValue.Text = "$ 000.00"
            LblProfitLossWinValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblProfitLossWin
            ' 
            LblProfitLossWin.AutoEllipsis = True
            LblProfitLossWin.AutoSize = True
            LblProfitLossWin.Cursor = Cursors.IBeam
            LblProfitLossWin.Dock = DockStyle.Fill
            LblProfitLossWin.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LblProfitLossWin.Location = New Point(0, 40)
            LblProfitLossWin.Margin = New Padding(0)
            LblProfitLossWin.Name = "LblProfitLossWin"
            LblProfitLossWin.RightToLeft = RightToLeft.No
            LblProfitLossWin.Size = New Size(89, 204)
            LblProfitLossWin.TabIndex = 1079
            LblProfitLossWin.Text = "P/L (WIN):"
            LblProfitLossWin.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LblTotalRaces
            ' 
            LblTotalRaces.AutoEllipsis = True
            LblTotalRaces.AutoSize = True
            LblTotalRaces.Cursor = Cursors.IBeam
            LblTotalRaces.Dock = DockStyle.Fill
            LblTotalRaces.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LblTotalRaces.Location = New Point(0, 20)
            LblTotalRaces.Margin = New Padding(0)
            LblTotalRaces.Name = "LblTotalRaces"
            LblTotalRaces.RightToLeft = RightToLeft.No
            LblTotalRaces.Size = New Size(89, 20)
            LblTotalRaces.TabIndex = 1064
            LblTotalRaces.Text = "RACES:"
            LblTotalRaces.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LblTotalWins
            ' 
            LblTotalWins.AutoEllipsis = True
            LblTotalWins.AutoSize = True
            LblTotalWins.Cursor = Cursors.IBeam
            LblTotalWins.Dock = DockStyle.Fill
            LblTotalWins.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LblTotalWins.ImageAlign = ContentAlignment.MiddleRight
            LblTotalWins.Location = New Point(178, 20)
            LblTotalWins.Margin = New Padding(0)
            LblTotalWins.Name = "LblTotalWins"
            LblTotalWins.RightToLeft = RightToLeft.No
            LblTotalWins.Size = New Size(89, 20)
            LblTotalWins.TabIndex = 1066
            LblTotalWins.Text = "WINS:"
            LblTotalWins.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LblTotalPlaces
            ' 
            LblTotalPlaces.AutoEllipsis = True
            LblTotalPlaces.AutoSize = True
            LblTotalPlaces.Cursor = Cursors.IBeam
            LblTotalPlaces.Dock = DockStyle.Fill
            LblTotalPlaces.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LblTotalPlaces.Location = New Point(356, 20)
            LblTotalPlaces.Margin = New Padding(0)
            LblTotalPlaces.Name = "LblTotalPlaces"
            LblTotalPlaces.RightToLeft = RightToLeft.No
            LblTotalPlaces.Size = New Size(89, 20)
            LblTotalPlaces.TabIndex = 1068
            LblTotalPlaces.Text = "PLACES:"
            LblTotalPlaces.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LblWinRate
            ' 
            LblWinRate.AutoEllipsis = True
            LblWinRate.AutoSize = True
            LblWinRate.Cursor = Cursors.IBeam
            LblWinRate.Dock = DockStyle.Fill
            LblWinRate.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LblWinRate.Location = New Point(534, 20)
            LblWinRate.Margin = New Padding(0)
            LblWinRate.Name = "LblWinRate"
            LblWinRate.RightToLeft = RightToLeft.No
            LblWinRate.Size = New Size(89, 20)
            LblWinRate.TabIndex = 1070
            LblWinRate.Text = "WIN %:"
            LblWinRate.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LblPlaceRate
            ' 
            LblPlaceRate.AutoEllipsis = True
            LblPlaceRate.AutoSize = True
            LblPlaceRate.Cursor = Cursors.IBeam
            LblPlaceRate.Dock = DockStyle.Fill
            LblPlaceRate.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LblPlaceRate.ImageAlign = ContentAlignment.TopCenter
            LblPlaceRate.Location = New Point(712, 20)
            LblPlaceRate.Margin = New Padding(0)
            LblPlaceRate.Name = "LblPlaceRate"
            LblPlaceRate.RightToLeft = RightToLeft.No
            LblPlaceRate.Size = New Size(89, 20)
            LblPlaceRate.TabIndex = 1072
            LblPlaceRate.Text = "PLACE %:"
            LblPlaceRate.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LblTotalRacesValue
            ' 
            LblTotalRacesValue.AutoEllipsis = True
            LblTotalRacesValue.AutoSize = True
            LblTotalRacesValue.Cursor = Cursors.IBeam
            LblTotalRacesValue.Dock = DockStyle.Fill
            LblTotalRacesValue.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LblTotalRacesValue.Location = New Point(89, 20)
            LblTotalRacesValue.Margin = New Padding(0)
            LblTotalRacesValue.Name = "LblTotalRacesValue"
            LblTotalRacesValue.RightToLeft = RightToLeft.No
            LblTotalRacesValue.Size = New Size(89, 20)
            LblTotalRacesValue.TabIndex = 1073
            LblTotalRacesValue.Text = "000,000"
            LblTotalRacesValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblTotalWinsValue
            ' 
            LblTotalWinsValue.AutoEllipsis = True
            LblTotalWinsValue.AutoSize = True
            LblTotalWinsValue.Cursor = Cursors.IBeam
            LblTotalWinsValue.Dock = DockStyle.Fill
            LblTotalWinsValue.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LblTotalWinsValue.Location = New Point(267, 20)
            LblTotalWinsValue.Margin = New Padding(0)
            LblTotalWinsValue.Name = "LblTotalWinsValue"
            LblTotalWinsValue.RightToLeft = RightToLeft.No
            LblTotalWinsValue.Size = New Size(89, 20)
            LblTotalWinsValue.TabIndex = 1074
            LblTotalWinsValue.Text = "000,000"
            LblTotalWinsValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblTotalPlacesValue
            ' 
            LblTotalPlacesValue.AutoEllipsis = True
            LblTotalPlacesValue.Cursor = Cursors.IBeam
            LblTotalPlacesValue.Dock = DockStyle.Fill
            LblTotalPlacesValue.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LblTotalPlacesValue.Location = New Point(445, 20)
            LblTotalPlacesValue.Margin = New Padding(0)
            LblTotalPlacesValue.Name = "LblTotalPlacesValue"
            LblTotalPlacesValue.RightToLeft = RightToLeft.No
            LblTotalPlacesValue.Size = New Size(89, 20)
            LblTotalPlacesValue.TabIndex = 1075
            LblTotalPlacesValue.Text = "000,000"
            LblTotalPlacesValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblWinRateValue
            ' 
            LblWinRateValue.AutoEllipsis = True
            LblWinRateValue.Cursor = Cursors.IBeam
            LblWinRateValue.Dock = DockStyle.Fill
            LblWinRateValue.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LblWinRateValue.Location = New Point(623, 20)
            LblWinRateValue.Margin = New Padding(0)
            LblWinRateValue.Name = "LblWinRateValue"
            LblWinRateValue.RightToLeft = RightToLeft.No
            LblWinRateValue.Size = New Size(89, 20)
            LblWinRateValue.TabIndex = 1076
            LblWinRateValue.Text = "000,000%"
            LblWinRateValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblPlaceRateValue
            ' 
            LblPlaceRateValue.AutoEllipsis = True
            LblPlaceRateValue.Cursor = Cursors.IBeam
            LblPlaceRateValue.Dock = DockStyle.Fill
            LblPlaceRateValue.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LblPlaceRateValue.Location = New Point(801, 20)
            LblPlaceRateValue.Margin = New Padding(0)
            LblPlaceRateValue.Name = "LblPlaceRateValue"
            LblPlaceRateValue.RightToLeft = RightToLeft.No
            LblPlaceRateValue.Size = New Size(89, 20)
            LblPlaceRateValue.TabIndex = 1077
            LblPlaceRateValue.Text = "000,000%"
            LblPlaceRateValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblProfitLoss
            ' 
            LblProfitLoss.AutoEllipsis = True
            LblProfitLoss.AutoSize = True
            LblProfitLoss.Cursor = Cursors.IBeam
            LblProfitLoss.Dock = DockStyle.Fill
            LblProfitLoss.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LblProfitLoss.Location = New Point(178, 40)
            LblProfitLoss.Margin = New Padding(0)
            LblProfitLoss.Name = "LblProfitLoss"
            LblProfitLoss.RightToLeft = RightToLeft.No
            LblProfitLoss.Size = New Size(89, 204)
            LblProfitLoss.TabIndex = 1078
            LblProfitLoss.Text = "P/L (PLACE):"
            LblProfitLoss.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LblPLWinPercent
            ' 
            LblPLWinPercent.AutoEllipsis = True
            LblPLWinPercent.AutoSize = True
            LblPLWinPercent.Cursor = Cursors.IBeam
            LblPLWinPercent.Dock = DockStyle.Fill
            LblPLWinPercent.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LblPLWinPercent.Location = New Point(356, 40)
            LblPLWinPercent.Margin = New Padding(0)
            LblPLWinPercent.Name = "LblPLWinPercent"
            LblPLWinPercent.RightToLeft = RightToLeft.No
            LblPLWinPercent.Size = New Size(89, 204)
            LblPLWinPercent.TabIndex = 1080
            LblPLWinPercent.Text = "P/L (WIN %):"
            LblPLWinPercent.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LblPLPlacePercent
            ' 
            LblPLPlacePercent.AutoEllipsis = True
            LblPLPlacePercent.AutoSize = True
            LblPLPlacePercent.Cursor = Cursors.IBeam
            LblPLPlacePercent.Dock = DockStyle.Fill
            LblPLPlacePercent.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LblPLPlacePercent.Location = New Point(534, 40)
            LblPLPlacePercent.Margin = New Padding(0)
            LblPLPlacePercent.Name = "LblPLPlacePercent"
            LblPLPlacePercent.RightToLeft = RightToLeft.No
            LblPLPlacePercent.Size = New Size(89, 204)
            LblPLPlacePercent.TabIndex = 1081
            LblPLPlacePercent.Text = "P/L (PLACE %):"
            LblPLPlacePercent.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LblProfitLossPlaceValue
            ' 
            LblProfitLossPlaceValue.AutoEllipsis = True
            LblProfitLossPlaceValue.Cursor = Cursors.IBeam
            LblProfitLossPlaceValue.Dock = DockStyle.Fill
            LblProfitLossPlaceValue.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LblProfitLossPlaceValue.Location = New Point(267, 40)
            LblProfitLossPlaceValue.Margin = New Padding(0)
            LblProfitLossPlaceValue.Name = "LblProfitLossPlaceValue"
            LblProfitLossPlaceValue.RightToLeft = RightToLeft.No
            LblProfitLossPlaceValue.Size = New Size(89, 204)
            LblProfitLossPlaceValue.TabIndex = 1083
            LblProfitLossPlaceValue.Text = "$ 000.00"
            LblProfitLossPlaceValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblPLWinPercentValue
            ' 
            LblPLWinPercentValue.AutoEllipsis = True
            LblPLWinPercentValue.Cursor = Cursors.IBeam
            LblPLWinPercentValue.Dock = DockStyle.Fill
            LblPLWinPercentValue.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LblPLWinPercentValue.Location = New Point(445, 40)
            LblPLWinPercentValue.Margin = New Padding(0)
            LblPLWinPercentValue.Name = "LblPLWinPercentValue"
            LblPLWinPercentValue.RightToLeft = RightToLeft.No
            LblPLWinPercentValue.Size = New Size(89, 204)
            LblPLWinPercentValue.TabIndex = 1084
            LblPLWinPercentValue.Text = "000.00"
            LblPLWinPercentValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblPLPlacePercentValue
            ' 
            LblPLPlacePercentValue.AutoEllipsis = True
            LblPLPlacePercentValue.Cursor = Cursors.IBeam
            LblPLPlacePercentValue.Dock = DockStyle.Fill
            LblPLPlacePercentValue.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            LblPLPlacePercentValue.Location = New Point(623, 40)
            LblPLPlacePercentValue.Margin = New Padding(0)
            LblPLPlacePercentValue.Name = "LblPLPlacePercentValue"
            LblPLPlacePercentValue.RightToLeft = RightToLeft.No
            LblPLPlacePercentValue.Size = New Size(89, 204)
            LblPLPlacePercentValue.TabIndex = 1085
            LblPLPlacePercentValue.Text = "000.00"
            LblPLPlacePercentValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LBL_DAYS
            ' 
            LBL_DAYS.AutoEllipsis = True
            LBL_DAYS.AutoSize = True
            LBL_DAYS.Dock = DockStyle.Fill
            LBL_DAYS.Font = New Font("Calibri", 8.25F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_DAYS.Location = New Point(0, 0)
            LBL_DAYS.Margin = New Padding(0)
            LBL_DAYS.Name = "LBL_DAYS"
            LBL_DAYS.Size = New Size(89, 20)
            LBL_DAYS.TabIndex = 1086
            LBL_DAYS.Text = "DAYS:"
            LBL_DAYS.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' UC_Model_Totals
            ' 
            AutoScaleDimensions = New SizeF(14F, 33F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.Transparent
            Controls.Add(TLPModelTotals)
            DoubleBuffered = True
            Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            Margin = New Padding(0)
            Name = "UC_Model_Totals"
            Size = New Size(890, 244)
            TLPModelTotals.ResumeLayout(False)
            TLPModelTotals.PerformLayout()
            ResumeLayout(False)
        End Sub
        Private WithEvents TLPModelTotals As TableLayoutPanel
        Private WithEvents LblTotalRaces As Label
        Private WithEvents LblTotalWins As Label
        Private WithEvents LblTotalPlaces As Label
        Private WithEvents LblWinRate As Label
        Private WithEvents LblPlaceRate As Label
        Private WithEvents LblTotalRacesValue As Label
        Private WithEvents LblTotalWinsValue As Label
        Private WithEvents LblTotalPlacesValue As Label
        Private WithEvents LblWinRateValue As Label
        Private WithEvents LblPlaceRateValue As Label
        Private WithEvents LblProfitLoss As Label
        Private WithEvents LblProfitLossWin As Label
        Private WithEvents LblPLWinPercent As Label
        Private WithEvents LblPLPlacePercent As Label
        Private WithEvents LblProfitLossWinValue As Label
        Private WithEvents LblProfitLossPlaceValue As Label
        Private WithEvents LblPLWinPercentValue As Label
        Private WithEvents LblPLPlacePercentValue As Label
        Private WithEvents LBL_DAYSVALUE As Label
        Private WithEvents LBL_DAYS As Label
        Private WithEvents LBL_MEETINGS As Label
        Private WithEvents LBL_ENTRIES_VALUE As Label
        Private WithEvents LBL_ENTRIES As Label
        Private WithEvents LBL_RACES_VALUE As Label
        Private WithEvents LBL_RACES As Label
        Private WithEvents LBL_MEETING_VALUE As Label
        Private WithEvents LBL_HITS As Label
        Private WithEvents LBL_HITS_VALUE As Label

    End Class
End Namespace