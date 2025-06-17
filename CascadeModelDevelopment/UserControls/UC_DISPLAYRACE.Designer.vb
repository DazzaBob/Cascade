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
            components = New ComponentModel.Container()
            CMSMainInformation = New ContextMenuStrip(components)
            CopyToolStripMenuItem = New ToolStripMenuItem()
            TC_MAIN = New TabControl()
            TPRACERUNNERS = New System.Windows.Forms.TabPage()
            TC_RACE_RUNNERS = New TabControl()
            TP_RACERUNNERS_MAIN = New System.Windows.Forms.TabPage()
            TC_RACERUNNERS_MAIN = New TabControl()
            TP_RACERUNNERS_MAIN_DISTANCE = New System.Windows.Forms.TabPage()
            SC_RACERUNNERS_MAIN_DISTANCE = New SplitContainer()
            GB_RACERUNNERS_MAIN_DISTANCE = New GroupBox()
            TP_RACERUNNERS_MAIN_GROUP = New System.Windows.Forms.TabPage()
            SC_RACERUNNERS_MAIN_GROUP = New SplitContainer()
            GB_RACERUNNERS_MAIN_GROUP = New GroupBox()
            TP_RACERUNNERS_MAIN_OVERALL = New System.Windows.Forms.TabPage()
            SC_RACERUNNERS_MAIN_OVERALL = New SplitContainer()
            GB_RACERUNNERS_MAIN_OVERALL = New GroupBox()
            TP_RACERUNNERS_RACEBARRIER = New System.Windows.Forms.TabPage()
            TP_RESULTS = New System.Windows.Forms.TabPage()
            TP_MODELS = New System.Windows.Forms.TabPage()
            TP_BARRIER = New System.Windows.Forms.TabPage()
            TC_BARRIER = New TabControl()
            TP_BARRIER_ALL = New System.Windows.Forms.TabPage()
            TP_BARRIER_90DAYS = New System.Windows.Forms.TabPage()
            TP_BARRIER_180DAYS = New System.Windows.Forms.TabPage()
            TP_BARRIER_270DAYS = New System.Windows.Forms.TabPage()
            CMSMainInformation.SuspendLayout()
            TC_MAIN.SuspendLayout()
            TPRACERUNNERS.SuspendLayout()
            TC_RACE_RUNNERS.SuspendLayout()
            TP_RACERUNNERS_MAIN.SuspendLayout()
            TC_RACERUNNERS_MAIN.SuspendLayout()
            TP_RACERUNNERS_MAIN_DISTANCE.SuspendLayout()
            CType(SC_RACERUNNERS_MAIN_DISTANCE, ComponentModel.ISupportInitialize).BeginInit()
            SC_RACERUNNERS_MAIN_DISTANCE.Panel2.SuspendLayout()
            SC_RACERUNNERS_MAIN_DISTANCE.SuspendLayout()
            TP_RACERUNNERS_MAIN_GROUP.SuspendLayout()
            CType(SC_RACERUNNERS_MAIN_GROUP, ComponentModel.ISupportInitialize).BeginInit()
            SC_RACERUNNERS_MAIN_GROUP.Panel2.SuspendLayout()
            SC_RACERUNNERS_MAIN_GROUP.SuspendLayout()
            TP_RACERUNNERS_MAIN_OVERALL.SuspendLayout()
            CType(SC_RACERUNNERS_MAIN_OVERALL, ComponentModel.ISupportInitialize).BeginInit()
            SC_RACERUNNERS_MAIN_OVERALL.Panel2.SuspendLayout()
            SC_RACERUNNERS_MAIN_OVERALL.SuspendLayout()
            TP_BARRIER.SuspendLayout()
            TC_BARRIER.SuspendLayout()
            SuspendLayout()
            ' 
            ' CMSMainInformation
            ' 
            CMSMainInformation.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
            CMSMainInformation.ImageScalingSize = New Size(40, 40)
            CMSMainInformation.Items.AddRange(New ToolStripItem() {CopyToolStripMenuItem})
            CMSMainInformation.Name = "CMSMainInformation"
            CMSMainInformation.Size = New Size(162, 50)
            ' 
            ' CopyToolStripMenuItem
            ' 
            CopyToolStripMenuItem.ImageTransparentColor = Color.Magenta
            CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
            CopyToolStripMenuItem.Size = New Size(161, 46)
            CopyToolStripMenuItem.Text = "Copy"
            ' 
            ' TC_MAIN
            ' 
            TC_MAIN.Controls.Add(TPRACERUNNERS)
            TC_MAIN.Controls.Add(TP_RESULTS)
            TC_MAIN.Controls.Add(TP_MODELS)
            TC_MAIN.Controls.Add(TP_BARRIER)
            TC_MAIN.Dock = DockStyle.Fill
            TC_MAIN.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
            TC_MAIN.HotTrack = True
            TC_MAIN.Location = New Point(0, 0)
            TC_MAIN.Margin = New Padding(0)
            TC_MAIN.Name = "TC_MAIN"
            TC_MAIN.Padding = New Point(0, 0)
            TC_MAIN.SelectedIndex = 0
            TC_MAIN.Size = New Size(2128, 935)
            TC_MAIN.TabIndex = 39
            ' 
            ' TPRACERUNNERS
            ' 
            TPRACERUNNERS.Controls.Add(TC_RACE_RUNNERS)
            TPRACERUNNERS.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
            TPRACERUNNERS.Location = New Point(10, 60)
            TPRACERUNNERS.Margin = New Padding(0)
            TPRACERUNNERS.Name = "TPRACERUNNERS"
            TPRACERUNNERS.Size = New Size(2108, 865)
            TPRACERUNNERS.TabIndex = 0
            TPRACERUNNERS.Text = "RACE RUNNERS"
            TPRACERUNNERS.ToolTipText = "Information is displayed for the CURRENT RACE for this VENUE, DISTANCE"
            TPRACERUNNERS.UseVisualStyleBackColor = True
            ' 
            ' TC_RACE_RUNNERS
            ' 
            TC_RACE_RUNNERS.Alignment = TabAlignment.Bottom
            TC_RACE_RUNNERS.Controls.Add(TP_RACERUNNERS_MAIN)
            TC_RACE_RUNNERS.Controls.Add(TP_RACERUNNERS_RACEBARRIER)
            TC_RACE_RUNNERS.Dock = DockStyle.Fill
            TC_RACE_RUNNERS.Location = New Point(0, 0)
            TC_RACE_RUNNERS.Margin = New Padding(0)
            TC_RACE_RUNNERS.Name = "TC_RACE_RUNNERS"
            TC_RACE_RUNNERS.Padding = New Point(0, 0)
            TC_RACE_RUNNERS.SelectedIndex = 0
            TC_RACE_RUNNERS.Size = New Size(2108, 865)
            TC_RACE_RUNNERS.TabIndex = 0
            ' 
            ' TP_RACERUNNERS_MAIN
            ' 
            TP_RACERUNNERS_MAIN.Controls.Add(TC_RACERUNNERS_MAIN)
            TP_RACERUNNERS_MAIN.Location = New Point(10, 10)
            TP_RACERUNNERS_MAIN.Margin = New Padding(0)
            TP_RACERUNNERS_MAIN.Name = "TP_RACERUNNERS_MAIN"
            TP_RACERUNNERS_MAIN.Size = New Size(2088, 795)
            TP_RACERUNNERS_MAIN.TabIndex = 0
            TP_RACERUNNERS_MAIN.Text = "MAIN INFORMATION"
            TP_RACERUNNERS_MAIN.UseVisualStyleBackColor = True
            ' 
            ' TC_RACERUNNERS_MAIN
            ' 
            TC_RACERUNNERS_MAIN.Controls.Add(TP_RACERUNNERS_MAIN_DISTANCE)
            TC_RACERUNNERS_MAIN.Controls.Add(TP_RACERUNNERS_MAIN_GROUP)
            TC_RACERUNNERS_MAIN.Controls.Add(TP_RACERUNNERS_MAIN_OVERALL)
            TC_RACERUNNERS_MAIN.Dock = DockStyle.Fill
            TC_RACERUNNERS_MAIN.Location = New Point(0, 0)
            TC_RACERUNNERS_MAIN.Margin = New Padding(0)
            TC_RACERUNNERS_MAIN.Name = "TC_RACERUNNERS_MAIN"
            TC_RACERUNNERS_MAIN.Padding = New Point(0, 0)
            TC_RACERUNNERS_MAIN.SelectedIndex = 0
            TC_RACERUNNERS_MAIN.Size = New Size(2088, 795)
            TC_RACERUNNERS_MAIN.TabIndex = 0
            ' 
            ' TP_RACERUNNERS_MAIN_DISTANCE
            ' 
            TP_RACERUNNERS_MAIN_DISTANCE.Controls.Add(SC_RACERUNNERS_MAIN_DISTANCE)
            TP_RACERUNNERS_MAIN_DISTANCE.Location = New Point(10, 60)
            TP_RACERUNNERS_MAIN_DISTANCE.Margin = New Padding(0)
            TP_RACERUNNERS_MAIN_DISTANCE.Name = "TP_RACERUNNERS_MAIN_DISTANCE"
            TP_RACERUNNERS_MAIN_DISTANCE.Size = New Size(2068, 725)
            TP_RACERUNNERS_MAIN_DISTANCE.TabIndex = 0
            TP_RACERUNNERS_MAIN_DISTANCE.Text = "DISTANCE"
            TP_RACERUNNERS_MAIN_DISTANCE.UseVisualStyleBackColor = True
            ' 
            ' SC_RACERUNNERS_MAIN_DISTANCE
            ' 
            SC_RACERUNNERS_MAIN_DISTANCE.Dock = DockStyle.Fill
            SC_RACERUNNERS_MAIN_DISTANCE.Location = New Point(0, 0)
            SC_RACERUNNERS_MAIN_DISTANCE.Margin = New Padding(0)
            SC_RACERUNNERS_MAIN_DISTANCE.Name = "SC_RACERUNNERS_MAIN_DISTANCE"
            SC_RACERUNNERS_MAIN_DISTANCE.Orientation = Orientation.Horizontal
            ' 
            ' SC_RACERUNNERS_MAIN_DISTANCE.Panel2
            ' 
            SC_RACERUNNERS_MAIN_DISTANCE.Panel2.Controls.Add(GB_RACERUNNERS_MAIN_DISTANCE)
            SC_RACERUNNERS_MAIN_DISTANCE.Size = New Size(2068, 725)
            SC_RACERUNNERS_MAIN_DISTANCE.SplitterDistance = 333
            SC_RACERUNNERS_MAIN_DISTANCE.TabIndex = 0
            ' 
            ' GB_RACERUNNERS_MAIN_DISTANCE
            ' 
            GB_RACERUNNERS_MAIN_DISTANCE.Dock = DockStyle.Fill
            GB_RACERUNNERS_MAIN_DISTANCE.Location = New Point(0, 0)
            GB_RACERUNNERS_MAIN_DISTANCE.Margin = New Padding(0)
            GB_RACERUNNERS_MAIN_DISTANCE.Name = "GB_RACERUNNERS_MAIN_DISTANCE"
            GB_RACERUNNERS_MAIN_DISTANCE.Padding = New Padding(0)
            GB_RACERUNNERS_MAIN_DISTANCE.Size = New Size(2068, 388)
            GB_RACERUNNERS_MAIN_DISTANCE.TabIndex = 0
            GB_RACERUNNERS_MAIN_DISTANCE.TabStop = False
            GB_RACERUNNERS_MAIN_DISTANCE.Text = "THEORETICAL"
            ' 
            ' TP_RACERUNNERS_MAIN_GROUP
            ' 
            TP_RACERUNNERS_MAIN_GROUP.Controls.Add(SC_RACERUNNERS_MAIN_GROUP)
            TP_RACERUNNERS_MAIN_GROUP.Location = New Point(10, 62)
            TP_RACERUNNERS_MAIN_GROUP.Margin = New Padding(0)
            TP_RACERUNNERS_MAIN_GROUP.Name = "TP_RACERUNNERS_MAIN_GROUP"
            TP_RACERUNNERS_MAIN_GROUP.Size = New Size(702, 256)
            TP_RACERUNNERS_MAIN_GROUP.TabIndex = 1
            TP_RACERUNNERS_MAIN_GROUP.Text = "GROUP"
            TP_RACERUNNERS_MAIN_GROUP.UseVisualStyleBackColor = True
            ' 
            ' SC_RACERUNNERS_MAIN_GROUP
            ' 
            SC_RACERUNNERS_MAIN_GROUP.Dock = DockStyle.Fill
            SC_RACERUNNERS_MAIN_GROUP.Location = New Point(0, 0)
            SC_RACERUNNERS_MAIN_GROUP.Margin = New Padding(0)
            SC_RACERUNNERS_MAIN_GROUP.Name = "SC_RACERUNNERS_MAIN_GROUP"
            SC_RACERUNNERS_MAIN_GROUP.Orientation = Orientation.Horizontal
            ' 
            ' SC_RACERUNNERS_MAIN_GROUP.Panel2
            ' 
            SC_RACERUNNERS_MAIN_GROUP.Panel2.Controls.Add(GB_RACERUNNERS_MAIN_GROUP)
            SC_RACERUNNERS_MAIN_GROUP.Size = New Size(702, 256)
            SC_RACERUNNERS_MAIN_GROUP.SplitterDistance = 117
            SC_RACERUNNERS_MAIN_GROUP.TabIndex = 1
            ' 
            ' GB_RACERUNNERS_MAIN_GROUP
            ' 
            GB_RACERUNNERS_MAIN_GROUP.Dock = DockStyle.Fill
            GB_RACERUNNERS_MAIN_GROUP.Location = New Point(0, 0)
            GB_RACERUNNERS_MAIN_GROUP.Margin = New Padding(0)
            GB_RACERUNNERS_MAIN_GROUP.Name = "GB_RACERUNNERS_MAIN_GROUP"
            GB_RACERUNNERS_MAIN_GROUP.Padding = New Padding(0)
            GB_RACERUNNERS_MAIN_GROUP.Size = New Size(702, 135)
            GB_RACERUNNERS_MAIN_GROUP.TabIndex = 0
            GB_RACERUNNERS_MAIN_GROUP.TabStop = False
            GB_RACERUNNERS_MAIN_GROUP.Text = "THEORETICAL"
            ' 
            ' TP_RACERUNNERS_MAIN_OVERALL
            ' 
            TP_RACERUNNERS_MAIN_OVERALL.Controls.Add(SC_RACERUNNERS_MAIN_OVERALL)
            TP_RACERUNNERS_MAIN_OVERALL.Location = New Point(10, 62)
            TP_RACERUNNERS_MAIN_OVERALL.Margin = New Padding(0)
            TP_RACERUNNERS_MAIN_OVERALL.Name = "TP_RACERUNNERS_MAIN_OVERALL"
            TP_RACERUNNERS_MAIN_OVERALL.Size = New Size(702, 256)
            TP_RACERUNNERS_MAIN_OVERALL.TabIndex = 2
            TP_RACERUNNERS_MAIN_OVERALL.Text = "OVERALL"
            TP_RACERUNNERS_MAIN_OVERALL.UseVisualStyleBackColor = True
            ' 
            ' SC_RACERUNNERS_MAIN_OVERALL
            ' 
            SC_RACERUNNERS_MAIN_OVERALL.Dock = DockStyle.Fill
            SC_RACERUNNERS_MAIN_OVERALL.Location = New Point(0, 0)
            SC_RACERUNNERS_MAIN_OVERALL.Margin = New Padding(0)
            SC_RACERUNNERS_MAIN_OVERALL.Name = "SC_RACERUNNERS_MAIN_OVERALL"
            SC_RACERUNNERS_MAIN_OVERALL.Orientation = Orientation.Horizontal
            ' 
            ' SC_RACERUNNERS_MAIN_OVERALL.Panel2
            ' 
            SC_RACERUNNERS_MAIN_OVERALL.Panel2.Controls.Add(GB_RACERUNNERS_MAIN_OVERALL)
            SC_RACERUNNERS_MAIN_OVERALL.Size = New Size(702, 256)
            SC_RACERUNNERS_MAIN_OVERALL.SplitterDistance = 117
            SC_RACERUNNERS_MAIN_OVERALL.TabIndex = 2
            ' 
            ' GB_RACERUNNERS_MAIN_OVERALL
            ' 
            GB_RACERUNNERS_MAIN_OVERALL.Dock = DockStyle.Fill
            GB_RACERUNNERS_MAIN_OVERALL.Location = New Point(0, 0)
            GB_RACERUNNERS_MAIN_OVERALL.Margin = New Padding(0)
            GB_RACERUNNERS_MAIN_OVERALL.Name = "GB_RACERUNNERS_MAIN_OVERALL"
            GB_RACERUNNERS_MAIN_OVERALL.Padding = New Padding(0)
            GB_RACERUNNERS_MAIN_OVERALL.Size = New Size(702, 135)
            GB_RACERUNNERS_MAIN_OVERALL.TabIndex = 0
            GB_RACERUNNERS_MAIN_OVERALL.TabStop = False
            GB_RACERUNNERS_MAIN_OVERALL.Text = "THEORETICAL"
            ' 
            ' TP_RACERUNNERS_RACEBARRIER
            ' 
            TP_RACERUNNERS_RACEBARRIER.Location = New Point(10, 10)
            TP_RACERUNNERS_RACEBARRIER.Margin = New Padding(0)
            TP_RACERUNNERS_RACEBARRIER.Name = "TP_RACERUNNERS_RACEBARRIER"
            TP_RACERUNNERS_RACEBARRIER.Size = New Size(2088, 795)
            TP_RACERUNNERS_RACEBARRIER.TabIndex = 1
            TP_RACERUNNERS_RACEBARRIER.Text = "RACE BARRIER INFORMATION"
            TP_RACERUNNERS_RACEBARRIER.UseVisualStyleBackColor = True
            ' 
            ' TP_RESULTS
            ' 
            TP_RESULTS.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
            TP_RESULTS.Location = New Point(10, 60)
            TP_RESULTS.Margin = New Padding(0)
            TP_RESULTS.Name = "TP_RESULTS"
            TP_RESULTS.Size = New Size(2108, 865)
            TP_RESULTS.TabIndex = 4
            TP_RESULTS.Text = "RESULTS"
            TP_RESULTS.ToolTipText = "Displays Results for this Race"
            TP_RESULTS.UseVisualStyleBackColor = True
            ' 
            ' TP_MODELS
            ' 
            TP_MODELS.Font = New Font("Calibri", 9.75F, FontStyle.Regular, GraphicsUnit.Point)
            TP_MODELS.Location = New Point(10, 60)
            TP_MODELS.Margin = New Padding(0)
            TP_MODELS.Name = "TP_MODELS"
            TP_MODELS.Size = New Size(718, 314)
            TP_MODELS.TabIndex = 1
            TP_MODELS.Text = "MODELS"
            TP_MODELS.ToolTipText = "Displays Models that have been selected for this race."
            TP_MODELS.UseVisualStyleBackColor = True
            ' 
            ' TP_BARRIER
            ' 
            TP_BARRIER.Controls.Add(TC_BARRIER)
            TP_BARRIER.Location = New Point(10, 60)
            TP_BARRIER.Margin = New Padding(0)
            TP_BARRIER.Name = "TP_BARRIER"
            TP_BARRIER.Size = New Size(718, 314)
            TP_BARRIER.TabIndex = 5
            TP_BARRIER.Text = "BARRIER"
            TP_BARRIER.ToolTipText = "Displays Barrier information for this race."
            TP_BARRIER.UseVisualStyleBackColor = True
            ' 
            ' TC_BARRIER
            ' 
            TC_BARRIER.Controls.Add(TP_BARRIER_ALL)
            TC_BARRIER.Controls.Add(TP_BARRIER_90DAYS)
            TC_BARRIER.Controls.Add(TP_BARRIER_180DAYS)
            TC_BARRIER.Controls.Add(TP_BARRIER_270DAYS)
            TC_BARRIER.Dock = DockStyle.Fill
            TC_BARRIER.Location = New Point(0, 0)
            TC_BARRIER.Margin = New Padding(0)
            TC_BARRIER.Name = "TC_BARRIER"
            TC_BARRIER.Padding = New Point(0, 0)
            TC_BARRIER.RightToLeft = RightToLeft.Yes
            TC_BARRIER.RightToLeftLayout = True
            TC_BARRIER.SelectedIndex = 0
            TC_BARRIER.Size = New Size(718, 314)
            TC_BARRIER.TabIndex = 1
            ' 
            ' TP_BARRIER_ALL
            ' 
            TP_BARRIER_ALL.Location = New Point(10, 60)
            TP_BARRIER_ALL.Margin = New Padding(0)
            TP_BARRIER_ALL.Name = "TP_BARRIER_ALL"
            TP_BARRIER_ALL.RightToLeft = RightToLeft.No
            TP_BARRIER_ALL.Size = New Size(698, 244)
            TP_BARRIER_ALL.TabIndex = 0
            TP_BARRIER_ALL.Text = "LIFE TIME"
            TP_BARRIER_ALL.ToolTipText = "Displays entry information for runners in this race."
            TP_BARRIER_ALL.UseVisualStyleBackColor = True
            ' 
            ' TP_BARRIER_90DAYS
            ' 
            TP_BARRIER_90DAYS.Location = New Point(10, 62)
            TP_BARRIER_90DAYS.Margin = New Padding(0)
            TP_BARRIER_90DAYS.Name = "TP_BARRIER_90DAYS"
            TP_BARRIER_90DAYS.RightToLeft = RightToLeft.No
            TP_BARRIER_90DAYS.Size = New Size(710, 284)
            TP_BARRIER_90DAYS.TabIndex = 3
            TP_BARRIER_90DAYS.Text = "90"
            TP_BARRIER_90DAYS.UseVisualStyleBackColor = True
            ' 
            ' TP_BARRIER_180DAYS
            ' 
            TP_BARRIER_180DAYS.Location = New Point(10, 62)
            TP_BARRIER_180DAYS.Margin = New Padding(0)
            TP_BARRIER_180DAYS.Name = "TP_BARRIER_180DAYS"
            TP_BARRIER_180DAYS.RightToLeft = RightToLeft.No
            TP_BARRIER_180DAYS.Size = New Size(710, 284)
            TP_BARRIER_180DAYS.TabIndex = 6
            TP_BARRIER_180DAYS.Text = "180"
            TP_BARRIER_180DAYS.UseVisualStyleBackColor = True
            ' 
            ' TP_BARRIER_270DAYS
            ' 
            TP_BARRIER_270DAYS.BackColor = Color.Transparent
            TP_BARRIER_270DAYS.Location = New Point(10, 62)
            TP_BARRIER_270DAYS.Margin = New Padding(0)
            TP_BARRIER_270DAYS.Name = "TP_BARRIER_270DAYS"
            TP_BARRIER_270DAYS.RightToLeft = RightToLeft.No
            TP_BARRIER_270DAYS.Size = New Size(710, 284)
            TP_BARRIER_270DAYS.TabIndex = 8
            TP_BARRIER_270DAYS.Text = "270"
            ' 
            ' UC_DISPLAYRACE
            ' 
            AutoScaleDimensions = New SizeF(14F, 33F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = Color.Transparent
            Controls.Add(TC_MAIN)
            Font = New Font("Calibri", 8.25F, FontStyle.Regular, GraphicsUnit.Point)
            ForeColor = SystemColors.WindowText
            Margin = New Padding(0)
            Name = "UC_DISPLAYRACE"
            Size = New Size(2128, 935)
            CMSMainInformation.ResumeLayout(False)
            TC_MAIN.ResumeLayout(False)
            TPRACERUNNERS.ResumeLayout(False)
            TC_RACE_RUNNERS.ResumeLayout(False)
            TP_RACERUNNERS_MAIN.ResumeLayout(False)
            TC_RACERUNNERS_MAIN.ResumeLayout(False)
            TP_RACERUNNERS_MAIN_DISTANCE.ResumeLayout(False)
            SC_RACERUNNERS_MAIN_DISTANCE.Panel2.ResumeLayout(False)
            CType(SC_RACERUNNERS_MAIN_DISTANCE, ComponentModel.ISupportInitialize).EndInit()
            SC_RACERUNNERS_MAIN_DISTANCE.ResumeLayout(False)
            TP_RACERUNNERS_MAIN_GROUP.ResumeLayout(False)
            SC_RACERUNNERS_MAIN_GROUP.Panel2.ResumeLayout(False)
            CType(SC_RACERUNNERS_MAIN_GROUP, ComponentModel.ISupportInitialize).EndInit()
            SC_RACERUNNERS_MAIN_GROUP.ResumeLayout(False)
            TP_RACERUNNERS_MAIN_OVERALL.ResumeLayout(False)
            SC_RACERUNNERS_MAIN_OVERALL.Panel2.ResumeLayout(False)
            CType(SC_RACERUNNERS_MAIN_OVERALL, ComponentModel.ISupportInitialize).EndInit()
            SC_RACERUNNERS_MAIN_OVERALL.ResumeLayout(False)
            TP_BARRIER.ResumeLayout(False)
            TC_BARRIER.ResumeLayout(False)
            ResumeLayout(False)
        End Sub
        Private WithEvents CMSMainInformation As ContextMenuStrip
        Private WithEvents CopyToolStripMenuItem As ToolStripMenuItem
        Private WithEvents TC_MAIN As TabControl
        Private WithEvents TPRACERUNNERS As System.Windows.Forms.TabPage
        Private WithEvents TP_RESULTS As System.Windows.Forms.TabPage
        Private WithEvents TP_MODELS As System.Windows.Forms.TabPage
        Private WithEvents TP_BARRIER As System.Windows.Forms.TabPage
        Private WithEvents TC_RACE_RUNNERS As TabControl
        Private WithEvents TP_RACERUNNERS_MAIN As System.Windows.Forms.TabPage
        Private WithEvents TC_RACERUNNERS_MAIN As TabControl
        Private WithEvents TP_RACERUNNERS_MAIN_DISTANCE As System.Windows.Forms.TabPage
        Private WithEvents SC_RACERUNNERS_MAIN_DISTANCE As SplitContainer
        Private WithEvents GB_RACERUNNERS_MAIN_DISTANCE As GroupBox
        Private WithEvents TP_RACERUNNERS_MAIN_GROUP As System.Windows.Forms.TabPage
        Private WithEvents SC_RACERUNNERS_MAIN_GROUP As SplitContainer
        Private WithEvents GB_RACERUNNERS_MAIN_GROUP As GroupBox
        Private WithEvents TP_RACERUNNERS_MAIN_OVERALL As System.Windows.Forms.TabPage
        Private WithEvents SC_RACERUNNERS_MAIN_OVERALL As SplitContainer
        Private WithEvents GB_RACERUNNERS_MAIN_OVERALL As GroupBox
        Private WithEvents TP_RACERUNNERS_RACEBARRIER As System.Windows.Forms.TabPage
        Private WithEvents TC_BARRIER As TabControl
        Private WithEvents TP_BARRIER_ALL As System.Windows.Forms.TabPage
        Private WithEvents TP_BARRIER_90DAYS As System.Windows.Forms.TabPage
        Private WithEvents TP_BARRIER_180DAYS As System.Windows.Forms.TabPage
        Private WithEvents TP_BARRIER_270DAYS As System.Windows.Forms.TabPage
    End Class
End Namespace