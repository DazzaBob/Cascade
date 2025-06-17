Imports System
Imports System.ComponentModel
Imports System.Windows.Forms
Namespace UserControls
    Friend NotInheritable Class UC_DISPLAYRACE
        Private MY_MEETING_OADATE As String = Nothing
        Private MY_MEETING_NUMBER As String = Nothing
        Private MY_MEETING_COUNTRY As String = Nothing
        Private MY_MEETING_TYPE As String = Nothing
        Private MY_RACE_NUMBER As String = Nothing
        Private MY_CONNECTION As Connection
        '
        Private UC_DISTANCE As DisplayRace.RaceRunners.UC_DISTANCE
        Private UC_DISTANCE_THEO As DisplayRace.RaceRunners.UC_DISTANCE_THEO
        Private UC_GROUP As DisplayRace.RaceRunners.UC_GROUP
        Private UC_GROUP_THEO As New DisplayRace.RaceRunners.UC_GROUP_THEO
        Private UC_OVERALL As New DisplayRace.RaceRunners.UC_OVERALL
        Private UC_OVERALL_THEO As New DisplayRace.RaceRunners.UC_OVERALL_THEO
        '
        Private UC_BARRIER_ALL As New DisplayRace.UC_BARRIER
        Private UC_BARRIER_90 As New DisplayRace.UC_BARRIER
        Private UC_BARRIER_180 As New DisplayRace.UC_BARRIER
        Private UC_BARRIER_270 As New DisplayRace.UC_BARRIER
        '
        Private WithEvents UC_RESULTS As DisplayRace.UC_RESULTS
        Private WithEvents UC_MODELS As DisplayRace.UC_MODELS
        Friend Sub New(ByVal Connection As Connection)
            InitializeComponent()
            MY_CONNECTION = Connection
        End Sub
        Friend Sub New(ByVal MEETING_OADATE As String, ByVal MEETING_NUMBER As String, ByVal MEETING_COUNTRY As String, ByVal MEETING_TYPE As String, ByVal RACE_NUMBER As String, ByVal Connection As Connection)
            Me.New(Connection)
            '
            MY_MEETING_OADATE = MEETING_OADATE
            MY_MEETING_NUMBER = MEETING_NUMBER
            MY_MEETING_COUNTRY = MEETING_COUNTRY
            MY_MEETING_TYPE = MEETING_TYPE
            MY_RACE_NUMBER = RACE_NUMBER
            '
            Me.UC_DISTANCE = New DisplayRace.RaceRunners.UC_DISTANCE(MY_CONNECTION, MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_RACE_NUMBER)
            Me.UC_DISTANCE.Dock = DockStyle.Fill : Me.SC_RACERUNNERS_MAIN_DISTANCE.Panel1.Controls.Add(Me.UC_DISTANCE)
            '
            Me.UC_DISTANCE_THEO = New DisplayRace.RaceRunners.UC_DISTANCE_THEO(MY_CONNECTION, MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_RACE_NUMBER)
            Me.UC_DISTANCE_THEO.Dock = DockStyle.Fill : Me.GB_RACERUNNERS_MAIN_DISTANCE.Controls.Add(Me.UC_DISTANCE_THEO)
            '
            Me.UC_GROUP = New DisplayRace.RaceRunners.UC_GROUP(MY_CONNECTION, MY_MEETING_OADATE, MY_MEETING_NUMBER, MEETING_COUNTRY, MEETING_COUNTRY, MY_RACE_NUMBER)
            Me.UC_GROUP.Dock = DockStyle.Fill : Me.SC_RACERUNNERS_MAIN_GROUP.Panel1.Controls.Add(Me.UC_GROUP)
            '
            Me.UC_GROUP_THEO = New DisplayRace.RaceRunners.UC_GROUP_THEO(MY_CONNECTION, MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_RACE_NUMBER)
            Me.UC_GROUP_THEO.Dock = DockStyle.Fill : Me.GB_RACERUNNERS_MAIN_GROUP.Controls.Add(Me.UC_GROUP_THEO)
            '
            Me.UC_OVERALL = New DisplayRace.RaceRunners.UC_OVERALL(MY_CONNECTION, MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_RACE_NUMBER)
            Me.UC_OVERALL.Dock = DockStyle.Fill : Me.SC_RACERUNNERS_MAIN_OVERALL.Panel1.Controls.Add(Me.UC_OVERALL)
            '
            Me.UC_OVERALL_THEO = New DisplayRace.RaceRunners.UC_OVERALL_THEO(MY_CONNECTION, MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_RACE_NUMBER)
            Me.UC_OVERALL_THEO.Dock = DockStyle.Fill : Me.GB_RACERUNNERS_MAIN_OVERALL.Controls.Add(Me.UC_OVERALL_THEO)
            '
            If MY_MEETING_TYPE <> "GR" Then
                Me.TC_RACERUNNERS_MAIN.TabPages.Remove(Me.TP_BARRIER)
            Else
                Me.UC_BARRIER_ALL.Dock = DockStyle.Fill : Me.TP_BARRIER_ALL.Controls.Add(Me.UC_BARRIER_ALL)
                Me.UC_BARRIER_90.Dock = DockStyle.Fill : Me.TP_BARRIER_90DAYS.Controls.Add(Me.UC_BARRIER_90)
                Me.UC_BARRIER_180.Dock = DockStyle.Fill : Me.TP_BARRIER_180DAYS.Controls.Add(Me.UC_BARRIER_180)
                Me.UC_BARRIER_270.Dock = DockStyle.Fill : Me.TP_BARRIER_270DAYS.Controls.Add(Me.UC_BARRIER_270)
            End If
        End Sub
        Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
            ' UC_DISTANCE, UC_DISTANCE_THEO is populated in the controls LOAD event so no need to populate here.
            ' UC_GROUP, UC_GROUP_THEO is populated in the controls LOAD event so no need to populate here.
            ' UC_OVERALL, UC_OVERALL_THEO is populated in the controls LOAD event so no need to populate here.
            '
            If CDbl(MY_MEETING_OADATE) < Today.ToOADate Then
                Me.UC_RESULTS = New DisplayRace.UC_RESULTS : Me.UC_RESULTS.Dock = DockStyle.Fill
                Me.TP_RESULTS.Controls.Add(Me.UC_RESULTS)
                Me.UC_RESULTS.Populate(MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_MEETING_COUNTRY, MY_MEETING_TYPE, MY_RACE_NUMBER, MY_CONNECTION)
            Else
                Me.TC_MAIN.TabPages.Remove(Me.TP_RESULTS)
            End If
            '
            Dim HASMODEL As String = StoredProcedures.RACE_INFO.GetScalarFieldValue("HASMODEL", MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_RACE_NUMBER, MY_CONNECTION)
            If (Not HASMODEL Is Nothing) AndAlso CBool(HASMODEL) Then
                Me.UC_MODELS = New DisplayRace.UC_MODELS(MY_CONNECTION) : Me.UC_MODELS.Dock = DockStyle.Fill
                Me.TP_MODELS.Controls.Add(Me.UC_MODELS)
                Me.UC_MODELS.Populate(MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_RACE_NUMBER)
            Else
                Me.TC_MAIN.TabPages.Remove(Me.TP_MODELS)
            End If
            '
            Select Case MY_MEETING_TYPE
                Case "GR"
                    For Each ROW As Data.DataRow In StoredProcedures.RACE_INFO_BARRIER.GetDataTable(MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_RACE_NUMBER, MY_CONNECTION).Select("", "BARRIER ASC")
                        Call UC_BARRIER_ALL.Populate(ROW, "ALL")
                        Call UC_BARRIER_90.Populate(ROW, "90")
                        Call UC_BARRIER_180.Populate(ROW, "180")
                        Call UC_BARRIER_270.Populate(ROW, "270")
                    Next ROW
                    '
                Case Else
                    Me.TC_MAIN.TabPages.Remove(Me.TP_BARRIER)
            End Select
        End Sub
    End Class
End Namespace