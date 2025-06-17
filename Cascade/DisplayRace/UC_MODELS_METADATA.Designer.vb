Namespace DisplayRace
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_MODELS_METADATA
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
            Me.TC_METADATA = New System.Windows.Forms.TabControl()
            Me.TP_LOGS = New System.Windows.Forms.TabPage()
            Me.TP_NOTES = New System.Windows.Forms.TabPage()
            Me.TB_LOGS = New System.Windows.Forms.TextBox()
            Me.TB_NOTES = New System.Windows.Forms.TextBox()
            Me.TC_METADATA.SuspendLayout()
            Me.TP_LOGS.SuspendLayout()
            Me.TP_NOTES.SuspendLayout()
            Me.SuspendLayout()
            '
            'TC_METADATA
            '
            Me.TC_METADATA.Controls.Add(Me.TP_LOGS)
            Me.TC_METADATA.Controls.Add(Me.TP_NOTES)
            Me.TC_METADATA.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_METADATA.Location = New System.Drawing.Point(0, 0)
            Me.TC_METADATA.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_METADATA.Name = "TC_METADATA"
            Me.TC_METADATA.SelectedIndex = 0
            Me.TC_METADATA.Size = New System.Drawing.Size(595, 346)
            Me.TC_METADATA.TabIndex = 0
            '
            'TP_LOGS
            '
            Me.TP_LOGS.Controls.Add(Me.TB_LOGS)
            Me.TP_LOGS.Location = New System.Drawing.Point(4, 22)
            Me.TP_LOGS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_LOGS.Name = "TP_LOGS"
            Me.TP_LOGS.Size = New System.Drawing.Size(587, 320)
            Me.TP_LOGS.TabIndex = 0
            Me.TP_LOGS.Text = "LOGS"
            Me.TP_LOGS.UseVisualStyleBackColor = True
            '
            'TP_NOTES
            '
            Me.TP_NOTES.Controls.Add(Me.TB_NOTES)
            Me.TP_NOTES.Location = New System.Drawing.Point(4, 22)
            Me.TP_NOTES.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_NOTES.Name = "TP_NOTES"
            Me.TP_NOTES.Size = New System.Drawing.Size(587, 320)
            Me.TP_NOTES.TabIndex = 1
            Me.TP_NOTES.Text = "NOTES"
            Me.TP_NOTES.UseVisualStyleBackColor = True
            '
            'TB_LOGS
            '
            Me.TB_LOGS.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TB_LOGS.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TB_LOGS.Location = New System.Drawing.Point(0, 0)
            Me.TB_LOGS.Margin = New System.Windows.Forms.Padding(0)
            Me.TB_LOGS.Multiline = True
            Me.TB_LOGS.Name = "TB_LOGS"
            Me.TB_LOGS.ReadOnly = True
            Me.TB_LOGS.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.TB_LOGS.Size = New System.Drawing.Size(587, 320)
            Me.TB_LOGS.TabIndex = 0
            '
            'TB_NOTES
            '
            Me.TB_NOTES.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.TB_NOTES.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TB_NOTES.Location = New System.Drawing.Point(0, 0)
            Me.TB_NOTES.Margin = New System.Windows.Forms.Padding(0)
            Me.TB_NOTES.Multiline = True
            Me.TB_NOTES.Name = "TB_NOTES"
            Me.TB_NOTES.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.TB_NOTES.Size = New System.Drawing.Size(587, 320)
            Me.TB_NOTES.TabIndex = 1
            '
            'UC_MODELS_METADATA
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.TC_METADATA)
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Name = "UC_MODELS_METADATA"
            Me.Size = New System.Drawing.Size(595, 346)
            Me.TC_METADATA.ResumeLayout(False)
            Me.TP_LOGS.ResumeLayout(False)
            Me.TP_LOGS.PerformLayout()
            Me.TP_NOTES.ResumeLayout(False)
            Me.TP_NOTES.PerformLayout()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents TC_METADATA As System.Windows.Forms.TabControl
        Private WithEvents TP_LOGS As System.Windows.Forms.TabPage
        Private WithEvents TP_NOTES As System.Windows.Forms.TabPage
        Private WithEvents TB_LOGS As System.Windows.Forms.TextBox
        Private WithEvents TB_NOTES As System.Windows.Forms.TextBox

    End Class
End Namespace