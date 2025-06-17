Namespace DisplayRace
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_RESULTS
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                    If Not MY_POPUP Is Nothing Then MY_POPUP.Dispose() : MY_POPUP = Nothing
                    If Not MY_RRL Is Nothing Then MY_RRL.Dispose() : MY_RRL = Nothing
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
            Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
            Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
            Me.DGV = New System.Windows.Forms.DataGridView()
            Me.DGV_NUMBER = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_NAME = New System.Windows.Forms.DataGridViewLinkColumn()
            Me.DGV_BARRIER = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
            Me.CMSRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.SC_MAIN = New System.Windows.Forms.SplitContainer()
            Me.DGV_POOL = New System.Windows.Forms.DataGridView()
            Me.DGV_POOLS_NUMBERS = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_POOLS_NAME = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_POOLS_AMOUNT = New System.Windows.Forms.DataGridViewTextBoxColumn()
            Me.DGV_POOLS_TYPE = New System.Windows.Forms.DataGridViewTextBoxColumn()
            CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.CMSRightClick.SuspendLayout()
            CType(Me.SC_MAIN, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SC_MAIN.Panel1.SuspendLayout()
            Me.SC_MAIN.Panel2.SuspendLayout()
            Me.SC_MAIN.SuspendLayout()
            CType(Me.DGV_POOL, System.ComponentModel.ISupportInitialize).BeginInit()
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
            DataGridViewCellStyle2.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
            Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_NUMBER, Me.DGV_NAME, Me.DGV_BARRIER, Me.DGV_FINISH_TIME, Me.DGV_FINISHPOSITION, Me.DGV_DISTANCE_BEHIND, Me.DGV_SPEED, Me.DGV_WINS, Me.DGV_PLACES, Me.DGV_THEO_TIME, Me.DGV_THEO_FINISH_POSITION, Me.DGV_THEO_SPEED, Me.DGV_THEO_DISTANCE_RAN})
            Me.DGV.ContextMenuStrip = Me.CMSRightClick
            Me.DGV.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV.Location = New System.Drawing.Point(0, 0)
            Me.DGV.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV.Name = "DGV"
            Me.DGV.ReadOnly = True
            Me.DGV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle16.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV.RowsDefaultCellStyle = DataGridViewCellStyle16
            Me.DGV.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
            Me.DGV.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV.RowTemplate.Height = 24
            Me.DGV.RowTemplate.ReadOnly = True
            Me.DGV.Size = New System.Drawing.Size(798, 298)
            Me.DGV.TabIndex = 1022
            '
            'DGV_NUMBER
            '
            Me.DGV_NUMBER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle3.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle3.Format = "N0"
            DataGridViewCellStyle3.NullValue = "0"
            Me.DGV_NUMBER.DefaultCellStyle = DataGridViewCellStyle3
            Me.DGV_NUMBER.HeaderText = "#"
            Me.DGV_NUMBER.Name = "DGV_NUMBER"
            Me.DGV_NUMBER.ReadOnly = True
            Me.DGV_NUMBER.ToolTipText = "NUMBER"
            Me.DGV_NUMBER.Width = 37
            '
            'DGV_NAME
            '
            Me.DGV_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle4.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_NAME.DefaultCellStyle = DataGridViewCellStyle4
            Me.DGV_NAME.HeaderText = "NAME"
            Me.DGV_NAME.Name = "DGV_NAME"
            Me.DGV_NAME.ReadOnly = True
            Me.DGV_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_NAME.ToolTipText = "RUNNER NAME"
            '
            'DGV_BARRIER
            '
            Me.DGV_BARRIER.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle5.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle5.Format = "N0"
            DataGridViewCellStyle5.NullValue = "0"
            Me.DGV_BARRIER.DefaultCellStyle = DataGridViewCellStyle5
            Me.DGV_BARRIER.HeaderText = "B"
            Me.DGV_BARRIER.Name = "DGV_BARRIER"
            Me.DGV_BARRIER.ReadOnly = True
            Me.DGV_BARRIER.ToolTipText = "BARRIER"
            Me.DGV_BARRIER.Width = 38
            '
            'DGV_FINISH_TIME
            '
            Me.DGV_FINISH_TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle6.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle6.Format = "N4"
            DataGridViewCellStyle6.NullValue = "0"
            Me.DGV_FINISH_TIME.DefaultCellStyle = DataGridViewCellStyle6
            Me.DGV_FINISH_TIME.HeaderText = "F-T"
            Me.DGV_FINISH_TIME.Name = "DGV_FINISH_TIME"
            Me.DGV_FINISH_TIME.ReadOnly = True
            Me.DGV_FINISH_TIME.ToolTipText = "FINISH TIME"
            Me.DGV_FINISH_TIME.Width = 45
            '
            'DGV_FINISHPOSITION
            '
            Me.DGV_FINISHPOSITION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle7.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle7.Format = "N0"
            DataGridViewCellStyle7.NullValue = "0"
            Me.DGV_FINISHPOSITION.DefaultCellStyle = DataGridViewCellStyle7
            Me.DGV_FINISHPOSITION.HeaderText = "F-P"
            Me.DGV_FINISHPOSITION.Name = "DGV_FINISHPOSITION"
            Me.DGV_FINISHPOSITION.ReadOnly = True
            Me.DGV_FINISHPOSITION.ToolTipText = "FINISH POSITION"
            Me.DGV_FINISHPOSITION.Width = 46
            '
            'DGV_DISTANCE_BEHIND
            '
            Me.DGV_DISTANCE_BEHIND.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle8.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle8.Format = "N4"
            DataGridViewCellStyle8.NullValue = "0"
            Me.DGV_DISTANCE_BEHIND.DefaultCellStyle = DataGridViewCellStyle8
            Me.DGV_DISTANCE_BEHIND.HeaderText = "D-B"
            Me.DGV_DISTANCE_BEHIND.Name = "DGV_DISTANCE_BEHIND"
            Me.DGV_DISTANCE_BEHIND.ReadOnly = True
            Me.DGV_DISTANCE_BEHIND.ToolTipText = "DISTANCE BEHIND"
            Me.DGV_DISTANCE_BEHIND.Width = 48
            '
            'DGV_SPEED
            '
            Me.DGV_SPEED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle9.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle9.Format = "N4"
            DataGridViewCellStyle9.NullValue = "0"
            Me.DGV_SPEED.DefaultCellStyle = DataGridViewCellStyle9
            Me.DGV_SPEED.HeaderText = "SPEED"
            Me.DGV_SPEED.Name = "DGV_SPEED"
            Me.DGV_SPEED.ReadOnly = True
            Me.DGV_SPEED.ToolTipText = "SPEED"
            Me.DGV_SPEED.Width = 60
            '
            'DGV_WINS
            '
            Me.DGV_WINS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle10.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle10.Format = "C2"
            DataGridViewCellStyle10.NullValue = "0.00"
            Me.DGV_WINS.DefaultCellStyle = DataGridViewCellStyle10
            Me.DGV_WINS.HeaderText = "P-W"
            Me.DGV_WINS.Name = "DGV_WINS"
            Me.DGV_WINS.ReadOnly = True
            Me.DGV_WINS.ToolTipText = "PAID WINS"
            Me.DGV_WINS.Width = 51
            '
            'DGV_PLACES
            '
            Me.DGV_PLACES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle11.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle11.Format = "C2"
            DataGridViewCellStyle11.NullValue = "0.00"
            Me.DGV_PLACES.DefaultCellStyle = DataGridViewCellStyle11
            Me.DGV_PLACES.HeaderText = "P-P"
            Me.DGV_PLACES.Name = "DGV_PLACES"
            Me.DGV_PLACES.ReadOnly = True
            Me.DGV_PLACES.ToolTipText = "PAID PLACES"
            Me.DGV_PLACES.Width = 47
            '
            'DGV_THEO_TIME
            '
            Me.DGV_THEO_TIME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle12.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle12.Format = "N4"
            DataGridViewCellStyle12.NullValue = "0"
            Me.DGV_THEO_TIME.DefaultCellStyle = DataGridViewCellStyle12
            Me.DGV_THEO_TIME.HeaderText = "T-T"
            Me.DGV_THEO_TIME.Name = "DGV_THEO_TIME"
            Me.DGV_THEO_TIME.ReadOnly = True
            Me.DGV_THEO_TIME.ToolTipText = "THEO TIME"
            Me.DGV_THEO_TIME.Width = 44
            '
            'DGV_THEO_FINISH_POSITION
            '
            Me.DGV_THEO_FINISH_POSITION.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle13.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle13.Format = "N0"
            DataGridViewCellStyle13.NullValue = "0"
            Me.DGV_THEO_FINISH_POSITION.DefaultCellStyle = DataGridViewCellStyle13
            Me.DGV_THEO_FINISH_POSITION.HeaderText = "T-F-P"
            Me.DGV_THEO_FINISH_POSITION.Name = "DGV_THEO_FINISH_POSITION"
            Me.DGV_THEO_FINISH_POSITION.ReadOnly = True
            Me.DGV_THEO_FINISH_POSITION.ToolTipText = "THEO FINISH POSITION"
            Me.DGV_THEO_FINISH_POSITION.Width = 53
            '
            'DGV_THEO_SPEED
            '
            Me.DGV_THEO_SPEED.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle14.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle14.Format = "N4"
            DataGridViewCellStyle14.NullValue = "0"
            Me.DGV_THEO_SPEED.DefaultCellStyle = DataGridViewCellStyle14
            Me.DGV_THEO_SPEED.HeaderText = "T-S"
            Me.DGV_THEO_SPEED.Name = "DGV_THEO_SPEED"
            Me.DGV_THEO_SPEED.ReadOnly = True
            Me.DGV_THEO_SPEED.ToolTipText = "THEO SPEED"
            Me.DGV_THEO_SPEED.Width = 44
            '
            'DGV_THEO_DISTANCE_RAN
            '
            Me.DGV_THEO_DISTANCE_RAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle15.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle15.Format = "N4"
            DataGridViewCellStyle15.NullValue = "0"
            Me.DGV_THEO_DISTANCE_RAN.DefaultCellStyle = DataGridViewCellStyle15
            Me.DGV_THEO_DISTANCE_RAN.HeaderText = "T-D-R"
            Me.DGV_THEO_DISTANCE_RAN.Name = "DGV_THEO_DISTANCE_RAN"
            Me.DGV_THEO_DISTANCE_RAN.ReadOnly = True
            Me.DGV_THEO_DISTANCE_RAN.ToolTipText = "THEO DISTANCE RAN"
            Me.DGV_THEO_DISTANCE_RAN.Width = 55
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
            'SC_MAIN
            '
            Me.SC_MAIN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.SC_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SC_MAIN.Location = New System.Drawing.Point(0, 0)
            Me.SC_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.SC_MAIN.Name = "SC_MAIN"
            Me.SC_MAIN.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SC_MAIN.Panel1
            '
            Me.SC_MAIN.Panel1.Controls.Add(Me.DGV)
            '
            'SC_MAIN.Panel2
            '
            Me.SC_MAIN.Panel2.Controls.Add(Me.DGV_POOL)
            Me.SC_MAIN.Size = New System.Drawing.Size(800, 600)
            Me.SC_MAIN.SplitterDistance = 300
            Me.SC_MAIN.TabIndex = 1023
            '
            'DGV_POOL
            '
            Me.DGV_POOL.AllowUserToAddRows = False
            DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.ControlLight
            DataGridViewCellStyle17.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
            DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_POOL.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
            Me.DGV_POOL.BackgroundColor = System.Drawing.SystemColors.Window
            Me.DGV_POOL.BorderStyle = System.Windows.Forms.BorderStyle.None
            Me.DGV_POOL.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
            Me.DGV_POOL.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
            DataGridViewCellStyle18.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_POOL.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
            Me.DGV_POOL.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
            Me.DGV_POOL.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGV_POOLS_NUMBERS, Me.DGV_POOLS_NAME, Me.DGV_POOLS_AMOUNT, Me.DGV_POOLS_TYPE})
            Me.DGV_POOL.ContextMenuStrip = Me.CMSRightClick
            Me.DGV_POOL.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DGV_POOL.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
            Me.DGV_POOL.GridColor = System.Drawing.SystemColors.ControlDarkDark
            Me.DGV_POOL.Location = New System.Drawing.Point(0, 0)
            Me.DGV_POOL.Margin = New System.Windows.Forms.Padding(0)
            Me.DGV_POOL.Name = "DGV_POOL"
            Me.DGV_POOL.ReadOnly = True
            Me.DGV_POOL.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
            DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
            DataGridViewCellStyle23.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText
            DataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight
            DataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_POOL.RowsDefaultCellStyle = DataGridViewCellStyle23
            Me.DGV_POOL.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.SystemColors.Window
            Me.DGV_POOL.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_POOL.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.SystemColors.WindowText
            Me.DGV_POOL.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight
            Me.DGV_POOL.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText
            Me.DGV_POOL.RowTemplate.Height = 24
            Me.DGV_POOL.RowTemplate.ReadOnly = True
            Me.DGV_POOL.Size = New System.Drawing.Size(798, 294)
            Me.DGV_POOL.TabIndex = 1023
            '
            'DGV_POOLS_NUMBERS
            '
            Me.DGV_POOLS_NUMBERS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
            DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle19.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_POOLS_NUMBERS.DefaultCellStyle = DataGridViewCellStyle19
            Me.DGV_POOLS_NUMBERS.HeaderText = "NUMBERS"
            Me.DGV_POOLS_NUMBERS.Name = "DGV_POOLS_NUMBERS"
            Me.DGV_POOLS_NUMBERS.ReadOnly = True
            Me.DGV_POOLS_NUMBERS.ToolTipText = "NUMBERS"
            Me.DGV_POOLS_NUMBERS.Width = 77
            '
            'DGV_POOLS_NAME
            '
            Me.DGV_POOLS_NAME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
            DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle20.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_POOLS_NAME.DefaultCellStyle = DataGridViewCellStyle20
            Me.DGV_POOLS_NAME.HeaderText = "NAMES"
            Me.DGV_POOLS_NAME.Name = "DGV_POOLS_NAME"
            Me.DGV_POOLS_NAME.ReadOnly = True
            Me.DGV_POOLS_NAME.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
            Me.DGV_POOLS_NAME.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
            Me.DGV_POOLS_NAME.ToolTipText = "RUNNER NAMES"
            '
            'DGV_POOLS_AMOUNT
            '
            Me.DGV_POOLS_AMOUNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
            DataGridViewCellStyle21.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            DataGridViewCellStyle21.Format = "C2"
            DataGridViewCellStyle21.NullValue = "0"
            Me.DGV_POOLS_AMOUNT.DefaultCellStyle = DataGridViewCellStyle21
            Me.DGV_POOLS_AMOUNT.HeaderText = "AMOUNT"
            Me.DGV_POOLS_AMOUNT.Name = "DGV_POOLS_AMOUNT"
            Me.DGV_POOLS_AMOUNT.ReadOnly = True
            Me.DGV_POOLS_AMOUNT.ToolTipText = "AMOUNT"
            Me.DGV_POOLS_AMOUNT.Width = 73
            '
            'DGV_POOLS_TYPE
            '
            Me.DGV_POOLS_TYPE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
            DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
            DataGridViewCellStyle22.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.DGV_POOLS_TYPE.DefaultCellStyle = DataGridViewCellStyle22
            Me.DGV_POOLS_TYPE.HeaderText = "TYPE"
            Me.DGV_POOLS_TYPE.Name = "DGV_POOLS_TYPE"
            Me.DGV_POOLS_TYPE.ReadOnly = True
            Me.DGV_POOLS_TYPE.ToolTipText = "TYPE"
            Me.DGV_POOLS_TYPE.Width = 53
            '
            'UC_RESULTS
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.Controls.Add(Me.SC_MAIN)
            Me.DoubleBuffered = True
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_RESULTS"
            Me.Size = New System.Drawing.Size(800, 600)
            CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
            Me.CMSRightClick.ResumeLayout(False)
            Me.SC_MAIN.Panel1.ResumeLayout(False)
            Me.SC_MAIN.Panel2.ResumeLayout(False)
            CType(Me.SC_MAIN, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SC_MAIN.ResumeLayout(False)
            CType(Me.DGV_POOL, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents DGV As System.Windows.Forms.DataGridView
        Private WithEvents CMSRightClick As System.Windows.Forms.ContextMenuStrip
        Private WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents DGV_NUMBER As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_NAME As System.Windows.Forms.DataGridViewLinkColumn
        Private WithEvents DGV_BARRIER As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_FINISH_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_FINISHPOSITION As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_DISTANCE_BEHIND As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_SPEED As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_WINS As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_PLACES As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_THEO_TIME As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_THEO_FINISH_POSITION As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_THEO_SPEED As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents DGV_THEO_DISTANCE_RAN As System.Windows.Forms.DataGridViewTextBoxColumn
        Private WithEvents SC_MAIN As System.Windows.Forms.SplitContainer
        Private WithEvents DGV_POOL As System.Windows.Forms.DataGridView
        Friend WithEvents DGV_POOLS_NUMBERS As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_POOLS_NAME As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_POOLS_AMOUNT As System.Windows.Forms.DataGridViewTextBoxColumn
        Friend WithEvents DGV_POOLS_TYPE As System.Windows.Forms.DataGridViewTextBoxColumn
    End Class
End Namespace