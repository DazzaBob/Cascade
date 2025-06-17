Partial Friend Class Schedule
    Partial Private Class InsertMeetings
        Partial Private Class InsertRaces
            Partial Private Class InsertEntrys
                Friend NotInheritable Class InsertJockeys : Implements IDisposable
                    Private ReadOnly MeetingInformation As Instance.MeetingInformation
                    Private ReadOnly RaceInformation As Instance.MeetingInformation.RaceInformation
                    Private ReadOnly EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation
                    Private disposedValue As Boolean
                    Friend Sub New(MeetingInformation As Instance.MeetingInformation, RaceInformation As Instance.MeetingInformation.RaceInformation, EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation)
                        Me.MeetingInformation = MeetingInformation
                        Me.RaceInformation = RaceInformation
                        Me.EntryInformation = EntryInformation
                    End Sub
                    Friend Function SQL() As String
                        Dim CMDTEXT As String = "INSERT INTO ENTRY_XML_JOCKEY (MEETING_XML_OADATE, MEETING_XML_NUMBER, RACE_XML_NUMBER, NUMBER, "
                        CMDTEXT += "[NAME], [WEIGHT], [ISAPPRENTICE], [ALLOWANCE]) "

                        CMDTEXT += "VALUES (" & MeetingInformation.OADATE & ", " & MeetingInformation.NUMBER & ", " & RaceInformation.NUMBER & ", " & EntryInformation.NUMBER & ", "
                        CMDTEXT += GetJockeyParameters() & ")"

                        Return CMDTEXT
                    End Function
                    Private Function GetJockeyParameters() As String
                        Dim COMMANDTEXT As String = "N'" & EntryInformation.JOCKEY & "', "
                        If EntryInformation.JOCKEY_WEIGHT Is Nothing Then
                            COMMANDTEXT += "0, "
                        Else
                            COMMANDTEXT += EntryInformation.JOCKEY_WEIGHT & ", "
                        End If
                        '
                        If (EntryInformation.JOCKEY_ALLOWANCE IsNot Nothing) AndAlso (EntryInformation.JOCKEY_ALLOWANCE.Length > 0) Then
                            COMMANDTEXT += "1, 0"
                        Else
                            COMMANDTEXT += "0, 0"
                        End If

                        Return COMMANDTEXT
                    End Function
#Region "                IDisposible "
                    Private Sub Dispose(disposing As Boolean)
                        If Not disposedValue Then
                            If disposing Then
                                ' TODO: dispose managed state (managed objects)
                            End If

                            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
                            ' TODO: set large fields to null
                            disposedValue = True
                        End If
                    End Sub

                    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
                    ' Protected Overrides Sub Finalize()
                    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
                    '     Dispose(disposing:=False)
                    '     MyBase.Finalize()
                    ' End Sub

                    Public Sub Dispose() Implements IDisposable.Dispose
                        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
                        Dispose(disposing:=True)
                        GC.SuppressFinalize(Me)
                    End Sub
#End Region
                End Class
            End Class
        End Class
    End Class
End Class
