Namespace UI.Messages
    Friend NotInheritable Class FrmInformation
        Friend Sub New(ByVal Title As String, ByVal Message As String)
            InitializeComponent()
            '
            Me.Text = Title
            Me.LBLMessage.Text = Message
        End Sub
        Private Sub Me_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Beep()
        End Sub
        Private Sub ButOK_Click(sender As Object, e As EventArgs) Handles ButOK.Click
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
    End Class
End Namespace