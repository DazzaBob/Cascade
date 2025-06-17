Imports System.Net
Public NotInheritable Class XmlCache : Implements IDisposable
    Private CACHETYPE As String
    Private FOLDERFILE As String
    Private FOLDER As String
    Private SCHEDULEFOLDERFILE As String
    Private RESULTSFOLDERFILE As String
    Private TABTOKEN As String
    Private OADATE As String

    Private MESSAGES As Utils.Messages
    Private HTTPCLIENT As Http.HttpClient

    Friend Sub New()
        Me.CACHETYPE = Nothing
        Me.FOLDERFILE = Nothing
        Me.FOLDER = Nothing
        Me.SCHEDULEFOLDERFILE = Nothing
        Me.RESULTSFOLDERFILE = Nothing
        Me.TABTOKEN = Nothing
        Me.OADATE = Nothing
        Me.MESSAGES = Nothing
        Me.HTTPCLIENT = Nothing
    End Sub
    Public Sub New(cacheType As String, OADate As String, ScheduleFolder As String, ResultsFolder As String, Token As String, Messages As Utils.Messages, HttpClient As Http.HttpClient)
        Me.New

        Me.MESSAGES = Messages
        Me.HTTPCLIENT = HttpClient

        If cacheType Is Nothing Then
            cacheType = ""
        Else
            Me.CACHETYPE = cacheType
        End If
        '
        Me.OADATE = OADate
        Me.SCHEDULEFOLDERFILE = ScheduleFolder & "\" & OADate & "\schedule.xml"
        Me.RESULTSFOLDERFILE = ResultsFolder & "\" & OADate & "\results.xml"
        Me.TABTOKEN = Token
        '
        Select Case cacheType.ToUpperInvariant
            Case "SCHEDULE"
                Me.FOLDER = ScheduleFolder & "\" & OADate
                Me.FOLDERFILE = Me.SCHEDULEFOLDERFILE
                Exit Select
            Case "RESULTS"
                Me.FOLDER = ResultsFolder & "\" & OADate
                Me.FOLDERFILE = Me.RESULTSFOLDERFILE
                Exit Select
            Case Else
                ' Do nothing
        End Select
    End Sub
    Public Function GetXml() As String
        Dim THIS_STOPWATCH As Stopwatch = New Stopwatch
        THIS_STOPWATCH.Start()
        '
        Dim Broadcast As String = String.Empty
        Dim XML As String = Nothing
        '
        Broadcast = "Attempting to read local cache " & Me.FOLDERFILE & "..... "
        If CDbl(Me.OADATE) = Today.ToOADate Then
            Broadcast += "N/A" & Environment.NewLine
            If IO.Directory.Exists(Me.FOLDER) Then
                If IO.File.Exists(Me.FOLDERFILE) Then IO.File.Delete(Me.FOLDERFILE)
                IO.Directory.Delete(Me.FOLDER)
            End If
            XML = GetInternetXML().Result
        Else
            XML = ReadFile(Broadcast)
            If XML Is Nothing Then XML = GetInternetXML().Result
        End If
        '
        THIS_STOPWATCH.Stop()
        Broadcast += "Read local cache file to stream in: " & Utils.ElapsedTime(THIS_STOPWATCH) & "."
        Me.MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)
        '
        THIS_STOPWATCH = Nothing
        Return XML
    End Function
    Private Async Function GetInternetXML() As Task(Of String)
        If Not IO.Directory.Exists(Me.FOLDER) Then Call IO.Directory.CreateDirectory(Me.FOLDER)
        '
        Dim Uri As Uri = New Uri("http://xml.tab.co.nz/" & Me.CACHETYPE & "/" & Format(Date.FromOADate(CDbl(Me.OADATE)), "yyyy-MM-dd") & "?token=" & Me.TABTOKEN)
        Dim XML As String
        Dim Broadcast As String

        Try
            XML = Await HTTPCLIENT.GetStringAsync(Uri)
            Broadcast = "Downloaded and created file: " & Me.FOLDERFILE & Environment.NewLine
        Catch
            XML = Nothing
            Broadcast = "Could not download and create file: " & Me.FOLDERFILE & Environment.NewLine
        End Try
        Call WriteFile(XML)

        Me.MESSAGES.LogMessages(Broadcast, Utils.General.BroadcastTypes.Log)
        Return XML
    End Function
    Private Sub WriteFile(ByVal XML As String)
        Using SW As New IO.StreamWriter(Me.FOLDERFILE, False)
            SW.Write(XML)
            SW.Flush()
        End Using
    End Sub
    Private Function ReadFile(ByRef Broadcast As String) As String
        If IO.File.Exists(Me.FOLDERFILE) Then
            Using SR As New IO.StreamReader(Me.FOLDERFILE, True)
                ReadFile = SR.ReadToEnd
            End Using
            Broadcast = String.Concat(Broadcast, "File found!" & Environment.NewLine)
        Else
            ReadFile = Nothing
            Broadcast = String.Concat(Broadcast, "File not found!" & Environment.NewLine)
        End If
    End Function
#Region "   IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Private Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                Me.CACHETYPE = Nothing
                Me.FOLDERFILE = Nothing
                Me.FOLDER = Nothing
                Me.SCHEDULEFOLDERFILE = Nothing
                Me.RESULTSFOLDERFILE = Nothing
                Me.TABTOKEN = Nothing
                Me.OADATE = Nothing
            End If
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
    Friend Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class