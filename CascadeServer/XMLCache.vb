Friend NotInheritable Class XmlCache : Implements IDisposable
    Private CACHETYPE As String
    Private FOLDERFILE As String
    Private FOLDER As String
    Private SCHEDULEFOLDERFILE As String
    Private RESULTSFOLDERFILE As String
    Private TABTOKEN As String
    Private OADATE As String

    Private ReadOnly MESSAGES As CascadeCommon.Messages
    Private ReadOnly HTTPCLIENT As Net.Http.HttpClient
    Private Sub New()
        CACHETYPE = Nothing
        FOLDERFILE = Nothing
        FOLDER = Nothing
        SCHEDULEFOLDERFILE = Nothing
        RESULTSFOLDERFILE = Nothing
        TABTOKEN = Nothing
        OADATE = Nothing
        MESSAGES = Nothing
        HTTPCLIENT = Nothing
    End Sub
    Friend Sub New(cacheType As String, OADate As String, ScheduleFolder As String, ResultsFolder As String, Token As String, Messages As CascadeCommon.Messages, HttpClient As Net.Http.HttpClient)
        Me.New

        Me.MESSAGES = Messages
        Me.HTTPCLIENT = HttpClient

        If cacheType Is Nothing Then
            cacheType = String.Empty
        Else
            Me.CACHETYPE = cacheType.ToLower
        End If
        '
        Me.OADATE = OADate
        SCHEDULEFOLDERFILE = ScheduleFolder & "\" & OADate & "\schedule.xml"
        RESULTSFOLDERFILE = ResultsFolder & "\" & OADate & "\results.xml"
        TABTOKEN = Token
        '
        Select Case cacheType.ToUpperInvariant
            Case "SCHEDULE"
                FOLDER = ScheduleFolder & "\" & OADate
                FOLDERFILE = SCHEDULEFOLDERFILE
                Exit Select
            Case "RESULTS"
                FOLDER = ResultsFolder & "\" & OADate
                FOLDERFILE = RESULTSFOLDERFILE
                Exit Select
            Case Else
                ' Do nothing
        End Select
    End Sub
    Friend Sub DownLoadXml()
        Dim THIS_STOPWATCH As New Stopwatch
        THIS_STOPWATCH.Start()

        Dim Broadcast As String = String.Empty
        Dim XML As String = Nothing

        Broadcast = "Attempting to read local cache " & FOLDERFILE & "..... "
        If (CDbl(OADATE) = Today.ToOADate - 1) OrElse (CDbl(OADATE) = Today.ToOADate) Then
            If IO.Directory.Exists(FOLDER) Then
                If IO.File.Exists(FOLDERFILE) Then IO.File.Delete(FOLDERFILE)
                IO.Directory.Delete(FOLDER)
            End If
        End If

        If Not IO.Directory.Exists(FOLDER) Then
            Call IO.Directory.CreateDirectory(FOLDER)
            XML = GetInternetXML().Result
        Else
            If IO.File.Exists(FOLDERFILE) Then
                XML = Utils.ReadFile(FOLDERFILE, Broadcast)
            End If

            If XML Is Nothing Then XML = GetInternetXML().Result
        End If
        THIS_STOPWATCH.Stop()
        Broadcast += "Read local cache file to stream in: " & Utils.ElapsedTime(THIS_STOPWATCH) & "."
        MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)

        THIS_STOPWATCH = Nothing
        XML = Nothing
    End Sub
    Private Async Function GetInternetXML() As Task(Of String)
        If Not IO.Directory.Exists(FOLDER) Then Call IO.Directory.CreateDirectory(FOLDER)
        '
        Dim Uri As New Uri("http://xml.tab.co.nz/" & CACHETYPE & "/" & Format(Date.FromOADate(OADATE), "yyyy-MM-dd"))
        Dim XML As String
        Dim Broadcast As String

        Try
            XML = Await HTTPCLIENT.GetStringAsync(Uri)
            Broadcast = "Downloaded and created file: " & FOLDERFILE & Environment.NewLine
        Catch
            XML = Nothing
            Broadcast = "Could not download and create file: " & FOLDERFILE & Environment.NewLine
        End Try
        Call Utils.WriteFile(FOLDERFILE, XML)

        MESSAGES.LogMessages(Broadcast, Utils.General.BroadcastTypes.Log)
        Return XML
    End Function

#Region "   IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Private Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                CACHETYPE = Nothing
                FOLDERFILE = Nothing
                FOLDER = Nothing
                SCHEDULEFOLDERFILE = Nothing
                RESULTSFOLDERFILE = Nothing
                TABTOKEN = Nothing
                OADATE = Nothing
            End If
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
    Friend Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class