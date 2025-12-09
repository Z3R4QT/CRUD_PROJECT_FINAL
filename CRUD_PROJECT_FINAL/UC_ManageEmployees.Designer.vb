<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_ManageEmployees
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnEdit = New MaterialSkin.Controls.MaterialButton()
        Me.btnDelete = New MaterialSkin.Controls.MaterialButton()
        Me.btnUpdate = New MaterialSkin.Controls.MaterialButton()
        Me.txtName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtPosition = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtSalary = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtDepartment = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtHiddenID = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(446, 380)
        Me.DataGridView1.TabIndex = 0
        '
        'btnEdit
        '
        Me.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnEdit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnEdit.Depth = 0
        Me.btnEdit.HighEmphasis = True
        Me.btnEdit.Icon = Nothing
        Me.btnEdit.Location = New System.Drawing.Point(501, 76)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnEdit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnEdit.Size = New System.Drawing.Size(64, 36)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnEdit.UseAccentColor = False
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnDelete.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnDelete.Depth = 0
        Me.btnDelete.HighEmphasis = True
        Me.btnDelete.Icon = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(501, 124)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnDelete.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnDelete.Size = New System.Drawing.Size(73, 36)
        Me.btnDelete.TabIndex = 2
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnDelete.UseAccentColor = False
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnUpdate.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnUpdate.Depth = 0
        Me.btnUpdate.HighEmphasis = True
        Me.btnUpdate.Icon = Nothing
        Me.btnUpdate.Location = New System.Drawing.Point(460, 266)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnUpdate.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnUpdate.Size = New System.Drawing.Size(77, 36)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "update"
        Me.btnUpdate.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnUpdate.UseAccentColor = False
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.AnimateReadOnly = False
        Me.txtName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtName.Depth = 0
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtName.HideSelection = True
        Me.txtName.LeadingIcon = Nothing
        Me.txtName.Location = New System.Drawing.Point(460, 12)
        Me.txtName.MaxLength = 32767
        Me.txtName.MouseState = MaterialSkin.MouseState.OUT
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PrefixSuffixText = Nothing
        Me.txtName.ReadOnly = False
        Me.txtName.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtName.SelectedText = ""
        Me.txtName.SelectionLength = 0
        Me.txtName.SelectionStart = 0
        Me.txtName.ShortcutsEnabled = True
        Me.txtName.Size = New System.Drawing.Size(229, 48)
        Me.txtName.TabIndex = 4
        Me.txtName.TabStop = False
        Me.txtName.Text = "NAME"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtName.TrailingIcon = Nothing
        Me.txtName.UseSystemPasswordChar = False
        '
        'txtPosition
        '
        Me.txtPosition.AnimateReadOnly = False
        Me.txtPosition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtPosition.Depth = 0
        Me.txtPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtPosition.HideSelection = True
        Me.txtPosition.LeadingIcon = Nothing
        Me.txtPosition.Location = New System.Drawing.Point(460, 66)
        Me.txtPosition.MaxLength = 32767
        Me.txtPosition.MouseState = MaterialSkin.MouseState.OUT
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPosition.PrefixSuffixText = Nothing
        Me.txtPosition.ReadOnly = False
        Me.txtPosition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPosition.SelectedText = ""
        Me.txtPosition.SelectionLength = 0
        Me.txtPosition.SelectionStart = 0
        Me.txtPosition.ShortcutsEnabled = True
        Me.txtPosition.Size = New System.Drawing.Size(229, 48)
        Me.txtPosition.TabIndex = 5
        Me.txtPosition.TabStop = False
        Me.txtPosition.Text = "POSITION"
        Me.txtPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtPosition.TrailingIcon = Nothing
        Me.txtPosition.UseSystemPasswordChar = False
        '
        'txtSalary
        '
        Me.txtSalary.AnimateReadOnly = False
        Me.txtSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtSalary.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtSalary.Depth = 0
        Me.txtSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtSalary.HideSelection = True
        Me.txtSalary.LeadingIcon = Nothing
        Me.txtSalary.Location = New System.Drawing.Point(460, 120)
        Me.txtSalary.MaxLength = 32767
        Me.txtSalary.MouseState = MaterialSkin.MouseState.OUT
        Me.txtSalary.Name = "txtSalary"
        Me.txtSalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSalary.PrefixSuffixText = Nothing
        Me.txtSalary.ReadOnly = False
        Me.txtSalary.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSalary.SelectedText = ""
        Me.txtSalary.SelectionLength = 0
        Me.txtSalary.SelectionStart = 0
        Me.txtSalary.ShortcutsEnabled = True
        Me.txtSalary.Size = New System.Drawing.Size(229, 48)
        Me.txtSalary.TabIndex = 6
        Me.txtSalary.TabStop = False
        Me.txtSalary.Text = "SALARY"
        Me.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSalary.TrailingIcon = Nothing
        Me.txtSalary.UseSystemPasswordChar = False
        '
        'txtDepartment
        '
        Me.txtDepartment.AnimateReadOnly = False
        Me.txtDepartment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtDepartment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtDepartment.Depth = 0
        Me.txtDepartment.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtDepartment.HideSelection = True
        Me.txtDepartment.LeadingIcon = Nothing
        Me.txtDepartment.Location = New System.Drawing.Point(460, 174)
        Me.txtDepartment.MaxLength = 32767
        Me.txtDepartment.MouseState = MaterialSkin.MouseState.OUT
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDepartment.PrefixSuffixText = Nothing
        Me.txtDepartment.ReadOnly = False
        Me.txtDepartment.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDepartment.SelectedText = ""
        Me.txtDepartment.SelectionLength = 0
        Me.txtDepartment.SelectionStart = 0
        Me.txtDepartment.ShortcutsEnabled = True
        Me.txtDepartment.Size = New System.Drawing.Size(229, 48)
        Me.txtDepartment.TabIndex = 7
        Me.txtDepartment.TabStop = False
        Me.txtDepartment.Text = "DEPARTMENT"
        Me.txtDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDepartment.TrailingIcon = Nothing
        Me.txtDepartment.UseSystemPasswordChar = False
        '
        'txtHiddenID
        '
        Me.txtHiddenID.Location = New System.Drawing.Point(460, 228)
        Me.txtHiddenID.Name = "txtHiddenID"
        Me.txtHiddenID.Size = New System.Drawing.Size(100, 20)
        Me.txtHiddenID.TabIndex = 8
        Me.txtHiddenID.Visible = False
        '
        'UC_ManageEmployees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.txtHiddenID)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "UC_ManageEmployees"
        Me.Size = New System.Drawing.Size(710, 380)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnEdit As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnDelete As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnUpdate As MaterialSkin.Controls.MaterialButton
    Friend WithEvents txtName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtPosition As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtSalary As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtDepartment As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtHiddenID As TextBox
End Class
