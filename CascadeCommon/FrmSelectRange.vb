Public Class FrmSelectRange
    Public Sub New()
        InitializeComponent()
        DateTimePickerTo.MinDate = Date.FromOADate(39766)
        DateTimePickerFrom.MinDate = Date.FromOADate(39766)

        DateTimePickerFrom.Value = Date.FromOADate(39766)
        DateTimePickerTo.Value = Date.Today

    End Sub
    Private Sub FrmSelectRange_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        PerformAutoScale()
    End Sub
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        DialogResult = DialogResult.OK
        Close()
    End Sub
    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub


End Class