Imports System.Windows.Forms
Namespace UserControls
    Friend NotInheritable Class GridViewCellStyles
        Private Sub New()
            ' Just to stop the compiler adding a default constructor to a shared class.
        End Sub
        Friend Shared Sub ChangeForeColor(ByRef GridViewRow As System.Windows.Forms.DataGridViewRow, ByVal ColumnIndex As Integer, ByVal Color As Drawing.Color)
            SyncLock New Object
                Dim CellStyle As System.Windows.Forms.DataGridViewCellStyle = GridViewRow.Cells(ColumnIndex).Style
                CellStyle.ForeColor = Color
                GridViewRow.Cells(ColumnIndex).Style = CellStyle
            End SyncLock
        End Sub
        Friend Shared Sub MakeRowScratched(ByVal Scratched As Int32, ByRef DGVRow As DataGridViewRow, ByRef DGV As DataGridView)
            SyncLock New Object
                If CBool(Scratched) Then
                    For Each Cell As DataGridViewCell In DGVRow.Cells
                        If Cell.ColumnIndex < 0 OrElse Cell.RowIndex < 0 Then Continue For
                        If DGV.Columns(Cell.ColumnIndex).Visible = True Then
                            Cell.Style = GridViewCellStyles.StrikeOut(Cell, DGV.Columns(Cell.ColumnIndex).DefaultCellStyle)
                            'Cell.Style = UI.GridViewCellStyles.Scratched(Cell, DGV.Columns(Cell.ColumnIndex).DefaultCellStyle)
                        End If
                    Next
                End If
            End SyncLock
        End Sub
        Friend Shared Sub AddDefaultCellStyleToCells(ByRef GridViewRow As DataGridViewRow, ByRef GridView As DataGridView)
            SyncLock New Object
                For Each Cell As DataGridViewCell In GridViewRow.Cells
                    If Cell.ColumnIndex < 0 OrElse Cell.RowIndex < 0 Then Continue For
                    Cell.Style = GridView.Columns(Cell.ColumnIndex).DefaultCellStyle
                Next
            End SyncLock
        End Sub
        Private Shared Function StrikeOut(ByVal Cell As DataGridViewCell, ByVal DefaultCellStyle As DataGridViewCellStyle) As DataGridViewCellStyle
            ' Is Synclocked in the calling method.
            StrikeOut = New DataGridViewCellStyle

            Dim CellStyle As DataGridViewCellStyle
            Try
                CellStyle = Cell.Style
            Catch ex As Exception
                CellStyle = DefaultCellStyle
            End Try
            '
            Try
                Dim FontStyle As Drawing.FontStyle = CType(CellStyle.Font.Style + Drawing.FontStyle.Strikeout, Drawing.FontStyle)
                StrikeOut.Font = New Font(DefaultCellStyle.Font, FontStyle)
            Catch EX As Exception
                ' DO NOTHING
            End Try
        End Function
        Friend Shared Function HasModel(ByRef Cell As DataGridViewCell, ByRef DefaultCellStyle As DataGridViewCellStyle) As DataGridViewCellStyle
            SyncLock New Object
                HasModel = New DataGridViewCellStyle

                Dim CellStyle As DataGridViewCellStyle
                Try
                    CellStyle = Cell.Style
                Catch ex As Exception
                    CellStyle = DefaultCellStyle
                End Try

                Try
                    Dim FontStyle As Drawing.FontStyle = CType(CellStyle.Font.Style + Drawing.FontStyle.Bold, Drawing.FontStyle)
                    HasModel.Font = New Font(DefaultCellStyle.Font, FontStyle)
                    HasModel.BackColor = Color.FromKnownColor(KnownColor.DarkCyan)
                    HasModel.ForeColor = Color.FromKnownColor(KnownColor.White)
                    '
                    Cell.Style = HasModel
                Catch EX As Exception
                    '
                End Try
            End SyncLock
        End Function
    End Class
End Namespace