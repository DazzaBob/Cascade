Namespace DisplayRace.RaceRunners
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_GROUP_THEO
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                If UC_90 IsNot Nothing Then UC_90.Dispose() : UC_90 = Nothing
                If UC_180 IsNot Nothing Then UC_180.Dispose() : UC_180 = Nothing
                If UC_270 IsNot Nothing Then UC_270.Dispose() : UC_270 = Nothing
                If UC_365 IsNot Nothing Then UC_365.Dispose() : UC_365 = Nothing
                If UC_BASE IsNot Nothing Then UC_BASE.Dispose() : UC_BASE = Nothing
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
            Me.TC_MAIN = New System.Windows.Forms.TabControl()
            Me.TP_BASE = New System.Windows.Forms.TabPage()
            Me.TP_90DAYS = New System.Windows.Forms.TabPage()
            Me.TP_180DAYS = New System.Windows.Forms.TabPage()
            Me.TP_270DAYS = New System.Windows.Forms.TabPage()
            Me.TP_365DAYS = New System.Windows.Forms.TabPage()
            Me.TC_MAIN.SuspendLayout()
            Me.SuspendLayout()
            '
            'TC_MAIN
            '
            Me.TC_MAIN.Controls.Add(Me.TP_BASE)
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
            Me.TC_MAIN.Size = New System.Drawing.Size(622, 312)
            Me.TC_MAIN.TabIndex = 4
            '
            'TP_BASE
            '
            Me.TP_BASE.Location = New System.Drawing.Point(4, 22)
            Me.TP_BASE.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_BASE.Name = "TP_BASE"
            Me.TP_BASE.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_BASE.Size = New System.Drawing.Size(614, 286)
            Me.TP_BASE.TabIndex = 0
            Me.TP_BASE.Text = "BASE"
            Me.TP_BASE.ToolTipText = "Displays entry information for runners in this race."
            Me.TP_BASE.UseVisualStyleBackColor = True
            '
            'TP_90DAYS
            '
            Me.TP_90DAYS.Location = New System.Drawing.Point(4, 22)
            Me.TP_90DAYS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_90DAYS.Name = "TP_90DAYS"
            Me.TP_90DAYS.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_90DAYS.Size = New System.Drawing.Size(614, 286)
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
            Me.TP_180DAYS.Size = New System.Drawing.Size(614, 286)
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
            Me.TP_270DAYS.Size = New System.Drawing.Size(614, 286)
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
            Me.TP_365DAYS.Size = New System.Drawing.Size(614, 286)
            Me.TP_365DAYS.TabIndex = 12
            Me.TP_365DAYS.Text = "365"
            Me.TP_365DAYS.UseVisualStyleBackColor = True
            '
            'UC_GROUP_THEO
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.TC_MAIN)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_GROUP_THEO"
            Me.Size = New System.Drawing.Size(622, 312)
            Me.TC_MAIN.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents TC_MAIN As System.Windows.Forms.TabControl
        Private WithEvents TP_BASE As System.Windows.Forms.TabPage
        Private WithEvents TP_90DAYS As System.Windows.Forms.TabPage
        Private WithEvents TP_180DAYS As System.Windows.Forms.TabPage
        Private WithEvents TP_270DAYS As System.Windows.Forms.TabPage
        Private WithEvents TP_365DAYS As System.Windows.Forms.TabPage

    End Class
End Namespace