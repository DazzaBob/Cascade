' Class is public we need to use it find Countries, Venues and Code for Mappings.
' This class needs to be public so that the UC_SCANXMLFILES can access it.
' XML is Converted to Upper Invariant when its read in, in the ENTRYPOINT Class
Partial Friend Class Schedule
    Private NotInheritable Class XmlLoader : Implements IDisposable
        Private MY_XML As String
        Private ReadOnly MESSAGES As CascadeCommon.Messages
        Private ReadOnly CONNECTION As CascadeCommon.Utils.Connection
        Friend Sub New(ByVal XML As String, Messages As CascadeCommon.Messages, Connection As CascadeCommon.Utils.Connection)
            MY_XML = XML
            Me.MESSAGES = Messages
            Me.CONNECTION = Connection
        End Sub
        Friend Function ListOfMeetingInformation() As List(Of Instance.MeetingInformation)
            '<!ELEMENT meetings (meeting*)>
            '<!ELEMENT meeting (betslip_type?, code?, country?, date, name?, number, nz?, penetrometer?, status?, track_dir?, type?, venue?, races?)>
            If Not MY_XML.Contains("<MEETING>") Then Return New List(Of Instance.MeetingInformation)

            Dim THIS_STOPWATCH As New Stopwatch

            Dim MY_MEETINGS As New List(Of Instance.MeetingInformation)
            MY_XML = Strings.Mid(MY_XML, InStr(MY_XML, "<MEETING>"))
            MY_XML = Strings.Left(MY_XML, InStrRev(MY_XML, "</MEETING>") + 10)
            Dim SplitMeetings() As String = Split(MY_XML, "</MEETING>")

            THIS_STOPWATCH.Reset() : THIS_STOPWATCH.Start()
            For Each Meeting As String In SplitMeetings
                ' Run the stopwatch for each meeting.
                THIS_STOPWATCH.Reset() : THIS_STOPWATCH.Start()
                '
                Meeting = Replace(Meeting, "<MEETING>", "")
                Meeting = Replace(Meeting, "</MEETING>", "")
                If Meeting = "" Then Continue For
                If Meeting.Length = 1 Then Continue For
                '
                Dim MeetingValues As String = Strings.Left(Meeting, InStr(Meeting, "<RACES>") - 1)

                Dim Code As String = Nothing, BetSlipType As String = Nothing, Country As String = Nothing
                Dim NZ As String = Nothing, Status As String = Nothing, Type As String = Nothing
                Call SetCode(MeetingValues, Code) : SetBetSlipType(MeetingValues, BetSlipType) : SetCountry(MeetingValues, Country)
                Call SetNZ(MeetingValues, NZ) : SetStatus(MeetingValues, Status) : SetType(MeetingValues, Type)
                If Code = "PSXG" OrElse Code = "PSXR" OrElse Code = "PSXT" OrElse Code = "EXTG" Then Continue For
                If BetSlipType <> "STD" Then Continue For
                If Country <> "NZL" Then
                    If Country <> "AUS" Then
                        Continue For
                    End If
                End If
                If Status.Contains("AB") Then Continue For

                    Dim OADate As String = Nothing, Name As String = Nothing, Number As String = Nothing
                Dim Penetrometer As String = Nothing, TrackDir As String = Nothing, Venue As String = Nothing
                Call SetOADate(MeetingValues, OADate) : SetName(MeetingValues, Name) : SetNumber(MeetingValues, Number)
                Call SetPenetrometer(MeetingValues, Penetrometer) : SetTrackDir(MeetingValues, TrackDir)
                Call SetVenue(MeetingValues, Venue)

                Dim ListOfRaceInfo As New List(Of Instance.MeetingInformation.RaceInformation)
                Meeting = Strings.Mid(Meeting, Meeting.IndexOf("<RACES>", StringComparison.Ordinal))
                Dim NewRaceList As New RaceList(Type, Meeting, Venue)
                ListOfRaceInfo = NewRaceList.GetListOfRaceInformation
                NewRaceList = Nothing
                If ListOfRaceInfo.Count = 0 Then Continue For

                MY_MEETINGS.Add(New Instance.MeetingInformation(OADate, Number, BetSlipType, Code, Country, Name, NZ, Penetrometer, Status, TrackDir, Type, Venue, ListOfRaceInfo))

                THIS_STOPWATCH.Stop()
                Call MESSAGES.LogMessages("Loaded meeting: M" & Number & " - " & Name & " to memory in: " & Utils.ElapsedTime(THIS_STOPWATCH) & ".", Utils.BroadcastTypes.Log)
            Next Meeting
            '
            THIS_STOPWATCH = Nothing
            Erase SplitMeetings
            '
            Call UpdateVenue(MY_MEETINGS)
            '
            Return MY_MEETINGS
        End Function
        Private Shared Sub SetCode(ByVal Xml As String, ByRef Code As String)
            If Xml.Contains("<CODE>") Then
                ' PSXG, PSXR, PSXT are codes for PICK 6, which is already a race in a meeting,
                ' So dont load it.
                Xml = Strings.Mid(Xml, InStr(Xml, "<CODE>") + Len("<CODE>"))
                Dim sCode As String = Strings.Left(Xml, InStr(Xml, "<") - 1)
                Code = Replace(sCode, "'", "")
            End If
        End Sub
        Private Shared Sub SetBetSlipType(ByVal Xml As String, ByRef BetSlipType As String)
            If Xml.Contains("<BETSLIP_TYPE>") Then
                Xml = Strings.Mid(Xml, InStr(Xml, "<BETSLIP_TYPE>") + Len("<BETSLIP_TYPE>"))
                BetSlipType = Strings.Left(Xml, InStr(Xml, "<") - 1)
            End If
        End Sub
        Private Shared Sub SetCountry(ByVal Xml As String, ByRef Country As String)
            If Xml.Contains("<COUNTRY>") Then
                Xml = Strings.Mid(Xml, InStr(Xml, "<COUNTRY>") + Len("<COUNTRY>"))
                Dim sMeeting As String = Strings.Left(Xml, InStr(Xml, "<") - 1)
                Country = Replace(sMeeting, "'", "")
            End If
        End Sub
        Private Shared Sub SetOADate(ByVal Xml As String, ByRef OADate As String)
            If Xml.Contains("<DATE>") Then
                Xml = Strings.Mid(Xml, InStr(Xml, "<DATE>") + Len("<DATE>"))
                Dim dDate As Date = Strings.Left(Xml, InStr(Xml, "<") - 1)
                OADate = CStr(dDate.ToOADate)
            End If
        End Sub
        Private Shared Sub SetName(ByVal Xml As String, ByRef Name As String)
            If Xml.Contains("<NAME>") Then
                Xml = Strings.Mid(Xml, InStr(Xml, "<NAME>") + Len("<NAME>"))
                Name = Strings.Left(Xml, InStr(Xml, "<") - 1)
                Name = Utils.ReplaceHTML(Name)
                Name = Replace(Name, "'", "")
            End If
        End Sub
        Private Shared Sub SetNumber(ByVal Xml As String, ByRef Number As String)
            If Xml.Contains("<NUMBER>") Then
                Xml = Strings.Mid(Xml, InStr(Xml, "<NUMBER>") + Len("<NUMBER>"))
                Number = Strings.Left(Xml, InStr(Xml, "<") - 1)
            End If
        End Sub
        Private Shared Sub SetNZ(ByVal Xml As String, ByRef NZ As String)
            If Xml.Contains("<NZ>") Then
                Xml = Strings.Mid(Xml, InStr(Xml, "<NZ>") + Len("<NZ>"))
                NZ = Trim(Strings.Left(Xml, InStr(Xml, "<") - 1))
            End If
        End Sub
        Private Shared Sub SetPenetrometer(ByVal Xml As String, ByRef Penetrometer As String)
            If Xml.Contains("<PENETROMETER>") Then
                Xml = Strings.Mid(Xml, InStr(Xml, "<PENETROMETER>") + Len("<PENETROMETER>"))
                Penetrometer = Strings.Left(Xml, InStr(Xml, "<") - 1)
            End If
        End Sub
        Private Shared Sub SetStatus(ByVal Xml As String, ByRef Status As String)
            If Xml.Contains("<STATUS>") Then
                Xml = Strings.Mid(Xml, InStr(Xml, "<STATUS>") + Len("<STATUS>"))
                Status = Strings.Left(Xml, InStr(Xml, "<") - 1)
            End If
        End Sub
        Private Shared Sub SetTrackDir(ByVal Xml As String, ByRef TrackDir As String)
            If Xml.Contains("<TRACK_DIR>") Then
                Xml = Strings.Mid(Xml, InStr(Xml, "<TRACK_DIR>") + Len("<TRACK_DIR>"))
                TrackDir = Strings.Left(Xml, InStr(Xml, "<") - 1)
            End If
        End Sub
        Private Shared Sub SetType(ByVal Xml As String, ByRef Type As String)
            If Xml.Contains("<TYPE>") Then
                Xml = Strings.Mid(Xml, InStr(Xml, "<TYPE>") + Len("<TYPE>"))
                Type = Strings.Left(Xml, InStr(Xml, "<") - 1)
            End If
        End Sub
        Private Shared Sub SetVenue(ByVal Xml As String, ByRef Venue As String)
            If Xml.Contains("<VENUE>") Then
                Xml = Strings.Mid(Xml, InStr(Xml, "<VENUE>") + Len("<VENUE>"))
                Venue = Strings.Left(Xml, InStr(Xml, "<") - 1)
                Venue = Replace(Venue, "&AMP;", "&")
                Venue = Replace(Venue, "'", "")
            End If
        End Sub
        Private Sub UpdateVenue(ByRef MeetingInformation As List(Of Instance.MeetingInformation))
            For Each MEETING As Instance.MeetingInformation In MeetingInformation
                If MEETING Is Nothing Then Dim unused = MeetingInformation.Remove(MEETING)
            Next MEETING

            Using DT As Data.DataTable = GetDataTable()
                If DT.Rows.Count > 0 Then
                    For Each MEETING As Instance.MeetingInformation In MeetingInformation
                        For Each RACE As Instance.MeetingInformation.RaceInformation In MEETING.ListOfRaceInformation
                            Dim THIS_VENUE As String = RACE.VENUE
                            Dim DR() As Data.DataRow = DT.Select("VENUE='" & RACE.VENUE & "' AND MEETING_XML_TYPE='" & MEETING.TYPE & "'")
                            If DR.Length > 0 Then
                                RACE.VENUE = DR(0).Item("MAPTOVENUE").ToString
                            End If
                        Next RACE
                    Next MEETING
                End If
            End Using
        End Sub
        Private ReadOnly Property GetDataTable() As Data.DataTable
            Get
                Dim CMDTEXT As String = "SELECT * FROM MAPPINGS_VENUE"
                Return CONNECTION.GetDataTable(CMDTEXT)
            End Get
        End Property
#Region "        IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
        Protected Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects).
                End If
                If MY_XML IsNot Nothing Then MY_XML = Nothing
            End If
            disposedValue = True
        End Sub
        ' This code added by Visual Basic to correctly implement the disposable pattern.
        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region
    End Class
End Class