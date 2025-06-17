Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Partial Class Entry
                    Partial Class Base
                        Partial Class Extended
                            Private NotInheritable Class IsFavouriteGroups : Implements IDisposable
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
                                Friend Sub IsFavouriteGroupWins(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetGroupWinsForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetGroupWinsAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_GROUP_WINS]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteGroupPlaces(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetGroupPlacesForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetGroupPlacesAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_GROUP_PLACES]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteGroupTrack(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetGroupTrackForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetGroupTrackAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_GROUP_TRACK]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteGroupTrackWins(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetGroupTrackWinsForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetGroupTrackWinsAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_GROUP_TRACK_WINS]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteGroupTrackPlaces(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetGroupTrackPlacesForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetGroupTrackPlacesAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_GROUP_TRACK_PLACES]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteGroupWeather(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetGroupWeatherForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetGroupWeatherAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_GROUP_WEATHER]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteGroupWeatherWins(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetGroupWeatherWinsForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetGroupWeatherWinsAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_GROUP_WEATHER_WINS]" : Values += ", 1"
                                    End If
                                End Sub
                                Friend Sub IsFavouriteGroupWeatherPlaces(ByRef Insert As String, ByRef Values As String)
                                    Dim COUNTFOR As Integer = 0I, COUNTAGAINST As Integer = 0I
                                    Dim Filter As String = GetGroupWeatherPlacesForFilter()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTFOR = DR.Count
                                    '
                                    Filter = GetGroupWeatherPlacesAganistFilter()
                                    DR = Me.RunnerRaceList.Select(Filter)
                                    If DR.Length > 0 Then COUNTAGAINST = DR.Count
                                    '
                                    If COUNTFOR > COUNTAGAINST Then
                                        Dim sDay As String = CStr(Me.Day)
                                        If Day > 0 Then sDay += "_" Else sDay = ""
                                        Insert += ", [" & sDay & "IS_FAV_GROUP_WEATHER_PLACES]" : Values += ", 1"
                                    End If
                                End Sub
#Region "                           GROUP FILTERS "
#Region "                           GROUP_WINS FILTERS "
                                Private Function GetGroupWinsForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH >= " & THIS_AL(0) & ") AND (LENGTH <= " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
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
                                Private Function GetGroupWinsAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH < " & THIS_AL(0) & ") AND (LENGTH > " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
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
#Region "                           GROUP_PLACES FILTERS "
                                Private Function GetGroupPlacesForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH >= " & THIS_AL(0) & ") AND (LENGTH <= " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1 OR  RESULT_" & THIS_THEO & "FINISH_POSITION=2 OR RESULT_" & THIS_THEO & "FINISH_POSITION=3)"
                                    '
                                    Return THIS_FILTER
                                End Function
                                Private Function GetGroupPlacesAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH < " & THIS_AL(0) & ") AND (LENGTH > " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
                                    End If
                                    '
                                    THIS_FILTER += " AND "
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (RESULT_" & THIS_THEO & "FINISH_POSITION=1 OR  RESULT_" & THIS_THEO & "FINISH_POSITION=2 OR RESULT_" & THIS_THEO & "FINISH_POSITION=3)"
                                    '
                                    Return THIS_FILTER
                                End Function
#End Region
#Region "                           GROUP_TRACK_ FILTERS "
#Region "                           GROUP_TRACK FILTERS "
                                Private Function GetGroupTrackForFilter() As String
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
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (TRACK='" & Me.RaceInformation.TRACK & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
                                Private Function GetGroupTrackAganistFilter() As String
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
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (TRACK <> '" & Me.RaceInformation.TRACK & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
#End Region
#Region "                           GROUP_TRACK_WINS FILTERS "
                                Private Function GetGroupTrackWinsForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH >= " & THIS_AL(0) & ") AND (LENGTH <= " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
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
                                Private Function GetGroupTrackWinsAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH < " & THIS_AL(0) & ") AND (LENGTH > " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
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
#Region "                           GROUP_TRACK_PLACES FILTERS "
                                Private Function GetGroupTrackPlacesForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH >= " & THIS_AL(0) & ") AND (LENGTH <= " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
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
                                Private Function GetGroupTrackPlacesAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH < " & THIS_AL(0) & ") AND (LENGTH > " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
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
#Region "                           GROUP_WEATHER_ FILTERS "
#Region "                           GROUP_WEATHER FILTERS "
                                Private Function GetGroupWeatherForFilter() As String
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
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (WEATHER='" & Me.RaceInformation.WEATHER & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
                                Private Function GetGroupWeatherAganistFilter() As String
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
                                    Dim THIS_DAY As Integer = Me.Day
                                    If THIS_DAY = 0 Then THIS_DAY = 365
                                    THIS_FILTER += "(MEETING_INFO_OADATE >=" & CStr(CInt(Me.MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & Me.MeetingInformation.OADATE & ")"
                                    THIS_FILTER += " AND (WEATHER <> '" & Me.RaceInformation.WEATHER & "')"
                                    '
                                    Return THIS_FILTER
                                End Function
#End Region
#Region "                           GROUP_WEATHER_WINS FILTERS "
                                Private Function GetGroupWeatherWinsForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH >= " & THIS_AL(0) & ") AND (LENGTH <= " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
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
                                Private Function GetGroupWeatherWinsAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH < " & THIS_AL(0) & ") AND (LENGTH > " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
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
#Region "                           GROUP_WEATHER_PLACES FILTERS "
                                Private Function GetGroupWeatherPlacesForFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH >= " & THIS_AL(0) & ") AND (LENGTH <= " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
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
                                Private Function GetGroupWeatherPlacesAganistFilter() As String
                                    Dim THIS_FILTER As String = Nothing
                                    Dim THIS_AL As ArrayList = ALDistance(Me.MeetingInformation.TYPE, Me.RaceInformation.LENGTH)
                                    Dim THIS_THEO As String = ""
                                    If Me.Section = "DISTANCE_THEO" Then THIS_THEO = "THEO_"
                                    '
                                    If Me.MeetingInformation.TYPE = "GR" Then
                                        THIS_FILTER = "(LENGTH < " & THIS_AL(0) & ") AND (LENGTH > " & THIS_AL(1) & ")"
                                    Else
                                        THIS_FILTER = "(LENGTH < " & Schedule.Common.GetAdjustedLengthMin(Me.MeetingInformation, THIS_AL(0)) & ") AND (LENGTH > " & Schedule.Common.GetAdjustedLengthMax(Me.MeetingInformation, THIS_AL(1)) & ")"
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
#Region "                           IDisposable Support"
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
