Namespace Processing
    Partial Class Results
        Private Class Instance
            Friend NotInheritable Class MeetingInformation : Implements IDisposable
                Friend NUMBER As String = Nothing
                Friend TYPE As String = Nothing
                Friend OADATE As String = Nothing
                Friend ListOfRaceInformation As New List(Of Instance.MeetingInformation.RaceInformation)
                Friend Sub New()
                    ' The default values are set when the fields are declared, so no need to set them here
                End Sub
                Friend Sub New(ByVal Number As String, ByVal Type As String, ByVal OADate As String, ByVal ListOfRaceInformation As List(Of Instance.MeetingInformation.RaceInformation))
                    Me.NUMBER = Number
                    Me.TYPE = Type
                    Me.OADATE = OADate
                    Me.ListOfRaceInformation = ListOfRaceInformation
                End Sub
#Region "       IDisposable Support"
                Private disposedValue As Boolean ' To detect redundant calls
                ' IDisposable
                Friend Sub Dispose(disposing As Boolean)
                    If Not Me.disposedValue Then
                        If disposing Then
                            Me.NUMBER = Nothing
                            Me.TYPE = Nothing
                            Me.OADATE = Nothing
                            '
                            For Each RACE As Instance.MeetingInformation.RaceInformation In Me.ListOfRaceInformation : RACE.Dispose() : Next
                            Me.ListOfRaceInformation.Clear() : Me.ListOfRaceInformation = Nothing
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
End Namespace