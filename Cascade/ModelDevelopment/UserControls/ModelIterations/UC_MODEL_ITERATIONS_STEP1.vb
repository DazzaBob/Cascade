' MY_CONNECTION is passed in from FORM MODEL DEVELOPMENT.
Namespace ModelDevelopment.UserControls.ModelIterations
    Friend NotInheritable Class UC_MODEL_ITERATIONS_STEP1
        Private MY_FRM_MODEL_ITERATIONS As Controls.FRM_MODEL_ITERATIONS
        Private MY_CONNECTION As Connection
        Friend Sub New(ByRef ModelIterations As Controls.FRM_MODEL_ITERATIONS, ByVal Connection As Connection)
            InitializeComponent()
            MY_FRM_MODEL_ITERATIONS = ModelIterations
            MY_CONNECTION = Connection
            Me.DTP_FROM.Value = Date.FromOADate(Date.Today.ToOADate - (365 * 2))
            Me.DTP_TO.Value = Date.Today
        End Sub
        Private Sub UC_MODEL_ITERATIONS_STEP1_Load(sender As Object, e As EventArgs) Handles Me.Load
            Me.CMB_TYPE.Items.Add("")
            If My.Settings.LoadGreyhounds Then Me.CMB_TYPE.Items.Add("GR")
            If My.Settings.LoadGallops Then Me.CMB_TYPE.Items.Add("G")
            If My.Settings.LoadHarness Then Me.CMB_TYPE.Items.Add("H")
        End Sub
        Private Sub CMB_TYPE_SelectedValueChanged(sender As Object, e As EventArgs) Handles CMB_TYPE.SelectedValueChanged
            Me.Cursor = Cursors.WaitCursor
            '
            If Me.CMB_TYPE.Text = "" Then Me.Cursor = Cursors.Default : Return
            '
            Me.CMB_VENUE.Items.Clear()
            Me.CMB_VENUE.Items.Add("")
            Dim CMDTEXT As String = "SELECT DISTINCT RACE_INFO.VENUE "
            CMDTEXT += "FROM MEETING_INFO INNER JOIN RACE_INFO ON MEETING_INFO.OADATE = RACE_INFO.MEETING_INFO_OADATE AND MEETING_INFO.NUMBER = RACE_INFO.MEETING_INFO_NUMBER "
            CMDTEXT += "WHERE MEETING_INFO.TYPE=N'" & Me.CMB_TYPE.Text & "'"
            '
            For Each ROW As Data.DataRow In MY_CONNECTION.GetDataTable(CMDTEXT).Select("")
                Me.CMB_VENUE.Items.Add(ROW.Item("VENUE").ToString)
            Next ROW
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub ButNext_Click(sender As Object, e As EventArgs) Handles ButNext.Click
            If Me.TB_RACES.Text = "" Then MessageBox.Show("RACES is a required field, suggested value is: 500", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) : Return
            If Me.TB_PLACE_PERCENTAGE.Text = "" Then MessageBox.Show("PLACE % is a required field, suggested value is: 80", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) : Return
            If Me.TB_RACESRETURNED.Text = "" Then MessageBox.Show("RACES RETURNED is a required field, suggested value is: 36 for a 3 year period", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) : Return
            '
            If Me.CMB_TYPE.Text = "" Then MessageBox.Show("TYPE is a required field", "Required Field Missing", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) : Return
            '
            MY_FRM_MODEL_ITERATIONS.RACES = Me.TB_RACES.Text
            MY_FRM_MODEL_ITERATIONS.PLACEPERCENT = Me.TB_PLACE_PERCENTAGE.Text
            MY_FRM_MODEL_ITERATIONS.RACESRETURNED = Me.TB_RACESRETURNED.Text
            MY_FRM_MODEL_ITERATIONS.TYPE = Me.CMB_TYPE.Text
            MY_FRM_MODEL_ITERATIONS.VENUE = Me.CMB_VENUE.Text
            MY_FRM_MODEL_ITERATIONS.EVALFROM = Me.DTP_FROM.Value
            MY_FRM_MODEL_ITERATIONS.EVALTO = Me.DTP_TO.Value
            '
            MY_FRM_MODEL_ITERATIONS.Step1Complete()
        End Sub
    End Class
End Namespace