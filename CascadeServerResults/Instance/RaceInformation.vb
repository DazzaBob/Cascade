Namespace Instance
    Partial Class MeetingInformation
        Friend Class RaceInformation : Implements IDisposable
            Private disposedValue As Boolean ' To detect redundant calls

            Private This_Number As String
            Private This_Stake As String
            Private This_Distance As String
            Private This_Status As String
            Private This_WinnersTime As String
            Private This_WinnersTrainer As String
            Private This_WinnersBreeding As String
            Private This_WinnersOwner As String

            Private This_ListOf_EntryInformationPlacings As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPlacings)
            Private This_ListOf_EntryInformationAlsoRan As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan)
            Private This_ListOf_EntryInformationScratchings As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationScratchings)
            Private This_ListOf_EntryInformationPools As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPools)
            Friend Sub New()
                Me.disposedValue = False

                Me.This_Number = String.Empty
                Me.This_Stake = String.Empty
                Me.This_Distance = String.Empty
                Me.This_Status = String.Empty
                Me.This_WinnersTime = String.Empty
                Me.This_WinnersTrainer = String.Empty
                Me.This_WinnersBreeding = String.Empty
                Me.This_WinnersOwner = String.Empty

                Me.This_ListOf_EntryInformationPlacings = New List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPlacings)
                Me.This_ListOf_EntryInformationAlsoRan = New List(Of Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan)
                Me.This_ListOf_EntryInformationScratchings = New List(Of Instance.MeetingInformation.RaceInformation.EntryInformationScratchings)
                Me.This_ListOf_EntryInformationPools = New List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPools)
            End Sub
            Friend Property Number As String
                Get
                    Return Me.This_Number
                End Get
                Set(value As String)
                    Me.This_Number = value
                End Set
            End Property
            Friend Property Stake As String
                Get
                    Return Me.This_Stake
                End Get
                Set(value As String)
                    Me.This_Stake = value
                End Set
            End Property
            Friend Property Distance As String
                Get
                    Return Me.This_Distance
                End Get
                Set(value As String)
                    Me.This_Distance = value
                End Set
            End Property
            Friend Property Status As String
                Get
                    Return Me.This_Status
                End Get
                Set(value As String)
                    Me.This_Status = value
                End Set
            End Property
            Friend Property WinnersTime As String
                Get
                    Return Me.This_WinnersTime
                End Get
                Set(value As String)
                    Me.This_WinnersTime = value
                End Set
            End Property
            Friend Property WinnersTrainer As String
                Get
                    Return Me.This_WinnersTrainer
                End Get
                Set(value As String)
                    Me.This_WinnersTrainer = value
                End Set
            End Property
            Friend Property WinnersBreeding As String
                Get
                    Return Me.This_WinnersBreeding
                End Get
                Set(value As String)
                    Me.This_WinnersBreeding = value
                End Set
            End Property
            Friend Property WinnersOwner As String
                Get
                    Return Me.This_WinnersOwner
                End Get
                Set(value As String)
                    Me.This_WinnersOwner = value
                End Set
            End Property
            Friend Property ListOf_EntryInformationPlacings As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPlacings)
                Get
                    Return Me.This_ListOf_EntryInformationPlacings
                End Get
                Set(value As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPlacings))
                    Me.This_ListOf_EntryInformationPlacings = value
                End Set
            End Property
            Friend Property ListOf_EntryInformationAlsoRan As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan)
                Get
                    Return Me.This_ListOf_EntryInformationAlsoRan
                End Get
                Set(value As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan))
                    Me.This_ListOf_EntryInformationAlsoRan = value
                End Set
            End Property
            Friend Property ListOf_EntryInformationScratchings As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationScratchings)
                Get
                    Return Me.This_ListOf_EntryInformationScratchings
                End Get
                Set(value As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationScratchings))
                    Me.This_ListOf_EntryInformationScratchings = value
                End Set
            End Property
            Friend Property ListOf_EntryInformationPools As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPools)
                Get
                    Return Me.This_ListOf_EntryInformationPools
                End Get
                Set(value As List(Of Instance.MeetingInformation.RaceInformation.EntryInformationPools))
                    Me.This_ListOf_EntryInformationPools = value
                End Set
            End Property
#Region "           IDisposable Support "
            ' IDisposable
            Private Sub Dispose(disposing As Boolean)
                If Not disposedValue Then
                    If disposing Then
                        Me.This_Number = Nothing
                        Me.This_Stake = Nothing
                        Me.This_Distance = Nothing
                        Me.This_Status = Nothing
                        Me.This_WinnersTime = Nothing
                        Me.This_WinnersTrainer = Nothing
                        Me.This_WinnersBreeding = Nothing
                        Me.This_WinnersOwner = Nothing

                        For Each Placing As Instance.MeetingInformation.RaceInformation.EntryInformationPlacings In Me.This_ListOf_EntryInformationPlacings : Placing.Dispose() : Next
                        Me.This_ListOf_EntryInformationPlacings = Nothing

                        For Each AlsoRan As Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan In Me.This_ListOf_EntryInformationAlsoRan : AlsoRan.Dispose() : Next
                        Me.This_ListOf_EntryInformationAlsoRan = Nothing

                        For Each Scratching As Instance.MeetingInformation.RaceInformation.EntryInformationScratchings In Me.This_ListOf_EntryInformationScratchings : Scratching.Dispose() : Next
                        Me.This_ListOf_EntryInformationScratchings = Nothing

                        For Each Pool As Instance.MeetingInformation.RaceInformation.EntryInformationPools In Me.This_ListOf_EntryInformationPools : Pool.Dispose() : Next
                        Me.This_ListOf_EntryInformationPools = Nothing
                    End If
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
End Namespace