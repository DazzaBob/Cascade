Namespace ModelRun.Models.Australia
    Friend Class Greyhounds
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
                    DR(0).Item("MODEL_EXPLORER_ID") = 4
                    Dim DT As Data.DataTable = StatisticsL10DT.Clone
                    DT.ImportRow(DR(0))
                    Return DT
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
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("LENGTH_RANK >= 80", "LENGTH_RANK DESC")
                If DR.Length > 0 Then
                    For X As Integer = 0 To DR.Length - 1
                        If DR(X).Item("LENGTH_RANK") = 100 Then Continue For
                        If DR(X).Item("LENGTH_RUNS") < 3 Then Continue For


                        DR(X).Item("MODEL_EXPLORER_ID") = 5
                        If DR(X).Item("SCRATCHED") = 0 Then RunnersAL.Add(DR(X).Item("NUMBER"))
                    Next X
                End If

                DR = StatisticsL3DT.Select("LENGTH_RANK >= 80", "LENGTH_RANK DESC")

                If DR.Length > 0 Then
                    For X As Integer = 0 To DR.Length - 1
                        If DR(X).Item("LENGTH_RANK") = 100 Then Continue For
                        If DR(X).Item("LENGTH_RUNS") < 3 Then Continue For
                        If DR(X).Item("SCRATCHED") = 0 Then
                            DR(X).Item("MODEL_EXPLORER_ID") = 5
                            If Not RunnersAL.Contains(DR(X).Item("NUMBER")) Then
                                RunnersAL.Add(DR(X).Item("NUMBER"))
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

            Dim RunnersAL As New ArrayList
            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("(SCRATCHED=0) AND (LENGTH_RANK <> 100) AND (LENGTH_RUNS >1)", "LENGTH_DISTANCEBEHIND ASC")
                For X As Integer = 0 To 4
                    DR(X).Item("MODEL_EXPLORER_ID") = 6
                    RunnersAL.Add(DR(X).Item("NUMBER"))
                Next

                DR = StatisticsL3DT.Select("(SCRATCHED=0) AND (LENGTH_RANK <> 100) AND (LENGTH_RUNS >1)", "LENGTH_DISTANCEBEHIND ASC")
                For X As Integer = 0 To 4
                    If Not RunnersAL.Contains(DR(X).Item("NUMBER")) Then
                        RunnersAL.Add(DR(X).Item("NUMBER"))
                    End If
                Next X

                DR = StatisticsL3DT.Select("", "BARRIER DESC")
                Dim NewAL As New ArrayList

                If RunnersAL.Count > 0 Then
                    For Y = 0 To 3
                        For Each Number As String In RunnersAL
                            If DR(Y).Item("NUMBER") = Number Then
                                NewAL.Add(DR(Y).Item("NUMBER"))
                            End If
                        Next Number
                    Next Y
                End If

                If NewAL.Count > 0 Then
                    For Each Number As String In NewAL
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
        Protected Friend Shared Function LastFinished(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If Not ModelRun.Rules.Main.IsEnoughRunners(StatisticsL10DT) Then Return New Data.DataTable

            Dim RunnersAL As New ArrayList
            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("(SCRATCHED=0) AND (LENGTH_RANK <> 100) AND (LENGTH_RUNS >1) AND (FINISHPOSITION > 1 AND FINISHPOSITION < 4)", "")
                If DR.Length > 3 Then Return New Data.DataTable

                For X As Integer = 0 To DR.Length - 1
                    DR(X).Item("MODEL_EXPLORER_ID") = 6
                    RunnersAL.Add(DR(X).Item("NUMBER"))
                Next

                DR = StatisticsL3DT.Select("(SCRATCHED=0) AND (LENGTH_RANK <> 100) AND (LENGTH_RUNS >1) AND (FINISHPOSITION > 1 AND FINISHPOSITION < 4)")
                If DR.Length > 0 Then
                    For X As Integer = 0 To DR.Length - 1
                        If Not RunnersAL.Contains(DR(X).Item("NUMBER")) Then
                            RunnersAL.Add(DR(X).Item("NUMBER"))
                        End If
                    Next

                End If

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
        Protected Friend Shared Function RankMoreThan20(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If Not ModelRun.Rules.Main.IsEnoughRunners(StatisticsL10DT) Then Return New Data.DataTable

            Dim RunnersAL As New ArrayList
            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("(SCRATCHED=0) AND (LENGTH_RANK <> 100) AND (LENGTH_RUNS >1)", "LENGTH_RANK DESC")
                If DR(0).Item("LENGTH_RANK") - DR(1).Item("LENGTH_RANK") < 20 Then Return New Data.DataTable

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
        Protected Friend Shared Function Only1Two(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If Not ModelRun.Rules.Main.IsEnoughRunners(StatisticsL10DT) Then Return New Data.DataTable

            Dim RunnersAL As New ArrayList
            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("FINISHPOSITION=1")
                If DR.Length > 0 Then Return New Data.DataTable

                DR = StatisticsL10DT.Select("FINISHPOSITION=2")
                If DR.Length = 0 OrElse DR.Length > 1 Then Return New Data.DataTable
                If DR(0).Item("LENGTH_RANK") > 60 AndAlso DR(0).Item("LENGTH_RANK") <> 100 Then
                    DR(0).Item("MODEL_EXPLORER_ID") = 10
                    RunnersAL.Add(DR(0).Item("NUMBER").ToString)
                End If

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
        Protected Friend Shared Function BestSequence(StatisticsL10DT As Data.DataTable, StatisticsL3DT As Data.DataTable) As Data.DataTable
            If StatisticsL10DT.Select("").Length - StatisticsL10DT.Select("SCRATCHED=1").Length <= 7 Then Return New Data.DataTable

            Dim DT As Data.DataTable = StatisticsL3DT.Clone
            Dim RunnersAL As New ArrayList
            Try
                Dim DR() As Data.DataRow = StatisticsL10DT.Select("", "SEQUENCE_RANK DESC")
                If DR(0).Item("FINISHPOSITION") > 4 Then Return New Data.DataTable
                RunnersAL.Add(DR(0).Item("NUMBER"))

                If RunnersAL.Count > 0 Then
                    For Each Runner As String In RunnersAL
                        If Runner = 0 Then Continue For
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
    End Class
End Namespace