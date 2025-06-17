Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar

Public NotInheritable Class ModelRun : Implements IDisposable
    Private MY_STARTDATE As String = Nothing
    Private MY_FINISHDATE As String = Nothing
    Private ReadOnly Connection As Utils.Connection
    Private ReadOnly LoadedAssemblies As ObjectModel.ReadOnlyCollection(Of System.Reflection.Assembly)
    Private ReadOnly InModelIDs As String

    Private MY_MODEL_DR() As Data.DataRow

    Private MY_TSS_LABEL As ToolStripStatusLabel
    Private MY_TSS_PROGRESSBAR As ToolStripProgressBar

    Private MY_COMPILERRESULTS As CodeDom.Compiler.CompilerResults
    Private This_CancelModelRun As Boolean = False
    Private Sub New()
        ' Just so the compiler doesnt create a default constructor
    End Sub
    Public Sub New(Connection As Utils.Connection, LoadedAssemblies As ObjectModel.ReadOnlyCollection(Of System.Reflection.Assembly), InModelIDs As String)
        Me.Connection = Connection
        Me.LoadedAssemblies = LoadedAssemblies
        Me.InModelIDs = InModelIDs
    End Sub
    Public Sub New(StartDate As String, FinishDate As String, InModelIDs As String)
        Me.New

        Me.InModelIDs = InModelIDs
        MY_STARTDATE = StartDate
        MY_FINISHDATE = FinishDate

    End Sub
    Public Property CancelModelRun As Boolean
        Get
            Return Me.This_CancelModelRun
        End Get
        Set(value As Boolean)
            Me.This_CancelModelRun = value
        End Set
    End Property
    Public Sub Start()
        Using RC As New RuntimeCompiler(Me.Connection, Me.InModelIDs, Me.LoadedAssemblies)
            Dim results As String = RC.ExecuteCode()
        End Using
    End Sub
    Friend Function GetResults_DT() As Data.DataTable
        If MY_TSS_LABEL IsNot Nothing Then MY_TSS_LABEL.Text = "Collecting Records..." : Application.DoEvents()

        Dim THIS_FILTER As String = Nothing
        Dim This_Model_Result_DT As Data.DataTable = Nothing
        If MY_MODEL_DR.Length = 1 Then
            Dim Type As String = Nothing, Country As String = Nothing, Length As String = Nothing
            Dim Venue As String = Nothing

            If Not IsDBNull(MY_MODEL_DR(0).Item("MEETING_COUNTRY")) Then Country = MY_MODEL_DR(0).Item("MEETING_COUNTRY").ToString
            If Not IsDBNull(MY_MODEL_DR(0).Item("MEETING_TYPE")) Then Type = MY_MODEL_DR(0).Item("MEETING_TYPE").ToString
            If Not IsDBNull(MY_MODEL_DR(0).Item("VENUE")) Then Venue = MY_MODEL_DR(0).Item("VENUE").ToString
            If Not IsDBNull(MY_MODEL_DR(0).Item("RACE_LENGTH")) Then Length = MY_MODEL_DR(0).Item("RACE_LENGTH").ToString

            THIS_FILTER = General.SQLFilter(MY_STARTDATE, MY_FINISHDATE, Country, Type, Venue, Length)
        Else
            THIS_FILTER = General.SQLFilter(MY_STARTDATE, MY_FINISHDATE, Nothing, Nothing, Nothing, Nothing)
        End If

        Using NewCollectRecords As New RecordCollection(THIS_FILTER, Connection)
            If Not NewCollectRecords.SetDataTables Then GoTo BYPASSRUN
            Dim Y As Int32 = 0
            ' 
            ' This should give us a fake table to populate the models into
            This_Model_Result_DT = New Data.DataTable ' Cascade.StoredProcedures.UC_RUNNERRACELIST.GetDataTable("MEETING_INFO.OADATE = 0", MY_CONNECTION)
            '
            Y = 0
            If Not MY_TSS_PROGRESSBAR Is Nothing Then
                MY_TSS_PROGRESSBAR.Minimum = 0
                MY_TSS_PROGRESSBAR.Maximum = NewCollectRecords.RaceInfoDT.Rows.Count
                MY_TSS_PROGRESSBAR.Step = 1
                MY_TSS_PROGRESSBAR.Visible = True
            End If
            '
            For Each Row As Data.DataRow In NewCollectRecords.RaceInfoDT.Select("")
                If CancelModelRun Then Exit For
                'Using NewRace As New Race(NewCollectRecords)
                'If Not NewRace.SetDataTables(Row) Then GoTo BYPASSRUN
                '
                'If MY_MODEL_DR.Length > 1 Then
                'Dim NewLiveModels As New LiveModels(MY_MODEL_DR, Nothing, MY_COMPILERRESULTS)
                'Call NewLiveModels.RunLiveModels(Row, NewRace.RI_B_DT, NewRace.EI_DT,
                'NewRace.EI_D_DT, NewRace.EI_D_S_DT, NewRace.EI_D_T_DT, NewRace.EI_D_T_S_DT,
                'NewRace.EI_G_DT, NewRace.EI_G_S_DT, NewRace.EI_G_T_DT, NewRace.EI_G_T_S_DT,
                'NewRace.EI_O_DT, NewRace.EI_O_S_DT, NewRace.EI_O_T_DT, NewRace.EI_O_T_S_DT)
                'NewLiveModels = Nothing
                'Else
                'Call RunTestModels(Row, This_Model_Result_DT, NewRace.RI_B_DT, NewRace.EI_DT,
                'NewRace.EI_D_DT, NewRace.EI_D_S_DT, NewRace.EI_D_T_DT, NewRace.EI_D_T_S_DT,
                'NewRace.EI_G_DT, NewRace.EI_G_S_DT, NewRace.EI_G_T_DT, NewRace.EI_G_T_S_DT,
                'NewRace.EI_O_DT, NewRace.EI_O_S_DT, NewRace.EI_O_T_DT, NewRace.EI_O_T_S_DT)
                'End If
                'End Using ' disposes the race class
                If MY_TSS_PROGRESSBAR IsNot Nothing Then MY_TSS_PROGRESSBAR.Value = Y : Y += 1
            Next Row
            This_Model_Result_DT.AcceptChanges()
            '
