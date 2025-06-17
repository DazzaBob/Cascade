Namespace DisplayRace
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_RUNNERRACELIST
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                    If Not MY_DISPLAYRACE Is Nothing Then MY_DISPLAYRACE.Dispose() : MY_DISPLAYRACE = Nothing
                    If Not MY_POPUP Is Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
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
            Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.DGV = New System.Windows.Forms.DataGridView()
            Me.CMSRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.DGV_RACENAME = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.DGV_DATE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_CLASS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_BARRIER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_VENUE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_LENGTH = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_WEATHER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_TRACK = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_FINISH_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_FINISHPOSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_DISTANCE_BEHIND = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_SPEED = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_WINS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_PLACES = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_THEO_TIME = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_THEO_FINISH_POSITION = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_THEO_SPEED = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_THEO_DISTANCE_RAN = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.CMSRightClick.SuspendLayout()
            Me.SuspendLayout()
            '
            'DGV
            '
            Me.DGV.AllowUserToAddRows = False
            DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight
            DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
            Me.DGV.BackgroundColor = System.Drawing.SystemColors.Window
            Me.DGV.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            Me.DGV.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_RACENAME, Me.DGV_DATE, Me.DGV_CLASS, Me.DGV_BARRIER, Me.DGV_VENUE, Me.DGV_LENGTH, Me.DGV_WEATHER, Me.DGV_TRACK, Me.DGV_FINISH_TIME, Me.DGV_FINISHPOSITION, Me.DGV_DISTANCE_BEHIND, Me.DGV_SPEED, Me.DGV_WINS, Me.DGV_PLACES, Me.DGV_THEO_TIME, Me.DGV_THEO_FINISH_POSITION, Me.DGV_THEO_SPEED, Me.DGV_THEO_DISTANCE_RAN})
            Me.DGV.ContextMenuStrip = Me.CMSRightClick
            DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle21.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV.DefaultCellStyle = DataGridViewCellStyle21
            Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV.Location = New System.Drawing.Point(0, 0)
            Me.DGV.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV.Name = "DGV"
            Me.DGV.ReadOnly = True
            Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
            DataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle22.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle22
            DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle23.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle23
            Me.DGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
            Me.DGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV.RowTemplate.Height = 24
            Me.DGV.Size = New System.Drawing.Size(927, 416)
            Me.DGV.TabIndex = 1021
            '
            'CMSRightClick
            '
            Me.CMSRightClick.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMSRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem})
            Me.CMSRightClick.Name = "CMSRightClick"
            Me.CMSRightClick.Size = New System.Drawing.Size(100, 26)
            '
            'CopyToolStripMenuItem
            '
            Me.CopyToolStripMenuItem.Image = Nothing
            Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
            Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(99, 22)
            Me.CopyToolStripMenuItem.Text = "&Copy"
            '
            'DGV_RACENAME
            '
            Me.DGV_RACENAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_RACENAME.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_RACENAME.HeaderText = "NAME"
            Me.DGV_RACENAME.Name = "DGV_RACENAME"
            Me.DGV_RACENAME.ReadOnly = True
            Me.DGV_RACENAME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_RACENAME.ToolTipText = "RUNNER NAME"
            Me.DGV_RACENAME.Width = 40
            '
            'DGV_DATE
            '
            Me.DGV_DATE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle4.Format = "g"
            DataGridViewCellStyle4.NullValue = Nothing
            DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
            Me.DGV_DATE.DefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_DATE.HeaderText = "DATE"
            Me.DGV_DATE.Name = "DGV_DATE"
            Me.DGV_DATE.ReadOnly = True
            Me.DGV_DATE.ToolTipText = "DATE OF RACE"
            Me.DGV_DATE.Width = 54
            '
            'DGV_CLASS
            '
            Me.DGV_CLASS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.Format = "N0"
            DataGridViewCellStyle5.NullValue = "999"
            Me.DGV_CLASS.DefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_CLASS.HeaderText = "CL"
            Me.DGV_CLASS.Name = "DGV_CLASS"
            Me.DGV_CLASS.ReadOnly = True
            Me.DGV_CLASS.ToolTipText = "CLASS"
            Me.DGV_CLASS.Width = 43
            '
            'DGV_BARRIER
            '
            Me.DGV_BARRIER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.Format = "N0"
            DataGridViewCellStyle6.NullValue = "0"
            Me.DGV_BARRIER.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_BARRIER.HeaderText = "B"
            Me.DGV_BARRIER.Name = "DGV_BARRIER"
            Me.DGV_BARRIER.ReadOnly = True
            Me.DGV_BARRIER.ToolTipText = "BARRIER"
            Me.DGV_BARRIER.Width = 38
            '
            'DGV_VENUE
            '
            Me.DGV_VENUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.NullValue = "-"
            Me.DGV_VENUE.DefaultCellStyle = DataGridViewCellStyle7
            Me.DGV_VENUE.HeaderText = "VENUE"
            Me.DGV_VENUE.Name = "DGV_VENUE"
            Me.DGV_VENUE.ReadOnly = True
            Me.DGV_VENUE.ToolTipText = "VENUE"
            Me.DGV_VENUE.Width = 62
            '
            'DGV_LENGTH
            '
            Me.DGV_LENGTH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.Format = "N0"
            DataGridViewCellStyle8.NullValue = "0"
            Me.DGV_LENGTH.DefaultCellStyle = DataGridViewCellStyle8
            Me.DGV_LENGTH.HeaderText = "LEN"
            Me.DGV_LENGTH.Name = "DGV_LENGTH"
            Me.DGV_LENGTH.ReadOnly = True
            Me.DGV_LENGTH.ToolTipText = "LENGTH"
            Me.DGV_LENGTH.Width = 49
            '
            'DGV_WEATHER
            '
            Me.DGV_WEATHER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_WEATHER.DefaultCellStyle = DataGridViewCellStyle9
            Me.DGV_WEATHER.HeaderText = "WEATHER"
            Me.DGV_WEATHER.Name = "DGV_WEATHER"
            Me.DGV_WEATHER.ReadOnly = True
            Me.DGV_WEATHER.ToolTipText = "WEATHER CONDITIONS"
            Me.DGV_WEATHER.Width = 75
            '
            'DGV_TRACK
            '
            Me.DGV_TRACK.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_TRACK.DefaultCellStyle = DataGridViewCellStyle10
            Me.DGV_TRACK.HeaderText = "TRACK"
            Me.DGV_TRACK.Name = "DGV_TRACK"
            Me.DGV_TRACK.ReadOnly = True
            Me.DGV_TRACK.ToolTipText = "TRACK CONDITIONS"
            Me.DGV_TRACK.Width = 61
            '
            'DGV_FINISH_TIME
            '
            Me.DGV_FINISH_TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.Format = "N4"
            DataGridViewCellStyle11.NullValue = "0"
            Me.DGV_FINISH_TIME.DefaultCellStyle = DataGridViewCellStyle11
            Me.DGV_FINISH_TIME.HeaderText = "F-T"
            Me.DGV_FINISH_TIME.Name = "DGV_FINISH_TIME"
            Me.DGV_FINISH_TIME.ReadOnly = True
            Me.DGV_FINISH_TIME.ToolTipText = "FINISH TIME"
            Me.DGV_FINISH_TIME.Width = 45
            '
            'DGV_FINISHPOSITION
            '
            Me.DGV_FINISHPOSITION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.Format = "N0"
            DataGridViewCellStyle12.NullValue = "0"
            Me.DGV_FINISHPOSITION.DefaultCellStyle = DataGridViewCellStyle12
            Me.DGV_FINISHPOSITION.HeaderText = "F-P"
            Me.DGV_FINISHPOSITION.Name = "DGV_FINISHPOSITION"
            Me.DGV_FINISHPOSITION.ReadOnly = True
            Me.DGV_FINISHPOSITION.ToolTipText = "FINISH POSITION"
            Me.DGV_FINISHPOSITION.Width = 46
            '
            'DGV_DISTANCE_BEHIND
            '
            Me.DGV_DISTANCE_BEHIND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.Format = "N4"
            DataGridViewCellStyle13.NullValue = "0"
            Me.DGV_DISTANCE_BEHIND.DefaultCellStyle = DataGridViewCellStyle13
            Me.DGV_DISTANCE_BEHIND.HeaderText = "D-B"
            Me.DGV_DISTANCE_BEHIND.Name = "DGV_DISTANCE_BEHIND"
            Me.DGV_DISTANCE_BEHIND.ReadOnly = True
            Me.DGV_DISTANCE_BEHIND.ToolTipText = "DISTANCE BEHIND"
            Me.DGV_DISTANCE_BEHIND.Width = 48
            '
            'DGV_SPEED
            '
            Me.DGV_SPEED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.Format = "N4"
            DataGridViewCellStyle14.NullValue = "0.0000"
            Me.DGV_SPEED.DefaultCellStyle = DataGridViewCellStyle14
            Me.DGV_SPEED.HeaderText = "SPEED"
            Me.DGV_SPEED.Name = "DGV_SPEED"
            Me.DGV_SPEED.ReadOnly = True
            Me.DGV_SPEED.Width = 60
            '
            'DGV_WINS
            '
            Me.DGV_WINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.Format = "C2"
            DataGridViewCellStyle15.NullValue = "0.00"
            Me.DGV_WINS.DefaultCellStyle = DataGridViewCellStyle15
            Me.DGV_WINS.HeaderText = "P-W"
            Me.DGV_WINS.Name = "DGV_WINS"
            Me.DGV_WINS.ReadOnly = True
            Me.DGV_WINS.ToolTipText = "PAID WINS"
            Me.DGV_WINS.Width = 51
            '
            'DGV_PLACES
            '
            Me.DGV_PLACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.Format = "C2"
            DataGridViewCellStyle16.NullValue = "0.00"
            Me.DGV_PLACES.DefaultCellStyle = DataGridViewCellStyle16
            Me.DGV_PLACES.HeaderText = "P-P"
            Me.DGV_PLACES.Name = "DGV_PLACES"
            Me.DGV_PLACES.ReadOnly = True
            Me.DGV_PLACES.ToolTipText = "PAID PLACES"
            Me.DGV_PLACES.Width = 47
            '
            'DGV_THEO_TIME
            '
            Me.DGV_THEO_TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.Format = "N4"
            DataGridViewCellStyle17.NullValue = "0"
            Me.DGV_THEO_TIME.DefaultCellStyle = DataGridViewCellStyle17
            Me.DGV_THEO_TIME.HeaderText = "T-T"
            Me.DGV_THEO_TIME.Name = "DGV_THEO_TIME"
            Me.DGV_THEO_TIME.ReadOnly = True
            Me.DGV_THEO_TIME.ToolTipText = "THEO TIME"
            Me.DGV_THEO_TIME.Width = 44
            '
            'DGV_THEO_FINISH_POSITION
            '
            Me.DGV_THEO_FINISH_POSITION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.Format = "N0"
            DataGridViewCellStyle18.NullValue = "0"
            Me.DGV_THEO_FINISH_POSITION.DefaultCellStyle = DataGridViewCellStyle18
            Me.DGV_THEO_FINISH_POSITION.HeaderText = "T-F-P"
            Me.DGV_THEO_FINISH_POSITION.Name = "DGV_THEO_FINISH_POSITION"
            Me.DGV_THEO_FINISH_POSITION.ReadOnly = True
            Me.DGV_THEO_FINISH_POSITION.ToolTipText = "THEO FINISH POSITION"
            Me.DGV_THEO_FINISH_POSITION.Width = 53
            '
            'DGV_THEO_SPEED
            '
            Me.DGV_THEO_SPEED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle19.Format = "N4"
            DataGridViewCellStyle19.NullValue = "0"
            Me.DGV_THEO_SPEED.DefaultCellStyle = DataGridViewCellStyle19
            Me.DGV_THEO_SPEED.HeaderText = "T-S"
            Me.DGV_THEO_SPEED.Name = "DGV_THEO_SPEED"
            Me.DGV_THEO_SPEED.ReadOnly = True
            Me.DGV_THEO_SPEED.ToolTipText = "THEO SPEED"
            Me.DGV_THEO_SPEED.Width = 44
            '
            'DGV_THEO_DISTANCE_RAN
            '
            Me.DGV_THEO_DISTANCE_RAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle20.Format = "N4"
            DataGridViewCellStyle20.NullValue = "0"
            Me.DGV_THEO_DISTANCE_RAN.DefaultCellStyle = DataGridViewCellStyle20
            Me.DGV_THEO_DISTANCE_RAN.HeaderText = "T-D-R"
            Me.DGV_THEO_DISTANCE_RAN.Name = "DGV_THEO_DISTANCE_RAN"
            Me.DGV_THEO_DISTANCE_RAN.ReadOnly = True
            Me.DGV_THEO_DISTANCE_RAN.ToolTipText = "THEO DISTANCE RAN"
            Me.DGV_THEO_DISTANCE_RAN.Width = 55
            '
            'UC_RUNNERRACELIST
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(5.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.DGV)
            Me.Font = New System.Drawing.Font("Calibri", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
            Me.Name = "UC_RUNNERRACELIST"
            Me.Size = New System.Drawing.Size(927, 416)
            CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
            Me.CMSRightClick.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents DGV As System.Windows.Forms.DataGridView
        Private WithEvents CMSRightClick As System.Windows.Forms.ContextMenuStrip
        Private WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Friend WithEvents DGV_RACENAME As System.Windows.Forms.DataGridViewLinkColumn
        Friend WithEvents DGV_DATE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_CLASS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_BARRIER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_VENUE As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_LENGTH As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_WEATHER As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_TRACK As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_FINISH_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_FINISHPOSITION As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_DISTANCE_BEHIND As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_SPEED As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_WINS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_PLACES As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_THEO_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_THEO_FINISH_POSITION As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_THEO_SPEED As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_THEO_DISTANCE_RAN As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace