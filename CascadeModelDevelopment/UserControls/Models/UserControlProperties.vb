Imports System.ComponentModel

Namespace UserControls.Models
    Friend Class UserControlProperties
        ' Model Information
        Private _Country As String = String.Empty
        Private _Type As String = String.Empty
        Private _Venue As String = String.Empty
        Private _Length As String = String.Empty
        Private _Name As String = String.Empty

        ' Status Information
        Private _ID As String = String.Empty
        Private _ParentID As String = String.Empty
        Private _TreePath As String = String.Empty
        Private _Version As String = String.Empty
        Private _Status As Boolean = False
        Private _Compiled As Boolean = False

        Private _SourceCode As String = String.Empty

        Private _RequiresSaving As Boolean = False
        Private _IsLoading As Boolean = True

        Private _DTCountry As Data.DataTable
        Private _DT_Venue As Data.DataTable
        Private _DT_Length As Data.DataTable

        Private _UCTabPage As UserControls.UserControlTabPage
        Private _FrmMain As FrmMain

        Private WithEvents Timer As System.Windows.Forms.Timer
#Region "        Constructor "
        Private Sub New()
            InitializeComponent()
            Me.Timer = New Timer
        End Sub
        Friend Sub New(ID As String, TabPage As UserControls.UserControlTabPage, FrmMain As FrmMain)
            Me.New
            Me._ID = ID
            Me._UCTabPage = TabPage
            Me._FrmMain = FrmMain
        End Sub
#End Region
        Private Sub UserControlProperties_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Using Connection As New Utils.Connection
                Me._DTCountry = Datatables.Country.DataTable(Connection)
                Me._DT_Venue = Datatables.Venue.DataTable(Connection)
                Me._DT_Length = Datatables.Length.DataTable(Connection)

                If Me._ID <> String.Empty Then
                    Call Populate_Control(Connection)
                End If
            End Using

            Me._IsLoading = False

            Me.Timer.Interval = 1000
            Me.Timer.Start()
        End Sub
#Region "        Properties "
        Friend Property Country As String
            Get
                Return Me._Country
            End Get
            Set(value As String)
                Me._Country = value
                Me.ComboBox_Country.Text = value
            End Set
        End Property
        Friend Property Type As String
            Get
                Return Me._Type
            End Get
            Set(value As String)
                Me._Type = value
                Me.ComboBox_Type.Text = value
            End Set
        End Property
        Friend Property Venue As String
            Get
                Return Me._Venue
            End Get
            Set(value As String)
                Me._Venue = value
                Me.ComboBox_Venue.Text = value
            End Set
        End Property
        Friend Property Length As String
            Get
                Return Me._Length
            End Get
            Set(value As String)
                Me._Length = value
                Me.ComboBox_Length.Text = value
            End Set
        End Property
        Friend Property [ModelName] As String
            Get
                Return Me._Name
            End Get
            Set(value As String)
                Me._Name = value
                Me.TBName.Text = value
            End Set
        End Property
        Friend Property ID As String
            Get
                Return Me._ID
            End Get
            Set(value As String)
                Me._ID = value
                Me.TB_ID.Text = value
            End Set
        End Property
        Friend Property ParentID As String
            Get
                Return Me._ParentID
            End Get
            Set(value As String)
                Me._ParentID = value
                Me.TB_ParentID.Text = value
            End Set
        End Property
        Friend Property TreePath As String
            Get
                Return Me._TreePath
            End Get
            Set(value As String)
                Me._TreePath = value
                Me.TB_TreePath.Text = value
            End Set
        End Property
        Friend Property Version As String
            Get
                Return Me._Version
            End Get
            Set(value As String)
                Me._Version = value
                Me.TB_Version.Text = value
            End Set
        End Property
        Friend Property Status As Boolean
            Get
                Return Me._Status
            End Get
            Set(value As Boolean)
                Me._Status = value
                Me.ComboBox_Status.Text = value.ToString()
            End Set
        End Property
        Friend Property Compiled As Boolean
            Get
                Return Me._Compiled
            End Get
            Set(value As Boolean)
                Me._Compiled = value
                Me.ComboBox_Compiled.Text = value.ToString()
                Me._RequiresSaving = True
            End Set
        End Property
        Friend Property RequiresSave As Boolean
            Get
                Return Me._RequiresSaving
            End Get
            Set(value As Boolean)
                Me._RequiresSaving = value
            End Set
        End Property
        Friend Property SourceCode As String
            Get
                Return Me._SourceCode
            End Get
            Set(value As String)
                Me._SourceCode = value
            End Set
        End Property
