Public Module Common
    Private ReadOnly ReplaceHTMLObjectLock As New Object
    Private ReadOnly ReadFileObjectLock As New Object
    Private ReadOnly ElapsedTimeLockObject As New Object
    Public Enum BroadcastTypes As Integer
        None = 0
        Log = 1
        [Error] = 2
    End Enum
    Public Function ReplaceHTML(sText As String) As String
        SyncLock ReplaceHTMLObjectLock
            Dim MyText As String = Replace(sText, "&AMP;", " & ")
            Return MyText
        End SyncLock
    End Function
    Public Function ReadFile(File As String, ByRef Broadcast As String) As String
        SyncLock ReadFileObjectLock
            If IO.File.Exists(File) Then
                Using SR As New IO.StreamReader(File, True)
                    ReadFile = SR.ReadToEnd
                End Using
                Broadcast += "File found!" & Environment.NewLine
            Else
                ReadFile = Nothing
                Broadcast += "File not found!" & Environment.NewLine
            End If
        End SyncLock
    End Function
    Public Function ElapsedTime(StopWatch As Stopwatch) As String
        SyncLock ElapsedTimeLockObject
            If StopWatch.Elapsed.Milliseconds < 1 Then
                Return FormatNumber(StopWatch.ElapsedTicks, 0) & " tick(s)"
            End If

            If StopWatch.Elapsed.Seconds < 1 Then
                Return FormatNumber(StopWatch.Elapsed.Milliseconds, 0) & " millisecond(s)"
            End If

            If StopWatch.Elapsed.Minutes < 1 Then
                Return FormatNumber(StopWatch.Elapsed.Seconds, 0) & " second(s)"
            End If

            Return FormatNumber(StopWatch.Elapsed.Minutes, 0) & " minutes, " & FormatNumber(StopWatch.Elapsed.Seconds, 0) & " seconds"
        End SyncLock
    End Function
End Module
