Partial Friend Class Schedule
    Partial Private Class InsertMeetings
        Partial Private Class InsertRaces
            Private NotInheritable Class InsertEntrys : Implements IDisposable
                Private ReadOnly MeetingInformation As Instance.MeetingInformation
                Private ReadOnly RaceInformation As Instance.MeetingInformation.RaceInformation
                Private ReadOnly EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation
                Private ReadOnly CONNECTION As CascadeCommon.Utils.Connection
                Friend Sub New(MeetingInformation As Instance.MeetingInformation, RaceInformation As Instance.MeetingInformation.RaceInformation, EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation, Connection As CascadeCommon.Utils.Connection)
                    Me.MeetingInformation = MeetingInformation
                    Me.RaceInformation = RaceInformation
                    Me.EntryInformation = EntryInformation
                    Me.CONNECTION = Connection
                End Sub
                Friend Sub Begin()
                    Dim CMDTEXT As String = "INSERT INTO ENTRY_XML (MEETING_XML_OADATE, MEETING_XML_NUMBER, RACE_XML_NUMBER, NUMBER, BARRIER, NAME, SCRATCHED, CLASS) "
                    CMDTEXT += "VALUES (" & MeetingInformation.OADATE & ", " & MeetingInformation.NUMBER & ", " & RaceInformation.NUMBER & ", " & EntryInformation.NUMBER & ", "
                    CMDTEXT += EntryInformation.BARRIER & ", " & "N'" & Replace(EntryInformation.NAME, "'", "' + CHAR(39) + '") & "', " & EntryInformation.SCRATCHED
                    CMDTEXT += ", " & RaceInformation.CLASS & ") " & Environment.NewLine

                    If MeetingInformation.TYPE <> "GR" AndAlso EntryInformation.SCRATCHED = "0" Then
                        Using Jockey As New InsertJockeys(MeetingInformation, RaceInformation, EntryInformation)
                            CMDTEXT += Jockey.SQL
                        End Using
                    End If

                    Call CONNECTION.Execute(CMDTEXT)
                End Sub

#Region "                   IDisposable Support"
                Private disposedValue As Boolean ' To detect redundant calls

                ' IDisposable
                Protected Sub Dispose(disposing As Boolean)
                    If Not disposedValue Then
                        If disposing Then
                            ' TODO: dispose managed state (managed objects).
                        End If

                        ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
                        ' TODO: set large fields to null.
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
        End Class
    End Class
End Class