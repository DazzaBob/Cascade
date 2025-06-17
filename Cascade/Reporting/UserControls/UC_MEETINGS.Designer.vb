Namespace Reporting.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_MEETINGS
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                If Not MY_DISPLAYRACE Is Nothing Then MY_DISPLAYRACE.Dispose() : MY_DISPLAYRACE = Nothing
                If Not MY_POPUP Is Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
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
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.PanelInputs = New System.Windows.Forms.Panel()
            Me.ButGO = New System.Windows.Forms.Button()
            Me.DTPTo = New System.Windows.Forms.DateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            Me.DTPFrom = New System.Windows.Forms.DateTimePicker()
            Me.LblFrom = New System.Windows.Forms.Label()
            Me.SC_MAIN = New System.Windows.Forms.SplitContainer()
            Me.DGV_MEETINGS = New System.Windows.Forms.DataGridView()
            Me.CMS_DGV_MEETINGS = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
            Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DGV_RACES = New System.Windows.Forms.DataGridView()
            Me.DGV_RACES_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RACES_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RACES_CLASS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RACES_NAME = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.DGV_RACE_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RACES_LENGTH = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RACES_TRACK = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RACES_WEATHER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RACES_RUNNERSINRACE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CMS_DGV_RACES = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.TSMI_CMS_DGV_RACES_COPY = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSMI_CMS_DGV_RACES_DELETE = New System.Windows.Forms.ToolStripMenuItem()
            Me.DGV_MEETINGS_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_MEETINGS_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_MEETINGS_NAME = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.DGV_MEETINGS_STATUS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_MEETINGS_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_MEETINGS_VENUE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.PanelInputs.SuspendLayout()
            CType(Me.SC_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SC_MAIN.Panel1.SuspendLayout()
            Me.SC_MAIN.Panel2.SuspendLayout()
            Me.SC_MAIN.SuspendLayout()
            CType(Me.DGV_MEETINGS, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.CMS_DGV_MEETINGS.SuspendLayout()
            CType(Me.DGV_RACES, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.CMS_DGV_RACES.SuspendLayout()
            Me.SuspendLayout()
            '
            'PanelInputs
            '
            Me.PanelInputs.Controls.Add(Me.ButGO)
            Me.PanelInputs.Controls.Add(Me.DTPTo)
            Me.PanelInputs.Controls.Add(Me.Label1)
            Me.PanelInputs.Controls.Add(Me.DTPFrom)
            Me.PanelInputs.Controls.Add(Me.LblFrom)
            Me.PanelInputs.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelInputs.Location = New System.Drawing.Point(0, 0)
            Me.PanelInputs.Margin = New System.Windows.Forms.Padding(0)
            Me.PanelInputs.Name = "PanelInputs"
            Me.PanelInputs.Size = New System.Drawing.Size(800, 28)
            Me.PanelInputs.TabIndex = 1
            '
            'ButGO
            '
            Me.ButGO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButGO.FlatStyle = System.Windows.Forms.FlatStyle.System
            Me.ButGO.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ButGO.Location = New System.Drawing.Point(748, 2)
            Me.ButGO.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.ButGO.Name = "ButGO"
            Me.ButGO.Size = New System.Drawing.Size(50, 21)
            Me.ButGO.TabIndex = 35
            Me.ButGO.Text = "GO!"
            Me.ButGO.UseVisualStyleBackColor = True
            '
            'DTPTo
            '
            Me.DTPTo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DTPTo.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DTPTo.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DTPTo.Location = New System.Drawing.Point(454, 3)
            Me.DTPTo.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.DTPTo.Name = "DTPTo"
            Me.DTPTo.Size = New System.Drawing.Size(198, 20)
            Me.DTPTo.TabIndex = 32
            '
            'Label1
            '
            Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.Label1.AutoSize = True
            Me.Label1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Label1.Location = New System.Drawing.Point(430, 8)
            Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(20, 13)
            Me.Label1.TabIndex = 0
            Me.Label1.Text = "To:"
            Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'DTPFrom
            '
            Me.DTPFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DTPFrom.CalendarFont = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DTPFrom.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DTPFrom.Location = New System.Drawing.Point(191, 3)
            Me.DTPFrom.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.DTPFrom.Name = "DTPFrom"
            Me.DTPFrom.Size = New System.Drawing.Size(204, 20)
            Me.DTPFrom.TabIndex = 31
            '
            'LblFrom
            '
            Me.LblFrom.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LblFrom.AutoSize = True
            Me.LblFrom.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblFrom.Location = New System.Drawing.Point(153, 8)
            Me.LblFrom.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
            Me.LblFrom.Name = "LblFrom"
            Me.LblFrom.Size = New System.Drawing.Size(34, 13)
            Me.LblFrom.TabIndex = 0
            Me.LblFrom.Text = "From:"
            Me.LblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            '
            'SC_MAIN
            '
            Me.SC_MAIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.SC_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SC_MAIN.Location = New System.Drawing.Point(0, 28)
            Me.SC_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.SC_MAIN.Name = "SC_MAIN"
            '
            'SC_MAIN.Panel1
            '
            Me.SC_MAIN.Panel1.Controls.Add(Me.DGV_MEETINGS)
            '
            'SC_MAIN.Panel2
            '
            Me.SC_MAIN.Panel2.Controls.Add(Me.DGV_RACES)
            Me.SC_MAIN.Size = New System.Drawing.Size(800, 572)
            Me.SC_MAIN.SplitterDistance = 382
            Me.SC_MAIN.TabIndex = 2
            '
            'DGV_MEETINGS
            '
            Me.DGV_MEETINGS.AllowUserToAddRows = False
            Me.DGV_MEETINGS.AllowUserToDeleteRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red
            Me.DGV_MEETINGS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV_MEETINGS.BackgroundColor = System.Drawing.Color.White
            Me.DGV_MEETINGS.BorderStyle = System.Windows.Forms.BorderStyle.None
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MEETINGS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV_MEETINGS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV_MEETINGS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_MEETINGS_DATE, Me.DGV_MEETINGS_NUMBER, Me.DGV_MEETINGS_NAME, Me.DGV_MEETINGS_STATUS, Me.DGV_MEETINGS_TYPE, Me.DGV_MEETINGS_VENUE})
            Me.DGV_MEETINGS.ContextMenuStrip = Me.CMS_DGV_MEETINGS
            Me.DGV_MEETINGS.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV_MEETINGS.Location = New System.Drawing.Point(0, 0)
            Me.DGV_MEETINGS.Margin = New System.Windows.Forms.Padding(2)
            Me.DGV_MEETINGS.Name = "DGV_MEETINGS"
            Me.DGV_MEETINGS.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.DGV_MEETINGS.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_MEETINGS.Size = New System.Drawing.Size(380, 570)
            Me.DGV_MEETINGS.TabIndex = 42
            '
            'CMS_DGV_MEETINGS
            '
            Me.CMS_DGV_MEETINGS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMS_DGV_MEETINGS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem, Me.ToolStripMenuItem1, Me.DeleteToolStripMenuItem})
            Me.CMS_DGV_MEETINGS.Name = "DGVCMS"
            Me.CMS_DGV_MEETINGS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.CMS_DGV_MEETINGS.Size = New System.Drawing.Size(109, 54)
            '
            'CopyToolStripMenuItem
            '
            Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
            Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
            Me.CopyToolStripMenuItem.Text = "&Copy"
            '
            'ToolStripMenuItem1
            '
            Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            Me.ToolStripMenuItem1.Size = New System.Drawing.Size(105, 6)
            '
            'DeleteToolStripMenuItem
            '
            Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
            Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(108, 22)
            Me.DeleteToolStripMenuItem.Text = "&Delete"
            '
            'DGV_RACES
            '
            Me.DGV_RACES.AllowUserToAddRows = False
            Me.DGV_RACES.AllowUserToDeleteRows = False
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.HotTrack
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Red
            Me.DGV_RACES.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
            Me.DGV_RACES.BackgroundColor = System.Drawing.SystemColors.Window
            Me.DGV_RACES.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DGV_RACES.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_RACES.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
            Me.DGV_RACES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV_RACES.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_RACES_TIME, Me.DGV_RACES_NUMBER, Me.DGV_RACES_CLASS, Me.DGV_RACES_NAME, Me.DGV_RACE_STATUS, Me.DGV_RACES_LENGTH, Me.DGV_RACES_TRACK, Me.DGV_RACES_WEATHER, Me.DGV_RACES_RUNNERSINRACE})
            Me.DGV_RACES.ContextMenuStrip = Me.CMS_DGV_RACES
            Me.DGV_RACES.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV_RACES.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV_RACES.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV_RACES.Location = New System.Drawing.Point(0, 0)
            Me.DGV_RACES.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV_RACES.Name = "DGV_RACES"
            Me.DGV_RACES.ReadOnly = True
            Me.DGV_RACES.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.DGV_RACES.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_RACES.RowHeadersDefaultCellStyle = DataGridViewCellStyle19
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RACES.RowsDefaultCellStyle = DataGridViewCellStyle20
            Me.DGV_RACES.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV_RACES.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RACES.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV_RACES.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
            Me.DGV_RACES.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_RACES.Size = New System.Drawing.Size(412, 570)
            Me.DGV_RACES.TabIndex = 37
            '
            'DGV_RACES_TIME
            '
            Me.DGV_RACES_TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.Format = "t"
            DataGridViewCellStyle10.NullValue = Nothing
            Me.DGV_RACES_TIME.DefaultCellStyle = DataGridViewCellStyle10
            Me.DGV_RACES_TIME.HeaderText = "RACE TIME"
            Me.DGV_RACES_TIME.Name = "DGV_RACES_TIME"
            Me.DGV_RACES_TIME.ReadOnly = True
            Me.DGV_RACES_TIME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_RACES_TIME.Width = 79
            '
            'DGV_RACES_NUMBER
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RACES_NUMBER.DefaultCellStyle = DataGridViewCellStyle11
            Me.DGV_RACES_NUMBER.HeaderText = "#"
            Me.DGV_RACES_NUMBER.Name = "DGV_RACES_NUMBER"
            Me.DGV_RACES_NUMBER.ReadOnly = True
            Me.DGV_RACES_NUMBER.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_RACES_NUMBER.ToolTipText = "NUMBER"
            Me.DGV_RACES_NUMBER.Width = 37
            '
            'DGV_RACES_CLASS
            '
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RACES_CLASS.DefaultCellStyle = DataGridViewCellStyle12
            Me.DGV_RACES_CLASS.HeaderText = "CL"
            Me.DGV_RACES_CLASS.Name = "DGV_RACES_CLASS"
            Me.DGV_RACES_CLASS.ReadOnly = True
            Me.DGV_RACES_CLASS.ToolTipText = "CLASS"
            Me.DGV_RACES_CLASS.Width = 43
            '
            'DGV_RACES_NAME
            '
            Me.DGV_RACES_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RACES_NAME.DefaultCellStyle = DataGridViewCellStyle13
            Me.DGV_RACES_NAME.HeaderText = "NAME"
            Me.DGV_RACES_NAME.Name = "DGV_RACES_NAME"
            Me.DGV_RACES_NAME.ReadOnly = True
            Me.DGV_RACES_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_RACES_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            '
            'DGV_RACE_STATUS
            '
            Me.DGV_RACE_STATUS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RACE_STATUS.DefaultCellStyle = DataGridViewCellStyle14
            Me.DGV_RACE_STATUS.HeaderText = "S"
            Me.DGV_RACE_STATUS.Name = "DGV_RACE_STATUS"
            Me.DGV_RACE_STATUS.ReadOnly = True
            Me.DGV_RACE_STATUS.ToolTipText = "STATUS"
            Me.DGV_RACE_STATUS.Width = 37
            '
            'DGV_RACES_LENGTH
            '
            Me.DGV_RACES_LENGTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.Format = "N0"
            DataGridViewCellStyle15.NullValue = "0"
            Me.DGV_RACES_LENGTH.DefaultCellStyle = DataGridViewCellStyle15
            Me.DGV_RACES_LENGTH.HeaderText = "L"
            Me.DGV_RACES_LENGTH.Name = "DGV_RACES_LENGTH"
            Me.DGV_RACES_LENGTH.ReadOnly = True
            Me.DGV_RACES_LENGTH.ToolTipText = "LENGTH"
            Me.DGV_RACES_LENGTH.Width = 37
            '
            'DGV_RACES_TRACK
            '
            Me.DGV_RACES_TRACK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_RACES_TRACK.DefaultCellStyle = DataGridViewCellStyle16
            Me.DGV_RACES_TRACK.HeaderText = "T"
            Me.DGV_RACES_TRACK.Name = "DGV_RACES_TRACK"
            Me.DGV_RACES_TRACK.ReadOnly = True
            Me.DGV_RACES_TRACK.ToolTipText = "TRACK CONDITIONS"
            Me.DGV_RACES_TRACK.Width = 37
            '
            'DGV_RACES_WEATHER
            '
            Me.DGV_RACES_WEATHER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RACES_WEATHER.DefaultCellStyle = DataGridViewCellStyle17
            Me.DGV_RACES_WEATHER.HeaderText = "W"
            Me.DGV_RACES_WEATHER.Name = "DGV_RACES_WEATHER"
            Me.DGV_RACES_WEATHER.ReadOnly = True
            Me.DGV_RACES_WEATHER.ToolTipText = "WEATHER CONDITIONS"
            Me.DGV_RACES_WEATHER.Width = 42
            '
            'DGV_RACES_RUNNERSINRACE
            '
            Me.DGV_RACES_RUNNERSINRACE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.Format = "N0"
            Me.DGV_RACES_RUNNERSINRACE.DefaultCellStyle = DataGridViewCellStyle18
            Me.DGV_RACES_RUNNERSINRACE.HeaderText = "RIR"
            Me.DGV_RACES_RUNNERSINRACE.Name = "DGV_RACES_RUNNERSINRACE"
            Me.DGV_RACES_RUNNERSINRACE.ReadOnly = True
            Me.DGV_RACES_RUNNERSINRACE.ToolTipText = "RUNNERS IN RACE"
            Me.DGV_RACES_RUNNERSINRACE.Width = 47
            '
            'CMS_DGV_RACES
            '
            Me.CMS_DGV_RACES.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMS_DGV_RACES.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_CMS_DGV_RACES_COPY, Me.ToolStripSeparator1, Me.TSMI_CMS_DGV_RACES_DELETE})
            Me.CMS_DGV_RACES.Name = "DGVCMS"
            Me.CMS_DGV_RACES.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.CMS_DGV_RACES.Size = New System.Drawing.Size(109, 54)
            '
            'TSMI_CMS_DGV_RACES_COPY
            '
            Me.TSMI_CMS_DGV_RACES_COPY.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_CMS_DGV_RACES_COPY.Name = "TSMI_CMS_DGV_RACES_COPY"
            Me.TSMI_CMS_DGV_RACES_COPY.Size = New System.Drawing.Size(108, 22)
            Me.TSMI_CMS_DGV_RACES_COPY.Text = "&Copy"
            '
            'ToolStripSeparator1
            '
            Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
            Me.ToolStripSeparator1.Size = New System.Drawing.Size(105, 6)
            '
            'TSMI_CMS_DGV_RACES_DELETE
            '
            Me.TSMI_CMS_DGV_RACES_DELETE.Name = "TSMI_CMS_DGV_RACES_DELETE"
            Me.TSMI_CMS_DGV_RACES_DELETE.Size = New System.Drawing.Size(108, 22)
            Me.TSMI_CMS_DGV_RACES_DELETE.Text = "&Delete"
            '
            'DGV_MEETINGS_DATE
            '
            Me.DGV_MEETINGS_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.Format = "d"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.DGV_MEETINGS_DATE.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_MEETINGS_DATE.HeaderText = "DATE"
            Me.DGV_MEETINGS_DATE.Name = "DGV_MEETINGS_DATE"
            Me.DGV_MEETINGS_DATE.ReadOnly = True
            Me.DGV_MEETINGS_DATE.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MEETINGS_DATE.ToolTipText = "DATE"
            Me.DGV_MEETINGS_DATE.Width = 54
            '
            'DGV_MEETINGS_NUMBER
            '
            Me.DGV_MEETINGS_NUMBER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Format = "N0"
            DataGridViewCellStyle4.NullValue = "0"
            Me.DGV_MEETINGS_NUMBER.DefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_MEETINGS_NUMBER.HeaderText = "#"
            Me.DGV_MEETINGS_NUMBER.Name = "DGV_MEETINGS_NUMBER"
            Me.DGV_MEETINGS_NUMBER.ReadOnly = True
            Me.DGV_MEETINGS_NUMBER.ToolTipText = "NUMBER"
            Me.DGV_MEETINGS_NUMBER.Width = 37
            '
            'DGV_MEETINGS_NAME
            '
            Me.DGV_MEETINGS_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
            Me.DGV_MEETINGS_NAME.HeaderText = "NAME"
            Me.DGV_MEETINGS_NAME.Name = "DGV_MEETINGS_NAME"
            Me.DGV_MEETINGS_NAME.ReadOnly = True
            Me.DGV_MEETINGS_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MEETINGS_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DGV_MEETINGS_NAME.ToolTipText = "NAME"
            Me.DGV_MEETINGS_NAME.Width = 59
            '
            'DGV_MEETINGS_STATUS
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DGV_MEETINGS_STATUS.DefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_MEETINGS_STATUS.HeaderText = "S"
            Me.DGV_MEETINGS_STATUS.Name = "DGV_MEETINGS_STATUS"
            Me.DGV_MEETINGS_STATUS.ReadOnly = True
            Me.DGV_MEETINGS_STATUS.ToolTipText = "STATUS"
            Me.DGV_MEETINGS_STATUS.Width = 37
            '
            'DGV_MEETINGS_TYPE
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            Me.DGV_MEETINGS_TYPE.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_MEETINGS_TYPE.HeaderText = "T"
            Me.DGV_MEETINGS_TYPE.Name = "DGV_MEETINGS_TYPE"
            Me.DGV_MEETINGS_TYPE.ReadOnly = True
            Me.DGV_MEETINGS_TYPE.ToolTipText = "TYPE"
            Me.DGV_MEETINGS_TYPE.Width = 37
            '
            'DGV_MEETINGS_VENUE
            '
            Me.DGV_MEETINGS_VENUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_MEETINGS_VENUE.DefaultCellStyle = DataGridViewCellStyle7
            Me.DGV_MEETINGS_VENUE.HeaderText = "VENUE"
            Me.DGV_MEETINGS_VENUE.Name = "DGV_MEETINGS_VENUE"
            Me.DGV_MEETINGS_VENUE.ReadOnly = True
            Me.DGV_MEETINGS_VENUE.ToolTipText = "VENUE"
            '
            'UC_MEETINGS
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.SC_MAIN)
            Me.Controls.Add(Me.PanelInputs)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_MEETINGS"
            Me.Size = New System.Drawing.Size(800, 600)
            Me.PanelInputs.ResumeLayout(False)
            Me.PanelInputs.PerformLayout()
            Me.SC_MAIN.Panel1.ResumeLayout(False)
            Me.SC_MAIN.Panel2.ResumeLayout(False)
            CType(Me.SC_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SC_MAIN.ResumeLayout(False)
            CType(Me.DGV_MEETINGS, System.ComponentModel.ISupportInitialize).EndInit()
            Me.CMS_DGV_MEETINGS.ResumeLayout(False)
            CType(Me.DGV_RACES, System.ComponentModel.ISupportInitialize).EndInit()
            Me.CMS_DGV_RACES.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents PanelInputs As System.Windows.Forms.Panel
        Private WithEvents ButGO As System.Windows.Forms.Button
        Private WithEvents DTPTo As System.Windows.Forms.DateTimePicker
        Private WithEvents Label1 As System.Windows.Forms.Label
        Private WithEvents DTPFrom As System.Windows.Forms.DateTimePicker
        Private WithEvents LblFrom As System.Windows.Forms.Label
        Private WithEvents DGV_MEETINGS As System.Windows.Forms.DataGridView
        Private WithEvents SC_MAIN As System.Windows.Forms.SplitContainer
        Private WithEvents DGV_RACES As System.Windows.Forms.DataGridView
        Private WithEvents CMS_DGV_MEETINGS As System.Windows.Forms.ContextMenuStrip
        Private WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CMS_DGV_RACES As System.Windows.Forms.ContextMenuStrip
        Private WithEvents TSMI_CMS_DGV_RACES_COPY As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents TSMI_CMS_DGV_RACES_DELETE As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents DGV_RACES_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_RACES_NUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_RACES_CLASS As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_RACES_NAME As System.Windows.Forms.DataGridViewLinkColumn
        Private WithEvents DGV_RACE_STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_RACES_LENGTH As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_RACES_TRACK As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_RACES_WEATHER As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_RACES_RUNNERSINRACE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_MEETINGS_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_MEETINGS_NUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_MEETINGS_NAME As System.Windows.Forms.DataGridViewLinkColumn
        Friend WithEvents DGV_MEETINGS_STATUS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_MEETINGS_TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_MEETINGS_VENUE As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace