Imports System.Timers
Public NotInheritable Class Messages
    Private ReadOnly LogFolder As String
    Private ReadOnly ErrorFolder As String
    Private ReadOnly RTBMessages As RichTextBox
    Private LOGTHIS As String
    Private ALMessages As ArrayList
    Private WithEvents LogTheMessagesTimer As System.Timers.Timer
    Public Sub New()
        RTBMessages = Nothing
        LOGTHIS = Nothing
        ALMessages = New ArrayList
        LogTheMessagesTimer = New Timers.Timer(1000)
        Call Me.LogTheMessagesTimer.Start()
    End Sub
    Public Sub New(LogFolder As String, ErrorFolder As String)
        Me.New
        Me.LogFolder = LogFolder
        Me.ErrorFolder = ErrorFolder
    End Sub
    Public Sub New(ByRef RTBMessages As RichTextBox, LogFolder As String, ErrorFolder As String)
        Me.New(LogFolder, ErrorFolder)
        Me.RTBMessages = RTBMessages
    End Sub
    Public Sub LogMessages(logText As String, type As BroadcastTypes)
        LOGTHIS = Date.Now.ToShortDateString & " " & Date.Now.ToShortTimeString & " - "

        Select Case type
            Case BroadcastTypes.Log
                LOGTHIS += "LOG: "
            Case BroadcastTypes.Error
                LOGTHIS += "ERR: "
            Case Else
                LOGTHIS += "UNK: "
        End Select

        LOGTHIS += "Thread (" & Environment.CurrentManagedThreadId.ToString & ") "
        LOGTHIS += Strings.Left(logText, 2048)

        Me.ALMessages.Add(New NewMessage(LOGTHIS, type))
        If Me.RTBMessages IsNot Nothing Then Call UpdateUI()
    End Sub
    Private Sub UpdateUI()
        If RTBMessages.InvokeRequired Then
            Call RTBMessages.Invoke(New MethodInvoker(AddressOf UpdateUI))
        Else
            RTBMessages.SuspendLayout()
            RTBMessages.SelectionStart = 0
            RTBMessages.SelectionLength = 0
            RTBMessages.SelectedText = LOGTHIS & Environment.NewLine
            If RTBMessages.TextLength > 10240I Then
                RTBMessages.SelectionStart = 10240
                RTBMessages.SelectionLength = RTBMessages.TextLength - 10240
                RTBMessages.SelectedText = String.Empty
            End If
            RTBMessages.ResumeLayout()
            RTBMessages.Invalidate()
        End If
    End Sub
    Private Sub LogTheMessagesTimer_Elapsed(sender As Object, e As ElapsedEventArgs) Handles LogTheMessagesTimer.Elapsed
        If Me.ALMessages Is Nothing Then Me.ALMessages = New ArrayList : Return
        If Me.ALMessages.Count = 0 Then Return

        Me.LogTheMessagesTimer.Stop()

        Do Until Me.ALMessages.Count = 0
            Dim ThisMessage As NewMessage = Me.ALMessages(0)
            Call StartLogging(ThisMessage.Message, ThisMessage.BrocastType)

            Me.ALMessages.RemoveAt(0)
        Loop

        Me.LogTheMessagesTimer.Start()
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
        Try
            If Not IO.File.Exists(LogFolder & "\" & sDATE & ".log") Then
                Using FS As New IO.FileStream(LogFolder & "\" & sDATE & ".log", IO.FileMode.OpenOrCreate, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                    FS.Write(bLogThis, 0, bLogThis.Length)
                    FS.Flush()
                End Using
            Else
                Using FS As New IO.FileStream(LogFolder & "\" & sDATE & ".log", IO.FileMode.Append, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                    FS.Write(bLogThis, 0, bLogThis.Length)
                    FS.Flush()
                End Using
            End If
        Catch ex As Exception
            ' Whoops. we cant write the file.
        End Try
    End Sub
    Private Sub WriteError(bLogThis() As Byte)
        Dim sDATE As String = FormatDateTime(Today, DateFormat.ShortDate)
        sDATE = Replace(sDATE, "/", "_")
        '
        If Not IO.File.Exists(ErrorFolder & "\" & sDATE & ".err") Then
            Using FS As New IO.FileStream(ErrorFolder & "\" & sDATE & ".err", IO.FileMode.OpenOrCreate, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                FS.Write(bLogThis, 0, bLogThis.Length)
                FS.Flush()
            End Using
        Else
            Using FS As New IO.FileStream(ErrorFolder & "\" & sDATE & ".err", IO.FileMode.Append, IO.FileAccess.Write, IO.FileShare.ReadWrite)
                FS.Write(bLogThis, 0, bLogThis.Length)
                FS.Flush()
            End Using
        End If
    End Sub
#End Region
    Private NotInheritable Class NewMessage
        Private _BroadcastType As BroadcastTypes
        Private _Message As String
        Friend Sub New()
            Me._BroadcastType = BroadcastTypes.None
            Me._Message = String.Empty
        End Sub
        Friend Sub New(Message As String, BroadcastType As BroadcastTypes)
            Me.New
            Me._BroadcastType = BroadcastType
            Me._Message = Message
        End Sub
        Friend Property BrocastType As BroadcastTypes
            Get
                Return Me._BroadcastType
            End Get
            Set(value As BroadcastTypes)
                Me._BroadcastType = value
            End Set
        End Property
        Friend Property Message As String
            Get
                Return Me._Message
            End Get
            Set(value As String)
                Me._Message = value
            End Set
        End Property
    End Class
End Class