Namespace Utils
    Public Module Groups
        Private ReadOnly ALLockObject As New Object
        Public Function ArrayList(MeetingType As String, RaceLength As Short) As ArrayList
            SyncLock ALLockObject
                Dim ThisAL As New ArrayList
                Dim Offset As Short = 0S

                Select Case MeetingType
                    Case "GR"
                        Offset = 50
                        Exit Select
                    Case "G"
                        If RaceLength < 1800 Then
                            Offset = 50
                        ElseIf RaceLength >= 1800 AndAlso RaceLength <= 2500 Then
                            Offset = 75
                        Else
                            Offset = 100
                        End If
                        Exit Select
                    Case Else
                        If RaceLength <= 1599 Then
                            Offset = 50
                        Else
                            If RaceLength >= 1600 AndAlso RaceLength <= 2200 Then
                                Offset = 75
                            ElseIf RaceLength >= 2200 AndAlso RaceLength <= 3000 Then
                                Offset = 100
                            Else
                                Offset = 200
                            End If
                        End If
                End Select
                Call ThisAL.Add(RaceLength - Offset)
                Call ThisAL.Add(RaceLength + Offset)

                Return ThisAL
            End SyncLock
        End Function
    End Module
End Namespace
