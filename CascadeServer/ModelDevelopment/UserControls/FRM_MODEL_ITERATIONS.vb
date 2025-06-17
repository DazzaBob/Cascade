' MY_CONNECTION is passed in from MODEL DEVELOPMENT
Namespace ModelDevelopment.Controls
    Friend Class FRM_MODEL_ITERATIONS
        Friend MODELEXPLORER_DR As Data.DataRow
        '
        Friend RACES As String
        Friend PLACEPERCENT As String
        Friend RACESRETURNED As String
        Friend EVALFROM As Date
        Friend EVALTO As Date
        Friend TYPE As String
        Friend VENUE As String
        '
        Private STEP1 As UserControls.ModelIterations.UC_MODEL_ITERATIONS_STEP1
        Private MODEL_FIND As UserControls.ModelIterations.UC_MODEL_FINDER
        Private MY_CONNECTION As Utils.Connection
        Friend Sub New(ByVal ModelExplorerDR As Data.DataRow, ByVal Connection As Utils.Connection)
            InitializeComponent()
            '
            MODELEXPLORER_DR = ModelExplorerDR
            MY_CONNECTION = Connection
        End Sub
        Private Sub FRM_MODEL_ITERATIONS_Load(sender As Object, e As EventArgs) Handles Me.Load
            STEP1 = New UserControls.ModelIterations.UC_MODEL_ITERATIONS_STEP1(Me, MY_CONNECTION)
            Me.Width = STEP1.Width + 25
            Me.Controls.Add(STEP1)
        End Sub
        Friend Sub Step1Complete()
            Me.Controls.Remove(STEP1)
            '
            MODEL_FIND = New UserControls.ModelIterations.UC_MODEL_FINDER(Me, MY_CONNECTION)
            Me.Width = MODEL_FIND.Width + 25
            Me.Height = MODEL_FIND.Height + 50
            '
            MODEL_FIND.Dock = DockStyle.Fill
            Me.Controls.Add(MODEL_FIND)
            MODEL_FIND.START()
        End Sub
    End Class
End Namespace