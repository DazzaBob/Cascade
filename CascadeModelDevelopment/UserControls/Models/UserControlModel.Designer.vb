Namespace UserControls.Models
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class UserControlModel
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
            TabControlMain = New TabControl()
            TabPage_Source = New TabPage()
            TabPage_Results = New TabPage()
            TabPage_Properties = New TabPage()
            TabControlMain.SuspendLayout()
            SuspendLayout()
            ' 
            ' TabControlMain
            ' 
            TabControlMain.Alignment = TabAlignment.Bottom
            TabControlMain.Controls.Add(TabPage_Properties)
            TabControlMain.Controls.Add(TabPage_Source)
            TabControlMain.Controls.Add(TabPage_Results)
            TabControlMain.Dock = DockStyle.Fill
            TabControlMain.Location = New Point(0, 0)
            TabControlMain.Margin = New Padding(0)
            TabControlMain.Name = "TabControlMain"
            TabControlMain.Padding = New Point(0, 0)
            TabControlMain.SelectedIndex = 0
            TabControlMain.ShowToolTips = True
            TabControlMain.Size = New Size(2080, 933)
            TabControlMain.TabIndex = 0
            ' 
            ' TabPage_Source
            ' 
            TabPage_Source.Location = New Point(10, 10)
            TabPage_Source.Margin = New Padding(0)
            TabPage_Source.Name = "TabPage_Source"
            TabPage_Source.Size = New Size(2060, 848)
            TabPage_Source.TabIndex = 0
            TabPage_Source.Text = "Source"
            TabPage_Source.ToolTipText = "The source code for the model."
            TabPage_Source.UseVisualStyleBackColor = True
            ' 
            ' TabPage_Results
            ' 
            TabPage_Results.Location = New Point(10, 10)
            TabPage_Results.Margin = New Padding(0)
            TabPage_Results.Name = "TabPage_Results"
            TabPage_Results.Size = New Size(2060, 848)
            TabPage_Results.TabIndex = 1
            TabPage_Results.Text = "Results"
            TabPage_Results.UseVisualStyleBackColor = True
            ' 
            ' TabPage_Properties
            ' 
            TabPage_Properties.Location = New Point(10, 10)
            TabPage_Properties.Margin = New Padding(0)
            TabPage_Properties.Name = "TabPage_Properties"
            TabPage_Properties.Size = New Size(2060, 848)
            TabPage_Properties.TabIndex = 2
            TabPage_Properties.Text = "Properties"
            TabPage_Properties.UseVisualStyleBackColor = True
            ' 
            ' UserControlModel
            ' 
            AutoScaleDimensions = New SizeF(22F, 54F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = SystemColors.Window
            Controls.Add(TabControlMain)
            DoubleBuffered = True
            Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            ForeColor = SystemColors.WindowText
            Margin = New Padding(0)
            Name = "UserControlModel"
            Size = New Size(2080, 933)
            TabControlMain.ResumeLayout(False)
            ResumeLayout(False)
        End Sub

        Friend WithEvents TabControlMain As TabControl
        Friend WithEvents TabPage_Source As TabPage

        Friend WithEvents TabPage_Results As TabPage
        Friend WithEvents TabPage_Properties As TabPage
    End Class
End Namespace