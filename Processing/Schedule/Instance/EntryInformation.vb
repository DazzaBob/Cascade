Partial Class Schedule
    Partial Class Instance
        Partial Class MeetingInformation
            Partial Class RaceInformation
                Friend NotInheritable Class EntryInformation : Implements IDisposable
                    Friend BARRIER As String = Nothing
                    Friend JOCKEY As String = Nothing
                    Friend JOCKEY_ALLOWANCE As String = Nothing
                    Friend JOCKEY_WEIGHT As String = Nothing
                    Friend NAME As String = Nothing
                    Friend NUMBER As String = Nothing
                    Friend SCRATCHED As String = Nothing
                    Friend Sub New()
                        ' The defaults are created when the fields are declared, so no need to set them here.
                    End Sub
                    Friend Sub New(ByVal Barrier As String, ByVal Jockey As String, ByVal JockeyAllowance As String, ByVal JockeyWeight As String, ByVal Name As String, ByVal Number As String, ByVal Scratched As String)
                        Me.BARRIER = Barrier
                        Me.JOCKEY = Jockey
                        Me.JOCKEY_ALLOWANCE = JockeyAllowance
                        Me.JOCKEY_WEIGHT = JockeyWeight
                        Me.NAME = Name
                        Me.NUMBER = Number
                        Me.SCRATCHED = Scratched
                    End Sub
#Region "       IDisposable Support"
                    Private disposedValue As Boolean ' To detect redundant calls
                    ' IDisposable
                    Private Sub Dispose(disposing As Boolean)
                        If Not Me.disposedValue Then
                            If disposing Then
                                BARRIER = Nothing
                                JOCKEY = Nothing
                                JOCKEY_ALLOWANCE = Nothing
                                JOCKEY_WEIGHT = Nothing
                                NAME = Nothing
                                NUMBER = Nothing
                                SCRATCHED = Nothing
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
End Class