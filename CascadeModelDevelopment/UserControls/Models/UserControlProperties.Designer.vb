Namespace UserControls.Models
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
    Partial Class UserControlProperties
        Inherits System.Windows.Forms.UserControl

        'UserControl overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            Try
                If disposing AndAlso components IsNot Nothing Then
                    components.Dispose()
                End If
                If Me.Timer IsNot Nothing Then Me.Timer.Dispose()
                If Me._DTCountry IsNot Nothing Then Me._DTCountry.Dispose()
                If Me._DT_Venue IsNot Nothing Then Me._DT_Venue.Dispose()
                If Me._DT_Length IsNot Nothing Then Me._DT_Length.Dispose()
            Finally
                MyBase.Dispose(disposing)
            End Try
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()>
        Private Sub InitializeComponent()
            GBStatusInformation = New GroupBox()
            ComboBox_Compiled = New ComboBox()
            Label_Compiled = New Label()
            ComboBox_Status = New ComboBox()
            LabelStatus = New Label()
            TB_Version = New TextBox()
            Label_Version = New Label()
            TB_TreePath = New TextBox()
            Label_TreePath = New Label()
            TB_ParentID = New TextBox()
            Label_ParentID = New Label()
            TB_ID = New TextBox()
            Label_ID = New Label()
            GB_Model_Information = New GroupBox()
            TBName = New TextBox()
            Label_Name = New Label()
            ComboBox_Length = New ComboBox()
            ComboBox_Venue = New ComboBox()
            ComboBox_Type = New ComboBox()
            ComboBox_Country = New ComboBox()
            Label_Length = New Label()
            Label_Venue = New Label()
            Label_Type = New Label()
            Label_Country = New Label()
            GBStatusInformation.SuspendLayout()
            GB_Model_Information.SuspendLayout()
            SuspendLayout()
            ' 
            ' GBStatusInformation
            ' 
            GBStatusInformation.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            GBStatusInformation.Controls.Add(ComboBox_Compiled)
            GBStatusInformation.Controls.Add(Label_Compiled)
            GBStatusInformation.Controls.Add(ComboBox_Status)
            GBStatusInformation.Controls.Add(LabelStatus)
            GBStatusInformation.Controls.Add(TB_Version)
            GBStatusInformation.Controls.Add(Label_Version)
            GBStatusInformation.Controls.Add(TB_TreePath)
            GBStatusInformation.Controls.Add(Label_TreePath)
            GBStatusInformation.Controls.Add(TB_ParentID)
            GBStatusInformation.Controls.Add(Label_ParentID)
            GBStatusInformation.Controls.Add(TB_ID)
            GBStatusInformation.Controls.Add(Label_ID)
            GBStatusInformation.Location = New Point(0, 0)
            GBStatusInformation.Margin = New Padding(0)
            GBStatusInformation.Name = "GBStatusInformation"
            GBStatusInformation.Padding = New Padding(0)
            GBStatusInformation.Size = New Size(2088, 333)
            GBStatusInformation.TabIndex = 0
            GBStatusInformation.TabStop = False
            GBStatusInformation.Text = "Status Information"
            ' 
            ' ComboBox_Compiled
            ' 
            ComboBox_Compiled.DropDownStyle = ComboBoxStyle.DropDownList
            ComboBox_Compiled.Enabled = False
            ComboBox_Compiled.FlatStyle = FlatStyle.Flat
            ComboBox_Compiled.FormattingEnabled = True
            ComboBox_Compiled.Items.AddRange(New Object() {"True", "False"})
            ComboBox_Compiled.Location = New Point(1608, 151)
            ComboBox_Compiled.Name = "ComboBox_Compiled"
            ComboBox_Compiled.Size = New Size(387, 62)
            ComboBox_Compiled.TabIndex = 17
            ' 
            ' Label_Compiled
            ' 
            Label_Compiled.AutoSize = True
            Label_Compiled.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            Label_Compiled.Location = New Point(1377, 154)
            Label_Compiled.Margin = New Padding(0)
            Label_Compiled.Name = "Label_Compiled"
            Label_Compiled.Size = New Size(214, 54)
            Label_Compiled.TabIndex = 16
            Label_Compiled.Text = "Compiled:"
            Label_Compiled.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' ComboBox_Status
            ' 
            ComboBox_Status.DropDownStyle = ComboBoxStyle.DropDownList
            ComboBox_Status.FlatStyle = FlatStyle.Flat
            ComboBox_Status.FormattingEnabled = True
            ComboBox_Status.Items.AddRange(New Object() {"True", "False"})
            ComboBox_Status.Location = New Point(1608, 69)
            ComboBox_Status.Name = "ComboBox_Status"
            ComboBox_Status.Size = New Size(387, 62)
            ComboBox_Status.TabIndex = 15
            ' 
            ' LabelStatus
            ' 
            LabelStatus.AutoSize = True
            LabelStatus.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            LabelStatus.Location = New Point(1440, 73)
            LabelStatus.Margin = New Padding(0)
            LabelStatus.Name = "LabelStatus"
            LabelStatus.Size = New Size(151, 54)
            LabelStatus.TabIndex = 14
            LabelStatus.Text = "Status:"
            LabelStatus.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' TB_Version
            ' 
            TB_Version.Enabled = False
            TB_Version.Location = New Point(1001, 72)
            TB_Version.Margin = New Padding(0)
            TB_Version.Name = "TB_Version"
            TB_Version.Size = New Size(250, 61)
            TB_Version.TabIndex = 7
            TB_Version.TabStop = False
            ' 
            ' Label_Version
            ' 
            Label_Version.AutoSize = True
            Label_Version.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            Label_Version.Location = New Point(827, 75)
            Label_Version.Margin = New Padding(0)
            Label_Version.Name = "Label_Version"
            Label_Version.Size = New Size(173, 54)
            Label_Version.TabIndex = 6
            Label_Version.Text = "Version:"
            Label_Version.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' TB_TreePath
            ' 
            TB_TreePath.Enabled = False
            TB_TreePath.Location = New Point(255, 231)
            TB_TreePath.Margin = New Padding(0)
            TB_TreePath.Name = "TB_TreePath"
            TB_TreePath.Size = New Size(996, 61)
            TB_TreePath.TabIndex = 5
            TB_TreePath.TabStop = False
            ' 
            ' Label_TreePath
            ' 
            Label_TreePath.AutoSize = True
            Label_TreePath.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            Label_TreePath.Location = New Point(132, 234)
            Label_TreePath.Margin = New Padding(0)
            Label_TreePath.Name = "Label_TreePath"
            Label_TreePath.Size = New Size(120, 54)
            Label_TreePath.TabIndex = 4
            Label_TreePath.Text = "Path:"
            Label_TreePath.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' TB_ParentID
            ' 
            TB_ParentID.Enabled = False
            TB_ParentID.Location = New Point(255, 151)
            TB_ParentID.Margin = New Padding(0)
            TB_ParentID.Name = "TB_ParentID"
            TB_ParentID.Size = New Size(250, 61)
            TB_ParentID.TabIndex = 3
            TB_ParentID.TabStop = False
            ' 
            ' Label_ParentID
            ' 
            Label_ParentID.AutoSize = True
            Label_ParentID.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            Label_ParentID.Location = New Point(40, 151)
            Label_ParentID.Name = "Label_ParentID"
            Label_ParentID.Size = New Size(212, 54)
            Label_ParentID.TabIndex = 2
            Label_ParentID.Text = "Parent ID:"
            Label_ParentID.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' TB_ID
            ' 
            TB_ID.Enabled = False
            TB_ID.Location = New Point(255, 69)
            TB_ID.Margin = New Padding(0)
            TB_ID.Name = "TB_ID"
            TB_ID.Size = New Size(250, 61)
            TB_ID.TabIndex = 1
            TB_ID.TabStop = False
            ' 
            ' Label_ID
            ' 
            Label_ID.AutoSize = True
            Label_ID.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            Label_ID.Location = New Point(175, 72)
            Label_ID.Name = "Label_ID"
            Label_ID.Size = New Size(77, 54)
            Label_ID.TabIndex = 0
            Label_ID.Text = "ID:"
            Label_ID.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' GB_Model_Information
            ' 
            GB_Model_Information.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            GB_Model_Information.Controls.Add(TBName)
            GB_Model_Information.Controls.Add(Label_Name)
            GB_Model_Information.Controls.Add(ComboBox_Length)
            GB_Model_Information.Controls.Add(ComboBox_Venue)
            GB_Model_Information.Controls.Add(ComboBox_Type)
            GB_Model_Information.Controls.Add(ComboBox_Country)
            GB_Model_Information.Controls.Add(Label_Length)
            GB_Model_Information.Controls.Add(Label_Venue)
            GB_Model_Information.Controls.Add(Label_Type)
            GB_Model_Information.Controls.Add(Label_Country)
            GB_Model_Information.Location = New Point(0, 348)
            GB_Model_Information.Margin = New Padding(0)
            GB_Model_Information.Name = "GB_Model_Information"
            GB_Model_Information.Padding = New Padding(0)
            GB_Model_Information.Size = New Size(2088, 333)
            GB_Model_Information.TabIndex = 1
            GB_Model_Information.TabStop = False
            GB_Model_Information.Text = "Model Information"
            ' 
            ' TBName
            ' 
            TBName.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
            TBName.Location = New Point(965, 212)
            TBName.Margin = New Padding(0)
            TBName.Name = "TBName"
            TBName.Size = New Size(996, 61)
            TBName.TabIndex = 15
            TBName.TabStop = False
            ' 
            ' Label_Name
            ' 
            Label_Name.AutoSize = True
            Label_Name.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            Label_Name.Location = New Point(815, 215)
            Label_Name.Margin = New Padding(0)
            Label_Name.Name = "Label_Name"
            Label_Name.Size = New Size(147, 54)
            Label_Name.TabIndex = 14
            Label_Name.Text = "Name:"
            Label_Name.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' ComboBox_Length
            ' 
            ComboBox_Length.FlatStyle = FlatStyle.Flat
            ComboBox_Length.FormattingEnabled = True
            ComboBox_Length.Location = New Point(965, 70)
            ComboBox_Length.Name = "ComboBox_Length"
            ComboBox_Length.Size = New Size(387, 62)
            ComboBox_Length.TabIndex = 13
            ' 
            ' ComboBox_Venue
            ' 
            ComboBox_Venue.FlatStyle = FlatStyle.Flat
            ComboBox_Venue.FormattingEnabled = True
            ComboBox_Venue.Location = New Point(276, 202)
            ComboBox_Venue.Name = "ComboBox_Venue"
            ComboBox_Venue.Size = New Size(387, 62)
            ComboBox_Venue.TabIndex = 12
            ' 
            ' ComboBox_Type
            ' 
            ComboBox_Type.FlatStyle = FlatStyle.Flat
            ComboBox_Type.FormattingEnabled = True
            ComboBox_Type.Items.AddRange(New Object() {"", "Greyhounds", "Harness", "Gallops"})
            ComboBox_Type.Location = New Point(276, 134)
            ComboBox_Type.Name = "ComboBox_Type"
            ComboBox_Type.Size = New Size(387, 62)
            ComboBox_Type.TabIndex = 11
            ' 
            ' ComboBox_Country
            ' 
            ComboBox_Country.AutoCompleteSource = AutoCompleteSource.ListItems
            ComboBox_Country.FlatStyle = FlatStyle.Flat
            ComboBox_Country.FormattingEnabled = True
            ComboBox_Country.Items.AddRange(New Object() {"", "New Zealand", "Australia"})
            ComboBox_Country.Location = New Point(276, 66)
            ComboBox_Country.Name = "ComboBox_Country"
            ComboBox_Country.Size = New Size(387, 62)
            ComboBox_Country.TabIndex = 10
            ' 
            ' Label_Length
            ' 
            Label_Length.AutoSize = True
            Label_Length.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            Label_Length.Location = New Point(797, 74)
            Label_Length.Margin = New Padding(0)
            Label_Length.Name = "Label_Length"
            Label_Length.Size = New Size(165, 54)
            Label_Length.TabIndex = 6
            Label_Length.Text = "Length:"
            Label_Length.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' Label_Venue
            ' 
            Label_Venue.AutoSize = True
            Label_Venue.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            Label_Venue.Location = New Point(120, 205)
            Label_Venue.Margin = New Padding(0)
            Label_Venue.Name = "Label_Venue"
            Label_Venue.Size = New Size(150, 54)
            Label_Venue.TabIndex = 4
            Label_Venue.Text = "Venue:"
            Label_Venue.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' Label_Type
            ' 
            Label_Type.AutoSize = True
            Label_Type.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            Label_Type.Location = New Point(146, 137)
            Label_Type.Name = "Label_Type"
            Label_Type.Size = New Size(124, 54)
            Label_Type.TabIndex = 2
            Label_Type.Text = "Type:"
            Label_Type.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' Label_Country
            ' 
            Label_Country.AutoSize = True
            Label_Country.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
            Label_Country.Location = New Point(83, 69)
            Label_Country.Name = "Label_Country"
            Label_Country.Size = New Size(187, 54)
            Label_Country.TabIndex = 0
            Label_Country.Text = "Country:"
            Label_Country.TextAlign = ContentAlignment.MiddleRight
            ' 
            ' UserControlProperties
            ' 
            AutoScaleDimensions = New SizeF(22F, 54F)
            AutoScaleMode = AutoScaleMode.Font
            BackColor = SystemColors.Window
            Controls.Add(GB_Model_Information)
            Controls.Add(GBStatusInformation)
            DoubleBuffered = True
            Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
            ForeColor = SystemColors.WindowText
            Margin = New Padding(0)
            Name = "UserControlProperties"
            Size = New Size(2094, 685)
            GBStatusInformation.ResumeLayout(False)
            GBStatusInformation.PerformLayout()
            GB_Model_Information.ResumeLayout(False)
            GB_Model_Information.PerformLayout()
            ResumeLayout(False)
        End Sub

        Private WithEvents GBStatusInformation As GroupBox
        Private WithEvents Label_ID As Label
        Private WithEvents Label_ParentID As Label
        Private WithEvents Label_TreePath As Label
        Private WithEvents Label_Version As Label
        Private WithEvents GB_Model_Information As GroupBox
        Private WithEvents Label_Length As Label
        Private WithEvents Label_Venue As Label
        Private WithEvents Label_Type As Label
        Private WithEvents Label_Country As Label
        Private WithEvents Label_Name As Label
        Private WithEvents TB_ID As TextBox
        Private WithEvents TB_ParentID As TextBox
        Private WithEvents TB_TreePath As TextBox
        Private WithEvents TB_Version As TextBox
        Private WithEvents ComboBox_Country As ComboBox
        Private WithEvents ComboBox_Venue As ComboBox
        Private WithEvents ComboBox_Type As ComboBox
        Private WithEvents ComboBox_Length As ComboBox
        Private WithEvents TBName As TextBox
        Private WithEvents ComboBox_Status As ComboBox
        Private WithEvents LabelStatus As Label
        Private WithEvents ComboBox_Compiled As ComboBox
        Private WithEvents Label_Compiled As Label
    End Class
End Namespace