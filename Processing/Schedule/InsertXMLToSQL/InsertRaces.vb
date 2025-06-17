Partial Class Schedule
    Partial Class InsertMeetings
        Private NotInheritable Class InsertRaces : Implements IDisposable
            Private MeetingInformation As Instance.MeetingInformation
            Private RaceInformation As Instance.MeetingInformation.RaceInformation
            Private CONNECTION As Utils.Connection
            Private MESSAGES As Utils.Messages
            Friend Sub New(MeetingInformation As Instance.MeetingInformation, RaceInformation As Instance.MeetingInformation.RaceInformation, Connection As Utils.Connection, Messages As Utils.Messages)
                Me.MeetingInformation = MeetingInformation
                Me.RaceInformation = RaceInformation
                Me.CONNECTION = Connection
            End Sub
            Friend Sub Begin()
                Dim CMDTEXT As String = "INSERT INTO RACE_XML (MEETING_XML_OADATE, MEETING_XML_NUMBER, NUMBER, [LENGTH], [NAME], [START_TIME], [STAKE], [STATUS], [TRACK], [VENUE], [WEATHER], [RUNNERSINRACE]"
                If Me.RaceInformation.CLASS IsNot Nothing Then CMDTEXT += ", [CLASS]"
                CMDTEXT += ") "

                CMDTEXT += "VALUES (" & Me.MeetingInformation.OADATE & ", " & Me.MeetingInformation.NUMBER & ", " & Me.RaceInformation.NUMBER & ", "
                CMDTEXT += Me.RaceInformation.LENGTH & ", "
                CMDTEXT += "N'" & Utils.ReplaceHTML(Me.RaceInformation.NAME) & "', "
                CMDTEXT += Me.RaceInformation.NORM_TIME & ", "
                CMDTEXT += Me.RaceInformation.STAKE & ", "
                CMDTEXT += "N'" & Me.RaceInformation.STATUS & "', "
                CMDTEXT += "N'" & Me.RaceInformation.TRACK & "', "
                CMDTEXT += "N'" & Me.RaceInformation.VENUE & "', "
                CMDTEXT += "N'" & Me.RaceInformation.WEATHER & "', "
                CMDTEXT += CStr(Me.RaceInformation.ListOfEntryInformation.Count)
                CMDTEXT += ", N'" & Me.RaceInformation.CLASS & "')"

                Call Me.CONNECTION.Execute(CMDTEXT)
                Dim Broadcast As String = " Inserted Race R" & Me.RaceInformation.NUMBER & " - " & Me.RaceInformation.NAME & " for M" & Me.MeetingInformation.NUMBER & " - " & Me.MeetingInformation.NAME
                Call Me.MESSAGES.LogMessages(Broadcast, Utils.BroadcastTypes.Log)

                CMDTEXT = Nothing : Broadcast = Nothing
                Dim THIS_BROADCAST = "    Inserted Runners: "
                For Each ENTRY_INFO As Instance.MeetingInformation.RaceInformation.EntryInformation In Me.RaceInformation.ListOfEntryInformation

                    Using Entry As New InsertsEntrys(Me.MeetingInformation, Me.RaceInformation, ENTRY_INFO, Me.CONNECTION, CMDTEXT)
                        Call Entry.Begin()
                    End Using

                    THIS_BROADCAST += ENTRY_INFO.NUMBER & ", "
                Next ENTRY_INFO
                THIS_BROADCAST = Strings.Left(THIS_BROADCAST, THIS_BROADCAST.Length - 2)
                Call Me.MESSAGES.LogMessages(THIS_BROADCAST, Utils.BroadcastTypes.Log)
            End Sub
#Region "               IDisposable Support"
            Private disposedValue As Boolean ' To detect redundant calls

            ' IDisposable
            Protected Sub Dispose(disposing As Boolean)
                If Not Me.disposedValue Then
                    If disposing Then
                        ' TODO: dispose managed state (managed objects).
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
    End Class
End Class