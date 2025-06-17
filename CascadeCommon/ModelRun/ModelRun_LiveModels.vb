Namespace ModelDevelopment
    Partial Class ModelRun
        Private NotInheritable Class LiveModels : Implements IDisposable
            Private disposedValue As Boolean
            Private MY_CONNECTION As Utils.Connection
            Private MY_MESSAGES As Messages
            Private MY_COMPILER_RESULTS As CodeDom.Compiler.CompilerResults
            Private MY_MODEL_EXPLORER_DR() As Data.DataRow
            Friend Sub New()
                Me.MY_CONNECTION = New Utils.Connection
            End Sub
            Friend Sub New(ModelExplorerDR() As Data.DataRow, Messages As Messages, ByVal CompilerResults As CodeDom.Compiler.CompilerResults)
                Me.New
                MY_MESSAGES = Messages
                MY_COMPILER_RESULTS = CompilerResults
                MY_MODEL_EXPLORER_DR = ModelExplorerDR
            End Sub
            Friend Sub RunLiveModels(ByVal RaceInfoRow As Data.DataRow, ByVal RI_B_DT As Data.DataTable, ByVal EI_DT As Data.DataTable,
            ByVal EI_D_DT As Data.DataTable, ByVal EI_D_S_DT As Data.DataTable, ByVal EI_D_T_DT As Data.DataTable, ByVal EI_D_T_S_DT As Data.DataTable,
            ByVal EI_G_DT As Data.DataTable, ByVal EI_G_S_DT As Data.DataTable, ByVal EI_G_T_DT As Data.DataTable, ByVal EI_G_T_S_DT As Data.DataTable,
            ByVal EI_O_DT As Data.DataTable, ByVal EI_O_S_DT As Data.DataTable, ByVal EI_O_T_DT As Data.DataTable, ByVal EI_O_T_S_DT As Data.DataTable)
                For Each MODEL As Data.DataRow In MY_MODEL_EXPLORER_DR
                    If Not LiveBaseCriteriaMatches(MODEL, EI_DT) Then Continue For
                    Dim Rslt As New Object, args() As Object = {CType(MODEL, Object), CType(RaceInfoRow, Object), CType(RI_B_DT, Object), CType(EI_DT, Object),
                CType(EI_D_DT, Object), CType(EI_D_S_DT, Object), CType(EI_D_T_DT, Object), CType(EI_D_T_S_DT, Object),
                CType(EI_G_DT, Object), CType(EI_G_S_DT, Object), CType(EI_G_T_DT, Object), CType(EI_G_T_S_DT, Object),
                CType(EI_O_DT, Object), CType(EI_O_S_DT, Object), CType(EI_O_T_DT, Object), CType(EI_O_T_S_DT, Object)}
                    Rslt = MY_COMPILER_RESULTS.CompiledAssembly.GetType("Models").InvokeMember("_" & CStr(MODEL.Item("MODEL_EXPLORER_ID")), System.Reflection.BindingFlags.InvokeMethod Or System.Reflection.BindingFlags.Public Or System.Reflection.BindingFlags.Static, Nothing, Nothing, args, Globalization.CultureInfo.InvariantCulture)
                    If Not Rslt Is Nothing Then
                        If IsException(Rslt, MODEL) Then Continue For
                        '
                        Rslt = Replace(CStr(Rslt), " ", "")
                        If Rslt = "False" Then Continue For
                        For Each NUMBER As String In Split(DirectCast(Rslt, String), ",")
                            If NUMBER = "" Then Continue For
                            Call Set_LiveModel(RaceInfoRow, MODEL, NUMBER)
                        Next NUMBER
                    End If
                Next MODEL
            End Sub
            Private ReadOnly Property IsException(ByVal ModelResult As Object, ModelExplorerRow As Data.DataRow) As Boolean
                Get
                    Try
                        Dim e As System.Exception
                        e = CType(ModelResult, System.Exception)
                        Call MY_MESSAGES.LogMessages("The following exception error has occured in Model: " & CStr(ModelExplorerRow.Item("MODEL_EXPLORER_ID")) & " - " & CStr(ModelExplorerRow.Item("NAME")) & Environment.NewLine & e.ToString & Environment.NewLine & e.StackTrace.ToString & Environment.NewLine & "Continuing running the model!", Utils.BroadcastTypes.Error)
                        Return True
                    Catch ex As Exception
                        ' Nothing to do, there is no exception in the model, so return false.... 
                    End Try
                    Return False
                End Get
            End Property
            Private Shared Function LiveBaseCriteriaMatches(ByVal ModelInfoRow As Data.DataRow, ByVal EI_DT As Data.DataTable) As Boolean
                Dim Type As String = Nothing, Country As String = Nothing, Length As String = Nothing, Weather As String = Nothing
                Dim Venue As String = Nothing, Track As String = Nothing, GTE As String = Nothing, LTE As String = Nothing
                '
                If Not IsDBNull(ModelInfoRow.Item("MEETING_TYPE")) Then Type = ModelInfoRow.Item("MEETING_TYPE").ToString
                If Not IsDBNull(ModelInfoRow.Item("MEETING_COUNTRY")) Then Country = ModelInfoRow.Item("MEETING_COUNTRY").ToString
                If Not IsDBNull(ModelInfoRow.Item("RACE_LENGTH")) Then Length = ModelInfoRow.Item("RACE_LENGTH").ToString
                If Not IsDBNull(ModelInfoRow.Item("RACE_WEATHER")) Then Weather = ModelInfoRow.Item("RACE_WEATHER").ToString
                If Not IsDBNull(ModelInfoRow.Item("RACE_VENUE")) Then Venue = ModelInfoRow.Item("RACE_VENUE").ToString
                If Not IsDBNull(ModelInfoRow.Item("RACE_TRACK")) Then Track = ModelInfoRow.Item("RACE_TRACK").ToString
                If Not IsDBNull(ModelInfoRow.Item("RACE_RIR_GTE")) Then GTE = ModelInfoRow.Item("RACE_RIR_GTE").ToString
                If Not IsDBNull(ModelInfoRow.Item("RACE_RIR_LTE")) Then LTE = ModelInfoRow.Item("RACE_RIR_LTE").ToString
                Dim FILTER As String = General.DTFilter(Type, Country, Length, Weather, Venue, Track, GTE, LTE)
                Dim DR() As Data.DataRow = EI_DT.Select(FILTER)
                If DR.Length = 0 Then
                    Return False
                Else
                    Return True
                End If
            End Function
            Private Sub Set_LiveModel(ByVal ROW As Data.DataRow, ByVal MODEL_INFO_ROW As Data.DataRow, ByVal ENTRY_NUMBER As String)
                ' On Error Resume Next
                '
                Dim CMDTEXT As String = "UPDATE RACE_INFO SET HASMODEL=1 WHERE (MEETING_INFO_OADATE=" & ROW.Item("MEETING_INFO_OADATE").ToString & ") "
                CMDTEXT += "AND (MEETING_INFO_NUMBER=" & CStr(ROW.Item("MEETING_INFO_NUMBER")) & ") AND (NUMBER=" & CStr(ROW.Item("NUMBER")) & ")"
                Call MY_CONNECTION.Execute(CMDTEXT)
                '
                CMDTEXT = "INSERT INTO RACE_MODEL_INFO (MEETING_INFO_OADATE, MEETING_INFO_NUMBER, RACE_INFO_NUMBER, ENTRY_INFO_NUMBER, MODEL_INFO_ID, BETTYPE, DETAIL) "
                CMDTEXT += "VALUES(" & CStr(ROW.Item("MEETING_INFO_OADATE")) & ", " & CStr(ROW.Item("MEETING_INFO_NUMBER")) & ", " & CStr(ROW.Item("NUMBER")) & ", "
                CMDTEXT += ENTRY_NUMBER & ", "
                CMDTEXT += MODEL_INFO_ROW.Item("MODEL_EXPLORER_ID").ToString & ", "
                CMDTEXT += "N'" & MODEL_INFO_ROW.Item("BACKING").ToString & "', "
                CMDTEXT += "N'Passed: " & CStr(MODEL_INFO_ROW.Item("TREE_PATH")) & " - " & CStr(MODEL_INFO_ROW.Item("NAME")) & " model, Runner: " & ENTRY_NUMBER & ", for " & CStr(MODEL_INFO_ROW.Item("BACKING")) & ".'"
                CMDTEXT += ")"
                Call MY_CONNECTION.Execute(CMDTEXT)
            End Sub

            Private Sub Dispose(disposing As Boolean)
                If Not disposedValue Then
                    If disposing Then
                        MY_CONNECTION.Dispose()
                    End If

                    ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
                    ' TODO: set large fields to null
                    disposedValue = True
                End If
            End Sub

            ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
            ' Protected Overrides Sub Finalize()
            '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            '     Dispose(disposing:=False)
            '     MyBase.Finalize()
            ' End Sub

            Public Sub Dispose() Implements IDisposable.Dispose
                ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
                Dispose(disposing:=True)
                GC.SuppressFinalize(Me)
            End Sub
        End Class
    End Class
End Namespace