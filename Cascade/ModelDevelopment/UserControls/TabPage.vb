Namespace ModelDevelopment.UserControls
    Friend NotInheritable Class TabPage
        Friend UC_Results As UC_RESULTS
        Friend Properties As New ModelProperties
        '
        Private Shared This_Compiled As Boolean = True
        '
        Private WithEvents MY_LINE_NUMBERS As New UserControls.LineNumbers_For_RichTextBox
        Private Loading As Boolean = True
        '
        Private MY_MAINFORM As FORM_MODELDEVELOPMENT
        Friend Sub New(ByRef FrmModelDevelopment As FORM_MODELDEVELOPMENT)
            InitializeComponent()
            '
            MY_MAINFORM = FrmModelDevelopment
            Me.TC_OUTPUT_TP_SOURCE.Controls.Add(RichTextBoxCode)
            MY_LINE_NUMBERS.BackColor = System.Drawing.Color.White
            MY_LINE_NUMBERS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            MY_LINE_NUMBERS.ForeColor = System.Drawing.Color.DarkCyan
            MY_LINE_NUMBERS.Location = New System.Drawing.Point(0, 0)
            MY_LINE_NUMBERS.Margin = New System.Windows.Forms.Padding(0)
            MY_LINE_NUMBERS.Name = "LineNumbers_For_RichTextBox1"
            MY_LINE_NUMBERS.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
            MY_LINE_NUMBERS.Size = New System.Drawing.Size(23, 192)
            MY_LINE_NUMBERS.TabIndex = 1
            MY_LINE_NUMBERS.ParentRichTextBox = Me.RichTextBoxCode
            MY_LINE_NUMBERS.AutoSize = True
            MY_LINE_NUMBERS.BorderLines_Style = Drawing2D.DashStyle.Solid
            MY_LINE_NUMBERS.GridLines_Color = Color.Transparent
            MY_LINE_NUMBERS.GridLines_Thickness = 1
            MY_LINE_NUMBERS.LineNrs_AntiAlias = True
            MY_LINE_NUMBERS.LineNrs_LeadingZeroes = False
            MY_LINE_NUMBERS.MarginLines_Color = Color.DarkGray
            MY_LINE_NUMBERS.MarginLines_Side = UserControls.LineNumbers_For_RichTextBox.LineNumberDockside.Right
            MY_LINE_NUMBERS.MarginLines_Style = Drawing2D.DashStyle.Solid
            MY_LINE_NUMBERS.MarginLines_Thickness = 1
            MY_LINE_NUMBERS.Show_BackgroundGradient = False
            MY_LINE_NUMBERS.Show_BorderLines = False
            MY_LINE_NUMBERS.Show_GridLines = False
            MY_LINE_NUMBERS.Show_MarginLines = True
            '
            UC_Results = New UC_RESULTS : UC_Results.Dock = DockStyle.Fill
            Me.TC_OUTPUT_TP_RESULTS.Controls.Add(UC_Results)
            '
            Me.Controls.Add(Me.TC_OUTPUT)
            '
            Properties.MY_LIST_OF_TYPES.Add("")
            If My.Settings.LoadGreyhounds Then Properties.MY_LIST_OF_TYPES.Add("GR")
            If My.Settings.LoadHarness Then Properties.MY_LIST_OF_TYPES.Add("H")
            If My.Settings.LoadGallops Then Properties.MY_LIST_OF_TYPES.Add("G")
            Call Converters.TYPEListTypeConverter.SetList(Properties.MY_LIST_OF_TYPES)
            '
            For Each ROW As Data.DataRow In Cascade.StoredProcedures.BetType.GetDataTable(FORM_MODELDEVELOPMENT.Connection).Select("")
                Properties.MY_LIST_OF_BACKINGS.Add(CStr(ROW.Item("TYPE")))
            Next ROW
            Call Converters.BACKINGListTypeConverter.SetList(Properties.MY_LIST_OF_BACKINGS)
            '
            Call Properties.Fill_COUNTRY_Property()
            Call Properties.Fill_WEATHER_Property("")
            Call Properties.Fill_TRACK_Property("")
            '
            Me.PROPERTIESGRID.SelectedObject = Properties
            Me.Loading = False
        End Sub
        Friend Sub New(ByVal ExplorerID As String, ByRef FrmModelDevelopment As FORM_MODELDEVELOPMENT)
            Me.New(FrmModelDevelopment)
            '
            Dim DR() As Data.DataRow
            Dim CMDTEXT As String = "SELECT * FROM MODEL_EXPLORER WHERE MODEL_EXPLORER_ID=" & ExplorerID
            DR = FORM_MODELDEVELOPMENT.Connection.GetDataTable(CMDTEXT).Select("")
            '
            If DR.Length > 0 Then
                Properties.ID = CLng(DR(0).Item("MODEL_EXPLORER_ID"))
                Properties.PARENTID = CLng(DR(0).Item("PARENT_EXPLORER_ID"))
                Properties.NAME = Trim(CStr(DR(0).Item("NAME")))
                Me.Text = Properties.NAME
                Me.Name = Properties.NAME
                Me.Tag = Properties.ID
                '
                Dim NODE() As TreeNode = MY_MAINFORM.TV_MODELS.Nodes.Find(CStr(DR(0).Item("MODEL_EXPLORER_ID")), True)
                Properties.TREEPATH = NODE(0).Parent.FullPath
                '
                If Not IsDBNull(DR(0).Item("MEETING_COUNTRY")) Then Properties.MEETING_COUNTRY = Trim(CStr(DR(0).Item("MEETING_COUNTRY")))
                If Not IsDBNull(DR(0).Item("MEETING_TYPE")) Then Properties.MEETING_TYPE = Trim(CStr(DR(0).Item("MEETING_TYPE")))
                '
                If Not IsDBNull(DR(0).Item("RACE_LENGTH")) Then Properties.LENGTH = Trim(CStr(DR(0).Item("RACE_LENGTH")))
                If Not IsDBNull(DR(0).Item("RACE_TRACK")) Then Properties.TRACK = Trim(CStr(DR(0).Item("RACE_TRACK")))
                If Not IsDBNull(DR(0).Item("RACE_VENUE")) Then Properties.VENUE = Trim(CStr(DR(0).Item("RACE_VENUE")))
                If Not IsDBNull(DR(0).Item("RACE_WEATHER")) Then Properties.WEATHER = Trim(CStr(DR(0).Item("RACE_WEATHER")))
                If Not IsDBNull(DR(0).Item("RACE_RIR_GTE")) Then Properties.RunnersInRaceGTE = Trim(CStr(DR(0).Item("RACE_RIR_GTE")))
                If Not IsDBNull(DR(0).Item("RACE_RIR_LTE")) Then Properties.RunnersInRaceLTE = Trim(CStr(DR(0).Item("RACE_RIR_LTE")))
                '
                If Not IsDBNull(DR(0).Item("BACKING")) Then Properties.BACKING = Trim(CStr(DR(0).Item("BACKING")))
                If Not IsDBNull(DR(0).Item("VBCODE")) Then Properties.VBCODE = Trim(CStr(DR(0).Item("VBCODE"))) : Me.RichTextBoxCode.Text = Properties.VBCODE
                Properties.VERSION = CDec(DR(0).Item("VERSION"))
                Properties.STATUS = CBool(DR(0).Item("STATUS"))
                '
                If Not IsDBNull(DR(0).Item("NOTES")) Then
                    Me.TC_OUTPUT_TP_NOTES_TB_NOTES.Text = CStr(DR(0).Item("NOTES"))
                End If
            End If
            Properties.Fill_LENGTHProperty(Properties.MEETING_TYPE, Properties.MEETING_COUNTRY, Properties.VENUE)
            Properties.Fill_TRACK_Property(Properties.MEETING_TYPE)
            Properties.Fill_WEATHER_Property(Properties.MEETING_TYPE)
            '
            Me.PROPERTIESGRID.SelectedObject = Properties
            Me.Loading = False
        End Sub
        Friend Sub Save()
            ' Let the calling method handle Status updates and exceptions.
            Properties.VBCODE = Me.RichTextBoxCode.Text
            Properties.VERSION = CDec(Now.ToOADate)

            '
            ' Save the fact we saved this model in the MODEL_LOG Table, Saving is carried out in the UpdateRow Method.
            Call StoredProcedures.ModelExplorer.UpdateRow(Me)
            '
            ' If any modified code has not been test compiled, then we have to compile test it for errors, else all models will fail
            ' as the main compiler will fail and no model will ever be found.
            If RuntimeCompiler.CompileCode(MY_MAINFORM, Me, RuntimeCompiler.ModelExplorerDR(FORM_MODELDEVELOPMENT.Connection, Properties.ID), FORM_MODELDEVELOPMENT.Connection) Is Nothing Then
                This_Compiled = False
                MessageBox.Show("The code for " & Me.Name & " was successfully saved.  However there are errors in the code, which can cause the Model Run to fail completely.  Please correct the errors and try again", "Errors happened compiling code.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                Me.TC_OUTPUT.SelectedTab = Me.TC_OUTPUT_TP_ERRORS
            Else
                This_Compiled = True
            End If
        End Sub
        Private Sub RichTextBoxCode_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RichTextBoxCode.TextChanged
            If Loading Then Exit Sub
            This_Compiled = False : MY_MAINFORM.STATUSSTRIP.TSSLStatus.Text = "Compile Required" : MY_MAINFORM.STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
            If Me.RichTextBoxCode.CanUndo Then MY_MAINFORM.TSB_Undo.Enabled = True Else MY_MAINFORM.TSB_Undo.Enabled = False
            If Me.RichTextBoxCode.CanRedo Then MY_MAINFORM.TSB_Redo.Enabled = True Else MY_MAINFORM.TSB_Redo.Enabled = False
        End Sub
        Private Sub TC_OUTPUT_TP_NOTES_TB_NOTES_TextChanged(sender As Object, e As EventArgs) Handles TC_OUTPUT_TP_NOTES_TB_NOTES.TextChanged
            If Loading Then Return
            '
            Me.Cursor = Cursors.AppStarting
            Dim CMDTEXT As String = "UPDATE MODEL_EXPLORER SET NOTES=N'" & Replace(Me.TC_OUTPUT_TP_NOTES_TB_NOTES.Text, "'", "' + CHAR(39) + '") & "' "
            CMDTEXT += "WHERE MODEL_EXPLORER_ID=" & Properties.ID
            Call FORM_MODELDEVELOPMENT.Connection.Execute(CMDTEXT)
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub PROPERTIESGRID_PropertyValueChanged(s As Object, e As PropertyValueChangedEventArgs) Handles PROPERTIESGRID.PropertyValueChanged
            Me.Cursor = Cursors.WaitCursor
            '
            Dim GridItem As Windows.Forms.GridItem = e.ChangedItem
            Select Case GridItem.Label.ToUpperInvariant
                Case "MEETING_TYPE"
                    Properties.MEETING_COUNTRY = Nothing
                    Properties.LENGTH = Nothing : Properties.VENUE = Nothing : Properties.TRACK = Nothing : Properties.WEATHER = Nothing
                    '
                    Call Properties.Fill_COUNTRY_Property()
                    Exit Select
                Case "MEETING_COUNTRY"
                    Properties.LENGTH = Nothing : Properties.VENUE = Nothing : Properties.TRACK = Nothing : Properties.WEATHER = Nothing
                    '
                    Properties.Fill_VENUEProperty(Properties.MEETING_TYPE, Properties.MEETING_COUNTRY)
                    Properties.Fill_LENGTHProperty(Properties.MEETING_TYPE, GridItem.Value.ToString)
                    Exit Select
                Case "VENUE"
                    Properties.LENGTH = Nothing
                    Call Properties.Fill_LENGTHProperty(Properties.MEETING_TYPE, Properties.MEETING_COUNTRY, GridItem.Value.ToString)
                    Exit Select
                Case "NAME"
                    Properties.NAME = CStr(GridItem.Value)
                    MY_MAINFORM.TV_MODELS.SelectedNode.Text = Properties.NAME
                    For Each TabPage As TabPage In MY_MAINFORM.TC_Main.TabPages
                        If TabPage.Tag Is Nothing Then Continue For
                        If CStr(TabPage.Tag) = CStr(MY_MAINFORM.TV_MODELS.SelectedNode.Name) Then TabPage.Text = Properties.NAME : Exit For
                    Next TabPage
                    Exit Select
                Case "RUNNERSINRACEGTE"
                    Properties.RunnersInRaceGTE = CStr(GridItem.Value)
                    If Properties.RunnersInRaceGTE = "" Then Properties.RunnersInRaceGTE = Nothing
                    Exit Select
                Case "RUNNERSINRACEGTE"
                    Properties.RunnersInRaceLTE = CStr(GridItem.Value)
                    If Properties.RunnersInRaceLTE = "" Then Properties.RunnersInRaceLTE = Nothing
            End Select
            '
            Call StoredProcedures.ModelExplorer.UpdateRow(Me)
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub CMS_RICHTEXTBOX_COPY_Click(sender As Object, e As EventArgs) Handles CMS_RICHTEXTBOX_COPY.Click
            Me.RichTextBoxCode.Copy()
        End Sub
        Private Sub CMS_RICHTEXTBOX_PASTE_Click(sender As Object, e As EventArgs) Handles CMS_RICHTEXTBOX_PASTE.Click
            Me.RichTextBoxCode.Paste()
        End Sub
        Private Sub CMS_RICHTEXTBOX_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles CMS_RICHTEXTBOX.Opening
            Dim Formats() As String = Clipboard.GetDataObject.GetFormats
            If Formats.Contains("System.String") OrElse Formats.Contains("UnicodeText") OrElse Formats.Contains("Text") OrElse Formats.Contains("Rich Text Format") Then
                Me.CMS_RICHTEXTBOX_PASTE.Enabled = True
            Else
                Me.CMS_RICHTEXTBOX_PASTE.Enabled = False
            End If
            If Me.RichTextBoxCode.SelectedText.Length > 0 Then
                Me.CMS_RICHTEXTBOX_COPY.Enabled = True
                Me.CMS_RICHTEXTBOX_CUT.Enabled = True
            Else
                Me.CMS_RICHTEXTBOX_COPY.Enabled = False
                Me.CMS_RICHTEXTBOX_CUT.Enabled = False
            End If
        End Sub
        Private Sub CMS_RICHTEXTBOX_CUT_Click(sender As Object, e As EventArgs) Handles CMS_RICHTEXTBOX_CUT.Click
            Me.RichTextBoxCode.Cut()
        End Sub
    End Class
End Namespace