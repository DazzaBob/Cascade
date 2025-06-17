Partial Class InsertUpdateDatabase
    Friend Class Scratchings : Implements IDisposable
        Private disposedValue As Boolean
        Private This_RaceInformation As Instance.MeetingInformation.RaceInformation
        Private Sub New()
            Me.disposedValue = False
        End Sub
        Friend Sub New(ByRef RaceInformation As Instance.MeetingInformation.RaceInformation)
            Me.New
            Me.This_RaceInformation = RaceInformation
        End Sub
        Friend Sub Remove()
            Dim RemoveAlsoRan As New List(Of Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan)

            For Each Scratching As Instance.MeetingInformation.RaceInformation.EntryInformationScratchings In Me.This_RaceInformation.ListOf_EntryInformationScratchings
                For Each AlsoRan As Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan In Me.This_RaceInformation.ListOf_EntryInformationAlsoRan
                    If Scratching.Number = AlsoRan.Number Then
                        RemoveAlsoRan.Add(AlsoRan)
                    End If
                    Exit For
                Next AlsoRan
            Next Scratching

            If RemoveAlsoRan.Count > 0 Then
                For Each Scratching As Instance.MeetingInformation.RaceInformation.EntryInformationAlsoRan In RemoveAlsoRan
                    If Me.This_RaceInformation.ListOf_EntryInformationAlsoRan.Remove(Scratching) Then Continue For
                Next
            End If
        End Sub
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects)
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
End Class