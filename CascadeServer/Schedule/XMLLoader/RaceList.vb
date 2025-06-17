Partial Friend Class Schedule
    Partial Private Class XmlLoader
        Private NotInheritable Class RaceList
            Private MY_XML As String
            Private ReadOnly MY_VENUE As String
            Private ReadOnly MeetingType As String
            Friend Sub New(MeetingType As String, Xml As String, ByRef Venue As String)
                Me.MeetingType = MeetingType
                MY_XML = Xml
                MY_VENUE = Venue
            End Sub
            Friend Function GetListOfRaceInformation() As List(Of Instance.MeetingInformation.RaceInformation)
                '<!ELEMENT races (race*)>
                '<!ELEMENT race (class?, length?, name, norm_time?, number, option?, overseas_number?, stake?, status?, track?, venue?, weather?, entries?)>
                Dim This_RaceList = New List(Of Instance.MeetingInformation.RaceInformation)
                '
                MY_XML = Replace(MY_XML, "<RACES>", "")
                MY_XML = Replace(MY_XML, "</RACES>", "")
                For Each Race As String In Split(MY_XML, "</RACE>")
                    If Not Race.Contains("<ENTRIES>") Then Continue For
                    '
                    Race = Replace(Race, "<RACE>", "")
                    Race = Replace(Race, "</RACE>", "")
                    '
                    Dim RaceValues As String = Strings.Left(Race, InStr(Race, "<ENTRIES>") - 1)
                    '
                    Dim [Class] As String = Nothing, Length As String = Nothing, Name As String = Nothing, Barriers As String = Nothing
                    Dim NormTime As String = Nothing, Number As String = Nothing, Stake As String = Nothing
                    Dim Status As String = "OK", Track As String = "GOOD", Weather As String = "FINE", Venue As String = Nothing
                    'Dim unused As New List(Of Instance.MeetingInformation.RaceInformation.EntryInformation)
                    Call SetName(Name, RaceValues)
                    If Name.Contains("ABANDON") Then Continue For
                    Call SetStatus(Status, RaceValues)
                    If Status = "AB" Then Continue For
                    '
                    Call SetClass([Class], Name, RaceValues) : SetLength(Length, RaceValues)
                    Call SetNormTime(NormTime, RaceValues) : SetNumber(Number, RaceValues) : SetStake(Stake, RaceValues)
                    Call SetVenue(Venue, RaceValues) : SetTrack(Track, RaceValues) : SetWeather(Weather, RaceValues)
                    If Venue.ToUpper.Contains("QUADDIE") Then Continue For
                    '
                    Race = Strings.Mid(Race, Race.IndexOf("<ENTRIES>"))
                    Dim NewEntryList As New EntryList(Race, MeetingType)
                    Dim ListOfEntryInfo As List(Of Instance.MeetingInformation.RaceInformation.EntryInformation) = NewEntryList.GetListOfEntryInformation
                    For Each EntryInfo As Instance.MeetingInformation.RaceInformation.EntryInformation In ListOfEntryInfo
                        Barriers = String.Concat(Barriers, EntryInfo.BARRIER & ", ")
                    Next
                    Barriers = Strings.Left(Barriers, Barriers.Length - 2)
                    '
                    This_RaceList.Add(New Instance.MeetingInformation.RaceInformation([Class], Length, Name, NormTime, Number, Stake, Status, Track, Venue, Weather, Barriers, ListOfEntryInfo))
                Next
                '
                Return This_RaceList
            End Function
            Private Shared Sub SetClass(ByRef [Class] As String, ByVal Name As String, ByVal Xml As String)
                If Xml.Contains("<CLASS>") Then
                    Xml = Strings.Mid(Xml, InStr(Xml, "<CLASS>") + Len("<CLASS>"))
                    [Class] = Strings.Left(Xml, InStr(Xml, "<") - 1)
                    [Class] = Replace([Class], "'", "")
                End If
                '
                If [Class] Is Nothing Then
                    Dim NAMETOCLASS As String = Name
                    If NAMETOCLASS.Contains(CChar(" ")) Then
                        NAMETOCLASS = Strings.Mid(NAMETOCLASS, InStrRev(NAMETOCLASS, " ") + 1)
                        [Class] = NAMETOCLASS
                    Else
                        [Class] = "999"
                    End If
                End If
                '
                [Class] = Replace([Class], "C", "")
                [Class] = Replace([Class], "F", "")
                [Class] = Replace([Class], "Q", "")
                [Class] = Replace([Class], "D", "")
                [Class] = Replace([Class], "+", "")
                [Class] = Replace([Class], "R/A", "999")
                If [Class].Contains(CChar("/")) Then [Class] = Replace([Class], "/", ".")
                If [Class].Contains("NZRS") Then [Class] = Replace([Class], "NZRS", "0")
                If [Class].Contains("RES") Then [Class] = Replace([Class], "RES", "0")
                If [Class].Contains("SPE") Then [Class] = Replace([Class], "SPE", "0")
                If [Class].Contains("SPEA") Then [Class] = Replace([Class], "SPEA", "0")
                If [Class].Contains("INV") Then [Class] = Replace([Class], "INV", "0")
                [Class] = Replace([Class], "A", "")
                If Not IsNumeric([Class]) Then [Class] = "999"
            End Sub
            Private Shared Sub SetLength(ByRef Length As String, ByVal Xml As String)
                If Xml.Contains("<LENGTH>") Then
                    Xml = Strings.Mid(Xml, InStr(Xml, "<LENGTH>") + Len("<LENGTH>"))
                    Length = Strings.Left(Xml, InStr(Xml, "<") - 1)
                End If
            End Sub
            Private Shared Sub SetName(ByRef Name As String, ByVal Xml As String)
                If Xml.Contains("<NAME>") Then
                    Xml = Strings.Mid(Xml, InStr(Xml, "<NAME>") + Len("<NAME>"))
                    Name = Strings.Left(Xml, InStr(Xml, "<") - 1)
                    Name = Utils.ReplaceHTML(Name)
                    Name = Replace(Name, "'", "")
                End If
            End Sub
            Private Shared Sub SetNormTime(ByRef NormTime As String, ByVal Xml As String)
                If Xml.Contains("<NORM_TIME>") Then
                    Xml = Strings.Mid(Xml, InStr(Xml, "<NORM_TIME>") + Len("<NORM_TIME>"))
                    Dim sDate As String = Strings.Left(Xml, InStr(Xml, "<") - 1)
                    NormTime = CStr(CDate("#" & sDate & "#").ToOADate)
                End If
            End Sub
            Private Shared Sub SetNumber(ByRef Number As String, ByVal Xml As String)
                If Xml.Contains("<NUMBER>") Then
                    Xml = Strings.Mid(Xml, InStr(Xml, "<NUMBER>") + Len("<NUMBER>"))
                    Number = Strings.Left(Xml, InStr(Xml, "<") - 1)
                End If
            End Sub
            Private Shared Sub SetStake(ByRef Stake As String, ByVal Xml As String)
                If Xml.Contains("<STAKE>") Then
                    Xml = Strings.Mid(Xml, InStr(Xml, "<STAKE>") + Len("<STAKE>"))
                    Stake = Replace(Strings.Left(Xml, InStr(Xml, "<") - 1), "$", "")
                    Stake = Replace(Stake, ",", "")
                End If
                If Stake Is Nothing Then
                    Stake = "9999"
                End If
            End Sub
            Private Shared Sub SetStatus(ByRef Status As String, ByVal Xml As String)
                If Xml.Contains("<STATUS>") Then
                    Xml = Strings.Mid(Xml, InStr(Xml, "<STATUS>") + Len("<STATUS>"))
                    Status = Strings.Left(Xml, InStr(Xml, "<") - 1)
                End If
            End Sub
            Private Shared Sub SetTrack(ByRef Track As String, ByVal Xml As String)
                If Xml.Contains("<TRACK>") Then
                    Xml = Strings.Mid(Xml, InStr(Xml, "<TRACK>") + Len("<TRACK>"))
                    Track = Strings.Left(Xml, InStr(Xml, "<") - 1)
                End If
            End Sub
            Private Shared Sub SetWeather(ByRef Weather As String, ByVal Xml As String)
                If Xml.Contains("<WEATHER>") Then
                    Xml = Strings.Mid(Xml, InStr(Xml, "<WEATHER>") + Len("<WEATHER>"))
                    Weather = Strings.Left(Xml, InStr(Xml, "<") - 1)
                End If
            End Sub
            Private Sub SetVenue(ByRef Venue As String, ByVal Xml As String)
                If Xml.Contains("<VENUE>") Then
                    Xml = Strings.Mid(Xml, InStr(Xml, "<VENUE>") + Len("<VENUE>"))
                    Venue = Strings.Left(Xml, InStr(Xml, "<") - 1)
                    Venue = Replace(Venue, "&AMP;", "&")
                    Venue = Replace(Venue, "'", "")
                End If
                If Venue Is Nothing Then Venue = MY_VENUE
                Call RemapVenues(Venue)
            End Sub
            Private Shared Sub RemapVenues(ByRef Venue As String)
                Dim CommandText As String = "SELECT MAPTOVENUE FROM MAPPINGS_VENUE WHERE (VENUE = N'" & Venue & "')"

                Dim NewVenue As String = Nothing
                Using Connection As New Utils.Connection(My.Settings.ConnectionString)
                    NewVenue = Connection.ExecuteScalar(CommandText)
                End Using
                If NewVenue IsNot Nothing Then Venue = NewVenue
            End Sub
        End Class
    End Class
End Class