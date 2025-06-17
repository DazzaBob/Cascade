Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Partial Class Entry
                    Partial Class Base
                        Private NotInheritable Class Extended : Implements IDisposable
                            Private MeetingInformation As Instance.MeetingInformation
                            Private RaceInformation As Instance.MeetingInformation.RaceInformation
                            Private RunnerRaceList As Data.DataTable
                            Private Insert As String
                            Private Values As String
                            Private Section As String
                            Friend Sub New(ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal RunnerRaceList As Data.DataTable, ByVal Section As String)
                                Me.MeetingInformation = MeetingInformation
                                Me.RaceInformation = RaceInformation
                                Me.RunnerRaceList = RunnerRaceList
                                Me.Insert = Nothing
                                Me.Values = Nothing
                                Me.Section = Section
                            End Sub
                            Friend Sub Begin(ByRef Insert As String, ByRef Values As String)
                                For Each Day As Integer In New Integer() {0, 90, 180, 270}
                                    Dim FILTER As String = Schedule.Common.GetSectionFilter(Me.MeetingInformation, Me.RaceInformation, Day, Section)
                                    Dim DR() As Data.DataRow = RunnerRaceList.Select(FILTER, "MEETING_INFO_OADATE DESC")
                                    If DR.Length = 0 Then Return
                                    '
                                    Call GetValuesForInsert(FILTER, Day)
                                Next Day
                                Insert += Me.Insert : Values += Me.Values
                            End Sub
                            Private Sub GetValuesForInsert(ByRef Filter As String, ByVal Day As Integer)
                                Dim sDAY As String = Day.ToString(Globalization.CultureInfo.InvariantCulture)
                                Dim THEO As String = Nothing
                                Dim RUNS As Int32 = 0I
                                If Section.Contains("THEO") Then THEO = "THEO_"
                                If Day > 0 Then sDAY = String.Concat(sDAY, "_") Else sDAY = ""
                                '
                                RUNS = CInt(RunnerRaceList.Compute("COUNT(MEETING_INFO_OADATE)", Filter))
                                Me.Insert += ", [" & sDAY & "RUNS]" : Me.Values += ", " & CStr(RUNS)
                                '
                                Using Standard As New Standard(Me.MeetingInformation, Me.Section, Me.RunnerRaceList, THEO, Filter, sDAY, RUNS)
                                    Call Standard.Begin(Me.Insert, Me.Values)
                                End Using
                                '
                                Call SetFavourites(Day, sDAY)
                            End Sub
                            Private Sub SetFavourites(ByVal Day As Integer, ByVal sDay As String)
                                If Not Section.Contains("DISTANCE") Then Return
                                ' IS_FAV_DISTANCE, IS_FAV_DISTANCE_WINS and IS_FAV_GROUP have a default of 0
                                If IsFavouriteDistance(Day) Then
                                    Me.Insert += ", [" & sDay & "IS_FAV_DISTANCE]" : Me.Values += ", 1"
                                    Me.Insert += ", [" & sDay & "IS_FAV_GROUP]" : Me.Values += ", 1"
                                Else
                                    If IsFavouriteGroup(Day) Then
                                        Me.Insert += ", [" & sDay & "IS_FAV_GROUP]" : Me.Values += ", 1"
                                    End If
                                End If
                                '
                                Using FavouriteDistance As New IsFavouriteDistances(Me.MeetingInformation, Me.RaceInformation, Me.RunnerRaceList, Day, Me.Section)
                                    Call FavouriteDistance.IsFavouriteDistanceWins(Me.Insert, Me.Values)
                                    Call FavouriteDistance.IsFavouriteDistancePlaces(Me.Insert, Me.Values)
                                    '
                                    Call FavouriteDistance.IsFavouriteDistanceTrack(Me.Insert, Me.Values)
                                    Call FavouriteDistance.IsFavouriteDistanceTrackWins(Me.Insert, Me.Values)
                                    Call FavouriteDistance.IsFavouriteDistanceTrackPlaces(Me.Insert, Me.Values)
                                    '
                                    Call FavouriteDistance.IsFavouriteDistanceWeather(Me.Insert, Me.Values)
                                    Call FavouriteDistance.IsFavouriteDistanceWeatherWins(Me.Insert, Me.Values)
                                    Call FavouriteDistance.IsFavouriteDistanceWeatherPlaces(Me.Insert, Me.Values)
                                End Using
                                '
                                Using FavouriteGroups As New IsFavouriteGroups(Me.MeetingInformation, Me.RaceInformation, Me.RunnerRaceList, Day, Me.Section)
                                    Call FavouriteGroups.IsFavouriteGroupWins(Me.Insert, Me.Values)
                                    Call FavouriteGroups.IsFavouriteGroupPlaces(Me.Insert, Me.Values)
                                    '
                                    Call FavouriteGroups.IsFavouriteGroupTrack(Me.Insert, Me.Values)
                                    Call FavouriteGroups.IsFavouriteGroupTrackWins(Me.Insert, Me.Values)
                                    Call FavouriteGroups.IsFavouriteGroupTrackPlaces(Me.Insert, Me.Values)
                                    '
                                    Call FavouriteGroups.IsFavouriteGroupWeather(Me.Insert, Me.Values)
                                    Call FavouriteGroups.IsFavouriteGroupWeatherWins(Me.Insert, Me.Values)
                                    Call FavouriteGroups.IsFavouriteGroupWeatherPlaces(Me.Insert, Me.Values)
                                End Using
                            End Sub
