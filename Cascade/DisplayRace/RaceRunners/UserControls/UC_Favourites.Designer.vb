Namespace DisplayRace.RaceRunners.UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_Favourites
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                If MY_RUNNERRACELIST IsNot Nothing Then MY_RUNNERRACELIST.Dispose() : MY_RUNNERRACELIST = Nothing
                If MY_POPUP IsNot Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.DGV_MAIN = New System.Windows.Forms.DataGridView()
            Me.CMS_DGV_MAIN = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.TSMI_MAIN_COPY = New System.Windows.Forms.ToolStripMenuItem()
            Me.DGV_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_FAV_DISTANCE = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_FAV_DISTANCE_WINS = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_FAV_DISTANCE_PLACES = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_FAV_DISTANCE_TRACK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_FAV_DISTANCE_TRACK_WINS = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_FAV_DISTANCE_TRACK_PLACES = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_FAV_DISTANCE_WEATHER = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_FAV_DISTANCE_WEATHER_WINS = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_FAV_DISTANCE_WEATHER_PLACES = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_GROUP = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_GROUP_WINS = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_GROUP_PLACES = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_GROUP_TRACK = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_GROUP_TRACK_WINS = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_GROUP_TRACK_PLACES = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_GROUP_WEATHER = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_GROUP_WEATHER_WINS = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_GROUP_WEATHER_PLACES = New System.Windows.Forms.DataGridViewCheckBoxColumn()
            Me.DGV_NAME = New System.Windows.Forms.DataGridViewLinkColumn()
            CType(Me.DGV_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.CMS_DGV_MAIN.SuspendLayout()
            Me.SuspendLayout()
            '
            'DGV_MAIN
            '
            Me.DGV_MAIN.AllowUserToAddRows = False
            Me.DGV_MAIN.AllowUserToDeleteRows = False
            Me.DGV_MAIN.AllowUserToOrderColumns = True
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV_MAIN.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DGV_MAIN.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            Me.DGV_MAIN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MAIN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV_MAIN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV_MAIN.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_NUMBER, Me.DGV_FAV_DISTANCE, Me.DGV_FAV_DISTANCE_WINS, Me.DGV_FAV_DISTANCE_PLACES, Me.DGV_FAV_DISTANCE_TRACK, Me.DGV_FAV_DISTANCE_TRACK_WINS, Me.DGV_FAV_DISTANCE_TRACK_PLACES, Me.DGV_FAV_DISTANCE_WEATHER, Me.DGV_FAV_DISTANCE_WEATHER_WINS, Me.DGV_FAV_DISTANCE_WEATHER_PLACES, Me.DGV_GROUP, Me.DGV_GROUP_WINS, Me.DGV_GROUP_PLACES, Me.DGV_GROUP_TRACK, Me.DGV_GROUP_TRACK_WINS, Me.DGV_GROUP_TRACK_PLACES, Me.DGV_GROUP_WEATHER, Me.DGV_GROUP_WEATHER_WINS, Me.DGV_GROUP_WEATHER_PLACES, Me.DGV_NAME})
            Me.DGV_MAIN.ContextMenuStrip = Me.CMS_DGV_MAIN
            Me.DGV_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV_MAIN.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV_MAIN.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV_MAIN.Location = New System.Drawing.Point(0, 0)
            Me.DGV_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV_MAIN.Name = "DGV_MAIN"
            Me.DGV_MAIN.ReadOnly = True
            Me.DGV_MAIN.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_MAIN.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
            DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN.RowsDefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
            Me.DGV_MAIN.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_MAIN.RowTemplate.ReadOnly = True
            Me.DGV_MAIN.Size = New System.Drawing.Size(800, 300)
            Me.DGV_MAIN.TabIndex = 9
            '
            'CMS_DGV_MAIN
            '
            Me.CMS_DGV_MAIN.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMS_DGV_MAIN.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_MAIN_COPY})
            Me.CMS_DGV_MAIN.Name = "CMSMainInformation"
            Me.CMS_DGV_MAIN.Size = New System.Drawing.Size(102, 26)
            '
            'TSMI_MAIN_COPY
            '
            Me.TSMI_MAIN_COPY.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.TSMI_MAIN_COPY.Name = "TSMI_MAIN_COPY"
            Me.TSMI_MAIN_COPY.Size = New System.Drawing.Size(101, 22)
            Me.TSMI_MAIN_COPY.Text = "&Copy"
            '
            'DGV_NUMBER
            '
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.Format = "N0"
            DataGridViewCellStyle3.NullValue = Nothing
            Me.DGV_NUMBER.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_NUMBER.DividerWidth = 2
            Me.DGV_NUMBER.FillWeight = 75.0!
            Me.DGV_NUMBER.HeaderText = "#"
            Me.DGV_NUMBER.Name = "DGV_NUMBER"
            Me.DGV_NUMBER.ReadOnly = True
            Me.DGV_NUMBER.ToolTipText = "NUMBER"
            Me.DGV_NUMBER.Width = 20
            '
            'DGV_FAV_DISTANCE
            '
            Me.DGV_FAV_DISTANCE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_FAV_DISTANCE.HeaderText = "D"
            Me.DGV_FAV_DISTANCE.Name = "DGV_FAV_DISTANCE"
            Me.DGV_FAV_DISTANCE.ReadOnly = True
            Me.DGV_FAV_DISTANCE.ToolTipText = "DISTANCE"
            Me.DGV_FAV_DISTANCE.Width = 20
            '
            'DGV_FAV_DISTANCE_WINS
            '
            Me.DGV_FAV_DISTANCE_WINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_FAV_DISTANCE_WINS.HeaderText = "DW"
            Me.DGV_FAV_DISTANCE_WINS.Name = "DGV_FAV_DISTANCE_WINS"
            Me.DGV_FAV_DISTANCE_WINS.ReadOnly = True
            Me.DGV_FAV_DISTANCE_WINS.ToolTipText = "DISTANCE WINS"
            Me.DGV_FAV_DISTANCE_WINS.Width = 30
            '
            'DGV_FAV_DISTANCE_PLACES
            '
            Me.DGV_FAV_DISTANCE_PLACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_FAV_DISTANCE_PLACES.DividerWidth = 1
            Me.DGV_FAV_DISTANCE_PLACES.HeaderText = "DP"
            Me.DGV_FAV_DISTANCE_PLACES.Name = "DGV_FAV_DISTANCE_PLACES"
            Me.DGV_FAV_DISTANCE_PLACES.ReadOnly = True
            Me.DGV_FAV_DISTANCE_PLACES.ToolTipText = "DISTANCE PLACES"
            Me.DGV_FAV_DISTANCE_PLACES.Width = 27
            '
            'DGV_FAV_DISTANCE_TRACK
            '
            Me.DGV_FAV_DISTANCE_TRACK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_FAV_DISTANCE_TRACK.HeaderText = "DT"
            Me.DGV_FAV_DISTANCE_TRACK.Name = "DGV_FAV_DISTANCE_TRACK"
            Me.DGV_FAV_DISTANCE_TRACK.ReadOnly = True
            Me.DGV_FAV_DISTANCE_TRACK.ToolTipText = "DISTANCE TRACK"
            Me.DGV_FAV_DISTANCE_TRACK.Width = 25
            '
            'DGV_FAV_DISTANCE_TRACK_WINS
            '
            Me.DGV_FAV_DISTANCE_TRACK_WINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_FAV_DISTANCE_TRACK_WINS.HeaderText = "DTW"
            Me.DGV_FAV_DISTANCE_TRACK_WINS.Name = "DGV_FAV_DISTANCE_TRACK_WINS"
            Me.DGV_FAV_DISTANCE_TRACK_WINS.ReadOnly = True
            Me.DGV_FAV_DISTANCE_TRACK_WINS.ToolTipText = "DISTANCE TRACK WINS"
            Me.DGV_FAV_DISTANCE_TRACK_WINS.Width = 35
            '
            'DGV_FAV_DISTANCE_TRACK_PLACES
            '
            Me.DGV_FAV_DISTANCE_TRACK_PLACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_FAV_DISTANCE_TRACK_PLACES.DividerWidth = 1
            Me.DGV_FAV_DISTANCE_TRACK_PLACES.HeaderText = "DTP"
            Me.DGV_FAV_DISTANCE_TRACK_PLACES.Name = "DGV_FAV_DISTANCE_TRACK_PLACES"
            Me.DGV_FAV_DISTANCE_TRACK_PLACES.ReadOnly = True
            Me.DGV_FAV_DISTANCE_TRACK_PLACES.ToolTipText = "DISTANCE TRACK PLACES"
            Me.DGV_FAV_DISTANCE_TRACK_PLACES.Width = 32
            '
            'DGV_FAV_DISTANCE_WEATHER
            '
            Me.DGV_FAV_DISTANCE_WEATHER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_FAV_DISTANCE_WEATHER.HeaderText = "DWEA"
            Me.DGV_FAV_DISTANCE_WEATHER.Name = "DGV_FAV_DISTANCE_WEATHER"
            Me.DGV_FAV_DISTANCE_WEATHER.ReadOnly = True
            Me.DGV_FAV_DISTANCE_WEATHER.ToolTipText = "DISTANCE WEATHER"
            Me.DGV_FAV_DISTANCE_WEATHER.Width = 41
            '
            'DGV_FAV_DISTANCE_WEATHER_WINS
            '
            Me.DGV_FAV_DISTANCE_WEATHER_WINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_FAV_DISTANCE_WEATHER_WINS.HeaderText = "DEWAW"
            Me.DGV_FAV_DISTANCE_WEATHER_WINS.Name = "DGV_FAV_DISTANCE_WEATHER_WINS"
            Me.DGV_FAV_DISTANCE_WEATHER_WINS.ReadOnly = True
            Me.DGV_FAV_DISTANCE_WEATHER_WINS.ToolTipText = "DISTANCE WEATHER WINS"
            Me.DGV_FAV_DISTANCE_WEATHER_WINS.Width = 51
            '
            'DGV_FAV_DISTANCE_WEATHER_PLACES
            '
            Me.DGV_FAV_DISTANCE_WEATHER_PLACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_FAV_DISTANCE_WEATHER_PLACES.DividerWidth = 2
            Me.DGV_FAV_DISTANCE_WEATHER_PLACES.HeaderText = "DWEAP"
            Me.DGV_FAV_DISTANCE_WEATHER_PLACES.Name = "DGV_FAV_DISTANCE_WEATHER_PLACES"
            Me.DGV_FAV_DISTANCE_WEATHER_PLACES.ReadOnly = True
            Me.DGV_FAV_DISTANCE_WEATHER_PLACES.ToolTipText = "DISTANCE WEATHER PLACES"
            Me.DGV_FAV_DISTANCE_WEATHER_PLACES.Width = 49
            '
            'DGV_GROUP
            '
            Me.DGV_GROUP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_GROUP.HeaderText = "G"
            Me.DGV_GROUP.Name = "DGV_GROUP"
            Me.DGV_GROUP.ReadOnly = True
            Me.DGV_GROUP.Width = 20
            '
            'DGV_GROUP_WINS
            '
            Me.DGV_GROUP_WINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_GROUP_WINS.HeaderText = "GW"
            Me.DGV_GROUP_WINS.Name = "DGV_GROUP_WINS"
            Me.DGV_GROUP_WINS.ReadOnly = True
            Me.DGV_GROUP_WINS.Width = 30
            '
            'DGV_GROUP_PLACES
            '
            Me.DGV_GROUP_PLACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_GROUP_PLACES.DividerWidth = 1
            Me.DGV_GROUP_PLACES.HeaderText = "GP"
            Me.DGV_GROUP_PLACES.Name = "DGV_GROUP_PLACES"
            Me.DGV_GROUP_PLACES.ReadOnly = True
            Me.DGV_GROUP_PLACES.Width = 27
            '
            'DGV_GROUP_TRACK
            '
            Me.DGV_GROUP_TRACK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_GROUP_TRACK.HeaderText = "GT"
            Me.DGV_GROUP_TRACK.Name = "DGV_GROUP_TRACK"
            Me.DGV_GROUP_TRACK.ReadOnly = True
            Me.DGV_GROUP_TRACK.Width = 25
            '
            'DGV_GROUP_TRACK_WINS
            '
            Me.DGV_GROUP_TRACK_WINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_GROUP_TRACK_WINS.HeaderText = "GTW"
            Me.DGV_GROUP_TRACK_WINS.Name = "DGV_GROUP_TRACK_WINS"
            Me.DGV_GROUP_TRACK_WINS.ReadOnly = True
            Me.DGV_GROUP_TRACK_WINS.Width = 35
            '
            'DGV_GROUP_TRACK_PLACES
            '
            Me.DGV_GROUP_TRACK_PLACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_GROUP_TRACK_PLACES.DividerWidth = 1
            Me.DGV_GROUP_TRACK_PLACES.HeaderText = "GTP"
            Me.DGV_GROUP_TRACK_PLACES.Name = "DGV_GROUP_TRACK_PLACES"
            Me.DGV_GROUP_TRACK_PLACES.ReadOnly = True
            Me.DGV_GROUP_TRACK_PLACES.Width = 32
            '
            'DGV_GROUP_WEATHER
            '
            Me.DGV_GROUP_WEATHER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_GROUP_WEATHER.HeaderText = "GWEA"
            Me.DGV_GROUP_WEATHER.Name = "DGV_GROUP_WEATHER"
            Me.DGV_GROUP_WEATHER.ReadOnly = True
            Me.DGV_GROUP_WEATHER.Width = 41
            '
            'DGV_GROUP_WEATHER_WINS
            '
            Me.DGV_GROUP_WEATHER_WINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_GROUP_WEATHER_WINS.HeaderText = "GWEAW"
            Me.DGV_GROUP_WEATHER_WINS.Name = "DGV_GROUP_WEATHER_WINS"
            Me.DGV_GROUP_WEATHER_WINS.ReadOnly = True
            Me.DGV_GROUP_WEATHER_WINS.Width = 51
            '
            'DGV_GROUP_WEATHER_PLACES
            '
            Me.DGV_GROUP_WEATHER_PLACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            Me.DGV_GROUP_WEATHER_PLACES.DividerWidth = 2
            Me.DGV_GROUP_WEATHER_PLACES.HeaderText = "GWEAP"
            Me.DGV_GROUP_WEATHER_PLACES.Name = "DGV_GROUP_WEATHER_PLACES"
            Me.DGV_GROUP_WEATHER_PLACES.ReadOnly = True
            Me.DGV_GROUP_WEATHER_PLACES.Width = 49
            '
            'DGV_NAME
            '
            Me.DGV_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_NAME.DefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_NAME.HeaderText = "NAME"
            Me.DGV_NAME.Name = "DGV_NAME"
            Me.DGV_NAME.ReadOnly = True
            Me.DGV_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
            Me.DGV_NAME.ToolTipText = "NAME OF RUNNER"
            '
            'UC_Favourites
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.SystemColors.AppWorkspace
            Me.CausesValidation = False
            Me.Controls.Add(Me.DGV_MAIN)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_Favourites"
            Me.Size = New System.Drawing.Size(800, 300)
            CType(Me.DGV_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
            Me.CMS_DGV_MAIN.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents DGV_MAIN As System.Windows.Forms.DataGridView
        Private WithEvents CMS_DGV_MAIN As System.Windows.Forms.ContextMenuStrip
        Private WithEvents TSMI_MAIN_COPY As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DGV_NUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_FAV_DISTANCE As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_FAV_DISTANCE_WINS As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_FAV_DISTANCE_PLACES As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_FAV_DISTANCE_TRACK As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_FAV_DISTANCE_TRACK_WINS As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_FAV_DISTANCE_TRACK_PLACES As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_FAV_DISTANCE_WEATHER As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_FAV_DISTANCE_WEATHER_WINS As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_FAV_DISTANCE_WEATHER_PLACES As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_GROUP As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_GROUP_WINS As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_GROUP_PLACES As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_GROUP_TRACK As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_GROUP_TRACK_WINS As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_GROUP_TRACK_PLACES As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_GROUP_WEATHER As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_GROUP_WEATHER_WINS As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_GROUP_WEATHER_PLACES As System.Windows.Forms.DataGridViewCheckBoxColumn
        Friend WithEvents DGV_NAME As System.Windows.Forms.DataGridViewLinkColumn

    End Class
End Namespace