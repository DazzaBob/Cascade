' Added just for readablity sake, the main class gets confusing to read with all the UI elements.
' MY_CONNECTION is declared in FORM_MODELDEVELOPMENT
Namespace ModelDevelopment
    Partial Class FORM_MODELDEVELOPMENT
        Private MY_TREENODES_CHECKED As Boolean = False
        Private Sub TSBSave_Click(sender As Object, e As EventArgs) Handles TSBSave.Click, CMSTabControl_SaveThis.Click
            ' This method saves the currently selected model.
            If Me.TC_Main.TabPages.Count = 0 Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            '
            STATUSSTRIP.TSSPBProgress.Visible = True : STATUSSTRIP.TSSPBProgress.Style = ProgressBarStyle.Marquee : Application.DoEvents()
            STATUSSTRIP.TSSLStatus.Text = "Saving ..." : STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
            '
            Dim TP As UserControls.UC_TABPAGE = Me.TC_Main.SelectedTab
            If TP IsNot Nothing Then TP.Save()
            '
            STATUSSTRIP.TSSLStatus.Text = "Ready" : STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
            STATUSSTRIP.TSSPBProgress.Style = ProgressBarStyle.Blocks : STATUSSTRIP.TSSPBProgress.Visible = False : Application.DoEvents()
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TSBSaveAll_Click(sender As Object, e As EventArgs) Handles TSBSaveAll.Click
            If Me.TC_Main.TabPages.Count = 0 Then Return
            '
            Me.Cursor = Cursors.WaitCursor
            '
            STATUSSTRIP.TSSPBProgress.Visible = True
            STATUSSTRIP.TSSPBProgress.Style = ProgressBarStyle.Continuous
            STATUSSTRIP.TSSLStatus.Text = "Saving ..." : STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
            '
            For Each TabPage As UserControls.UC_TABPAGE In Me.TC_Main.TabPages
                TabPage.Save()
            Next TabPage
            '
            STATUSSTRIP.TSSLStatus.Text = "Ready" : STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
            STATUSSTRIP.TSSPBProgress.Style = ProgressBarStyle.Blocks
            STATUSSTRIP.TSSPBProgress.Visible = False
            '
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TSB_DisableButtons()
            Me.STARTToolStripMenuItem.Enabled = False
            Me.TSB_STOP.Enabled = False
            Me.TSB_Undo.Enabled = False
            Me.TSB_Redo.Enabled = False
            Me.TSDDBClose.Enabled = False
            Me.TSBCommentOut.Enabled = False
            Me.TSBNavigateBack.Enabled = False
            Me.TSBNavigateForward.Enabled = False
            Me.TSBSave.Enabled = False
            Me.TSBSaveAll.Enabled = False
            Me.TSBUncomment.Enabled = False
        End Sub
        Private Sub TSB_Enable_Base_Buttons()
            Me.STARTToolStripMenuItem.Enabled = True
            Me.TSBCommentOut.Enabled = True
            Me.TSDDBClose.Enabled = True
            Me.TSBNavigateBack.Enabled = True
            Me.TSBNavigateForward.Enabled = True
            Me.TSBSave.Enabled = True
            Me.TSBSaveAll.Enabled = True
            Me.TSBUncomment.Enabled = True
        End Sub
        Private Sub TSB_OpenFile_Click(sender As Object, e As EventArgs) Handles TSB_OpenFile.Click
            Me.TSB_OPENFILEDIALOG.ShowDialog()
        End Sub
        Private Sub TSB_OpenFileDialog_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TSB_OPENFILEDIALOG.FileOk
            If e.Cancel Then Return
            Me.Cursor = Cursors.WaitCursor
            Shell("NOTEPAD.EXE " & Me.TSB_OPENFILEDIALOG.FileName, AppWinStyle.NormalFocus, False)
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TSDDBClose_Click(sender As Object, e As EventArgs) Handles TSDDBClose.Click
            If Me.TC_Main.TabPages.Count = 0 Then Return
            '
            Me.CMS_TC_MAIN.Visible = False
            '
            Me.CMSTabControl_SaveThis.Visible = False
            Me.CMSTabControlDivider.Visible = False
            '
            Me.CMS_TC_MAIN.Visible = True
        End Sub
        Private Sub TSBCommentOut_Click(sender As Object, e As EventArgs) Handles TSBCommentOut.Click
            Dim TP As UserControls.UC_TABPAGE = Me.TC_Main.SelectedTab
            If TP.RichTextBoxCode.SelectionLength = 0 Then
                Dim FirstCharOnLine As Int32 = TP.RichTextBoxCode.GetFirstCharIndexOfCurrentLine
                With TP.RichTextBoxCode
                    .Select(FirstCharOnLine, 0)
                    .SelectedText = "'"
                End With
            Else
                Dim NewLine As String = ""
                Dim sLine() As String = Split(TP.RichTextBoxCode.SelectedText, vbLf)
                For X As Int32 = 0 To sLine.Length - 1
                    sLine(X) = sLine(X).Insert(0, "'")
                    NewLine += sLine(X)
                    If X < (sLine.Length - 1) Then NewLine += vbLf
                Next X
                TP.RichTextBoxCode.SelectedText = NewLine
            End If
        End Sub
        Private Sub TSBUncomment_Click(sender As Object, e As EventArgs) Handles TSBUncomment.Click
            Dim TP As UserControls.UC_TABPAGE = Me.TC_Main.SelectedTab
            If TP.RichTextBoxCode.SelectionLength = 0 Then
                Dim FirstCharOnLine As Int32 = TP.RichTextBoxCode.GetFirstCharIndexOfCurrentLine
                With TP.RichTextBoxCode
                    .Select(FirstCharOnLine, 1)
                    .SelectedText = ""
                End With
            Else
                Dim NewLine As String = ""
                Dim sLine() As String = Split(TP.RichTextBoxCode.SelectedText, vbLf)
                For X As Int32 = 0 To sLine.Length - 1
                    Try
                        Dim IndexOfFirstSingleQuote As Int32 = 0
                        IndexOfFirstSingleQuote = InStr(sLine(X), "'") + 1
                        sLine(X) = Strings.Mid(sLine(X), IndexOfFirstSingleQuote)
                    Catch ex As Exception
                        ' Do nothing    
                    End Try
                    NewLine += sLine(X)
                    If X < (sLine.Length - 1) Then NewLine += vbLf
                Next X
                TP.RichTextBoxCode.SelectedText = NewLine
            End If
        End Sub
        Private Sub TSB_Undo_Click(sender As Object, e As EventArgs) Handles TSB_Undo.Click
            Dim TP As UserControls.UC_TABPAGE = Me.TC_Main.SelectedTab
            TP.RichTextBoxCode.Undo()
        End Sub
        Private Sub TSB_Redo_Click(sender As Object, e As EventArgs) Handles TSB_Redo.Click
            Dim TP As UserControls.UC_TABPAGE = Me.TC_Main.SelectedTab
            TP.RichTextBoxCode.Redo
        End Sub
