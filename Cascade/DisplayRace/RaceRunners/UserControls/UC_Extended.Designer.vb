Namespace DisplayRace.RaceRunners.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_Extended
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                    If MY_POPUP IsNot Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
                    If MY_RUNNERRACELIST IsNot Nothing Then MY_RUNNERRACELIST.Dispose() : MY_POPUP = Nothing
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.DGV_MAIN = New System.Windows.Forms.DataGridView()
            Me.CMS_DGV_MAIN = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.TSMI_MAIN_COPY = New System.Windows.Forms.ToolStripMenuItem()
            Me.DGV_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RUNS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_FP_MIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_FP_AVG = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_FP_MAX = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SMN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SAVG = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SMX = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_DB_MIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_DB_AVG = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_DB_MAX = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_WIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_PLC = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_TREND = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_TRENDSTATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SMINDAYSAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SMAXDAYSAGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SCORE_RANK = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SCORE_RANK_PERCENT = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SCORE_RANK_DIFFERENCE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_NAME = New System.Windows.Forms.DataGridViewLinkColumn()
            CType(Me.DGV_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.CMS_DGV_MAIN.SuspendLayout()
            Me.SuspendLayout()
            '
            'DGV_MAIN
            '
            Me.DGV_MAIN.AllowUserToAddRows = False
            Me.DGV_MAIN.AllowUserToDeleteRows = False
            Me.DGV_MAIN.AllowUserToOrderColumns = True
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV_MAIN.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DGV_MAIN.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            Me.DGV_MAIN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MAIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV_MAIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV_MAIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_NUMBER, Me.DGV_RUNS, Me.DGV_FP_MIN, Me.DGV_FP_AVG, Me.DGV_FP_MAX, Me.DGV_SMN, Me.DGV_SAVG, Me.DGV_SMX, Me.DGV_DB_MIN, Me.DGV_DB_AVG, Me.DGV_DB_MAX, Me.DGV_WIN, Me.DGV_PLC, Me.DGV_TREND, Me.DGV_TRENDSTATUS, Me.DGV_SMINDAYSAGO, Me.DGV_SMAXDAYSAGO, Me.DGV_SCORE_RANK, Me.DGV_SCORE_RANK_PERCENT, Me.DGV_SCORE_RANK_DIFFERENCE, Me.DGV_NAME})
            Me.DGV_MAIN.ContextMenuStrip = Me.CMS_DGV_MAIN
            DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle24.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle24.Format = "N2"
            DataGridViewCellStyle24.NullValue = "0.00"
            DataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_MAIN.DefaultCellStyle = DataGridViewCellStyle24
            Me.DGV_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV_MAIN.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV_MAIN.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV_MAIN.Location = New System.Drawing.Point(0, 0)
            Me.DGV_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV_MAIN.Name = "DGV_MAIN"
            Me.DGV_MAIN.ReadOnly = True
            Me.DGV_MAIN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle25.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle25.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MAIN.RowHeadersDefaultCellStyle = DataGridViewCellStyle25
            DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle26.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN.RowsDefaultCellStyle = DataGridViewCellStyle26
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.Format = "N2"
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.NullValue = "0.00"
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN.RowTemplate.ReadOnly = True
            Me.DGV_MAIN.Size = New System.Drawing.Size(800, 300)
            Me.DGV_MAIN.TabIndex = 1
            '
            'CMS_DGV_MAIN
            '
            Me.CMS_DGV_MAIN.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMS_DGV_MAIN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_MAIN_COPY})
            Me.CMS_DGV_MAIN.Name = "CMSMainInformation"
            Me.CMS_DGV_MAIN.Size = New System.Drawing.Size(102, 26)
            '
            'TSMI_MAIN_COPY
            '
            Me.TSMI_MAIN_COPY.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_MAIN_COPY.Name = "TSMI_MAIN_COPY"
            Me.TSMI_MAIN_COPY.Size = New System.Drawing.Size(101, 22)
            Me.TSMI_MAIN_COPY.Text = "&Copy"
            '
            'DGV_NUMBER
            '
            Me.DGV_NUMBER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.Format = "N0"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.DGV_NUMBER.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_NUMBER.FillWeight = 75.0!
            Me.DGV_NUMBER.HeaderText = "#"
            Me.DGV_NUMBER.Name = "DGV_NUMBER"
            Me.DGV_NUMBER.ReadOnly = True
            Me.DGV_NUMBER.ToolTipText = "NUMBER"
            Me.DGV_NUMBER.Width = 37
            '
            'DGV_RUNS
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.Format = "N0"
            DataGridViewCellStyle4.NullValue = "0"
            Me.DGV_RUNS.DefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_RUNS.DividerWidth = 2
            Me.DGV_RUNS.HeaderText = "RUNS"
            Me.DGV_RUNS.Name = "DGV_RUNS"
            Me.DGV_RUNS.ReadOnly = True
            Me.DGV_RUNS.ToolTipText = "RUNS"
            Me.DGV_RUNS.Width = 30
            '
            'DGV_FP_MIN
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.Format = "N2"
            Me.DGV_FP_MIN.DefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_FP_MIN.HeaderText = "FP MIN"
            Me.DGV_FP_MIN.Name = "DGV_FP_MIN"
            Me.DGV_FP_MIN.ReadOnly = True
            Me.DGV_FP_MIN.ToolTipText = "FINISH POSITION MINIMUM"
            Me.DGV_FP_MIN.Width = 40
            '
            'DGV_FP_AVG
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.Format = "N2"
            Me.DGV_FP_AVG.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_FP_AVG.HeaderText = "FP AVG"
            Me.DGV_FP_AVG.Name = "DGV_FP_AVG"
            Me.DGV_FP_AVG.ReadOnly = True
            Me.DGV_FP_AVG.ToolTipText = "FINISH POSITION AVERAGE"
            Me.DGV_FP_AVG.Width = 40
            '
            'DGV_FP_MAX
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.Format = "N2"
            Me.DGV_FP_MAX.DefaultCellStyle = DataGridViewCellStyle7
            Me.DGV_FP_MAX.DividerWidth = 2
            Me.DGV_FP_MAX.HeaderText = "FP MAX"
            Me.DGV_FP_MAX.Name = "DGV_FP_MAX"
            Me.DGV_FP_MAX.ReadOnly = True
            Me.DGV_FP_MAX.ToolTipText = "FINISH POSITION MAXIMUM"
            Me.DGV_FP_MAX.Width = 40
            '
            'DGV_SMN
            '
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.Format = "N2"
            DataGridViewCellStyle8.NullValue = "0.00"
            Me.DGV_SMN.DefaultCellStyle = DataGridViewCellStyle8
            Me.DGV_SMN.HeaderText = "S  MIN"
            Me.DGV_SMN.Name = "DGV_SMN"
            Me.DGV_SMN.ReadOnly = True
            Me.DGV_SMN.ToolTipText = "SPEED MINIMUM"
            Me.DGV_SMN.Width = 40
            '
            'DGV_SAVG
            '
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.Format = "N2"
            DataGridViewCellStyle9.NullValue = "0.00"
            Me.DGV_SAVG.DefaultCellStyle = DataGridViewCellStyle9
            Me.DGV_SAVG.HeaderText = "S  AVG"
            Me.DGV_SAVG.Name = "DGV_SAVG"
            Me.DGV_SAVG.ReadOnly = True
            Me.DGV_SAVG.ToolTipText = "SPEED AVERAGE"
            Me.DGV_SAVG.Width = 40
            '
            'DGV_SMX
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.Format = "N2"
            DataGridViewCellStyle10.NullValue = "0.00"
            Me.DGV_SMX.DefaultCellStyle = DataGridViewCellStyle10
            Me.DGV_SMX.DividerWidth = 2
            Me.DGV_SMX.HeaderText = "S  MAX"
            Me.DGV_SMX.Name = "DGV_SMX"
            Me.DGV_SMX.ReadOnly = True
            Me.DGV_SMX.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_SMX.ToolTipText = "SPEED MAX"
            Me.DGV_SMX.Width = 40
            '
            'DGV_DB_MIN
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.Format = "N2"
            Me.DGV_DB_MIN.DefaultCellStyle = DataGridViewCellStyle11
            Me.DGV_DB_MIN.HeaderText = "DB MIN"
            Me.DGV_DB_MIN.Name = "DGV_DB_MIN"
            Me.DGV_DB_MIN.ReadOnly = True
            Me.DGV_DB_MIN.ToolTipText = "DISTANCE BEHIND MINIMUM"
            Me.DGV_DB_MIN.Width = 40
            '
            'DGV_DB_AVG
            '
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.Format = "N2"
            Me.DGV_DB_AVG.DefaultCellStyle = DataGridViewCellStyle12
            Me.DGV_DB_AVG.HeaderText = "DB AVG"
            Me.DGV_DB_AVG.Name = "DGV_DB_AVG"
            Me.DGV_DB_AVG.ReadOnly = True
            Me.DGV_DB_AVG.ToolTipText = "DISTANCE BEHIND AVERAGE"
            Me.DGV_DB_AVG.Width = 40
            '
            'DGV_DB_MAX
            '
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.Format = "N2"
            Me.DGV_DB_MAX.DefaultCellStyle = DataGridViewCellStyle13
            Me.DGV_DB_MAX.DividerWidth = 2
            Me.DGV_DB_MAX.HeaderText = "DB MAX"
            Me.DGV_DB_MAX.Name = "DGV_DB_MAX"
            Me.DGV_DB_MAX.ReadOnly = True
            Me.DGV_DB_MAX.ToolTipText = "DISTANCE BEHIND MAXIMUM"
            Me.DGV_DB_MAX.Width = 40
            '
            'DGV_WIN
            '
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.Format = "N0"
            DataGridViewCellStyle14.NullValue = "0"
            Me.DGV_WIN.DefaultCellStyle = DataGridViewCellStyle14
            Me.DGV_WIN.HeaderText = "WIN %"
            Me.DGV_WIN.Name = "DGV_WIN"
            Me.DGV_WIN.ReadOnly = True
            Me.DGV_WIN.ToolTipText = "WIN %"
            Me.DGV_WIN.Width = 40
            '
            'DGV_PLC
            '
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.Format = "N0"
            DataGridViewCellStyle15.NullValue = "0"
            Me.DGV_PLC.DefaultCellStyle = DataGridViewCellStyle15
            Me.DGV_PLC.DividerWidth = 2
            Me.DGV_PLC.HeaderText = "PLC %"
            Me.DGV_PLC.Name = "DGV_PLC"
            Me.DGV_PLC.ReadOnly = True
            Me.DGV_PLC.ToolTipText = "PLACE %"
            Me.DGV_PLC.Width = 40
            '
            'DGV_TREND
            '
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle16.Format = "N1"
            DataGridViewCellStyle16.NullValue = "-25"
            Me.DGV_TREND.DefaultCellStyle = DataGridViewCellStyle16
            Me.DGV_TREND.HeaderText = "T"
            Me.DGV_TREND.Name = "DGV_TREND"
            Me.DGV_TREND.ReadOnly = True
            Me.DGV_TREND.ToolTipText = "TREND - HIGHER VALUE = BETTER"
            Me.DGV_TREND.Width = 30
            '
            'DGV_TRENDSTATUS
            '
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.Format = "N0"
            DataGridViewCellStyle17.NullValue = "0"
            Me.DGV_TRENDSTATUS.DefaultCellStyle = DataGridViewCellStyle17
            Me.DGV_TRENDSTATUS.DividerWidth = 2
            Me.DGV_TRENDSTATUS.HeaderText = "TS"
            Me.DGV_TRENDSTATUS.Name = "DGV_TRENDSTATUS"
            Me.DGV_TRENDSTATUS.ReadOnly = True
            Me.DGV_TRENDSTATUS.ToolTipText = "TREND STATUS"
            Me.DGV_TRENDSTATUS.Width = 30
            '
            'DGV_SMINDAYSAGO
            '
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.Format = "N0"
            Me.DGV_SMINDAYSAGO.DefaultCellStyle = DataGridViewCellStyle18
            Me.DGV_SMINDAYSAGO.HeaderText = "S-MIN-DA"
            Me.DGV_SMINDAYSAGO.Name = "DGV_SMINDAYSAGO"
            Me.DGV_SMINDAYSAGO.ReadOnly = True
            Me.DGV_SMINDAYSAGO.ToolTipText = "SPEED MIN DAYS AGO"
            Me.DGV_SMINDAYSAGO.Width = 40
            '
            'DGV_SMAXDAYSAGO
            '
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle19.Format = "N0"
            Me.DGV_SMAXDAYSAGO.DefaultCellStyle = DataGridViewCellStyle19
            Me.DGV_SMAXDAYSAGO.DividerWidth = 2
            Me.DGV_SMAXDAYSAGO.HeaderText = "S-MAX-DA"
            Me.DGV_SMAXDAYSAGO.Name = "DGV_SMAXDAYSAGO"
            Me.DGV_SMAXDAYSAGO.ReadOnly = True
            Me.DGV_SMAXDAYSAGO.ToolTipText = "SPEED MAX DAYS AGO"
            Me.DGV_SMAXDAYSAGO.Width = 40
            '
            'DGV_SCORE_RANK
            '
            DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle20.Format = "N2"
            Me.DGV_SCORE_RANK.DefaultCellStyle = DataGridViewCellStyle20
            Me.DGV_SCORE_RANK.HeaderText = "S RANK"
            Me.DGV_SCORE_RANK.Name = "DGV_SCORE_RANK"
            Me.DGV_SCORE_RANK.ReadOnly = True
            Me.DGV_SCORE_RANK.ToolTipText = "SCORE RANK"
            Me.DGV_SCORE_RANK.Width = 40
            '
            'DGV_SCORE_RANK_PERCENT
            '
            DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle21.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle21.Format = "N2"
            Me.DGV_SCORE_RANK_PERCENT.DefaultCellStyle = DataGridViewCellStyle21
            Me.DGV_SCORE_RANK_PERCENT.HeaderText = "S RANK %"
            Me.DGV_SCORE_RANK_PERCENT.Name = "DGV_SCORE_RANK_PERCENT"
            Me.DGV_SCORE_RANK_PERCENT.ReadOnly = True
            Me.DGV_SCORE_RANK_PERCENT.ToolTipText = "SCORE RANK PERCENT"
            Me.DGV_SCORE_RANK_PERCENT.Width = 40
            '
            'DGV_SCORE_RANK_DIFFERENCE
            '
            DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle22.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle22.Format = "N2"
            Me.DGV_SCORE_RANK_DIFFERENCE.DefaultCellStyle = DataGridViewCellStyle22
            Me.DGV_SCORE_RANK_DIFFERENCE.DividerWidth = 2
            Me.DGV_SCORE_RANK_DIFFERENCE.HeaderText = "S RANK DIFF"
            Me.DGV_SCORE_RANK_DIFFERENCE.Name = "DGV_SCORE_RANK_DIFFERENCE"
            Me.DGV_SCORE_RANK_DIFFERENCE.ReadOnly = True
            Me.DGV_SCORE_RANK_DIFFERENCE.ToolTipText = "SCORE RANK DIFFERENCE"
            Me.DGV_SCORE_RANK_DIFFERENCE.Width = 40
            '
            'DGV_NAME
            '
            Me.DGV_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle23.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_NAME.DefaultCellStyle = DataGridViewCellStyle23
            Me.DGV_NAME.HeaderText = "NAME"
            Me.DGV_NAME.Name = "DGV_NAME"
            Me.DGV_NAME.ReadOnly = True
            Me.DGV_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DGV_NAME.ToolTipText = "NAME OF RUNNER"
            '
            'UC_Extended
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.DGV_MAIN)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_Extended"
            Me.Size = New System.Drawing.Size(800, 300)
            CType(Me.DGV_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
            Me.CMS_DGV_MAIN.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents DGV_MAIN As System.Windows.Forms.DataGridView
        Private WithEvents CMS_DGV_MAIN As System.Windows.Forms.ContextMenuStrip
        Private WithEvents TSMI_MAIN_COPY As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DGV_NUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_RUNS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_FP_MIN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_FP_AVG As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_FP_MAX As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SMN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SAVG As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SMX As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_DB_MIN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_DB_AVG As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_DB_MAX As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_WIN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLC As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_TREND As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_TRENDSTATUS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SMINDAYSAGO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SMAXDAYSAGO As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SCORE_RANK As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SCORE_RANK_PERCENT As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SCORE_RANK_DIFFERENCE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_NAME As System.Windows.Forms.DataGridViewLinkColumn

    End Class
End Namespace