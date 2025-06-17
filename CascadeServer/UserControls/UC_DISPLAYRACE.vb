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
        Private MY_CONNECTION As Utils.Connection
        Friend Sub New(ByVal Connection As Utils.Connection)
            InitializeComponent()
            MY_CONNECTION = Connection
        End Sub
        Friend Sub New(ByVal MEETING_OADATE As String, ByVal MEETING_NUMBER As String, ByVal MEETING_COUNTRY As String, ByVal MEETING_TYPE As String, ByVal RACE_NUMBER As String, ByVal Connection As Utils.Connection)
            Me.New(Connection)
            '
            MY_MEETING_OADATE = MEETING_OADATE
            MY_MEETING_NUMBER = MEETING_NUMBER
            MY_MEETING_COUNTRY = MEETING_COUNTRY
            MY_MEETING_TYPE = MEETING_TYPE
            MY_RACE_NUMBER = RACE_NUMBER
            '
            '
            If MY_MEETING_TYPE <> "GR" Then
                Me.TC_RACERUNNERS_MAIN.TabPages.Remove(Me.TP_BARRIER)
            Else
                '
            End If
        End Sub
        Private Sub Me_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' UC_DISTANCE, UC_DISTANCE_THEO is populated in the controls LOAD event so no need to populate here.
            ' UC_GROUP, UC_GROUP_THEO is populated in the controls LOAD event so no need to populate here.
            ' UC_OVERALL, UC_OVERALL_THEO is populated in the controls LOAD event so no need to populate here.
            '
            If CDbl(MY_MEETING_OADATE) < Today.ToOADate Then
                'Me.TP_RESULTS.Controls.Add(Me.UC_RESULTS)
            Else
                Me.TC_MAIN.TabPages.Remove(Me.TP_RESULTS)
            End If
            '
            Dim HASMODEL As String = String.Empty ' StoredProcedures.RACE_INFO.GetScalarFieldValue("HASMODEL", MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_RACE_NUMBER, MY_CONNECTION)
            If (Not HASMODEL Is Nothing) AndAlso CBool(HASMODEL) Then
                'Me.UC_MODELS = New DisplayRace.UC_MODELS(MY_CONNECTION) : Me.UC_MODELS.Dock = DockStyle.Fill
                'Me.TP_MODELS.Controls.Add(Me.UC_MODELS)
                'Me.UC_MODELS.Populate(MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_RACE_NUMBER)
            Else
                Me.TC_MAIN.TabPages.Remove(Me.TP_MODELS)
            End If
            '
            Select Case MY_MEETING_TYPE
                Case "GR"
                    'For Each ROW As Data.DataRow In StoredProcedures.RACE_INFO_BARRIER.GetDataTable(MY_MEETING_OADATE, MY_MEETING_NUMBER, MY_RACE_NUMBER, MY_CONNECTION).Select("", "BARRIER ASC")
                    'Call UC_BARRIER_ALL.Populate(ROW, "ALL")
                    'Call UC_BARRIER_90.Populate(ROW, "90")
                    'Call UC_BARRIER_180.Populate(ROW, "180")
                    'Call UC_BARRIER_270.Populate(ROW, "270")
                    'Next ROW
                    '
                Case Else
                    Me.TC_MAIN.TabPages.Remove(Me.TP_BARRIER)
            End Select
        End Sub
    End Class
End Namespace