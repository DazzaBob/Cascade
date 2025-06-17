Namespace DataTables
    Friend Class Meeting : Implements IDisposable
        Private disposedValue As Boolean
        Private ReadOnly This_OADate As String
        Private ReadOnly This_Connection As CascadeCommon.Utils.Connection
        Private Sub New()
            Me.disposedValue = False
            Me.This_OADate = String.Empty
        End Sub
        Friend Sub New(OADate As String, ConnectionString As String)
            Me.New
            Me.This_OADate = OADate
            Me.This_Connection = New CascadeCommon.Utils.Connection(ConnectionString)
        End Sub
        Friend Function Meeting_XML_ForDay() As Data.DataTable
            Dim CMDTEXT As String = "SELECT * FROM MEETING_XML WHERE OADATE=" & This_OADate
            If Me.This_Connection IsNot Nothing Then
                Return Me.This_Connection.GetDataTable(CMDTEXT)
            Else
                Return New Data.DataTable
            End If
        End Function
#Region "       IDisposable "
        Private Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    If Me.This_Connection IsNot Nothing Then Me.This_Connection.Dispose()
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
End Namespace