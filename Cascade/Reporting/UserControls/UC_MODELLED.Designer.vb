Namespace Reporting.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_MODELLED
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                    If Not MY_DISPLAYRACE Is Nothing Then MY_DISPLAYRACE.Dispose() : MY_DISPLAYRACE = Nothing
                    If Not MY_POPUP Is Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
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
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
            Me.DGV = New System.Windows.Forms.DataGridView()
            Me.DGV_CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.TSMI_DGV_CMS_COPY = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSS_DGV_CMS_1 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSMI_DGV_CMS_DELETE = New System.Windows.Forms.ToolStripMenuItem()
            Me.BUT_GO = New System.Windows.Forms.Button()
            Me.DTP_TO = New System.Windows.Forms.DateTimePicker()
            Me.LBL_TO = New System.Windows.Forms.Label()
            Me.DTP_FROM = New System.Windows.Forms.DateTimePicker()
            Me.LBL_TYPE = New System.Windows.Forms.Label()
            Me.LBL_FROM = New System.Windows.Forms.Label()
            Me.CB_TYPE = New System.Windows.Forms.ComboBox()
            Me.LBLNOTE = New System.Windows.Forms.Label()
            Me.DGV_RACE_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RACE_NAME = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.DGV_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_VENUE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_CLASS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LENGTH = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_TRACK = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_WEATHER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_WINS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_PLACES = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DGV_CMS.SuspendLayout()
            Me.SuspendLayout()
            '
            'DGV
            '
            Me.DGV.AllowUserToAddRows = False
            Me.DGV.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DGV.BackgroundColor = System.Drawing.SystemColors.Window
            Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_RACE_TIME, Me.DGV_RACE_NAME, Me.DGV_STATUS, Me.DGV_VENUE, Me.DGV_CLASS, Me.DGV_LENGTH, Me.DGV_TRACK, Me.DGV_WEATHER, Me.DGV_WINS, Me.DGV_PLACES})
            Me.DGV.ContextMenuStrip = Me.DGV_CMS
            Me.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV.Location = New System.Drawing.Point(6, 108)
            Me.DGV.Margin = New System.Windows.Forms.Padding(2)
            Me.DGV.Name = "DGV"
            Me.DGV.ReadOnly = True
            Me.DGV.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
            Me.DGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle14
            Me.DGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
            Me.DGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV.Size = New System.Drawing.Size(710, 218)
            Me.DGV.TabIndex = 41
            '
            'DGV_CMS
            '
            Me.DGV_CMS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_DGV_CMS_COPY, Me.TSS_DGV_CMS_1, Me.TSMI_DGV_CMS_DELETE})
            Me.DGV_CMS.Name = "DGVCMS"
            Me.DGV_CMS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.DGV_CMS.Size = New System.Drawing.Size(109, 54)
            '
            'TSMI_DGV_CMS_COPY
            '
            Me.TSMI_DGV_CMS_COPY.Image = Nothing
            Me.TSMI_DGV_CMS_COPY.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_DGV_CMS_COPY.Name = "TSMI_DGV_CMS_COPY"
            Me.TSMI_DGV_CMS_COPY.Size = New System.Drawing.Size(108, 22)
            Me.TSMI_DGV_CMS_COPY.Text = "&Copy"
            '
            'TSS_DGV_CMS_1
            '
            Me.TSS_DGV_CMS_1.Name = "TSS_DGV_CMS_1"
            Me.TSS_DGV_CMS_1.Size = New System.Drawing.Size(105, 6)
            '
            'TSMI_DGV_CMS_DELETE
            '
            Me.TSMI_DGV_CMS_DELETE.Name = "TSMI_DGV_CMS_DELETE"
            Me.TSMI_DGV_CMS_DELETE.Size = New System.Drawing.Size(108, 22)
            Me.TSMI_DGV_CMS_DELETE.Text = "&Delete"
            '
            'BUT_GO
            '
            Me.BUT_GO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BUT_GO.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.BUT_GO.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BUT_GO.Location = New System.Drawing.Point(664, 2)
            Me.BUT_GO.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.BUT_GO.Name = "BUT_GO"
            Me.BUT_GO.Size = New System.Drawing.Size(50, 21)
            Me.BUT_GO.TabIndex = 47
            Me.BUT_GO.Text = "GO!"
            Me.BUT_GO.UseVisualStyleBackColor = True
            '
            'DTP_TO
            '
            Me.DTP_TO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DTP_TO.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DTP_TO.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DTP_TO.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DTP_TO.Location = New System.Drawing.Point(164, 3)
            Me.DTP_TO.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.DTP_TO.Name = "DTP_TO"
            Me.DTP_TO.Size = New System.Drawing.Size(88, 20)
            Me.DTP_TO.TabIndex = 43
            '
            'LBL_TO
            '
            Me.LBL_TO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LBL_TO.AutoSize = True
            Me.LBL_TO.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_TO.Location = New System.Drawing.Point(140, 7)
            Me.LBL_TO.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.LBL_TO.Name = "LBL_TO"
            Me.LBL_TO.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LBL_TO.Size = New System.Drawing.Size(22, 13)
            Me.LBL_TO.TabIndex = 44
            Me.LBL_TO.Text = "TO:"
            Me.LBL_TO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'DTP_FROM
            '
            Me.DTP_FROM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DTP_FROM.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DTP_FROM.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DTP_FROM.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.DTP_FROM.Location = New System.Drawing.Point(51, 3)
            Me.DTP_FROM.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.DTP_FROM.Name = "DTP_FROM"
            Me.DTP_FROM.Size = New System.Drawing.Size(85, 20)
            Me.DTP_FROM.TabIndex = 45
            '
            'LBL_TYPE
            '
            Me.LBL_TYPE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LBL_TYPE.AutoSize = True
            Me.LBL_TYPE.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_TYPE.Location = New System.Drawing.Point(266, 7)
            Me.LBL_TYPE.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.LBL_TYPE.Name = "LBL_TYPE"
            Me.LBL_TYPE.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LBL_TYPE.Size = New System.Drawing.Size(32, 13)
            Me.LBL_TYPE.TabIndex = 49
            Me.LBL_TYPE.Text = "TYPE:"
            '
            'LBL_FROM
            '
            Me.LBL_FROM.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LBL_FROM.AutoSize = True
            Me.LBL_FROM.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_FROM.Location = New System.Drawing.Point(13, 7)
            Me.LBL_FROM.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.LBL_FROM.Name = "LBL_FROM"
            Me.LBL_FROM.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.LBL_FROM.Size = New System.Drawing.Size(38, 13)
            Me.LBL_FROM.TabIndex = 46
            Me.LBL_FROM.Text = "FROM:"
            Me.LBL_FROM.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'CB_TYPE
            '
            Me.CB_TYPE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.CB_TYPE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.CB_TYPE.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CB_TYPE.FormattingEnabled = True
            Me.CB_TYPE.Location = New System.Drawing.Point(302, 4)
            Me.CB_TYPE.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.CB_TYPE.Name = "CB_TYPE"
            Me.CB_TYPE.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.CB_TYPE.Size = New System.Drawing.Size(68, 21)
            Me.CB_TYPE.TabIndex = 48
            '
            'LBLNOTE
            '
            Me.LBLNOTE.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LBLNOTE.Font = New System.Drawing.Font("Calibri", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBLNOTE.Location = New System.Drawing.Point(6, 91)
            Me.LBLNOTE.Name = "LBLNOTE"
            Me.LBLNOTE.Size = New System.Drawing.Size(708, 15)
            Me.LBLNOTE.TabIndex = 52
            Me.LBLNOTE.Text = "NB: RESULTS ARE BASED ON THE LAST MODEL RUN."
            Me.LBLNOTE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'DGV_RACE_TIME
            '
            Me.DGV_RACE_TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.Format = "T"
            Me.DGV_RACE_TIME.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_RACE_TIME.HeaderText = "RACE TIME"
            Me.DGV_RACE_TIME.Name = "DGV_RACE_TIME"
            Me.DGV_RACE_TIME.ReadOnly = True
            Me.DGV_RACE_TIME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_RACE_TIME.Width = 79
            '
            'DGV_RACE_NAME
            '
            Me.DGV_RACE_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RACE_NAME.DefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_RACE_NAME.HeaderText = "RACE NAME"
            Me.DGV_RACE_NAME.Name = "DGV_RACE_NAME"
            Me.DGV_RACE_NAME.ReadOnly = True
            Me.DGV_RACE_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_RACE_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DGV_RACE_NAME.Width = 84
            '
            'DGV_STATUS
            '
            Me.DGV_STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_STATUS.DefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_STATUS.HeaderText = "STATUS"
            Me.DGV_STATUS.Name = "DGV_STATUS"
            Me.DGV_STATUS.ReadOnly = True
            Me.DGV_STATUS.Width = 63
            '
            'DGV_VENUE
            '
            Me.DGV_VENUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_VENUE.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_VENUE.HeaderText = "VENUE"
            Me.DGV_VENUE.Name = "DGV_VENUE"
            Me.DGV_VENUE.ReadOnly = True
            '
            'DGV_CLASS
            '
            Me.DGV_CLASS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_CLASS.DefaultCellStyle = DataGridViewCellStyle7
            Me.DGV_CLASS.HeaderText = "CL"
            Me.DGV_CLASS.Name = "DGV_CLASS"
            Me.DGV_CLASS.ReadOnly = True
            Me.DGV_CLASS.ToolTipText = "CLASS"
            Me.DGV_CLASS.Width = 43
            '
            'DGV_LENGTH
            '
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.Format = "N0"
            DataGridViewCellStyle8.NullValue = "0"
            Me.DGV_LENGTH.DefaultCellStyle = DataGridViewCellStyle8
            Me.DGV_LENGTH.HeaderText = "LENGTH"
            Me.DGV_LENGTH.Name = "DGV_LENGTH"
            Me.DGV_LENGTH.ReadOnly = True
            Me.DGV_LENGTH.Width = 68
            '
            'DGV_TRACK
            '
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_TRACK.DefaultCellStyle = DataGridViewCellStyle9
            Me.DGV_TRACK.HeaderText = "TRACK"
            Me.DGV_TRACK.Name = "DGV_TRACK"
            Me.DGV_TRACK.ReadOnly = True
            Me.DGV_TRACK.Width = 61
            '
            'DGV_WEATHER
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_WEATHER.DefaultCellStyle = DataGridViewCellStyle10
            Me.DGV_WEATHER.HeaderText = "WEATHER"
            Me.DGV_WEATHER.Name = "DGV_WEATHER"
            Me.DGV_WEATHER.ReadOnly = True
            '
            'DGV_WINS
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle11.Format = "C2"
            Me.DGV_WINS.DefaultCellStyle = DataGridViewCellStyle11
            Me.DGV_WINS.HeaderText = "WINS"
            Me.DGV_WINS.Name = "DGV_WINS"
            Me.DGV_WINS.ReadOnly = True
            '
            'DGV_PLACES
            '
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.Format = "C2"
            Me.DGV_PLACES.DefaultCellStyle = DataGridViewCellStyle12
            Me.DGV_PLACES.HeaderText = "PLACES"
            Me.DGV_PLACES.Name = "DGV_PLACES"
            Me.DGV_PLACES.ReadOnly = True
            Me.DGV_PLACES.Width = 65
            '
            'UC_MODELLED
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.LBLNOTE)
            Me.Controls.Add(Me.DGV)
            Me.Controls.Add(Me.BUT_GO)
            Me.Controls.Add(Me.DTP_TO)
            Me.Controls.Add(Me.LBL_TO)
            Me.Controls.Add(Me.DTP_FROM)
            Me.Controls.Add(Me.LBL_TYPE)
            Me.Controls.Add(Me.LBL_FROM)
            Me.Controls.Add(Me.CB_TYPE)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_MODELLED"
            Me.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.Size = New System.Drawing.Size(720, 340)
            CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DGV_CMS.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents DGV As System.Windows.Forms.DataGridView
        Private WithEvents BUT_GO As System.Windows.Forms.Button
        Private WithEvents DTP_TO As System.Windows.Forms.DateTimePicker
        Private WithEvents LBL_TO As System.Windows.Forms.Label
        Private WithEvents DTP_FROM As System.Windows.Forms.DateTimePicker
        Private WithEvents LBL_TYPE As System.Windows.Forms.Label
        Private WithEvents LBL_FROM As System.Windows.Forms.Label
        Private WithEvents CB_TYPE As System.Windows.Forms.ComboBox
        Private WithEvents DGV_CMS As System.Windows.Forms.ContextMenuStrip
        Private WithEvents TSMI_DGV_CMS_COPY As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TSS_DGV_CMS_1 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents TSMI_DGV_CMS_DELETE As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents LBLNOTE As System.Windows.Forms.Label
        Friend WithEvents DGV_RACE_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_RACE_NAME As System.Windows.Forms.DataGridViewLinkColumn
        Friend WithEvents DGV_STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_VENUE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_CLASS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LENGTH As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_TRACK As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_WEATHER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_WINS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLACES As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace