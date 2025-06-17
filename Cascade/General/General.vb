Friend Module General
    Friend InvariantCulture As Globalization.CultureInfo = Globalization.CultureInfo.InvariantCulture
    Friend Const AreYouSure As String = "Are You Sure You Want To Do This?"
    Friend Const UnExpectedError As String = "An un-expected exception error has happened"
    Private LockObject As New Object
    Friend ReadOnly Property ReplaceHTML(sText As String) As String
        Get
            Dim MyText As String = Replace(sText, "&AMP;", " & ")
            '
            Return MyText
        End Get
    End Property
    Friend ReadOnly Property ALDistance(ByVal MeetingType As String, RaceLength As Int16) As ArrayList
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
    Friend ReadOnly Property GetTime(ByVal StopWatch As Stopwatch) As String
        Get
            If StopWatch.ElapsedMilliseconds <= 1L Then
                GetTime = FormatNumber(StopWatch.ElapsedTicks, 0) & " tick(s)"
            ElseIf StopWatch.ElapsedMilliseconds <= 1000L Then
                GetTime = FormatNumber(StopWatch.Elapsed.Milliseconds, 0) & " millisecond(s)"
            ElseIf StopWatch.ElapsedMilliseconds > 1000L AndAlso StopWatch.ElapsedMilliseconds <= 60000L Then
                GetTime = FormatNumber(StopWatch.ElapsedMilliseconds / 1000, 2) & " second(s)"
            Else
                GetTime = FormatNumber(StopWatch.Elapsed.Minutes, 0) & " minutes, " & FormatNumber(StopWatch.Elapsed.Seconds, 0) & " seconds"
            End If
        End Get
    End Property
    Friend Sub LogThreadDetails(ByVal Thread As Threading.Thread)
        SyncLock LockObject
            Dim Broadcast As String = "Thread " & CStr(Thread.ManagedThreadId) & " "
            If Not Thread.Name Is Nothing Then Broadcast += "Name=" & Thread.Name & ", "
            Broadcast += "Apartment State(" & Thread.GetApartmentState.ToString & "), "
            Broadcast += "Priority=" & Thread.Priority.ToString & ", "
            Broadcast += "Is Background=" & Thread.IsBackground.ToString
            Call ServerUI.Messages.LogMessages(Broadcast, BroadcastTypes.Log)
        End SyncLock
    End Sub
    Friend ReadOnly Property GetRequestString(ByVal Request As Cascade.Requests) As String
        Get
            Return System.Enum.GetName(GetType(Cascade.Requests), Request)
        End Get
    End Property
End Module
