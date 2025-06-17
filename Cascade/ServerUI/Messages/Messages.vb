Namespace ServerUI
    Friend NotInheritable Class Messages
        Private Shared LogMessages_LockObject As New Object
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared Sub LogMessages(ByVal logText As String, type As BroadcastTypes)
            SyncLock LogMessages_LockObject
                Dim LogThis As String = ""
                Dim NOW As Date = Date.Now
                Dim DateTime As String = NOW.ToShortDateString & " " & NOW.ToShortTimeString
                '
                Select Case type
                    Case BroadcastTypes.Log
                        LogThis = "LOG: "
                    Case BroadcastTypes.Error
                        LogThis = "ERR: "
                    Case Else
                        LogThis = "UNK: "
                End Select
                LogThis += "Thread (" & CStr(Threading.Thread.CurrentThread.ManagedThreadId) & ") "
                LogThis += Strings.Left(logText, 2048)
                '
                Call InMemory.AddNew(NOW, LogThis)
                '
                Dim WTL As New WriteToLog(DateTime & " - " & LogThis, type)
                WTL.Start() : WTL = Nothing
            End SyncLock
        End Sub
#Region "       THE ACTUAL LOGGING, START A NEW THREAD TO LOG THE MESSAGE "
        Private NotInheritable Class WriteToLog
            Private MY_LINE() As Byte = Nothing
            Private MY_BROADCASTTYPE As BroadcastTypes = BroadcastTypes.None
            Friend Sub New(ByVal logthis As String, ByVal Type As BroadcastTypes)
                MY_LINE = System.Text.Encoding.UTF8.GetBytes(logthis & Environment.NewLine)
                MY_BROADCASTTYPE = Type
            End Sub
            Friend Sub Start() ' Can be used in Single Thread also, just by calling start.
                Select Case MY_BROADCASTTYPE
                    Case BroadcastTypes.Log
                        Call WriteLog() ' Synclocked
                    Case BroadcastTypes.Error
                        Call WriteLog() ' Synclocked
                        Call WriteError() ' Synclocked
                    Case Else
                        Return
                End Select
            End Sub
            Private Sub WriteLog()
                Dim sDATE As String = FormatDateTime(Today, DateFormat.ShortDate)
                sDATE = Replace(sDATE, "/", "_")
                '
                If Not IO.File.Exists(My.Settings.LogFolder & "\" & sDATE & ".log") Then
                    Using FS As IO.FileStream = New IO.FileStream(My.Settings.LogFolder & "\" & sDATE & ".log", IO.FileMode.OpenOrCreate, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                        FS.Write(MY_LINE, 0, MY_LINE.Length)
                        FS.Flush()
                    End Using
                Else
                    Using FS As IO.FileStream = New IO.FileStream(My.Settings.LogFolder & "\" & sDATE & ".log", IO.FileMode.Append, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                        FS.Write(MY_LINE, 0, MY_LINE.Length)
                        FS.Flush()
                    End Using
                End If
            End Sub
            Private Sub WriteError()
                Dim sDATE As String = FormatDateTime(Today, DateFormat.ShortDate)
                sDATE = Replace(sDATE, "/", "_")
                '
                If Not IO.File.Exists(My.Settings.ErrorFolder & "\" & sDATE & ".err") Then
                    Using FS As IO.FileStream = New IO.FileStream(My.Settings.ErrorFolder & "\" & sDATE & ".err", IO.FileMode.OpenOrCreate, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                        FS.Write(MY_LINE, 0, MY_LINE.Length)
                        FS.Flush()
                    End Using
                Else
                    Using FS As IO.FileStream = New IO.FileStream(My.Settings.ErrorFolder & "\" & sDATE & ".err", IO.FileMode.Append, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                        FS.Write(MY_LINE, 0, MY_LINE.Length)
                        FS.Flush()
                    End Using
                End If
            End Sub
        End Class

#End Region
    End Class
End Namespace