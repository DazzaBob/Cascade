Public Class FrmMain
    Friend MaxLoadedDate As Integer
    Private ReadOnly Connection As CascadeCommon.Utils.Connection
    Private CountryDT As Data.DataTable
    Public Sub New()
        InitializeComponent()
        Me.Connection = New CascadeCommon.Utils.Connection(My.Settings.ConnectionString)
    End Sub
    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CommandText As String = "SELECT * FROM COUNTRIES"
        Me.CountryDT = Connection.GetDataTable(CommandText)

        CommandText = "SELECT MAX(START_TIME) AS DATETIME FROM RACE_XML"
        Dim oMaxDate As Object = Me.Connection.ExecuteScalar(CommandText)
        If oMaxDate Is Nothing Then
            MessageBox.Show("No Data to load, exiting the application", "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
            Exit Sub
        End If
        Me.MaxLoadedDate = Convert.ToInt32(oMaxDate)

        Call PopulateBaseTreeItems()
    End Sub
#Region "    Populate Tree Nodes "
    Private Sub PopulateBaseTreeItems()
        Dim StartYear As Integer = Date.FromOADate(Me.MaxLoadedDate).Year, FinishYear As Integer = Date.FromOADate(Utils.MinOADate).Year
        Dim FinishMonth As Integer = Date.FromOADate(Me.MaxLoadedDate).Month
        For i As Integer = StartYear To FinishYear Step -1
            Dim NewNode As New TreeNode With {
                .Text = i.ToString,
                .Tag = i.ToString
            }
            Call AddCountry(NewNode, i, StartYear, FinishMonth)
            Me.TreeViewMain.Nodes.Add(NewNode)
        Next
    End Sub
    Private Sub AddCountry(ByRef Node As TreeNode, CurrentYear As Integer, StartYear As Integer, FinishMonth As Integer)
        For Each Row As Data.DataRow In Me.CountryDT.Select("")
            Dim NewNode As New TreeNode With {
                           .Text = Row.Item("NAME").ToString,
                           .Tag = Node.Tag & "|" & Row.Item("COUNTRY_ID").ToString
}
            Call AddMonths(CurrentYear, StartYear, FinishMonth, NewNode)
            Node.Nodes.Add(NewNode)
        Next
    End Sub
    Private Sub AddMonths(CurrentYear As Integer, StartYear As Integer, FinishMonth As Integer, ByRef Node As TreeNode)
        Dim this_FinishMonth As Integer
        If CurrentYear = StartYear Then this_FinishMonth = FinishMonth Else this_FinishMonth = 12

        For X As Integer = this_FinishMonth To 1 Step -1
            Dim NewNode As New TreeNode With {
                .Text = DateAndTime.MonthName(X),
                .Tag = Node.Tag & "|" & X.ToString
            }
            Call AddMeetingType(NewNode)
            Node.Nodes.Add(NewNode)
        Next
    End Sub
    Private Shared Sub AddMeetingType(ByRef Node As TreeNode)
        For Each Type As String In New String() {"GR", "H", "G"}
            Dim NewNode As New TreeNode With {
                .Tag = Node.Tag & "|" & Type
            }
            If Type = "GR" Then NewNode.Text = "Greyhounds"
            If Type = "H" Then NewNode.Text = "Harness"
            If Type = "G" Then NewNode.Text = "Gallops"

            Node.Nodes.Add(NewNode)
        Next
    End Sub
    Private Sub PopulateMeetings(ByRef Node As TreeNode)
        If Node.GetNodeCount(True) > 0 Then Return

        Dim Tag() As String = Split(Node.Tag, "|")
        Dim Year As Integer = Convert.ToInt32(Tag(0))
        Dim CountryID As String = Tag(1)
        Dim Month As Integer = Convert.ToInt32(Tag(2))
        Dim Type As String = Tag(3).ToString

        Dim StartDate As Double, FinishDate As Double

        StartDate = New DateTime(Year, Month, 1).ToOADate
        FinishDate = New DateTime(Year, Month, DateTime.DaysInMonth(Year, Month)).ToOADate

        Dim CommandText As String = "SELECT NUMBER, NAME, OADATE FROM MEETING_XML 
        WHERE (TYPE = N'" & Type & "')  AND (COUNTRY_ID = " & CountryID & ") 
        GROUP BY NAME, NUMBER, OADATE 
        HAVING (OADATE >= " & StartDate.ToString & " AND OADATE <= " & FinishDate & ")"

        For Each Row As Data.DataRow In Me.Connection.GetDataTable(CommandText).Select("", "OADATE DESC")
            Dim NewNode As New TreeNode With {
                .Text = Date.FromOADate(Convert.ToDouble(Row.Item("OADATE"))).ToString("dd ddd") & " - " & "(M" & Row.Item("NUMBER") & ") " & Row.Item("NAME").ToString,
                .Tag = Node.Tag & "|" & Row.Item("OADATE").ToString & "-" & Row.Item("NUMBER").ToString
            }
            CommandText = "SELECT DISTINCT RACE_EXTENDED.HASMODEL FROM MEETING_XML INNER JOIN RACE_EXTENDED ON MEETING_XML.OADATE = RACE_EXTENDED.MEETING_XML_OADATE AND MEETING_XML.NUMBER = RACE_EXTENDED.MEETING_XML_NUMBER 
            WHERE (RACE_EXTENDED.HASMODEL = 1) AND (RACE_EXTENDED.MEETING_XML_OADATE = " & Row.Item("OADATE").ToString & ") AND (RACE_EXTENDED.MEETING_XML_NUMBER = " & Row.Item("NUMBER").ToString & ")"
            If Me.Connection.GetDataTable(CommandText).Rows.Count > 0 Then
                NewNode.BackColor = Color.DarkCyan
                NewNode.ForeColor = Color.Black
                NewNode.NodeFont = New Font(Me.TreeViewMain.Font.FontFamily, Me.TreeViewMain.Font.Size, FontStyle.Bold)
            End If
            Node.Nodes.Add(NewNode)
        Next Row
        Node.Expand()

    End Sub
    Private Sub PopulateRaces(ByRef Node As TreeNode)
        If Node.GetNodeCount(True) > 0 Then Return

        Dim Tag() As String = Split(Split(Node.Tag, "|")(4), "-")
        Dim CountryID As String = Split(Node.Tag, "|")(1)
        Dim MeetingType As String = Split(Node.Tag, "|")(3)

        For Each Row As Data.DataRow In CascadeCommon.SQL.View.Common.RACE_XML_RACE_EXTENDED(Tag(0).ToString, Tag(1).ToString, Me.Connection).Select("")
            Dim NewNode As New TreeNode With {
                .Text = Date.FromOADate(Convert.ToDouble(Row.Item("START_TIME"))).ToString("t") & " - " & "(R" & Row.Item("NUMBER") & ") - " & Row.Item("LENGTH") & " - " & Row.Item("NAME").ToString,
                .Tag = Node.Tag & "|" & Row.Item("NUMBER").ToString
            }

            If Not Information.IsDBNull(Row.Item("HASMODEL")) Then
                If CBool(Row.Item("HASMODEL")) Then
                    NewNode.BackColor = Color.DarkCyan
                    NewNode.ForeColor = Color.Black
                    NewNode.NodeFont = New Font(Me.TreeViewMain.Font.FontFamily, Me.TreeViewMain.Font.Size, FontStyle.Bold)
                End If
            End If

            Node.Nodes.Add(NewNode)
        Next Row
        Node.Expand()
    End Sub
#End Region
    Private Sub PopulateGridView(Node As TreeNode)
        Dim Tag() As String = Split(Node.Tag, "|")
        Dim sSTRING() As String = Split(Tag(4), "-")

        Dim CountryID As String = Tag(1).ToString
        Dim OADate As String = sSTRING(0).ToString
        Dim MeetingNumber As String = sSTRING(1).ToString
        Dim RaceNumber As String = Tag(5).ToString

        If SplitContainerMain.Panel2.Controls.Count > 0 Then
            For Each CNTRL As Control In SplitContainerMain.Panel2.Controls
                CNTRL.Dispose()
            Next
        End If
        Dim UC_ViewRace As New CascadeCommon.UserControls.ViewRace(CountryID, OADate, MeetingNumber, Tag(3), RaceNumber, Node.FullPath, Me.Connection)
        UC_ViewRace.Dock = DockStyle.Fill
        SplitContainerMain.Panel2.Font = UC_ViewRace.Font
        SplitContainerMain.Panel2.Controls.Add(UC_ViewRace)
    End Sub
    Private Sub TreeViewMain_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeViewMain.AfterSelect
        Me.Cursor = Cursors.WaitCursor
        Me.TreeViewMain.Cursor = Cursors.WaitCursor

        If SplitContainerMain.Panel2.Controls.Count > 0 Then
            For Each CNTRL As Control In SplitContainerMain.Panel2.Controls
                CNTRL.Dispose()
            Next
        End If

        Dim Tag() As String = Split(Me.TreeViewMain.SelectedNode.Tag, "|")
        If Tag.Length = 4 Then Call PopulateMeetings(Me.TreeViewMain.SelectedNode)
        If Tag.Length = 5 Then Call PopulateRaces(Me.TreeViewMain.SelectedNode)
        If Tag.Length = 6 Then Call PopulateGridView(Me.TreeViewMain.SelectedNode)

        Me.Cursor = Cursors.Default
        Me.TreeViewMain.Cursor = Cursors.Default
    End Sub
    Private Sub TreeViewMain_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeViewMain.NodeMouseClick
        Call TreeViewMain_AfterSelect(sender, New TreeViewEventArgs(e.Node))
    End Sub
End Class
