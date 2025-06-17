Namespace Utils
    Friend Module General
        Friend Const MinOADate As Integer = 39766

        Friend InvariantCulture As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
        Friend Const AreYouSure As String = "Are You Sure You Want To Do This?"
        Friend Const UnExpectedError As String = "An un-expected exception error has happened"
        Private ReadOnly ElapsedTimeLockObject As New Object
        <Flags>
        Friend Enum Requests As Integer
            None = 0
            Connect = 1
            Disconnect = 2
            DataTransfer = 3
            StringTransfer = 4
            ByteTransfer = 5
            GetStatus = 6
            Connected = 7
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
        Public Enum BroadcastTypes As Integer
            None = 0
            Log = 1
            [Error] = 2
        End Enum
        Public ReadOnly Property ReplaceHTML(sText As String) As String
            Get
                Dim MyText As String = Replace(sText, "&AMP;", " & ")
                '
                Return MyText
            End Get
        End Property
        Public ReadOnly Property ALDistance(ByVal MeetingType As String, RaceLength As Int16) As ArrayList
            Get
                ALDistance = New ArrayList
                Select Case UCase(MeetingType)
                    Case "G" ' Its a Gallops race
                        Select Case RaceLength
                            Case Is < 1251 ' Short Distance
                                ALDistance.Add(0)
                                ALDistance.Add(1251)
                                Exit Select
                            Case Is > 1749 ' Long Distance
                                ALDistance.Add(1950)
                                ALDistance.Add(9999)
                                Exit Select
                            Case Else
                                ALDistance.Add(1250) ' Medium Distance
                                ALDistance.Add(1951)
                        End Select
                        Exit Select
                    Case "GR" ' Its a Greyhounds race
                        Select Case RaceLength
                            Case Is < 391 ' Short Distance
                                ALDistance.Add(0)
                                ALDistance.Add(391)
                                Exit Select
                            Case Is > 546 ' Long Distance
                                ALDistance.Add(546)
                                ALDistance.Add(9999)
                                Exit Select
                            Case Else ' Medium Distance
                                ALDistance.Add(390)
                                ALDistance.Add(547)
                        End Select
                        Exit Select
                    Case Else ' Must be a harness race
                        Select Case RaceLength
                            Case Is < 1751 ' Short Distance
                                ALDistance.Add(0)
                                ALDistance.Add(1751)
                                Exit Select
                            Case Is > 2249
                                ALDistance.Add(2249)
                                ALDistance.Add(9999)
                                Exit Select
                            Case Else ' Medium Distance
                                ALDistance.Add(1750)
                                ALDistance.Add(2250)
                        End Select
                        Exit Select
                End Select
            End Get
        End Property
        Public ReadOnly Property ElapsedTime(StopWatch As Stopwatch) As String
            Get
                SyncLock ElapsedTimeLockObject
                    Select Case StopWatch.ElapsedMilliseconds
                        Case <= 1
                            Return FormatNumber(StopWatch.ElapsedTicks, 0) & " tick(s)"
                        Case <= 1000
                            Return FormatNumber(StopWatch.Elapsed.Milliseconds, 0) & " millisecond(s)"
                        Case > 1000, < 60000
                            Return FormatNumber(StopWatch.ElapsedMilliseconds / 1000, 2) & " second(s)"
                        Case Else
                            Return FormatNumber(StopWatch.Elapsed.Minutes, 0) & " minutes, " & FormatNumber(StopWatch.Elapsed.Seconds, 0) & " seconds"
                    End Select
                End SyncLock
            End Get
        End Property
        Public ReadOnly Property GetRequestString(Request As Requests) As String
            Get
                Return System.Enum.GetName(GetType(Requests), Request)
            End Get
        End Property
    End Module
End Namespace