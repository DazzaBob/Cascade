Namespace DisplayRace.RaceRunners
    Friend NotInheritable Class UC_GROUP
        Private MY_MEETING_OADATE As String
        Private MY_MEETING_NUMBER As String
        Private MY_MEETING_COUNTRY As String
        Private MY_MEETING_TYPE As String
        Private MY_RACE_NUMBER As String
        Private MY_CONNECTION As Connection
        '
        Private UC_BASE As UserControls.UC_GroupOverall_Base = Nothing
        Private UC_90 As UserControls.UC_Extended = Nothing
        Private UC_180 As UserControls.UC_Extended = Nothing
        Private UC_270 As UserControls.UC_Extended = Nothing
        Private UC_365 As UserControls.UC_Extended = Nothing
        Friend Sub New()
            InitializeComponent()
        End Sub
        Friend Sub New(ByVal Connection As Connection, ByVal MEETING_OADATE As String, ByVal MEETING_NUMBER As String, ByVal MEETING_COUNTRY As String, ByVal MEETING_TYPE As String, ByVal RACE_NUMBER As String)
            Me.New()
            '
            MY_CONNECTION = Connection
            MY_MEETING_OADATE = MEETING_OADATE
            MY_MEETING_NUMBER = MEETING_NUMBER
            MY_MEETING_COUNTRY = MEETING_COUNTRY
            MY_MEETING_TYPE = MEETING_TYPE
            MY_RACE_NUMBER = RACE_NUMBER
            '
            UC_90 = New UserControls.UC_Extended(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_CONNECTION) : UC_90.Dock = DockStyle.Fill
            UC_180 = New UserControls.UC_Extended(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_CONNECTION) : UC_180.Dock = DockStyle.Fill
            UC_270 = New UserControls.UC_Extended(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_CONNECTION) : UC_270.Dock = DockStyle.Fill
            UC_365 = New UserControls.UC_Extended(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_CONNECTION) : UC_365.Dock = DockStyle.Fill
            UC_BASE = New UserControls.UC_GroupOverall_Base(MY_MEETING_OADATE, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_CONNECTION) : UC_BASE.Dock = DockStyle.Fill
            '
            Me.TP_90DAYS.Controls.Add(UC_90)
            Me.TP_180DAYS.Controls.Add(UC_180)
            Me.TP_270DAYS.Controls.Add(UC_270)
            Me.TP_365DAYS.Controls.Add(UC_365)
            Me.TP_BASE.Controls.Add(UC_BASE)
        End Sub
        Private Sub UC_GROUP_Load(sender As Object, e As EventArgs) Handles Me.Load
            For Each ENTRY_ROW As Data.DataRow In StoredProcedures.JoinedDataTable(MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_RACE_NUMBER, "GROUP", MY_CONNECTION).Select("")
                Call UC_BASE.Populate(ENTRY_ROW)
                Call PopulateExtendedInformation(ENTRY_ROW)
            Next ENTRY_ROW
        End Sub
        Private Sub PopulateExtendedInformation(ByVal ROW As Data.DataRow)
            Call UC_90.Populate(ROW, "90")
            Call UC_180.Populate(ROW, "180")
            Call UC_270.Populate(ROW, "270")
            Call UC_365.Populate(ROW, "0")
        End Sub
    End Class
End Namespace