Imports System.Windows.Forms
Namespace Forms
    Public Class MdiMain
        Private MY_REPORTING As Reporting.FORM_REPORTING
        Private MY_SERVERUI As UI.FrmServer
        Private MY_MODELDEVELOPMENT As ModelDevelopment.FORM_MODELDEVELOPMENT
        Private MY_POPUP As UserControls.PopUp
        Public Sub New()
            InitializeComponent()
#If DEBUG Then
            Me.Text += " (DEBUG)"
#End If
        End Sub
        'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        '        Dim OpenFileDialog As New OpenFileDialog
        '       OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        '      OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
        '     If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
        ' Dim FileName As String = OpenFileDialog.FileName
        ' TODO: Add code here to open the file.
        'End If
        'End Sub
        ' Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        'Dim SaveFileDialog As New SaveFileDialog
        '   SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        '   SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

        '   If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
        '  Dim FileName As String = SaveFileDialog.FileName
        ' TODO: Add code here to save the current contents of the form to a file.
        '    End If
        'End Sub
        Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
            Me.Close()
        End Sub
        Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
            Me.LayoutMdi(MdiLayout.Cascade)
        End Sub

        Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
            Me.LayoutMdi(MdiLayout.TileVertical)
        End Sub

        Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
            Me.LayoutMdi(MdiLayout.TileHorizontal)
        End Sub
        Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
            ' Close all child forms of the parent.
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
        End Sub
        Private Sub ReportingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportingToolStripMenuItem.Click
            If Not MY_REPORTING Is Nothing AndAlso Not MY_REPORTING.IsDisposed Then
                MY_REPORTING.BringToFront()
                MY_REPORTING.Focus()
                Return
            End If
            '
            MY_REPORTING = New Reporting.FORM_REPORTING
            MY_REPORTING.Size = New Size(800, 600)
            MY_REPORTING.WindowState = FormWindowState.Maximized
            MY_REPORTING.MdiParent = Me
            MY_REPORTING.Show()
        End Sub
        Private Sub ServerUIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ServerUIToolStripMenuItem.Click
            If Not MY_SERVERUI Is Nothing AndAlso Not MY_SERVERUI.IsDisposed Then
                MY_SERVERUI.BringToFront()
                MY_SERVERUI.Focus()
                Return
            End If
            '
            MY_SERVERUI = New UI.FrmServer
            MY_SERVERUI.Size = New Size(800, 600)
            MY_SERVERUI.WindowState = FormWindowState.Maximized
            MY_SERVERUI.MdiParent = Me
            MY_SERVERUI.Show()
        End Sub
        Private Sub TSMI_FileOpenModelDevelopment_Click(sender As Object, e As EventArgs) Handles TSMI_FileOpenModelDevelopment.Click
            If Not MY_MODELDEVELOPMENT Is Nothing AndAlso Not MY_MODELDEVELOPMENT.IsDisposed Then
                MY_MODELDEVELOPMENT.Focus()
                Return
            End If
            '
            MY_MODELDEVELOPMENT = New ModelDevelopment.FORM_MODELDEVELOPMENT
            MY_MODELDEVELOPMENT.Size = New Size(800, 600)
            MY_MODELDEVELOPMENT.WindowState = FormWindowState.Maximized
            MY_MODELDEVELOPMENT.MdiParent = Me
            MY_MODELDEVELOPMENT.Show()
        End Sub
        Private Sub TSMI_FileApplicationSettings_Click(sender As Object, e As EventArgs) Handles TSMI_FileApplicationSettings.Click
            Using ApplicationSettings As UserControls.UC_ApplicationSettings = New UserControls.UC_ApplicationSettings
                ApplicationSettings.Dock = DockStyle.Fill
                '
                MY_POPUP = New UserControls.PopUp
                MY_POPUP.Text = "Application Settings"
                MY_POPUP.Size = New Size(800, 600)
                MY_POPUP.MinimizeBox = False
                MY_POPUP.MaximizeBox = False
                MY_POPUP.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedToolWindow
                '
                MY_POPUP.Controls.Add(ApplicationSettings)
                '
                MY_POPUP.ShowDialog(Me)
            End Using
        End Sub
#Region "   OPEN FOLDERS "
        Private Sub TSMI_FILE_OPEN_HomeFolder_Click(sender As Object, e As EventArgs) Handles TSMI_FILE_OPEN_HomeFolder.Click
            Shell("Explorer " & My.Settings.HomeFolder, AppWinStyle.MaximizedFocus, False)
        End Sub
        Private Sub TSMI_FILE_OPEN_ErrorFolder_Click(sender As Object, e As EventArgs) Handles TSMI_FILE_OPEN_ErrorFolder.Click
            Shell("Explorer " & My.Settings.ErrorFolder, AppWinStyle.MaximizedFocus, False)
        End Sub
        Private Sub TSMI_FILE_OPEN_LogFolder_Click(sender As Object, e As EventArgs) Handles TSMI_FILE_OPEN_LogFolder.Click
            Shell("Explorer " & My.Settings.LogFolder, AppWinStyle.MaximizedFocus, False)
        End Sub
#End Region
    End Class
End Namespace