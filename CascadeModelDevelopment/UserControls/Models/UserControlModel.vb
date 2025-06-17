Imports System.ComponentModel
Namespace UserControls.Models
    Friend Class UserControlModel
        Private This_UCProperties As UserControlProperties
        Private This_UCSource As UserControlSource
        Private This_UCResults As UserControlResults

        Private UCTabPage As UserControls.UserControlTabPage
        Private This_FrmMain As FrmMain
        Private This_ExplorerID As String
        Private Sub New()
            InitializeComponent()
            Me.This_ExplorerID = String.Empty
        End Sub
        Friend Sub New(ExplorerID As String, TabPage As UserControls.UserControlTabPage, FrmMain As FrmMain)
            Me.New
            Me.UCTabPage = TabPage
            Me.This_ExplorerID = ExplorerID
            Me.This_FrmMain = FrmMain

            Call AddControlProperties() ' Load this first, we store everything in here.
            Call AddControlSource()
            Call AddControlResults()

            Me.TabControlMain.TabPages(0).Select()
        End Sub
        Friend ReadOnly Property UCProperties As UserControls.Models.UserControlProperties
            Get
                Return Me.This_UCProperties
            End Get
        End Property
        Friend ReadOnly Property UCSource As UserControls.Models.UserControlSource
            Get
                Return Me.This_UCSource
            End Get
        End Property
        Friend ReadOnly Property UCResults As UserControls.Models.UserControlResults
            Get
                Return Me.This_UCResults
            End Get
        End Property
        Private Sub AddControlProperties()
            This_UCProperties = New UserControlProperties(This_ExplorerID, Me.UCTabPage, FrmMain) With {
                .BackColor = SystemColors.Window,
                .Dock = DockStyle.Fill,
                .Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point),
                .ForeColor = SystemColors.WindowText,
                .Location = New Point(0, 0),
                .Margin = New Padding(0),
                .Name = "_UserControlProperties",
                .Size = New Size(1705, 647),
                .TabIndex = 1
            }

            Me.TabPage_Properties.Controls.Add(This_UCProperties)
        End Sub
        Private Sub AddControlSource()
            This_UCSource = New UserControlSource(Me.This_UCProperties) With {
                .BackColor = SystemColors.Window,
                .Dock = DockStyle.Fill,
                .Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point),
                .ForeColor = SystemColors.WindowText,
                .Location = New Point(0, 0),
                .Margin = New Padding(0),
                .Name = "_UserControlSource",
                .Size = New Size(1705, 647),
                .TabIndex = 1
            }

            Me.TabPage_Source.Controls.Add(This_UCSource)
        End Sub
        Private Sub AddControlResults()
            This_UCResults = New UserControlResults With {
                .BackColor = SystemColors.Window,
                .Dock = DockStyle.Fill,
                .Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point),
                .ForeColor = SystemColors.WindowText,
                .Location = New Point(0, 0),
                .Margin = New Padding(0),
                .Name = "_UserControlResults",
                .Size = New Size(1705, 647),
                .TabIndex = 1
            }

            Me.TabPage_Results.Controls.Add(This_UCResults)
        End Sub
    End Class
End Namespace