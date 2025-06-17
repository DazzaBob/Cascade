Namespace Processing
    Partial Class Schedule
        Partial Class Instance
            Partial Class MeetingInformation
                Friend NotInheritable Class RaceInformation : Implements IDisposable
                    Friend [CLASS] As String = Nothing '  the default is set in the LOADER class, after all properties have been set.
                    Friend LENGTH As String
                    Friend NAME As String = Nothing
                    Friend NORM_TIME As String
                    Friend NUMBER As String = Nothing
                    Friend STAKE As String = Nothing
                    Friend STATUS As String = "OK"
                    Friend TRACK As String = "GOOD"
                    Friend VENUE As String = Nothing
                    Friend WEATHER As String = "FINE"
                    Friend BARRIERS As String = Nothing
                    '
                    Friend ListOfEntryInformation As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                    Friend Sub New()
                        Me.ListOfEntryInformation = New List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                    End Sub
                    Friend Sub New(ByVal [Class] As String, ByVal Length As String, ByVal Name As String, ByVal NormTime As String, ByVal Number As String, ByVal Stake As String, ByVal Status As String, ByVal Track As String, ByVal Venue As String, ByVal Weather As String, ByVal Barriers As String, ListOfEntryInformation As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation))
                        Me.CLASS = [Class]
                        Me.LENGTH = Length
                        Me.NAME = Name
                        Me.NORM_TIME = NormTime
                        Me.NUMBER = Number
                        Me.STAKE = Stake
                        Me.STATUS = Status
                        Me.TRACK = Track
                        Me.VENUE = Venue
                        Me.WEATHER = Weather
                        Me.BARRIERS = Barriers
                        Me.ListOfEntryInformation = ListOfEntryInformation
                    End Sub
#Region "       IDisposable Support"
                    Private disposedValue As Boolean ' To detect redundant calls
                    ' IDisposable
                    Private Sub Dispose(disposing As Boolean)
                        If Not Me.disposedValue Then
                            If disposing Then
                                [CLASS] = Nothing
                                LENGTH = Nothing
                                NAME = Nothing
                                NORM_TIME = Nothing
                                NUMBER = Nothing
                                STAKE = Nothing
                                STATUS = Nothing
                                TRACK = Nothing
                                VENUE = Nothing
                                WEATHER = Nothing
                                BARRIERS = Nothing
                                '
                                For Each ENTRY As Instance.MeetingInformation.RaceInformation.EntryInformation In Me.ListOfEntryInformation
                                    ENTRY.Dispose() : ENTRY = Nothing
                                Next
                            End If
                            Me.ListOfEntryInformation.Clear() : Me.ListOfEntryInformation = Nothing
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
                    Public Sub Dispose() Implements IDisposable.Dispose
                        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
                        Dispose(True)
                        GC.SuppressFinalize(Me)
                    End Sub
#End Region
                End Class
            End Class
        End Class
    End Class
End Namespace
