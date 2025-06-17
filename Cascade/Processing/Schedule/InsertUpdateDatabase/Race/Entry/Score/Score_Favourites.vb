Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Partial Class Entry
                    Partial Class Score
                        Private NotInheritable Class Favourites
                            Private Sub New()
                                ' Just so the compiler doesnt create a default constructor
                            End Sub
                            Friend Shared ReadOnly Property RankTotal(ByVal MeetingInfo As Instance.MeetingInformation, ByVal RaceInfo As Instance.MeetingInformation.RaceInformation, ByVal Row As Data.DataRow, ByVal SectionDataTable As Data.DataTable, sDay As String) As Double
                                Get
                                    Dim My_RankTotal As Double = 0.0#
                                    My_RankTotal = GetFavDistance(MeetingInfo, RaceInfo, Row, sDay)
                                    My_RankTotal += GetFavDistanceWins(RaceInfo, Row, SectionDataTable, sDay)
                                    My_RankTotal += GetFavDistancePlaces(RaceInfo, Row, SectionDataTable, sDay)
                                    '
                                    My_RankTotal = GetFavGroup(MeetingInfo, RaceInfo, Row, sDay)
                                    My_RankTotal += GetFavGroupWins(RaceInfo, Row, SectionDataTable, sDay)
                                    My_RankTotal += GetFavGroupPlaces(RaceInfo, Row, SectionDataTable, sDay)
                                    '
                                    Return My_RankTotal
                                End Get
                            End Property
#Region "                           FAVOURITE DISTANCE "
                            Private Shared ReadOnly Property GetFavDistance(ByVal MeetingInfo As Instance.MeetingInformation, ByVal RaceInfo As Instance.MeetingInformation.RaceInformation, ByVal Row As Data.DataRow, ByVal sDay As String) As Double
                                Get
                                    Dim RankTotal As Double = 0.0#
                                    If CBool(Row.Item(sDay & "IS_FAV_DISTANCE")) = True Then RankTotal += Common.GetRuns(MeetingInfo, RaceInfo, Row, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_DISTANCE_TRACK")) = True Then RankTotal += Common.GetRuns(MeetingInfo, RaceInfo, Row, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_DISTANCE_WEATHER")) = True Then RankTotal += Common.GetRuns(MeetingInfo, RaceInfo, Row, sDay)
                                    '
                                    Return RankTotal
                                End Get
                            End Property
                            Private Shared ReadOnly Property GetFavDistanceWins(ByVal RaceInfo As Instance.MeetingInformation.RaceInformation, ByVal Row As Data.DataRow, ByVal SectionDataTable As Data.DataTable, ByVal sDay As String) As Double
                                Get
                                    Dim RankTotal As Double = 0.0#
                                    If CBool(Row.Item(sDay & "IS_FAV_DISTANCE_WINS")) = True Then RankTotal += Common.GetWins(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_DISTANCE_TRACK_WINS")) = True Then RankTotal += Common.GetWins(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_DISTANCE_WEATHER_WINS")) = True Then RankTotal += Common.GetWins(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    '
                                    Return RankTotal
                                End Get
                            End Property
                            Private Shared ReadOnly Property GetFavDistancePlaces(ByVal RaceInfo As Instance.MeetingInformation.RaceInformation, ByVal Row As Data.DataRow, ByVal SectionDataTable As Data.DataTable, ByVal sDay As String) As Double
                                Get
                                    Dim RankTotal As Double = 0.0#
                                    If CBool(Row.Item(sDay & "IS_FAV_DISTANCE_PLACES")) = True Then RankTotal += Common.GetPlaces(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_DISTANCE_TRACK_PLACES")) = True Then RankTotal += Common.GetPlaces(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_DISTANCE_WEATHER_PLACES")) = True Then RankTotal += Common.GetPlaces(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    '
                                    Return RankTotal
                                End Get
                            End Property
#End Region
#Region "                           FAVOURITE GROUP "
                            Private Shared ReadOnly Property GetFavGroup(ByVal MeetingInfo As Instance.MeetingInformation, ByVal RaceInfo As Instance.MeetingInformation.RaceInformation, ByVal Row As Data.DataRow, ByVal sDay As String) As Double
                                Get
                                    Dim RankTotal As Double = 0.0#
                                    If CBool(Row.Item(sDay & "IS_FAV_GROUP")) = True Then RankTotal += Common.GetRuns(MeetingInfo, RaceInfo, Row, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_GROUP_TRACK")) = True Then RankTotal += Common.GetRuns(MeetingInfo, RaceInfo, Row, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_GROUP_WEATHER")) = True Then RankTotal += Common.GetRuns(MeetingInfo, RaceInfo, Row, sDay)
                                    '
                                    Return RankTotal
                                End Get
                            End Property
                            Private Shared ReadOnly Property GetFavGroupWins(ByVal RaceInfo As Instance.MeetingInformation.RaceInformation, ByVal Row As Data.DataRow, ByVal SectionDataTable As Data.DataTable, ByVal sDay As String) As Double
                                Get
                                    Dim RankTotal As Double = 0.0#
                                    If CBool(Row.Item(sDay & "IS_FAV_GROUP_WINS")) = True Then RankTotal += Common.GetWins(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_GROUP_TRACK_WINS")) = True Then RankTotal += Common.GetWins(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_GROUP_WEATHER_WINS")) = True Then RankTotal += Common.GetWins(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    '
                                    Return RankTotal
                                End Get
                            End Property
                            Private Shared ReadOnly Property GetFavGroupPlaces(ByVal RaceInfo As Instance.MeetingInformation.RaceInformation, ByVal Row As Data.DataRow, ByVal SectionDataTable As Data.DataTable, ByVal sDay As String) As Double
                                Get
                                    Dim RankTotal As Double = 0.0#
                                    If CBool(Row.Item(sDay & "IS_FAV_GROUP_PLACES")) = True Then RankTotal += Common.GetPlaces(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_GROUP_TRACK_PLACES")) = True Then RankTotal += Common.GetPlaces(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    If CBool(Row.Item(sDay & "IS_FAV_GROUP_WEATHER_PLACES")) = True Then RankTotal += Common.GetPlaces(RaceInfo.ListOfEntryInformation.Count, CStr(Row.Item("NUMBER")), SectionDataTable, sDay)
                                    '
                                    Return RankTotal
                                End Get
                            End Property
#End Region
                        End Class
                    End Class
                End Class
            End Class
        End Class
    End Class
End Namespace