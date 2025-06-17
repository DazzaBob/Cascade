<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        SplitContainerMain = New SplitContainer()
        TreeViewMain = New TreeView()
        CType(SplitContainerMain, ComponentModel.ISupportInitialize).BeginInit()
        SplitContainerMain.Panel1.SuspendLayout()
        SplitContainerMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' SplitContainerMain
        ' 
        SplitContainerMain.Dock = DockStyle.Fill
        SplitContainerMain.Location = New Point(0, 0)
        SplitContainerMain.Margin = New Padding(4)
        SplitContainerMain.Name = "SplitContainerMain"
        ' 
        ' SplitContainerMain.Panel1
        ' 
        SplitContainerMain.Panel1.Controls.Add(TreeViewMain)
        ' 
        ' SplitContainerMain.Panel2
        ' 
        SplitContainerMain.Panel2.Font = New Font("Calibri", 8F, FontStyle.Regular, GraphicsUnit.Point)
        SplitContainerMain.Size = New Size(2765, 939)
        SplitContainerMain.SplitterDistance = 790
        SplitContainerMain.SplitterWidth = 6
        SplitContainerMain.TabIndex = 0
        ' 
        ' TreeViewMain
        ' 
        TreeViewMain.BorderStyle = BorderStyle.FixedSingle
        TreeViewMain.Dock = DockStyle.Fill
        TreeViewMain.Font = New Font("Segoe UI", 9.900001F, FontStyle.Regular, GraphicsUnit.Point)
        TreeViewMain.Location = New Point(0, 0)
        TreeViewMain.Margin = New Padding(4)
        TreeViewMain.Name = "TreeViewMain"
        TreeViewMain.Size = New Size(790, 939)
        TreeViewMain.TabIndex = 0
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(22F, 54F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Window
        ClientSize = New Size(2765, 939)
        Controls.Add(SplitContainerMain)
        DoubleBuffered = True
        Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Margin = New Padding(4)
        Name = "FrmMain"
        Text = "Monitor"
        WindowState = FormWindowState.Maximized
        SplitContainerMain.Panel1.ResumeLayout(False)
        CType(SplitContainerMain, ComponentModel.ISupportInitialize).EndInit()
        SplitContainerMain.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents SplitContainerMain As SplitContainer
    Friend WithEvents TreeViewMain As TreeView
End Class
