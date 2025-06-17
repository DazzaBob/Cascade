Imports System.Net
Namespace Processing
    Friend NotInheritable Class XmlCache : Implements IDisposable
        Private MY_CACHETYPE As String = Nothing
        Private MY_FOLDERFILE As String = Nothing
        Private MY_FOLDER As String = Nothing
        Private MY_SCHEDULEFOLDERFILE As String = Nothing
        Private MY_RESULTSFOLDERFILE As String = Nothing
        Private MY_TABTOKEN As String = Nothing
        Private MY_OADATE As String = Nothing
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Sub New(ByVal cacheType As String, ByVal [date] As String)
            If cacheType Is Nothing Then
                cacheType = ""
            Else
                MY_CACHETYPE = cacheType
            End If
            '
            MY_OADATE = [date]
            MY_SCHEDULEFOLDERFILE = My.Settings.ScheduleFolder & "\" & [date] & "\schedule.xml"
            MY_RESULTSFOLDERFILE = My.Settings.ResultsFolder & "\" & [date] & "\results.xml"
            MY_TABTOKEN = My.Settings.Token
            '
            Select Case cacheType.ToUpperInvariant
                Case "SCHEDULE"
                    MY_FOLDER = My.Settings.ScheduleFolder & "\" & [date]
                    MY_FOLDERFILE = MY_SCHEDULEFOLDERFILE
                    Exit Select
                Case "RESULTS"
                    MY_FOLDER = My.Settings.ResultsFolder & "\" & [date]
                    MY_FOLDERFILE = MY_RESULTSFOLDERFILE
                    Exit Select
                Case Else
                    ' Do nothing
            End Select
        End Sub
        Friend Function GetXml() As String
            Dim THIS_STOPWATCH As Stopwatch = New Stopwatch
            THIS_STOPWATCH.Start()
            '
            Dim Broadcast As String = ""
            Dim XML As String = Nothing
            '
            Broadcast = String.Concat(Broadcast, "Attempting to read local cache " & MY_FOLDERFILE & "..... ")
            If CDbl(MY_OADATE) = Today.ToOADate Then
                Broadcast = String.Concat(Broadcast, "N/A" & Environment.NewLine)
                If IO.Directory.Exists(MY_FOLDER) Then
                    If IO.File.Exists(MY_FOLDERFILE) Then IO.File.Delete(MY_FOLDERFILE)
                    IO.Directory.Delete(MY_FOLDER)
                End If
                XML = GetInternetXML(Broadcast)
            Else
                XML = ReadFile(Broadcast)
                If XML Is Nothing Then XML = GetInternetXML(Broadcast)
            End If
            '
            THIS_STOPWATCH.Stop()
            Broadcast = String.Concat(Broadcast, "Read local cache file to stream in: " & Cascade.GetTime(THIS_STOPWATCH) & ".")
            Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
            '
            THIS_STOPWATCH = Nothing
            Return XML
        End Function
        Private Function GetInternetXML(ByRef Broadcast As String) As String
            If Not IO.Directory.Exists(MY_FOLDER) Then Call IO.Directory.CreateDirectory(MY_FOLDER)
            '
            Dim Uri As Uri = New Uri("http://xml.tab.co.nz/" & MY_CACHETYPE & "/" & Format(Date.FromOADate(CDbl(MY_OADATE)), "yyyy-MM-dd") & "?token=" & MY_TABTOKEN)
            Dim XML As String
            '                
            Try
                Using WC As New WebClient
                    XML = WC.DownloadString(Uri)
                    Call WriteFile(XML)
                End Using
                Broadcast = String.Concat(Broadcast, "Downloaded and created file: " & MY_FOLDERFILE & Environment.NewLine)
            Catch
                XML = Nothing
                Broadcast = String.Concat(Broadcast, "Could not download and create file: " & MY_FOLDERFILE & Environment.NewLine)
            End Try
            Return XML
        End Function
        Private Sub WriteFile(ByVal XML As String)
            Using SW As New IO.StreamWriter(MY_FOLDERFILE, False)
                SW.Write(XML)
                SW.Flush()
            End Using
        End Sub
        Private Function ReadFile(ByRef Broadcast As String) As String
            If IO.File.Exists(MY_FOLDERFILE) Then
                Using SR As New IO.StreamReader(MY_FOLDERFILE, True)
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
                    '
                End If
                MY_CACHETYPE = Nothing
                MY_FOLDERFILE = Nothing
                MY_FOLDER = Nothing
                MY_OADATE = Nothing
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
        Friend Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region
    End Class
End Namespace