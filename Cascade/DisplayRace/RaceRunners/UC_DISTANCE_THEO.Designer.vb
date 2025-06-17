Namespace DisplayRace.RaceRunners
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_DISTANCE_THEO
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                If MY_RRL IsNot Nothing Then MY_RRL.Dispose() : MY_RRL = Nothing
                If MY_POPUP IsNot Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
                If UC_FAVOURITES IsNot Nothing Then UC_FAVOURITES.Dispose() : UC_FAVOURITES = Nothing
                If UC_90 IsNot Nothing Then UC_90.Dispose() : UC_90 = Nothing
                If UC_180 IsNot Nothing Then UC_180.Dispose() : UC_180 = Nothing
                If UC_270 IsNot Nothing Then UC_270.Dispose() : UC_270 = Nothing
                If UC_365 IsNot Nothing Then UC_365.Dispose() : UC_365 = Nothing
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
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.TC_MAIN = New System.Windows.Forms.TabControl()
            Me.TP_BASE = New System.Windows.Forms.TabPage()
            Me.DGV_MAIN_INFORMATION = New System.Windows.Forms.DataGridView()
            Me.DGV_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LASTRAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LAST_SPEED = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LAST_DISTANCEBEHIND = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LAST_PREVIOUS_RAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LAST_PREVIOUS_SPEED = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_NAME = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.CMSMainInformation = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.CMS_MI_TSMI_COPY = New System.Windows.Forms.ToolStripMenuItem()
            Me.TP_FAVOURITES = New System.Windows.Forms.TabPage()
            Me.TP_90DAYS = New System.Windows.Forms.TabPage()
            Me.TP_180DAYS = New System.Windows.Forms.TabPage()
            Me.TP_270DAYS = New System.Windows.Forms.TabPage()
            Me.TP_365DAYS = New System.Windows.Forms.TabPage()
            Me.TC_MAIN.SuspendLayout()
            Me.TP_BASE.SuspendLayout()
            CType(Me.DGV_MAIN_INFORMATION, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.CMSMainInformation.SuspendLayout()
            Me.SuspendLayout()
            '
            'TC_MAIN
            '
            Me.TC_MAIN.Controls.Add(Me.TP_BASE)
            Me.TC_MAIN.Controls.Add(Me.TP_FAVOURITES)
            Me.TC_MAIN.Controls.Add(Me.TP_90DAYS)
            Me.TC_MAIN.Controls.Add(Me.TP_180DAYS)
            Me.TC_MAIN.Controls.Add(Me.TP_270DAYS)
            Me.TC_MAIN.Controls.Add(Me.TP_365DAYS)
            Me.TC_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_MAIN.Location = New System.Drawing.Point(0, 0)
            Me.TC_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_MAIN.Name = "TC_MAIN"
            Me.TC_MAIN.Padding = New System.Drawing.Point(0, 0)
            Me.TC_MAIN.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.TC_MAIN.RightToLeftLayout = True
            Me.TC_MAIN.SelectedIndex = 0
            Me.TC_MAIN.Size = New System.Drawing.Size(695, 312)
            Me.TC_MAIN.TabIndex = 0
            '
            'TP_BASE
            '
            Me.TP_BASE.Controls.Add(Me.DGV_MAIN_INFORMATION)
            Me.TP_BASE.Location = New System.Drawing.Point(4, 22)
            Me.TP_BASE.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_BASE.Name = "TP_BASE"
            Me.TP_BASE.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_BASE.Size = New System.Drawing.Size(687, 286)
            Me.TP_BASE.TabIndex = 0
            Me.TP_BASE.Text = "BASE"
            Me.TP_BASE.ToolTipText = "Displays entry information for runners in this race."
            Me.TP_BASE.UseVisualStyleBackColor = True
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
            Me.DGV_MAIN_INFORMATION.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_NUMBER, Me.DGV_LASTRAN, Me.DGV_LAST_SPEED, Me.DGV_LAST_DISTANCEBEHIND, Me.DGV_LAST_PREVIOUS_RAN, Me.DGV_LAST_PREVIOUS_SPEED, Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND, Me.DGV_NAME})
            Me.DGV_MAIN_INFORMATION.ContextMenuStrip = Me.CMSMainInformation
            Me.DGV_MAIN_INFORMATION.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV_MAIN_INFORMATION.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV_MAIN_INFORMATION.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV_MAIN_INFORMATION.Location = New System.Drawing.Point(0, 0)
            Me.DGV_MAIN_INFORMATION.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV_MAIN_INFORMATION.Name = "DGV_MAIN_INFORMATION"
            Me.DGV_MAIN_INFORMATION.ReadOnly = True
            Me.DGV_MAIN_INFORMATION.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MAIN_INFORMATION.RowHeadersDefaultCellStyle = DataGridViewCellStyle11
            DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN_INFORMATION.RowsDefaultCellStyle = DataGridViewCellStyle12
            Me.DGV_MAIN_INFORMATION.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV_MAIN_INFORMATION.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_MAIN_INFORMATION.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV_MAIN_INFORMATION.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
            Me.DGV_MAIN_INFORMATION.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN_INFORMATION.RowTemplate.ReadOnly = True
            Me.DGV_MAIN_INFORMATION.Size = New System.Drawing.Size(687, 286)
            Me.DGV_MAIN_INFORMATION.TabIndex = 8
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
            Me.DGV_NUMBER.Width = 25
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
            'DGV_LAST_SPEED
            '
            Me.DGV_LAST_SPEED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.Format = "N2"
            Me.DGV_LAST_SPEED.DefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_LAST_SPEED.HeaderText = "LS"
            Me.DGV_LAST_SPEED.Name = "DGV_LAST_SPEED"
            Me.DGV_LAST_SPEED.ReadOnly = True
            Me.DGV_LAST_SPEED.ToolTipText = "LAST SPEED"
            Me.DGV_LAST_SPEED.Width = 42
            '
            'DGV_LAST_DISTANCEBEHIND
            '
            Me.DGV_LAST_DISTANCEBEHIND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.Format = "N2"
            Me.DGV_LAST_DISTANCEBEHIND.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_LAST_DISTANCEBEHIND.DividerWidth = 2
            Me.DGV_LAST_DISTANCEBEHIND.HeaderText = "LDB"
            Me.DGV_LAST_DISTANCEBEHIND.Name = "DGV_LAST_DISTANCEBEHIND"
            Me.DGV_LAST_DISTANCEBEHIND.ReadOnly = True
            Me.DGV_LAST_DISTANCEBEHIND.ToolTipText = "LAST DISTANCE BEHIND"
            Me.DGV_LAST_DISTANCEBEHIND.Width = 52
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
            Me.DGV_LAST_PREVIOUS_SPEED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.Format = "N2"
            Me.DGV_LAST_PREVIOUS_SPEED.DefaultCellStyle = DataGridViewCellStyle8
            Me.DGV_LAST_PREVIOUS_SPEED.HeaderText = "LPS"
            Me.DGV_LAST_PREVIOUS_SPEED.Name = "DGV_LAST_PREVIOUS_SPEED"
            Me.DGV_LAST_PREVIOUS_SPEED.ReadOnly = True
            Me.DGV_LAST_PREVIOUS_SPEED.Width = 48
            '
            'DGV_LAST_PREVIOUS_DISTANCEBEHIND
            '
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.Format = "N2"
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.DefaultCellStyle = DataGridViewCellStyle9
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.DividerWidth = 2
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.HeaderText = "LPDB"
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.Name = "DGV_LAST_PREVIOUS_DISTANCEBEHIND"
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.ReadOnly = True
            Me.DGV_LAST_PREVIOUS_DISTANCEBEHIND.Width = 58
            '
            'DGV_NAME
            '
            Me.DGV_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_NAME.DefaultCellStyle = DataGridViewCellStyle10
            Me.DGV_NAME.HeaderText = "NAME"
            Me.DGV_NAME.Name = "DGV_NAME"
            Me.DGV_NAME.ReadOnly = True
            Me.DGV_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DGV_NAME.ToolTipText = "NAME OF RUNNER"
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
            'TP_FAVOURITES
            '
            Me.TP_FAVOURITES.Location = New System.Drawing.Point(4, 22)
            Me.TP_FAVOURITES.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_FAVOURITES.Name = "TP_FAVOURITES"
            Me.TP_FAVOURITES.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_FAVOURITES.Size = New System.Drawing.Size(687, 286)
            Me.TP_FAVOURITES.TabIndex = 12
            Me.TP_FAVOURITES.Text = "FAVS"
            Me.TP_FAVOURITES.UseVisualStyleBackColor = True
            '
            'TP_90DAYS
            '
            Me.TP_90DAYS.Location = New System.Drawing.Point(4, 22)
            Me.TP_90DAYS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_90DAYS.Name = "TP_90DAYS"
            Me.TP_90DAYS.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_90DAYS.Size = New System.Drawing.Size(687, 286)
            Me.TP_90DAYS.TabIndex = 3
            Me.TP_90DAYS.Text = "90"
            Me.TP_90DAYS.UseVisualStyleBackColor = True
            '
            'TP_180DAYS
            '
            Me.TP_180DAYS.Location = New System.Drawing.Point(4, 22)
            Me.TP_180DAYS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_180DAYS.Name = "TP_180DAYS"
            Me.TP_180DAYS.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_180DAYS.Size = New System.Drawing.Size(687, 286)
            Me.TP_180DAYS.TabIndex = 6
            Me.TP_180DAYS.Text = "180"
            Me.TP_180DAYS.UseVisualStyleBackColor = True
            '
            'TP_270DAYS
            '
            Me.TP_270DAYS.Location = New System.Drawing.Point(4, 22)
            Me.TP_270DAYS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_270DAYS.Name = "TP_270DAYS"
            Me.TP_270DAYS.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_270DAYS.Size = New System.Drawing.Size(687, 286)
            Me.TP_270DAYS.TabIndex = 8
            Me.TP_270DAYS.Text = "270"
            Me.TP_270DAYS.UseVisualStyleBackColor = True
            '
            'TP_365DAYS
            '
            Me.TP_365DAYS.Location = New System.Drawing.Point(4, 22)
            Me.TP_365DAYS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_365DAYS.Name = "TP_365DAYS"
            Me.TP_365DAYS.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_365DAYS.Size = New System.Drawing.Size(687, 286)
            Me.TP_365DAYS.TabIndex = 11
            Me.TP_365DAYS.Text = "365"
            Me.TP_365DAYS.UseVisualStyleBackColor = True
            '
            'UC_DISTANCE_THEO
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.TC_MAIN)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_DISTANCE_THEO"
            Me.Size = New System.Drawing.Size(695, 312)
            Me.TC_MAIN.ResumeLayout(False)
            Me.TP_BASE.ResumeLayout(False)
            CType(Me.DGV_MAIN_INFORMATION, System.ComponentModel.ISupportInitialize).EndInit()
            Me.CMSMainInformation.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents TC_MAIN As System.Windows.Forms.TabControl
        Private WithEvents TP_BASE As System.Windows.Forms.TabPage
        Private WithEvents DGV_MAIN_INFORMATION As System.Windows.Forms.DataGridView
        Private WithEvents TP_90DAYS As System.Windows.Forms.TabPage
        Private WithEvents TP_180DAYS As System.Windows.Forms.TabPage
        Private WithEvents CMSMainInformation As System.Windows.Forms.ContextMenuStrip
        Private WithEvents CMS_MI_TSMI_COPY As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TP_270DAYS As System.Windows.Forms.TabPage
        Private WithEvents TP_365DAYS As System.Windows.Forms.TabPage
        Private WithEvents TP_FAVOURITES As System.Windows.Forms.TabPage
        Friend WithEvents DGV_NUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LASTRAN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LAST_SPEED As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LAST_DISTANCEBEHIND As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LAST_PREVIOUS_RAN As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LAST_PREVIOUS_SPEED As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LAST_PREVIOUS_DISTANCEBEHIND As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_NAME As System.Windows.Forms.DataGridViewLinkColumn

    End Class
End Namespace