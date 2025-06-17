Namespace UserControls
    Friend Class UC_ApplicationSettings
        Friend Sub New()
            InitializeComponent()
            Me.PG_ApplicationSettings.SelectedObject = My.Settings
        End Sub

        Private Sub PG_ApplicationSettings_PropertyValueChanged(s As Object, e As PropertyValueChangedEventArgs) Handles PG_ApplicationSettings.PropertyValueChanged
            Me.Cursor = Cursors.WaitCursor
            My.Settings.Save()
            Me.Cursor = Cursors.Default
        End Sub
    End Class
End Namespace