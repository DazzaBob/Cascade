Partial Friend Class Schedule
    Partial Public Class Instance
        Friend NotInheritable Class MeetingInformation : Implements IDisposable
            Friend OADATE As String = Nothing
            Friend NUMBER As String = Nothing
            Friend BETSLIP_TYPE As String = "STD"
            Friend CODE As String = Nothing
            Friend COUNTRY As String = "UNK"
            Friend NAME As String = Nothing
            Friend NZ As Short = 0
            Friend PENETROMETER As String = Nothing
            Friend STATUS As String = "OK"
            Friend TRACK_DIR As String = Nothing
            Friend TYPE As String = "UNK"
            Friend VENUE As String = Nothing
            '
            Friend ListOfRaceInformation As List(Of Instance.MeetingInformation.RaceInformation)
            Friend Sub New(ByVal OADate As String, ByVal Number As String, ByVal BetSlipType As String, ByVal Code As String, ByVal Country As String, ByVal Name As String, ByVal NZ As String, ByVal Penetrometer As String, ByVal Status As String, ByVal TrackDir As String, ByVal Type As String, ByVal Venue As String, ByVal ListOfRaceInformation As List(Of Instance.MeetingInformation.RaceInformation))
                Me.OADATE = OADate
                Me.NUMBER = Number
                BETSLIP_TYPE = BetSlipType
                Me.CODE = Code
                Me.COUNTRY = Country
                Me.NAME = Name
                Me.NZ = NZ
                Me.PENETROMETER = Penetrometer
                Me.STATUS = Status
                TRACK_DIR = TrackDir
                Me.TYPE = Type
                Me.VENUE = Venue
                Me.ListOfRaceInformation = ListOfRaceInformation
            End Sub
#Region "               IDisposable Support"
            Private disposedValue As Boolean ' To detect redundant calls

            ' IDisposable
            Private Sub Dispose(disposing As Boolean)
                If Not disposedValue Then
                    If disposing Then
                        OADATE = Nothing
                        NUMBER = Nothing
                        BETSLIP_TYPE = Nothing
                        CODE = Nothing
                        COUNTRY = Nothing
                        NAME = Nothing
                        NZ = Nothing
                        PENETROMETER = Nothing
                        STATUS = Nothing
                        TRACK_DIR = Nothing
                        TYPE = Nothing
                        VENUE = Nothing
                        '
                        For Each RACE As MeetingInformation.RaceInformation In ListOfRaceInformation
                            RACE.Dispose() :
                        Next
                    End If
                    '
                    ListOfRaceInformation.Clear() : ListOfRaceInformation = Nothing
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
            Public Sub Dispose() Implements IDisposable.Dispose
                ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
                Dispose(True)
                GC.SuppressFinalize(Me)
            End Sub
#End Region
        End Class
    End Class
End Class