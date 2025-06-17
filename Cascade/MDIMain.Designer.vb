Namespace Forms
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class MdiMain
        Inherits System.Windows.Forms.Form

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub


        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MdiMain))
            Me.MenuStrip = New System.Windows.Forms.MenuStrip()
            Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_FileApplicationSettings = New System.Windows.Forms.ToolStripMenuItem()
            Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ReportingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ServerUIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_FileOpenModelDevelopment = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_TSS_FILE_OPEN1 = New System.Windows.Forms.ToolStripSeparator()
            Me.TSMI_FILE_OPEN_HomeFolder = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_FILE_OPEN_ErrorFolder = New System.Windows.Forms.ToolStripMenuItem()
            Me.TSMI_FILE_OPEN_LogFolder = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
            Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem()
            Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem()
            Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
            Me.MenuStrip.SuspendLayout()
            Me.SuspendLayout()
            '
            'MenuStrip
            '
            Me.MenuStrip.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.MenuStrip.GripMargin = New System.Windows.Forms.Padding(2, 2, 0, 2)
            Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(24, 24)
            Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ToolsMenu, Me.WindowsMenu})
            Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
            Me.MenuStrip.MdiWindowListItem = Me.WindowsMenu
            Me.MenuStrip.Name = "MenuStrip"
            Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
            Me.MenuStrip.Size = New System.Drawing.Size(737, 37)
            Me.MenuStrip.TabIndex = 5
            Me.MenuStrip.Text = "MenuStrip"
            '
            'FileMenu
            '
            Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_FileApplicationSettings, Me.OpenToolStripMenuItem, Me.ToolStripSeparator5, Me.ExitToolStripMenuItem})
            Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
            Me.FileMenu.Name = "FileMenu"
            Me.FileMenu.Size = New System.Drawing.Size(64, 33)
            Me.FileMenu.Text = "&File"
            '
            'TSMI_FileApplicationSettings
            '
            Me.TSMI_FileApplicationSettings.ImageTransparentColor = System.Drawing.Color.White
            Me.TSMI_FileApplicationSettings.Name = "TSMI_FileApplicationSettings"
            Me.TSMI_FileApplicationSettings.Size = New System.Drawing.Size(311, 38)
            Me.TSMI_FileApplicationSettings.Text = "Application Settings"
            '
            'OpenToolStripMenuItem
            '
            Me.OpenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReportingToolStripMenuItem, Me.ServerUIToolStripMenuItem, Me.TSMI_FileOpenModelDevelopment, Me.TSMI_TSS_FILE_OPEN1, Me.TSMI_FILE_OPEN_HomeFolder, Me.TSMI_FILE_OPEN_ErrorFolder, Me.TSMI_FILE_OPEN_LogFolder})
            Me.OpenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
            Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(311, 38)
            Me.OpenToolStripMenuItem.Text = "&Open"
            '
            'ReportingToolStripMenuItem
            '
            Me.ReportingToolStripMenuItem.Name = "ReportingToolStripMenuItem"
            Me.ReportingToolStripMenuItem.Size = New System.Drawing.Size(320, 38)
            Me.ReportingToolStripMenuItem.Text = "Reporting"
            '
            'ServerUIToolStripMenuItem
            '
            Me.ServerUIToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.ServerUIToolStripMenuItem.Name = "ServerUIToolStripMenuItem"
            Me.ServerUIToolStripMenuItem.Size = New System.Drawing.Size(320, 38)
            Me.ServerUIToolStripMenuItem.Text = "Server UI"
            '
            'TSMI_FileOpenModelDevelopment
            '
            Me.TSMI_FileOpenModelDevelopment.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_FileOpenModelDevelopment.Name = "TSMI_FileOpenModelDevelopment"
            Me.TSMI_FileOpenModelDevelopment.Size = New System.Drawing.Size(320, 38)
            Me.TSMI_FileOpenModelDevelopment.Text = "Model Development"
            '
            'TSMI_TSS_FILE_OPEN1
            '
            Me.TSMI_TSS_FILE_OPEN1.Name = "TSMI_TSS_FILE_OPEN1"
            Me.TSMI_TSS_FILE_OPEN1.Size = New System.Drawing.Size(317, 6)
            '
            'TSMI_FILE_OPEN_HomeFolder
            '
            Me.TSMI_FILE_OPEN_HomeFolder.Name = "TSMI_FILE_OPEN_HomeFolder"
            Me.TSMI_FILE_OPEN_HomeFolder.Size = New System.Drawing.Size(320, 38)
            Me.TSMI_FILE_OPEN_HomeFolder.Text = "Home Folder"
            '
            'TSMI_FILE_OPEN_ErrorFolder
            '
            Me.TSMI_FILE_OPEN_ErrorFolder.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_FILE_OPEN_ErrorFolder.Name = "TSMI_FILE_OPEN_ErrorFolder"
            Me.TSMI_FILE_OPEN_ErrorFolder.Size = New System.Drawing.Size(320, 38)
            Me.TSMI_FILE_OPEN_ErrorFolder.Text = "Error Folder"
            '
            'TSMI_FILE_OPEN_LogFolder
            '
            Me.TSMI_FILE_OPEN_LogFolder.Name = "TSMI_FILE_OPEN_LogFolder"
            Me.TSMI_FILE_OPEN_LogFolder.Size = New System.Drawing.Size(320, 38)
            Me.TSMI_FILE_OPEN_LogFolder.Text = "Log Folder"
            '
            'ToolStripSeparator5
            '
            Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
            Me.ToolStripSeparator5.Size = New System.Drawing.Size(308, 6)
            '
            'ExitToolStripMenuItem
            '
            Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
            Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(311, 38)
            Me.ExitToolStripMenuItem.Text = "E&xit"
            '
            'ToolsMenu
            '
            Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
            Me.ToolsMenu.Name = "ToolsMenu"
            Me.ToolsMenu.Size = New System.Drawing.Size(80, 33)
            Me.ToolsMenu.Text = "&Tools"
            '
            'OptionsToolStripMenuItem
            '
            Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
            Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(270, 38)
            Me.OptionsToolStripMenuItem.Text = "&Options"
            '
            'WindowsMenu
            '
            Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem})
            Me.WindowsMenu.Name = "WindowsMenu"
            Me.WindowsMenu.Size = New System.Drawing.Size(121, 33)
            Me.WindowsMenu.Text = "&Windows"
            '
            'CascadeToolStripMenuItem
            '
            Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
            Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(270, 38)
            Me.CascadeToolStripMenuItem.Text = "&Cascade"
            '
            'TileVerticalToolStripMenuItem
            '
            Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
            Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(270, 38)
            Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
            '
            'TileHorizontalToolStripMenuItem
            '
            Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
            Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(270, 38)
            Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
            '
            'CloseAllToolStripMenuItem
            '
            Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
            Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(270, 38)
            Me.CloseAllToolStripMenuItem.Text = "C&lose All"
            '
            'MdiMain
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.White
            Me.ClientSize = New System.Drawing.Size(737, 523)
            Me.Controls.Add(Me.MenuStrip)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.IsMdiContainer = True
            Me.MainMenuStrip = Me.MenuStrip
            Me.Name = "MdiMain"
            Me.Text = "CASCADE"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.MenuStrip.ResumeLayout(False)
            Me.MenuStrip.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Private WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents ToolTip As System.Windows.Forms.ToolTip
        Private WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents TSMI_FileApplicationSettings As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents MenuStrip As System.Windows.Forms.MenuStrip
        Private WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents ReportingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents ServerUIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TSMI_FileOpenModelDevelopment As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TSMI_TSS_FILE_OPEN1 As System.Windows.Forms.ToolStripSeparator
        Private WithEvents TSMI_FILE_OPEN_HomeFolder As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TSMI_FILE_OPEN_ErrorFolder As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TSMI_FILE_OPEN_LogFolder As System.Windows.Forms.ToolStripMenuItem

    End Class
End Namespace