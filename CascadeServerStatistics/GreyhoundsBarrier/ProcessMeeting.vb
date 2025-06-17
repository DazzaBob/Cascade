Imports CascadeCommon

Namespace GreyhoundsBarrier
    Partial Class EntryPoint
        Friend Class ProcessMeeting : Implements IDisposable
            Private disposedValue As Boolean
            Private ReadOnly This_MeetingDR As Data.DataRow
            Private This_Connection As CascadeCommon.Utils.Connection
            Private ReadOnly This_ConnectionString As String
            Private ReadOnly This_Messages As CascadeCommon.Messages
            Private Sub New()
                Me.disposedValue = False
                Me.This_MeetingDR = Nothing
                Me.This_Connection = Nothing
                Me.This_ConnectionString = String.Empty
                Me.This_Messages = Nothing
            End Sub
            Friend Sub New(MeetingDR As Data.DataRow, ConnectionString As String, Messages As CascadeCommon.Messages)
                Me.New
                Me.This_MeetingDR = MeetingDR
                Me.This_ConnectionString = ConnectionString
                Me.This_Messages = Messages
            End Sub
            Friend Sub Start()
                This_Connection = New CascadeCommon.Utils.Connection(This_ConnectionString, This_Messages)

                Dim LogThis As String

                LogThis = "Created barrier STATistics for M " & This_MeetingDR.Item("NUMBER").ToString & " - " & This_MeetingDR.Item("NAME").ToString & Environment.NewLine & vbTab

                Dim RaceDT As New Data.DataTable
                Using cDT As New DataTables(This_Messages)
                    RaceDT = cDT.Race(This_MeetingDR.Item("OADATE"), This_MeetingDR.Item("NUMBER").ToString, This_Connection)
                End Using
                If RaceDT.Rows.Count > 0 Then
                    For Each DR As Data.DataRow In RaceDT.Select("")
                        LogThis += "R" & DR.Item("NUMBER").ToString & " @ " & DR.Item("LENGTH").ToString

                        Dim CommandText As String = String.Empty

                        Using BarrierDT As Data.DataTable = GetBarrierGridDataTable(DR.Item("VENUE_ID").ToString, DR.Item("LENGTH").ToString)
                            If BarrierDT IsNot Nothing AndAlso BarrierDT.Rows.Count > 0 Then
                                For Each BarrierDR As Data.DataRow In BarrierDT.Select("")
                                    Using cSQL As New SQL(This_Messages)
                                        CommandText += cSQL.Insert(DR.Item("MEETING_XML_OADATE").ToString, DR.Item("MEETING_XML_NUMBER").ToString, DR.Item("NUMBER").ToString, BarrierDR.Item("BARRIER").ToString, BarrierDR.Item("RANK"))
                                    End Using
                                Next BarrierDR
                            End If
                        End Using

                        If CommandText.Length > 0 Then Call This_Connection.Execute(CommandText)
                        LogThis += ", "
                    Next DR

                    If LogThis.Contains(CChar(",")) Then
                        LogThis = Strings.Left(LogThis, LogThis.LastIndexOf(","))
                    End If

                    Call This_Messages.LogMessages(LogThis, CascadeCommon.Common.BroadcastTypes.Log)
                End If

                This_Connection.Dispose()
            End Sub
            Private Function GetBarrierGridDataTable(VenueID As String, Length As String) As Data.DataTable
                Dim DT As New Data.DataTable
                Dim ThisDT As Data.DataTable = CreateBarrierGrid()

                Using cDT As New DataTables(This_Messages)
                    DT = cDT.RaceResultsDT(This_MeetingDR.Item("OADATE").ToString, VenueID, Length, This_Connection)
                End Using

                If DT.Rows.Count = 0 Then Return New Data.DataTable

                Try
                    For Barrier As Integer = 1 To 8
                        Dim NewRow As Data.DataRow = ThisDT.NewRow
                        NewRow.Item("BARRIER") = Barrier

                        Dim BarrierRank As Double = 0#

                        Dim SumOfRank As Double = 0#
                        Dim CountOf As Integer = 0#
                        Dim COMP As Object = DT.Compute("SUM(RANK)", "(BARRIER=" & Barrier.ToString & ")")
                        If COMP IsNot Nothing AndAlso IsNumeric(COMP) Then SumOfRank = CDbl(COMP)

                        COMP = DT.Compute("COUNT(BARRIER)", "(BARRIER=" & Barrier.ToString & ")")
                        If COMP IsNot Nothing AndAlso IsNumeric(COMP) Then CountOf = CDbl(COMP)

                        If CountOf > 0 Then
                            BarrierRank = SumOfRank / CountOf
                        End If

                        NewRow.Item("RANK") = BarrierRank
                        ThisDT.Rows.Add(NewRow)
                    Next Barrier
                Catch ex As Exception
                    Call Me.This_Messages.LogMessages(ex.ToString, CascadeCommon.BroadcastTypes.Error)
                End Try

                Return ThisDT
            End Function
            Private Function CreateBarrierGrid() As Data.DataTable
                Dim MyDT As New Data.DataTable("BARRIERGRID")
                Dim Column As New Data.DataColumn("BARRIER", GetType(Integer))
                MyDT.Columns.Add(Column)

                Try
                    Column = New Data.DataColumn("RANK", GetType(Double)) : MyDT.Columns.Add(Column)
                Catch ex As Exception
                    Call Me.This_Messages.LogMessages(ex.ToString, CascadeCommon.BroadcastTypes.Error)
                Finally
                    MyDT.AcceptChanges()
                End Try

                Return MyDT
            End Function
            Protected Overridable Sub Dispose(disposing As Boolean)
                If Not disposedValue Then
                    If disposing Then
                        If This_Connection IsNot Nothing Then This_Connection.Dispose()
                    End If

                    ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
                    ' TODO: set large fields to null
                    disposedValue = True
                End If
            End Sub
            ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
            ' Protected Overrides Sub Finalize()
            '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            '     Dispose(disposing:=False)
            '     MyBase.Finalize()
            ' End Sub
            Public Sub Dispose() Implements IDisposable.Dispose
                ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
                Dispose(disposing:=True)
                GC.SuppressFinalize(Me)
            End Sub
        End Class
    End Class
End Namespace