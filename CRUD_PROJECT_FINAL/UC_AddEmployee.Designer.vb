<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UC_AddEmployee
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
        Me.txtName = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtposition = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtSalary = New MaterialSkin.Controls.MaterialTextBox2()
        Me.txtDepartment = New MaterialSkin.Controls.MaterialTextBox2()
        Me.btnSave = New MaterialSkin.Controls.MaterialButton()
        Me.SuspendLayout()
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
        Me.txtName.Location = New System.Drawing.Point(17, 32)
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
        Me.txtName.Size = New System.Drawing.Size(170, 48)
        Me.txtName.TabIndex = 0
        Me.txtName.TabStop = False
        Me.txtName.Text = "NAME"
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtName.TrailingIcon = Nothing
        Me.txtName.UseSystemPasswordChar = False
        '
        'txtposition
        '
        Me.txtposition.AnimateReadOnly = False
        Me.txtposition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.txtposition.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.txtposition.Depth = 0
        Me.txtposition.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.txtposition.HideSelection = True
        Me.txtposition.LeadingIcon = Nothing
        Me.txtposition.Location = New System.Drawing.Point(17, 97)
        Me.txtposition.MaxLength = 32767
        Me.txtposition.MouseState = MaterialSkin.MouseState.OUT
        Me.txtposition.Name = "txtposition"
        Me.txtposition.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtposition.PrefixSuffixText = Nothing
        Me.txtposition.ReadOnly = False
        Me.txtposition.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtposition.SelectedText = ""
        Me.txtposition.SelectionLength = 0
        Me.txtposition.SelectionStart = 0
        Me.txtposition.ShortcutsEnabled = True
        Me.txtposition.Size = New System.Drawing.Size(170, 48)
        Me.txtposition.TabIndex = 1
        Me.txtposition.TabStop = False
        Me.txtposition.Text = "POSITION"
        Me.txtposition.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtposition.TrailingIcon = Nothing
        Me.txtposition.UseSystemPasswordChar = False
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
        Me.txtSalary.Location = New System.Drawing.Point(17, 151)
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
        Me.txtSalary.Size = New System.Drawing.Size(170, 48)
        Me.txtSalary.TabIndex = 2
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
        Me.txtDepartment.Location = New System.Drawing.Point(17, 205)
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
        Me.txtDepartment.Size = New System.Drawing.Size(170, 48)
        Me.txtDepartment.TabIndex = 3
        Me.txtDepartment.TabStop = False
        Me.txtDepartment.Text = "DEPARTMENT"
        Me.txtDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtDepartment.TrailingIcon = Nothing
        Me.txtDepartment.UseSystemPasswordChar = False
        '
        'btnSave
        '
        Me.btnSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnSave.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnSave.Depth = 0
        Me.btnSave.HighEmphasis = True
        Me.btnSave.Icon = Nothing
        Me.btnSave.Location = New System.Drawing.Point(17, 262)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnSave.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnSave.Name = "btnSave"
        Me.btnSave.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnSave.Size = New System.Drawing.Size(64, 36)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "SAVE"
        Me.btnSave.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnSave.UseAccentColor = False
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'UC_AddEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDepartment)
        Me.Controls.Add(Me.txtSalary)
        Me.Controls.Add(Me.txtposition)
        Me.Controls.Add(Me.txtName)
        Me.Name = "UC_AddEmployee"
        Me.Size = New System.Drawing.Size(806, 325)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtposition As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtSalary As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents txtDepartment As MaterialSkin.Controls.MaterialTextBox2
    Friend WithEvents btnSave As MaterialSkin.Controls.MaterialButton
End Class
