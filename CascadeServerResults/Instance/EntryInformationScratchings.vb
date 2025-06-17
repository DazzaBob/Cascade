Namespace Instance
    Partial Class MeetingInformation
        Partial Class RaceInformation
            Friend Class EntryInformationScratchings : Implements IDisposable
                Private disposedValue As Boolean ' To detect redundant calls
                Private This_Number As String
                Private Sub New()
                    Me.disposedValue = False
                    Me.This_Number = String.Empty
                End Sub
                Friend Sub New(Number As String)
                    Me.New
                    Me.This_Number = Number
                End Sub
                Friend Property Number As String
                    Get
                        Return Me.This_Number
                    End Get
                    Set(value As String)
                        Me.This_Number = value
                    End Set
                End Property
#Region "                IDisposable Support "
                ' IDisposable
                Private Sub Dispose(disposing As Boolean)
                    If Not disposedValue Then
                        If disposing Then
                            Me.This_Number = Nothing
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
                Friend Sub Dispose() Implements IDisposable.Dispose
                    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
                    Dispose(True)
                    GC.SuppressFinalize(Me)
                End Sub
#End Region
            End Class
        End Class
    End Class
End Namespace