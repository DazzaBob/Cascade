Namespace Processing
    Partial Class Results
        Partial Class Instance
            Partial Class MeetingInformation
                Partial Class RaceInformation
                    Partial Class EntryInformation
                        Friend NotInheritable Class EntryInformationPools : Implements IDisposable
                            Friend NUMBER As String
                            Friend NAME As String
                            Friend AMOUNT As String
                            Friend TYPE As String
                            Friend Sub New(ByVal number As String, ByVal name As String, ByVal amount As String, ByVal type As String)
                                Me.NUMBER = number
                                Me.NAME = name
                                Me.AMOUNT = amount
                                Me.TYPE = type
                            End Sub
                            Friend Sub New()
                                NUMBER = Nothing
                                NAME = Nothing
                                AMOUNT = Nothing
                                TYPE = Nothing
                            End Sub
#Region "       IDisposable Support"
                            Private disposedValue As Boolean ' To detect redundant calls
                            ' IDisposable
                            Friend Sub Dispose(disposing As Boolean)
                                If Not Me.disposedValue Then
                                    If disposing Then
                                        NUMBER = Nothing
                                        NAME = Nothing
                                        AMOUNT = Nothing
                                        TYPE = Nothing
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
        End Class
    End Class
End Namespace