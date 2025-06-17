<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSelectRange
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
        TableLayoutPanelMain = New TableLayoutPanel()
        ButtonCancel = New Button()
        ButtonOK = New Button()
        PanelSelections = New Panel()
        DateTimePickerTo = New DateTimePicker()
        DateTimePickerFrom = New DateTimePicker()
        LabelTo = New Label()
        LabelFrom = New Label()
        TableLayoutPanelMain.SuspendLayout()
        PanelSelections.SuspendLayout()
        SuspendLayout()
        ' 
        ' TableLayoutPanelMain
        ' 
        TableLayoutPanelMain.BackColor = Drawing.SystemColors.Window
        TableLayoutPanelMain.ColumnCount = 2
        TableLayoutPanelMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanelMain.ColumnStyles.Add(New ColumnStyle(SizeType.Percent, 50F))
        TableLayoutPanelMain.Controls.Add(ButtonCancel, 0, 1)
        TableLayoutPanelMain.Controls.Add(ButtonOK, 1, 1)
        TableLayoutPanelMain.Controls.Add(PanelSelections, 0, 0)
        TableLayoutPanelMain.Dock = DockStyle.Fill
        TableLayoutPanelMain.Location = New Drawing.Point(0, 0)
        TableLayoutPanelMain.Margin = New Padding(0)
        TableLayoutPanelMain.Name = "TableLayoutPanelMain"
        TableLayoutPanelMain.RowCount = 2
        TableLayoutPanelMain.RowStyles.Add(New RowStyle(SizeType.Percent, 100F))
        TableLayoutPanelMain.RowStyles.Add(New RowStyle(SizeType.Absolute, 99F))
        TableLayoutPanelMain.Size = New Drawing.Size(1076, 356)
        TableLayoutPanelMain.TabIndex = 0
        ' 
        ' ButtonCancel
        ' 
        ButtonCancel.BackColor = Drawing.SystemColors.Control
        ButtonCancel.Dock = DockStyle.Right
        ButtonCancel.ForeColor = Drawing.SystemColors.ControlText
        ButtonCancel.Location = New Drawing.Point(358, 260)
        ButtonCancel.Name = "ButtonCancel"
        ButtonCancel.Size = New Drawing.Size(177, 93)
        ButtonCancel.TabIndex = 1
        ButtonCancel.Text = "&Cancel"
        ButtonCancel.UseVisualStyleBackColor = False
        ' 
        ' ButtonOK
        ' 
        ButtonOK.BackColor = Drawing.SystemColors.Control
        ButtonOK.Dock = DockStyle.Left
        ButtonOK.ForeColor = Drawing.SystemColors.ControlText
        ButtonOK.Location = New Drawing.Point(541, 260)
        ButtonOK.Name = "ButtonOK"
        ButtonOK.Size = New Drawing.Size(179, 93)
        ButtonOK.TabIndex = 2
        ButtonOK.Text = "&OK"
        ButtonOK.UseVisualStyleBackColor = False
        ' 
        ' PanelSelections
        ' 
        TableLayoutPanelMain.SetColumnSpan(PanelSelections, 2)
        PanelSelections.Controls.Add(DateTimePickerTo)
        PanelSelections.Controls.Add(DateTimePickerFrom)
        PanelSelections.Controls.Add(LabelTo)
        PanelSelections.Controls.Add(LabelFrom)
        PanelSelections.Dock = DockStyle.Fill
        PanelSelections.Location = New Drawing.Point(3, 3)
        PanelSelections.Name = "PanelSelections"
        PanelSelections.Size = New Drawing.Size(1070, 251)
        PanelSelections.TabIndex = 3
        ' 
        ' DateTimePickerTo
        ' 
        DateTimePickerTo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DateTimePickerTo.Location = New Drawing.Point(163, 130)
        DateTimePickerTo.Name = "DateTimePickerTo"
        DateTimePickerTo.Size = New Drawing.Size(869, 56)
        DateTimePickerTo.TabIndex = 3
        ' 
        ' DateTimePickerFrom
        ' 
        DateTimePickerFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DateTimePickerFrom.Location = New Drawing.Point(163, 58)
        DateTimePickerFrom.Name = "DateTimePickerFrom"
        DateTimePickerFrom.Size = New Drawing.Size(869, 56)
        DateTimePickerFrom.TabIndex = 2
        ' 
        ' LabelTo
        ' 
        LabelTo.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelTo.AutoSize = True
        LabelTo.Font = New Drawing.Font("Calibri", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        LabelTo.Location = New Drawing.Point(73, 137)
        LabelTo.Name = "LabelTo"
        LabelTo.Size = New Drawing.Size(72, 49)
        LabelTo.TabIndex = 1
        LabelTo.Text = "To:"
        ' 
        ' LabelFrom
        ' 
        LabelFrom.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LabelFrom.AutoSize = True
        LabelFrom.Font = New Drawing.Font("Calibri", 12F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point)
        LabelFrom.Location = New Drawing.Point(16, 58)
        LabelFrom.Name = "LabelFrom"
        LabelFrom.Size = New Drawing.Size(120, 49)
        LabelFrom.TabIndex = 0
        LabelFrom.Text = "From:"
        ' 
        ' FrmSelectRange
        ' 
        AcceptButton = ButtonOK
        AutoScaleDimensions = New Drawing.SizeF(20F, 49F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Drawing.SystemColors.Window
        CancelButton = ButtonCancel
        ClientSize = New Drawing.Size(1076, 356)
        Controls.Add(TableLayoutPanelMain)
        DoubleBuffered = True
        Font = New Drawing.Font("Calibri", 12F, Drawing.FontStyle.Regular, Drawing.GraphicsUnit.Point)
        ForeColor = Drawing.SystemColors.WindowText
        FormBorderStyle = FormBorderStyle.FixedSingle
        Margin = New Padding(4, 3, 4, 3)
        MaximizeBox = False
        MinimizeBox = False
        Name = "FrmSelectRange"
        ShowIcon = False
        ShowInTaskbar = False
        SizeGripStyle = SizeGripStyle.Show
        StartPosition = FormStartPosition.CenterParent
        Text = "Select Range"
        TopMost = True
        TableLayoutPanelMain.ResumeLayout(False)
        PanelSelections.ResumeLayout(False)
        PanelSelections.PerformLayout()
        ResumeLayout(False)
    End Sub

    Private WithEvents TableLayoutPanelMain As TableLayoutPanel
    Private WithEvents ButtonCancel As Button
    Private WithEvents ButtonOK As Button
    Friend WithEvents PanelSelections As Panel
    Private WithEvents LabelTo As Label
    Private WithEvents LabelFrom As Label
    Public WithEvents DateTimePickerTo As DateTimePicker
    Public WithEvents DateTimePickerFrom As DateTimePicker
End Class