#Region "       START DROP DOWN MENU ITEMS"
        Private Sub STARTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STARTToolStripMenuItem.Click
            Me.Cursor = Cursors.WaitCursor
            Me.TSB_STOP.Enabled = True
            '
            Call Start(Me.TC_Main.SelectedTab)
            '
            Me.TSB_STOP.Enabled = False
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub STARTITERATIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STARTITERATIONToolStripMenuItem.Click
            Me.Cursor = Cursors.WaitCursor
            Dim TP As UserControls.UC_TABPAGE = Me.TC_Main.SelectedTab
            Dim CMDTEXT As String = "SELECT * FROM MODEL_EXPLORER WHERE MODEL_EXPLORER_ID=" & CStr(TP.Properties.ID)
            Dim DR() As Data.DataRow = Connection.GetDataTable(CMDTEXT).Select("")
            Using FRM_MODEL_ITERATIONS As New Controls.FRM_MODEL_ITERATIONS(DR(0), Connection)
                FRM_MODEL_ITERATIONS.ShowDialog(Me)
            End Using
            Me.Cursor = Cursors.Default
        End Sub
#End Region
        Private Sub TSB_STOP_Click(sender As Object, e As EventArgs) Handles TSB_STOP.Click
            Call ModelDevelopment.ModelRun.Cancel()
            Me.STARTToolStripMenuItem.Enabled = True
            Me.TSB_STOP.Enabled = False
        End Sub
        Private Sub TSBNavigateBack_Click(sender As Object, e As EventArgs) Handles TSBNavigateBack.Click
            If Me.TC_Main.SelectedIndex = 0 Then Return Else Me.TC_Main.SelectedIndex -= 1
        End Sub
        Private Sub TSBNavigateForward_Click(sender As Object, e As EventArgs) Handles TSBNavigateForward.Click
            If Me.TC_Main.SelectedIndex = Me.TC_Main.TabCount - 1 Then Return Else Me.TC_Main.SelectedIndex += 1
        End Sub
        Private Sub TSB_SELECTMODE_Click(sender As Object, e As EventArgs) Handles TSB_SELECTMODE.Click
            MY_TREENODES_CHECKED = False
            '
            If Me.TV_MODELS.CheckBoxes Then
                Me.TSB_SELECTMODE.Image = Nothing
                Me.TSB_SELECTMODE.ToolTipText = "Check boxes ON"
                '
                Me.TSB_SWITCHMODELOFF.Enabled = False
                Me.TSB_SWITCHMODELON.Enabled = False
            Else
                Me.TSB_SELECTMODE.ToolTipText = "Check boxes OFF"
                '
                Me.TSB_SWITCHMODELOFF.Enabled = True
                Me.TSB_SWITCHMODELON.Enabled = True
            End If
            If Not Me.TV_MODELS.CheckBoxes Then Me.TV_MODELS.CheckBoxes = True Else Me.TV_MODELS.CheckBoxes = False

            Me.TSB_SELECTMODE.Invalidate()
            '
            If Not Me.TSB_EXPORTTOFILE.Enabled Then
                Me.TSB_EXPORTTOFILE.Enabled = True
                Me.TSB_IMPORT.Enabled = False
            Else
                Me.TSB_EXPORTTOFILE.Enabled = False
                Me.TSB_IMPORT.Enabled = True
            End If
        End Sub
        Private Sub TSB_EXPORTTOFILE_Click(sender As Object, e As EventArgs) Handles TSB_EXPORTTOFILE.Click
            Me.Cursor = Cursors.WaitCursor
            MY_TREENODES_CHECKED = False
            For Each Node As TreeNode In Me.TV_MODELS.Nodes
                Call CheckForCheckedSubNodes(Node)
            Next
            If Not MY_TREENODES_CHECKED Then
                MessageBox.Show("There are no Nodes checked for exporting.  Check Nodes and try again.", "Nothing to do!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                Return
            End If
            Using ExportModels As New EXPORTMODELS(Me.TV_MODELS, Connection)
                Call ExportModels.Execute()
            End Using
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub CheckForCheckedSubNodes(ByVal TN As TreeNode)
            For Each Node As TreeNode In TN.Nodes
                If Node.Nodes.Count > 0 Then Call CheckForCheckedSubNodes(Node)
                If Node.Checked Then MY_TREENODES_CHECKED = True : Exit For
            Next
        End Sub
        Private Sub TSB_IMPORT_Click(sender As Object, e As EventArgs) Handles TSB_IMPORT.Click
            MY_IMPORTFILE_DIALOG.ShowDialog()
        End Sub
        Private Sub MY_IMPORTFILE_DIALOG_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MY_IMPORTFILE_DIALOG.FileOk
            Dim ValidXMLFile As Boolean = True
            Me.Cursor = Cursors.WaitCursor
            Using DT As New Data.DataTable
                DT.Locale = Globalization.CultureInfo.InvariantCulture
                Try
                    DT.ReadXml(Me.MY_IMPORTFILE_DIALOG.FileName)
                Catch EX As Exception
                    ValidXMLFile = False
                    MessageBox.Show("The file " & Me.MY_IMPORTFILE_DIALOG.FileName & " does not appear to be a valid XML file for model import." & Environment.NewLine & Environment.NewLine & "The following exception happened:" & Environment.NewLine & EX.Message, "Invalid File", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                End Try
                If ValidXMLFile Then
                    Using ImportModels As New IMPORTMODELS(DT, Connection)
                        Call ImportModels.Execute()
                    End Using
                    '
                    Call Me.CMS_TV_MODELS_REFRESH_Click(sender, e)
                    '
                    Dim Nodes() As TreeNode = Me.TV_MODELS.Nodes.Find("-6", True)
                    If Nodes.Length > 0 Then
                        Me.TV_MODELS.SelectedNode = Nodes(0)
                        Me.TV_MODELS.SelectedNode.EnsureVisible()
                        Me.TV_MODELS.SelectedNode.ExpandAll()
                    End If
                End If
                Me.Cursor = Cursors.Default
            End Using
        End Sub
        Private Sub TSB_SWITCHMODELOFF_Click(sender As Object, e As EventArgs) Handles TSB_SWITCHMODELOFF.Click
            MY_TREENODES_CHECKED = False
            For Each Node As TreeNode In Me.TV_MODELS.Nodes
                Call CheckForCheckedSubNodes(Node)
            Next
            If Not MY_TREENODES_CHECKED Then
                MessageBox.Show("There are no Nodes checked for switching OFF.  Check Nodes and try again.", "Nothing to do!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                Return
            Else
                MessageBox.Show("Any model that is currently open will not be updated!  Click OK to continue.", "Change Model Status: OFF - Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            End If
            '
            Me.Cursor = Cursors.WaitCursor
            Using SWITCHSTATUS As New SWITCHMODELSTATUS(Me.TV_MODELS, False, Connection)
                SWITCHSTATUS.Execute()
            End Using
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TSB_SWITCHMODELON_Click(sender As Object, e As EventArgs) Handles TSB_SWITCHMODELON.Click
            MY_TREENODES_CHECKED = False
            For Each Node As TreeNode In Me.TV_MODELS.Nodes
                Call CheckForCheckedSubNodes(Node)
            Next
            If Not MY_TREENODES_CHECKED Then
                MessageBox.Show("There are no Nodes checked for switching ON.  Check Nodes and try again.", "Nothing to do!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                Return
            Else
                MessageBox.Show("Any model that is currently open will not be updated!  Click OK to continue.", "Change Model Status: ON - Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            End If
            '
            Me.Cursor = Cursors.WaitCursor
            Using SWITCHSTATUS As New SWITCHMODELSTATUS(Me.TV_MODELS, True, Connection)
                SWITCHSTATUS.Execute()
            End Using
            Me.Cursor = Cursors.Default
        End Sub
        Private Sub TSB_TESTCOMPILE_Click(sender As Object, e As EventArgs) Handles TSB_TESTCOMPILE.Click
            If MessageBox.Show("This will test compile all models and open the first one found with an error for modification, if any errors are found, are you sure you want to continue?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = System.Windows.Forms.DialogResult.Cancel Then Exit Sub
            '
            Me.Cursor = Cursors.WaitCursor
            STATUSSTRIP.TSSPBProgress.Minimum = 0
            STATUSSTRIP.TSSPBProgress.Visible = True : STATUSSTRIP.TSSPBProgress.Style = ProgressBarStyle.Continuous : Application.DoEvents()
            STATUSSTRIP.TSSLStatus.Text = "Searching ..." : STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
            '
            Dim CMDTEXT As String = "SELECT * FROM MODEL_EXPLORER WHERE TREE_NODE_TYPE = 2"
            Dim DR() As Data.DataRow = Connection.GetDataTable(CMDTEXT).Select("")
            If DR.Length > 0 Then
                STATUSSTRIP.TSSPBProgress.Maximum = DR.Count
                STATUSSTRIP.TSSPBProgress.Value = 0
                For Each ROW As Data.DataRow In DR
                    Dim ModelExplorerID As String = CStr(ROW.Item("MODEL_EXPLORER_ID"))
                    If IsDBNull(ROW.Item("VBCODE")) Then Continue For
                    '
                    If RuntimeCompiler.CompileCode(Me, Nothing, RuntimeCompiler.ModelExplorerDR(Connection, ROW.Item("MODEL_EXPLORER_ID").ToString), Connection) Is Nothing Then
                        Me.TC_Main.TabPages.Add(New UserControls.UC_TABPAGE(ModelExplorerID, Me, Me.Connection))
                        Exit For
                    End If
                    STATUSSTRIP.TSSPBProgress.Value += 1 : Application.DoEvents()
                Next ROW
            End If
            '
            STATUSSTRIP.TSSPBProgress.Visible = False : STATUSSTRIP.TSSPBProgress.Style = ProgressBarStyle.Blocks : Application.DoEvents()
            STATUSSTRIP.TSSLStatus.Text = "Ready" : STATUSSTRIP.TSSLStatus.Invalidate() : Application.DoEvents()
            Me.Cursor = Cursors.Default
        End Sub
    End Class
End Namespace