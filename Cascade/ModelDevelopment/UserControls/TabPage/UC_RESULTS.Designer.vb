Namespace ModelDevelopment.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_RESULTS
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                If Not MY_POPUP Is Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
                If Not MY_DISPLAYRACE Is Nothing Then MY_DISPLAYRACE.Dispose() : MY_DISPLAYRACE = Nothing
                If Not MY_UI_MODEL_TOTALS Is Nothing Then MY_UI_MODEL_TOTALS.Dispose() : MY_UI_MODEL_TOTALS = Nothing
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
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
            Me.DGV_RESULTS_CMS = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.DGV_RESULTS_CMS_CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DGV_RESULTS = New System.Windows.Forms.DataGridView()
            Me.LBL_RANGE_HEADER = New System.Windows.Forms.Label()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.DGV_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_BARRIER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_NAME = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.DGV_CLASS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_MEETINGNAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RACELENGTH = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_VENUE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_WEATHER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_TRACK = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_FINISHPOSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_WINS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_PLACES = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RESULTS_CMS.SuspendLayout()
            CType(Me.DGV_RESULTS, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel1.SuspendLayout()
            Me.SuspendLayout()
            '
            'DGV_RESULTS_CMS
            '
            Me.DGV_RESULTS_CMS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RESULTS_CMS.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DGV_RESULTS_CMS_CopyToolStripMenuItem})
            Me.DGV_RESULTS_CMS.Name = "DGVCMS"
            Me.DGV_RESULTS_CMS.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
            Me.DGV_RESULTS_CMS.Size = New System.Drawing.Size(102, 26)
            '
            'DGV_RESULTS_CMS_CopyToolStripMenuItem
            '
            Me.DGV_RESULTS_CMS_CopyToolStripMenuItem.Image = Nothing
            Me.DGV_RESULTS_CMS_CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.DGV_RESULTS_CMS_CopyToolStripMenuItem.Name = "DGV_RESULTS_CMS_CopyToolStripMenuItem"
            Me.DGV_RESULTS_CMS_CopyToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
            Me.DGV_RESULTS_CMS_CopyToolStripMenuItem.Text = "&Copy"
            '
            'DGV_RESULTS
            '
            Me.DGV_RESULTS.AllowUserToAddRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_RESULTS.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV_RESULTS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DGV_RESULTS.BackgroundColor = System.Drawing.SystemColors.Window
            Me.DGV_RESULTS.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DGV_RESULTS.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            Me.DGV_RESULTS.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_RESULTS.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV_RESULTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV_RESULTS.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_DATE, Me.DGV_NUMBER, Me.DGV_BARRIER, Me.DGV_NAME, Me.DGV_CLASS, Me.DGV_MEETINGNAME, Me.DGV_RACELENGTH, Me.DGV_VENUE, Me.DGV_WEATHER, Me.DGV_TRACK, Me.DGV_FINISHPOSITION, Me.DGV_WINS, Me.DGV_PLACES})
            Me.DGV_RESULTS.ContextMenuStrip = Me.DGV_RESULTS_CMS
            Me.DGV_RESULTS.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV_RESULTS.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV_RESULTS.Location = New System.Drawing.Point(0, 84)
            Me.DGV_RESULTS.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV_RESULTS.Name = "DGV_RESULTS"
            Me.DGV_RESULTS.ReadOnly = True
            Me.DGV_RESULTS.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_RESULTS.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
            Me.DGV_RESULTS.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_RESULTS.RowsDefaultCellStyle = DataGridViewCellStyle17
            Me.DGV_RESULTS.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV_RESULTS.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RESULTS.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV_RESULTS.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
            Me.DGV_RESULTS.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_RESULTS.RowTemplate.Height = 24
            Me.DGV_RESULTS.RowTemplate.ReadOnly = True
            Me.DGV_RESULTS.Size = New System.Drawing.Size(663, 249)
            Me.DGV_RESULTS.TabIndex = 1060
            '
            'LBL_RANGE_HEADER
            '
            Me.LBL_RANGE_HEADER.BackColor = System.Drawing.SystemColors.GradientActiveCaption
            Me.LBL_RANGE_HEADER.Dock = System.Windows.Forms.DockStyle.Top
            Me.LBL_RANGE_HEADER.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LBL_RANGE_HEADER.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
            Me.LBL_RANGE_HEADER.Location = New System.Drawing.Point(0, 0)
            Me.LBL_RANGE_HEADER.Margin = New System.Windows.Forms.Padding(0)
            Me.LBL_RANGE_HEADER.Name = "LBL_RANGE_HEADER"
            Me.LBL_RANGE_HEADER.Size = New System.Drawing.Size(663, 19)
            Me.LBL_RANGE_HEADER.TabIndex = 0
            Me.LBL_RANGE_HEADER.Text = "RANGE:"
            Me.LBL_RANGE_HEADER.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
            '
            'Panel1
            '
            Me.Panel1.Controls.Add(Me.LBL_RANGE_HEADER)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(663, 84)
            Me.Panel1.TabIndex = 1061
            '
            'DGV_DATE
            '
            Me.DGV_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle3.Format = "d"
            DataGridViewCellStyle3.NullValue = Nothing
            DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_DATE.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_DATE.HeaderText = "DATE"
            Me.DGV_DATE.Name = "DGV_DATE"
            Me.DGV_DATE.ReadOnly = True
            Me.DGV_DATE.ToolTipText = "DATE"
            Me.DGV_DATE.Width = 54
            '
            'DGV_NUMBER
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.Format = "N0"
            DataGridViewCellStyle4.NullValue = "0"
            Me.DGV_NUMBER.DefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_NUMBER.HeaderText = "#"
            Me.DGV_NUMBER.Name = "DGV_NUMBER"
            Me.DGV_NUMBER.ReadOnly = True
            Me.DGV_NUMBER.ToolTipText = "NUMBER"
            Me.DGV_NUMBER.Width = 25
            '
            'DGV_BARRIER
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.Format = "N0"
            DataGridViewCellStyle5.NullValue = "0"
            Me.DGV_BARRIER.DefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_BARRIER.HeaderText = "B"
            Me.DGV_BARRIER.Name = "DGV_BARRIER"
            Me.DGV_BARRIER.ReadOnly = True
            Me.DGV_BARRIER.ToolTipText = "BARRIER"
            Me.DGV_BARRIER.Width = 25
            '
            'DGV_NAME
            '
            Me.DGV_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_NAME.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_NAME.DividerWidth = 1
            Me.DGV_NAME.HeaderText = "NAME"
            Me.DGV_NAME.Name = "DGV_NAME"
            Me.DGV_NAME.ReadOnly = True
            Me.DGV_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_NAME.ToolTipText = "RUNNER NAME"
            Me.DGV_NAME.Width = 41
            '
            'DGV_CLASS
            '
            Me.DGV_CLASS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.Format = "N0"
            DataGridViewCellStyle7.NullValue = "999"
            Me.DGV_CLASS.DefaultCellStyle = DataGridViewCellStyle7
            Me.DGV_CLASS.HeaderText = "CL"
            Me.DGV_CLASS.Name = "DGV_CLASS"
            Me.DGV_CLASS.ReadOnly = True
            Me.DGV_CLASS.Width = 43
            '
            'DGV_MEETINGNAME
            '
            Me.DGV_MEETINGNAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MEETINGNAME.DefaultCellStyle = DataGridViewCellStyle8
            Me.DGV_MEETINGNAME.HeaderText = "M-N"
            Me.DGV_MEETINGNAME.Name = "DGV_MEETINGNAME"
            Me.DGV_MEETINGNAME.ReadOnly = True
            Me.DGV_MEETINGNAME.ToolTipText = "MEETING NAME"
            Me.DGV_MEETINGNAME.Width = 51
            '
            'DGV_RACELENGTH
            '
            Me.DGV_RACELENGTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.Format = "N0"
            DataGridViewCellStyle9.NullValue = "0"
            Me.DGV_RACELENGTH.DefaultCellStyle = DataGridViewCellStyle9
            Me.DGV_RACELENGTH.HeaderText = "L"
            Me.DGV_RACELENGTH.Name = "DGV_RACELENGTH"
            Me.DGV_RACELENGTH.ReadOnly = True
            Me.DGV_RACELENGTH.ToolTipText = "LENGTH"
            Me.DGV_RACELENGTH.Width = 37
            '
            'DGV_VENUE
            '
            Me.DGV_VENUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_VENUE.DefaultCellStyle = DataGridViewCellStyle10
            Me.DGV_VENUE.HeaderText = "VENUE"
            Me.DGV_VENUE.Name = "DGV_VENUE"
            Me.DGV_VENUE.ReadOnly = True
            Me.DGV_VENUE.ToolTipText = "VENUE"
            '
            'DGV_WEATHER
            '
            Me.DGV_WEATHER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_WEATHER.DefaultCellStyle = DataGridViewCellStyle11
            Me.DGV_WEATHER.HeaderText = "W"
            Me.DGV_WEATHER.Name = "DGV_WEATHER"
            Me.DGV_WEATHER.ReadOnly = True
            Me.DGV_WEATHER.ToolTipText = "WEATHER"
            Me.DGV_WEATHER.Width = 42
            '
            'DGV_TRACK
            '
            Me.DGV_TRACK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_TRACK.DefaultCellStyle = DataGridViewCellStyle12
            Me.DGV_TRACK.DividerWidth = 1
            Me.DGV_TRACK.HeaderText = "T"
            Me.DGV_TRACK.Name = "DGV_TRACK"
            Me.DGV_TRACK.ReadOnly = True
            Me.DGV_TRACK.ToolTipText = "TRACK"
            Me.DGV_TRACK.Width = 38
            '
            'DGV_FINISHPOSITION
            '
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.Format = "N0"
            DataGridViewCellStyle13.NullValue = "0"
            Me.DGV_FINISHPOSITION.DefaultCellStyle = DataGridViewCellStyle13
            Me.DGV_FINISHPOSITION.HeaderText = "F-P"
            Me.DGV_FINISHPOSITION.Name = "DGV_FINISHPOSITION"
            Me.DGV_FINISHPOSITION.ReadOnly = True
            Me.DGV_FINISHPOSITION.ToolTipText = "FINISH POSITION"
            Me.DGV_FINISHPOSITION.Width = 25
            '
            'DGV_WINS
            '
            Me.DGV_WINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.Format = "C2"
            DataGridViewCellStyle14.NullValue = "0.00"
            Me.DGV_WINS.DefaultCellStyle = DataGridViewCellStyle14
            Me.DGV_WINS.HeaderText = "P-W"
            Me.DGV_WINS.Name = "DGV_WINS"
            Me.DGV_WINS.ReadOnly = True
            Me.DGV_WINS.ToolTipText = "PAID WINS"
            Me.DGV_WINS.Width = 51
            '
            'DGV_PLACES
            '
            Me.DGV_PLACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.Format = "C2"
            DataGridViewCellStyle15.NullValue = "0.00"
            Me.DGV_PLACES.DefaultCellStyle = DataGridViewCellStyle15
            Me.DGV_PLACES.HeaderText = "P-P"
            Me.DGV_PLACES.Name = "DGV_PLACES"
            Me.DGV_PLACES.ReadOnly = True
            Me.DGV_PLACES.ToolTipText = "PAID PLACES"
            Me.DGV_PLACES.Width = 47
            '
            'UC_RESULTS
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Window
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.DGV_RESULTS)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_RESULTS"
            Me.Size = New System.Drawing.Size(663, 342)
            Me.DGV_RESULTS_CMS.ResumeLayout(False)
            CType(Me.DGV_RESULTS, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel1.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents DGV_RESULTS_CMS As System.Windows.Forms.ContextMenuStrip
        Private WithEvents DGV_RESULTS_CMS_CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents DGV_RESULTS As System.Windows.Forms.DataGridView
        Private WithEvents Panel1 As System.Windows.Forms.Panel
        Private WithEvents LBL_RANGE_HEADER As System.Windows.Forms.Label
        Friend WithEvents DGV_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_NUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_BARRIER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_NAME As System.Windows.Forms.DataGridViewLinkColumn
        Friend WithEvents DGV_CLASS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_MEETINGNAME As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_RACELENGTH As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_VENUE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_WEATHER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_TRACK As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_FINISHPOSITION As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_WINS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLACES As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace