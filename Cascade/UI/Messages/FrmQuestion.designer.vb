Namespace UI.Messages
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmQuestion
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmQuestion))
            Me.ButYES = New System.Windows.Forms.Button()
            Me.LBLMessage = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            Me.ButNO = New System.Windows.Forms.Button()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ButYES
            '
            Me.ButYES.Location = New System.Drawing.Point(656, 141)
            Me.ButYES.Name = "ButYES"
            Me.ButYES.Size = New System.Drawing.Size(75, 27)
            Me.ButYES.TabIndex = 0
            Me.ButYES.Text = "YES"
            Me.ButYES.UseVisualStyleBackColor = True
            '
            'LBLMessage
            '
            Me.LBLMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.LBLMessage.Location = New System.Drawing.Point(157, 7)
            Me.LBLMessage.Name = "LBLMessage"
            Me.LBLMessage.Size = New System.Drawing.Size(574, 124)
            Me.LBLMessage.TabIndex = 1
            Me.LBLMessage.Text = "Message"
            '
            'PictureBox1
            '
            Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
            Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.PictureBox1.Location = New System.Drawing.Point(13, 7)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(138, 124)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 2
            Me.PictureBox1.TabStop = False
            '
            'ButNO
            '
            Me.ButNO.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.ButNO.Location = New System.Drawing.Point(575, 141)
            Me.ButNO.Name = "ButNO"
            Me.ButNO.Size = New System.Drawing.Size(75, 27)
            Me.ButNO.TabIndex = 3
            Me.ButNO.Text = "NO"
            Me.ButNO.UseVisualStyleBackColor = True
            '
            'FrmQuestion
            '
            Me.AcceptButton = Me.ButYES
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Window
            Me.CancelButton = Me.ButNO
            Me.ClientSize = New System.Drawing.Size(743, 180)
            Me.Controls.Add(Me.ButNO)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.LBLMessage)
            Me.Controls.Add(Me.ButYES)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmQuestion"
            Me.Opacity = 0.95R
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.TopMost = True
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents ButYES As System.Windows.Forms.Button
        Private WithEvents LBLMessage As System.Windows.Forms.Label
        Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
        Private WithEvents ButNO As System.Windows.Forms.Button
    End Class
End Namespace