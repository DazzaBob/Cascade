Partial Class ModelRun
    Private Class General
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Friend Shared ReadOnly Property SQLFilter(StartDate As String, FinishDate As String, Country As String, Type As String, Venue As String, Length As String) As String
            Get
                Dim THIS_FILTER As String = " WHERE (MEETING_INFO.OADATE >= " & StartDate & ") AND (MEETING_INFO.OADATE <=" & FinishDate & ")"
                If Country IsNot Nothing AndAlso Country.Length Then THIS_FILTER += " AND (MEETING_INFO.COUNTRY=N'" & Country & "')"
                If Type IsNot Nothing AndAlso Type.Length > 0 Then THIS_FILTER += " AND (MEETING_INFO.TYPE =N'" & Type & "')"
                If Venue IsNot Nothing AndAlso Venue.Length > 0 Then THIS_FILTER += " AND (RACE_INFO.VENUE=N'" & Venue & "')"
                If Length IsNot Nothing AndAlso Length.Length > 0 Then THIS_FILTER += " AND (RACE_INFO.LENGTH=" & Length & ")"

                Return THIS_FILTER
            End Get
        End Property
        Friend Shared ReadOnly Property DTFilter(ByVal Type As String, ByVal Country As String, ByVal Length As String, ByVal Weather As String, ByVal Venue As String, ByVal Track As String, ByVal GTE As String, ByVal LTE As String) As String
            Get
                Dim THIS_FILTER As String = ""
                '
                Call SetTypeCountryDTFilter(Type, Country, THIS_FILTER)
                '
                If Not Length Is Nothing AndAlso Length.Length > 0 Then THIS_FILTER += "(LENGTH=" & Length & ") AND "
                If Not Weather Is Nothing AndAlso Weather.Length > 0 Then THIS_FILTER += "(WEATHER='" & Weather & "') AND "
                If Not Venue Is Nothing AndAlso Venue.Length > 0 Then THIS_FILTER += "(VENUE='" & Venue & "') AND "
                If Not Track Is Nothing AndAlso Track.Length > 0 Then THIS_FILTER += "(TRACK='" & Track & "') AND "
                If Not GTE Is Nothing AndAlso GTE.Length > 0 Then THIS_FILTER += "(RUNNERSINRACE >=" & GTE & ") AND "
                If Not LTE Is Nothing AndAlso LTE.Length > 0 Then THIS_FILTER += "(RUNNERSINRACE <=" & LTE & ")"
                '
                If Strings.Right(THIS_FILTER, 5) = " AND " Then THIS_FILTER = Strings.Left(THIS_FILTER, Len(THIS_FILTER) - 5)
                Return THIS_FILTER
            End Get
        End Property
        Private Shared Sub SetTypeCountryDTFilter(ByVal Type As String, ByVal Country As String, ByRef Filter As String)
            If Not Type Is Nothing AndAlso Type.Length > 0 Then Filter = String.Concat(Filter, "(TYPE ='" & Type & "') AND ")
            If Not Country Is Nothing AndAlso Country.Length > 0 Then Filter = String.Concat(Filter, "(COUNTRY='" & Country & "') AND ")
        End Sub
    End Class
End Class