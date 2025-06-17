Public NotInheritable Class Messages
    Private ReadOnly LOGFOLDER As String
    Private ReadOnly ERRORFOLDER As String
    Friend Sub New()
        Me.LOGFOLDER = Nothing
        Me.ERRORFOLDER = Nothing
    End Sub
    Public Sub New(LogFolder As String, ErrorFolder As String)
        Me.New
        Me.LOGFOLDER = LogFolder
        Me.ERRORFOLDER = ErrorFolder
    End Sub
    Public Sub LogMessages(logText As String, type As BroadcastTypes)
        Dim LogThis As String

        Select Case type
            Case BroadcastTypes.Log
                LogThis = "LOG: "
            Case BroadcastTypes.Error
                LogThis = "ERR: "
            Case Else
                LogThis = "UNK: "
        End Select
        LogThis += "Thread (" & Environment.CurrentManagedThreadId.ToString & ") "
        LogThis += Strings.Left(logText, 2048)

        Call StartLogging(Date.Now.ToShortDateString & " " & Date.Today.ToShortTimeString & " - " & LogThis, type)
    End Sub
    Public Sub LogMessages(logText As String, type As BroadcastTypes, MessagesInMemory As InMemory)
        Call LogMessages(logText, type)

        If MessagesInMemory IsNot Nothing Then Call MessagesInMemory.AddNew(Date.Now, logText)
    End Sub
#Region "       THE ACTUAL LOGGING "
    Private Sub StartLogging(ByVal logthis As String, ByVal BroadcastType As BroadcastTypes)
        Dim bLogThis() As Byte = System.Text.Encoding.UTF8.GetBytes(logthis & Environment.NewLine)

        Select Case BroadcastType
            Case BroadcastTypes.Log
                Call WriteLog(bLogThis)
            Case BroadcastTypes.Error
                Call WriteLog(bLogThis)
                Call WriteError(bLogThis)
            Case Else
                Return
        End Select
    End Sub
    Private Sub WriteLog(bLogThis() As Byte)
        Dim sDATE As String = FormatDateTime(Today, DateFormat.ShortDate)
        sDATE = Replace(sDATE, "/", "_")
        '
        If Not IO.File.Exists(Me.LOGFOLDER & "\" & sDATE & ".log") Then
            Using FS As New IO.FileStream(Me.LOGFOLDER & "\" & sDATE & ".log", IO.FileMode.OpenOrCreate, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                FS.Write(bLogThis, 0, bLogThis.Length)
                FS.Flush()
            End Using
        Else
            Using FS As New IO.FileStream(Me.LOGFOLDER & "\" & sDATE & ".log", IO.FileMode.Append, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                FS.Write(bLogThis, 0, bLogThis.Length)
                FS.Flush()
            End Using
        End If
    End Sub
    Private Sub WriteError(bLogThis() As Byte)
        Dim sDATE As String = FormatDateTime(Today, DateFormat.ShortDate)
        sDATE = Replace(sDATE, "/", "_")
        '
        If Not IO.File.Exists(Me.ERRORFOLDER & "\" & sDATE & ".err") Then
            Using FS As New IO.FileStream(Me.ERRORFOLDER & "\" & sDATE & ".err", IO.FileMode.OpenOrCreate, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                FS.Write(bLogThis, 0, bLogThis.Length)
                FS.Flush()
            End Using
        Else
            Using FS As New IO.FileStream(Me.ERRORFOLDER & "\" & sDATE & ".err", IO.FileMode.Append, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                FS.Write(bLogThis, 0, bLogThis.Length)
                FS.Flush()
            End Using
        End If
    End Sub
#End Region
End Class