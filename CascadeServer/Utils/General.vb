Namespace Utils
    Friend Module General
        Friend InvariantCulture As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
        Friend Const AreYouSure As String = "Are You Sure You Want To Do This?"
        Friend Const UnExpectedError As String = "An un-expected exception error has happened"
        Private ReadOnly LockObject As New Object
        Private ReadOnly ElapsedTimeLockObject As New Object
        <Flags>
        Friend Enum Requests As Integer
            None = 0
            DownloadXMLSchedule = 1
            DownloadXMLResults = 2
            LoadSQLSchedule = 3
            LoadSQLResults = 4
            LoadStats = 5
            CreateStatsGreyhoundsBarrier = 6
            TidyUp = 7
            DownloadYesterdaysResultsForce = 8
            ServerUI = 9
            ReportingUI = 10
            RerunModelsAll = 11
            DownloadYesterdaysResults = 12
            RebuildIndexes = 13
            DownloadDay = 14
            DownloadSchedule = 15
            RerunModels = 16
            DownloadResults = 17
            CheckModelResults = 18
            DownloadXml = 19
            DownloadScheduleForceReload = 21
        End Enum
        <Flags>
        Friend Enum NodeTypes As Integer
            Folder = 1
            Model = 2
            Clone = 3
            BaseFolder = 4
            None = 0
        End Enum
        <Flags>
        Friend Enum BroadcastTypes As Integer
            None = 0
            Log = 1
            [Error] = 2
        End Enum
        Friend ReadOnly Property ReplaceHTML(sText As String) As String
            Get
                Dim MyText As String = Replace(sText, "&AMP;", " & ")
                '
                Return MyText
            End Get
        End Property
        Friend ReadOnly Property ElapsedTime(StopWatch As Stopwatch) As String
            Get
                SyncLock ElapsedTimeLockObject
                    If StopWatch.Elapsed.Ticks < 10000 Then
                        Return FormatNumber(StopWatch.ElapsedTicks, 0) & " tick(s)"
                    End If

                    If StopWatch.Elapsed.Milliseconds < 1000 Then
                        Return FormatNumber(StopWatch.Elapsed.Milliseconds, 0) & " millisecond(s)"
                    End If

                    If StopWatch.Elapsed.Seconds < 60 Then
                        Return FormatNumber(StopWatch.Elapsed.Seconds, 0) & " second(s)"
                    End If

                    Return FormatNumber(StopWatch.Elapsed.Minutes, 0) & " minutes, " & FormatNumber(StopWatch.Elapsed.Seconds, 0) & " seconds"
                End SyncLock
            End Get
        End Property
        Friend Sub LogThreadDetails(Thread As Threading.Thread, Messages As Messages)
            SyncLock LockObject
                Dim Broadcast As String = "Thread " & Thread.ManagedThreadId & " "
                If Thread.Name IsNot Nothing Then Broadcast += "Name=" & Thread.Name & ", "
                Broadcast += "Apartment State(" & Thread.GetApartmentState.ToString & "), "
                Broadcast += "Priority=" & Thread.Priority.ToString & ", "
                Broadcast += "Is Background=" & Thread.IsBackground.ToString
                Call Messages.LogMessages(Broadcast, BroadcastTypes.Log)
            End SyncLock
        End Sub
        Friend ReadOnly Property GetRequestString(Request As Requests) As String
            Get
                Return System.Enum.GetName(GetType(Requests), Request)
            End Get
        End Property
        Friend Function ReadFile(File As String, ByRef Broadcast As String) As String
            If IO.File.Exists(File) Then
                Using SR As New IO.StreamReader(File, True)
                    ReadFile = SR.ReadToEnd
                End Using
                Broadcast += "File found!" & Environment.NewLine
            Else
                ReadFile = Nothing
                Broadcast += "File not found!" & Environment.NewLine
            End If
        End Function
        Friend Sub WriteFile(File As String, Value As String)
            Using SW As New IO.StreamWriter(File, False)
                SW.Write(Value)
                SW.Flush()
            End Using
        End Sub
    End Module
End Namespace