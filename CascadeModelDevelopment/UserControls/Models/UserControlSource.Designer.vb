Namespace UserControls.Models
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class UserControlSource
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
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
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            components = New ComponentModel.Container()
            GroupBox_ErrorList = New GroupBox()
            RichTextBoxLineNumbers = New RichTextBox()
            RichTextBoxSource = New RichTextBox()
            ContextMenuStripRichTextBoxSourceCode = New ContextMenuStrip(components)
            CopyToolStripMenuItem = New ToolStripMenuItem()
            CutToolStripMenuItem = New ToolStripMenuItem()
            ToolStripMenuItem1 = New ToolStripSeparator()
            PasteToolStripMenuItem = New ToolStripMenuItem()
            RichTextBoxErrorList = New RichTextBox()
            GroupBox_ErrorList.SuspendLayout()
            ContextMenuStripRichTextBoxSourceCode.SuspendLayout()
            SuspendLayout()
            ' 
            ' GroupBox_ErrorList
            ' 
            GroupBox_ErrorList.AccessibleRole = AccessibleRole.Grouping
            GroupBox_ErrorList.Controls.Add(RichTextBoxErrorList)
            GroupBox_ErrorList.Dock = DockStyle.Bottom
            GroupBox_ErrorList.Location = New Point(0, 812)
            GroupBox_ErrorList.Margin = New Padding(0)
            GroupBox_ErrorList.Name = "GroupBox_ErrorList"
            GroupBox_ErrorList.Padding = New Padding(0)
            GroupBox_ErrorList.Size = New Size(2394, 250)
            GroupBox_ErrorList.TabIndex = 3
            GroupBox_ErrorList.TabStop = False
            GroupBox_ErrorList.Text = "Error List"
            ' 
            ' RichTextBoxLineNumbers
            ' 
            RichTextBoxLineNumbers.BorderStyle = BorderStyle.None
            RichTextBoxLineNumbers.Dock = DockStyle.Left
            RichTextBoxLineNumbers.Location = New Point(0, 0)
            RichTextBoxLineNumbers.Margin = New Padding(0)
            RichTextBoxLineNumbers.Name = "RichTextBoxLineNumbers"
            RichTextBoxLineNumbers.ScrollBars = RichTextBoxScrollBars.None
            RichTextBoxLineNumbers.Size = New Size(75, 812)
            RichTextBoxLineNumbers.TabIndex = 0
            RichTextBoxLineNumbers.TabStop = False
            RichTextBoxLineNumbers.Text = ""
            ' 
            ' RichTextBoxSource
            ' 
            RichTextBoxSource.BorderStyle = BorderStyle.None
            RichTextBoxSource.ContextMenuStrip = ContextMenuStripRichTextBoxSourceCode
            RichTextBoxSource.Dock = DockStyle.Fill
            RichTextBoxSource.Location = New Point(75, 0)
            RichTextBoxSource.Margin = New Padding(0)
            RichTextBoxSource.Name = "RichTextBoxSource"
            RichTextBoxSource.Size = New Size(2319, 812)
            RichTextBoxSource.TabIndex = 1
            RichTextBoxSource.Text = ""
            ' 
            ' ContextMenuStripRichTextBoxSourceCode
            ' 
            ContextMenuStripRichTextBoxSourceCode.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            ContextMenuStripRichTextBoxSourceCode.ImageScalingSize = New Size(40, 40)
            ContextMenuStripRichTextBoxSourceCode.Items.AddRange(New ToolStripItem() {CopyToolStripMenuItem, CutToolStripMenuItem, ToolStripMenuItem1, PasteToolStripMenuItem})
            ContextMenuStripRichTextBoxSourceCode.Name = "ContextMenuStripRichTextBoxSourceCode"
            ContextMenuStripRichTextBoxSourceCode.RenderMode = ToolStripRenderMode.Professional
            ContextMenuStripRichTextBoxSourceCode.Size = New Size(200, 190)
            ' 
            ' CopyToolStripMenuItem
            ' 
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
            CopyToolStripMenuItem.Size = New Size(199, 60)
            CopyToolStripMenuItem.Text = "Copy"
            ' 
            ' CutToolStripMenuItem
            ' 
            CutToolStripMenuItem.Name = "CutToolStripMenuItem"
            CutToolStripMenuItem.Size = New Size(199, 60)
            CutToolStripMenuItem.Text = "Cut"
            ' 
            ' ToolStripMenuItem1
            ' 
            ToolStripMenuItem1.Name = "ToolStripMenuItem1"
            ToolStripMenuItem1.Size = New Size(196, 6)
            ' 
            ' PasteToolStripMenuItem
            ' 
            PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
            PasteToolStripMenuItem.Size = New Size(199, 60)
            PasteToolStripMenuItem.Text = "Paste"
            ' 
            ' RichTextBoxErrorList
            ' 
            RichTextBoxErrorList.BorderStyle = BorderStyle.None
            RichTextBoxErrorList.Dock = DockStyle.Fill
            RichTextBoxErrorList.Location = New Point(0, 54)
            RichTextBoxErrorList.Name = "RichTextBoxErrorList"
            RichTextBoxErrorList.Size = New Size(2394, 196)
            RichTextBoxErrorList.TabIndex = 0
            RichTextBoxErrorList.Text = ""
            ' 
            ' UserControlSource
            ' 
            AutoScaleDimensions = New SizeF(22F, 54F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = SystemColors.Window
            Controls.Add(RichTextBoxSource)
            Controls.Add(RichTextBoxLineNumbers)
            Controls.Add(GroupBox_ErrorList)
            DoubleBuffered = True
            Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            ForeColor = SystemColors.WindowText
            Margin = New Padding(0)
            Name = "UserControlSource"
            Size = New Size(2394, 1062)
            GroupBox_ErrorList.ResumeLayout(False)
            ContextMenuStripRichTextBoxSourceCode.ResumeLayout(False)
            ResumeLayout(False)
        End Sub

        Private WithEvents GroupBox_ErrorList As GroupBox
        Friend WithEvents RichTextBoxLineNumbers As RichTextBox
        Friend WithEvents RichTextBoxSource As RichTextBox
        Private WithEvents ContextMenuStripRichTextBoxSourceCode As ContextMenuStrip
        Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
        Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
        Friend WithEvents RichTextBoxErrorList As RichTextBox
    End Class
End Namespace