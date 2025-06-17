Namespace UserControls
    Friend Class UserControlTabPage : Inherits System.Windows.Forms.TabPage
        Private This_ExplorerID As String
        Private ReadOnly This_UCModels As UserControls.Models.UserControlModel
        Private Sub New()
            MyBase.New
        End Sub
        Friend Sub New(ExplorerID As String, FrmMain As FrmMain)
            Me.New
            Me.This_UCModels = New Models.UserControlModel(ExplorerID, Me, FrmMain)
            Call AddControlModel()

            Me.This_ExplorerID = ExplorerID
        End Sub
        Private Sub AddControlModel()
            Me.This_UCModels.BackColor = SystemColors.Window
            Me.This_UCModels.Dock = DockStyle.Fill
            Me.This_UCModels.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point)
            Me.This_UCModels.ForeColor = SystemColors.WindowText
            Me.This_UCModels.Location = New Point(0, 0)
            Me.This_UCModels.Margin = New Padding(0)
            Me.This_UCModels.Name = "_UserControlModels"
            Me.This_UCModels.Size = New Size(1705, 647)
            Me.This_UCModels.TabIndex = 1

            Me.Controls.Add(This_UCModels)
        End Sub
        Friend Property ExplorerID As String
            Get
                Return Me.This_ExplorerID
            End Get
            Set(value As String)
                Me.This_ExplorerID = value
            End Set
        End Property
        Friend ReadOnly Property UserControlModel As UserControls.Models.UserControlModel
            Get
                Return Me.This_UCModels
            End Get
        End Property
        Private Sub UserControlTabPage_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            MyBase.Dispose()
        End Sub
    End Class
End Namespace