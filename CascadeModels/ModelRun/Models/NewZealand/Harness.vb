Namespace ModelRun.Models.NewZealand
    Friend Class Harness
        Private Sub New()
            ' Just so the compiler doesnt create a default constructor
        End Sub
        Protected Friend Shared Function NewRunners(StatisticsL10DT As Data.DataTable) As Data.DataTable
            If Not ModelRun.Rules.Main.IsEnoughRunners(StatisticsL10DT) Then Return New Data.DataTable
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("LENGTH_RUNS IS NULL")
                If DR.Length = 1 Then
                    Dim DR1() As Data.DataRow = StatisticsL10DT.Select("LENGTH_RUNS >0")
                    ' This is a new runner, no data exists, so lets make some up.
                    DR(0).Item("MEETING_XML_OADATE") = DR1(0).Item("MEETING_XML_OADATE")
                    DR(0).Item("MEETING_XML_NUMBER") = DR1(0).Item("MEETING_XML_NUMBER")
                    DR(0).Item("RACE_XML_NUMBER") = DR1(0).Item("RACE_XML_NUMBER")
                    DR(0).Item("TRACK_TYPE") = DR1(0).Item("TRACK_TYPE")
                    DR(0).Item("NUMBER") = DR1(0).Item("BARRIER")
                    DR(0).Item("MODEL_EXPLORER_ID") = 8
                    If DR(0).Item("BARRIER") = 1 OrElse DR(0).Item("BARRIER") = 3 Or DR(0).Item("BARRIER").ToString.Contains("2"c) Then
                        Dim DT As Data.DataTable = StatisticsL10DT.Clone
                        DT.ImportRow(DR(0))
                        Return DT
                    End If
                End If
            Catch ex As Exception
                Call Messages.LogMessages(ex.ToString, BroadcastTypes.Error)
            End Try

            Return New Data.DataTable
        End Function
        Protected Friend Shared Function StatisticsLXGreaterThan80(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If Not ModelRun.Rules.Main.IsEnoughRunners(StatisticsL10DT) Then Return New Data.DataTable

            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Dim RunnersAL As New ArrayList
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("LENGTH_RANK > 80", "LENGTH_RANK DESC")
                If DR.Length > 0 Then
                    For X As Integer = 0 To DR.Length - 1
                        DR(X).Item("MODEL_EXPLORER_ID") = 9
                        If DR(X).Item("SCRATCHED") = 0 Then
                            If DR(X).Item("BARRIER") = 1 OrElse DR(X).Item("BARRIER") = 3 Or DR(X).Item("BARRIER").ToString.Contains("2"c) Then
                                RunnersAL.Add(DR(X).Item("NUMBER"))
                            End If
                        End If
                    Next X
                End If

                DR = StatisticsL3DT.Select("LENGTH_RANK > 80", "LENGTH_RANK DESC")
                If DR.Length > 0 Then
                    For X As Integer = 0 To DR.Length - 1
                        If DR(X).Item("SCRATCHED") = 0 Then
                            DR(X).Item("MODEL_EXPLORER_ID") = 9
                            If Not RunnersAL.Contains(DR(X).Item("NUMBER")) Then
                                If DR(X).Item("BARRIER") = 1 OrElse DR(X).Item("BARRIER") = 3 Or DR(X).Item("BARRIER").ToString.Contains("2"c) Then
                                    RunnersAL.Add(DR(X).Item("NUMBER"))
                                End If
                            End If
                        End If
                    Next X
                End If

                If RunnersAL.Count > 0 Then
                    For Each Runner As String In RunnersAL
                        DR = StatisticsL3DT.Select("NUMBER=" & Runner.ToString)
                        DT.ImportRow(DR(0))
                    Next Runner
                    Return DT
                End If

            Catch ex As Exception
                Call Messages.LogMessages(ex.ToString, BroadcastTypes.Error)
            End Try

            Return New Data.DataTable
        End Function
        Protected Friend Shared Function TopDistanceBehind(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If Not ModelRun.Rules.Main.IsEnoughRunners(StatisticsL10DT) Then Return New Data.DataTable

            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Try
                Dim Y As Integer = 0
                Dim DR() As Data.DataRow = StatisticsL3DT.Select("", "LENGTH_DISTANCEBEHIND ASC")
                If Information.IsDBNull(DR(0).Item("LENGTH_RUNS")) Then Y = 1
                If DR(Y).Item("SCRATCHED") = 1 Then Y += 1
                For X As Integer = Y To 1
                    If DR(Y).Item("SCRATCHED") = 0 Then
                        If DR(X).Item("FINISHPOSITION") <= 4 Then
                            DR(X).Item("MODEL_EXPLORER_ID") = 7
                            If DR(X).Item("BARRIER") = 1 OrElse DR(X).Item("BARRIER") = 3 Or DR(X).Item("BARRIER").ToString.Contains("2"c) Then
                                DT.ImportRow(DR(X))
                            End If
                        End If
                    End If
                Next
                If DT.Rows.Count > 0 Then
                    Return DT
                End If
            Catch ex As Exception
                Call Messages.LogMessages(ex.ToString, BroadcastTypes.Error)
            End Try

            Return New Data.DataTable
        End Function
        Protected Friend Shared Function RankMoreThan20(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If Not ModelRun.Rules.Main.IsEnoughRunners(StatisticsL10DT) Then Return New Data.DataTable

            Dim RunnersAL As New ArrayList
            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("(SCRATCHED=0) AND (LENGTH_RANK <> 100) AND (LENGTH_RUNS >1)", "LENGTH_RANK DESC")
                If DR(0).Item("LENGTH_RANK") - DR(1).Item("LENGTH_RANK") < 20 Then Return New Data.DataTable
                DR(0).Item("MODEL_EXPLORER_ID") = 11
                RunnersAL.Add(DR(0).Item("NUMBER").ToString)

                If RunnersAL.Count > 0 Then
                    For Each Number As String In RunnersAL
                        DT.ImportRow(StatisticsL3DT.Select("NUMBER=" & Number)(0))
                    Next Number
                End If

                If DT.Rows.Count > 0 Then
                    Return DT
                End If
            Catch ex As Exception
                Call Messages.LogMessages(ex.ToString, BroadcastTypes.Error)
            End Try

            Return New Data.DataTable
        End Function
    End Class
End Namespace