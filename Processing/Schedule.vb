Public NotInheritable Class Schedule : Implements IDisposable
    Private MY_OADATE As String
    Private CONNECTION As Utils.Connection
    Private MESSAGES As Utils.Messages
    Private INMEMORYMESSAGES As Utils.Messages.InMemory
    Public Sub New(ByVal meetingDate As String, ByVal Connection As Utils.Connection, Messages As Utils.Messages, InMemoryMessages As Utils.Messages.InMemory)
        MY_OADATE = meetingDate
        Me.CONNECTION = Connection

        Me.MESSAGES = Messages
        Me.INMEMORYMESSAGES = InMemoryMessages
    End Sub
    Public Sub Start()
        ' Create the Connection in the STARTing method, so its in context if we are running multiple threads.
        Call Utils.LogThreadDetails(Threading.Thread.CurrentThread, Me.MESSAGES)
        '
        Dim This_Stopwatch As Stopwatch = New Stopwatch
        Dim Broadcast As String
        Dim This_ScheduleXML As String = Nothing
        '
        This_Stopwatch.Start()
        '
        Broadcast = "*****     START SCHEDULE LOAD FOR " & FormatDateTime(Date.FromOADate(CDbl(MY_OADATE)), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
        Call Me.MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log, Me.INMEMORYMESSAGES)
        '
        Using XMLCache As XmlCache = New XmlCache("schedule", MY_OADATE, Nothing, Nothing, Nothing, Me.MESSAGES, Nothing)
            This_ScheduleXML = XMLCache.GetXml
            '
            ' Load the XML, then test to see if its nothing. ToUpperInvariant throws an execption if the XML is nothing.
            If This_ScheduleXML IsNot Nothing Then This_ScheduleXML = This_ScheduleXML.ToUpperInvariant
        End Using
        '
        ' If there was no schedule data in the local cache and not on the TAB; there is nothing to do.
        ' We found some data to work with so start doing some work.
        If This_ScheduleXML IsNot Nothing Then
            Try
                Using NZLoader As New XmlLoader(This_ScheduleXML, Me.MESSAGES, Me.CONNECTION, New List(Of String)({"GR"}))
                    Call BeginInsertMeetings(NZLoader.ListOfMeetingInformation)
                    Call Me.MESSAGES.LogMessages("Load race schedule, done!", Utils.BroadcastTypes.Log, Me.INMEMORYMESSAGES)
                End Using
            Catch EX As Exception
                Call Me.MESSAGES.LogMessages(EX.ToString, Utils.BroadcastTypes.Error, Me.INMEMORYMESSAGES)
                Call Me.MESSAGES.LogMessages("Load race schedule, done, but with errors!", Utils.BroadcastTypes.Error, Me.INMEMORYMESSAGES)
            End Try
        End If
        '
        Broadcast = "*****     FINISHED SCHEDULE LOAD FOR " & FormatDateTime(Date.FromOADate(CDbl(MY_OADATE)), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
        Call Me.MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log, Me.INMEMORYMESSAGES)
        This_Stopwatch.Stop()
        Broadcast = "*****     TIME TAKEN TO LOAD DAY: " & Utils.ElapsedTime(This_Stopwatch) & "     *****"
        Call Me.MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log, Me.INMEMORYMESSAGES)
    End Sub
    Private Sub BeginInsertMeetings(ByRef ListOf_MeetingInformation As List(Of Instance.MeetingInformation))
        ' ABANDONED Meetings are removed in the Loader.
        '
        If (ListOf_MeetingInformation Is Nothing) OrElse (ListOf_MeetingInformation.Count = 0) Then
            Me.MESSAGES.LogMessages("There are no meetings to process.", Utils.BroadcastTypes.Log, Me.INMEMORYMESSAGES)
            Return ' There are no meetings to process
        End If
        '
        Dim THIS_STOPWATCH As Stopwatch = New Stopwatch
        Dim BROADCAST As String = Nothing, CMDTEXT As String = Nothing
        BROADCAST = "Attempting to construct meetings ....."
        Call Me.MESSAGES.LogMessages(BROADCAST, Utils.BroadcastTypes.Log, Me.INMEMORYMESSAGES)
        '
        THIS_STOPWATCH.Reset() : THIS_STOPWATCH.Start()
        CMDTEXT = "DELETE FROM MEETING_XML WHERE OADATE =" & MY_OADATE
        Me.CONNECTION.Execute(CMDTEXT)
        THIS_STOPWATCH.Stop()
        Call Me.MESSAGES.LogMessages("Deleted Meetings for " & FormatDateTime(Date.FromOADate(CDbl(MY_OADATE)), DateFormat.LongDate) & " in: " & Utils.ElapsedTime(THIS_STOPWATCH) & ".", Utils.BroadcastTypes.Log, Me.INMEMORYMESSAGES)
        '
        Using InsertUpdate As New InsertMeetings(ListOf_MeetingInformation, Me.CONNECTION, Me.MESSAGES)
            Call InsertUpdate.Begin()
        End Using
        '
        BROADCAST = "Meetings constructed ....."
        Call Me.MESSAGES.LogMessages(BROADCAST, Utils.BroadcastTypes.Log, Me.INMEMORYMESSAGES)
    End Sub

#Region "       IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Friend Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' 
            End If
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
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class