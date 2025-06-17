Namespace Processing
    Partial Class Schedule
        Partial Class InsertUpdateDatabase
            Partial Class Race
                Partial Class Entry
                    Private NotInheritable Class Base : Implements IDisposable
                        Private MeetingInformation As Instance.MeetingInformation
                        Private RaceInformation As Instance.MeetingInformation.RaceInformation
                        Private EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation
                        Private RunnerRaceList As Data.DataTable
                        Friend Sub New(ByVal MeetingInformation As Instance.MeetingInformation, ByVal RaceInformation As Instance.MeetingInformation.RaceInformation, ByVal EntryInformation As Instance.MeetingInformation.RaceInformation.EntryInformation, ByVal RunnerRaceList As Data.DataTable)
                            Me.MeetingInformation = MeetingInformation
                            Me.RaceInformation = RaceInformation
                            Me.EntryInformation = EntryInformation
                            Me.RunnerRaceList = RunnerRaceList
                        End Sub
                        Friend Function GetCommandText() As String
                            Dim CMDTEXT As String = Nothing
                            '
                            For Each Section As String In New String() {"DISTANCE", "DISTANCE_THEO", "GROUP", "GROUP_THEO", "OVERALL", "OVERALL_THEO"}
                                Dim INSERT As String = "INSERT INTO ENTRY_INFO_" & Section & " ([MEETING_INFO_OADATE], [MEETING_INFO_NUMBER], [RACE_INFO_NUMBER], [NUMBER]"
                                Dim VALUES As String = "VALUES (" & Me.MeetingInformation.OADATE & ", " & Me.MeetingInformation.NUMBER & ", " & Me.RaceInformation.NUMBER & ", " & Me.EntryInformation.NUMBER
                                Call GetBaseValuesForInsert(INSERT, VALUES, Section)
                                INSERT += ") " : VALUES += ") " & vbCrLf
                                '
                                CMDTEXT += INSERT & VALUES
                            Next Section
                            '
                            Return CMDTEXT
                        End Function
                        Private Sub GetBaseValuesForInsert(ByRef INSERT As String, ByRef VALUES As String, ByVal Section As String)
                            Dim FILTER As String = Schedule.Common.GetSectionFilter(Me.MeetingInformation, Me.RaceInformation, 365, Section)
                            Dim DR() As Data.DataRow = RunnerRaceList.Select(FILTER, "MEETING_INFO_OADATE DESC")
                            If DR.Length = 0 Then Return
                            '
                            Dim THEO As String = Nothing
                            If Section.Contains("THEO") Then THEO = "THEO_"
                            '
                            Dim LAST_RAN As Int32 = 0I, LAST_SPEED As Decimal = 0D, LAST_DISTANCEBEHIND As Decimal = 0D
                            Dim DSLR As Int32 = 0I
                            Dim LAST_PREVIOUS_RAN As Int32 = 0I, LAST_PREVIOUS_SPEED As Decimal = 0D, LAST_PREVIOUS_DISTANCEBEHIND As Decimal = 0D
                            LAST_RAN = CInt(DR(0).Item("RESULT_" & THEO & "FINISH_POSITION"))
                            LAST_SPEED = CDec(DR(0).Item("RESULT_" & THEO & "SPEED"))
                            LAST_DISTANCEBEHIND = CDec(DR(0).Item("RESULT_" & THEO & "DISTANCE_BEHIND"))
                            If DR.Length > 1 Then
                                LAST_PREVIOUS_RAN = CInt(DR(1).Item("RESULT_" & THEO & "FINISH_POSITION"))
                                LAST_PREVIOUS_SPEED = CDec(DR(1).Item("RESULT_" & THEO & "SPEED"))
                                LAST_PREVIOUS_DISTANCEBEHIND = CDec(DR(1).Item("RESULT_" & THEO & "DISTANCE_BEHIND"))
                            End If
                            '
                            DSLR = CInt(Me.MeetingInformation.OADATE) - CInt(DR(0).Item("MEETING_INFO_OADATE"))
                            If DSLR = CInt(Me.MeetingInformation.OADATE) Then DSLR = 0I
                            '
                            INSERT += ", [LAST_RAN]" : VALUES += ", " & CStr(LAST_RAN)
                            INSERT += ", [LAST_SPEED]" : VALUES += ", " & CStr(LAST_SPEED)
                            INSERT += ", [LAST_DISTANCE_BEHIND]" : VALUES += ", " & CStr(LAST_DISTANCEBEHIND)
                            '
                            INSERT += ", [LAST_PREVIOUS_RAN]" : VALUES += ", " & CStr(LAST_PREVIOUS_RAN)
                            INSERT += ", [LAST_PREVIOUS_SPEED]" : VALUES += ", " & CStr(LAST_PREVIOUS_SPEED)
                            INSERT += ", [LAST_PREVIOUS_DISTANCE_BEHIND]" : VALUES += ", " & CStr(LAST_PREVIOUS_DISTANCEBEHIND)
                            '
                            INSERT += ", [LAST_DSLR]" : VALUES += ", " & CStr(DSLR)
                            '
                            Using Extended As New Extended(Me.MeetingInformation, Me.RaceInformation, Me.RunnerRaceList, Section)
                                Call Extended.Begin(INSERT, VALUES)
                            End Using
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
End Namespace
