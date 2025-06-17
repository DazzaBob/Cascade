Namespace ServerUI.Mappings
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class UC_VENUE_MAPPINGS
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
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("G")
            Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("H")
            Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("GR")
            Me.TV_MAPPINGS = New System.Windows.Forms.TreeView()
            Me.CMS_TV = New System.Windows.Forms.ContextMenuStrip(Me.components)
            Me.FindExistingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
            Me.ButRUNNOW = New System.Windows.Forms.Button()
            Me.CMS_TV.SuspendLayout()
            Me.SuspendLayout()
            '
            'TV_MAPPINGS
            '
            Me.TV_MAPPINGS.AllowDrop = True
            Me.TV_MAPPINGS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.TV_MAPPINGS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.TV_MAPPINGS.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TV_MAPPINGS.HideSelection = False
            Me.TV_MAPPINGS.LineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(204, Byte), Integer))
            Me.TV_MAPPINGS.Location = New System.Drawing.Point(0, 0)
            Me.TV_MAPPINGS.Margin = New System.Windows.Forms.Padding(0)
            Me.TV_MAPPINGS.Name = "TV_MAPPINGS"
            TreeNode1.Name = "G"
            TreeNode1.Tag = "G"
            TreeNode1.Text = "G"
            TreeNode2.Name = "H"
            TreeNode2.Tag = "H"
            TreeNode2.Text = "H"
            TreeNode3.Name = "GR"
            TreeNode3.Tag = "GR"
            TreeNode3.Text = "GR"
            Me.TV_MAPPINGS.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode3})
            Me.TV_MAPPINGS.Size = New System.Drawing.Size(526, 300)
            Me.TV_MAPPINGS.TabIndex = 3
            '
            'CMS_TV
            '
            Me.CMS_TV.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FindExistingToolStripMenuItem})
            Me.CMS_TV.Name = "CMS_TV"
            Me.CMS_TV.Size = New System.Drawing.Size(141, 26)
            '
            'FindExistingToolStripMenuItem
            '
            Me.FindExistingToolStripMenuItem.Name = "FindExistingToolStripMenuItem"
            Me.FindExistingToolStripMenuItem.Size = New System.Drawing.Size(140, 22)
            Me.FindExistingToolStripMenuItem.Text = "Find Existing"
            '
            'ButRUNNOW
            '
            Me.ButRUNNOW.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.ButRUNNOW.Location = New System.Drawing.Point(451, 308)
            Me.ButRUNNOW.Name = "ButRUNNOW"
            Me.ButRUNNOW.Size = New System.Drawing.Size(75, 23)
            Me.ButRUNNOW.TabIndex = 4
            Me.ButRUNNOW.Text = "RUN NOW"
            Me.ButRUNNOW.UseVisualStyleBackColor = True
            '
            'UC_VENUE_MAPPINGS
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.ButRUNNOW)
            Me.Controls.Add(Me.TV_MAPPINGS)
            Me.Name = "UC_VENUE_MAPPINGS"
            Me.Size = New System.Drawing.Size(526, 334)
            Me.CMS_TV.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub
        Private WithEvents TV_MAPPINGS As System.Windows.Forms.TreeView
        Private WithEvents ButRUNNOW As System.Windows.Forms.Button
        Private WithEvents CMS_TV As System.Windows.Forms.ContextMenuStrip
        Private WithEvents FindExistingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    End Class
End Namespace