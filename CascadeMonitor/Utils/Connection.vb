Namespace Utils
    Friend NotInheritable Class Connection : Implements IDisposable
        Private MY_CONNECTION As SqlClient.SqlConnection
        Friend Sub New(ConnectionString As String)
            Me.MY_CONNECTION = New SqlClient.SqlConnection(ConnectionString)
            Me.MY_CONNECTION.Open()
        End Sub
#Region "    Private Routines "
        Private Sub ExceptionThrown(ex As Exception, CommandText As String)
            Dim Log As String = "Error:" & ex.ToString & Environment.NewLine
            Log += "ConnectionString: " & MY_CONNECTION.ConnectionString & Environment.NewLine
            Log += "CommandText: " & CommandText & Environment.NewLine

            MessageBox.Show(Log, "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Sub
        Private Function ValidateCommandText(Commandtext As String) As Boolean
            If Commandtext Is Nothing OrElse Commandtext = String.Empty Then Return False
            If MY_CONNECTION Is Nothing Then Return False
            If MY_CONNECTION.State <> ConnectionState.Open Then MY_CONNECTION.Open()

            Return True
        End Function
#End Region
        Friend Function GetDataTable(Commandtext As String) As DataTable
            If Not ValidateCommandText(Commandtext) Then Return New Data.DataTable

            Using My_GetDataTable = New Data.DataTable
                My_GetDataTable.Locale = Globalization.CultureInfo.InvariantCulture
                Using SQLDataAdapter As New SqlClient.SqlDataAdapter
                    Try
                        Using Command As New SqlClient.SqlCommand
                            With Command
                                .CommandText = Commandtext
                                .CommandTimeout = 0
                                .Connection = MY_CONNECTION
                            End With
                            SQLDataAdapter.SelectCommand = Command
                            Dim unused = SQLDataAdapter.Fill(My_GetDataTable)
                        End Using
                    Catch EX As Exception
                        Call ExceptionThrown(EX, Commandtext)
                    End Try
                End Using

                GetDataTable = My_GetDataTable
            End Using
        End Function
        Friend Sub Execute(Commandtext As String)
            If Not ValidateCommandText(Commandtext) Then Return

            Try
                Using Command As New SqlClient.SqlCommand
                    With Command
                        .CommandText = Commandtext
                        .CommandTimeout = 0
                        .Connection = MY_CONNECTION
                        Dim unused = .ExecuteNonQuery()
                    End With
                End Using
            Catch EX As Exception
                Call ExceptionThrown(EX, Commandtext)
            End Try
        End Sub
        Friend Function ExecuteScalar(Commandtext As String) As Object
            If Not ValidateCommandText(Commandtext) Then Return Nothing

            ExecuteScalar = Nothing
            Try
                Using DW = New SqlClient.SqlCommand(Commandtext, MY_CONNECTION)
                    If MY_CONNECTION.State <> ConnectionState.Open Then MY_CONNECTION.Open()
                    DW.CommandTimeout = 0
                    ExecuteScalar = DW.ExecuteScalar()
                End Using
            Catch EX As Exception
                Call ExceptionThrown(EX, Commandtext)
            End Try
        End Function
#Region "    IDisposable Support "
        Private disposedValue As Boolean ' To detect redundant calls
        ' IDisposable
        Friend Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    '
                End If
                If MY_CONNECTION IsNot Nothing Then MY_CONNECTION.Dispose() : MY_CONNECTION = Nothing
            End If
            disposedValue = True
        End Sub
        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region
    End Class
End Namespace