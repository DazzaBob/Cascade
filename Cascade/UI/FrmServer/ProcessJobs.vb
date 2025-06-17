Namespace UI
    Partial Class FrmServer
        Friend NotInheritable Class ProcessJobs
            Private Sub New()
                ' Just so the compiler doesnt create a default constructor
            End Sub
            Friend Shared Sub Start(ByRef FormServerUI As FrmServer)
                If GetTop1Id Is Nothing Then Return
                Call DeleteProcessed()
                '
                Dim CMDTEXT As String = "SELECT * FROM JOB_LIST WHERE (PROCESSED <> 1) ORDER BY JOBLIST_ID ASC"
                Dim DR() As Data.DataRow = FrmServer.Connection.GetDataTable(CMDTEXT).Select("")
                If DR.Length = 0 Then Return
                '
                FormServerUI.TSPBMain.Minimum = 0
                FormServerUI.TSPBMain.Maximum = DR.Count
                FormServerUI.TSPBMain.Value = 0
                '
                For Each ROW As Data.DataRow In DR
                    Using NewCommand As New ProcessJobsCommands(CType(ROW.Item("REQUEST"), Requests), CStr(ROW.Item("PARAMETERS")), CStr(ROW.Item("JOBLIST_ID")), Connection)
                        Call NewCommand.Start()
                    End Using
                    '
                    Dim JobID As String = CStr(ROW.Item("JOBLIST_ID"))
                    Dim Command As String = GetRequestString(CType(ROW.Item("REQUEST"), Requests))
                    Call ProcessedJob(JobID, Command & "?" & CStr(ROW.Item("PARAMETERS")))
                    '
                    FormServerUI.TSPBMain.Value += 1 : Application.DoEvents()
                Next ROW
            End Sub
            Friend Shared ReadOnly Property GetTop1Id() As String
                Get
                    Dim CMDTEXT As String = "SELECT TOP 1 JOBLIST_ID FROM JOB_LIST"
                    Return FrmServer.Connection.ExecuteScalar(CMDTEXT)
                End Get
            End Property
            Friend Shared Sub DeleteProcessed()
                Dim CMDTEXT As String = "DELETE FROM JOB_LIST WHERE PROCESSED=1"
                Call FrmServer.Connection.Execute(CMDTEXT)
            End Sub
            Friend Shared Sub ProcessedJob(ByVal jobId As String, ByVal command As String)
                Dim CMDTEXT As String = "UPDATE JOB_LIST SET PROCESSED=1 WHERE JOBLIST_ID=" & jobId
                Call FrmServer.Connection.Execute(CMDTEXT)
                '
                Call Messages.LogMessages("Processed job " & jobId & " - " & command & " from server job list.", Cascade.BroadcastTypes.Log)
            End Sub
            Friend Shared Sub ProcessingJob(ByVal jobId As String)
                Dim CMDTEXT As String = "UPDATE JOB_LIST SET PROCESSED=2 WHERE JOBLIST_ID=" & jobId
                Call FrmServer.Connection.Execute(CMDTEXT)
            End Sub
            Friend Shared Sub AddToJobList(ByVal caller As String, ByVal priority As String, ByVal request As String, ByVal parameters As String)
                If parameters Is Nothing Then Return
                '
                Dim CMDTEXT As String = "INSERT INTO JOB_LIST (OADATETIME, CALLER, PRIORITY, REQUEST, PARAMETERS, PROCESSED) "
                CMDTEXT += "VALUES(" & CStr(Now.ToOADate) & ", "
                CMDTEXT += "N'" & caller & "', "
                CMDTEXT += priority & ", "
                CMDTEXT += request & ", "
                CMDTEXT += "'" & parameters & "', "
                CMDTEXT += "0)"
                Call FrmServer.Connection.Execute(CMDTEXT)
                '
                Call Messages.LogMessages("Added Job " & CType(request, Requests).ToString & "?" & parameters.ToString & " to server job list.", Cascade.BroadcastTypes.Log)
            End Sub
            Private NotInheritable Class ProcessJobsCommands : Implements IDisposable
                ' These variables are passed in, so dispose them in the calling class.
                Private MY_REQUEST As Cascade.Requests = Nothing
                Private MY_PARAMETERS As String = Nothing
                Private MY_JOB_ID As String = Nothing
                Private MY_CONNECTION As Connection
                Friend Sub New(ByVal request As Cascade.Requests, ByVal parameters As String, ByVal JobID As String, ByVal Connection As Connection)
                    MY_REQUEST = request
                    MY_PARAMETERS = parameters
                    MY_JOB_ID = JobID
                    MY_CONNECTION = Connection
                End Sub
                Friend Sub Start()
                    Dim ThisDay As String = Nothing
                    ' Check to see if the command has parameters
                    ' If the DAY parameter has a date specified, is it 0, if it is it's today else its the day specified.
                    ' if DAY is not specified then DAY is today.
                    If MY_PARAMETERS.ToUpperInvariant.Contains("DAY") Then
                        Dim Parameters() As String = Split(MY_PARAMETERS, "=")
                        If Parameters(1) = "0" Then
                            ThisDay = CStr(Today.ToOADate)
                        Else
                            ThisDay = Parameters(1)
                        End If
                    Else
                        ThisDay = CStr(Today.ToOADate)
                    End If
                    '
                    Call ServerUI.Messages.LogMessages("Processing Job: " & Cascade.GetRequestString(MY_REQUEST) & "?" & MY_PARAMETERS & " in server job list.", Cascade.BroadcastTypes.Log)
                    '
                    'Set the current Job to 'PROCESSING' in case we get interrupted. we can then redo the job again until it completes successfully.
                    Call ProcessJobs.ProcessingJob(MY_JOB_ID)
                    '
                    Select Case MY_REQUEST
                        Case Cascade.Requests.DownloadSchedule
                            Call DOWNLOAD_SCHEDULE(ThisDay, False)
                            Exit Select
                            '
                        Case Cascade.Requests.DownloadScheduleForceReload
                            Call DOWNLOAD_SCHEDULE(ThisDay, True)
                            Exit Select
                            '
                        Case Cascade.Requests.RerunModels
                            Call RERUNMODELS(ThisDay)
                            Exit Select
                            '
                        Case Cascade.Requests.RerunModelsAll
                            Call RERUNMODELS("0")
                            Exit Select
                            '
                        Case Cascade.Requests.DownloadResults
                            Call DOWNLOAD_RESULTS(ThisDay)
                            Exit Select
                            '
                        Case Cascade.Requests.DownloadYesterdaysResults
                            ' This day equals today -1, giving yesterday.
                            Call DOWNLOAD_RESULTS(ThisDay)
                            Exit Select
                        Case Cascade.Requests.DownloadYesterdaysResultsForce
                            ' This day equals today -1, giving yesterday.
                            Call DOWNLOAD_RESULTS(ThisDay, True)
                            Exit Select
                            '
                        Case Cascade.Requests.DownloadXml
                            Call DOWNLOAD_SCHEDULE(ThisDay, True)
                            Call DOWNLOAD_RESULTS(ThisDay, True)
                            Exit Select
                            '
                        Case Cascade.Requests.DownloadDay
                            Call DOWNLOAD_SCHEDULE(ThisDay)
                            Call DOWNLOAD_RESULTS(ThisDay)
                            Exit Select
                            '
                        Case Cascade.Requests.RebuildIndexes
                            Call REBUILD_INDEXES()
                            Exit Select
                        Case Else
                            '   Do Nothing we dont know what the request is.
                    End Select
                End Sub
