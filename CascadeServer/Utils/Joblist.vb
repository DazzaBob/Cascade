Imports System.Timers
Namespace Utils
    Friend Class Joblist
        Private ReadOnly File As String = Application.StartupPath & "Jobs.Xml"
        Private DATATABLE As Data.DataTable
        Private Shared THIS_DGVROW As DataGridViewRow

        Private ReadOnly DGV As DataGridView
        Private ReadOnly MESSAGES As CascadeCommon.Messages
        Private ReadOnly CONNECTION As CascadeCommon.Utils.Connection
        Private ReadOnly HTTPCLIENT As Net.Http.HttpClient

        Private WithEvents Timer As System.Timers.Timer

        Private Sub New()
            DATATABLE = New Data.DataTable
            THIS_DGVROW = Nothing

            Timer = New System.Timers.Timer(500.0#)
        End Sub
        Friend Sub New(DataGridView As DataGridView, Messages As CascadeCommon.Messages, Connection As CascadeCommon.Utils.Connection, HttpClient As Net.Http.HttpClient)
            Me.New

            DGV = DataGridView
            Me.MESSAGES = Messages
            Me.CONNECTION = Connection
            Me.HTTPCLIENT = HttpClient
        End Sub
        Friend Sub Start()
            If IO.File.Exists(File) Then
                Dim unused = DATATABLE.ReadXml(File)

                For Each ROW As Data.DataRow In DATATABLE.Select("", "ID ASC")
                    Call AddDataGridviewRow(ROW)
                Next ROW
            Else
                Call CreateDataTable()
            End If

            Timer.Start()
        End Sub
        Friend Sub Refresh()
            DATATABLE.Dispose()
            DATATABLE = New Data.DataTable

            Start()
        End Sub
        Friend Sub StopTimer()
            Timer.Stop()
        End Sub
        Friend Sub StartTimer()
            Timer.Start()
        End Sub
        Friend ReadOnly Property Count As Integer
            Get
                Return DATATABLE.Rows.Count
            End Get
        End Property
        Friend Sub Add(Requests As Utils.Requests, Parameters As String, Optional WriteXMLFile As Boolean = False)
            Dim DR As Data.DataRow = DATATABLE.NewRow
            DR.Item("DATETIME") = Date.Now
            DR.Item("REQUESTS") = Requests
            DR.Item("PARAMETERS") = Parameters

            DATATABLE.Rows.Add(DR)
            DATATABLE.AcceptChanges()

            If WriteXMLFile Then
                DATATABLE.WriteXml(File, XmlWriteMode.WriteSchema)
            End If

            Call AddDataGridviewRow(DR)
        End Sub
#Region "        Remove "
        Friend Sub Remove(Id As String)
            Dim DR() As Data.DataRow = DATATABLE.Select("ID=" & Id)
            If DR.Length = 0 Then
                Call MESSAGES.LogMessages("Cannot remove job ID" & Id & ".  It no longer exists in the table.", BroadcastTypes.Error)

                For Each DGV_Row As DataGridViewRow In DGV.Rows
                    If CInt(Id) = DGV_Row.Cells(0).Value Then
                        THIS_DGVROW = DGV_Row
                        Call InvokeDGVRemove()
                    End If
                Next DGV_Row

                DATATABLE.AcceptChanges()
                DATATABLE.WriteXml(File, XmlWriteMode.WriteSchema)

                Return
            End If

            Dim RemoveRows As New List(Of DataGridViewRow)
            For Each DGV_Row As DataGridViewRow In DGV.Rows
                If CInt(Id) = DGV_Row.Cells(0).Value Then
                    RemoveRows.Add(DGV_Row)
                    Exit For
                End If
            Next DGV_Row

            Try
                DATATABLE.Rows.Remove(DR(0))
            Catch ex As Exception

            Finally
                DATATABLE.AcceptChanges()
                DATATABLE.WriteXml(File, XmlWriteMode.WriteSchema)
            End Try

            For Each DGV_Row As DataGridViewRow In RemoveRows
                THIS_DGVROW = DGV_Row
                Call InvokeRemove()
            Next
        End Sub
        Private Sub InvokeRemove()
            If DGV.InvokeRequired Then
                Dim unused = DGV.Invoke(New MethodInvoker(AddressOf InvokeRemove))
            Else
                DGV.Rows.Remove(THIS_DGVROW)
            End If
        End Sub
        Private Sub InvokeDGVRemove()
            If DGV.InvokeRequired Then
                Call DGV.Invoke(New MethodInvoker(AddressOf InvokeDGVRemove))
            Else
                DGV.Rows.Remove(THIS_DGVROW)
            End If
        End Sub
#End Region
        Friend Sub Truncate()
            DATATABLE.Dispose()
            DGV.Rows.Clear()

            Call CreateDataTable()
        End Sub
        Private Sub CreateDataTable()
            DATATABLE = New Data.DataTable("JobList") With {
                .Locale = Globalization.CultureInfo.InvariantCulture
            }
            Using Column As New Data.DataColumn("ID", GetType(Integer))
                Column.AutoIncrement = True
                Column.AutoIncrementSeed = 1L
                Column.Unique = True
                DATATABLE.Columns.Add(Column)
            End Using

            DATATABLE.Columns.Add(New Data.DataColumn("DATETIME", GetType(Date)))
            DATATABLE.Columns.Add(New Data.DataColumn("REQUESTS", GetType(Utils.Requests)))
            DATATABLE.Columns.Add(New Data.DataColumn("PARAMETERS", GetType(String)))
            DATATABLE.AcceptChanges()

            DATATABLE.WriteXml(File, XmlWriteMode.WriteSchema)
        End Sub
        Private Sub AddDataGridviewRow(DR As Data.DataRow)
            Using DGVRow As New DataGridViewRow
                DGVRow.CreateCells(DGV)
                DGVRow.Cells(0).Value = Convert.ToInt32(DR.Item("ID"))
                DGVRow.Cells(1).Value = FormatDateTime(DR.Item("DATETIME"), DateFormat.GeneralDate)
                DGVRow.Cells(2).Value = Utils.GetRequestString(DR.Item("REQUESTS"))
                DGVRow.Cells(3).Value = DR.Item("PARAMETERS").ToString
                Dim unused = DGV.Rows.Add(DGVRow)
            End Using
            MESSAGES.LogMessages("Added Job: " & DR.Item("ID").ToString & "- " & Utils.GetRequestString(DR.Item("REQUESTS")) & "?" & DR.Item("PARAMETERS"), BroadcastTypes.Log)
            Application.DoEvents()
        End Sub
        Private Sub Timer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles Timer.Elapsed
            Timer.Stop()
            If DATATABLE.Rows.Count < 1 Then Timer.Start() : Return

            Dim DR() As Data.DataRow = DATATABLE.Select("", "ID ASC")
            Using ProcessJobsCommands As New ProcessJobsCommands(Me, DR(0).Item("REQUESTS"), DR(0).Item("PARAMETERS"), DR(0).Item("ID"), MESSAGES, CONNECTION, HTTPCLIENT)
                Call ProcessJobsCommands.Start()
            End Using

            GC.Collect()
            Timer.Start()
        End Sub
        Private NotInheritable Class ProcessJobsCommands : Implements IDisposable
            ' These variables are passed in, so dispose them in the calling class.
            Private ReadOnly MY_JOBLIST As Joblist
            Private ReadOnly MY_REQUEST As Utils.Requests = Nothing
            Private ReadOnly MY_PARAMETERS As String = Nothing
            Private ReadOnly MY_JOB_ID As String = Nothing
            Private ReadOnly CONNECTION As CascadeCommon.Utils.Connection
            Private ReadOnly HTTPCLIENT As Net.Http.HttpClient
            Private ReadOnly MESSAGES As CascadeCommon.Messages
            Friend Sub New(Joblist As Joblist, Request As Utils.Requests, Parameters As String, JobID As String, Messages As CascadeCommon.Messages, Connection As CascadeCommon.Utils.Connection, HttpClient As Net.Http.HttpClient)
                MY_JOBLIST = Joblist
                MY_REQUEST = Request
                MY_PARAMETERS = Parameters
                MY_JOB_ID = JobID
                Me.CONNECTION = Connection
                Me.MESSAGES = Messages
                Me.HTTPCLIENT = HttpClient
            End Sub
            Friend Sub Start()
                Dim ThisDay As String = Nothing
                ' Check to see if the command has parameters
                ' If the DAY parameter has a date specified, is it 0, if it is it's today else its the day specified.
                ' if DAY is not specified then DAY is today.
                If MY_PARAMETERS.ToUpperInvariant.Contains("DAY") Then
                    Dim Parameters() As String = Split(MY_PARAMETERS, "=")
                    ThisDay = If(Parameters(1) = "0", CStr(Today.ToOADate), Parameters(1))
                Else
                    ThisDay = CStr(Today.ToOADate)
                End If

                Call MESSAGES.LogMessages("Processing Job: " & Utils.GetRequestString(MY_REQUEST) & "?" & MY_PARAMETERS & " in server job list.", Utils.BroadcastTypes.Log)

                Select Case MY_REQUEST
                    Case Requests.DownloadXMLSchedule
                        Call DOWNLOAD_XML(ThisDay, "Schedule")
                        Exit Select

                    Case Requests.DownloadXMLResults
                        Call DOWNLOAD_XML(ThisDay, "Results")
                        Exit Select

                    Case Requests.LoadSQLSchedule
                        Call LOAD_SCHEDULE(ThisDay)
                        Exit Select

                    Case Requests.LoadSQLResults
                        Call LOAD_RESULTS(ThisDay)
                        Call TIDYUP(ThisDay)
                        Exit Select

                    Case Requests.LoadStats
                        Call LOAD_STATS(ThisDay)
                        Exit Select

                    Case Requests.RebuildIndexes
                        Call REBUILD_INDEXES()
                        Exit Select

                    Case Requests.CreateStatsGreyhoundsBarrier
                        Call CREATE_STATS_GREYHOUNDS_BARRIER(ThisDay)
                        Exit Select

                    Case Else
                        Call MESSAGES.LogMessages("An unknown request: " & Utils.GetRequestString(MY_REQUEST) & "?" & MY_PARAMETERS & " was not processed in the job list.", Utils.BroadcastTypes.Log)
                End Select

                MY_JOBLIST.Remove(MY_JOB_ID)
            End Sub
#Region "       The actual commands where we start the worker threads "
            ''' <summary>
            ''' Down load the Schedule for a given day.
            ''' </summary>
            ''' <param name="OADate"></param>
            ''' <param name="Force"></param>
            ''' <remarks>If Force is TRUE, Then delete the schedule.xml file to force it to download it again.</remarks>
            Private Sub DOWNLOAD_XML(OADate As String, XMLType As String)
                Dim Broadcast As String = "Download the XML " & XMLType & " for " & FormatDateTime(Date.FromOADate(OADate), DateFormat.LongDate).ToString
                Call MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)

                Using XMLCache As New XmlCache(XMLType, OADate, My.Settings.ScheduleFolder, My.Settings.ResultsFolder, "", MESSAGES, HTTPCLIENT)
                    Call XMLCache.DownLoadXml()
                End Using
            End Sub
            Private Sub LOAD_SCHEDULE(OADate As String)
                Dim Broadcast As String = "Download the SCHEDULE for " & FormatDateTime(Date.FromOADate(OADate), DateFormat.LongDate).ToString
                Call MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)

                Using Schedule As New Schedule(OADate, MESSAGES)
                    Schedule.Start()
                End Using
            End Sub
            Private Sub LOAD_RESULTS(OADate As String)
                Dim Broadcast As String = "Download the RESULTS for " & FormatDateTime(Date.FromOADate(OADate), DateFormat.LongDate).ToString
                Call MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)

                Using NewResults As New CascadeServerResults.EntryPoint(OADate, My.Settings.ResultsFolder, Me.CONNECTION.String, Me.MESSAGES)
                    Call NewResults.Start()
                End Using
            End Sub
            Private Sub LOAD_STATS(OADate As String)
                Dim Broadcast As String = "Create STATISTICS for " & FormatDateTime(Date.FromOADate(OADate), DateFormat.LongDate).ToString
                Call MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)

                Using StatsEP As New CascadeServerStatistics.EntryPoint(OADate, MESSAGES, CONNECTION.String)
                    Call StatsEP.Start()
                End Using
            End Sub
            Private Sub CREATE_STATS_GREYHOUNDS_BARRIER(OADate As String)
                Dim Broadcast As String = "Create Greyhounds Barrier STATISTICS for " & FormatDateTime(Date.FromOADate(OADate), DateFormat.LongDate).ToString
                Call MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)

                ' Database Connection is created in the class. Let the connection pool handle the rest.
                '                Using Stats As New Statistics.GreyHoundsBarrier(OADate, MESSAGES)
                '                    Call Stats.Start()
                '               End Using
            End Sub
            Private Sub REBUILD_INDEXES()
                Call SQL.Indexes.RebuildIndexes(CONNECTION, MESSAGES)
            End Sub
            Private Sub TIDYUP(OADate As String)
                Using NewTidyUp As New CascadeServerTidyUp.EntryPoint(OADate, MESSAGES, My.Settings.ConnectionString)
                    Call NewTidyUp.BeginTidyUp()
                End Using
            End Sub
#End Region
#Region "   IDisposable Support"
            Private disposedValue As Boolean ' To detect redundant calls

            ' IDisposable
            Private Sub Dispose(disposing As Boolean)
                If Not disposedValue Then
                    If disposing Then
                        '
                    End If

                    ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                    ' TODO: set large fields to null.
                End If
                disposedValue = True
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
End Namespace