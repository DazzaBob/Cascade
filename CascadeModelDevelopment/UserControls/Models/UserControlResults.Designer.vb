Namespace UserControls.Models
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class UserControlResults
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As DataGridViewCellStyle = New DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As DataGridViewCellStyle = New DataGridViewCellStyle()
            GroupBoxTotals = New GroupBox()
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
            LBL_RANGE_HEADER = New Label()
            DGV_RESULTS = New DataGridView()
            DGV_DATE = New DataGridViewTextBoxColumn()
            DGV_NUMBER = New DataGridViewTextBoxColumn()
            DGV_BARRIER = New DataGridViewTextBoxColumn()
            DGV_NAME = New DataGridViewLinkColumn()
            DGV_CLASS = New DataGridViewTextBoxColumn()
            DGV_MEETINGNAME = New DataGridViewTextBoxColumn()
            DGV_RACELENGTH = New DataGridViewTextBoxColumn()
            DGV_VENUE = New DataGridViewTextBoxColumn()
            DGV_WEATHER = New DataGridViewTextBoxColumn()
            DGV_TRACK = New DataGridViewTextBoxColumn()
            DGV_FINISHPOSITION = New DataGridViewTextBoxColumn()
            DGV_WINS = New DataGridViewTextBoxColumn()
            DGV_PLACES = New DataGridViewTextBoxColumn()
            GroupBoxTotals.SuspendLayout()
            TLPModelTotals.SuspendLayout()
            CType(DGV_RESULTS, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' GroupBoxTotals
            ' 
            GroupBoxTotals.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            GroupBoxTotals.Controls.Add(TLPModelTotals)
            GroupBoxTotals.Location = New Point(0, 55)
            GroupBoxTotals.Margin = New Padding(0)
            GroupBoxTotals.Name = "GroupBoxTotals"
            GroupBoxTotals.Padding = New Padding(0)
            GroupBoxTotals.Size = New Size(2398, 288)
            GroupBoxTotals.TabIndex = 0
            GroupBoxTotals.TabStop = False
            GroupBoxTotals.Text = "Totals"
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
            TLPModelTotals.Location = New Point(0, 54)
            TLPModelTotals.Margin = New Padding(0)
            TLPModelTotals.Name = "TLPModelTotals"
            TLPModelTotals.RowCount = 3
            TLPModelTotals.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
            TLPModelTotals.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
            TLPModelTotals.RowStyles.Add(New RowStyle(SizeType.Percent, 33.3333321F))
            TLPModelTotals.Size = New Size(2398, 234)
            TLPModelTotals.TabIndex = 1
            ' 
            ' LBL_HITS_VALUE
            ' 
            LBL_HITS_VALUE.AutoEllipsis = True
            LBL_HITS_VALUE.Cursor = Cursors.IBeam
            LBL_HITS_VALUE.Dock = DockStyle.Fill
            LBL_HITS_VALUE.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LBL_HITS_VALUE.Location = New Point(2151, 0)
            LBL_HITS_VALUE.Margin = New Padding(0)
            LBL_HITS_VALUE.Name = "LBL_HITS_VALUE"
            LBL_HITS_VALUE.RightToLeft = RightToLeft.No
            LBL_HITS_VALUE.Size = New Size(247, 77)
            LBL_HITS_VALUE.TabIndex = 1095
            LBL_HITS_VALUE.Text = "000,000%"
            LBL_HITS_VALUE.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LBL_HITS
            ' 
            LBL_HITS.AutoEllipsis = True
            LBL_HITS.AutoSize = True
            LBL_HITS.Dock = DockStyle.Fill
            LBL_HITS.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_HITS.Location = New Point(1912, 0)
            LBL_HITS.Margin = New Padding(0)
            LBL_HITS.Name = "LBL_HITS"
            LBL_HITS.Size = New Size(239, 77)
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
            LBL_ENTRIES_VALUE.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LBL_ENTRIES_VALUE.Location = New Point(1673, 0)
            LBL_ENTRIES_VALUE.Margin = New Padding(0)
            LBL_ENTRIES_VALUE.Name = "LBL_ENTRIES_VALUE"
            LBL_ENTRIES_VALUE.RightToLeft = RightToLeft.No
            LBL_ENTRIES_VALUE.Size = New Size(239, 77)
            LBL_ENTRIES_VALUE.TabIndex = 1093
            LBL_ENTRIES_VALUE.Text = "000,000"
            LBL_ENTRIES_VALUE.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LBL_ENTRIES
            ' 
            LBL_ENTRIES.AutoEllipsis = True
            LBL_ENTRIES.AutoSize = True
            LBL_ENTRIES.Dock = DockStyle.Fill
            LBL_ENTRIES.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_ENTRIES.Location = New Point(1434, 0)
            LBL_ENTRIES.Margin = New Padding(0)
            LBL_ENTRIES.Name = "LBL_ENTRIES"
            LBL_ENTRIES.Size = New Size(239, 77)
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
            LBL_RACES_VALUE.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LBL_RACES_VALUE.Location = New Point(1195, 0)
            LBL_RACES_VALUE.Margin = New Padding(0)
            LBL_RACES_VALUE.Name = "LBL_RACES_VALUE"
            LBL_RACES_VALUE.RightToLeft = RightToLeft.No
            LBL_RACES_VALUE.Size = New Size(239, 77)
            LBL_RACES_VALUE.TabIndex = 1091
            LBL_RACES_VALUE.Text = "000,000"
            LBL_RACES_VALUE.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LBL_RACES
            ' 
            LBL_RACES.AutoEllipsis = True
            LBL_RACES.AutoSize = True
            LBL_RACES.Dock = DockStyle.Fill
            LBL_RACES.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_RACES.Location = New Point(956, 0)
            LBL_RACES.Margin = New Padding(0)
            LBL_RACES.Name = "LBL_RACES"
            LBL_RACES.Size = New Size(239, 77)
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
            LBL_MEETING_VALUE.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LBL_MEETING_VALUE.Location = New Point(717, 0)
            LBL_MEETING_VALUE.Margin = New Padding(0)
            LBL_MEETING_VALUE.Name = "LBL_MEETING_VALUE"
            LBL_MEETING_VALUE.RightToLeft = RightToLeft.No
            LBL_MEETING_VALUE.Size = New Size(239, 77)
            LBL_MEETING_VALUE.TabIndex = 1089
            LBL_MEETING_VALUE.Text = "000,000"
            LBL_MEETING_VALUE.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LBL_MEETINGS
            ' 
            LBL_MEETINGS.AutoEllipsis = True
            LBL_MEETINGS.AutoSize = True
            LBL_MEETINGS.Dock = DockStyle.Fill
            LBL_MEETINGS.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_MEETINGS.Location = New Point(478, 0)
            LBL_MEETINGS.Margin = New Padding(0)
            LBL_MEETINGS.Name = "LBL_MEETINGS"
            LBL_MEETINGS.Size = New Size(239, 77)
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
            LBL_DAYSVALUE.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LBL_DAYSVALUE.Location = New Point(239, 0)
            LBL_DAYSVALUE.Margin = New Padding(0)
            LBL_DAYSVALUE.Name = "LBL_DAYSVALUE"
            LBL_DAYSVALUE.RightToLeft = RightToLeft.No
            LBL_DAYSVALUE.Size = New Size(239, 77)
            LBL_DAYSVALUE.TabIndex = 1087
            LBL_DAYSVALUE.Text = "000,000"
            LBL_DAYSVALUE.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblProfitLossWinValue
            ' 
            LblProfitLossWinValue.AutoEllipsis = True
            LblProfitLossWinValue.Cursor = Cursors.IBeam
            LblProfitLossWinValue.Dock = DockStyle.Fill
            LblProfitLossWinValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LblProfitLossWinValue.Location = New Point(239, 154)
            LblProfitLossWinValue.Margin = New Padding(0)
            LblProfitLossWinValue.Name = "LblProfitLossWinValue"
            LblProfitLossWinValue.RightToLeft = RightToLeft.No
            LblProfitLossWinValue.Size = New Size(239, 80)
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
            LblProfitLossWin.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LblProfitLossWin.Location = New Point(0, 154)
            LblProfitLossWin.Margin = New Padding(0)
            LblProfitLossWin.Name = "LblProfitLossWin"
            LblProfitLossWin.RightToLeft = RightToLeft.No
            LblProfitLossWin.Size = New Size(239, 80)
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
            LblTotalRaces.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LblTotalRaces.Location = New Point(0, 77)
            LblTotalRaces.Margin = New Padding(0)
            LblTotalRaces.Name = "LblTotalRaces"
            LblTotalRaces.RightToLeft = RightToLeft.No
            LblTotalRaces.Size = New Size(239, 77)
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
            LblTotalWins.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LblTotalWins.ImageAlign = ContentAlignment.MiddleRight
            LblTotalWins.Location = New Point(478, 77)
            LblTotalWins.Margin = New Padding(0)
            LblTotalWins.Name = "LblTotalWins"
            LblTotalWins.RightToLeft = RightToLeft.No
            LblTotalWins.Size = New Size(239, 77)
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
            LblTotalPlaces.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LblTotalPlaces.Location = New Point(956, 77)
            LblTotalPlaces.Margin = New Padding(0)
            LblTotalPlaces.Name = "LblTotalPlaces"
            LblTotalPlaces.RightToLeft = RightToLeft.No
            LblTotalPlaces.Size = New Size(239, 77)
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
            LblWinRate.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LblWinRate.Location = New Point(1434, 77)
            LblWinRate.Margin = New Padding(0)
            LblWinRate.Name = "LblWinRate"
            LblWinRate.RightToLeft = RightToLeft.No
            LblWinRate.Size = New Size(239, 77)
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
            LblPlaceRate.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LblPlaceRate.ImageAlign = ContentAlignment.TopCenter
            LblPlaceRate.Location = New Point(1912, 77)
            LblPlaceRate.Margin = New Padding(0)
            LblPlaceRate.Name = "LblPlaceRate"
            LblPlaceRate.RightToLeft = RightToLeft.No
            LblPlaceRate.Size = New Size(239, 77)
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
            LblTotalRacesValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LblTotalRacesValue.Location = New Point(239, 77)
            LblTotalRacesValue.Margin = New Padding(0)
            LblTotalRacesValue.Name = "LblTotalRacesValue"
            LblTotalRacesValue.RightToLeft = RightToLeft.No
            LblTotalRacesValue.Size = New Size(239, 77)
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
            LblTotalWinsValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LblTotalWinsValue.Location = New Point(717, 77)
            LblTotalWinsValue.Margin = New Padding(0)
            LblTotalWinsValue.Name = "LblTotalWinsValue"
            LblTotalWinsValue.RightToLeft = RightToLeft.No
            LblTotalWinsValue.Size = New Size(239, 77)
            LblTotalWinsValue.TabIndex = 1074
            LblTotalWinsValue.Text = "000,000"
            LblTotalWinsValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblTotalPlacesValue
            ' 
            LblTotalPlacesValue.AutoEllipsis = True
            LblTotalPlacesValue.Cursor = Cursors.IBeam
            LblTotalPlacesValue.Dock = DockStyle.Fill
            LblTotalPlacesValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LblTotalPlacesValue.Location = New Point(1195, 77)
            LblTotalPlacesValue.Margin = New Padding(0)
            LblTotalPlacesValue.Name = "LblTotalPlacesValue"
            LblTotalPlacesValue.RightToLeft = RightToLeft.No
            LblTotalPlacesValue.Size = New Size(239, 77)
            LblTotalPlacesValue.TabIndex = 1075
            LblTotalPlacesValue.Text = "000,000"
            LblTotalPlacesValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblWinRateValue
            ' 
            LblWinRateValue.AutoEllipsis = True
            LblWinRateValue.Cursor = Cursors.IBeam
            LblWinRateValue.Dock = DockStyle.Fill
            LblWinRateValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LblWinRateValue.Location = New Point(1673, 77)
            LblWinRateValue.Margin = New Padding(0)
            LblWinRateValue.Name = "LblWinRateValue"
            LblWinRateValue.RightToLeft = RightToLeft.No
            LblWinRateValue.Size = New Size(239, 77)
            LblWinRateValue.TabIndex = 1076
            LblWinRateValue.Text = "000,000%"
            LblWinRateValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblPlaceRateValue
            ' 
            LblPlaceRateValue.AutoEllipsis = True
            LblPlaceRateValue.Cursor = Cursors.IBeam
            LblPlaceRateValue.Dock = DockStyle.Fill
            LblPlaceRateValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LblPlaceRateValue.Location = New Point(2151, 77)
            LblPlaceRateValue.Margin = New Padding(0)
            LblPlaceRateValue.Name = "LblPlaceRateValue"
            LblPlaceRateValue.RightToLeft = RightToLeft.No
            LblPlaceRateValue.Size = New Size(247, 77)
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
            LblProfitLoss.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LblProfitLoss.Location = New Point(478, 154)
            LblProfitLoss.Margin = New Padding(0)
            LblProfitLoss.Name = "LblProfitLoss"
            LblProfitLoss.RightToLeft = RightToLeft.No
            LblProfitLoss.Size = New Size(239, 80)
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
            LblPLWinPercent.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LblPLWinPercent.Location = New Point(956, 154)
            LblPLWinPercent.Margin = New Padding(0)
            LblPLWinPercent.Name = "LblPLWinPercent"
            LblPLWinPercent.RightToLeft = RightToLeft.No
            LblPLWinPercent.Size = New Size(239, 80)
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
            LblPLPlacePercent.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LblPLPlacePercent.Location = New Point(1434, 154)
            LblPLPlacePercent.Margin = New Padding(0)
            LblPLPlacePercent.Name = "LblPLPlacePercent"
            LblPLPlacePercent.RightToLeft = RightToLeft.No
            LblPLPlacePercent.Size = New Size(239, 80)
            LblPLPlacePercent.TabIndex = 1081
            LblPLPlacePercent.Text = "P/L (PLACE %):"
            LblPLPlacePercent.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LblProfitLossPlaceValue
            ' 
            LblProfitLossPlaceValue.AutoEllipsis = True
            LblProfitLossPlaceValue.Cursor = Cursors.IBeam
            LblProfitLossPlaceValue.Dock = DockStyle.Fill
            LblProfitLossPlaceValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LblProfitLossPlaceValue.Location = New Point(717, 154)
            LblProfitLossPlaceValue.Margin = New Padding(0)
            LblProfitLossPlaceValue.Name = "LblProfitLossPlaceValue"
            LblProfitLossPlaceValue.RightToLeft = RightToLeft.No
            LblProfitLossPlaceValue.Size = New Size(239, 80)
            LblProfitLossPlaceValue.TabIndex = 1083
            LblProfitLossPlaceValue.Text = "$ 000.00"
            LblProfitLossPlaceValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblPLWinPercentValue
            ' 
            LblPLWinPercentValue.AutoEllipsis = True
            LblPLWinPercentValue.Cursor = Cursors.IBeam
            LblPLWinPercentValue.Dock = DockStyle.Fill
            LblPLWinPercentValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LblPLWinPercentValue.Location = New Point(1195, 154)
            LblPLWinPercentValue.Margin = New Padding(0)
            LblPLWinPercentValue.Name = "LblPLWinPercentValue"
            LblPLWinPercentValue.RightToLeft = RightToLeft.No
            LblPLWinPercentValue.Size = New Size(239, 80)
            LblPLWinPercentValue.TabIndex = 1084
            LblPLWinPercentValue.Text = "000.00"
            LblPLWinPercentValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LblPLPlacePercentValue
            ' 
            LblPLPlacePercentValue.AutoEllipsis = True
            LblPLPlacePercentValue.Cursor = Cursors.IBeam
            LblPLPlacePercentValue.Dock = DockStyle.Fill
            LblPLPlacePercentValue.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            LblPLPlacePercentValue.Location = New Point(1673, 154)
            LblPLPlacePercentValue.Margin = New Padding(0)
            LblPLPlacePercentValue.Name = "LblPLPlacePercentValue"
            LblPLPlacePercentValue.RightToLeft = RightToLeft.No
            LblPLPlacePercentValue.Size = New Size(239, 80)
            LblPLPlacePercentValue.TabIndex = 1085
            LblPLPlacePercentValue.Text = "000.00"
            LblPLPlacePercentValue.TextAlign = ContentAlignment.MiddleLeft
            ' 
            ' LBL_DAYS
            ' 
            LBL_DAYS.AutoEllipsis = True
            LBL_DAYS.AutoSize = True
            LBL_DAYS.Dock = DockStyle.Fill
            LBL_DAYS.Font = New Font("Segoe UI", 9.900001F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_DAYS.Location = New Point(0, 0)
            LBL_DAYS.Margin = New Padding(0)
            LBL_DAYS.Name = "LBL_DAYS"
            LBL_DAYS.Size = New Size(239, 77)
            LBL_DAYS.TabIndex = 1086
            LBL_DAYS.Text = "DAYS:"
            LBL_DAYS.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' LBL_RANGE_HEADER
            ' 
            LBL_RANGE_HEADER.BackColor = SystemColors.GradientActiveCaption
            LBL_RANGE_HEADER.Dock = DockStyle.Top
            LBL_RANGE_HEADER.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            LBL_RANGE_HEADER.ForeColor = SystemColors.ActiveCaptionText
            LBL_RANGE_HEADER.Location = New Point(0, 0)
            LBL_RANGE_HEADER.Margin = New Padding(0)
            LBL_RANGE_HEADER.Name = "LBL_RANGE_HEADER"
            LBL_RANGE_HEADER.Size = New Size(2398, 55)
            LBL_RANGE_HEADER.TabIndex = 1
            LBL_RANGE_HEADER.Text = "RANGE:"
            LBL_RANGE_HEADER.TextAlign = ContentAlignment.MiddleCenter
            ' 
            ' DGV_RESULTS
            ' 
            DGV_RESULTS.AllowUserToAddRows = False
            DataGridViewCellStyle1.BackColor = SystemColors.ControlLight
            DataGridViewCellStyle1.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle1.ForeColor = SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText
            DGV_RESULTS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            DGV_RESULTS.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
            DGV_RESULTS.BackgroundColor = SystemColors.Window
            DGV_RESULTS.BorderStyle = BorderStyle.None
            DGV_RESULTS.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            DGV_RESULTS.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = SystemColors.Control
            DataGridViewCellStyle2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle2.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
            DGV_RESULTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            DGV_RESULTS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
            DGV_RESULTS.Columns.AddRange(New DataGridViewColumn() {DGV_DATE, DGV_NUMBER, DGV_BARRIER, DGV_NAME, DGV_CLASS, DGV_MEETINGNAME, DGV_RACELENGTH, DGV_VENUE, DGV_WEATHER, DGV_TRACK, DGV_FINISHPOSITION, DGV_WINS, DGV_PLACES})
            DGV_RESULTS.EditMode = DataGridViewEditMode.EditProgrammatically
            DGV_RESULTS.GridColor = SystemColors.ControlDarkDark
            DGV_RESULTS.Location = New Point(0, 343)
            DGV_RESULTS.Margin = New Padding(0)
            DGV_RESULTS.Name = "DGV_RESULTS"
            DGV_RESULTS.ReadOnly = True
            DGV_RESULTS.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            DataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle16.BackColor = SystemColors.Control
            DataGridViewCellStyle16.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle16.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = DataGridViewTriState.True
            DGV_RESULTS.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
            DGV_RESULTS.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            DataGridViewCellStyle17.BackColor = SystemColors.Window
            DataGridViewCellStyle17.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle17.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText
            DGV_RESULTS.RowsDefaultCellStyle = DataGridViewCellStyle17
            DGV_RESULTS.RowTemplate.DefaultCellStyle.BackColor = SystemColors.Window
            DGV_RESULTS.RowTemplate.DefaultCellStyle.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_RESULTS.RowTemplate.DefaultCellStyle.ForeColor = SystemColors.WindowText
            DGV_RESULTS.RowTemplate.DefaultCellStyle.SelectionBackColor = SystemColors.Highlight
            DGV_RESULTS.RowTemplate.DefaultCellStyle.SelectionForeColor = SystemColors.HighlightText
            DGV_RESULTS.RowTemplate.Height = 24
            DGV_RESULTS.RowTemplate.ReadOnly = True
            DGV_RESULTS.Size = New Size(2398, 526)
            DGV_RESULTS.TabIndex = 1061
            ' 
            ' DGV_DATE
            ' 
            DGV_DATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.BackColor = SystemColors.Window
            DataGridViewCellStyle3.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle3.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle3.Format = "d"
            DataGridViewCellStyle3.NullValue = Nothing
            DataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText
            DGV_DATE.DefaultCellStyle = DataGridViewCellStyle3
            DGV_DATE.HeaderText = "DATE"
            DGV_DATE.MinimumWidth = 12
            DGV_DATE.Name = "DGV_DATE"
            DGV_DATE.ReadOnly = True
            DGV_DATE.ToolTipText = "DATE"
            DGV_DATE.Width = 168
            ' 
            ' DGV_NUMBER
            ' 
            DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle4.Format = "N0"
            DataGridViewCellStyle4.NullValue = "0"
            DGV_NUMBER.DefaultCellStyle = DataGridViewCellStyle4
            DGV_NUMBER.HeaderText = "#"
            DGV_NUMBER.MinimumWidth = 12
            DGV_NUMBER.Name = "DGV_NUMBER"
            DGV_NUMBER.ReadOnly = True
            DGV_NUMBER.ToolTipText = "NUMBER"
            DGV_NUMBER.Width = 25
            ' 
            ' DGV_BARRIER
            ' 
            DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle5.Format = "N0"
            DataGridViewCellStyle5.NullValue = "0"
            DGV_BARRIER.DefaultCellStyle = DataGridViewCellStyle5
            DGV_BARRIER.HeaderText = "B"
            DGV_BARRIER.MinimumWidth = 12
            DGV_BARRIER.Name = "DGV_BARRIER"
            DGV_BARRIER.ReadOnly = True
            DGV_BARRIER.ToolTipText = "BARRIER"
            DGV_BARRIER.Width = 25
            ' 
            ' DGV_NAME
            ' 
            DGV_NAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_NAME.DefaultCellStyle = DataGridViewCellStyle6
            DGV_NAME.DividerWidth = 1
            DGV_NAME.HeaderText = "NAME"
            DGV_NAME.MinimumWidth = 12
            DGV_NAME.Name = "DGV_NAME"
            DGV_NAME.ReadOnly = True
            DGV_NAME.Resizable = DataGridViewTriState.True
            DGV_NAME.ToolTipText = "RUNNER NAME"
            DGV_NAME.Width = 142
            ' 
            ' DGV_CLASS
            ' 
            DGV_CLASS.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle7.Format = "N0"
            DataGridViewCellStyle7.NullValue = "999"
            DGV_CLASS.DefaultCellStyle = DataGridViewCellStyle7
            DGV_CLASS.HeaderText = "CL"
            DGV_CLASS.MinimumWidth = 12
            DGV_CLASS.Name = "DGV_CLASS"
            DGV_CLASS.ReadOnly = True
            DGV_CLASS.Width = 121
            ' 
            ' DGV_MEETINGNAME
            ' 
            DGV_MEETINGNAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle8.BackColor = SystemColors.Window
            DataGridViewCellStyle8.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle8.ForeColor = SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText
            DGV_MEETINGNAME.DefaultCellStyle = DataGridViewCellStyle8
            DGV_MEETINGNAME.HeaderText = "M-N"
            DGV_MEETINGNAME.MinimumWidth = 12
            DGV_MEETINGNAME.Name = "DGV_MEETINGNAME"
            DGV_MEETINGNAME.ReadOnly = True
            DGV_MEETINGNAME.ToolTipText = "MEETING NAME"
            DGV_MEETINGNAME.Width = 159
            ' 
            ' DGV_RACELENGTH
            ' 
            DGV_RACELENGTH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle9.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle9.Format = "N0"
            DataGridViewCellStyle9.NullValue = "0"
            DGV_RACELENGTH.DefaultCellStyle = DataGridViewCellStyle9
            DGV_RACELENGTH.HeaderText = "L"
            DGV_RACELENGTH.MinimumWidth = 12
            DGV_RACELENGTH.Name = "DGV_RACELENGTH"
            DGV_RACELENGTH.ReadOnly = True
            DGV_RACELENGTH.ToolTipText = "LENGTH"
            DGV_RACELENGTH.Width = 96
            ' 
            ' DGV_VENUE
            ' 
            DGV_VENUE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_VENUE.DefaultCellStyle = DataGridViewCellStyle10
            DGV_VENUE.HeaderText = "VENUE"
            DGV_VENUE.MinimumWidth = 12
            DGV_VENUE.Name = "DGV_VENUE"
            DGV_VENUE.ReadOnly = True
            DGV_VENUE.ToolTipText = "VENUE"
            ' 
            ' DGV_WEATHER
            ' 
            DGV_WEATHER.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle11.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_WEATHER.DefaultCellStyle = DataGridViewCellStyle11
            DGV_WEATHER.HeaderText = "W"
            DGV_WEATHER.MinimumWidth = 12
            DGV_WEATHER.Name = "DGV_WEATHER"
            DGV_WEATHER.ReadOnly = True
            DGV_WEATHER.ToolTipText = "WEATHER"
            DGV_WEATHER.Width = 114
            ' 
            ' DGV_TRACK
            ' 
            DGV_TRACK.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DGV_TRACK.DefaultCellStyle = DataGridViewCellStyle12
            DGV_TRACK.DividerWidth = 1
            DGV_TRACK.HeaderText = "T"
            DGV_TRACK.MinimumWidth = 12
            DGV_TRACK.Name = "DGV_TRACK"
            DGV_TRACK.ReadOnly = True
            DGV_TRACK.ToolTipText = "TRACK"
            DGV_TRACK.Width = 99
            ' 
            ' DGV_FINISHPOSITION
            ' 
            DataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle13.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle13.Format = "N0"
            DataGridViewCellStyle13.NullValue = "0"
            DGV_FINISHPOSITION.DefaultCellStyle = DataGridViewCellStyle13
            DGV_FINISHPOSITION.HeaderText = "F-P"
            DGV_FINISHPOSITION.MinimumWidth = 12
            DGV_FINISHPOSITION.Name = "DGV_FINISHPOSITION"
            DGV_FINISHPOSITION.ReadOnly = True
            DGV_FINISHPOSITION.ToolTipText = "FINISH POSITION"
            DGV_FINISHPOSITION.Width = 25
            ' 
            ' DGV_WINS
            ' 
            DGV_WINS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle14.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle14.Format = "C2"
            DataGridViewCellStyle14.NullValue = "0.00"
            DGV_WINS.DefaultCellStyle = DataGridViewCellStyle14
            DGV_WINS.HeaderText = "P-W"
            DGV_WINS.MinimumWidth = 12
            DGV_WINS.Name = "DGV_WINS"
            DGV_WINS.ReadOnly = True
            DGV_WINS.ToolTipText = "PAID WINS"
            DGV_WINS.Width = 152
            ' 
            ' DGV_PLACES
            ' 
            DGV_PLACES.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle15.Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            DataGridViewCellStyle15.Format = "C2"
            DataGridViewCellStyle15.NullValue = "0.00"
            DGV_PLACES.DefaultCellStyle = DataGridViewCellStyle15
            DGV_PLACES.HeaderText = "P-P"
            DGV_PLACES.MinimumWidth = 12
            DGV_PLACES.Name = "DGV_PLACES"
            DGV_PLACES.ReadOnly = True
            DGV_PLACES.ToolTipText = "PAID PLACES"
            DGV_PLACES.Width = 137
            ' 
            ' UserControlResults
            ' 
            AutoScaleDimensions = New SizeF(22F, 54F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = SystemColors.Window
            Controls.Add(DGV_RESULTS)
            Controls.Add(LBL_RANGE_HEADER)
            Controls.Add(GroupBoxTotals)
            Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            ForeColor = SystemColors.WindowText
            Margin = New Padding(0)
            Name = "UserControlResults"
            Size = New Size(2398, 869)
            GroupBoxTotals.ResumeLayout(False)
            TLPModelTotals.ResumeLayout(False)
            TLPModelTotals.PerformLayout()
            CType(DGV_RESULTS, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
        End Sub

        Private WithEvents GroupBoxTotals As GroupBox
        Private WithEvents TLPModelTotals As TableLayoutPanel
        Private WithEvents LBL_HITS_VALUE As Label
        Private WithEvents LBL_HITS As Label
        Private WithEvents LBL_ENTRIES_VALUE As Label
        Private WithEvents LBL_ENTRIES As Label
        Private WithEvents LBL_RACES_VALUE As Label
        Private WithEvents LBL_RACES As Label
        Private WithEvents LBL_MEETING_VALUE As Label
        Private WithEvents LBL_MEETINGS As Label
        Private WithEvents LBL_DAYSVALUE As Label
        Private WithEvents LblProfitLossWinValue As Label
        Private WithEvents LblProfitLossWin As Label
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
        Private WithEvents LblPLWinPercent As Label
        Private WithEvents LblPLPlacePercent As Label
        Private WithEvents LblProfitLossPlaceValue As Label
        Private WithEvents LblPLWinPercentValue As Label
        Private WithEvents LblPLPlacePercentValue As Label
        Private WithEvents LBL_DAYS As Label
        Private WithEvents LBL_RANGE_HEADER As Label
        Private WithEvents DGV_RESULTS As DataGridView
        Friend WithEvents DGV_DATE As DataGridViewTextBoxColumn
        Friend WithEvents DGV_NUMBER As DataGridViewTextBoxColumn
        Friend WithEvents DGV_BARRIER As DataGridViewTextBoxColumn
        Friend WithEvents DGV_NAME As DataGridViewLinkColumn
        Friend WithEvents DGV_CLASS As DataGridViewTextBoxColumn
        Friend WithEvents DGV_MEETINGNAME As DataGridViewTextBoxColumn
        Friend WithEvents DGV_RACELENGTH As DataGridViewTextBoxColumn
        Friend WithEvents DGV_VENUE As DataGridViewTextBoxColumn
        Friend WithEvents DGV_WEATHER As DataGridViewTextBoxColumn
        Friend WithEvents DGV_TRACK As DataGridViewTextBoxColumn
        Friend WithEvents DGV_FINISHPOSITION As DataGridViewTextBoxColumn
        Friend WithEvents DGV_WINS As DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLACES As DataGridViewTextBoxColumn
    End Class
End Namespace