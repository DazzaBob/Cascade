Namespace UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_ApplicationSettings
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
            Me.PG_ApplicationSettings = New System.Windows.Forms.PropertyGrid()
            Me.SuspendLayout()
            '
            'PG_ApplicationSettings
            '
            Me.PG_ApplicationSettings.Dock = System.Windows.Forms.DockStyle.Fill
            Me.PG_ApplicationSettings.Location = New System.Drawing.Point(0, 0)
            Me.PG_ApplicationSettings.Margin = New System.Windows.Forms.Padding(0)
            Me.PG_ApplicationSettings.Name = "PG_ApplicationSettings"
            Me.PG_ApplicationSettings.Size = New System.Drawing.Size(405, 239)
            Me.PG_ApplicationSettings.TabIndex = 0
            '
            'UC_ApplicationSettings
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.PG_ApplicationSettings)
            Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_ApplicationSettings"
            Me.Size = New System.Drawing.Size(405, 239)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents PG_ApplicationSettings As System.Windows.Forms.PropertyGrid

    End Class
End Namespace