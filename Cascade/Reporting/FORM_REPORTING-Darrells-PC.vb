Namespace Reporting
    Friend NotInheritable Class FORM_REPORTING
        Friend Shared Connection As Connection
        '
        Private MY_RACES_MODELLED As UserControls.UC_MODELLED
        '
        Private MY_MEETINGS As UserControls.UC_MEETINGS
        Friend Sub New()
            InitializeComponent()
            '
            Connection = New Connection()
        End Sub
        Private Sub FORM_REPORTING_Load(sender As Object, e As EventArgs) Handles Me.Load
            MY_RACES_MODELLED = New UserControls.UC_MODELLED(Connection)
            MY_RACES_MODELLED.Dock = DockStyle.Fill
            TP_MODELLEDRACES.Controls.Add(MY_RACES_MODELLED)
            '
            MY_MEETINGS = New UserControls.UC_MEETINGS
            MY_MEETINGS.Dock = DockStyle.Fill
            TP_MEETINGS.Controls.Add(MY_MEETINGS)
        End Sub
    End Class
End Namespace