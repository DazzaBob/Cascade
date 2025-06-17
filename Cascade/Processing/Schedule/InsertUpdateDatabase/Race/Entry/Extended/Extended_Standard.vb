Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Partial Class Entry
                    Partial Class Base
                        Partial Class Extended
                            Private NotInheritable Class Standard : Implements IDisposable
                                Private MeetingInformation As Instance.MeetingInformation
                                Private Section As String
                                Private RunnerRaceList As Data.DataTable
                                Private Theo As String
                                Private Filter As String
                                Private Day As String
                                Private Insert As String
                                Private Values As String
                                Private Runs As Integer
                                Friend Sub New(ByVal MeetingInformation As Instance.MeetingInformation, ByVal Section As String, ByVal RunnerRaceList As Data.DataTable, ByVal Theo As String, ByVal Filter As String, ByVal Day As String, ByVal Runs As Integer)
                                    Me.MeetingInformation = MeetingInformation
                                    Me.Section = Section
                                    Me.RunnerRaceList = RunnerRaceList
                                    Me.Theo = Theo
                                    Me.Filter = Filter
                                    Me.Day = Day
                                    Me.Runs = Runs
                                End Sub
                                Friend Sub Begin(ByRef Insert As String, ByRef Values As String)
                                    Dim FINISHPOSITION_MIN As String = "0", FINISHPOSITION_AVG As String = "0", FINISHPOSITION_MAX As String = "0"
                                    FINISHPOSITION_MIN = Me.RunnerRaceList.Compute("MIN(RESULT_" & Me.Theo & "FINISH_POSITION)", Me.Filter).ToString
                                    FINISHPOSITION_AVG = Me.RunnerRaceList.Compute("AVG(RESULT_" & Me.Theo & "FINISH_POSITION)", Me.Filter).ToString
                                    FINISHPOSITION_MAX = Me.RunnerRaceList.Compute("MAX(RESULT_" & Me.Theo & "FINISH_POSITION)", Me.Filter).ToString
                                    '
                                    Me.Insert += ", [" & Day & "FINISH_POSITION_MIN]" : Me.Values += ", " & FINISHPOSITION_MIN
                                    Me.Insert += ", [" & Day & "FINISH_POSITION_AVG]" : Me.Values += ", " & FINISHPOSITION_AVG
                                    Me.Insert += ", [" & Day & "FINISH_POSITION_MAX]" : Me.Values += ", " & FINISHPOSITION_MAX
                                    '
                                    Call Speed() : Call DistanceBehind() : Call WinsPlaces()
                                    Call SpeedMaxOADate() : Call SpeedMinOADate()
                                    Call Trend() : Call TrendStatus()
                                    Call Length()
                                    '
                                    Insert += Me.Insert : Values += Me.Values
                                End Sub
                                Private Sub Speed()
                                    Dim SPEED_MIN As String = "0", SPEED_AVG As String = "0", SPEED_MAX As String = "0"
                                    SPEED_MIN = Me.RunnerRaceList.Compute("MIN(RESULT_" & Me.Theo & "SPEED)", Me.Filter).ToString
                                    SPEED_AVG = Me.RunnerRaceList.Compute("AVG(RESULT_" & Me.Theo & "SPEED)", Me.Filter).ToString
                                    SPEED_MAX = Me.RunnerRaceList.Compute("MAX(RESULT_" & Me.Theo & "SPEED)", Me.Filter).ToString
                                    '
                                    Me.Insert += ", [" & Day & "SPEED_MIN]" : Me.Values += ", " & SPEED_MIN
                                    Me.Insert += ", [" & Day & "SPEED_AVG]" : Me.Values += ", " & SPEED_AVG
                                    Me.Insert += ", [" & Day & "SPEED_MAX]" : Me.Values += ", " & SPEED_MAX
                                End Sub
                                Private Sub DistanceBehind()
                                    Dim DISTANCEBEHIND_MIN As String = "0", DISTANCEBEHIND_AVG As String = "0", DISTANCEBEHIND_MAX As String = "0"
                                    DISTANCEBEHIND_MIN = Me.RunnerRaceList.Compute("MIN(RESULT_" & Me.Theo & "DISTANCE_BEHIND)", Me.Filter).ToString
                                    DISTANCEBEHIND_AVG = Me.RunnerRaceList.Compute("AVG(RESULT_" & Me.Theo & "DISTANCE_BEHIND)", Me.Filter).ToString
                                    DISTANCEBEHIND_MAX = Me.RunnerRaceList.Compute("MAX(RESULT_" & Me.Theo & "DISTANCE_BEHIND)", Me.Filter).ToString
                                    '
                                    Me.Insert += ", [" & Day & "DISTANCE_BEHIND_MIN]" : Me.Values += ", " & DISTANCEBEHIND_MIN
                                    Me.Insert += ", [" & Day & "DISTANCE_BEHIND_AVG]" : Me.Values += ", " & DISTANCEBEHIND_AVG
                                    Me.Insert += ", [" & Day & "DISTANCE_BEHIND_MAX]" : Me.Values += ", " & DISTANCEBEHIND_MAX
                                End Sub
                                Private Sub WinsPlaces()
                                    Dim WINS As Int32 = 0I, PLACES As Int32 = 0I
                                    WINS = CInt(Me.RunnerRaceList.Compute("COUNT(MEETING_INFO_OADATE)", "(RESULT_" & Me.Theo & "FINISH_POSITION = 1) AND " & Filter))
                                    PLACES = CInt(Me.RunnerRaceList.Compute("COUNT(MEETING_INFO_OADATE)", "(RESULT_" & Me.Theo & "FINISH_POSITION = 1 OR RESULT_" & Me.Theo & "FINISH_POSITION = 2 OR RESULT_" & Me.Theo & "FINISH_POSITION = 3) AND " & Filter))
                                    '
                                    Me.Insert += ", [" & Day & "WINS]" : Me.Values += ", " & CStr(CDec(WINS / Me.Runs) * 100)
                                    Me.Insert += ", [" & Day & "PLACES]" : Me.Values += ", " & CStr(CDec(PLACES / Me.Runs) * 100)
                                End Sub
                                Private Sub SpeedMaxOADate()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter, "RESULT_" & Me.Theo & "SPEED DESC")
                                    Dim SPEEDMAXOADATE As Integer = 0 : SPEEDMAXOADATE = CInt(DR(0).Item("MEETING_INFO_OADATE"))
                                    SPEEDMAXOADATE = CInt(Me.MeetingInformation.OADATE) - SPEEDMAXOADATE
                                    If SPEEDMAXOADATE = CInt(Me.MeetingInformation.OADATE) Then SPEEDMAXOADATE = 0I
                                    Me.Insert += ", [" & Day & "SPEED_MAX_DAYSAGO]" : Me.Values += ", " & SPEEDMAXOADATE.ToString(Globalization.CultureInfo.InvariantCulture)
                                End Sub
                                Private Sub SpeedMinOADate()
                                    Dim DR() As Data.DataRow = Me.RunnerRaceList.Select(Filter, "RESULT_" & Me.Theo & "SPEED ASC")
                                    Dim SPEEDMINOADATE As Integer = 0 : SPEEDMINOADATE = CInt(DR(0).Item("MEETING_INFO_OADATE"))
                                    SPEEDMINOADATE = CInt(Me.MeetingInformation.OADATE) - SPEEDMINOADATE
                                    If SPEEDMINOADATE = CInt(Me.MeetingInformation.OADATE) Then SPEEDMINOADATE = 0I
                                    Me.Insert += ", [" & Day & "SPEED_MIN_DAYSAGO]" : Me.Values += ", " & SPEEDMINOADATE.ToString(Globalization.CultureInfo.InvariantCulture)
                                End Sub
                                Private Sub Trend()
                                    Dim istheo As Boolean = False
                                    If Me.Theo IsNot Nothing Then istheo = True
                                    Me.Insert += ", [" & Day & "TREND]"
                                    Using Trend As New Trends(Me.RunnerRaceList, Me.Filter, istheo)
                                        Me.Values += ", " & Trend.GetTrend()
                                    End Using
                                End Sub
                                Private Sub TrendStatus()
                                    Me.Insert += ", [" & Day & "TREND_STATUS]"
                                    Me.Values += ", " & Trends.TrendStatus(Filter, Me.RunnerRaceList, Theo)
                                End Sub
                                Private Sub Length()
                                    If Me.Section.Contains("DISTANCE") Then Return
                                    '
                                    Dim LENGTH_MIN As String = "0", LENGTH_AVG As String = "0", LENGTH_MAX As String = "0"
                                    If Theo Is Nothing Then
                                        LENGTH_MIN = Me.RunnerRaceList.Compute("MIN(LENGTH)", Me.Filter).ToString
                                        LENGTH_AVG = Me.RunnerRaceList.Compute("AVG(LENGTH)", Me.Filter).ToString
                                        LENGTH_MAX = Me.RunnerRaceList.Compute("MAX(LENGTH)", Me.Filter).ToString
                                    Else
                                        LENGTH_MIN = Me.RunnerRaceList.Compute("MIN(RESULT_THEO_DISTANCE_RAN)", Me.Filter).ToString
                                        LENGTH_AVG = Me.RunnerRaceList.Compute("AVG(RESULT_THEO_DISTANCE_RAN)", Me.Filter).ToString
                                        LENGTH_MAX = Me.RunnerRaceList.Compute("MAX(RESULT_THEO_DISTANCE_RAN)", Me.Filter).ToString
                                    End If
                                    '
                                    Me.Insert += ", [" & Day & "LENGTH_MIN]" : Me.Values += ", " & LENGTH_MIN
                                    Me.Insert += ", [" & Day & "LENGTH_AVG]" : Me.Values += ", " & LENGTH_AVG
                                    Me.Insert += ", [" & Day & "LENGTH_MAX]" : Me.Values += ", " & LENGTH_MAX
                                End Sub
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