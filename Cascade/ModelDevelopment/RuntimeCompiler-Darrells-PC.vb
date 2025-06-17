Imports System.Windows.Forms
Namespace ModelDevelopment
    Friend NotInheritable Class RuntimeCompiler
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared ReadOnly Property ModelExplorerDR(ByVal Connection As Connection, Optional ByVal ModelID As String = Nothing) As Data.DataRow()
            Get
                Dim CMDTEXT As String
                If Not ModelID Is Nothing AndAlso ModelID.Length > 0 Then
                    CMDTEXT = "SELECT * FROM MODEL_EXPLORER WHERE (MODEL_EXPLORER_ID=" & ModelID & ")"
                Else
                    CMDTEXT = "SELECT * FROM MODEL_EXPLORER WHERE ([STATUS]=1) AND ([TREE_NODE_TYPE]=2) AND (NOT [VBCODE] IS NULL)"
                End If
                Return Connection.GetDataTable(CMDTEXT).Select("")
            End Get
        End Property
        Friend Shared Function CompileCode(ByRef FormModelDevelopment As ModelDevelopment.FORM_MODELDEVELOPMENT, ByRef TabPage As UserControls.TabPage, ByVal ModelExplorerDR() As Data.DataRow, ByVal Connection As Connection) As CodeDom.Compiler.CompilerResults
            If FormModelDevelopment IsNot Nothing Then FormModelDevelopment.STATUSSTRIP.TSSLStatus.Text = "Compiling ..." : Application.DoEvents()
            If TabPage IsNot Nothing Then TabPage.ListViewErrorList.Items.Clear() : Application.DoEvents()
            '
            Dim CompilerResults As CodeDom.Compiler.CompilerResults = Nothing
            For Each ROW As Data.DataRow In ModelExplorerDR
                Call StoredProcedures.ModelExplorer.AddNewModelLog(ROW.Item("MODEL_EXPLORER_ID").ToString, "Model is being compiled.", Connection)
                '
                CompilerResults = CompileClass(VBClass(ModelExplorerDR))
                If CompilerResults Is Nothing Then
                    Call StoredProcedures.ModelExplorer.AddNewModelLog(ROW.Item("MODEL_EXPLORER_ID").ToString, "There was nothing to compile or the compiler had an error.", Connection)
                    If FormModelDevelopment IsNot Nothing Then FormModelDevelopment.STATUSSTRIP.TSSLStatus.Text = "Compile complete ..." : Application.DoEvents()
                    Return Nothing
                End If
                '
                If CompilerResults.Errors.Count > 0 Then
                    Dim LogErrors As String = "The model has the following errors: " & Environment.NewLine
                    '
                    Dim X As Integer = 1
                    For Each err As System.CodeDom.Compiler.CompilerError In CompilerResults.Errors
                        If TabPage IsNot Nothing Then Call AddErrorsToListView(err, X.ToString(InvariantCulture), TabPage)
                        LogErrors = String.Concat(LogErrors, "Line: " & CStr(err.Line - 10) & " " & err.ErrorText & Environment.NewLine)
                        X += 1
                    Next err
                    Call StoredProcedures.ModelExplorer.AddNewModelLog(ROW.Item("MODEL_EXPLORER_ID").ToString, LogErrors, Connection)
                    Call ServerUI.Messages.LogMessages(LogErrors, Cascade.BroadcastTypes.Error)
                    If FormModelDevelopment IsNot Nothing Then FormModelDevelopment.STATUSSTRIP.TSSLStatus.Text = "Compile completed, but with errors." : Application.DoEvents()
                    Return Nothing
                End If
                '
                If FormModelDevelopment IsNot Nothing Then FormModelDevelopment.STATUSSTRIP.TSSLStatus.Text = "Compile completed, correctly." : Application.DoEvents()
                Call StoredProcedures.ModelExplorer.AddNewModelLog(ROW.Item("MODEL_EXPLORER_ID").ToString, "Model compiled correctly.", Connection)
            Next ROW
            '
            Return CompilerResults
        End Function
        Private Shared ReadOnly Property VBClass(ByVal ModelExplorerDR() As Data.DataRow) As String
            ' Multiple Functions, generally from a model run.
            Get
                If (ModelExplorerDR Is Nothing) OrElse (ModelExplorerDR.Length = 0) Then Return Nothing
                Dim ThisClass As String
                ThisClass = "Imports System" & Environment.NewLine
                ThisClass = String.Concat(ThisClass, "Imports System.Data" & Environment.NewLine)
                ThisClass = String.Concat(ThisClass, "Imports Microsoft.VisualBasic" & Environment.NewLine)
                ThisClass = String.Concat(ThisClass, "Public Class Models" & Environment.NewLine)
                ThisClass = String.Concat(ThisClass, ControlChars.Tab & "Private Sub New()" & Environment.NewLine & ControlChars.Tab & ControlChars.Tab & "' Just so the compiler doesn't create a default constructor." & Environment.NewLine)
                ThisClass = String.Concat(ThisClass, ControlChars.Tab & "End Sub" & Environment.NewLine & ControlChars.Tab & "'" & Environment.NewLine)
                '
                For Each Row As Data.DataRow In ModelExplorerDR
                    ThisClass += ControlChars.Tab & "Public Shared Function _" & Row.Item("MODEL_EXPLORER_ID").ToString & " (ByVal ModelExplorerDR As Data.DataRow, ByVal Race_Info as System.Data.DataRow, ByVal Race_Info_Barrier as System.Data.DataTable, ByVal Entry_Info as System.Data.DataTable, "
                    ThisClass += "ByVal Entry_Info_Distance as System.Data.DataTable, ByVal Entry_Info_Distance_Score as System.Data.DataTable, ByVal Entry_Info_Distance_Theo as System.Data.DataTable, ByVal Entry_Info_Distance_Theo_Score as System.Data.DataTable, "
                    ThisClass += "ByVal Entry_Info_Group as System.Data.DataTable, ByVal Entry_Info_Group_Score as System.Data.DataTable, ByVal Entry_Info_Group_Theo as System.Data.DataTable, ByVal Entry_Info_Group_Theo_Score as System.Data.DataTable, "
                    ThisClass += "ByVal Entry_Info_OverAll as System.Data.DataTable, ByVal Entry_Info_OverAll_Score as System.Data.DataTable, ByVal Entry_Info_OverAll_Theo as System.Data.DataTable, ByVal Entry_Info_OverAll_Theo_Score as System.Data.DataTable"
                    ThisClass += ") as Object" & Environment.NewLine
                    ThisClass += ControlChars.Tab & ControlChars.Tab & "Try" & Environment.NewLine
                    '
                    ThisClass += ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & CStr(Row.Item("VBCODE")) & Environment.NewLine
                    '
                    ThisClass += ControlChars.Tab & ControlChars.Tab & "Catch EX as System.Exception" & Environment.NewLine
                    ThisClass += ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "Return EX" & Environment.NewLine
                    ThisClass += ControlChars.Tab & ControlChars.Tab & "End Try" & Environment.NewLine
                    ThisClass += ControlChars.Tab & "End Function" & Environment.NewLine
                Next Row
                ThisClass += Environment.NewLine & "End Class" & Environment.NewLine
                '
                Return ThisClass
            End Get
        End Property
        Private Shared Sub AddErrorsToListView(ByVal err As System.CodeDom.Compiler.CompilerError, ErrorCount As String, ByRef TabPage As UserControls.TabPage)
            Dim LI As New ListViewItem
            If err.IsWarning Then LI.StateImageIndex = 2 Else LI.StateImageIndex = 3
            LI.SubItems.Add(ErrorCount)
            LI.SubItems.Add(err.ErrorText)
            LI.SubItems.Add(err.ErrorNumber)
            LI.SubItems.Add(CStr(err.Line - 10))
            LI.SubItems.Add(CStr(err.Column))
            TabPage.ListViewErrorList.Items.Add(LI)
        End Sub
        Private Shared ReadOnly Property CompileClass(ByVal code As String) As System.CodeDom.Compiler.CompilerResults
            Get
                Using l_Provider As New Microsoft.VisualBasic.VBCodeProvider
                    Dim l_Params As System.CodeDom.Compiler.CompilerParameters
                    '
                    l_Params = New System.CodeDom.Compiler.CompilerParameters
                    l_Params.GenerateInMemory = True      'Assembly is created in memory
                    l_Params.TreatWarningsAsErrors = False
                    l_Params.WarningLevel = 4
                    l_Params.IncludeDebugInformation = False
                    '
                    Dim refs() As String = {"System.dll", "System.Data.dll", "System.Windows.Forms.dll", "System.Xml.dll"}
                    l_Params.ReferencedAssemblies.AddRange(refs)
                    If Not IO.Directory.Exists(Application.StartupPath & "\Temp") Then
                        IO.Directory.CreateDirectory(Application.StartupPath & "\Temp")
                    End If
                    l_Params.TempFiles = New System.CodeDom.Compiler.TempFileCollection(Application.StartupPath & "\Temp")
                    '
                    Dim l_Results As New System.CodeDom.Compiler.CompilerResults(l_Params.TempFiles)
                    Try
                        l_Results = l_Provider.CompileAssemblyFromSource(l_Params, code)
                        Dim Err As System.CodeDom.Compiler.CompilerErrorCollection = l_Results.Errors
                        If Err.Count > 0 Then
                            Dim Errors As String = ""
                            For Each Er As System.CodeDom.Compiler.CompilerError In l_Results.Errors
                                Errors += Er.ToString() & vbCrLf
                            Next
                            'Throw New Exception(Errors)
                        End If
                    Catch ex As Exception
                    End Try
                    '
                    CompileClass = l_Results
                End Using
            End Get
        End Property
    End Class
End Namespace