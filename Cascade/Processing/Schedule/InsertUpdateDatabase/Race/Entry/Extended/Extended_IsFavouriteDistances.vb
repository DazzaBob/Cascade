Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Partial Class Entry
                    Partial Class Base
                        Partial Class Extended
                            Private NotInheritable Class IsFavouriteDistances : Implements IDisposable
                                Private MeetingInformation As Instance.MeetingInformation
                                Private RaceInformation As Instance.MeetingInformation.RaceInformation
                                Private RunnerRaceList As Data.DataTable
                                Private Day As Integer
                                Private Section As String
                                Friend Sub New(ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal RunnerRaceList As Data.DataTable, ByVal Day As Integer, ByVal Section As String)
                                    Me.MeetingInformation = MeetingInformation
                                    Me.RaceInformation = RaceInformation
                                    Me.RunnerRaceList = RunnerRaceList
                                    Me.Day = Day
                                    Me.Section = Section
                                End Sub
                                Friend Sub IsFavouriteDistanceWins(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetDistanceWinsForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetDistanceWinsAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Me.Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_DISTANCE_WINS]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteDistancePlaces(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetDistancePlacesForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetDistancePlacesAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Me.Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_DISTANCE_PLACES]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteDistanceTrack(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetDistanceTrackForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetDistanceTrackAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Me.Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_DISTANCE_TRACK]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteDistanceTrackWins(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetDistanceTrackWinsForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetDistanceTrackWinsAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Me.Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_DISTANCE_TRACK_WINS]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteDistanceTrackPlaces(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetDistanceTrackPlacesForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetDistanceTrackPlacesAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Me.Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_DISTANCE_TRACK_PLACES]" : Values += ", 1"
                                    End If
                                End Sub
                                '
                                Friend Sub IsFavouriteDistanceWeather(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetDistanceWeatherForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetDistanceWeatherAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Me.Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_DISTANCE_WEATHER]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteDistanceWeatherWins(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetDistanceWeatherWinsForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetDistanceWeatherWinsAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Me.Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_DISTANCE_WEATHER_WINS]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteDistanceWeatherPlaces(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetDistanceWeatherPlacesForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetDistanceWeatherPlacesAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Me.Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_DISTANCE_WEATHER_PLACES]" : Values += ", 1"
                                    End If
                                End Sub
#Region "                           DISTANCE FILTERS "
#Region "                           DISTANCE_WINS FILTERS "
                                Private Function GetDistanceWinsForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH = " & Me.RaceInformation.LENGTH & ") AND (VENUE='" & Me.RaceInformation.VENUE & "')"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1)"
                                    '
                                    Return THIS_FILTER
                                End Function
                                Private Function GetDistanceWinsAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH <> " & Me.RaceInformation.LENGTH & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1)"
                                    '
                                    Return THIS_FILTER
                                End Function
#End Region
#Region "                           DISTANCE_PLACES FILTERS "
                                Private Function GetDistancePlacesForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH = " & Me.RaceInformation.LENGTH & ") AND (VENUE='" & Me.RaceInformation.VENUE & "')"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION < 4)"
                                    '
                                    Return THIS_FILTER
                                End Function
                                Private Function GetDistancePlacesAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH <> " & Me.RaceInformation.LENGTH & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION < 4)"
                                    '
                                    Return THIS_FILTER
                                End Function
#End Region
#Region "                           DISTANCE_TRACK "
#Region "                           DISTANCE_TRACK FILTERS "
                                Private Function GetDistanceTrackForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH = " & Me.RaceInformation.LENGTH & ") AND (VENUE='" & Me.RaceInformation.VENUE & "')"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (TRACK='" & Me.RaceInformation.TRACK & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
                                Private Function GetDistanceTrackAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH <> " & Me.RaceInformation.LENGTH & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (TRACK <>'" & Me.RaceInformation.TRACK & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
#End Region
#Region "                           DISTANCE_TRACK_WINS FILTERS "
                                Private Function GetDistanceTrackWinsForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH = " & Me.RaceInformation.LENGTH & ") AND (VENUE='" & Me.RaceInformation.VENUE & "')"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1)"
                                    THIS_FILTER += " AND (TRACK='" & Me.RaceInformation.TRACK & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
                                Private Function GetDistanceTrackWinsAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH <> " & Me.RaceInformation.LENGTH & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1)"
                                    THIS_FILTER += " AND (TRACK <> '" & Me.RaceInformation.TRACK & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
#End Region
#Region "                           DISTANCE_TRACK_PLACES FILTERS "
                                Private Function GetDistanceTrackPlacesForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH = " & Me.RaceInformation.LENGTH & ") AND (VENUE='" & Me.RaceInformation.VENUE & "')"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1 OR  RESULT_" & THIS_THEO & "FINISH_POSITION=2 OR RESULT_" & THIS_THEO & "FINISH_POSITION=3)"
                                    THIS_FILTER += " AND (TRACK='" & Me.RaceInformation.TRACK & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
                                Private Function GetDistanceTrackPlacesAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH <> " & Me.RaceInformation.LENGTH & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1 OR  RESULT_" & THIS_THEO & "FINISH_POSITION=2 OR RESULT_" & THIS_THEO & "FINISH_POSITION=3)"
                                    THIS_FILTER += " AND (TRACK <> '" & Me.RaceInformation.TRACK & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
#End Region
#End Region
#Region "                           DISTANCE_WEATHER "
#Region "                           DISTANCE_WEATHER FILTERS "
                                Private Function GetDistanceWeatherForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH = " & Me.RaceInformation.LENGTH & ") AND (VENUE='" & Me.RaceInformation.VENUE & "')"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (WEATHER='" & Me.RaceInformation.WEATHER & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
                                Private Function GetDistanceWeatherAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH <> " & Me.RaceInformation.LENGTH & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (WEATHER <>'" & Me.RaceInformation.WEATHER & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
#End Region
#Region "                           DISTANCE_WEATHER_WINS FILTERS "
                                Private Function GetDistanceWeatherWinsForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH = " & Me.RaceInformation.LENGTH & ") AND (VENUE='" & Me.RaceInformation.VENUE & "')"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1)"
                                    THIS_FILTER += " AND (WEATHER='" & Me.RaceInformation.WEATHER & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
                                Private Function GetDistanceWeatherWinsAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH <> " & Me.RaceInformation.LENGTH & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1)"
                                    THIS_FILTER += " AND (WEATHER <> '" & Me.RaceInformation.WEATHER & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
#End Region
#Region "                           DISTANCE_WEATHER_PLACES FILTERS "
                                Private Function GetDistanceWeatherPlacesForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH = " & Me.RaceInformation.LENGTH & ") AND (VENUE='" & Me.RaceInformation.VENUE & "')"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1 OR  RESULT_" & THIS_THEO & "FINISH_POSITION=2 OR RESULT_" & THIS_THEO & "FINISH_POSITION=3)"
                                    THIS_FILTER += " AND (WEATHER='" & Me.RaceInformation.WEATHER & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
                                Private Function GetDistanceWeatherPlacesAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH <> " & Me.RaceInformation.LENGTH & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, Me.RaceInformation.LENGTH) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1 OR  RESULT_" & THIS_THEO & "FINISH_POSITION=2 OR RESULT_" & THIS_THEO & "FINISH_POSITION=3)"
                                    THIS_FILTER += " AND (WEATHER <> '" & Me.RaceInformation.WEATHER & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
#End Region
#End Region
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
    End Class
End Namespace