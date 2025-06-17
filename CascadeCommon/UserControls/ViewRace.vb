Imports System.Drawing

Namespace UserControls
    Public Class ViewRace
        Private This_CountryID As String
        Private This_OADate As String
        Private This_MeetingNumber As String
        Private This_MeetingType As String
        Private This_RaceNumber As String
        Private This_NodeFullPath As String
        Private This_Connection As Utils.Connection
        Private Sub New()
            InitializeComponent()
        End Sub
        Public Sub New(CountryID As String, OADate As String, MeetingNumber As String, MeetingType As String, RaceNumber As String, NodeFullPath As String, Connection As Utils.Connection)
            Me.New()

            This_CountryID = CountryID
            This_OADate = OADate
            This_MeetingNumber = MeetingNumber
            This_MeetingType = MeetingType
            This_RaceNumber = RaceNumber
            This_NodeFullPath = NodeFullPath
            This_Connection = Connection
        End Sub
        Private Sub ViewRace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            Me.GroupBoxLast10Races.Text = "Last 10 Races: " & This_NodeFullPath
            Me.GroupBoxVenueLast10.Text = Me.GroupBoxLast10Races.Text

            Me.GroupBoxLast3Races.Text = "Last 3 Races: " & This_NodeFullPath
            Me.GroupBoxVenueLast3.Text = Me.GroupBoxVenueLast3.Text

            If This_MeetingType <> "GR" Then
                Me.DGVL10BarrierRank.Visible = False
                Me.DGVTBCL10VenueBarrier.Visible = False

                Me.DGVL3BarrierRank.Visible = False
                Me.DGVTBCL3VenueBarrierRank.Visible = False
            Else
                Me.DGVL10BarrierRank.Visible = True
                Me.DGVTBCL10VenueBarrier.Visible = True

                Me.DGVL3BarrierRank.Visible = True
                Me.DGVTBCL3VenueBarrierRank.Visible = True
            End If

            Call PopulateL3()
            Call PopulateL10() : Call VenuePopulateL10()
            Call PopulateResults()
        End Sub
        Private Sub PopulateL10()
            For Each Row As Data.DataRow In DataTables.StatsLastX.Last10DataTable(This_OADate, This_MeetingNumber, This_RaceNumber, This_Connection).Select("", "NUMBER ASC")
                Using DGVRow As New DataGridViewRow
                    Dim Divider As Double = 0#, AverageTrend As Double = 0#
                    DGVRow.CreateCells(Me.DataGridViewLast10)
                    DGVRow.Cells(Me.DGVL10Number.Index).Value = Convert.ToInt32(Row.Item("NUMBER"))
                    DGVRow.Cells(Me.DGVL10Barrier.Index).Value = Convert.ToInt32(Row.Item("BARRIER"))
                    If This_MeetingType = "GR" Then
                        If IsDBNull(Row.Item("BARRIER_RANK")) Then
                            DGVRow.Cells(Me.DGVL10BarrierRank.Index).Value = 0#
                        Else
                            DGVRow.Cells(Me.DGVL10BarrierRank.Index).Value = CDbl(Row.Item("BARRIER_RANK"))
                        End If
                    End If
                    DGVRow.Cells(Me.DGVL10Name.Index).Value = Row.Item("NAME").ToString

                    If Not Information.IsDBNull(Row.Item("LASTRAN")) Then
                        DGVRow.Cells(Me.DGVL10LASTRANOADATE.Index).Value = Date.FromOADate(Row.Item("LASTRAN"))
                    End If
                    If Not Information.IsDBNull(Row.Item("FINISHPOSITION")) Then
                        DGVRow.Cells(Me.DGVL10LASTRANFINISHPOSITION.Index).Value = CInt(Row.Item("FINISHPOSITION"))
                    End If
                    If Not Information.IsDBNull(Row.Item("DISTANCE")) Then
                        DGVRow.Cells(Me.DGVL10LASTRANDISTANCE.Index).Value = CInt(Row.Item("DISTANCE"))
                    End If

                    If Not Information.IsDBNull(Row.Item("SEQUENCE")) Then
                        DGVRow.Cells(Me.DGVL10SEQUENCE.Index).Value = Row.Item("SEQUENCE").ToString
                    End If
                    If Not Information.IsDBNull(Row.Item("SEQUENCE_RANK")) Then
                        DGVRow.Cells(Me.DGVL10SEQUENCERANK.Index).Value = CDbl(Row.Item("SEQUENCE_RANK"))
                    End If
                    If Not Information.IsDBNull(Row.Item("SEQUENCE_RUNS")) Then
                        DGVRow.Cells(Me.DGVL10SEQUENCERUNS.Index).Value = CInt(Row.Item("SEQUENCE_RUNS"))
                    End If

                    If Not Information.IsDBNull(Row.Item("GROUP")) Then
                        DGVRow.Cells(Me.DGVL10Group.Index).Value = Row.Item("GROUP").ToString
                    End If
                    If Not Information.IsDBNull(Row.Item("GROUP_RANK")) Then
                        DGVRow.Cells(Me.DGVL10GROUPRANK.Index).Value = CDbl(Row.Item("GROUP_RANK"))
                    End If
                    If Not Information.IsDBNull(Row.Item("GROUP_RUNS")) Then
                        DGVRow.Cells(Me.DGVL10GroupRuns.Index).Value = CInt(Row.Item("GROUP_RUNS"))
                    End If

                    If Not Information.IsDBNull(Row.Item("LENGTH")) Then
                        DGVRow.Cells(Me.DGVL10LENGTH.Index).Value = Row.Item("LENGTH").ToString
                    End If
                    If Not Information.IsDBNull(Row.Item("LENGTH_DISTANCEBEHIND")) Then
                        DGVRow.Cells(Me.DGVL10LENGTHDISTANCEBEHIND.Index).Value = CDbl(FormatNumber(Row.Item("LENGTH_DISTANCEBEHIND"), 2))
                    End If
                    If Not Information.IsDBNull(Row.Item("LENGTH_RANK")) Then
                        DGVRow.Cells(Me.DGVL10LENGTHRANK.Index).Value = CDbl(Row.Item("LENGTH_RANK"))
                    End If
                    If Not Information.IsDBNull(Row.Item("LENGTH_RUNS")) Then
                        DGVRow.Cells(Me.DGVL10LENGTHRUNS.Index).Value = CInt(Row.Item("LENGTH_RUNS"))
                    End If

                    If Convert.ToBoolean(Row.Item("SCRATCHED")) Then Call StratchDGVRow(DGVRow, Me.DataGridViewLast10)

                    Me.DataGridViewLast10.Rows.Add(DGVRow)
                End Using
            Next Row
            Call SelectModels(This_OADate, This_MeetingNumber, This_RaceNumber)
        End Sub
        Private Sub VenuePopulateL10()
            For Each Row As Data.DataRow In DataTables.StatsLastX.VenueLast10DataTable(This_OADate, This_MeetingNumber, This_RaceNumber, This_Connection).Select("", "NUMBER ASC")
                Using DGVRow As New DataGridViewRow
                    Dim Divider As Double = 0#, AverageTrend As Double = 0#
                    DGVRow.CreateCells(Me.DataGridViewVenueLast10)
                    DGVRow.Cells(Me.DGVTBCL10VenueNumber.Index).Value = Convert.ToInt32(Row.Item("NUMBER"))
                    DGVRow.Cells(Me.DGVTBCL10VenueBarrier.Index).Value = Convert.ToInt32(Row.Item("BARRIER"))
                    If This_MeetingType = "GR" Then
                        If IsDBNull(Row.Item("BARRIER_RANK")) Then
                            DGVRow.Cells(Me.DGVTBCL10VenueBarrierRank.Index).Value = 0#
                        Else
                            DGVRow.Cells(Me.DGVTBCL10VenueBarrierRank.Index).Value = CDbl(Row.Item("BARRIER_RANK"))
                        End If
                    End If
                    DGVRow.Cells(Me.DGVTBCL10VenueName.Index).Value = Row.Item("NAME").ToString

                    If Not Information.IsDBNull(Row.Item("LASTRAN")) Then
                        DGVRow.Cells(Me.DGVTBCL10VenueLastRanDate.Index).Value = Date.FromOADate(Row.Item("LASTRAN"))
                    End If
                    If Not Information.IsDBNull(Row.Item("FINISHPOSITION")) Then
                        DGVRow.Cells(Me.DGVTBCL10VenueLastRanFinishPosition.Index).Value = CInt(Row.Item("FINISHPOSITION"))
                    End If
                    If Not Information.IsDBNull(Row.Item("DISTANCE")) Then
                        DGVRow.Cells(Me.DGVTBCL10VenueDistance.Index).Value = CInt(Row.Item("DISTANCE"))
                    End If

                    If Not Information.IsDBNull(Row.Item("SEQUENCE")) Then
                        DGVRow.Cells(Me.DGVTBCL10VenueSequence.Index).Value = Row.Item("SEQUENCE").ToString
                    End If
                    If Not Information.IsDBNull(Row.Item("SEQUENCE_RANK")) Then
                        DGVRow.Cells(Me.DGVTBCL10VenueSequenceRank.Index).Value = CDbl(Row.Item("SEQUENCE_RANK"))
                    End If
                    If Not Information.IsDBNull(Row.Item("SEQUENCE_RUNS")) Then
                        DGVRow.Cells(Me.DGVTBCL10VenueSequenceRuns.Index).Value = CInt(Row.Item("SEQUENCE_RUNS"))
                    End If

                    If Not Information.IsDBNull(Row.Item("GROUP")) Then
                        DGVRow.Cells(Me.DGVTBCL10VenueGroup.Index).Value = Row.Item("GROUP").ToString
                    End If
                    If Not Information.IsDBNull(Row.Item("GROUP_RANK")) Then
                        DGVRow.Cells(Me.DGVTBCL10VenueGroupRank.Index).Value = CDbl(Row.Item("GROUP_RANK"))
                    End If
                    If Not Information.IsDBNull(Row.Item("GROUP_RUNS")) Then
                        DGVRow.Cells(Me.DGVTBCL10VenueGroupRuns.Index).Value = CInt(Row.Item("GROUP_RUNS"))
                    End If

                    If Not Information.IsDBNull(Row.Item("LENGTH")) Then
                        DGVRow.Cells(Me.DGVTBCL10VenueLength.Index).Value = Row.Item("LENGTH").ToString
                    End If
                    If Not Information.IsDBNull(Row.Item("LENGTH_DISTANCEBEHIND")) Then
                        DGVRow.Cells(Me.DGVTBCL10VenueLengthDistancebehind.Index).Value = CDbl(FormatNumber(Row.Item("LENGTH_DISTANCEBEHIND"), 2))
                    End If
                    If Not Information.IsDBNull(Row.Item("LENGTH_RANK")) Then
                        DGVRow.Cells(Me.DGVTBCL3VenueLengthRank.Index).Value = CDbl(Row.Item("LENGTH_RANK"))
                    End If
                    If Not Information.IsDBNull(Row.Item("LENGTH_RUNS")) Then
                        DGVRow.Cells(Me.DGVTBCL3VenueLengthRuns.Index).Value = CInt(Row.Item("LENGTH_RUNS"))
                    End If

                    If Convert.ToBoolean(Row.Item("SCRATCHED")) Then Call StratchDGVRow(DGVRow, Me.DataGridViewLast10)

                    Me.DataGridViewVenueLast10.Rows.Add(DGVRow)
                End Using
            Next Row
            Call SelectModels(This_OADate, This_MeetingNumber, This_RaceNumber)
        End Sub

        Private Sub PopulateL3()
            For Each Row As Data.DataRow In DataTables.StatsLastX.Last3DataTable(This_OADate, This_MeetingNumber, This_RaceNumber, This_Connection).Select("", "NUMBER ASC")
                Using DGVRow As New DataGridViewRow
                    Dim Divider As Double = 0#, AverageTrend As Double = 0#
                    DGVRow.CreateCells(Me.DataGridViewLast3)
                    DGVRow.Cells(Me.DGVL3Number.Index).Value = Convert.ToInt32(Row.Item("NUMBER"))
                    DGVRow.Cells(Me.DGVL3Barrier.Index).Value = Convert.ToInt32(Row.Item("BARRIER"))
                    If This_MeetingType = "GR" Then
                        If IsDBNull(Row.Item("BARRIER_RANK")) Then
                            DGVRow.Cells(Me.DGVL3BarrierRank.Index).Value = 0#
                        Else
                            DGVRow.Cells(Me.DGVL3BarrierRank.Index).Value = CDbl(Row.Item("BARRIER_RANK"))
                        End If
                    End If
                    DGVRow.Cells(Me.DGVL3Name.Index).Value = Row.Item("NAME").ToString

                    If Not Information.IsDBNull(Row.Item("LASTRAN")) Then
                        DGVRow.Cells(Me.DGVL3LastRanDate.Index).Value = Date.FromOADate(Row.Item("LASTRAN"))
                    End If
                    If Not Information.IsDBNull(Row.Item("FINISHPOSITION")) Then
                        DGVRow.Cells(Me.DGVL3LastRanFinishPosition.Index).Value = CInt(Row.Item("FINISHPOSITION"))
                    End If
                    If Not Information.IsDBNull(Row.Item("DISTANCE")) Then
                        DGVRow.Cells(Me.DGVL3Distance.Index).Value = CInt(Row.Item("DISTANCE"))
                    End If

                    If Not Information.IsDBNull(Row.Item("SEQUENCE")) Then
                        DGVRow.Cells(Me.DGVL3Sequence.Index).Value = Row.Item("SEQUENCE").ToString
                    End If
                    If Not Information.IsDBNull(Row.Item("SEQUENCE_RANK")) Then
                        DGVRow.Cells(Me.DGVL3SequenceRank.Index).Value = CDbl(Row.Item("SEQUENCE_RANK"))
                    End If
                    If Not Information.IsDBNull(Row.Item("SEQUENCE_RUNS")) Then
                        DGVRow.Cells(Me.DGVL3SequenceRuns.Index).Value = CInt(Row.Item("SEQUENCE_RUNS"))
                    End If

                    If Not Information.IsDBNull(Row.Item("GROUP")) Then
                        DGVRow.Cells(Me.DGVL3Group.Index).Value = Row.Item("GROUP").ToString
                    End If
                    If Not Information.IsDBNull(Row.Item("GROUP_RANK")) Then
                        DGVRow.Cells(Me.DGVL3GroupRank.Index).Value = CDbl(Row.Item("GROUP_RANK"))
                    End If
                    If Not Information.IsDBNull(Row.Item("GROUP_RUNS")) Then
                        DGVRow.Cells(Me.DGVL3GroupRuns.Index).Value = CInt(Row.Item("GROUP_RUNS"))
                    End If

                    If Not Information.IsDBNull(Row.Item("LENGTH")) Then
                        DGVRow.Cells(Me.DGVL3Length.Index).Value = Row.Item("LENGTH").ToString
                    End If
                    If Not Information.IsDBNull(Row.Item("LENGTH_DISTANCEBEHIND")) Then
                        DGVRow.Cells(Me.DGVL3LENGTHDISTANCEBEHIND.Index).Value = CDbl(FormatNumber(Row.Item("LENGTH_DISTANCEBEHIND"), 2))
                    End If
                    If Not Information.IsDBNull(Row.Item("LENGTH_RANK")) Then
                        DGVRow.Cells(Me.DGVL3LengthRank.Index).Value = CDbl(Row.Item("LENGTH_RANK"))
                    End If
                    If Not Information.IsDBNull(Row.Item("LENGTH_RUNS")) Then
                        DGVRow.Cells(Me.DGVL3LengthRuns.Index).Value = CInt(Row.Item("LENGTH_RUNS"))
                    End If

                    If Convert.ToBoolean(Row.Item("SCRATCHED")) Then Call StratchDGVRow(DGVRow, Me.DataGridViewLast3)

                    Me.DataGridViewLast3.Rows.Add(DGVRow)
                End Using
            Next Row
        End Sub
        Private Sub SelectModels(OADate As String, MeetingNumber As String, RaceNumber As String)
            Dim CMDTEXT As String = "SELECT MEETING_XML_OADATE, MEETING_XML_NUMBER, RACE_XML_NUMBER, NUMBER FROM RACE_MODELS 
            WHERE (MEETING_XML_OADATE = " & OADate & ") AND (MEETING_XML_NUMBER = " & MeetingNumber & ") AND (RACE_XML_NUMBER = " & RaceNumber & ")"

            For Each Row As Data.DataRow In This_Connection.GetDataTable(CMDTEXT).Select("")
                For Each DGVRow As DataGridViewRow In Me.DataGridViewLast10.Rows
                    If CInt(DGVRow.Cells(Me.DGVL3Number.Index).Value) = CInt(Row.Item("NUMBER")) Then
                        For ColumnIndex As Integer = 0 To Me.DataGridViewLast10.ColumnCount - 1
                            DGVRow.Cells(ColumnIndex).Style.Font = New Font(Me.DataGridViewLast10.Font.FontFamily, Me.DataGridViewLast10.Font.Size, FontStyle.Bold)
                            DGVRow.Cells(ColumnIndex).Style.BackColor = Color.Teal
                            DGVRow.Cells(ColumnIndex).Style.ForeColor = Color.Black
                        Next
                    End If
                Next DGVRow
            Next row
        End Sub
        Private Sub PopulateResults()
            For Each Row As Data.DataRow In DataTables.Results.Results(This_OADate, This_MeetingNumber, This_RaceNumber, This_Connection).Select("")
                Using DGVRow As New DataGridViewRow
                    Dim Divider As Double = 0#, AverageTrend As Double = 0#
                    DGVRow.CreateCells(Me.DataGridViewResults)
                    DGVRow.Cells(Me.DGVResultsNumber.Index).Value = Convert.ToInt32(Row.Item("NUMBER"))
                    DGVRow.Cells(Me.DGVResultsBarrier.Index).Value = Convert.ToInt32(Row.Item("BARRIER"))
                    DGVRow.Cells(Me.DGVResultsName.Index).Value = Row.Item("NAME").ToString
                    If Not Information.IsDBNull(Row.Item("FINISH_POSITION")) Then
                        DGVRow.Cells(Me.DGVResultsFinishPosition.Index).Value = Convert.ToInt32(Row.Item("FINISH_POSITION"))
                    End If
                    Me.DataGridViewResults.Rows.Add(DGVRow)
                End Using
            Next Row
        End Sub
        Private Sub StratchDGVRow(ByRef DGVRow As DataGridViewRow, ByRef DGV As DataGridView)
            For ColumnIndex As Integer = 0 To DGV.ColumnCount - 1
                DGVRow.Cells(ColumnIndex).Style.Font = New Font(DGV.Font.FontFamily, DGV.Font.Size, FontStyle.Strikeout)
            Next
        End Sub

        Private Sub DataGridViewLast10_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewLast10.CellContentDoubleClick
            If e.RowIndex < 0 Then Return

            If e.ColumnIndex = Me.DGVL10Name.Index Then
                Me.Cursor = Cursors.WaitCursor
                Using NewFrmRunnerRaceList As New CascadeCommon.FrmRunnerRaceList(Me.This_OADate, Me.This_CountryID, Me.This_MeetingType, Me.DataGridViewLast10.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString, This_Connection)
                    NewFrmRunnerRaceList.ShowDialog(Me)

                End Using
                Me.Cursor = Cursors.Default
            End If
        End Sub
    End Class
End Namespace