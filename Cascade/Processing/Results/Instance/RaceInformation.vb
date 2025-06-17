Namespace Processing
    Partial Class Results
        Partial Class Instance
            Partial Class MeetingInformation
                Friend NotInheritable Class RaceInformation : Implements IDisposable
                    Friend NUMBER As String = Nothing
                    Friend STAKE As Decimal = 0D
                    Friend STATUS As String = Nothing
                    Friend RACEDISTANCE As String = Nothing
                    Friend WINNERSTIME As Decimal = 0D
                    '
                    Friend ListOfEntryInformation As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                    Friend ListOfEntryInformationPools As New List(Of Instance.MeetingInformation.RaceInformation.EntryInformation.EntryInformationPools)
                    Friend Sub New()
                        Me.ListOfEntryInformation = New List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                        Me.ListOfEntryInformationPools = New List(Of Instance.MeetingInformation.RaceInformation.EntryInformation.EntryInformationPools)
                    End Sub
#Region "                   IDisposable Support"
                    Private disposedValue As Boolean ' To detect redundant calls

                    ' IDisposable
                    Friend Sub Dispose(disposing As Boolean)
                        If Not Me.disposedValue Then
                            If disposing Then
                                Me.NUMBER = Nothing
                                Me.STAKE = Nothing
                                Me.STATUS = Nothing
                                Me.RACEDISTANCE = Nothing
                                Me.WINNERSTIME = Nothing
                                '
                                If Not Me.ListOfEntryInformation Is Nothing Then
                                    If Me.ListOfEntryInformation.Count > 0 Then
                                        For Each ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation In Me.ListOfEntryInformation
                                            ENTRY.Dispose()
                                        Next
                                        Me.ListOfEntryInformation.Clear()
                                    End If
                                    Me.ListOfEntryInformation = Nothing
                                End If
                                '
                                If Not Me.ListOfEntryInformationPools Is Nothing Then
                                    If Me.ListOfEntryInformationPools.Count > 0 Then
                                        For Each ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation.EntryInformationPools In Me.ListOfEntryInformationPools
                                            ENTRY.Dispose()
                                        Next
                                        Me.ListOfEntryInformationPools.Clear()
                                    End If
                                    Me.ListOfEntryInformationPools = Nothing
                                End If
                            End If
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
                    Friend Sub Dispose() Implements IDisposable.Dispose
                        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
                        Dispose(True)
                        GC.SuppressFinalize(Me)
                    End Sub
#End Region
                End Class
            End Class
        End Class
    End Class
End Namespace
