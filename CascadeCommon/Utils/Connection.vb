Imports System.Data
Namespace Utils
    Public NotInheritable Class Connection : Implements IDisposable
        Private ReadOnly _Connection As SqlClient.SqlConnection
        Private _Messages As CascadeCommon.Messages
#Region "        Constructors "
        Private Sub New()
            Me._Messages = Nothing
        End Sub
        Public Sub New(ConnectionString As String)
            Me._Connection = New SqlClient.SqlConnection(ConnectionString)
            Me._Connection.Open()
        End Sub
        Public Sub New(ConnectionString As String, Messages As CascadeCommon.Messages)
            Me.New(ConnectionString)
            Me._Messages = Messages
        End Sub
#End Region
        Public ReadOnly Property [String] As String
            Get
                If Me._Connection IsNot Nothing Then
                    Return Me._Connection.ConnectionString
                Else
                    Return String.Empty
                End If
            End Get
        End Property
#Region "        Private Routines "
        Private Sub ExceptionThrown(ex As Exception, CommandText As String)
            Dim Log As String = "Error:" & ex.ToString & Environment.NewLine
            Log += "ConnectionString: " & Me._Connection.ConnectionString & Environment.NewLine
            Log += "CommandText: " & CommandText & Environment.NewLine

            If Me._Messages Is Nothing Then
                Call MessageBox.Show(Log)
            Else
                Call _Messages.LogMessages(Log, BroadcastTypes.Error)
            End If
        End Sub
        Private Function ValidateCommandText(Commandtext As String) As Boolean
            If Commandtext Is Nothing OrElse Commandtext = String.Empty Then Return False
            If Me._Connection Is Nothing Then Return False
            If Me._Connection.State <> ConnectionState.Open Then Me._Connection.Open()

            Return True
        End Function
#End Region
        Public Function GetDataTable(Commandtext As String) As DataTable
            If Not ValidateCommandText(Commandtext) Then Return New Data.DataTable

            Using My_GetDataTable = New Data.DataTable
                My_GetDataTable.Locale = Globalization.CultureInfo.InvariantCulture
                Using SQLDataAdapter As New SqlClient.SqlDataAdapter
                    Try
                        Using Command As New SqlClient.SqlCommand
                            With Command
                                .CommandText = Commandtext
                                .CommandTimeout = 0
                                .Connection = Me._Connection
                            End With
                            SQLDataAdapter.SelectCommand = Command
                            Call SQLDataAdapter.Fill(My_GetDataTable)
                        End Using
                    Catch EX As Exception
                        Call ExceptionThrown(EX, Commandtext)
                    End Try
                End Using

                GetDataTable = My_GetDataTable
            End Using
        End Function
        Public Sub Execute(Commandtext As String)
            If Not ValidateCommandText(Commandtext) Then Return

            Dim Command As SqlClient.SqlCommand = Me._Connection.CreateCommand
            Dim Transaction As SqlClient.SqlTransaction = Me._Connection.BeginTransaction

            Command.Connection = Me._Connection
            Command.Transaction = Transaction

            Try
                Command.CommandTimeout = 0
                Command.CommandText = Commandtext
                Call Command.ExecuteNonQuery()
                Transaction.Commit()
            Catch EX As Exception
                Try
                    Transaction.Rollback()
                Catch ex1 As Exception
                    Call ExceptionThrown(ex1, Commandtext)
                End Try
                Call ExceptionThrown(EX, Commandtext)
            End Try
        End Sub
        Public Function ExecuteScalar(Commandtext As String) As Object
            If Not ValidateCommandText(Commandtext) Then Return Nothing

            ExecuteScalar = Nothing
            Try
                Using DW = New SqlClient.SqlCommand(Commandtext, Me._Connection)
                    DW.CommandTimeout = 0
                    ExecuteScalar = DW.ExecuteScalar()
                End Using
            Catch EX As Exception
                Call ExceptionThrown(EX, Commandtext)
            End Try
        End Function
        Public Overrides Function ToString() As String
            Return Me._Connection.ConnectionString
        End Function
#Region "       IDisposable Support "
        Private disposedValue As Boolean ' To detect redundant calls
        ' IDisposable
        Friend Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    If Me._Connection IsNot Nothing Then Me._Connection.Dispose() ' Dont set to nothing. Let .net handle the release.
                End If
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