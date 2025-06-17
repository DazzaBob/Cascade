<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRunnerRaceList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        components = New ComponentModel.Container()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        DGV = New DataGridView()
        DGV_RACENAME = New DataGridViewLinkColumn()
        DGV_DATE = New DataGridViewTextBoxColumn()
        DGV_CLASS = New DataGridViewTextBoxColumn()
        DGV_BARRIER = New DataGridViewTextBoxColumn()
        DGV_VENUE = New DataGridViewTextBoxColumn()
        DGV_LENGTH = New DataGridViewTextBoxColumn()
        DGV_EXCEPTIONS = New DataGridViewTextBoxColumn()
        DGV_FINISHPOSITION = New DataGridViewTextBoxColumn()
        DGV_DISTANCE_BEHIND = New DataGridViewTextBoxColumn()
        CMSRightClick = New ContextMenuStrip(components)
        CopyToolStripMenuItem = New ToolStripMenuItem()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        CMSRightClick.SuspendLayout()
        SuspendLayout()
        ' 
        ' DGV
        ' 
        DGV.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = Drawing.SystemColors.HighlightText
        DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        DGV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
        DGV.BackgroundColor = Drawing.SystemColors.Window
        DGV.BorderStyle = BorderStyle.None
        DGV.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        DGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {DGV_RACENAME, DGV_DATE, DGV_CLASS, DGV_BARRIER, DGV_VENUE, DGV_LENGTH, DGV_EXCEPTIONS, DGV_FINISHPOSITION, DGV_DISTANCE_BEHIND})
        DGV.ContextMenuStrip = CMSRightClick
        DataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle11.ForeColor = Drawing.SystemColors.WindowText
        DataGridViewCellStyle11.SelectionBackColor = Drawing.SystemColors.Highlight
        DataGridViewCellStyle11.SelectionForeColor = Drawing.SystemColors.HighlightText
        DataGridViewCellStyle11.WrapMode = DataGridViewTriState.False
        DGV.DefaultCellStyle = DataGridViewCellStyle11
        DGV.Dock = DockStyle.Fill
        DGV.EditMode = DataGridViewEditMode.EditProgrammatically
        DGV.GridColor = Drawing.SystemColors.ControlDarkDark
        DGV.Location = New Drawing.Point(3, 3)
        DGV.Name = "DGV"
        DGV.ReadOnly = True
        DGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
        DataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle12.ForeColor = Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.SelectionBackColor = Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = DataGridViewTriState.True
        DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        DGV.RowHeadersWidth = 102
        DataGridViewCellStyle13.BackColor = Drawing.SystemColors.Window
        DataGridViewCellStyle13.Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle13.ForeColor = Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = Drawing.SystemColors.HighlightText
        DGV.RowsDefaultCellStyle = DataGridViewCellStyle13
        DGV.RowTemplate.DefaultCellStyle.BackColor = Drawing.SystemColors.Window
        DGV.RowTemplate.DefaultCellStyle.Font = New Drawing.Font("Calibri", 8.25F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        DGV.RowTemplate.DefaultCellStyle.ForeColor = Drawing.SystemColors.WindowText
        DGV.RowTemplate.DefaultCellStyle.SelectionBackColor = Drawing.SystemColors.Highlight
        DGV.RowTemplate.DefaultCellStyle.SelectionForeColor = Drawing.SystemColors.HighlightText
        DGV.RowTemplate.Height = 24
        DGV.Size = New Drawing.Size(1717, 551)
        DGV.TabIndex = 1022
        ' 
        ' DGV_RACENAME
        ' 
        DGV_RACENAME.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DGV_RACENAME.HeaderText = "NAME"
        DGV_RACENAME.MinimumWidth = 12
        DGV_RACENAME.Name = "DGV_RACENAME"
        DGV_RACENAME.ReadOnly = True
        DGV_RACENAME.Resizable = DataGridViewTriState.True
        DGV_RACENAME.ToolTipText = "RUNNER NAME"
        DGV_RACENAME.Width = 141
        ' 
        ' DGV_DATE
        ' 
        DGV_DATE.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Format = "g"
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.WrapMode = DataGridViewTriState.False
        DGV_DATE.DefaultCellStyle = DataGridViewCellStyle3
        DGV_DATE.HeaderText = "DATE"
        DGV_DATE.MinimumWidth = 12
        DGV_DATE.Name = "DGV_DATE"
        DGV_DATE.ReadOnly = True
        DGV_DATE.ToolTipText = "DATE OF RACE"
        DGV_DATE.Width = 168
        ' 
        ' DGV_CLASS
        ' 
        DGV_CLASS.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = "999"
        DGV_CLASS.DefaultCellStyle = DataGridViewCellStyle4
        DGV_CLASS.HeaderText = "CL"
        DGV_CLASS.MinimumWidth = 12
        DGV_CLASS.Name = "DGV_CLASS"
        DGV_CLASS.ReadOnly = True
        DGV_CLASS.ToolTipText = "CLASS"
        DGV_CLASS.Width = 121
        ' 
        ' DGV_BARRIER
        ' 
        DGV_BARRIER.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Format = "N0"
        DataGridViewCellStyle5.NullValue = "0"
        DGV_BARRIER.DefaultCellStyle = DataGridViewCellStyle5
        DGV_BARRIER.HeaderText = "B"
        DGV_BARRIER.MinimumWidth = 12
        DGV_BARRIER.Name = "DGV_BARRIER"
        DGV_BARRIER.ReadOnly = True
        DGV_BARRIER.ToolTipText = "BARRIER"
        ' 
        ' DGV_VENUE
        ' 
        DGV_VENUE.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.NullValue = "-"
        DGV_VENUE.DefaultCellStyle = DataGridViewCellStyle6
        DGV_VENUE.HeaderText = "VENUE"
        DGV_VENUE.MinimumWidth = 12
        DGV_VENUE.Name = "DGV_VENUE"
        DGV_VENUE.ReadOnly = True
        DGV_VENUE.ToolTipText = "VENUE"
        ' 
        ' DGV_LENGTH
        ' 
        DGV_LENGTH.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "N0"
        DataGridViewCellStyle7.NullValue = "0"
        DGV_LENGTH.DefaultCellStyle = DataGridViewCellStyle7
        DGV_LENGTH.HeaderText = "LEN"
        DGV_LENGTH.MinimumWidth = 12
        DGV_LENGTH.Name = "DGV_LENGTH"
        DGV_LENGTH.ReadOnly = True
        DGV_LENGTH.ToolTipText = "LENGTH"
        DGV_LENGTH.Width = 146
        ' 
        ' DGV_EXCEPTIONS
        ' 
        DGV_EXCEPTIONS.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleCenter
        DGV_EXCEPTIONS.DefaultCellStyle = DataGridViewCellStyle8
        DGV_EXCEPTIONS.HeaderText = "EXCEPTIONS"
        DGV_EXCEPTIONS.MinimumWidth = 12
        DGV_EXCEPTIONS.Name = "DGV_EXCEPTIONS"
        DGV_EXCEPTIONS.ReadOnly = True
        DGV_EXCEPTIONS.ToolTipText = "Any Exceptions"
        DGV_EXCEPTIONS.Width = 301
        ' 
        ' DGV_FINISHPOSITION
        ' 
        DGV_FINISHPOSITION.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Format = "N0"
        DataGridViewCellStyle9.NullValue = "0"
        DGV_FINISHPOSITION.DefaultCellStyle = DataGridViewCellStyle9
        DGV_FINISHPOSITION.HeaderText = "F-P"
        DGV_FINISHPOSITION.MinimumWidth = 12
        DGV_FINISHPOSITION.Name = "DGV_FINISHPOSITION"
        DGV_FINISHPOSITION.ReadOnly = True
        DGV_FINISHPOSITION.ToolTipText = "FINISH POSITION"
        DGV_FINISHPOSITION.Width = 135
        ' 
        ' DGV_DISTANCE_BEHIND
        ' 
        DGV_DISTANCE_BEHIND.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N4"
        DataGridViewCellStyle10.NullValue = "0"
        DGV_DISTANCE_BEHIND.DefaultCellStyle = DataGridViewCellStyle10
        DGV_DISTANCE_BEHIND.HeaderText = "D-B"
        DGV_DISTANCE_BEHIND.MinimumWidth = 12
        DGV_DISTANCE_BEHIND.Name = "DGV_DISTANCE_BEHIND"
        DGV_DISTANCE_BEHIND.ReadOnly = True
        DGV_DISTANCE_BEHIND.ToolTipText = "DISTANCE BEHIND"
        DGV_DISTANCE_BEHIND.Width = 144
        ' 
        ' CMSRightClick
        ' 
        CMSRightClick.Font = New Drawing.Font("Calibri", 9F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        CMSRightClick.ImageScalingSize = New Drawing.Size(40, 40)
        CMSRightClick.Items.AddRange(New ToolStripItem() {CopyToolStripMenuItem})
        CMSRightClick.Name = "CMSRightClick"
        CMSRightClick.Size = New Drawing.Size(157, 48)
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.ImageTransparentColor = Drawing.Color.Magenta
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Drawing.Size(156, 44)
        CopyToolStripMenuItem.Text = "&Copy"
        ' 
        ' FrmRunnerRaceList
        ' 
        AutoScaleDimensions = New Drawing.SizeF(22F, 54F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Drawing.SystemColors.Window
        ClientSize = New Drawing.Size(1723, 557)
        Controls.Add(DGV)
        DoubleBuffered = True
        Font = New Drawing.Font("Segoe UI", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        ForeColor = Drawing.SystemColors.WindowText
        FormBorderStyle = FormBorderStyle.FixedDialog
        Margin = New Padding(10, 12, 10, 12)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmRunnerRaceList"
        Padding = New Padding(3)
        ShowInTaskbar = False
        StartPosition = FormStartPosition.CenterParent
        Text = "Runner Race List"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        CMSRightClick.ResumeLayout(False)
        ResumeLayout(False)
    End Sub
    Private WithEvents DGV As DataGridView
    Friend WithEvents DGV_RACENAME As DataGridViewLinkColumn
    Friend WithEvents DGV_DATE As DataGridViewTextBoxColumn
    Friend WithEvents DGV_CLASS As DataGridViewTextBoxColumn
    Friend WithEvents DGV_BARRIER As DataGridViewTextBoxColumn
    Friend WithEvents DGV_VENUE As DataGridViewTextBoxColumn
    Friend WithEvents DGV_LENGTH As DataGridViewTextBoxColumn
    Friend WithEvents DGV_EXCEPTIONS As DataGridViewTextBoxColumn
    Friend WithEvents DGV_FINISHPOSITION As DataGridViewTextBoxColumn
    Friend WithEvents DGV_DISTANCE_BEHIND As DataGridViewTextBoxColumn
    Private WithEvents CMSRightClick As ContextMenuStrip
    Private WithEvents CopyToolStripMenuItem As ToolStripMenuItem
End Class
