Partial Class Schedule
    Partial Class InsertMeetings
        Partial Class InsertRaces
            Private NotInheritable Class InsertsEntrys : Implements IDisposable
                Private MeetingInformation As Instance.MeetingInformation
                Private RaceInformation As Instance.MeetingInformation.RaceInformation
                Private EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation
                Private CONNECTION As Utils.Connection
                Friend Sub New(MeetingInformation As Instance.MeetingInformation, RaceInformation As Instance.MeetingInformation.RaceInformation, EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation, Connection As Utils.Connection, ByRef CommandText As String)
                    Me.MeetingInformation = MeetingInformation
                    Me.RaceInformation = RaceInformation
                    Me.EntryInformation = EntryInformation
                    Me.CONNECTION = Connection
                End Sub
                Friend Sub Begin()
                    Dim CMDTEXT As String = "INSERT INTO ENTRY_XML (MEETING_INFO_OADATE, MEETING_INFO_NUMBER, RACE_INFO_NUMBER, NUMBER, BARRIER, NAME, SCRATCHED, CLASS "
                    If Me.MeetingInformation.TYPE <> "GR" Then
                        CMDTEXT += ", JOCKEY_NAME, JOCKEY_WEIGHT, JOCKEY_ISAPPRENTICE, JOCKEY_ALLOWANCE"
                    End If
                    CMDTEXT += ") "

                    CMDTEXT += "VALUES (" & Me.MeetingInformation.OADATE & ", " & Me.MeetingInformation.NUMBER & ", " & Me.RaceInformation.NUMBER & ", " & Me.EntryInformation.NUMBER & ", "
                    CMDTEXT += Me.EntryInformation.BARRIER & ", " & "N'" & Replace(Me.EntryInformation.NAME, "'", "' + CHAR(39) + '") & "', " & Me.EntryInformation.SCRATCHED
                    CMDTEXT += ", " & Me.RaceInformation.CLASS
                    If Me.MeetingInformation.TYPE <> "GR" Then CMDTEXT += ", " & GetJockeyParameters()
                    CMDTEXT += ") " & vbCrLf

                    Me.CONNECTION.Execute(CMDTEXT)
                End Sub
                Private Function GetJockeyParameters() As String
                    Dim COMMANDTEXT As String = "N'" & Me.EntryInformation.JOCKEY & "', "
                    If Me.EntryInformation.JOCKEY_WEIGHT Is Nothing Then
                        COMMANDTEXT += "0, "
                    Else
                        COMMANDTEXT += CStr(Me.EntryInformation.JOCKEY_WEIGHT) & ", "
                    End If
                    '
                    If (Not Me.EntryInformation.JOCKEY_ALLOWANCE Is Nothing) AndAlso (Me.EntryInformation.JOCKEY_ALLOWANCE.Length > 0) Then
                        If Me.EntryInformation.JOCKEY_ALLOWANCE.Contains("A") OrElse Me.EntryInformation.JOCKEY_ALLOWANCE.Contains("M") Then
                            COMMANDTEXT += "1, "
                            Me.EntryInformation.JOCKEY_ALLOWANCE = Replace(Me.EntryInformation.JOCKEY_ALLOWANCE, "A", "")
                            Me.EntryInformation.JOCKEY_ALLOWANCE = Replace(Me.EntryInformation.JOCKEY_ALLOWANCE, "M", "")
                            If Not Me.EntryInformation.JOCKEY_ALLOWANCE Is Nothing AndAlso Me.EntryInformation.JOCKEY_ALLOWANCE.Length > 0 Then
                                Me.EntryInformation.JOCKEY_ALLOWANCE = Replace(Me.EntryInformation.JOCKEY_ALLOWANCE, ",", ".")
                                Me.EntryInformation.JOCKEY_ALLOWANCE = Replace(Me.EntryInformation.JOCKEY_ALLOWANCE, "}", "")
                                COMMANDTEXT += Me.EntryInformation.JOCKEY_ALLOWANCE 'Jockey Allowance
                            Else
                                COMMANDTEXT += "0"
                            End If
                        Else
                            COMMANDTEXT += "0, 0" ' Jockey Allowance
                        End If
                    Else
                        COMMANDTEXT += "0, 0" ' Jockey Allowance
                    End If
                    Return COMMANDTEXT
                End Function
#Region "                   IDisposable Support"
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
End Class