Namespace DisplayRace
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_BARRIER
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
            Me.components = New System.ComponentModel.Container()
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
            Me.CMSMainInformation = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.CMS_MI_TSMI_COPY = New System.Windows.Forms.ToolStripMenuItem()
            Me.DGV_MAIN = New System.Windows.Forms.DataGridView()
            Me.DGV_BARRIER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RUNS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SPEED_MIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SPEED_AVG = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SPEED_MAX = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_FINISHPOSITION_MIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_FINISHPOSITION_AVG = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_FINISHPOSITION_MAX = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_DISTANCEBEHIND_MIN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_DISTANCEBEHIND_AVG = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_DISTANCEBEHIND_MAX = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_WINS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_PLACES = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_RANK = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.CMSMainInformation.SuspendLayout()
            CType(Me.DGV_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'CMSMainInformation
            '
            Me.CMSMainInformation.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMSMainInformation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CMS_MI_TSMI_COPY})
            Me.CMSMainInformation.Name = "CMSMainInformation"
            Me.CMSMainInformation.Size = New System.Drawing.Size(102, 26)
            '
            'CMS_MI_TSMI_COPY
            '
            Me.CMS_MI_TSMI_COPY.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.CMS_MI_TSMI_COPY.Name = "CMS_MI_TSMI_COPY"
            Me.CMS_MI_TSMI_COPY.Size = New System.Drawing.Size(101, 22)
            Me.CMS_MI_TSMI_COPY.Text = "&Copy"
            '
            'DGV_MAIN
            '
            Me.DGV_MAIN.AllowUserToAddRows = False
            Me.DGV_MAIN.AllowUserToDeleteRows = False
            Me.DGV_MAIN.AllowUserToOrderColumns = True
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV_MAIN.BackgroundColor = System.Drawing.SystemColors.Window
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
            Me.DGV_MAIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_BARRIER, Me.DGV_RUNS, Me.DGV_SPEED_MIN, Me.DGV_SPEED_AVG, Me.DGV_SPEED_MAX, Me.DGV_FINISHPOSITION_MIN, Me.DGV_FINISHPOSITION_AVG, Me.DGV_FINISHPOSITION_MAX, Me.DGV_DISTANCEBEHIND_MIN, Me.DGV_DISTANCEBEHIND_AVG, Me.DGV_DISTANCEBEHIND_MAX, Me.DGV_WINS, Me.DGV_PLACES, Me.DGV_RANK})
            Me.DGV_MAIN.ContextMenuStrip = Me.CMSMainInformation
            Me.DGV_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV_MAIN.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV_MAIN.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV_MAIN.Location = New System.Drawing.Point(0, 0)
            Me.DGV_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV_MAIN.Name = "DGV_MAIN"
            Me.DGV_MAIN.ReadOnly = True
            Me.DGV_MAIN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MAIN.RowHeadersDefaultCellStyle = DataGridViewCellStyle17
            DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN.RowsDefaultCellStyle = DataGridViewCellStyle18
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN.RowTemplate.ReadOnly = True
            Me.DGV_MAIN.Size = New System.Drawing.Size(742, 312)
            Me.DGV_MAIN.TabIndex = 9
            '
            'DGV_BARRIER
            '
            Me.DGV_BARRIER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.Format = "N0"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.DGV_BARRIER.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_BARRIER.HeaderText = "B"
            Me.DGV_BARRIER.Name = "DGV_BARRIER"
            Me.DGV_BARRIER.ReadOnly = True
            Me.DGV_BARRIER.ToolTipText = "BARRIER"
            Me.DGV_BARRIER.Width = 38
            '
            'DGV_RUNS
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.Format = "N0"
            DataGridViewCellStyle4.NullValue = "0"
            Me.DGV_RUNS.DefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_RUNS.DividerWidth = 1
            Me.DGV_RUNS.HeaderText = "RUNS"
            Me.DGV_RUNS.Name = "DGV_RUNS"
            Me.DGV_RUNS.ReadOnly = True
            Me.DGV_RUNS.ToolTipText = "RUNS"
            Me.DGV_RUNS.Width = 35
            '
            'DGV_SPEED_MIN
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.Format = "N2"
            Me.DGV_SPEED_MIN.DefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_SPEED_MIN.HeaderText = "S-MIN"
            Me.DGV_SPEED_MIN.Name = "DGV_SPEED_MIN"
            Me.DGV_SPEED_MIN.ReadOnly = True
            Me.DGV_SPEED_MIN.ToolTipText = "SPEED MINIMUM"
            Me.DGV_SPEED_MIN.Width = 45
            '
            'DGV_SPEED_AVG
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.Format = "N2"
            DataGridViewCellStyle6.NullValue = "0.00"
            Me.DGV_SPEED_AVG.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_SPEED_AVG.HeaderText = "S-AVG"
            Me.DGV_SPEED_AVG.Name = "DGV_SPEED_AVG"
            Me.DGV_SPEED_AVG.ReadOnly = True
            Me.DGV_SPEED_AVG.ToolTipText = "SPEED AVERAGE"
            Me.DGV_SPEED_AVG.Width = 45
            '
            'DGV_SPEED_MAX
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.Format = "N2"
            Me.DGV_SPEED_MAX.DefaultCellStyle = DataGridViewCellStyle7
            Me.DGV_SPEED_MAX.DividerWidth = 1
            Me.DGV_SPEED_MAX.HeaderText = "S-MAX"
            Me.DGV_SPEED_MAX.Name = "DGV_SPEED_MAX"
            Me.DGV_SPEED_MAX.ReadOnly = True
            Me.DGV_SPEED_MAX.ToolTipText = "SPEED MAXIMUM"
            Me.DGV_SPEED_MAX.Width = 45
            '
            'DGV_FINISHPOSITION_MIN
            '
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.Format = "N2"
            Me.DGV_FINISHPOSITION_MIN.DefaultCellStyle = DataGridViewCellStyle8
            Me.DGV_FINISHPOSITION_MIN.HeaderText = "FP-MIN"
            Me.DGV_FINISHPOSITION_MIN.Name = "DGV_FINISHPOSITION_MIN"
            Me.DGV_FINISHPOSITION_MIN.ReadOnly = True
            Me.DGV_FINISHPOSITION_MIN.ToolTipText = "FINISH POSITION MINIMUM"
            Me.DGV_FINISHPOSITION_MIN.Width = 45
            '
            'DGV_FINISHPOSITION_AVG
            '
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.Format = "N2"
            Me.DGV_FINISHPOSITION_AVG.DefaultCellStyle = DataGridViewCellStyle9
            Me.DGV_FINISHPOSITION_AVG.HeaderText = "FP-AVG"
            Me.DGV_FINISHPOSITION_AVG.Name = "DGV_FINISHPOSITION_AVG"
            Me.DGV_FINISHPOSITION_AVG.ReadOnly = True
            Me.DGV_FINISHPOSITION_AVG.ToolTipText = "FINISH POSITION AVERAGE"
            Me.DGV_FINISHPOSITION_AVG.Width = 45
            '
            'DGV_FINISHPOSITION_MAX
            '
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.Format = "N2"
            Me.DGV_FINISHPOSITION_MAX.DefaultCellStyle = DataGridViewCellStyle10
            Me.DGV_FINISHPOSITION_MAX.DividerWidth = 1
            Me.DGV_FINISHPOSITION_MAX.HeaderText = "FP-MAX"
            Me.DGV_FINISHPOSITION_MAX.Name = "DGV_FINISHPOSITION_MAX"
            Me.DGV_FINISHPOSITION_MAX.ReadOnly = True
            Me.DGV_FINISHPOSITION_MAX.ToolTipText = "FINISH POSITION MAXIMUM"
            Me.DGV_FINISHPOSITION_MAX.Width = 45
            '
            'DGV_DISTANCEBEHIND_MIN
            '
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.Format = "N2"
            Me.DGV_DISTANCEBEHIND_MIN.DefaultCellStyle = DataGridViewCellStyle11
            Me.DGV_DISTANCEBEHIND_MIN.HeaderText = "DB-MIN"
            Me.DGV_DISTANCEBEHIND_MIN.Name = "DGV_DISTANCEBEHIND_MIN"
            Me.DGV_DISTANCEBEHIND_MIN.ReadOnly = True
            Me.DGV_DISTANCEBEHIND_MIN.ToolTipText = "DISTANCE BEHIND MINIMUM"
            Me.DGV_DISTANCEBEHIND_MIN.Width = 45
            '
            'DGV_DISTANCEBEHIND_AVG
            '
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.Format = "N2"
            Me.DGV_DISTANCEBEHIND_AVG.DefaultCellStyle = DataGridViewCellStyle12
            Me.DGV_DISTANCEBEHIND_AVG.HeaderText = "DB-AVG"
            Me.DGV_DISTANCEBEHIND_AVG.Name = "DGV_DISTANCEBEHIND_AVG"
            Me.DGV_DISTANCEBEHIND_AVG.ReadOnly = True
            Me.DGV_DISTANCEBEHIND_AVG.ToolTipText = "DISTANCE BEHIND AVERAGE "
            Me.DGV_DISTANCEBEHIND_AVG.Width = 45
            '
            'DGV_DISTANCEBEHIND_MAX
            '
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.Format = "N2"
            Me.DGV_DISTANCEBEHIND_MAX.DefaultCellStyle = DataGridViewCellStyle13
            Me.DGV_DISTANCEBEHIND_MAX.DividerWidth = 1
            Me.DGV_DISTANCEBEHIND_MAX.HeaderText = "DB-MAX"
            Me.DGV_DISTANCEBEHIND_MAX.Name = "DGV_DISTANCEBEHIND_MAX"
            Me.DGV_DISTANCEBEHIND_MAX.ReadOnly = True
            Me.DGV_DISTANCEBEHIND_MAX.ToolTipText = "DISTANCE BEHIND MAX"
            Me.DGV_DISTANCEBEHIND_MAX.Width = 45
            '
            'DGV_WINS
            '
            Me.DGV_WINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.Format = "N0"
            DataGridViewCellStyle14.NullValue = "0"
            Me.DGV_WINS.DefaultCellStyle = DataGridViewCellStyle14
            Me.DGV_WINS.HeaderText = "WIN %"
            Me.DGV_WINS.Name = "DGV_WINS"
            Me.DGV_WINS.ReadOnly = True
            Me.DGV_WINS.ToolTipText = "WIN %"
            Me.DGV_WINS.Width = 62
            '
            'DGV_PLACES
            '
            Me.DGV_PLACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.Format = "N0"
            DataGridViewCellStyle15.NullValue = "0"
            Me.DGV_PLACES.DefaultCellStyle = DataGridViewCellStyle15
            Me.DGV_PLACES.DividerWidth = 1
            Me.DGV_PLACES.HeaderText = "PLC %"
            Me.DGV_PLACES.Name = "DGV_PLACES"
            Me.DGV_PLACES.ReadOnly = True
            Me.DGV_PLACES.ToolTipText = "PLACE %"
            Me.DGV_PLACES.Width = 60
            '
            'DGV_RANK
            '
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.Format = "N2"
            DataGridViewCellStyle16.NullValue = "0"
            Me.DGV_RANK.DefaultCellStyle = DataGridViewCellStyle16
            Me.DGV_RANK.HeaderText = "RANK"
            Me.DGV_RANK.Name = "DGV_RANK"
            Me.DGV_RANK.ReadOnly = True
            '
            'UC_BARRIER
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.DGV_MAIN)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_BARRIER"
            Me.Size = New System.Drawing.Size(742, 312)
            Me.CMSMainInformation.ResumeLayout(False)
            CType(Me.DGV_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents CMSMainInformation As System.Windows.Forms.ContextMenuStrip
        Private WithEvents CMS_MI_TSMI_COPY As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents DGV_MAIN As System.Windows.Forms.DataGridView
        Friend WithEvents DGV_BARRIER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_RUNS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SPEED_MIN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SPEED_AVG As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SPEED_MAX As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_FINISHPOSITION_MIN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_FINISHPOSITION_AVG As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_FINISHPOSITION_MAX As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_DISTANCEBEHIND_MIN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_DISTANCEBEHIND_AVG As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_DISTANCEBEHIND_MAX As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_WINS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLACES As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_RANK As System.Windows.Forms.DataGridViewTextBoxColumn

    End Class
End Namespace