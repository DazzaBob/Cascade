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
            Me.TLPModelTotals = New System.Windows.Forms.TableLayoutPanel()
            Me.LblProfitLossWinValue = New System.Windows.Forms.Label()
            Me.LblProfitLossWin = New System.Windows.Forms.Label()
            Me.LblTotalRaces = New System.Windows.Forms.Label()
            Me.LblTotalWins = New System.Windows.Forms.Label()
            Me.LblTotalPlaces = New System.Windows.Forms.Label()
            Me.LblWinRate = New System.Windows.Forms.Label()
            Me.LblPlaceRate = New System.Windows.Forms.Label()
            Me.LblTotalRacesValue = New System.Windows.Forms.Label()
            Me.LblTotalWinsValue = New System.Windows.Forms.Label()
            Me.LblTotalPlacesValue = New System.Windows.Forms.Label()
            Me.LblWinRateValue = New System.Windows.Forms.Label()
            Me.LblPlaceRateValue = New System.Windows.Forms.Label()
            Me.LblProfitLoss = New System.Windows.Forms.Label()
            Me.LblPLWinPercent = New System.Windows.Forms.Label()
            Me.LblPLPlacePercent = New System.Windows.Forms.Label()
            Me.LblProfitLossPlaceValue = New System.Windows.Forms.Label()
            Me.LblPLWinPercentValue = New System.Windows.Forms.Label()
            Me.LblPLPlacePercentValue = New System.Windows.Forms.Label()
            Me.LBL_DAYS = New System.Windows.Forms.Label()
            Me.LBL_DAYSVALUE = New System.Windows.Forms.Label()
            Me.LBL_MEETINGS = New System.Windows.Forms.Label()
            Me.LBL_MEETING_VALUE = New System.Windows.Forms.Label()
            Me.LBL_RACES = New System.Windows.Forms.Label()
            Me.LBL_RACES_VALUE = New System.Windows.Forms.Label()
            Me.LBL_ENTRIES = New System.Windows.Forms.Label()
            Me.LBL_ENTRIES_VALUE = New System.Windows.Forms.Label()
            Me.LBL_HITS = New System.Windows.Forms.Label()
            Me.LBL_HITS_VALUE = New System.Windows.Forms.Label()
            Me.TLPModelTotals.SuspendLayout()
            Me.SuspendLayout()
            '
            'TLPModelTotals
            '
            Me.TLPModelTotals.ColumnCount = 10
            Me.TLPModelTotals.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TLPModelTotals.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TLPModelTotals.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TLPModelTotals.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TLPModelTotals.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TLPModelTotals.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TLPModelTotals.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TLPModelTotals.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TLPModelTotals.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TLPModelTotals.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0!))
            Me.TLPModelTotals.Controls.Add(Me.LBL_HITS_VALUE, 9, 0)
            Me.TLPModelTotals.Controls.Add(Me.LBL_HITS, 8, 0)
            Me.TLPModelTotals.Controls.Add(Me.LBL_ENTRIES_VALUE, 7, 0)
            Me.TLPModelTotals.Controls.Add(Me.LBL_ENTRIES, 6, 0)
            Me.TLPModelTotals.Controls.Add(Me.LBL_RACES_VALUE, 5, 0)
            Me.TLPModelTotals.Controls.Add(Me.LBL_RACES, 4, 0)
            Me.TLPModelTotals.Controls.Add(Me.LBL_MEETING_VALUE, 3, 0)
            Me.TLPModelTotals.Controls.Add(Me.LBL_MEETINGS, 2, 0)
            Me.TLPModelTotals.Controls.Add(Me.LBL_DAYSVALUE, 1, 0)
            Me.TLPModelTotals.Controls.Add(Me.LblProfitLossWinValue, 0, 2)
            Me.TLPModelTotals.Controls.Add(Me.LblProfitLossWin, 0, 2)
            Me.TLPModelTotals.Controls.Add(Me.LblTotalRaces, 0, 1)
            Me.TLPModelTotals.Controls.Add(Me.LblTotalWins, 2, 1)
            Me.TLPModelTotals.Controls.Add(Me.LblTotalPlaces, 4, 1)
            Me.TLPModelTotals.Controls.Add(Me.LblWinRate, 6, 1)
            Me.TLPModelTotals.Controls.Add(Me.LblPlaceRate, 8, 1)
            Me.TLPModelTotals.Controls.Add(Me.LblTotalRacesValue, 1, 1)
            Me.TLPModelTotals.Controls.Add(Me.LblTotalWinsValue, 3, 1)
            Me.TLPModelTotals.Controls.Add(Me.LblTotalPlacesValue, 5, 1)
            Me.TLPModelTotals.Controls.Add(Me.LblWinRateValue, 7, 1)
            Me.TLPModelTotals.Controls.Add(Me.LblPlaceRateValue, 9, 1)
            Me.TLPModelTotals.Controls.Add(Me.LblProfitLoss, 2, 2)
            Me.TLPModelTotals.Controls.Add(Me.LblPLWinPercent, 4, 2)
            Me.TLPModelTotals.Controls.Add(Me.LblPLPlacePercent, 6, 2)
            Me.TLPModelTotals.Controls.Add(Me.LblProfitLossPlaceValue, 3, 2)
            Me.TLPModelTotals.Controls.Add(Me.LblPLWinPercentValue, 5, 2)
            Me.TLPModelTotals.Controls.Add(Me.LblPLPlacePercentValue, 7, 2)
            Me.TLPModelTotals.Controls.Add(Me.LBL_DAYS, 0, 0)
            Me.TLPModelTotals.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TLPModelTotals.Location = New System.Drawing.Point(0, 0)
            Me.TLPModelTotals.Margin = New System.Windows.Forms.Padding(0)
            Me.TLPModelTotals.Name = "TLPModelTotals"
            Me.TLPModelTotals.RowCount = 3
            Me.TLPModelTotals.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TLPModelTotals.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TLPModelTotals.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.TLPModelTotals.Size = New System.Drawing.Size(573, 72)
            Me.TLPModelTotals.TabIndex = 0
            '
            'LblProfitLossWinValue
            '
            Me.LblProfitLossWinValue.AutoEllipsis = True
            Me.LblProfitLossWinValue.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblProfitLossWinValue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblProfitLossWinValue.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblProfitLossWinValue.Location = New System.Drawing.Point(57, 40)
            Me.LblProfitLossWinValue.Margin = New System.Windows.Forms.Padding(0)
            Me.LblProfitLossWinValue.Name = "LblProfitLossWinValue"
            Me.LblProfitLossWinValue.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblProfitLossWinValue.Size = New System.Drawing.Size(57, 32)
            Me.LblProfitLossWinValue.TabIndex = 1082
            Me.LblProfitLossWinValue.Text = "$ 000.00"
            Me.LblProfitLossWinValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LblProfitLossWin
            '
            Me.LblProfitLossWin.AutoEllipsis = True
            Me.LblProfitLossWin.AutoSize = True
            Me.LblProfitLossWin.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblProfitLossWin.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblProfitLossWin.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblProfitLossWin.Location = New System.Drawing.Point(0, 40)
            Me.LblProfitLossWin.Margin = New System.Windows.Forms.Padding(0)
            Me.LblProfitLossWin.Name = "LblProfitLossWin"
            Me.LblProfitLossWin.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblProfitLossWin.Size = New System.Drawing.Size(57, 32)
            Me.LblProfitLossWin.TabIndex = 1079
            Me.LblProfitLossWin.Text = "P/L (WIN):"
            Me.LblProfitLossWin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblTotalRaces
            '
            Me.LblTotalRaces.AutoEllipsis = True
            Me.LblTotalRaces.AutoSize = True
            Me.LblTotalRaces.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblTotalRaces.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblTotalRaces.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblTotalRaces.Location = New System.Drawing.Point(0, 20)
            Me.LblTotalRaces.Margin = New System.Windows.Forms.Padding(0)
            Me.LblTotalRaces.Name = "LblTotalRaces"
            Me.LblTotalRaces.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblTotalRaces.Size = New System.Drawing.Size(57, 20)
            Me.LblTotalRaces.TabIndex = 1064
            Me.LblTotalRaces.Text = "RACES:"
            Me.LblTotalRaces.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblTotalWins
            '
            Me.LblTotalWins.AutoEllipsis = True
            Me.LblTotalWins.AutoSize = True
            Me.LblTotalWins.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblTotalWins.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblTotalWins.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblTotalWins.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.LblTotalWins.Location = New System.Drawing.Point(114, 20)
            Me.LblTotalWins.Margin = New System.Windows.Forms.Padding(0)
            Me.LblTotalWins.Name = "LblTotalWins"
            Me.LblTotalWins.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblTotalWins.Size = New System.Drawing.Size(57, 20)
            Me.LblTotalWins.TabIndex = 1066
            Me.LblTotalWins.Text = "WINS:"
            Me.LblTotalWins.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblTotalPlaces
            '
            Me.LblTotalPlaces.AutoEllipsis = True
            Me.LblTotalPlaces.AutoSize = True
            Me.LblTotalPlaces.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblTotalPlaces.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblTotalPlaces.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblTotalPlaces.Location = New System.Drawing.Point(228, 20)
            Me.LblTotalPlaces.Margin = New System.Windows.Forms.Padding(0)
            Me.LblTotalPlaces.Name = "LblTotalPlaces"
            Me.LblTotalPlaces.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblTotalPlaces.Size = New System.Drawing.Size(57, 20)
            Me.LblTotalPlaces.TabIndex = 1068
            Me.LblTotalPlaces.Text = "PLACES:"
            Me.LblTotalPlaces.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblWinRate
            '
            Me.LblWinRate.AutoEllipsis = True
            Me.LblWinRate.AutoSize = True
            Me.LblWinRate.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblWinRate.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblWinRate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblWinRate.Location = New System.Drawing.Point(342, 20)
            Me.LblWinRate.Margin = New System.Windows.Forms.Padding(0)
            Me.LblWinRate.Name = "LblWinRate"
            Me.LblWinRate.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblWinRate.Size = New System.Drawing.Size(57, 20)
            Me.LblWinRate.TabIndex = 1070
            Me.LblWinRate.Text = "WIN %:"
            Me.LblWinRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblPlaceRate
            '
            Me.LblPlaceRate.AutoEllipsis = True
            Me.LblPlaceRate.AutoSize = True
            Me.LblPlaceRate.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblPlaceRate.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblPlaceRate.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPlaceRate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
            Me.LblPlaceRate.Location = New System.Drawing.Point(456, 20)
            Me.LblPlaceRate.Margin = New System.Windows.Forms.Padding(0)
            Me.LblPlaceRate.Name = "LblPlaceRate"
            Me.LblPlaceRate.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblPlaceRate.Size = New System.Drawing.Size(57, 20)
            Me.LblPlaceRate.TabIndex = 1072
            Me.LblPlaceRate.Text = "PLACE %:"
            Me.LblPlaceRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblTotalRacesValue
            '
            Me.LblTotalRacesValue.AutoEllipsis = True
            Me.LblTotalRacesValue.AutoSize = True
            Me.LblTotalRacesValue.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblTotalRacesValue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblTotalRacesValue.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblTotalRacesValue.Location = New System.Drawing.Point(57, 20)
            Me.LblTotalRacesValue.Margin = New System.Windows.Forms.Padding(0)
            Me.LblTotalRacesValue.Name = "LblTotalRacesValue"
            Me.LblTotalRacesValue.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblTotalRacesValue.Size = New System.Drawing.Size(57, 20)
            Me.LblTotalRacesValue.TabIndex = 1073
            Me.LblTotalRacesValue.Text = "000,000"
            Me.LblTotalRacesValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LblTotalWinsValue
            '
            Me.LblTotalWinsValue.AutoEllipsis = True
            Me.LblTotalWinsValue.AutoSize = True
            Me.LblTotalWinsValue.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblTotalWinsValue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblTotalWinsValue.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblTotalWinsValue.Location = New System.Drawing.Point(171, 20)
            Me.LblTotalWinsValue.Margin = New System.Windows.Forms.Padding(0)
            Me.LblTotalWinsValue.Name = "LblTotalWinsValue"
            Me.LblTotalWinsValue.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblTotalWinsValue.Size = New System.Drawing.Size(57, 20)
            Me.LblTotalWinsValue.TabIndex = 1074
            Me.LblTotalWinsValue.Text = "000,000"
            Me.LblTotalWinsValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LblTotalPlacesValue
            '
            Me.LblTotalPlacesValue.AutoEllipsis = True
            Me.LblTotalPlacesValue.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblTotalPlacesValue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblTotalPlacesValue.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblTotalPlacesValue.Location = New System.Drawing.Point(285, 20)
            Me.LblTotalPlacesValue.Margin = New System.Windows.Forms.Padding(0)
            Me.LblTotalPlacesValue.Name = "LblTotalPlacesValue"
            Me.LblTotalPlacesValue.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblTotalPlacesValue.Size = New System.Drawing.Size(57, 20)
            Me.LblTotalPlacesValue.TabIndex = 1075
            Me.LblTotalPlacesValue.Text = "000,000"
            Me.LblTotalPlacesValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LblWinRateValue
            '
            Me.LblWinRateValue.AutoEllipsis = True
            Me.LblWinRateValue.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblWinRateValue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblWinRateValue.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblWinRateValue.Location = New System.Drawing.Point(399, 20)
            Me.LblWinRateValue.Margin = New System.Windows.Forms.Padding(0)
            Me.LblWinRateValue.Name = "LblWinRateValue"
            Me.LblWinRateValue.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblWinRateValue.Size = New System.Drawing.Size(57, 20)
            Me.LblWinRateValue.TabIndex = 1076
            Me.LblWinRateValue.Text = "000,000%"
            Me.LblWinRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LblPlaceRateValue
            '
            Me.LblPlaceRateValue.AutoEllipsis = True
            Me.LblPlaceRateValue.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblPlaceRateValue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblPlaceRateValue.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPlaceRateValue.Location = New System.Drawing.Point(513, 20)
            Me.LblPlaceRateValue.Margin = New System.Windows.Forms.Padding(0)
            Me.LblPlaceRateValue.Name = "LblPlaceRateValue"
            Me.LblPlaceRateValue.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblPlaceRateValue.Size = New System.Drawing.Size(60, 20)
            Me.LblPlaceRateValue.TabIndex = 1077
            Me.LblPlaceRateValue.Text = "000,000%"
            Me.LblPlaceRateValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LblProfitLoss
            '
            Me.LblProfitLoss.AutoEllipsis = True
            Me.LblProfitLoss.AutoSize = True
            Me.LblProfitLoss.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblProfitLoss.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblProfitLoss.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblProfitLoss.Location = New System.Drawing.Point(114, 40)
            Me.LblProfitLoss.Margin = New System.Windows.Forms.Padding(0)
            Me.LblProfitLoss.Name = "LblProfitLoss"
            Me.LblProfitLoss.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblProfitLoss.Size = New System.Drawing.Size(57, 32)
            Me.LblProfitLoss.TabIndex = 1078
            Me.LblProfitLoss.Text = "P/L (PLACE):"
            Me.LblProfitLoss.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblPLWinPercent
            '
            Me.LblPLWinPercent.AutoEllipsis = True
            Me.LblPLWinPercent.AutoSize = True
            Me.LblPLWinPercent.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblPLWinPercent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblPLWinPercent.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPLWinPercent.Location = New System.Drawing.Point(228, 40)
            Me.LblPLWinPercent.Margin = New System.Windows.Forms.Padding(0)
            Me.LblPLWinPercent.Name = "LblPLWinPercent"
            Me.LblPLWinPercent.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblPLWinPercent.Size = New System.Drawing.Size(57, 32)
            Me.LblPLWinPercent.TabIndex = 1080
            Me.LblPLWinPercent.Text = "P/L (WIN %):"
            Me.LblPLWinPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblPLPlacePercent
            '
            Me.LblPLPlacePercent.AutoEllipsis = True
            Me.LblPLPlacePercent.AutoSize = True
            Me.LblPLPlacePercent.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblPLPlacePercent.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblPLPlacePercent.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPLPlacePercent.Location = New System.Drawing.Point(342, 40)
            Me.LblPLPlacePercent.Margin = New System.Windows.Forms.Padding(0)
            Me.LblPLPlacePercent.Name = "LblPLPlacePercent"
            Me.LblPLPlacePercent.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblPLPlacePercent.Size = New System.Drawing.Size(57, 32)
            Me.LblPLPlacePercent.TabIndex = 1081
            Me.LblPLPlacePercent.Text = "P/L (PLACE %):"
            Me.LblPLPlacePercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LblProfitLossPlaceValue
            '
            Me.LblProfitLossPlaceValue.AutoEllipsis = True
            Me.LblProfitLossPlaceValue.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblProfitLossPlaceValue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblProfitLossPlaceValue.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblProfitLossPlaceValue.Location = New System.Drawing.Point(171, 40)
            Me.LblProfitLossPlaceValue.Margin = New System.Windows.Forms.Padding(0)
            Me.LblProfitLossPlaceValue.Name = "LblProfitLossPlaceValue"
            Me.LblProfitLossPlaceValue.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblProfitLossPlaceValue.Size = New System.Drawing.Size(57, 32)
            Me.LblProfitLossPlaceValue.TabIndex = 1083
            Me.LblProfitLossPlaceValue.Text = "$ 000.00"
            Me.LblProfitLossPlaceValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LblPLWinPercentValue
            '
            Me.LblPLWinPercentValue.AutoEllipsis = True
            Me.LblPLWinPercentValue.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblPLWinPercentValue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblPLWinPercentValue.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPLWinPercentValue.Location = New System.Drawing.Point(285, 40)
            Me.LblPLWinPercentValue.Margin = New System.Windows.Forms.Padding(0)
            Me.LblPLWinPercentValue.Name = "LblPLWinPercentValue"
            Me.LblPLWinPercentValue.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblPLWinPercentValue.Size = New System.Drawing.Size(57, 32)
            Me.LblPLWinPercentValue.TabIndex = 1084
            Me.LblPLWinPercentValue.Text = "000.00"
            Me.LblPLWinPercentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LblPLPlacePercentValue
            '
            Me.LblPLPlacePercentValue.AutoEllipsis = True
            Me.LblPLPlacePercentValue.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LblPLPlacePercentValue.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LblPLPlacePercentValue.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblPLPlacePercentValue.Location = New System.Drawing.Point(399, 40)
            Me.LblPLPlacePercentValue.Margin = New System.Windows.Forms.Padding(0)
            Me.LblPLPlacePercentValue.Name = "LblPLPlacePercentValue"
            Me.LblPLPlacePercentValue.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LblPLPlacePercentValue.Size = New System.Drawing.Size(57, 32)
            Me.LblPLPlacePercentValue.TabIndex = 1085
            Me.LblPLPlacePercentValue.Text = "000.00"
            Me.LblPLPlacePercentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LBL_DAYS
            '
            Me.LBL_DAYS.AutoEllipsis = True
            Me.LBL_DAYS.AutoSize = True
            Me.LBL_DAYS.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LBL_DAYS.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_DAYS.Location = New System.Drawing.Point(0, 0)
            Me.LBL_DAYS.Margin = New System.Windows.Forms.Padding(0)
            Me.LBL_DAYS.Name = "LBL_DAYS"
            Me.LBL_DAYS.Size = New System.Drawing.Size(57, 20)
            Me.LBL_DAYS.TabIndex = 1086
            Me.LBL_DAYS.Text = "DAYS:"
            Me.LBL_DAYS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LBL_DAYSVALUE
            '
            Me.LBL_DAYSVALUE.AutoEllipsis = True
            Me.LBL_DAYSVALUE.AutoSize = True
            Me.LBL_DAYSVALUE.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LBL_DAYSVALUE.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LBL_DAYSVALUE.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_DAYSVALUE.Location = New System.Drawing.Point(57, 0)
            Me.LBL_DAYSVALUE.Margin = New System.Windows.Forms.Padding(0)
            Me.LBL_DAYSVALUE.Name = "LBL_DAYSVALUE"
            Me.LBL_DAYSVALUE.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LBL_DAYSVALUE.Size = New System.Drawing.Size(57, 20)
            Me.LBL_DAYSVALUE.TabIndex = 1087
            Me.LBL_DAYSVALUE.Text = "000,000"
            Me.LBL_DAYSVALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LBL_MEETINGS
            '
            Me.LBL_MEETINGS.AutoEllipsis = True
            Me.LBL_MEETINGS.AutoSize = True
            Me.LBL_MEETINGS.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LBL_MEETINGS.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_MEETINGS.Location = New System.Drawing.Point(114, 0)
            Me.LBL_MEETINGS.Margin = New System.Windows.Forms.Padding(0)
            Me.LBL_MEETINGS.Name = "LBL_MEETINGS"
            Me.LBL_MEETINGS.Size = New System.Drawing.Size(57, 20)
            Me.LBL_MEETINGS.TabIndex = 1088
            Me.LBL_MEETINGS.Text = "MEETINGS:"
            Me.LBL_MEETINGS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LBL_MEETING_VALUE
            '
            Me.LBL_MEETING_VALUE.AutoEllipsis = True
            Me.LBL_MEETING_VALUE.AutoSize = True
            Me.LBL_MEETING_VALUE.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LBL_MEETING_VALUE.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LBL_MEETING_VALUE.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_MEETING_VALUE.Location = New System.Drawing.Point(171, 0)
            Me.LBL_MEETING_VALUE.Margin = New System.Windows.Forms.Padding(0)
            Me.LBL_MEETING_VALUE.Name = "LBL_MEETING_VALUE"
            Me.LBL_MEETING_VALUE.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LBL_MEETING_VALUE.Size = New System.Drawing.Size(57, 20)
            Me.LBL_MEETING_VALUE.TabIndex = 1089
            Me.LBL_MEETING_VALUE.Text = "000,000"
            Me.LBL_MEETING_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LBL_RACES
            '
            Me.LBL_RACES.AutoEllipsis = True
            Me.LBL_RACES.AutoSize = True
            Me.LBL_RACES.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LBL_RACES.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_RACES.Location = New System.Drawing.Point(228, 0)
            Me.LBL_RACES.Margin = New System.Windows.Forms.Padding(0)
            Me.LBL_RACES.Name = "LBL_RACES"
            Me.LBL_RACES.Size = New System.Drawing.Size(57, 20)
            Me.LBL_RACES.TabIndex = 1090
            Me.LBL_RACES.Text = "RACES:"
            Me.LBL_RACES.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LBL_RACES_VALUE
            '
            Me.LBL_RACES_VALUE.AutoEllipsis = True
            Me.LBL_RACES_VALUE.AutoSize = True
            Me.LBL_RACES_VALUE.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LBL_RACES_VALUE.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LBL_RACES_VALUE.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_RACES_VALUE.Location = New System.Drawing.Point(285, 0)
            Me.LBL_RACES_VALUE.Margin = New System.Windows.Forms.Padding(0)
            Me.LBL_RACES_VALUE.Name = "LBL_RACES_VALUE"
            Me.LBL_RACES_VALUE.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LBL_RACES_VALUE.Size = New System.Drawing.Size(57, 20)
            Me.LBL_RACES_VALUE.TabIndex = 1091
            Me.LBL_RACES_VALUE.Text = "000,000"
            Me.LBL_RACES_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LBL_ENTRIES
            '
            Me.LBL_ENTRIES.AutoEllipsis = True
            Me.LBL_ENTRIES.AutoSize = True
            Me.LBL_ENTRIES.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LBL_ENTRIES.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_ENTRIES.Location = New System.Drawing.Point(342, 0)
            Me.LBL_ENTRIES.Margin = New System.Windows.Forms.Padding(0)
            Me.LBL_ENTRIES.Name = "LBL_ENTRIES"
            Me.LBL_ENTRIES.Size = New System.Drawing.Size(57, 20)
            Me.LBL_ENTRIES.TabIndex = 1092
            Me.LBL_ENTRIES.Text = "ENTRIES:"
            Me.LBL_ENTRIES.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LBL_ENTRIES_VALUE
            '
            Me.LBL_ENTRIES_VALUE.AutoEllipsis = True
            Me.LBL_ENTRIES_VALUE.AutoSize = True
            Me.LBL_ENTRIES_VALUE.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LBL_ENTRIES_VALUE.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LBL_ENTRIES_VALUE.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_ENTRIES_VALUE.Location = New System.Drawing.Point(399, 0)
            Me.LBL_ENTRIES_VALUE.Margin = New System.Windows.Forms.Padding(0)
            Me.LBL_ENTRIES_VALUE.Name = "LBL_ENTRIES_VALUE"
            Me.LBL_ENTRIES_VALUE.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LBL_ENTRIES_VALUE.Size = New System.Drawing.Size(57, 20)
            Me.LBL_ENTRIES_VALUE.TabIndex = 1093
            Me.LBL_ENTRIES_VALUE.Text = "000,000"
            Me.LBL_ENTRIES_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'LBL_HITS
            '
            Me.LBL_HITS.AutoEllipsis = True
            Me.LBL_HITS.AutoSize = True
            Me.LBL_HITS.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LBL_HITS.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_HITS.Location = New System.Drawing.Point(456, 0)
            Me.LBL_HITS.Margin = New System.Windows.Forms.Padding(0)
            Me.LBL_HITS.Name = "LBL_HITS"
            Me.LBL_HITS.Size = New System.Drawing.Size(57, 20)
            Me.LBL_HITS.TabIndex = 1094
            Me.LBL_HITS.Text = "HITS:"
            Me.LBL_HITS.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'LBL_HITS_VALUE
            '
            Me.LBL_HITS_VALUE.AutoEllipsis = True
            Me.LBL_HITS_VALUE.Cursor = System.Windows.Forms.Cursors.IBeam
            Me.LBL_HITS_VALUE.Dock = System.Windows.Forms.DockStyle.Fill
            Me.LBL_HITS_VALUE.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_HITS_VALUE.Location = New System.Drawing.Point(513, 0)
            Me.LBL_HITS_VALUE.Margin = New System.Windows.Forms.Padding(0)
            Me.LBL_HITS_VALUE.Name = "LBL_HITS_VALUE"
            Me.LBL_HITS_VALUE.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LBL_HITS_VALUE.Size = New System.Drawing.Size(60, 20)
            Me.LBL_HITS_VALUE.TabIndex = 1095
            Me.LBL_HITS_VALUE.Text = "000,000%"
            Me.LBL_HITS_VALUE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'UC_Model_Totals
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.TLPModelTotals)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_Model_Totals"
            Me.Size = New System.Drawing.Size(573, 72)
            Me.TLPModelTotals.ResumeLayout(False)
            Me.TLPModelTotals.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents TLPModelTotals As System.Windows.Forms.TableLayoutPanel
        Private WithEvents LblTotalRaces As System.Windows.Forms.Label
        Private WithEvents LblTotalWins As System.Windows.Forms.Label
        Private WithEvents LblTotalPlaces As System.Windows.Forms.Label
        Private WithEvents LblWinRate As System.Windows.Forms.Label
        Private WithEvents LblPlaceRate As System.Windows.Forms.Label
        Private WithEvents LblTotalRacesValue As System.Windows.Forms.Label
        Private WithEvents LblTotalWinsValue As System.Windows.Forms.Label
        Private WithEvents LblTotalPlacesValue As System.Windows.Forms.Label
        Private WithEvents LblWinRateValue As System.Windows.Forms.Label
        Private WithEvents LblPlaceRateValue As System.Windows.Forms.Label
        Private WithEvents LblProfitLoss As System.Windows.Forms.Label
        Private WithEvents LblProfitLossWin As System.Windows.Forms.Label
        Private WithEvents LblPLWinPercent As System.Windows.Forms.Label
        Private WithEvents LblPLPlacePercent As System.Windows.Forms.Label
        Private WithEvents LblProfitLossWinValue As System.Windows.Forms.Label
        Private WithEvents LblProfitLossPlaceValue As System.Windows.Forms.Label
        Private WithEvents LblPLWinPercentValue As System.Windows.Forms.Label
        Private WithEvents LblPLPlacePercentValue As System.Windows.Forms.Label
        Private WithEvents LBL_DAYSVALUE As System.Windows.Forms.Label
        Private WithEvents LBL_DAYS As System.Windows.Forms.Label
        Private WithEvents LBL_MEETINGS As System.Windows.Forms.Label
        Private WithEvents LBL_ENTRIES_VALUE As System.Windows.Forms.Label
        Private WithEvents LBL_ENTRIES As System.Windows.Forms.Label
        Private WithEvents LBL_RACES_VALUE As System.Windows.Forms.Label
        Private WithEvents LBL_RACES As System.Windows.Forms.Label
        Private WithEvents LBL_MEETING_VALUE As System.Windows.Forms.Label
        Private WithEvents LBL_HITS As System.Windows.Forms.Label
        Private WithEvents LBL_HITS_VALUE As System.Windows.Forms.Label

    End Class
End Namespace