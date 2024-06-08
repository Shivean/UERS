<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.lblwelcomelogin = New System.Windows.Forms.Label()
        Me.btnlogin = New Guna.UI2.WinForms.Guna2Button()
        Me.txtloginUser = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2GradientPanel2 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.txtloginPassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel3 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnloginexit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnloginReturn = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Silver
        Me.GunaSeparator1.Location = New System.Drawing.Point(450, 449)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(291, 18)
        Me.GunaSeparator1.TabIndex = 23
        '
        'lblwelcomelogin
        '
        Me.lblwelcomelogin.AutoSize = True
        Me.lblwelcomelogin.Font = New System.Drawing.Font("Arial Rounded MT Bold", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwelcomelogin.Location = New System.Drawing.Point(438, 172)
        Me.lblwelcomelogin.Name = "lblwelcomelogin"
        Me.lblwelcomelogin.Size = New System.Drawing.Size(315, 38)
        Me.lblwelcomelogin.TabIndex = 22
        Me.lblwelcomelogin.Text = "Welcome to Login!"
        '
        'btnlogin
        '
        Me.btnlogin.Animated = True
        Me.btnlogin.AutoRoundedCorners = True
        Me.btnlogin.BackColor = System.Drawing.Color.Transparent
        Me.btnlogin.BorderRadius = 33
        Me.btnlogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnlogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnlogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnlogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnlogin.FillColor = System.Drawing.Color.DarkBlue
        Me.btnlogin.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.btnlogin.ForeColor = System.Drawing.Color.White
        Me.btnlogin.Location = New System.Drawing.Point(387, 498)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(417, 69)
        Me.btnlogin.TabIndex = 3
        Me.btnlogin.Text = "Log In"
        Me.btnlogin.UseTransparentBackground = True
        '
        'txtloginUser
        '
        Me.txtloginUser.AutoRoundedCorners = True
        Me.txtloginUser.BorderColor = System.Drawing.Color.DarkBlue
        Me.txtloginUser.BorderRadius = 33
        Me.txtloginUser.BorderThickness = 2
        Me.txtloginUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtloginUser.DefaultText = ""
        Me.txtloginUser.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtloginUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtloginUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtloginUser.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtloginUser.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtloginUser.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtloginUser.ForeColor = System.Drawing.Color.Black
        Me.txtloginUser.HoverState.BorderColor = System.Drawing.Color.DarkBlue
        Me.txtloginUser.Location = New System.Drawing.Point(387, 240)
        Me.txtloginUser.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtloginUser.Name = "txtloginUser"
        Me.txtloginUser.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtloginUser.PlaceholderText = "Username or Email"
        Me.txtloginUser.SelectedText = ""
        Me.txtloginUser.Size = New System.Drawing.Size(417, 69)
        Me.txtloginUser.TabIndex = 1
        Me.txtloginUser.TextOffset = New System.Drawing.Point(20, 0)
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.AutoRoundedCorners = True
        Me.Guna2GradientPanel1.BorderRadius = 212
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(3, 270)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(450, 426)
        Me.Guna2GradientPanel1.TabIndex = 24
        '
        'Guna2GradientPanel2
        '
        Me.Guna2GradientPanel2.AutoRoundedCorners = True
        Me.Guna2GradientPanel2.BorderRadius = 171
        Me.Guna2GradientPanel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Guna2GradientPanel2.Location = New System.Drawing.Point(866, 49)
        Me.Guna2GradientPanel2.Name = "Guna2GradientPanel2"
        Me.Guna2GradientPanel2.Size = New System.Drawing.Size(370, 345)
        Me.Guna2GradientPanel2.TabIndex = 25
        '
        'txtloginPassword
        '
        Me.txtloginPassword.Animated = True
        Me.txtloginPassword.AutoRoundedCorners = True
        Me.txtloginPassword.BorderColor = System.Drawing.Color.DarkBlue
        Me.txtloginPassword.BorderRadius = 33
        Me.txtloginPassword.BorderThickness = 2
        Me.txtloginPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtloginPassword.DefaultText = ""
        Me.txtloginPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtloginPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtloginPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtloginPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtloginPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtloginPassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtloginPassword.ForeColor = System.Drawing.Color.Black
        Me.txtloginPassword.HoverState.BorderColor = System.Drawing.Color.DarkBlue
        Me.txtloginPassword.Location = New System.Drawing.Point(387, 349)
        Me.txtloginPassword.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtloginPassword.Name = "txtloginPassword"
        Me.txtloginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtloginPassword.PlaceholderText = "Password"
        Me.txtloginPassword.SelectedText = ""
        Me.txtloginPassword.Size = New System.Drawing.Size(417, 69)
        Me.txtloginPassword.TabIndex = 2
        Me.txtloginPassword.TextOffset = New System.Drawing.Point(20, 0)
        Me.txtloginPassword.UseSystemPasswordChar = True
        '
        'Guna2GradientPanel3
        '
        Me.Guna2GradientPanel3.AutoRoundedCorners = True
        Me.Guna2GradientPanel3.BorderRadius = 110
        Me.Guna2GradientPanel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel3.Location = New System.Drawing.Point(893, 539)
        Me.Guna2GradientPanel3.Name = "Guna2GradientPanel3"
        Me.Guna2GradientPanel3.Size = New System.Drawing.Size(251, 223)
        Me.Guna2GradientPanel3.TabIndex = 25
        '
        'btnloginexit
        '
        Me.btnloginexit.BackColor = System.Drawing.Color.Transparent
        Me.btnloginexit.BorderRadius = 5
        Me.btnloginexit.DefaultAutoSize = True
        Me.btnloginexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnloginexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnloginexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnloginexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnloginexit.FillColor = System.Drawing.Color.DarkBlue
        Me.btnloginexit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnloginexit.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btnloginexit.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnloginexit.IndicateFocus = True
        Me.btnloginexit.Location = New System.Drawing.Point(1125, 12)
        Me.btnloginexit.Name = "btnloginexit"
        Me.btnloginexit.Size = New System.Drawing.Size(63, 39)
        Me.btnloginexit.TabIndex = 26
        Me.btnloginexit.Text = "✖️"
        Me.btnloginexit.UseTransparentBackground = True
        '
        'btnloginReturn
        '
        Me.btnloginReturn.BackColor = System.Drawing.Color.Transparent
        Me.btnloginReturn.BorderColor = System.Drawing.Color.Transparent
        Me.btnloginReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnloginReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnloginReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnloginReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnloginReturn.FillColor = System.Drawing.Color.Transparent
        Me.btnloginReturn.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnloginReturn.ForeColor = System.Drawing.Color.DarkBlue
        Me.btnloginReturn.Location = New System.Drawing.Point(431, 584)
        Me.btnloginReturn.Name = "btnloginReturn"
        Me.btnloginReturn.Size = New System.Drawing.Size(329, 40)
        Me.btnloginReturn.TabIndex = 27
        Me.btnloginReturn.Text = "↩ Return to previous page"
        Me.btnloginReturn.UseTransparentBackground = True
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 708)
        Me.Controls.Add(Me.btnloginReturn)
        Me.Controls.Add(Me.btnloginexit)
        Me.Controls.Add(Me.Guna2GradientPanel3)
        Me.Controls.Add(Me.GunaSeparator1)
        Me.Controls.Add(Me.lblwelcomelogin)
        Me.Controls.Add(Me.txtloginPassword)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.txtloginUser)
        Me.Controls.Add(Me.Guna2GradientPanel2)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents lblwelcomelogin As Label
    Friend WithEvents btnlogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtloginUser As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel2 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2GradientPanel3 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents txtloginPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnloginexit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnloginReturn As Guna.UI2.WinForms.Guna2Button
End Class
