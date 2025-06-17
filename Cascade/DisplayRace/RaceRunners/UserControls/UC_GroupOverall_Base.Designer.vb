Namespace DisplayRace.RaceRunners.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_GroupOverall_Base
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
            Me.DGV_MAIN_INFORMATION = New System.Windows.Forms.DataGridView()
            Me.CMSMainInformation = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.TSMI_COPY = New System.Windows.Forms.ToolStripMenuItem()
            Me.DGV_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LASTRAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LASTSPEED = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LASTDISTANCEBEHIND = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LAST_PREVIOUS_RAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LAST_PREVIOUS_SPEED = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_DSLR = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_DISTANCETORUN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_NAME = New System.Windows.Forms.DataGridViewLinkColumn()
            CType(Me.DGV_MAIN_INFORMATION, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.CMSMainInformation.SuspendLayout()
            Me.SuspendLayout()
            '
            'DGV_MAIN_INFORMATION
            '
            Me.DGV_MAIN_INFORMATION.AllowUserToAddRows = False
            Me.DGV_MAIN_INFORMATION.AllowUserToDeleteRows = False
            Me.DGV_MAIN_INFORMATION.AllowUserToOrderColumns = True
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN_INFORMATION.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV_MAIN_INFORMATION.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DGV_MAIN_INFORMATION.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            Me.DGV_MAIN_INFORMATION.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MAIN_INFORMATION.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV_MAIN_INFORMATION.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV_MAIN_INFORMATION.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_NUMBER, Me.DGV_LASTRAN, Me.DGV_LASTSPEED, Me.DGV_LASTDISTANCEBEHIND, Me.DGV_LAST_PREVIOUS_RAN, Me.DGV_LAST_PREVIOUS_SPEED, Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND, Me.DGV_DSLR, Me.DGV_DISTANCETORUN, Me.DGV_NAME})
            Me.DGV_MAIN_INFORMATION.ContextMenuStrip = Me.CMSMainInformation
            Me.DGV_MAIN_INFORMATION.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV_MAIN_INFORMATION.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV_MAIN_INFORMATION.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV_MAIN_INFORMATION.Location = New System.Drawing.Point(0, 0)
            Me.DGV_MAIN_INFORMATION.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV_MAIN_INFORMATION.Name = "DGV_MAIN_INFORMATION"
            Me.DGV_MAIN_INFORMATION.ReadOnly = True
            Me.DGV_MAIN_INFORMATION.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MAIN_INFORMATION.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
            DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN_INFORMATION.RowsDefaultCellStyle = DataGridViewCellStyle14
            Me.DGV_MAIN_INFORMATION.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV_MAIN_INFORMATION.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_MAIN_INFORMATION.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV_MAIN_INFORMATION.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
            Me.DGV_MAIN_INFORMATION.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN_INFORMATION.RowTemplate.ReadOnly = True
            Me.DGV_MAIN_INFORMATION.Size = New System.Drawing.Size(622, 291)
            Me.DGV_MAIN_INFORMATION.TabIndex = 9
            '
            'CMSMainInformation
            '
            Me.CMSMainInformation.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMSMainInformation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_COPY})
            Me.CMSMainInformation.Name = "CMSMainInformation"
            Me.CMSMainInformation.Size = New System.Drawing.Size(153, 48)
            '
            'TSMI_COPY
            '
            Me.TSMI_COPY.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_COPY.Name = "TSMI_COPY"
            Me.TSMI_COPY.Size = New System.Drawing.Size(152, 22)
            Me.TSMI_COPY.Text = "&Copy"
            '
            'DGV_NUMBER
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.Format = "N0"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.DGV_NUMBER.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_NUMBER.DividerWidth = 2
            Me.DGV_NUMBER.FillWeight = 75.0!
            Me.DGV_NUMBER.HeaderText = "#"
            Me.DGV_NUMBER.Name = "DGV_NUMBER"
            Me.DGV_NUMBER.ReadOnly = True
            Me.DGV_NUMBER.ToolTipText = "NUMBER"
            Me.DGV_NUMBER.Width = 20
            '
            'DGV_LASTRAN
            '
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.Format = "N0"
            Me.DGV_LASTRAN.DefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_LASTRAN.HeaderText = "LR"
            Me.DGV_LASTRAN.Name = "DGV_LASTRAN"
            Me.DGV_LASTRAN.ReadOnly = True
            Me.DGV_LASTRAN.ToolTipText = "LAST RAN"
            Me.DGV_LASTRAN.Width = 20
            '
            'DGV_LASTSPEED
            '
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.Format = "N2"
            Me.DGV_LASTSPEED.DefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_LASTSPEED.HeaderText = "LS"
            Me.DGV_LASTSPEED.Name = "DGV_LASTSPEED"
            Me.DGV_LASTSPEED.ReadOnly = True
            Me.DGV_LASTSPEED.ToolTipText = "LAST SPEED"
            Me.DGV_LASTSPEED.Width = 50
            '
            'DGV_LASTDISTANCEBEHIND
            '
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.Format = "N2"
            Me.DGV_LASTDISTANCEBEHIND.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_LASTDISTANCEBEHIND.DividerWidth = 2
            Me.DGV_LASTDISTANCEBEHIND.HeaderText = "LDB"
            Me.DGV_LASTDISTANCEBEHIND.Name = "DGV_LASTDISTANCEBEHIND"
            Me.DGV_LASTDISTANCEBEHIND.ReadOnly = True
            Me.DGV_LASTDISTANCEBEHIND.ToolTipText = "LAST DISTANCE BEHIND"
            Me.DGV_LASTDISTANCEBEHIND.Width = 50
            '
            'DGV_LAST_PREVIOUS_RAN
            '
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.Format = "N0"
            Me.DGV_LAST_PREVIOUS_RAN.DefaultCellStyle = DataGridViewCellStyle7
            Me.DGV_LAST_PREVIOUS_RAN.HeaderText = "LPR"
            Me.DGV_LAST_PREVIOUS_RAN.Name = "DGV_LAST_PREVIOUS_RAN"
            Me.DGV_LAST_PREVIOUS_RAN.ReadOnly = True
            Me.DGV_LAST_PREVIOUS_RAN.ToolTipText = "LAST PREVIOUS RAN"
            Me.DGV_LAST_PREVIOUS_RAN.Width = 25
            '
            'DGV_LAST_PREVIOUS_SPEED
            '
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.Format = "N2"
            Me.DGV_LAST_PREVIOUS_SPEED.DefaultCellStyle = DataGridViewCellStyle8
            Me.DGV_LAST_PREVIOUS_SPEED.HeaderText = "LPS"
            Me.DGV_LAST_PREVIOUS_SPEED.Name = "DGV_LAST_PREVIOUS_SPEED"
            Me.DGV_LAST_PREVIOUS_SPEED.ReadOnly = True
            Me.DGV_LAST_PREVIOUS_SPEED.ToolTipText = "LAST PREVIOUS SPEED"
            Me.DGV_LAST_PREVIOUS_SPEED.Width = 50
            '
            'DGV_LAST_PREVIOUS_DISTANCEBEHIND
            '
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.Format = "N2"
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.DefaultCellStyle = DataGridViewCellStyle9
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.DividerWidth = 2
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.HeaderText = "LPDB"
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.Name = "DGV_LAST_PREVIOUS_DISTANCEBEHIND"
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.ReadOnly = True
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.ToolTipText = "LAST PREVIOUS DISTANCE BEHIND"
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.Width = 50
            '
            'DGV_DSLR
            '
            Me.DGV_DSLR.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.Format = "N0"
            Me.DGV_DSLR.DefaultCellStyle = DataGridViewCellStyle10
            Me.DGV_DSLR.HeaderText = "DSLR"
            Me.DGV_DSLR.Name = "DGV_DSLR"
            Me.DGV_DSLR.ReadOnly = True
            Me.DGV_DSLR.ToolTipText = "DAYS SINCE LAST RAN"
            Me.DGV_DSLR.Width = 55
            '
            'DGV_DISTANCETORUN
            '
            Me.DGV_DISTANCETORUN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle11.Format = "N2"
            DataGridViewCellStyle11.NullValue = "999"
            Me.DGV_DISTANCETORUN.DefaultCellStyle = DataGridViewCellStyle11
            Me.DGV_DISTANCETORUN.DividerWidth = 2
            Me.DGV_DISTANCETORUN.HeaderText = "DTR"
            Me.DGV_DISTANCETORUN.Name = "DGV_DISTANCETORUN"
            Me.DGV_DISTANCETORUN.ReadOnly = True
            Me.DGV_DISTANCETORUN.ToolTipText = "DISTANCE TO RUN"
            Me.DGV_DISTANCETORUN.Width = 52
            '
            'DGV_NAME
            '
            Me.DGV_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_NAME.DefaultCellStyle = DataGridViewCellStyle12
            Me.DGV_NAME.HeaderText = "NAME"
            Me.DGV_NAME.Name = "DGV_NAME"
            Me.DGV_NAME.ReadOnly = True
            Me.DGV_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DGV_NAME.ToolTipText = "NAME OF RUNNER"
            '
            'UC_GroupOverall_Base
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.Controls.Add(Me.DGV_MAIN_INFORMATION)
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_GroupOverall_Base"
            Me.Size = New System.Drawing.Size(622, 291)
            CType(Me.DGV_MAIN_INFORMATION, System.ComponentModel.ISupportInitialize).EndInit()
            Me.CMSMainInformation.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents DGV_MAIN_INFORMATION As System.Windows.Forms.DataGridView
        Friend WithEvents DGV_NUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LASTRAN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LASTSPEED As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LASTDISTANCEBEHIND As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LAST_PREVIOUS_RAN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LAST_PREVIOUS_SPEED As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LAST_PREVIOUS_DISTANCEBEHIND As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_DSLR As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_DISTANCETORUN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_NAME As System.Windows.Forms.DataGridViewLinkColumn
        Private WithEvents CMSMainInformation As System.Windows.Forms.ContextMenuStrip
        Private WithEvents TSMI_COPY As System.Windows.Forms.ToolStripMenuItem

    End Class
End Namespace