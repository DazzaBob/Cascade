Namespace UI.Messages
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmExclamation
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExclamation))
            Me.ButOK = New System.Windows.Forms.Button()
            Me.LBLMessage = New System.Windows.Forms.Label()
            Me.PictureBox1 = New System.Windows.Forms.PictureBox()
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ButOK
            '
            Me.ButOK.Location = New System.Drawing.Point(656, 141)
            Me.ButOK.Name = "ButOK"
            Me.ButOK.Size = New System.Drawing.Size(75, 27)
            Me.ButOK.TabIndex = 0
            Me.ButOK.Text = "OK"
            Me.ButOK.UseVisualStyleBackColor = True
            '
            'LBLMessage
            '
            Me.LBLMessage.AutoEllipsis = True
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
            Me.PictureBox1.InitialImage = Nothing
            Me.PictureBox1.Location = New System.Drawing.Point(13, 7)
            Me.PictureBox1.Name = "PictureBox1"
            Me.PictureBox1.Size = New System.Drawing.Size(138, 124)
            Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
            Me.PictureBox1.TabIndex = 2
            Me.PictureBox1.TabStop = False
            '
            'FrmExclamation
            '
            Me.AcceptButton = Me.ButOK
            Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.Window
            Me.ClientSize = New System.Drawing.Size(743, 180)
            Me.Controls.Add(Me.PictureBox1)
            Me.Controls.Add(Me.LBLMessage)
            Me.Controls.Add(Me.ButOK)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
            Me.Margin = New System.Windows.Forms.Padding(4)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "FrmExclamation"
            Me.Opacity = 0.95R
            Me.ShowIcon = False
            Me.ShowInTaskbar = False
            Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.TopMost = True
            CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents ButOK As System.Windows.Forms.Button
        Private WithEvents LBLMessage As System.Windows.Forms.Label
        Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    End Class
End Namespace