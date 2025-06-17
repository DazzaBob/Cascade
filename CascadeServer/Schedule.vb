Friend NotInheritable Class Schedule : Implements IDisposable
    Private ReadOnly OADate As String
    Private ReadOnly Connection As CascadeCommon.Utils.Connection
    Private ReadOnly Messages As CascadeCommon.Messages
    Private Sub New()
        OADate = String.Empty
    End Sub
    Friend Sub New(OADate As String, Messages As CascadeCommon.Messages)
        Me.New

        Me.OADate = OADate
        Me.Messages = Messages

        Connection = New CascadeCommon.Utils.Connection(My.Settings.ConnectionString, Messages)
    End Sub
    Friend Sub Start()
        Dim Broadcast As String = "*****     START SCHEDULE LOAD FOR " & FormatDateTime(Date.FromOADate(OADate), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
        Call MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)

        Dim This_Stopwatch As New Stopwatch

        This_Stopwatch.Start()
        Call SQL.MeetingXML.DeleteMeeting(OADate, CONNECTION)
        This_Stopwatch.Stop()
        Call MESSAGES.LogMessages("Deleted Meetings for " & FormatDateTime(Date.FromOADate(OADate), DateFormat.LongDate) & " in: " & Utils.ElapsedTime(This_Stopwatch) & ".", Utils.BroadcastTypes.Log)

        This_Stopwatch.Reset() : This_Stopwatch.Start()
        Dim XML As String = Utils.ReadFile(My.Settings.ScheduleFolder & "\" & OADate & "\schedule.xml", Broadcast)
        If XML IsNot Nothing Then
            ' Load the XML, then test to see if its nothing. ToUpperInvariant throws an execption if the XML is nothing.
            XML = XML.ToUpperInvariant
            Try
                Using NZLoader As New XmlLoader(XML, MESSAGES, CONNECTION)
                    Call BeginInsertMeetings(NZLoader.ListOfMeetingInformation)
                    Call MESSAGES.LogMessages("Load race schedule, done!", Utils.BroadcastTypes.Log)
                End Using
            Catch EX As Exception
                Call MESSAGES.LogMessages(EX.ToString, Utils.BroadcastTypes.Error)
                Call MESSAGES.LogMessages("Load race schedule, done, but with errors!", Utils.BroadcastTypes.Error)
            End Try
        End If

        Broadcast = "*****     FINISHED SCHEDULE LOAD FOR " & FormatDateTime(Date.FromOADate(OADate), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
        Call MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)
        This_Stopwatch.Stop()
        Broadcast = "*****     TIME TAKEN TO LOAD DAY: " & Utils.ElapsedTime(This_Stopwatch) & "     *****"
        Call MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)
    End Sub
    Private Sub BeginInsertMeetings(ByRef ListOf_MeetingInformation As List(Of Instance.MeetingInformation))
        ' ABANDONED Meetings are removed in the Loader.
        '
        If (ListOf_MeetingInformation Is Nothing) OrElse (ListOf_MeetingInformation.Count = 0) Then
            MESSAGES.LogMessages("There are no meetings to process.", Utils.BroadcastTypes.Log)
            Return ' There are no meetings to process
        End If

        Dim BROADCAST As String
        BROADCAST = "Attempting to construct meetings ....."
        Call MESSAGES.LogMessages(BROADCAST, Utils.BroadcastTypes.Log)

        Using InsertUpdate As New InsertMeetings(ListOf_MeetingInformation, CONNECTION, MESSAGES)
            Call InsertUpdate.Begin()
        End Using

        BROADCAST = "Meetings constructed ....."
        Call MESSAGES.LogMessages(BROADCAST, Utils.BroadcastTypes.Log)
    End Sub

#Region "       IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Friend Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' 
            End If
            Connection.Dispose()
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
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region
End Class