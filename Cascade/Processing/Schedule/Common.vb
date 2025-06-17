Namespace Processing
    Partial Class Schedule
        Friend NotInheritable Class Common
            Private Sub New()
                ' Just so the compiler doesnt create a default constructor
            End Sub
            Friend Shared ReadOnly Property GetAdjustedLengthMin(ByVal MeetingInfo As Instance.MeetingInformation, ByVal Length As String) As String
                Get
                    Dim RACE_LENGTH As Integer = CInt(Length)
                    Select Case MeetingInfo.TYPE
                        Case "H"
                            Return CStr(RACE_LENGTH - 25)
                            Exit Select
                        Case Else ' Gallops
                            Return CStr(RACE_LENGTH - 35)
                            Exit Select
                    End Select
                End Get
            End Property
            Friend Shared ReadOnly Property GetAdjustedLengthMax(ByVal MeetingInfo As Instance.MeetingInformation, ByVal Length As String) As String
                Get
                    Dim RACE_LENGTH As Integer = CInt(Length)
                    Select Case MeetingInfo.TYPE
                        Case "H"
                            Return CStr(RACE_LENGTH + 25)
                            Exit Select
                        Case Else   ' Gallops
                            Return CStr(RACE_LENGTH + 35)
                            Exit Select
                    End Select
                End Get
            End Property
            Friend Shared ReadOnly Property GetSectionFilter(ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal Day As Integer, ByVal Section As String) As String
                Get
                    Dim THIS_FILTER As String = Nothing
                    Dim THIS_AL As ArrayList = ALDistance(MeetingInformation.TYPE, RaceInformation.LENGTH)
                    '
                    Select Case Section
                        Case "DISTANCE", "DISTANCE_THEO"
                            If MeetingInformation.TYPE = "GR" Then
                                THIS_FILTER = "(LENGTH = " & RaceInformation.LENGTH & ") AND (VENUE='" & RaceInformation.VENUE & "')"
                            Else
                                THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(MeetingInformation, RaceInformation.LENGTH) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(MeetingInformation, RaceInformation.LENGTH) & ")"
                            End If
                            Exit Select
                        Case "GROUP", "GROUP_THEO"
                            If MeetingInformation.TYPE = "GR" Then
                                THIS_FILTER = "(LENGTH >= " & THIS_AL(0) & ") AND (LENGTH <= " & THIS_AL(1) & ")"
                            Else
                                THIS_FILTER = "(LENGTH >= " & Schedule.Common.GetAdjustedLengthMin(MeetingInformation, THIS_AL(0)) & ") AND (LENGTH <= " & Schedule.Common.GetAdjustedLengthMax(MeetingInformation, THIS_AL(1)) & ")"
                            End If
                            Exit Select
                        Case Else
                            Exit Select
                    End Select
                    If Not THIS_FILTER Is Nothing Then THIS_FILTER = String.Concat(THIS_FILTER, " AND ")
                    '
                    Dim THIS_DAY As Integer = Day
                    If THIS_DAY = 0 Then THIS_DAY = 365
                    THIS_FILTER = String.Concat(THIS_FILTER, "(MEETING_INFO_OADATE >=" & CStr(CInt(MeetingInformation.OADATE) - (THIS_DAY)) & ") AND (MEETING_INFO_OADATE < " & MeetingInformation.OADATE & ")")
                    '
                    Return THIS_FILTER
                End Get
            End Property
        End Class
    End Class
End Namespace
