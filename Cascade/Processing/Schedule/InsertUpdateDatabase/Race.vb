Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Private NotInheritable Class Race : Implements IDisposable
                Private MeetingInformation As Instance.MeetingInformation
                Private RaceInformation As Instance.MeetingInformation.RaceInformation
                Private Connection As Connection
                Friend Sub New(ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal Connection As Connection)
                    Me.MeetingInformation = MeetingInformation
                    Me.RaceInformation = RaceInformation
                    Me.Connection = Connection
                End Sub
                Friend Sub Begin()
                    Dim CMDTEXT As String = "INSERT INTO RACE_INFO (MEETING_INFO_OADATE, MEETING_INFO_NUMBER, NUMBER, [LENGTH], [NAME], [NORM_TIME], [STAKE], [STATUS], [TRACK], [VENUE], [WEATHER], [RUNNERSINRACE]"
                    If Not Me.RaceInformation.CLASS Is Nothing Then CMDTEXT += ", [CLASS]"
                    CMDTEXT += ") "
                    '
                    CMDTEXT += "VALUES (" & Me.MeetingInformation.OADATE & ", " & Me.MeetingInformation.NUMBER & ", " & Me.RaceInformation.NUMBER & ", "
                    CMDTEXT += Me.RaceInformation.LENGTH & ", "
                    CMDTEXT += "N'" & ReplaceHTML(Me.RaceInformation.NAME) & "', "
                    CMDTEXT += Me.RaceInformation.NORM_TIME & ", "
                    CMDTEXT += Me.RaceInformation.STAKE & ", "
                    CMDTEXT += "N'" & Me.RaceInformation.STATUS & "', "
                    CMDTEXT += "N'" & Me.RaceInformation.TRACK & "', "
                    CMDTEXT += "N'" & Me.RaceInformation.VENUE & "', "
                    CMDTEXT += "N'" & Me.RaceInformation.WEATHER & "', "
                    CMDTEXT += CStr(Me.RaceInformation.ListOfEntryInformation.Count)
                    CMDTEXT += ", N'" & Me.RaceInformation.CLASS & "')"
                    '
                    Call Me.Connection.Execute(CMDTEXT)
                    Dim Broadcast As String = " Inserted Race R" & Me.RaceInformation.NUMBER & " - " & Me.RaceInformation.NAME & " for M" & Me.MeetingInformation.NUMBER & " - " & Me.MeetingInformation.NAME
                    Call ServerUI.Messages.LogMessages(Broadcast, Cascade.BroadcastTypes.Log)
                    '
                    If Me.MeetingInformation.TYPE = "GR" Then
                        Using Barrier As New Barrier(Me.MeetingInformation, Me.RaceInformation, Connection)
                            Barrier.Begin()
                        End Using
                    Else
                        Using Jockey As New Jockey(Me.MeetingInformation, Me.RaceInformation, Connection)
                            Jockey.Begin()
                        End Using
                    End If
                    '
                    CMDTEXT = Nothing : Broadcast = Nothing
                    Dim THIS_BROADCAST = "    Inserted Runners: "
                    For Each ENTRY_INFO As Instance.MeetingInformation.RaceInformation.EntryInformation In Me.RaceInformation.ListOfEntryInformation
                        Dim FILTER As String = "(ENTRY_INFO.[MEETING_INFO_OADATE] < " & Me.MeetingInformation.OADATE & " AND ENTRY_INFO.[MEETING_INFO_OADATE] > " & CStr(CInt(Me.MeetingInformation.OADATE) - 365) & ") AND (MEETING_INFO.[COUNTRY]=N'" & Me.MeetingInformation.COUNTRY & "') AND (MEETING_INFO.[TYPE]=N'" & Me.MeetingInformation.TYPE & "') AND (ENTRY_INFO.NAME=N'" & ENTRY_INFO.NAME & "') "
                        Dim RUNNERRACELIST As Data.DataTable = StoredProcedures.UC_RUNNERRACELIST.GetDataTable(FILTER, Me.Connection)
                        '
                        Using Entry As New Entry(Me.MeetingInformation, Me.RaceInformation, ENTRY_INFO, RUNNERRACELIST, Me.Connection, CMDTEXT)
                            Call Entry.Begin()
                        End Using
                        '
                        THIS_BROADCAST += ENTRY_INFO.NUMBER & ", "
                    Next ENTRY_INFO
                    THIS_BROADCAST = Strings.Left(THIS_BROADCAST, THIS_BROADCAST.Length - 2)
                    Call ServerUI.Messages.LogMessages(THIS_BROADCAST, BroadcastTypes.Log)
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
End Namespace