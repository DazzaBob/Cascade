Namespace DisplayRace
    Friend NotInheritable Class UC_MODELS_METADATA
        Private MY_MODEL_ID As String
        Private MY_CONNECTION As Connection
        '
        Private FormLoading As Boolean = True
        Friend Sub New()
            InitializeComponent()
        End Sub
        Friend Sub New(ByVal modelexplorerID As String, ByVal connection As Connection)
            Me.New()
            '
            MY_MODEL_ID = modelexplorerID
            MY_CONNECTION = connection
        End Sub
        Private Sub ME_Load(sender As Object, e As EventArgs) Handles Me.Load
            Me.TB_LOGS.Text = Load_Log_String()
            Me.TB_NOTES.Text = Load_Notes_String()
            '
            FormLoading = False
        End Sub
        Private Sub TB_NOTES_TextChanged(sender As Object, e As EventArgs) Handles TB_NOTES.TextChanged
            If FormLoading Then Return
            '
            Me.Cursor = Cursors.AppStarting
            Dim CMDTEXT As String = "UPDATE MODEL_EXPLORER SET NOTES=N'" & Replace(Me.TB_NOTES.Text, "'", "' + CHAR(39) + '") & "' "
            CMDTEXT += "WHERE MODEL_EXPLORER_ID=" & MY_MODEL_ID
            Call MY_CONNECTION.Execute(CMDTEXT)
            Me.Cursor = Cursors.Default
        End Sub
        Private Function Load_Notes_String() As String
            Dim CMDTEXT As String = "SELECT NOTES FROM MODEL_EXPLORER WHERE (MODEL_EXPLORER_ID=" & MY_MODEL_ID & ")"
            Dim DR() As Data.DataRow = MY_CONNECTION.GetDataTable(CMDTEXT).Select("")
            If DR.Length = 0 Then Return ""
            '
            If Not IsDBNull(DR(0).Item("NOTES")) Then
                Return CStr(DR(0).Item("NOTES"))
            Else
                Return ""
            End If
        End Function
        Private Function Load_Log_String() As String
            Dim CMDTEXT As String = Nothing
            CMDTEXT = "SELECT OADATE, DESCRIPTION FROM MODEL_LOG WHERE (MODEL_EXPLORER_ID=" & MY_MODEL_ID & ") "
            CMDTEXT += "ORDER BY OADATE DESC"
            '
            Dim DR() As Data.DataRow = MY_CONNECTION.GetDataTable(CMDTEXT).Select("")
            If DR.Length = 0 Then Return "There is no history for this model yet."
            '
            Dim ReturnString As String = ""
            For Each ROW As Data.DataRow In DR
                ReturnString += FormatDateTime(Date.FromOADate(CDbl(ROW.Item("OADATE"))), DateFormat.GeneralDate) & " - " & CStr(ROW.Item("DESCRIPTION")) & Environment.NewLine
            Next
            Return ReturnString
        End Function
    End Class
End Namespace