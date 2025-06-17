Namespace Instance
    Friend Class MeetingInformation : Implements IDisposable
        Private This_Number As String
        Private This_Type As String
        Private This_OADate As String
        Private This_ListOfRaceInformation As New List(Of Instance.MeetingInformation.RaceInformation)
        Private Sub New()
            Me.This_Number = String.Empty
            Me.This_Type = String.Empty
            Me.This_OADate = String.Empty
            Me.This_ListOfRaceInformation = Nothing
        End Sub
        Friend Sub New(Number As String, Type As String, OADate As String, ListOfRaceInformation As List(Of Instance.MeetingInformation.RaceInformation))
            Me.New
            Me.This_Number = Number
            Me.This_Type = Type
            Me.This_OADate = OADate
            Me.This_ListOfRaceInformation = ListOfRaceInformation
        End Sub
        Friend Property Number As String
            Get
                Return Me.This_Number
            End Get
            Set(value As String)
                Me.This_Number = value
            End Set
        End Property
        Friend Property Type As String
            Get
                Return Me.This_Type
            End Get
            Set(value As String)
                Me.This_Type = Type
            End Set
        End Property
        Friend Property OADate As String
            Get
                Return Me.This_OADate
            End Get
            Set(value As String)
                Me.This_OADate = value
            End Set
        End Property
        Friend Property ListOfRaceInformation As List(Of Instance.MeetingInformation.RaceInformation)
            Get
                Return Me.This_ListOfRaceInformation
            End Get
            Set(value As List(Of Instance.MeetingInformation.RaceInformation))
                Me.This_ListOfRaceInformation = value
            End Set
        End Property
#Region "       IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls
        ' IDisposable
        Friend Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    Me.This_Number = Nothing
                    Me.This_Type = Nothing
                    Me.This_OADate = Nothing

                    For Each RACE As Instance.MeetingInformation.RaceInformation In Me.This_ListOfRaceInformation : RACE.Dispose() : Next
                    Me.This_ListOfRaceInformation.Clear() : Me.This_ListOfRaceInformation = Nothing
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
End Namespace