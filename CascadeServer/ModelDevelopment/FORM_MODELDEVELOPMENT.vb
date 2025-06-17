Namespace ModelDevelopment
    Friend NotInheritable Class FORM_MODELDEVELOPMENT
        Private SearchAutoCompletestringcollection As New AutoCompleteStringCollection
        Private WithEvents MY_IMPORTFILE_DIALOG As OpenFileDialog
        Private Connection As Utils.Connection
        '
        Private MY_POPUP As PopUp
        Private MODELLIST As ModelDevelopment.Controls.UC_LISTLIVEMODELS
        Private MY_TVMAIN_COPY As TreeNode
        Private MY_TVMAIN_CURSOR_POSITION As Point
        Friend WithEvents STATUSSTRIP As Controls.UC_STATUSSTRIP
        '
        Private IsMouseDown As Boolean = False
        Friend Sub New()
            InitializeComponent()
            '
            Me.TextBoxSearch.AutoCompleteCustomSource = SearchAutoCompletestringcollection
            '
            MY_IMPORTFILE_DIALOG = New OpenFileDialog
            MY_IMPORTFILE_DIALOG.AddExtension = True
            MY_IMPORTFILE_DIALOG.AutoUpgradeEnabled = True
            MY_IMPORTFILE_DIALOG.DefaultExt = ".xml"
            MY_IMPORTFILE_DIALOG.Filter = "*.xml|XML Files|*.*|All Files"
            MY_IMPORTFILE_DIALOG.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            MY_IMPORTFILE_DIALOG.Title = "Import an Exported file."
            MY_IMPORTFILE_DIALOG.FileName = "*.xml"
            '
            Me.Connection = New Utils.Connection()
            '
            STATUSSTRIP = New Controls.UC_STATUSSTRIP
            STATUSSTRIP.Dock = DockStyle.Bottom
            STATUSSTRIP.RenderMode = ToolStripRenderMode.Professional
            '
            Me.Controls.Add(STATUSSTRIP)

            Me.TSB_OPENFILEDIALOG.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        End Sub
        Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            'Call Populate_TV_Solution() ' Populates the Solution Treeview
            Call Populate_TV_Objects() ' Populates the Objects Treview
        End Sub
        Private Sub TSMI_OBJECTS_COPY_Click(sender As Object, e As EventArgs) Handles TSMI_OBJECTS_COPY.Click
            Try
                If InStr(Me.TVObjects.SelectedNode.Text, " ") > 0 Then
                    Clipboard.SetText(Strings.Left(Me.TVObjects.SelectedNode.Text.ToUpper, InStr(Me.TVObjects.SelectedNode.Text, " ") - 1))
                Else
                    Clipboard.SetText(Me.TVObjects.SelectedNode.Text.ToUpperInvariant)
                End If
            Catch
                MessageBox.Show("Error copying the Item to the clipboard.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            End Try
        End Sub
        Private Sub TSBI_LISTLIVE_Click(sender As Object, e As EventArgs) Handles TSBI_LISTLIVE.Click
            MY_POPUP = New PopUp
            MY_POPUP.Size = New Size(800, 600)
            MY_POPUP.Text = "LIST LIVE MODELS"
            '
            MODELLIST = New ModelDevelopment.Controls.UC_LISTLIVEMODELS(Me)
            MODELLIST.Dock = DockStyle.Fill
            '
            MY_POPUP.Controls.Add(MODELLIST)
            MY_POPUP.Show(Me)
            '
            MODELLIST.Populate()
        End Sub
        Friend Sub Start(ByVal TabPage As UserControls.UC_TABPAGE)
            ' Cursor is changed in the calling method.
            Call TabPage.Save()

            If Not TabPage.Properties.COMPILED Then Return

            Dim StartDate As Int32 = CInt(Today.ToOADate - 8)
            Dim FinishDate As Int32 = CInt(Today.ToOADate - 1)

            Using NewSDTR As New FrmSelectRange
                If NewSDTR.ShowDialog(Me) <> DialogResult.Cancel Then
                    StartDate = NewSDTR.DateTimePickerFrom.Value.ToOADate
                    FinishDate = NewSDTR.DateTimePickerTo.Value.ToOADate
                Else
                    Me.STATUSSTRIP.TSSLStatus.Text = "Ready" : Application.DoEvents()
                    Return
                End If
            End Using

            Me.STATUSSTRIP.TSSLStatus.Text = "Collecting Records ..." : Application.DoEvents()

            Dim This_Model_Result_DT As Data.DataTable

            Me.STATUSSTRIP.TSSLStatus.Text = "Collecting Records ..." : Application.DoEvents()
            Call TabPage.UC_Results.Clear()
            Using ModelRun As ModelDevelopment.ModelRun = New ModelDevelopment.ModelRun(CStr(StartDate), CStr(FinishDate), TabPage.Properties.ID,
            Nothing, Me.STATUSSTRIP.TSSLStatus, Me.STATUSSTRIP.TSSPBProgress)
                Try
                    If Not ModelRun.HasErrors Then
                        This_Model_Result_DT = ModelRun.GetResults_DT
                        '
                        If This_Model_Result_DT.Rows.Count = 0 Then
                            MessageBox.Show("There are no records to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                        Else
                            Me.STATUSSTRIP.TSSLStatus.Text = "Preparing Results ..." : Me.STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
                            Call TabPage.UC_Results.Populate(This_Model_Result_DT, StartDate, FinishDate, TabPage)
                        End If
                    End If
                Catch ex As Exception
                    ' do nothing
                End Try
            End Using

            Me.STATUSSTRIP.TSSLStatus.Text = "Ready" : Me.STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
            TabPage.TC_OUTPUT.SelectedTab = TabPage.TC_OUTPUT_TP_RESULTS

            GC.Collect()
        End Sub

        Private Sub ButtonSearch_Click(sender As Object, e As EventArgs)
            If Me.TextBoxSearch.Text.Length = 0 Then Return
            Me.Cursor = Cursors.WaitCursor
            '
            If Not SearchAutoCompletestringcollection.Contains(Me.TextBoxSearch.Text) Then
                SearchAutoCompletestringcollection.Add(Me.TextBoxSearch.Text)
            End If
            '
            Dim Nodes() As TreeNode = Me.TV_MODELS.Nodes.Find(Me.TextBoxSearch.Text, True)
            If Nodes.Count > 0 Then
                Me.TV_MODELS.SelectedNode = Nodes(0)
            Else
                MessageBox.Show("Not found", "Model ID not found", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                Me.TextBoxSearch.SelectAll()
                Me.TextBoxSearch.Focus()
            End If
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TextBoxSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBoxSearch.KeyUp
            If e.KeyCode = Keys.Enter Then
                Call ButtonSearch_Click(sender, New EventArgs)
            End If
        End Sub
    End Class
End Namespace