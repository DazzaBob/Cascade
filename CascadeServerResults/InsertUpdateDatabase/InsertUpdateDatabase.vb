Friend Class InsertUpdateDatabase : Implements IDisposable
    Private disposedValue As Boolean
    Private ReadOnly _CONNECTION As CascadeCommon.Utils.Connection
    Private Sub New()
        Me.disposedValue = False
    End Sub
    Friend Sub New(Connection As CascadeCommon.Utils.Connection)
        Me.New
        Me._CONNECTION = Connection
    End Sub
    Friend Sub Start(ByRef ListOfMeetingInformation As List(Of Instance.MeetingInformation))
        Dim RemoveAbandonedRaces As New List(Of Instance.MeetingInformation.RaceInformation)

        For Each Meeting As Instance.MeetingInformation In ListOfMeetingInformation
            For Each Race As Instance.MeetingInformation.RaceInformation In Meeting.ListOfRaceInformation
                If Race.Status Is Nothing Then Continue For
                If Race.Status.Contains("AB") Then
                    Call Me.DeleteRace(Meeting.OADate, Meeting.Number, Race.Number)
                    Call RemoveAbandonedRaces.Add(Race)
                    Continue For
                End If
                Call ClearScratchings(Race) ' Removes from the ListOf
                If Race.ListOf_EntryInformationPlacings.Count = 0 Then
                    Call Me.DeleteRace(Meeting.OADate, Meeting.Number, Race.Number)
                    Call RemoveAbandonedRaces.Add(Race)
                End If
            Next Race

            If RemoveAbandonedRaces.Count > 0 Then
                For Each Race As Instance.MeetingInformation.RaceInformation In RemoveAbandonedRaces
                    Meeting.ListOfRaceInformation.Remove(Race)
                Next Race
                Call RemoveAbandonedRaces.Clear()
            End If
        Next Meeting

        For Each Meeting As Instance.MeetingInformation In ListOfMeetingInformation
            For Each Race As Instance.MeetingInformation.RaceInformation In Meeting.ListOfRaceInformation

                Dim CommandText As String = "INSERT INTO RESULTS_XML_RACE ([MEETING_XML_OADATE], [MEETING_XML_NUMBER], [NUMBER], [WINNERSTIME], [WINNERSTRAINER], [WINNERSBREEDING], [WINNERSOWNER]) "
                CommandText += "VALUES (" & Meeting.OADate & ", " & Meeting.Number & ", " & Race.Number & ", '" & Race.WinnersTime & "', "
                CommandText += "'" & Replace(Race.WinnersTrainer, "'", "' + CHAR(39) +'") & "', '" & Replace(Race.WinnersBreeding, "'", "' + CHAR(39) +'") & "', '" & Replace(Race.WinnersOwner, "'", "' + CHAR(39) +'") & "') " & Environment.NewLine
                Call _CONNECTION.Execute(CommandText)

                CommandText = String.Empty
                Using Placings As New Placings(Meeting, Race, _CONNECTION)
                    Call Placings.CommandText()
                End Using

                Using AlsoRan As New AlsoRan(Meeting, Race, _CONNECTION)
                    Call AlsoRan.Insert()
                End Using

                CommandText = String.Empty
                Using Pools As New Pools(Meeting, Race)
                    CommandText += Pools.CommandText
                End Using
                Call Me._CONNECTION.Execute(CommandText)
            Next Race
        Next Meeting
    End Sub
    Private Shared Sub ClearScratchings(ByRef Race As Instance.MeetingInformation.RaceInformation)
        Using S As New Scratchings(Race)
            Call S.Remove()
        End Using
    End Sub
    Private Sub DeleteRace(OADate As String, MeetingNumber As String, [Number] As String)
        Dim CommandText As String = "DELETE FROM RACE_XML WHERE (MEETING_XML_OADATE=" & OADate & ") AND (MEETING_XML_NUMBER=" & MeetingNumber & ") AND (NUMBER=" & Number & ")"
        Call Me._CONNECTION.Execute(CommandText)
    End Sub
    Private Sub Dispose(disposing As Boolean)
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