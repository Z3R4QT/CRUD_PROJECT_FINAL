<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New MaterialSkin.Controls.MaterialButton()
        Me.btnManageEmployee = New MaterialSkin.Controls.MaterialButton()
        Me.btnAddEmployee = New MaterialSkin.Controls.MaterialButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnConnect = New MaterialSkin.Controls.MaterialButton()
        Me.btnHome = New MaterialSkin.Controls.MaterialButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel1.Controls.Add(Me.btnHome)
        Me.Panel1.Controls.Add(Me.btnConnect)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnAddEmployee)
        Me.Panel1.Controls.Add(Me.btnManageEmployee)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(182, 449)
        Me.Panel1.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnExit.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnExit.Depth = 0
        Me.btnExit.HighEmphasis = True
        Me.btnExit.Icon = Nothing
        Me.btnExit.Location = New System.Drawing.Point(13, 407)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnExit.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnExit.Name = "btnExit"
        Me.btnExit.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnExit.Size = New System.Drawing.Size(64, 36)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "EXIT"
        Me.btnExit.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnExit.UseAccentColor = False
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnManageEmployee
        '
        Me.btnManageEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnManageEmployee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnManageEmployee.Depth = 0
        Me.btnManageEmployee.HighEmphasis = True
        Me.btnManageEmployee.Icon = Nothing
        Me.btnManageEmployee.Location = New System.Drawing.Point(13, 229)
        Me.btnManageEmployee.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnManageEmployee.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnManageEmployee.Name = "btnManageEmployee"
        Me.btnManageEmployee.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnManageEmployee.Size = New System.Drawing.Size(161, 36)
        Me.btnManageEmployee.TabIndex = 2
        Me.btnManageEmployee.Text = "MANAGE EMPLOYEE"
        Me.btnManageEmployee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnManageEmployee.UseAccentColor = False
        Me.btnManageEmployee.UseVisualStyleBackColor = True
        '
        'btnAddEmployee
        '
        Me.btnAddEmployee.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnAddEmployee.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnAddEmployee.Depth = 0
        Me.btnAddEmployee.HighEmphasis = True
        Me.btnAddEmployee.Icon = Nothing
        Me.btnAddEmployee.Location = New System.Drawing.Point(13, 168)
        Me.btnAddEmployee.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnAddEmployee.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnAddEmployee.Name = "btnAddEmployee"
        Me.btnAddEmployee.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnAddEmployee.Size = New System.Drawing.Size(129, 36)
        Me.btnAddEmployee.TabIndex = 1
        Me.btnAddEmployee.Text = "ADD EMPLOYEE"
        Me.btnAddEmployee.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnAddEmployee.UseAccentColor = False
        Me.btnAddEmployee.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkBlue
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(182, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(761, 103)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(182, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(761, 449)
        Me.Panel4.TabIndex = 2
        '
        'btnConnect
        '
        Me.btnConnect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnConnect.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnConnect.Depth = 0
        Me.btnConnect.HighEmphasis = True
        Me.btnConnect.Icon = Nothing
        Me.btnConnect.Location = New System.Drawing.Point(10, 104)
        Me.btnConnect.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnConnect.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnConnect.Size = New System.Drawing.Size(164, 36)
        Me.btnConnect.TabIndex = 2
        Me.btnConnect.Text = "Connect to MySQL"
        Me.btnConnect.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnConnect.UseAccentColor = False
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnHome.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.[Default]
        Me.btnHome.Depth = 0
        Me.btnHome.HighEmphasis = True
        Me.btnHome.Icon = Nothing
        Me.btnHome.Location = New System.Drawing.Point(10, 15)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnHome.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnHome.Name = "btnHome"
        Me.btnHome.NoAccentTextColor = System.Drawing.Color.Empty
        Me.btnHome.Size = New System.Drawing.Size(64, 36)
        Me.btnHome.TabIndex = 4
        Me.btnHome.Text = "HOME"
        Me.btnHome.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained
        Me.btnHome.UseAccentColor = False
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(943, 449)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnAddEmployee As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnExit As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnManageEmployee As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnConnect As MaterialSkin.Controls.MaterialButton
    Friend WithEvents btnHome As MaterialSkin.Controls.MaterialButton
End Class
