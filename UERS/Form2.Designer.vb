<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class portalForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(portalForm))
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Button3 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2ColorTransition1 = New Guna.UI2.WinForms.Guna2ColorTransition(Me.components)
        Me.btnPortalLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPortalregister = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Button3
        '
        Me.Guna2Button3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button3.BorderRadius = 5
        Me.Guna2Button3.DefaultAutoSize = True
        Me.Guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button3.FillColor = System.Drawing.Color.DarkBlue
        Me.Guna2Button3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Guna2Button3.ForeColor = System.Drawing.Color.LavenderBlush
        Me.Guna2Button3.IndicateFocus = True
        Me.Guna2Button3.Location = New System.Drawing.Point(1125, 12)
        Me.Guna2Button3.Name = "Guna2Button3"
        Me.Guna2Button3.Size = New System.Drawing.Size(63, 39)
        Me.Guna2Button3.TabIndex = 12
        Me.Guna2Button3.Text = "✖️"
        Me.Guna2Button3.UseTransparentBackground = True
        '
        'Guna2ColorTransition1
        '
        Me.Guna2ColorTransition1.ColorArray = New System.Drawing.Color() {System.Drawing.Color.Red, System.Drawing.Color.Blue, System.Drawing.Color.Orange}
        '
        'btnPortalLogin
        '
        Me.btnPortalLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnPortalLogin.BorderRadius = 30
        Me.btnPortalLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPortalLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPortalLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPortalLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPortalLogin.FillColor = System.Drawing.Color.DarkBlue
        Me.btnPortalLogin.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.btnPortalLogin.ForeColor = System.Drawing.Color.White
        Me.btnPortalLogin.Location = New System.Drawing.Point(508, 510)
        Me.btnPortalLogin.Name = "btnPortalLogin"
        Me.btnPortalLogin.Size = New System.Drawing.Size(312, 100)
        Me.btnPortalLogin.TabIndex = 14
        Me.btnPortalLogin.Text = "Log In"
        Me.btnPortalLogin.UseTransparentBackground = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(539, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(590, 54)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "REGISTRATION PORTAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(595, 246)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(455, 54)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "UNIVERSITY EXAM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(745, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 27)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Welcome to"
        '
        'btnPortalregister
        '
        Me.btnPortalregister.AutoRoundedCorners = True
        Me.btnPortalregister.BackColor = System.Drawing.Color.Transparent
        Me.btnPortalregister.BorderRadius = 30
        Me.btnPortalregister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPortalregister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPortalregister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPortalregister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPortalregister.FillColor = System.Drawing.Color.DarkBlue
        Me.btnPortalregister.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.btnPortalregister.ForeColor = System.Drawing.Color.White
        Me.btnPortalregister.Location = New System.Drawing.Point(849, 510)
        Me.btnPortalregister.Name = "btnPortalregister"
        Me.btnPortalregister.Size = New System.Drawing.Size(312, 100)
        Me.btnPortalregister.TabIndex = 25
        Me.btnPortalregister.Text = "Register"
        Me.btnPortalregister.UseTransparentBackground = True
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = CType(resources.GetObject("GunaPictureBox2.Image"), System.Drawing.Image)
        Me.GunaPictureBox2.Location = New System.Drawing.Point(12, 127)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(487, 587)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 24
        Me.GunaPictureBox2.TabStop = False
        Me.GunaPictureBox2.WaitOnLoad = True
        '
        'GunaSeparator1
        '
        Me.GunaSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.GunaSeparator1.LineColor = System.Drawing.Color.Black
        Me.GunaSeparator1.Location = New System.Drawing.Point(584, 382)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(513, 99)
        Me.GunaSeparator1.TabIndex = 26
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.AutoRoundedCorners = True
        Me.Guna2GradientPanel1.BorderRadius = 353
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Button3)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnPortalregister)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label1)
        Me.Guna2GradientPanel1.Controls.Add(Me.btnPortalLogin)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2GradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaPictureBox2)
        Me.Guna2GradientPanel1.Controls.Add(Me.GunaSeparator1)
        Me.Guna2GradientPanel1.CustomizableEdges.TopRight = False
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1200, 708)
        Me.Guna2GradientPanel1.TabIndex = 30
        '
        'portalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.GhostWhite
        Me.ClientSize = New System.Drawing.Size(1200, 708)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "portalForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Text = "portalform"
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Guna2Button3 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2ColorTransition1 As Guna.UI2.WinForms.Guna2ColorTransition
    Friend WithEvents btnPortalLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnPortalregister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
End Class
