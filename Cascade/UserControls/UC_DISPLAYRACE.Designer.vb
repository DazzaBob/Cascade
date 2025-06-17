Namespace UserControls
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_DISPLAYRACE
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                    If UC_DISTANCE IsNot Nothing Then UC_DISTANCE.Dispose() : UC_DISTANCE = Nothing
                    If UC_DISTANCE_THEO IsNot Nothing Then UC_DISTANCE_THEO.Dispose() : UC_DISTANCE_THEO = Nothing
                    If Not UC_GROUP Is Nothing Then UC_GROUP.Dispose() : UC_GROUP = Nothing
                    If Not UC_GROUP_THEO Is Nothing Then UC_GROUP_THEO.Dispose() : UC_GROUP_THEO = Nothing
                    If Not UC_OVERALL Is Nothing Then UC_OVERALL.Dispose() : UC_OVERALL = Nothing
                    If Not UC_OVERALL_THEO Is Nothing Then UC_OVERALL_THEO.Dispose() : UC_OVERALL_THEO = Nothing
                    '
                    If UC_BARRIER_ALL IsNot Nothing Then UC_BARRIER_ALL.Dispose() : UC_BARRIER_ALL = Nothing
                    If UC_BARRIER_90 IsNot Nothing Then UC_BARRIER_90.Dispose() : UC_BARRIER_90 = Nothing
                    If UC_BARRIER_180 IsNot Nothing Then UC_BARRIER_180.Dispose() : UC_BARRIER_180 = Nothing
                    If UC_BARRIER_270 IsNot Nothing Then UC_BARRIER_270.Dispose() : UC_BARRIER_270 = Nothing
                    '
                    If Not UC_RESULTS Is Nothing Then UC_RESULTS.Dispose() : UC_RESULTS = Nothing
                    If Not UC_MODELS Is Nothing Then UC_MODELS.Dispose() : UC_MODELS = Nothing
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
        '
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Me.CMSMainInformation = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.TC_MAIN = New System.Windows.Forms.TabControl()
            Me.TPRACERUNNERS = New System.Windows.Forms.TabPage()
            Me.TC_RACE_RUNNERS = New System.Windows.Forms.TabControl()
            Me.TP_RACERUNNERS_MAIN = New System.Windows.Forms.TabPage()
            Me.TC_RACERUNNERS_MAIN = New System.Windows.Forms.TabControl()
            Me.TP_RACERUNNERS_MAIN_DISTANCE = New System.Windows.Forms.TabPage()
            Me.SC_RACERUNNERS_MAIN_DISTANCE = New System.Windows.Forms.SplitContainer()
            Me.GB_RACERUNNERS_MAIN_DISTANCE = New System.Windows.Forms.GroupBox()
            Me.TP_RACERUNNERS_MAIN_GROUP = New System.Windows.Forms.TabPage()
            Me.SC_RACERUNNERS_MAIN_GROUP = New System.Windows.Forms.SplitContainer()
            Me.GB_RACERUNNERS_MAIN_GROUP = New System.Windows.Forms.GroupBox()
            Me.TP_RACERUNNERS_MAIN_OVERALL = New System.Windows.Forms.TabPage()
            Me.SC_RACERUNNERS_MAIN_OVERALL = New System.Windows.Forms.SplitContainer()
            Me.GB_RACERUNNERS_MAIN_OVERALL = New System.Windows.Forms.GroupBox()
            Me.TP_RACERUNNERS_RACEBARRIER = New System.Windows.Forms.TabPage()
            Me.TP_RESULTS = New System.Windows.Forms.TabPage()
            Me.TP_MODELS = New System.Windows.Forms.TabPage()
            Me.TP_BARRIER = New System.Windows.Forms.TabPage()
            Me.TC_BARRIER = New System.Windows.Forms.TabControl()
            Me.TP_BARRIER_ALL = New System.Windows.Forms.TabPage()
            Me.TP_BARRIER_90DAYS = New System.Windows.Forms.TabPage()
            Me.TP_BARRIER_180DAYS = New System.Windows.Forms.TabPage()
            Me.TP_BARRIER_270DAYS = New System.Windows.Forms.TabPage()
            Me.CMSMainInformation.SuspendLayout()
            Me.TC_MAIN.SuspendLayout()
            Me.TPRACERUNNERS.SuspendLayout()
            Me.TC_RACE_RUNNERS.SuspendLayout()
            Me.TP_RACERUNNERS_MAIN.SuspendLayout()
            Me.TC_RACERUNNERS_MAIN.SuspendLayout()
            Me.TP_RACERUNNERS_MAIN_DISTANCE.SuspendLayout()
            CType(Me.SC_RACERUNNERS_MAIN_DISTANCE, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SC_RACERUNNERS_MAIN_DISTANCE.Panel2.SuspendLayout()
            Me.SC_RACERUNNERS_MAIN_DISTANCE.SuspendLayout()
            Me.TP_RACERUNNERS_MAIN_GROUP.SuspendLayout()
            CType(Me.SC_RACERUNNERS_MAIN_GROUP, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SC_RACERUNNERS_MAIN_GROUP.Panel2.SuspendLayout()
            Me.SC_RACERUNNERS_MAIN_GROUP.SuspendLayout()
            Me.TP_RACERUNNERS_MAIN_OVERALL.SuspendLayout()
            CType(Me.SC_RACERUNNERS_MAIN_OVERALL, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SC_RACERUNNERS_MAIN_OVERALL.Panel2.SuspendLayout()
            Me.SC_RACERUNNERS_MAIN_OVERALL.SuspendLayout()
            Me.TP_BARRIER.SuspendLayout()
            Me.TC_BARRIER.SuspendLayout()
            Me.SuspendLayout()
            '
            'CMSMainInformation
            '
            Me.CMSMainInformation.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.CMSMainInformation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CopyToolStripMenuItem})
            Me.CMSMainInformation.Name = "CMSMainInformation"
            Me.CMSMainInformation.Size = New System.Drawing.Size(102, 26)
            '
            'CopyToolStripMenuItem
            '
            Me.CopyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
            Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
            Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
            Me.CopyToolStripMenuItem.Text = "Copy"
            '
            'TC_MAIN
            '
            Me.TC_MAIN.Controls.Add(Me.TPRACERUNNERS)
            Me.TC_MAIN.Controls.Add(Me.TP_RESULTS)
            Me.TC_MAIN.Controls.Add(Me.TP_MODELS)
            Me.TC_MAIN.Controls.Add(Me.TP_BARRIER)
            Me.TC_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_MAIN.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TC_MAIN.HotTrack = True
            Me.TC_MAIN.Location = New System.Drawing.Point(0, 0)
            Me.TC_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_MAIN.Name = "TC_MAIN"
            Me.TC_MAIN.Padding = New System.Drawing.Point(0, 0)
            Me.TC_MAIN.SelectedIndex = 0
            Me.TC_MAIN.Size = New System.Drawing.Size(738, 384)
            Me.TC_MAIN.TabIndex = 39
            '
            'TPRACERUNNERS
            '
            Me.TPRACERUNNERS.Controls.Add(Me.TC_RACE_RUNNERS)
            Me.TPRACERUNNERS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TPRACERUNNERS.Location = New System.Drawing.Point(4, 24)
            Me.TPRACERUNNERS.Margin = New System.Windows.Forms.Padding(0)
            Me.TPRACERUNNERS.Name = "TPRACERUNNERS"
            Me.TPRACERUNNERS.Size = New System.Drawing.Size(730, 356)
            Me.TPRACERUNNERS.TabIndex = 0
            Me.TPRACERUNNERS.Text = "RACE RUNNERS"
            Me.TPRACERUNNERS.ToolTipText = "Information is displayed for the CURRENT RACE for this VENUE, DISTANCE"
            Me.TPRACERUNNERS.UseVisualStyleBackColor = True
            '
            'TC_RACE_RUNNERS
            '
            Me.TC_RACE_RUNNERS.Alignment = System.Windows.Forms.TabAlignment.Bottom
            Me.TC_RACE_RUNNERS.Controls.Add(Me.TP_RACERUNNERS_MAIN)
            Me.TC_RACE_RUNNERS.Controls.Add(Me.TP_RACERUNNERS_RACEBARRIER)
            Me.TC_RACE_RUNNERS.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_RACE_RUNNERS.Location = New System.Drawing.Point(0, 0)
            Me.TC_RACE_RUNNERS.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_RACE_RUNNERS.Name = "TC_RACE_RUNNERS"
            Me.TC_RACE_RUNNERS.Padding = New System.Drawing.Point(0, 0)
            Me.TC_RACE_RUNNERS.SelectedIndex = 0
            Me.TC_RACE_RUNNERS.Size = New System.Drawing.Size(730, 356)
            Me.TC_RACE_RUNNERS.TabIndex = 0
            '
            'TP_RACERUNNERS_MAIN
            '
            Me.TP_RACERUNNERS_MAIN.Controls.Add(Me.TC_RACERUNNERS_MAIN)
            Me.TP_RACERUNNERS_MAIN.Location = New System.Drawing.Point(4, 4)
            Me.TP_RACERUNNERS_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_RACERUNNERS_MAIN.Name = "TP_RACERUNNERS_MAIN"
            Me.TP_RACERUNNERS_MAIN.Size = New System.Drawing.Size(722, 328)
            Me.TP_RACERUNNERS_MAIN.TabIndex = 0
            Me.TP_RACERUNNERS_MAIN.Text = "MAIN INFORMATION"
            Me.TP_RACERUNNERS_MAIN.UseVisualStyleBackColor = True
            '
            'TC_RACERUNNERS_MAIN
            '
            Me.TC_RACERUNNERS_MAIN.Controls.Add(Me.TP_RACERUNNERS_MAIN_DISTANCE)
            Me.TC_RACERUNNERS_MAIN.Controls.Add(Me.TP_RACERUNNERS_MAIN_GROUP)
            Me.TC_RACERUNNERS_MAIN.Controls.Add(Me.TP_RACERUNNERS_MAIN_OVERALL)
            Me.TC_RACERUNNERS_MAIN.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_RACERUNNERS_MAIN.Location = New System.Drawing.Point(0, 0)
            Me.TC_RACERUNNERS_MAIN.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_RACERUNNERS_MAIN.Name = "TC_RACERUNNERS_MAIN"
            Me.TC_RACERUNNERS_MAIN.Padding = New System.Drawing.Point(0, 0)
            Me.TC_RACERUNNERS_MAIN.SelectedIndex = 0
            Me.TC_RACERUNNERS_MAIN.Size = New System.Drawing.Size(722, 328)
            Me.TC_RACERUNNERS_MAIN.TabIndex = 0
            '
            'TP_RACERUNNERS_MAIN_DISTANCE
            '
            Me.TP_RACERUNNERS_MAIN_DISTANCE.Controls.Add(Me.SC_RACERUNNERS_MAIN_DISTANCE)
            Me.TP_RACERUNNERS_MAIN_DISTANCE.Location = New System.Drawing.Point(4, 24)
            Me.TP_RACERUNNERS_MAIN_DISTANCE.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_RACERUNNERS_MAIN_DISTANCE.Name = "TP_RACERUNNERS_MAIN_DISTANCE"
            Me.TP_RACERUNNERS_MAIN_DISTANCE.Size = New System.Drawing.Size(714, 300)
            Me.TP_RACERUNNERS_MAIN_DISTANCE.TabIndex = 0
            Me.TP_RACERUNNERS_MAIN_DISTANCE.Text = "DISTANCE"
            Me.TP_RACERUNNERS_MAIN_DISTANCE.UseVisualStyleBackColor = True
            '
            'SC_RACERUNNERS_MAIN_DISTANCE
            '
            Me.SC_RACERUNNERS_MAIN_DISTANCE.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SC_RACERUNNERS_MAIN_DISTANCE.Location = New System.Drawing.Point(0, 0)
            Me.SC_RACERUNNERS_MAIN_DISTANCE.Margin = New System.Windows.Forms.Padding(0)
            Me.SC_RACERUNNERS_MAIN_DISTANCE.Name = "SC_RACERUNNERS_MAIN_DISTANCE"
            Me.SC_RACERUNNERS_MAIN_DISTANCE.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SC_RACERUNNERS_MAIN_DISTANCE.Panel2
            '
            Me.SC_RACERUNNERS_MAIN_DISTANCE.Panel2.Controls.Add(Me.GB_RACERUNNERS_MAIN_DISTANCE)
            Me.SC_RACERUNNERS_MAIN_DISTANCE.Size = New System.Drawing.Size(714, 300)
            Me.SC_RACERUNNERS_MAIN_DISTANCE.SplitterDistance = 138
            Me.SC_RACERUNNERS_MAIN_DISTANCE.TabIndex = 0
            '
            'GB_RACERUNNERS_MAIN_DISTANCE
            '
            Me.GB_RACERUNNERS_MAIN_DISTANCE.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GB_RACERUNNERS_MAIN_DISTANCE.Location = New System.Drawing.Point(0, 0)
            Me.GB_RACERUNNERS_MAIN_DISTANCE.Margin = New System.Windows.Forms.Padding(0)
            Me.GB_RACERUNNERS_MAIN_DISTANCE.Name = "GB_RACERUNNERS_MAIN_DISTANCE"
            Me.GB_RACERUNNERS_MAIN_DISTANCE.Padding = New System.Windows.Forms.Padding(0)
            Me.GB_RACERUNNERS_MAIN_DISTANCE.Size = New System.Drawing.Size(714, 158)
            Me.GB_RACERUNNERS_MAIN_DISTANCE.TabIndex = 0
            Me.GB_RACERUNNERS_MAIN_DISTANCE.TabStop = False
            Me.GB_RACERUNNERS_MAIN_DISTANCE.Text = "THEORETICAL"
            '
            'TP_RACERUNNERS_MAIN_GROUP
            '
            Me.TP_RACERUNNERS_MAIN_GROUP.Controls.Add(Me.SC_RACERUNNERS_MAIN_GROUP)
            Me.TP_RACERUNNERS_MAIN_GROUP.Location = New System.Drawing.Point(4, 24)
            Me.TP_RACERUNNERS_MAIN_GROUP.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_RACERUNNERS_MAIN_GROUP.Name = "TP_RACERUNNERS_MAIN_GROUP"
            Me.TP_RACERUNNERS_MAIN_GROUP.Size = New System.Drawing.Size(714, 300)
            Me.TP_RACERUNNERS_MAIN_GROUP.TabIndex = 1
            Me.TP_RACERUNNERS_MAIN_GROUP.Text = "GROUP"
            Me.TP_RACERUNNERS_MAIN_GROUP.UseVisualStyleBackColor = True
            '
            'SC_RACERUNNERS_MAIN_GROUP
            '
            Me.SC_RACERUNNERS_MAIN_GROUP.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SC_RACERUNNERS_MAIN_GROUP.Location = New System.Drawing.Point(0, 0)
            Me.SC_RACERUNNERS_MAIN_GROUP.Margin = New System.Windows.Forms.Padding(0)
            Me.SC_RACERUNNERS_MAIN_GROUP.Name = "SC_RACERUNNERS_MAIN_GROUP"
            Me.SC_RACERUNNERS_MAIN_GROUP.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SC_RACERUNNERS_MAIN_GROUP.Panel2
            '
            Me.SC_RACERUNNERS_MAIN_GROUP.Panel2.Controls.Add(Me.GB_RACERUNNERS_MAIN_GROUP)
            Me.SC_RACERUNNERS_MAIN_GROUP.Size = New System.Drawing.Size(714, 300)
            Me.SC_RACERUNNERS_MAIN_GROUP.SplitterDistance = 138
            Me.SC_RACERUNNERS_MAIN_GROUP.TabIndex = 1
            '
            'GB_RACERUNNERS_MAIN_GROUP
            '
            Me.GB_RACERUNNERS_MAIN_GROUP.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GB_RACERUNNERS_MAIN_GROUP.Location = New System.Drawing.Point(0, 0)
            Me.GB_RACERUNNERS_MAIN_GROUP.Margin = New System.Windows.Forms.Padding(0)
            Me.GB_RACERUNNERS_MAIN_GROUP.Name = "GB_RACERUNNERS_MAIN_GROUP"
            Me.GB_RACERUNNERS_MAIN_GROUP.Padding = New System.Windows.Forms.Padding(0)
            Me.GB_RACERUNNERS_MAIN_GROUP.Size = New System.Drawing.Size(714, 158)
            Me.GB_RACERUNNERS_MAIN_GROUP.TabIndex = 0
            Me.GB_RACERUNNERS_MAIN_GROUP.TabStop = False
            Me.GB_RACERUNNERS_MAIN_GROUP.Text = "THEORETICAL"
            '
            'TP_RACERUNNERS_MAIN_OVERALL
            '
            Me.TP_RACERUNNERS_MAIN_OVERALL.Controls.Add(Me.SC_RACERUNNERS_MAIN_OVERALL)
            Me.TP_RACERUNNERS_MAIN_OVERALL.Location = New System.Drawing.Point(4, 24)
            Me.TP_RACERUNNERS_MAIN_OVERALL.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_RACERUNNERS_MAIN_OVERALL.Name = "TP_RACERUNNERS_MAIN_OVERALL"
            Me.TP_RACERUNNERS_MAIN_OVERALL.Size = New System.Drawing.Size(714, 300)
            Me.TP_RACERUNNERS_MAIN_OVERALL.TabIndex = 2
            Me.TP_RACERUNNERS_MAIN_OVERALL.Text = "OVERALL"
            Me.TP_RACERUNNERS_MAIN_OVERALL.UseVisualStyleBackColor = True
            '
            'SC_RACERUNNERS_MAIN_OVERALL
            '
            Me.SC_RACERUNNERS_MAIN_OVERALL.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SC_RACERUNNERS_MAIN_OVERALL.Location = New System.Drawing.Point(0, 0)
            Me.SC_RACERUNNERS_MAIN_OVERALL.Margin = New System.Windows.Forms.Padding(0)
            Me.SC_RACERUNNERS_MAIN_OVERALL.Name = "SC_RACERUNNERS_MAIN_OVERALL"
            Me.SC_RACERUNNERS_MAIN_OVERALL.Orientation = System.Windows.Forms.Orientation.Horizontal
            '
            'SC_RACERUNNERS_MAIN_OVERALL.Panel2
            '
            Me.SC_RACERUNNERS_MAIN_OVERALL.Panel2.Controls.Add(Me.GB_RACERUNNERS_MAIN_OVERALL)
            Me.SC_RACERUNNERS_MAIN_OVERALL.Size = New System.Drawing.Size(714, 300)
            Me.SC_RACERUNNERS_MAIN_OVERALL.SplitterDistance = 138
            Me.SC_RACERUNNERS_MAIN_OVERALL.TabIndex = 2
            '
            'GB_RACERUNNERS_MAIN_OVERALL
            '
            Me.GB_RACERUNNERS_MAIN_OVERALL.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GB_RACERUNNERS_MAIN_OVERALL.Location = New System.Drawing.Point(0, 0)
            Me.GB_RACERUNNERS_MAIN_OVERALL.Margin = New System.Windows.Forms.Padding(0)
            Me.GB_RACERUNNERS_MAIN_OVERALL.Name = "GB_RACERUNNERS_MAIN_OVERALL"
            Me.GB_RACERUNNERS_MAIN_OVERALL.Padding = New System.Windows.Forms.Padding(0)
            Me.GB_RACERUNNERS_MAIN_OVERALL.Size = New System.Drawing.Size(714, 158)
            Me.GB_RACERUNNERS_MAIN_OVERALL.TabIndex = 0
            Me.GB_RACERUNNERS_MAIN_OVERALL.TabStop = False
            Me.GB_RACERUNNERS_MAIN_OVERALL.Text = "THEORETICAL"
            '
            'TP_RACERUNNERS_RACEBARRIER
            '
            Me.TP_RACERUNNERS_RACEBARRIER.Location = New System.Drawing.Point(4, 4)
            Me.TP_RACERUNNERS_RACEBARRIER.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_RACERUNNERS_RACEBARRIER.Name = "TP_RACERUNNERS_RACEBARRIER"
            Me.TP_RACERUNNERS_RACEBARRIER.Size = New System.Drawing.Size(722, 328)
            Me.TP_RACERUNNERS_RACEBARRIER.TabIndex = 1
            Me.TP_RACERUNNERS_RACEBARRIER.Text = "RACE BARRIER INFORMATION"
            Me.TP_RACERUNNERS_RACEBARRIER.UseVisualStyleBackColor = True
            '
            'TP_RESULTS
            '
            Me.TP_RESULTS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TP_RESULTS.Location = New System.Drawing.Point(4, 24)
            Me.TP_RESULTS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_RESULTS.Name = "TP_RESULTS"
            Me.TP_RESULTS.Size = New System.Drawing.Size(730, 356)
            Me.TP_RESULTS.TabIndex = 4
            Me.TP_RESULTS.Text = "RESULTS"
            Me.TP_RESULTS.ToolTipText = "Displays Results for this Race"
            Me.TP_RESULTS.UseVisualStyleBackColor = True
            '
            'TP_MODELS
            '
            Me.TP_MODELS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TP_MODELS.Location = New System.Drawing.Point(4, 24)
            Me.TP_MODELS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_MODELS.Name = "TP_MODELS"
            Me.TP_MODELS.Size = New System.Drawing.Size(730, 356)
            Me.TP_MODELS.TabIndex = 1
            Me.TP_MODELS.Text = "MODELS"
            Me.TP_MODELS.ToolTipText = "Displays Models that have been selected for this race."
            Me.TP_MODELS.UseVisualStyleBackColor = True
            '
            'TP_BARRIER
            '
            Me.TP_BARRIER.Controls.Add(Me.TC_BARRIER)
            Me.TP_BARRIER.Location = New System.Drawing.Point(4, 24)
            Me.TP_BARRIER.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_BARRIER.Name = "TP_BARRIER"
            Me.TP_BARRIER.Size = New System.Drawing.Size(730, 356)
            Me.TP_BARRIER.TabIndex = 5
            Me.TP_BARRIER.Text = "BARRIER"
            Me.TP_BARRIER.ToolTipText = "Displays Barrier information for this race."
            Me.TP_BARRIER.UseVisualStyleBackColor = True
            '
            'TC_BARRIER
            '
            Me.TC_BARRIER.Controls.Add(Me.TP_BARRIER_ALL)
            Me.TC_BARRIER.Controls.Add(Me.TP_BARRIER_90DAYS)
            Me.TC_BARRIER.Controls.Add(Me.TP_BARRIER_180DAYS)
            Me.TC_BARRIER.Controls.Add(Me.TP_BARRIER_270DAYS)
            Me.TC_BARRIER.Dock = System.Windows.Forms.DockStyle.Fill
            Me.TC_BARRIER.Location = New System.Drawing.Point(0, 0)
            Me.TC_BARRIER.Margin = New System.Windows.Forms.Padding(0)
            Me.TC_BARRIER.Name = "TC_BARRIER"
            Me.TC_BARRIER.Padding = New System.Drawing.Point(0, 0)
            Me.TC_BARRIER.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.TC_BARRIER.RightToLeftLayout = True
            Me.TC_BARRIER.SelectedIndex = 0
            Me.TC_BARRIER.Size = New System.Drawing.Size(730, 356)
            Me.TC_BARRIER.TabIndex = 1
            '
            'TP_BARRIER_ALL
            '
            Me.TP_BARRIER_ALL.Location = New System.Drawing.Point(4, 24)
            Me.TP_BARRIER_ALL.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_BARRIER_ALL.Name = "TP_BARRIER_ALL"
            Me.TP_BARRIER_ALL.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_BARRIER_ALL.Size = New System.Drawing.Size(722, 328)
            Me.TP_BARRIER_ALL.TabIndex = 0
            Me.TP_BARRIER_ALL.Text = "LIFE TIME"
            Me.TP_BARRIER_ALL.ToolTipText = "Displays entry information for runners in this race."
            Me.TP_BARRIER_ALL.UseVisualStyleBackColor = True
            '
            'TP_BARRIER_90DAYS
            '
            Me.TP_BARRIER_90DAYS.Location = New System.Drawing.Point(4, 24)
            Me.TP_BARRIER_90DAYS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_BARRIER_90DAYS.Name = "TP_BARRIER_90DAYS"
            Me.TP_BARRIER_90DAYS.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_BARRIER_90DAYS.Size = New System.Drawing.Size(722, 328)
            Me.TP_BARRIER_90DAYS.TabIndex = 3
            Me.TP_BARRIER_90DAYS.Text = "90"
            Me.TP_BARRIER_90DAYS.UseVisualStyleBackColor = True
            '
            'TP_BARRIER_180DAYS
            '
            Me.TP_BARRIER_180DAYS.Location = New System.Drawing.Point(4, 24)
            Me.TP_BARRIER_180DAYS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_BARRIER_180DAYS.Name = "TP_BARRIER_180DAYS"
            Me.TP_BARRIER_180DAYS.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_BARRIER_180DAYS.Size = New System.Drawing.Size(722, 328)
            Me.TP_BARRIER_180DAYS.TabIndex = 6
            Me.TP_BARRIER_180DAYS.Text = "180"
            Me.TP_BARRIER_180DAYS.UseVisualStyleBackColor = True
            '
            'TP_BARRIER_270DAYS
            '
            Me.TP_BARRIER_270DAYS.BackColor = System.Drawing.Color.Transparent
            Me.TP_BARRIER_270DAYS.Location = New System.Drawing.Point(4, 24)
            Me.TP_BARRIER_270DAYS.Margin = New System.Windows.Forms.Padding(0)
            Me.TP_BARRIER_270DAYS.Name = "TP_BARRIER_270DAYS"
            Me.TP_BARRIER_270DAYS.RightToLeft = System.Windows.Forms.RightToLeft.No
            Me.TP_BARRIER_270DAYS.Size = New System.Drawing.Size(722, 328)
            Me.TP_BARRIER_270DAYS.TabIndex = 8
            Me.TP_BARRIER_270DAYS.Text = "270"
            '
            'UC_DISPLAYRACE
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.BackColor = System.Drawing.Color.Transparent
            Me.Controls.Add(Me.TC_MAIN)
            Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ForeColor = System.Drawing.SystemColors.WindowText
            Me.Margin = New System.Windows.Forms.Padding(0)
            Me.Name = "UC_DISPLAYRACE"
            Me.Size = New System.Drawing.Size(738, 384)
            Me.CMSMainInformation.ResumeLayout(False)
            Me.TC_MAIN.ResumeLayout(False)
            Me.TPRACERUNNERS.ResumeLayout(False)
            Me.TC_RACE_RUNNERS.ResumeLayout(False)
            Me.TP_RACERUNNERS_MAIN.ResumeLayout(False)
            Me.TC_RACERUNNERS_MAIN.ResumeLayout(False)
            Me.TP_RACERUNNERS_MAIN_DISTANCE.ResumeLayout(False)
            Me.SC_RACERUNNERS_MAIN_DISTANCE.Panel2.ResumeLayout(False)
            CType(Me.SC_RACERUNNERS_MAIN_DISTANCE, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SC_RACERUNNERS_MAIN_DISTANCE.ResumeLayout(False)
            Me.TP_RACERUNNERS_MAIN_GROUP.ResumeLayout(False)
            Me.SC_RACERUNNERS_MAIN_GROUP.Panel2.ResumeLayout(False)
            CType(Me.SC_RACERUNNERS_MAIN_GROUP, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SC_RACERUNNERS_MAIN_GROUP.ResumeLayout(False)
            Me.TP_RACERUNNERS_MAIN_OVERALL.ResumeLayout(False)
            Me.SC_RACERUNNERS_MAIN_OVERALL.Panel2.ResumeLayout(False)
            CType(Me.SC_RACERUNNERS_MAIN_OVERALL, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SC_RACERUNNERS_MAIN_OVERALL.ResumeLayout(False)
            Me.TP_BARRIER.ResumeLayout(False)
            Me.TC_BARRIER.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents CMSMainInformation As System.Windows.Forms.ContextMenuStrip
        Private WithEvents CopyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
        Private WithEvents TC_MAIN As System.Windows.Forms.TabControl
        Private WithEvents TPRACERUNNERS As System.Windows.Forms.TabPage
        Private WithEvents TP_RESULTS As System.Windows.Forms.TabPage
        Private WithEvents TP_MODELS As System.Windows.Forms.TabPage
        Private WithEvents TP_BARRIER As System.Windows.Forms.TabPage
        Private WithEvents TC_RACE_RUNNERS As System.Windows.Forms.TabControl
        Private WithEvents TP_RACERUNNERS_MAIN As System.Windows.Forms.TabPage
        Private WithEvents TC_RACERUNNERS_MAIN As System.Windows.Forms.TabControl
        Private WithEvents TP_RACERUNNERS_MAIN_DISTANCE As System.Windows.Forms.TabPage
        Private WithEvents SC_RACERUNNERS_MAIN_DISTANCE As System.Windows.Forms.SplitContainer
        Private WithEvents GB_RACERUNNERS_MAIN_DISTANCE As System.Windows.Forms.GroupBox
        Private WithEvents TP_RACERUNNERS_MAIN_GROUP As System.Windows.Forms.TabPage
        Private WithEvents SC_RACERUNNERS_MAIN_GROUP As System.Windows.Forms.SplitContainer
        Private WithEvents GB_RACERUNNERS_MAIN_GROUP As System.Windows.Forms.GroupBox
        Private WithEvents TP_RACERUNNERS_MAIN_OVERALL As System.Windows.Forms.TabPage
        Private WithEvents SC_RACERUNNERS_MAIN_OVERALL As System.Windows.Forms.SplitContainer
        Private WithEvents GB_RACERUNNERS_MAIN_OVERALL As System.Windows.Forms.GroupBox
        Private WithEvents TP_RACERUNNERS_RACEBARRIER As System.Windows.Forms.TabPage
        Private WithEvents TC_BARRIER As System.Windows.Forms.TabControl
        Private WithEvents TP_BARRIER_ALL As System.Windows.Forms.TabPage
        Private WithEvents TP_BARRIER_90DAYS As System.Windows.Forms.TabPage
        Private WithEvents TP_BARRIER_180DAYS As System.Windows.Forms.TabPage
        Private WithEvents TP_BARRIER_270DAYS As System.Windows.Forms.TabPage
    End Class
End Namespace