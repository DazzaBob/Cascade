Namespace Processing
    Friend NotInheritable Class Schedule : Implements IDisposable
        Private MY_OADATE As String
        Private MY_CONNECTION As Connection
        Friend Sub New(ByVal meetingDate As String, ByVal connection As Connection)
            MY_OADATE = meetingDate
            MY_CONNECTION = connection
        End Sub
        Friend Sub Start()
            ' Create the Connection in the STARTing method, so its in context if we are running multiple threads.
            Call LogThreadDetails(Threading.Thread.CurrentThread)
            '
            Dim This_Stopwatch As Stopwatch = New Stopwatch
            Dim Broadcast As String
            Dim This_ScheduleXML As String = Nothing
            '
            This_Stopwatch.Start()
            '
            Broadcast = "*****     START SCHEDULE LOAD FOR " & FormatDateTime(Date.FromOADate(CDbl(MY_OADATE)), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
            Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
            '
            Using XMLCache As Cascade.Processing.XmlCache = New Cascade.Processing.XmlCache("schedule", MY_OADATE)
                This_ScheduleXML = XMLCache.GetXml
                '
                ' Load the XML, then test to see if its nothing. ToUpperInvariant throws an execption if the XML is nothing.
                If Not This_ScheduleXML Is Nothing Then This_ScheduleXML = This_ScheduleXML.ToUpperInvariant
            End Using
            '
            ' If there was no schedule data in the local cache and not on the TAB; there is nothing to do.
            ' We found some data to work with so start doing some work.
            If Not This_ScheduleXML Is Nothing Then
                Try
                    Using NZLoader As New XmlLoader(This_ScheduleXML)
                        Call BeginInsertMeetings(NZLoader.ListOfMeetingInformation)
                        Call ServerUI.Messages.LogMessages("Load race schedule, done!", Cascade.BroadcastTypes.Log)
                    End Using
                Catch EX As Exception
                    Call ServerUI.Messages.LogMessages(EX.ToString, Cascade.BroadcastTypes.Error)
                    Call ServerUI.Messages.LogMessages("Load race schedule, done, but with errors!", Cascade.BroadcastTypes.Error)
                End Try
            End If
            '
            Broadcast = "*****     FINISHED SCHEDULE LOAD FOR " & FormatDateTime(Date.FromOADate(CDbl(MY_OADATE)), DateFormat.LongDate) & " AT: " & FormatDateTime(Now, DateFormat.GeneralDate) & "     *****"
            Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
            This_Stopwatch.Stop()
            Broadcast = "*****     TIME TAKEN TO LOAD DAY: " & Cascade.GetTime(This_Stopwatch) & "     *****"
            Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
        End Sub
        Private Sub BeginInsertMeetings(ByRef ListOf_MeetingInformation As List(Of Instance.MeetingInformation))
            ' ABANDONED Meetings are removed in the Loader.
            '
            If (ListOf_MeetingInformation Is Nothing) OrElse (ListOf_MeetingInformation.Count = 0) Then
                ServerUI.Messages.LogMessages("There are no meetings to process.", Cascade.BroadcastTypes.Log)
                Return ' There are no meetings to process
            End If
            '
            Dim THIS_STOPWATCH As Stopwatch = New Stopwatch
            Dim BROADCAST As String = Nothing, CMDTEXT As String = Nothing
            BROADCAST = "Attempting to construct meetings ....."
            Call ServerUI.Messages.LogMessages(BROADCAST, Cascade.BroadcastTypes.Log)
            '
            THIS_STOPWATCH.Reset() : THIS_STOPWATCH.Start()
            CMDTEXT = "DELETE FROM MEETING_INFO WHERE OADATE =" & MY_OADATE
            MY_CONNECTION.Execute(CMDTEXT)
            THIS_STOPWATCH.Stop()
            Call ServerUI.Messages.LogMessages("Deleted Meetings for " & FormatDateTime(Date.FromOADate(CDbl(MY_OADATE)), DateFormat.LongDate) & " in: " & Cascade.GetTime(THIS_STOPWATCH) & ".", Cascade.BroadcastTypes.Log)
            '
            Using InsertUpdate As New InsertUpdateDatabase(ListOf_MeetingInformation)
                Call InsertUpdate.Begin()
            End Using
            '
            BROADCAST = "Meetings constructed ....."
            Call ServerUI.Messages.LogMessages(BROADCAST, Cascade.BroadcastTypes.Log)
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
End Namespace