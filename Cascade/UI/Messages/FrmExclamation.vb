Namespace UI.Messages
    Friend NotInheritable Class FrmExclamation
        Friend Sub New(ByVal Title As String, ByVal Message As String)
            InitializeComponent()
            '
            Me.Text = Title
            Me.LBLMessage.Text = Message
        End Sub
        Private Sub FrmExclamation_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Beep()
        End Sub

        Private Sub ButOK_Click(sender As Object, e As EventArgs) Handles ButOK.Click
            Me.Close()
        End Sub
    End Class
End Namespace