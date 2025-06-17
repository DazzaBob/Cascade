Namespace UI.Messages
    Friend NotInheritable Class FrmQuestion
        Friend Sub New(ByVal Title As String, ByVal Message As String)
            InitializeComponent()
            '
            Me.Text = Title
            Me.LBLMessage.Text = Message
        End Sub
        Private Sub FrmExclamation_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Beep()
        End Sub

        Private Sub ButOK_Click(sender As Object, e As EventArgs) Handles ButYES.Click
            Me.DialogResult = Windows.Forms.DialogResult.Yes
            Me.Close()
        End Sub
        Private Sub ButNO_Click(sender As Object, e As EventArgs) Handles ButNO.Click
            Me.DialogResult = Windows.Forms.DialogResult.No
            Me.Close()
        End Sub
    End Class
End Namespace