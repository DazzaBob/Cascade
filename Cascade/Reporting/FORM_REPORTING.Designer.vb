Namespace Reporting
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FORM_REPORTING
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                If Connection IsNot Nothing Then Connection.Dispose() : Connection = Nothing
                '
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FORM_REPORTING))
            Me.TC_MAIN = New System.Windows.Forms.TabControl()
            Me.TP_MEETINGS = New System.Windows.Forms.TabPage()
            Me.TP_MODELLEDRACES = New System.Windows.Forms.TabPage()
            Me.TC_MAIN.SuspendLayout()
            Me.SuspendLayout()
            '
            'TC_MAIN
            '
            Me.TC_MAIN.Controls.Add(Me.TP_MEETINGS)
            Me.TC_MAIN.Controls.Add(Me.TP_MODELLEDRACES)
            Me.TC_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_MAIN.Font = New System.Drawing.Font("Calibri", 9.75!)
            Me.TC_MAIN.Location = New System.Drawing.Point(0, 0)
            Me.TC_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_MAIN.Name = "TC_MAIN"
            Me.TC_MAIN.Padding = New System.Drawing.Point(0, 0)
            Me.TC_MAIN.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TC_MAIN.RightToLeftLayout = True
            Me.TC_MAIN.SelectedIndex = 0
            Me.TC_MAIN.Size = New System.Drawing.Size(784, 561)
            Me.TC_MAIN.TabIndex = 23
            '
            'TP_MEETINGS
            '
            Me.TP_MEETINGS.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.TP_MEETINGS.Location = New System.Drawing.Point(4, 24)
            Me.TP_MEETINGS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_MEETINGS.Name = "TP_MEETINGS"
            Me.TP_MEETINGS.Size = New System.Drawing.Size(776, 533)
            Me.TP_MEETINGS.TabIndex = 3
            Me.TP_MEETINGS.Text = "MEETINGS"
            '
            'TP_MODELLEDRACES
            '
            Me.TP_MODELLEDRACES.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.TP_MODELLEDRACES.Location = New System.Drawing.Point(4, 24)
            Me.TP_MODELLEDRACES.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_MODELLEDRACES.Name = "TP_MODELLEDRACES"
            Me.TP_MODELLEDRACES.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_MODELLEDRACES.Size = New System.Drawing.Size(1012, 693)
            Me.TP_MODELLEDRACES.TabIndex = 2
            Me.TP_MODELLEDRACES.Text = "MODELLED RACES"
            '
            'FORM_REPORTING
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.ClientSize = New System.Drawing.Size(784, 561)
            Me.Controls.Add(Me.TC_MAIN)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 8.25!)
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
            Me.Name = "FORM_REPORTING"
            Me.Opacity = 0.9R
            Me.ShowInTaskbar = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "REPORTING"
            Me.TC_MAIN.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents TC_MAIN As System.Windows.Forms.TabControl
        Private WithEvents TP_MEETINGS As System.Windows.Forms.TabPage
        Private WithEvents TP_MODELLEDRACES As System.Windows.Forms.TabPage
    End Class
End Namespace