#End Region
        Private Sub ComboBox_Country_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_Country.SelectedValueChanged
            Me.ComboBox_Type.SelectedValue = String.Empty
            Call Clear_ComboBox(Me.ComboBox_Venue)
            Call Clear_ComboBox(Me.ComboBox_Length)

            Select Case Me.ComboBox_Country.Text
                Case "New Zealand"
                    Me._Country = "1"
                    Exit Select
                Case "Australia"
                    Me._Country = "3"
                    Exit Select
                Case Else
                    Me._Country = String.Empty
                    Me._Type = String.Empty
                    Me._Venue = String.Empty
                    Me._Length = String.Empty
            End Select

            If Not Me._IsLoading Then Me._RequiresSaving = True
        End Sub
        Private Sub ComboBox_Type_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_Type.SelectedValueChanged
            Call Clear_ComboBox(Me.ComboBox_Length)

            Select Case Me.ComboBox_Type.Text
                Case "Greyhounds"
                    Me._Type = "GR"
                    Exit Select
                Case "Harness"
                    Me._Type = "H"
                    Exit Select
                Case "Gallops"
                    Me._Type = "G"
                    Exit Select
                Case Else
                    Me._Type = String.Empty
                    Me._Venue = String.Empty
                    Me._Length = String.Empty
            End Select

            Call Populate_ComboBoxVenue()
            If Not Me._IsLoading Then Me._RequiresSaving = True
        End Sub
        Private Sub ComboBox_Venue_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_Venue.SelectedValueChanged
            Call Clear_ComboBox(Me.ComboBox_Length)

            If Me._Country = String.Empty Then Return
            If Me._Type = String.Empty Then Return
            If Me.ComboBox_Venue.Text = String.Empty Then
                Me._Venue = String.Empty
                Return
            End If

            Dim DR() As Data.DataRow = Me._DT_Venue.Select("(COUNTRY_ID=" & Me._Country & ") AND (TRACK_TYPE='" & Me._Type & "') AND (NAME='" & Me.ComboBox_Venue.Text & "')")
            Me._Venue = DR(0).Item("VENUE_ID").ToString
            Me._Length = String.Empty

            Call Populate_ComboBoxLength()
            If Not Me._IsLoading Then Me._RequiresSaving = True
        End Sub
        Private Sub ComboBox_Length_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_Length.SelectedValueChanged
            Me._Length = Me.ComboBox_Length.Text
            If Not Me._IsLoading Then Me._RequiresSaving = True
        End Sub
        Private Sub TBName_TextChanged(sender As Object, e As EventArgs) Handles TBName.TextChanged
            Me._Name = Me.TBName.Text
            Me._UCTabPage.Text = Me.TBName.Text

            FrmMain.TV_MODELS.Nodes.Find(Me.ID, True)(0).Text = Me.TBName.Text

            If Not Me._IsLoading Then Me._RequiresSaving = True
        End Sub
        Private Sub ComboBox_Status_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox_Status.SelectedValueChanged
            If Not Me._IsLoading Then
                If Me.ComboBox_Status.Text = Boolean.TrueString Then Me._Status = True
                If Me.ComboBox_Status.Text = Boolean.FalseString Then Me._Status = False
            End If

            If Not Me._IsLoading Then Me._RequiresSaving = True
        End Sub
        Private Shared Sub Clear_ComboBox(ByRef ComboBox As ComboBox)
            ComboBox.Items.Clear() : ComboBox.Items.Add(String.Empty)
            ComboBox.Text = String.Empty
        End Sub
        Private Sub Populate_ComboBoxVenue()
            Call Clear_ComboBox(Me.ComboBox_Venue)

            For Each Row As Data.DataRow In Me._DT_Venue.Select("(COUNTRY_ID=" & Me._Country & ") AND (TRACK_TYPE='" & Me._Type & "')", "NAME ASC")
                Me.ComboBox_Venue.Items.Add(Row.Item("NAME").ToString)
            Next Row
        End Sub
        Private Sub Populate_ComboBoxLength()
            Call Clear_ComboBox(Me.ComboBox_Length)

            If Me._Country = String.Empty Then Return
            If Me._Type = String.Empty Then Return
            If Me._Venue = String.Empty Then Return

            For Each Row As Data.DataRow In Me._DT_Length.Select("(COUNTRY_ID=" & Me._Country & ") AND (TRACK_TYPE='" & Me._Type & "') AND (VENUE_ID=" & Me._Venue & ")", "LENGTH ASC")
                Me.ComboBox_Length.Items.Add(Row.Item("LENGTH").ToString)
            Next Row
        End Sub
        Private Sub Populate_Control(Connection As Utils.Connection)
            Dim CMDTEXT As String = "SELECT * FROM MODEL_EXPLORER WHERE ID=" & Me._ID
            Using DT As Data.DataTable = Connection.GetDataTable(CMDTEXT)
                Dim DR() As Data.DataRow = DT.Select("")
                If DR.Length > 0 Then
                    Me.ID = DR(0).Item("ID").ToString
                    Me.Version = DR(0).Item("VERSION").ToString
                    Me.ParentID = DR(0).Item("PARENT_ID").ToString
                    Me.ModelName = DR(0).Item("NAME").ToString
                    Me.TreePath = DR(0).Item("PATH").ToString
                    Me.Status = CBool(DR(0).Item("STATUS"))
                    Me.Compiled = CBool(DR(0).Item("COMPILED"))

                    If Not IsDBNull(DR(0).Item("VBCODE")) Then
                        Me.SourceCode = DR(0).Item("VBCODE").ToString
                    End If
                    If Not IsDBNull(DR(0).Item("COUNTRY_ID")) Then
                        Me.ComboBox_Country.Text = Me._DTCountry.Select("COUNTRY_ID=" & DR(0).Item("COUNTRY_ID").ToString)(0).Item("NAME").ToString
                    End If
                    If Not IsDBNull(DR(0).Item("TRACK_TYPE")) Then
                        Select Case DR(0).Item("TRACK_TYPE").ToString
                            Case "GR"
                                Me.ComboBox_Type.Text = "Greyhounds"
                            Case "H"
                                Me.ComboBox_Type.Text = "Harness"
                            Case "G"
                                Me.ComboBox_Type.Text = "Gallops"
                            Case Else
                                Me.ComboBox_Type.Text = String.Empty
                        End Select
                    End If
                    If Not IsDBNull(DR(0).Item("VENUE_ID")) Then
                        Me.ComboBox_Venue.Text = Me._DT_Venue.Select("(COUNTRY_ID=" & Me._Country & ") AND (TRACK_TYPE='" & Me._Type & "') AND (VENUE_ID=" & DR(0).Item("VENUE_ID").ToString & ")")(0).Item("NAME").ToString
                    End If
                    If Not IsDBNull(DR(0).Item("LENGTH")) Then
                        Me.ComboBox_Length.Text = DR(0).Item("LENGTH").ToString
                    End If
                End If
            End Using
        End Sub
        Friend Sub Save()
            Me._Version = Date.Now.ToOADate.ToString
            Me.TB_Version.Text = Me._Version

            Dim CMDTEXT As String = ""

            CMDTEXT += "UPDATE MODEL_EXPLORER SET "
            CMDTEXT += "[PATH]=N'" & Trim(Me._TreePath) & "', "
            CMDTEXT += "[NAME]=N'" & Trim(Me._Name) & "', "
            CMDTEXT += "[PARENT_ID]=" & Me._ParentID & ", "
            CMDTEXT += "[LEVEL]=" & Split(Me._TreePath, "\").Length & ", "

            If Me._Country <> String.Empty Then CMDTEXT += "[COUNTRY_ID]=" & Me._Country & ", " Else CMDTEXT += "[COUNTRY_ID]=NULL, "
            If Me._Type <> String.Empty Then CMDTEXT += "[TRACK_TYPE]=N'" & Me._Type & "', " Else CMDTEXT += "[TRACK_TYPE]=NULL, "
            If Me._Venue <> String.Empty Then CMDTEXT += "[VENUE_ID]=" & Me._Venue & ", " Else CMDTEXT += "[VENUE_ID]=NULL, "
            If Me._Length <> String.Empty Then CMDTEXT += "[LENGTH]=" & Me._Length & ", " Else CMDTEXT += "[LENGTH]=NULL, "
            If Me._SourceCode <> String.Empty Then CMDTEXT += "[VBCODE]='" & Replace(Me.SourceCode, "'", "' + CHAR(39) + '") & "', " Else CMDTEXT += "[VBCODE]=NULL, "

            CMDTEXT += "[VERSION]=" & Me._Version & ", "
            CMDTEXT += "[COMPILED]=" & CInt(Me._Compiled).ToString & ", "
            CMDTEXT += "[STATUS]=" & CInt(Me._Status).ToString & " "
            CMDTEXT += "WHERE ID=" & Me._ID

            Using Connection As New Utils.Connection
                Call Connection.Execute(CMDTEXT)
            End Using
            Me._RequiresSaving = False
        End Sub
        Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Timer.Tick
            Me.Timer.Stop()
            If Me._RequiresSaving Then
                Call Me.Save()
            End If
            Me.Timer.Start()
        End Sub
    End Class
End Namespace