BYPASSRUN:
        End Using  ' disposes the Record Collection Class
        If Not MY_TSS_PROGRESSBAR Is Nothing Then MY_TSS_PROGRESSBAR.Visible = False
        '
        CancelModelRun = False
        If Not This_Model_Result_DT Is Nothing Then
            Return This_Model_Result_DT
        Else
            Return New Data.DataTable
        End If

        End Function
    Private Sub RunTestModels(ByVal RaceInfoRow As Data.DataRow, ByRef ModelResults_DT As Data.DataTable, ByVal RI_B_DT As Data.DataTable, ByVal EI_DT As Data.DataTable,
    ByVal EI_D_DT As Data.DataTable, ByVal EI_D_S_DT As Data.DataTable, ByVal EI_D_T_DT As Data.DataTable, ByVal EI_D_T_S_DT As Data.DataTable,
    ByVal EI_G_DT As Data.DataTable, ByVal EI_G_S_DT As Data.DataTable, ByVal EI_G_T_DT As Data.DataTable, ByVal EI_G_T_S_DT As Data.DataTable,
    ByVal EI_O_DT As Data.DataTable, ByVal EI_O_S_DT As Data.DataTable, ByVal EI_O_T_DT As Data.DataTable, ByVal EI_O_T_S_DT As Data.DataTable)
        '
        Dim Rslt As New Object, args() As Object = {CType(MY_MODEL_DR(0), Object), CType(RaceInfoRow, Object), CType(RI_B_DT, Object), CType(EI_DT, Object),
        CType(EI_D_DT, Object), CType(EI_D_S_DT, Object), CType(EI_D_T_DT, Object), CType(EI_D_T_S_DT, Object),
        CType(EI_G_DT, Object), CType(EI_G_S_DT, Object), CType(EI_G_T_DT, Object), CType(EI_G_T_S_DT, Object),
        CType(EI_O_DT, Object), CType(EI_O_S_DT, Object), CType(EI_O_T_DT, Object), CType(EI_O_T_S_DT, Object)}

        Rslt = MY_COMPILERRESULTS.CompiledAssembly.GetType("Models").InvokeMember("_" & Trim(MY_MODEL_DR(0).Item("MODEL_EXPLORER_ID")), System.Reflection.BindingFlags.InvokeMethod Or System.Reflection.BindingFlags.Public Or System.Reflection.BindingFlags.Static, Nothing, Nothing, args)
        '
        If Not Rslt Is Nothing Then
            Dim sRESULT As String = Rslt.GetType.ToString.ToUpperInvariant
            If sRESULT.Contains("EXCEPTION") Then
                Dim EX As Exception = CType(Rslt, Exception)
                Dim Text As String = "The following exception error has happened:" & EX.ToString & Environment.NewLine & Environment.NewLine & "Do you want to continue running the model?"
                If MessageBox.Show(Text, "An Error Occured", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False) = DialogResult.No Then CancelModelRun = True
                Exit Sub
            End If
            sRESULT = Nothing
            '
            Dim Values() As String = Nothing
            Values = Split(CStr(Rslt), ",")
            If (Not Values Is Nothing) AndAlso (Values.Length > 0) Then
                For Each Value As String In Values
                    If Value.ToUpperInvariant = "FALSE" Or Value = "" Then Continue For
                    Dim DR As Data.DataRow = Nothing 'Cascade.StoredProcedures.UC_RUNNERRACELIST.GetDataRow(CStr(RaceInfoRow.Item("MEETING_INFO_OADATE")), CStr(RaceInfoRow.Item("MEETING_INFO_NUMBER")), CStr(RaceInfoRow.Item("NUMBER")), Value, Me.MY_CONNECTION)
                    If DR Is Nothing Then Continue For
                    ModelResults_DT.ImportRow(DR)
                Next Value
            End If
        End If
    End Sub

#Region "       IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Friend Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                '
            End If

            '
            If MY_COMPILERRESULTS IsNot Nothing Then MY_COMPILERRESULTS = Nothing
        End If
        Me.disposedValue = True
    End Sub
    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class