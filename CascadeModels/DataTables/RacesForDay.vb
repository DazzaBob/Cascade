Namespace DataTables
    Friend Class RacesForDay : Implements IDisposable
        Private disposedValue As Boolean

        Private This_MeetingNumber As String
        Private This_RacesAL As ArrayList
        Friend Sub New()
            Me.disposedValue = False
            Me.This_MeetingNumber = String.Empty
            Me.This_RacesAL = New ArrayList ' Stores the Rows for Races For Meeting as a datatable
        End Sub
        Friend Property MeetingNumber As String
            Get
                Return Me.This_MeetingNumber
            End Get
            Set(value As String)
                Me.This_MeetingNumber = value
            End Set
        End Property
        Friend Property RacesArrayList As ArrayList
            Get
                Return Me.This_RacesAL
            End Get
            Set(value As ArrayList)
                Me.This_RacesAL = value
            End Set
        End Property

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    This_MeetingNumber = Nothing
                    This_RacesAL.Clear() : This_RacesAL = Nothing
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
    End Class
End Namespace