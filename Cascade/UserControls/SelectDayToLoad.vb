Imports System.Windows.Forms
Namespace UserControls
    Friend Class SelectDayToLoad
        Friend Sub New()
            InitializeComponent()
            Me.MonthCalendar1.SelectionStart = Date.FromOADate(Date.Today.ToOADate - 1)
            Me.MonthCalendar1.MinDate = Date.FromOADate(39765)
        End Sub
        Private Sub SelectDayToLoad_Shown(sender As Object, e As EventArgs) Handles Me.Shown
            Dim X As Int16 = 0
            Do Until Me.MonthCalendar1.Width >= Me.Width - 25
                Me.MonthCalendar1.Font = New Font(Me.MonthCalendar1.Font.FontFamily.ToString, Me.MonthCalendar1.Font.Size + 1)
                X += 1S
                If X > 10 Then Exit Do
            Loop
            Me.Width = Me.MonthCalendar1.Width + 25
            Me.NumericUpDown1.Select(1, Me.NumericUpDown1.Value.ToString(InvariantCulture).Length)
            Me.NumericUpDown1.Focus()
        End Sub
        Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End Sub
        Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        End Sub
        Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
            If Me.NumericUpDown1.Value = 0 Then Me.MonthCalendar1.SelectionStart = Today : Me.MonthCalendar1.SelectionEnd = Today
            Dim StartOADate As Integer = CInt(Today.ToOADate)
            StartOADate -= CInt(Me.NumericUpDown1.Value * 30D)
            Me.MonthCalendar1.SelectionStart = Date.FromOADate(CDbl(StartOADate))
        End Sub
    End Class
End Namespace