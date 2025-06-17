Imports System
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.Loader
Imports System.Windows.Forms
Imports System.Collections.Generic
Imports Microsoft.CodeAnalysis
Imports Microsoft.CodeAnalysis.VisualBasic
Imports Microsoft.CodeAnalysis.Emit
Namespace ModelDevelopment
    Friend NotInheritable Class RuntimeCompiler
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared ReadOnly Property ModelExplorerDR(ByVal Connection As Utils.Connection, Optional ByVal ModelID As String = Nothing) As Data.DataRow()
            Get
                Dim CMDTEXT As String
                If ModelID IsNot Nothing AndAlso ModelID.Length > 0 Then
                    CMDTEXT = "SELECT * FROM MODEL_EXPLORER WHERE (ID=" & ModelID & ")"
                Else
                    CMDTEXT = "SELECT * FROM MODEL_EXPLORER WHERE ([STATUS]=1) AND ([NODE_TYPE]=2) AND (NOT [VBCODE] IS NULL)"
                End If
                Return Connection.GetDataTable(CMDTEXT).Select("")
            End Get
        End Property
        Friend Shared Function CompileCode(FrmMain As FrmMain, TabPage As UserControls.UserControlTabPage, ModelExplorerDR() As Data.DataRow) As IEnumerable(Of Microsoft.CodeAnalysis.Diagnostic)
            If FrmMain IsNot Nothing Then FrmMain.TSSLBLStatus.Text = "Compiling ..." : Application.DoEvents()
            If TabPage IsNot Nothing Then TabPage.UserControlModel.UCSource.RichTextBoxErrorList.Text = String.Empty : Application.DoEvents()

            Dim CompilerResults As IEnumerable(Of Microsoft.CodeAnalysis.Diagnostic) = CompileClass(VBClass(ModelExplorerDR))

            If CompilerResults Is Nothing Then
                If FrmMain IsNot Nothing Then FrmMain.TSSLBLStatus.Text = "Compile complete ..." : Application.DoEvents()
                Return Nothing
            Else
                If TabPage IsNot Nothing Then
                    TabPage.UserControlModel.UCSource.RichTextBoxErrorList.Text = "The model has the following errors: " & Environment.NewLine
                    Dim LogErrors As String = String.Empty
                    For Each diagnostic As Diagnostic In CompilerResults
                        LogErrors += vbTab & diagnostic.Id & " " & diagnostic.GetMessage() & Environment.NewLine
                    Next
                    TabPage.UserControlModel.UCSource.RichTextBoxErrorList.Text += LogErrors
                End If
                If FrmMain IsNot Nothing Then FrmMain.TSSLBLStatus.Text = "Compile failed!" : Application.DoEvents()
            End If

            Return CompilerResults
        End Function
        Private Shared Function VBClass(ModelExplorerDR() As Data.DataRow) As String
            ' Multiple Functions, generally from a model run.
            If (ModelExplorerDR Is Nothing) OrElse (ModelExplorerDR.Length = 0) Then Return Nothing
            Dim ThisClass As String
            ThisClass = "Imports System" & Environment.NewLine
            ThisClass += "Imports System.Data" & Environment.NewLine
            ThisClass += "Imports Microsoft.VisualBasic" & Environment.NewLine
            ThisClass += "Namespace CompiledModels" & Environment.NewLine
            ThisClass += "Public Class Models" & Environment.NewLine
            ThisClass += ControlChars.Tab & "Private Sub New()" & Environment.NewLine & ControlChars.Tab & ControlChars.Tab & "' Just so the compiler doesn't create a default constructor." & Environment.NewLine
            ThisClass += ControlChars.Tab & "End Sub" & Environment.NewLine & ControlChars.Tab & "'" & Environment.NewLine

            For Each Row As Data.DataRow In ModelExplorerDR
                ThisClass += ControlChars.Tab & "Public Shared Function _" & Row.Item("ID").ToString & " (ByVal ModelExplorerDR As Data.DataRow, ByVal Race_Info as System.Data.DataRow, ByVal Race_Info_Barrier as System.Data.DataTable, ByVal Entry_Info as System.Data.DataTable, "
                ThisClass += "ByVal Entry_Info_Distance as System.Data.DataTable, ByVal Entry_Info_Distance_Score as System.Data.DataTable, ByVal Entry_Info_Distance_Theo as System.Data.DataTable, ByVal Entry_Info_Distance_Theo_Score as System.Data.DataTable, "
                ThisClass += "ByVal Entry_Info_Group as System.Data.DataTable, ByVal Entry_Info_Group_Score as System.Data.DataTable, ByVal Entry_Info_Group_Theo as System.Data.DataTable, ByVal Entry_Info_Group_Theo_Score as System.Data.DataTable, "
                ThisClass += "ByVal Entry_Info_OverAll as System.Data.DataTable, ByVal Entry_Info_OverAll_Score as System.Data.DataTable, ByVal Entry_Info_OverAll_Theo as System.Data.DataTable, ByVal Entry_Info_OverAll_Theo_Score as System.Data.DataTable"
                ThisClass += ") as Object" & Environment.NewLine

                ThisClass += ControlChars.Tab & ControlChars.Tab & "Try" & Environment.NewLine
                ThisClass += ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & CStr(Row.Item("VBCODE")) & Environment.NewLine
                ThisClass += ControlChars.Tab & ControlChars.Tab & "Catch EX as System.Exception" & Environment.NewLine
                ThisClass += ControlChars.Tab & ControlChars.Tab & ControlChars.Tab & "Return EX" & Environment.NewLine
                ThisClass += ControlChars.Tab & ControlChars.Tab & "End Try" & Environment.NewLine
                ThisClass += ControlChars.Tab & "End Function" & Environment.NewLine
            Next Row
            ThisClass += Environment.NewLine & "End Class" & Environment.NewLine
            ThisClass += "End Namespace"
            Return ThisClass
        End Function
        Private Shared Function CompileClass(CodeToCompile As String) As IEnumerable(Of Microsoft.CodeAnalysis.Diagnostic)
            Dim syntaxTree As Microsoft.CodeAnalysis.SyntaxTree = Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxTree.ParseText(CodeToCompile)
            Dim assemblyName As String = System.IO.Path.GetRandomFileName()
            Dim refPaths(My.Application.Info.LoadedAssemblies.Count - 1) As String
            For X As Integer = 0 To My.Application.Info.LoadedAssemblies.Count - 1
                refPaths(X) = Assembly.Load(My.Application.Info.LoadedAssemblies(X).FullName).Location
            Next
            Dim references As MetadataReference() = refPaths.[Select](Function(r) MetadataReference.CreateFromFile(r)).ToArray()

            '= {GetType(System.Object).GetTypeInfo().Assembly.Location, GetType(Form).GetTypeInfo().Assembly.Location, Path.Combine(Path.GetDirectoryName(GetType(System.Runtime.GCSettings).GetTypeInfo().Assembly.Location), "System.Runtime.dll")}
            'Dim references As MetadataReference() = refPaths.[Select](Function(r) MetadataReference.CreateFromFile(r)).ToArray()
            'Write("Adding the following references")

            'For Each r In refPaths
            '    Write(r)
            'Next

            'Write("Compiling ...")
            Dim compilation As Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation = Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation.Create(assemblyName, syntaxTrees:={syntaxTree}, references:=references, options:=New Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions(OutputKind.DynamicallyLinkedLibrary))

            Using ms = New MemoryStream()
                Dim result As EmitResult = compilation.Emit(ms)
                If Not result.Success Then
                    'Write("Compilation failed!")
                    Return result.Diagnostics.Where(Function(diagnostic) diagnostic.IsWarningAsError OrElse diagnostic.Severity = DiagnosticSeverity.[Error])
                Else
                    Return Nothing
                End If
            End Using
        End Function
    End Class

    Public Class Program
        Shared Write As Action(Of String) = AddressOf Console.WriteLine

        Public Shared Sub _Main(ByVal args As String())
            Write("Let's compile!")
            Dim codeToCompile As String = "
            using System;

            namespace RoslynCompileSample
            {
                public class Writer
                {
                    public void Write(string message)
                    {
                        Console.WriteLine($""you said '{message}!'"");
                    }
                }
            }"
            Write("Parsing the code into the SyntaxTree")
            Dim syntaxTree As Microsoft.CodeAnalysis.SyntaxTree = Microsoft.CodeAnalysis.VisualBasic.VisualBasicSyntaxTree.ParseText(codeToCompile)
            Dim assemblyName As String = System.IO.Path.GetRandomFileName()
            Dim refPaths = {GetType(System.Object).GetTypeInfo().Assembly.Location, GetType(Form).GetTypeInfo().Assembly.Location, Path.Combine(Path.GetDirectoryName(GetType(System.Runtime.GCSettings).GetTypeInfo().Assembly.Location), "System.Runtime.dll")}
            Dim references As MetadataReference() = refPaths.[Select](Function(r) MetadataReference.CreateFromFile(r)).ToArray()
            Write("Adding the following references")

            For Each r In refPaths
                Write(r)
            Next

            Write("Compiling ...")
            Dim compilation As Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation = Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilation.Create(assemblyName, syntaxTrees:={syntaxTree}, references:=references, options:=New Microsoft.CodeAnalysis.VisualBasic.VisualBasicCompilationOptions(OutputKind.DynamicallyLinkedLibrary))

            Using ms = New MemoryStream()
                Dim result As EmitResult = compilation.Emit(ms)
                If Not result.Success Then
                    Write("Compilation failed!")
                    Dim failures As IEnumerable(Of Diagnostic) = result.Diagnostics.Where(Function(diagnostic) diagnostic.IsWarningAsError OrElse diagnostic.Severity = DiagnosticSeverity.[Error])

                    For Each diagnostic As Diagnostic In failures
                        Console.[Error].WriteLine(vbTab & "{0}: {1}", diagnostic.Id, diagnostic.GetMessage())
                    Next
                Else
                    Write("Compilation successful! Now instantiating and executing the code ...")
                    ms.Seek(0, SeekOrigin.Begin)
                    Dim assembly As Assembly = AssemblyLoadContext.[Default].LoadFromStream(ms)
                    Dim type = assembly.[GetType]("RoslynCompileSample.Writer")
                    Dim instance = assembly.CreateInstance("RoslynCompileSample.Writer")
                    Dim meth = TryCast(type.GetMember("Write").First(), MethodInfo)
                    meth.Invoke(instance, {"joel"})
                End If
            End Using
        End Sub
    End Class
End Namespace