Imports System.CodeDom.Compiler
Imports CascadeModelDevelopment.ModelDevelopment
Imports CascadeModelDevelopment.Utils
Imports Microsoft.CodeAnalysis

Partial Class FrmMain
    Friend Class ToolStripMenuClass
        Friend Shared Sub TSB_DisableButtons(FrmMain As FrmMain)
            FrmMain.STARTToolStripMenuItem.Enabled = False
            FrmMain.TSB_STOP.Enabled = False
            FrmMain.TSB_Undo.Enabled = False
            FrmMain.TSB_Redo.Enabled = False
            FrmMain.TSBCommentOut.Enabled = False
            FrmMain.TSBNavigateBack.Enabled = False
            FrmMain.TSBNavigateForward.Enabled = False
            FrmMain.TSBUncomment.Enabled = False
        End Sub
        Friend Shared Sub TSB_Enable_Base_Buttons(FrmMain As FrmMain)
            FrmMain.STARTToolStripMenuItem.Enabled = True
            FrmMain.TSBCommentOut.Enabled = True
            FrmMain.TSBNavigateBack.Enabled = True
            FrmMain.TSBNavigateForward.Enabled = True
            FrmMain.TSBUncomment.Enabled = True
        End Sub
        Friend Shared Sub TSBCommentOut_Click(FrmMain As FrmMain)
            Dim TP As UserControls.UserControlTabPage = FrmMain.TabControlMain.SelectedTab
            If TP.UserControlModel.UCSource.RichTextBoxSource.SelectionLength = 0 Then
                Dim FirstCharOnLine As Integer = TP.UserControlModel.UCSource.RichTextBoxSource.GetFirstCharIndexOfCurrentLine
                With TP.UserControlModel.UCSource.RichTextBoxSource
                    .Select(FirstCharOnLine, 0)
                    .SelectedText = "'"
                End With
            Else
                Dim NewLine As String = ""
                Dim sLine() As String = Split(TP.UserControlModel.UCSource.RichTextBoxSource.SelectedText, vbLf)
                For X As Integer = 0 To sLine.Length - 1
                    sLine(X) = sLine(X).Insert(0, "'")
                    NewLine += sLine(X)
                    If X < (sLine.Length - 1) Then NewLine += vbLf
                Next X
                TP.UserControlModel.UCSource.RichTextBoxSource.SelectedText = NewLine
            End If
        End Sub
        Friend Shared Sub TSBUncomment_Click(FrmMain As FrmMain)
            Dim TP As UserControls.UserControlTabPage = FrmMain.TabControlMain.SelectedTab
            If TP.UserControlModel.UCSource.RichTextBoxSource.SelectionLength = 0 Then
                Dim FirstCharOnLine As Int32 = TP.UserControlModel.UCSource.RichTextBoxSource.GetFirstCharIndexOfCurrentLine
                With TP.UserControlModel.UCSource.RichTextBoxSource
                    .Select(FirstCharOnLine, 1)
                    .SelectedText = ""
                End With
            Else
                Dim NewLine As String = ""
                Dim sLine() As String = Split(TP.UserControlModel.UCSource.RichTextBoxSource.SelectedText, Environment.NewLine)
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
                TP.UserControlModel.UCSource.RichTextBoxSource.SelectedText = NewLine
            End If
        End Sub
        Friend Shared Sub TSB_TESTCOMPILE_Click(FrmMain As FrmMain, Connection As CascadeCommon.Utils.Connection)
            If MessageBox.Show("This will test compile, all models and open the first one found with an error for modification, if any errors are found, are you sure you want to continue?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly, False) = System.Windows.Forms.DialogResult.Cancel Then Exit Sub

            FrmMain.Cursor = Cursors.WaitCursor
            'FrmMain.tss StatusStrip.TSSPBProgress.Minimum = 0
            'StatusStrip.TSSPBProgress.Visible = True : StatusStrip.TSSPBProgress.Style = ProgressBarStyle.Continuous : Application.DoEvents()
            FrmMain.TSSLBLStatus.Text = "Searching ..." : FrmMain.TSSLBLStatus.Invalidate() : Application.DoEvents()

            Dim CMDTEXT As String = "SELECT * FROM MODEL_EXPLORER WHERE (NODE_TYPE = 2) AND (COMPILED=0) AND (NOT [VBCODE] IS NULL)"
            Using DT As Data.DataTable = Connection.GetDataTable(CMDTEXT)
                If DT.Rows.Count > 0 Then
                    'StatusStrip.TSSPBProgress.Maximum = DR.Count
                    'StatusStrip.TSSPBProgress.Value = 0
                    For X As Integer = 0 To DT.Rows.Count - 1
                        Dim ModelExplorerID As String = DT.Rows(X).Item("ID").ToString
                        If IsDBNull(DT.Rows(X).Item("VBCODE")) Then Continue For

                        Using RC As New CascadeCommon.RuntimeCompiler(Connection, ModelExplorerID, My.Application.Info.LoadedAssemblies)
                            Dim CompilerResults As IEnumerable(Of Diagnostic) = RC.DiagnoseCode

                            If CompilerResults IsNot Nothing Then
                                Dim NewTabPage As UserControls.UserControlTabPage = Nothing
                                If FrmMain.TabControlMain.TabPages.Count > 0 Then
                                    For Each TP As TabPage In FrmMain.TabControlMain.TabPages
                                        Dim UC As UserControls.Models.UserControlModel = TP.Controls(0)
                                        If UC.UCProperties.ID = DT.Rows(X).Item("ID").ToString Then
                                            NewTabPage = TP
                                            Exit For
                                        End If
                                    Next TP
                                Else
                                    NewTabPage = New UserControls.UserControlTabPage(ModelExplorerID, FrmMain)
                                    FrmMain.TabControlMain.TabPages.Add(NewTabPage)
                                End If

                                NewTabPage.UserControlModel.UCSource.RichTextBoxErrorList.Text = "The model has the following errors: " & Environment.NewLine
                                Dim LogErrors As String = String.Empty
                                For Each diagnostic As Diagnostic In CompilerResults
                                    LogErrors += vbTab & diagnostic.Id & " " & diagnostic.GetMessage() & Environment.NewLine
                                Next
                                NewTabPage.UserControlModel.UCSource.RichTextBoxErrorList.Text += LogErrors
                                NewTabPage.UserControlModel.UCProperties.Compiled = False
                            Else
                                If FrmMain.TabControlMain.TabPages.Count > 0 Then
                                    For Each TP As TabPage In FrmMain.TabControlMain.TabPages
                                        Dim UC As UserControls.Models.UserControlModel = TP.Controls(0)
                                        If UC.UCProperties.ID = DT.Rows(X).Item("ID").ToString Then
                                            UC.UCProperties.Compiled = True
                                            Exit For
                                        End If
                                    Next TP
                                Else
                                    CMDTEXT = "UPDATE MODEL_EXPLORER SET COMPILED=1 WHERE ID=" & DT.Rows(X).Item("ID").ToString
                                    Call Connection.Execute(CMDTEXT)
                                End If
                            End If
                        End Using
                    Next X
                End If
            End Using
            '
            '           StatusStrip.TSSPBProgress.Visible = False : StatusStrip.TSSPBProgress.Style = ProgressBarStyle.Blocks : Application.DoEvents()
            FrmMain.TSSLBLStatus.Text = "Ready" : FrmMain.TSSLBLStatus.Invalidate() : Application.DoEvents()
            FrmMain.Cursor = Cursors.Default
        End Sub
        Friend Shared Sub STARTToolStripMenuItem_Click(FrmMain As FrmMain)
            FrmMain.Cursor = Cursors.WaitCursor
            FrmMain.TSB_STOP.Enabled = True

            Call Start(FrmMain, FrmMain.TabControlMain.SelectedTab)

            FrmMain.TSB_STOP.Enabled = False
            FrmMain.Cursor = Cursors.Default
        End Sub
        Friend Shared Sub Start(FrmMain As FrmMain, TabPage As UserControls.UserControlTabPage)

            If Not TabPage.UserControlModel.UCProperties.Compiled Then
                Call MessageBox.Show("Test Compile this model, before STARTing the model run!", "This model is not compiled!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            Dim StartDate As Int32 = CInt(Today.ToOADate - 8)
            Dim FinishDate As Int32 = CInt(Today.ToOADate - 1)

            Using NewSDTR As New CascadeCommon.FrmSelectRange
                If NewSDTR.ShowDialog(FrmMain) <> DialogResult.Cancel Then
                    StartDate = NewSDTR.DateTimePickerFrom.Value.ToOADate
                    FinishDate = NewSDTR.DateTimePickerTo.Value.ToOADate
                Else
                    FrmMain.TSSLBLStatus.Text = "Ready" : FrmMain.TSSLBLStatus.Invalidate()
                    Return
                End If
            End Using

            FrmMain.TSSLBLStatus.Text = "Collecting Records ..." : FrmMain.TSSLBLStatus.Invalidate()
            Call Application.DoEvents()

            Dim This_Model_Result_DT As Data.DataTable
            Call TabPage.UserControlModel.UCResults.ResetTotalsValues()

            Using ModelRun As ModelDevelopment.ModelRun = New ModelDevelopment.ModelRun(CStr(StartDate), CStr(FinishDate), TabPage.Properties.ID,
            Nothing, Me.STATUSSTRIP.TSSLStatus, Me.STATUSSTRIP.TSSPBProgress)
                Try
                    If Not ModelRun.HasErrors Then
                        This_Model_Result_DT = ModelRun.GetResults_DT

                        If This_Model_Result_DT.Rows.Count = 0 Then
                            MessageBox.Show("There are no records to display.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
                        Else
                            FrmMain.TSSLBLStatus.Text = "Preparing Results ..." : FrmMain.TSSLBLStatus.Invalidate()
                            ' Call TabPage.UC_Results.Populate(This_Model_Result_DT, StartDate, FinishDate, TabPage)
                        End If
                    End If
                Catch ex As Exception
                    ' do nothing
                End Try
            End Using

            FrmMain.TSSLBLStatus.Text = "Ready" : FrmMain.TSSLBLStatus.Invalidate() : Application.DoEvents()
            ' TC_OUTPUT.SelectedTab = TabPage.TC_OUTPUT_TP_RESULTS

            GC.Collect()
        End Sub
    End Class
End Class