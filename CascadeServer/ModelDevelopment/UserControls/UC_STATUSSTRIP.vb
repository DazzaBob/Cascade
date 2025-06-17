Namespace ModelDevelopment.Controls
    Friend NotInheritable Class UC_STATUSSTRIP : Inherits System.Windows.Forms.StatusStrip
        Friend WithEvents TSSLStatus As ToolStripStatusLabel
        Friend WithEvents TSSPBProgress As ToolStripProgressBar
        Friend Sub New()
            MyBase.New()
            '
            Me.TSSLStatus = New ToolStripStatusLabel
            Me.TSSLStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.TSSLStatus.Margin = New System.Windows.Forms.Padding(0)
            Me.TSSLStatus.Name = "TSSLabelStatus"
            Me.TSSLStatus.Size = New System.Drawing.Size(579, 22)
            Me.TSSLStatus.Spring = True
            Me.TSSLStatus.Text = "Ready"
            Me.TSSLStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            Me.TSSPBProgress = New ToolStripProgressBar
            Me.TSSPBProgress.Name = "TSSBar"
            Me.TSSPBProgress.Size = New System.Drawing.Size(100, 16)
            Me.TSSPBProgress.Visible = False
            Me.Items.Add(Me.TSSLStatus)
            Me.Items.Add(Me.TSSPBProgress)
        End Sub
    End Class
End Namespace