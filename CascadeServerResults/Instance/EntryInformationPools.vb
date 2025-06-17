Namespace Instance
    Partial Class MeetingInformation
        Partial Class RaceInformation
            Friend Class EntryInformationPools : Implements IDisposable
                Private disposedValue As Boolean ' To detect redundant calls
                Private This_Number As String
                Private This_Name As String
                Private This_Amount As String
                Private This_Type As String
                Private Sub New()
                    Me.disposedValue = False
                    Me.This_Number = String.Empty
                    Me.This_Name = String.Empty
                    Me.This_Amount = String.Empty
                    Me.This_Type = String.Empty
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
                Friend Property Name As String
                    Get
                        Return Me.This_Name
                    End Get
                    Set(value As String)
                        Me.This_Name = value
                    End Set
                End Property
                Friend Property Amount As String
                    Get
                        Return Me.This_Amount
                    End Get
                    Set(value As String)
                        Me.This_Amount = value
                    End Set
                End Property
                Friend Property Type As String
                    Get
                        Return Me.This_Type
                    End Get
                    Set(value As String)
                        Me.This_Type = value
                    End Set
                End Property
#Region "                IDisposable Support "
                ' IDisposable
                Private Sub Dispose(disposing As Boolean)
                    If Not disposedValue Then
                        If disposing Then
                            Me.This_Number = Nothing
                            Me.This_Name = Nothing
                            Me.This_Amount = Nothing
                            Me.This_Type = Nothing
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