#Region "       The actual commands where we start the worker threads "
                ''' <summary>
                ''' Down load the Schedule for a given day.
                ''' </summary>
                ''' <param name="OADate"></param>
                ''' <param name="Force"></param>
                ''' <remarks>If Force is TRUE, Then delete the schedule.xml file to force it to download it again.</remarks>
                Private Sub DOWNLOAD_SCHEDULE(ByVal OADate As String, Optional ByVal Force As Boolean = False)
                    Dim Broadcast As String = "Download the schedule for " & FormatDateTime(Date.FromOADate(CDbl(OADate)), DateFormat.LongDate).ToString & " in a " & Threading.Thread.CurrentThread.GetApartmentState.ToString & " background thread, wait for thread to finish."
                    Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
                    If Force Then
                        If IO.Directory.Exists(My.Settings.ScheduleFolder & "\" & OADate) AndAlso IO.File.Exists(My.Settings.ScheduleFolder & "\" & OADate & "\schedule.xml") Then
                            IO.File.Delete(My.Settings.ScheduleFolder & "\" & OADate & "\schedule.xml")
                        End If
                    End If
                    '
                    Dim CMDTEXT As String = "DELETE FROM MEETING_INFO WHERE (OADATE=" & OADate & ")"
                    Call MY_CONNECTION.Execute(CMDTEXT)
                    '
                    Using PSE As New Cascade.Processing.Schedule(OADate, MY_CONNECTION)
                        Call PSE.Start()
                    End Using
                End Sub
                ''' <summary>
                ''' Dowload Results for a given day.
                ''' </summary>
                ''' <param name="OADate"></param>
                ''' <param name="Force"></param>
                ''' <remarks>if param Force is TRUE then we delete results.xml if it exists and force it to download it again.</remarks>
                Private Sub DOWNLOAD_RESULTS(ByVal OADate As String, Optional ByVal Force As Boolean = False)
                    If Force AndAlso IO.Directory.Exists(My.Settings.ResultsFolder & "\" & OADate) AndAlso IO.File.Exists(My.Settings.ResultsFolder & "\" & OADate & "\results.xml") Then
                        IO.File.Delete(My.Settings.ResultsFolder & "\" & OADate & "\results.xml")
                    End If
                    '
                    Dim CMDTEXT As String = "UPDATE ENTRY_INFO SET "
                    CMDTEXT += "RESULT_TIME = NULL, RESULT_FINISH_POSITION = NULL, RESULT_DISTANCE_BEHIND= NULL, RESULT_SPEED= NULL, RESULT_POOL_WIN=NULL, RESULT_POOL_PLACE=NULL, "
                    CMDTEXT += "RESULT_THEO_TIME= NULL, RESULT_THEO_FINISH_POSITION= NULL, RESULT_THEO_DISTANCE_BEHIND= NULL, RESULT_THEO_SPEED= NULL "
                    CMDTEXT += "WHERE (MEETING_INFO_OADATE = " & OADate & ") " & vbCrLf
                    '
                    CMDTEXT += "DELETE FROM RACE_INFO_RESULTS_POOLS WHERE (MEETING_INFO_OADATE = " & OADate & ")"
                    Call MY_CONNECTION.Execute(CMDTEXT)
                    '
                    Using PRE As New Cascade.Processing.Results(OADate)
                        Dim NewThread As New Threading.Thread(AddressOf PRE.Start)
                        NewThread.TrySetApartmentState(Threading.ApartmentState.MTA)
                        NewThread.Priority = Threading.ThreadPriority.Lowest
                        NewThread.IsBackground = True
                        NewThread.Start()
                        NewThread.Join()
                    End Using
                End Sub
                Private Sub RERUNMODELS(ByVal OADate As String)
                    ' Check the Rerun Models in a background thread
                    Dim Broadcast As String = "Rerun the models for: " & FormatDateTime(Date.FromOADate(CDbl(OADate)), DateFormat.LongDate) & " in a STA background thread, wait for thread to finish."
                    Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
                    '
                    Using RRM As Cascade.ModelDevelopment.RerunModels = New Cascade.ModelDevelopment.RerunModels(OADate, MY_CONNECTION)
                        Call RRM.NOW()
                    End Using
                End Sub
                Private Sub REBUILD_INDEXES()
                    Dim Broadcast As String = "Rebuild Indexes"
                    Dim STOPWATCH As New Stopwatch
                    STOPWATCH.Start()
                    Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
                    '
                    Dim CMDTEXT As String = "EXEC SP_REBUILD_INDEXES"
                    Call MY_CONNECTION.Execute(CMDTEXT)
                    '
                    STOPWATCH.Stop()
                    Broadcast = "Rebuilt Indexes in: " & Cascade.GetTime(STOPWATCH)
                    Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
                End Sub
#End Region
#Region "   IDisposable Support"
                Private disposedValue As Boolean ' To detect redundant calls

                ' IDisposable
                Private Sub Dispose(disposing As Boolean)
                    If Not Me.disposedValue Then
                        If disposing Then
                            '
                        End If

                        ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                        ' TODO: set large fields to null.
                    End If
                    Me.disposedValue = True
                End Sub

                ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
                'Protected Overrides Sub Finalize()
                '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
                '    Dispose(False)
                '    MyBase.Finalize()
                'End Sub

                ' This code added by Visual Basic to correctly implement the disposable pattern.
                Public Sub Dispose() Implements IDisposable.Dispose
                    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
                    Dispose(True)
                    GC.SuppressFinalize(Me)
                End Sub
#End Region
            End Class
        End Class
    End Class
End Namespace