#Region "                           DISTANCE "
                            Private Function IsFavouriteDistance(ByVal Day As Integer) As Boolean
                                Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                Dim Filter As String = GetDistanceForFilter(Day)
                                Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                If DR.Length > 0 Then COUNTFOR = DR.Count
                                '
                                Filter = GetDistanceAganistFilter(Day)
                                DR = Me.RunnerRaceList.Select(Filter)
                                If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                '
                                If COUNTFOR > COUNTAGAINST Then Return True
                                Return False
                            End Function
                            Private Function GetDistanceForFilter(ByVal Day As Integer) As String
                                Dim THIS_FILTER As String = Nothing
                                '
                                If Me.MeetingInformation.TYPE = "GR" Then
                                    THIS_FILTER = "(LENGTH = " & Me.RaceInformation.LENGTH & ") AND (VENUE='" & Me.RaceInformation.VENUE & "')"
                                Else
                                    THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                End If
                                '
                                THIS_FILTER += " AND "
                                Dim THIS_DAY As Integer = Day
                                If THIS_DAY = 0 Then THIS_DAY = 365
                                THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                '
                                Return THIS_FILTER
                            End Function
                            Private Function GetDistanceAganistFilter(ByVal Day As Integer) As String
                                Dim THIS_FILTER As String = Nothing
                                '
                                If Me.MeetingInformation.TYPE = "GR" Then
                                    THIS_FILTER = "(LENGTH <> " & Me.RaceInformation.LENGTH & ")"
                                Else
                                    THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                End If
                                '
                                THIS_FILTER += " AND "
                                Dim THIS_DAY As Integer = Day
                                If THIS_DAY = 0 Then THIS_DAY = 365
                                THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                '
                                Return THIS_FILTER
                            End Function
#End Region
#Region "                           GROUP "
                            Private Function IsFavouriteGroup(ByVal Day As Integer) As Boolean
                                Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                Dim Filter As String = GetGroupForFilter(Day)
                                Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                If DR.Length > 0 Then COUNTFOR = DR.Count
                                '
                                Filter = GetGroupAganistFilter(Day)
                                DR = Me.RunnerRaceList.Select(Filter)
                                If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                '
                                If COUNTFOR > COUNTAGAINST Then Return True
                                Return False
                            End Function
                            Private Function GetGroupForFilter(ByVal Day As Integer) As String
                                Dim THIS_FILTER As String = Nothing
                                Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                '
                                If Me.MeetingInformation.TYPE = "GR" Then
                                    THIS_FILTER = "(LENGTH >= " & THIS_AL(0) & ") AND (LENGTH <= " & THIS_AL(1) & ")"
                                Else
                                    THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
                                End If
                                '
                                THIS_FILTER += " AND "
                                Dim THIS_DAY As Integer = Day
                                If THIS_DAY = 0 Then THIS_DAY = 365
                                THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                '
                                Return THIS_FILTER
                            End Function
                            Private Function GetGroupAganistFilter(ByVal Day As Integer) As String
                                Dim THIS_FILTER As String = Nothing
                                Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                '
                                If Me.MeetingInformation.TYPE = "GR" Then
                                    THIS_FILTER = "(LENGTH < " & THIS_AL(0) & ") AND (LENGTH > " & THIS_AL(1) & ")"
                                Else
                                    THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
                                End If
                                '
                                THIS_FILTER += " AND "
                                Dim THIS_DAY As Integer = Day
                                If THIS_DAY = 0 Then THIS_DAY = 365
                                THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                '
                                Return THIS_FILTER
                            End Function
#End Region
#Region "IDisposable Support"
                            Private disposedValue As Boolean ' To detect redundant calls

                            ' IDisposable
                            Protected Sub Dispose(disposing As Boolean)
                                If Not Me.disposedValue Then
                                    If disposing Then
                                        ' TODO: dispose managed state (managed objects).
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
        End Class
    End Class
End Namespace