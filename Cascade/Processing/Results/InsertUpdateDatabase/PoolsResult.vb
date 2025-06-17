Namespace Processing
    Partial Class Results
        Partial Class InsertUpdateDatabase
            Private NotInheritable Class PoolsResult : Implements IDisposable
                Private MeetingInformation As Instance.MeetingInformation
                Private RaceInformation As Instance.MeetingInformation.RaceInformation
                Private Connection As Connection
                Friend Sub New(ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal Connection As Connection)
                    Me.MeetingInformation = MeetingInformation
                    Me.RaceInformation = RaceInformation
                    Me.Connection = Connection
                End Sub
                Friend Sub Insert()
                    Dim CMDTEXT As String = Nothing
                    For Each ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation.EntryInformationPools In Me.RaceInformation.ListOfEntryInformationPools
                        If ENTRY.NAME Is Nothing OrElse ENTRY.AMOUNT Is Nothing Or ENTRY.AMOUNT Is Nothing Then Continue For
                        '
                        CMDTEXT += "INSERT INTO RACE_INFO_RESULTS_POOLS ([MEETING_INFO_OADATE], [MEETING_INFO_NUMBER], [RACE_INFO_NUMBER], [NUMBERS], [NAME], [AMOUNT], [TYPE]) "
                        CMDTEXT += "VALUES (" & CStr(Me.MeetingInformation.OADATE) & ", " & CStr(Me.MeetingInformation.NUMBER) & ", " & CStr(Me.RaceInformation.NUMBER) & ", "
                        CMDTEXT += "'" & ENTRY.NUMBER & "', '" & Replace(ENTRY.NAME, "'", "") & "', " & ENTRY.AMOUNT & ", '" & ENTRY.TYPE & "') " & Environment.NewLine
                    Next ENTRY
                    '
                    If Not CMDTEXT Is Nothing Then Call Me.Connection.Execute(CMDTEXT) : CMDTEXT = Nothing
                End Sub

#Region "IDisposable Support"
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