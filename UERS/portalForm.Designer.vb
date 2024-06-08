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
        Me.btnPortalexit = New Guna.UI2.WinForms.Guna2Button()
        Me.btnPortalLogin = New Guna.UI2.WinForms.Guna2Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.GunaSeparator1 = New Guna.UI.WinForms.GunaSeparator()
        Me.portalGradient = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.btnPortalregister = New Guna.UI2.WinForms.Guna2Button()
        Me.GunaSeparator2 = New Guna.UI.WinForms.GunaSeparator()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.portalGradient.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'btnPortalexit
        '
        Me.btnPortalexit.BackColor = System.Drawing.Color.Transparent
        Me.btnPortalexit.BorderRadius = 5
        Me.btnPortalexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPortalexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPortalexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPortalexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPortalexit.FillColor = System.Drawing.Color.DarkBlue
        Me.btnPortalexit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnPortalexit.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btnPortalexit.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnPortalexit.IndicateFocus = True
        Me.btnPortalexit.Location = New System.Drawing.Point(1125, 12)
        Me.btnPortalexit.Name = "btnPortalexit"
        Me.btnPortalexit.Size = New System.Drawing.Size(63, 39)
        Me.btnPortalexit.TabIndex = 12
        Me.btnPortalexit.Text = "✖️"
        Me.btnPortalexit.UseTransparentBackground = True
        '
        'btnPortalLogin
        '
        Me.btnPortalLogin.Animated = True
        Me.btnPortalLogin.AutoRoundedCorners = True
        Me.btnPortalLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnPortalLogin.BorderRadius = 36
        Me.btnPortalLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPortalLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPortalLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPortalLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPortalLogin.FillColor = System.Drawing.Color.DarkBlue
        Me.btnPortalLogin.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.btnPortalLogin.ForeColor = System.Drawing.Color.White
        Me.btnPortalLogin.Location = New System.Drawing.Point(597, 484)
        Me.btnPortalLogin.Name = "btnPortalLogin"
        Me.btnPortalLogin.Size = New System.Drawing.Size(483, 75)
        Me.btnPortalLogin.TabIndex = 14
        Me.btnPortalLogin.Text = "Log In"
        Me.btnPortalLogin.UseTransparentBackground = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(551, 347)
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
        Me.Label3.Location = New System.Drawing.Point(618, 283)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(455, 54)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "UNIVERSITY EXAM"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(768, 220)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 27)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Welcome to"
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
        Me.GunaSeparator1.Location = New System.Drawing.Point(578, 379)
        Me.GunaSeparator1.Name = "GunaSeparator1"
        Me.GunaSeparator1.Size = New System.Drawing.Size(502, 99)
        Me.GunaSeparator1.TabIndex = 26
        '
        'portalGradient
        '
        Me.portalGradient.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.portalGradient.AutoRoundedCorners = True
        Me.portalGradient.BorderRadius = 353
        Me.portalGradient.Controls.Add(Me.btnPortalregister)
        Me.portalGradient.Controls.Add(Me.btnPortalexit)
        Me.portalGradient.Controls.Add(Me.Label1)
        Me.portalGradient.Controls.Add(Me.btnPortalLogin)
        Me.portalGradient.Controls.Add(Me.Label5)
        Me.portalGradient.Controls.Add(Me.Label3)
        Me.portalGradient.Controls.Add(Me.GunaPictureBox2)
        Me.portalGradient.Controls.Add(Me.GunaSeparator1)
        Me.portalGradient.Controls.Add(Me.GunaSeparator2)
        Me.portalGradient.CustomizableEdges.TopRight = False
        Me.portalGradient.FillColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.portalGradient.Location = New System.Drawing.Point(0, 0)
        Me.portalGradient.Name = "portalGradient"
        Me.portalGradient.Size = New System.Drawing.Size(1200, 708)
        Me.portalGradient.TabIndex = 30
        '
        'btnPortalregister
        '
        Me.btnPortalregister.Animated = True
        Me.btnPortalregister.AutoRoundedCorners = True
        Me.btnPortalregister.BackColor = System.Drawing.Color.Transparent
        Me.btnPortalregister.BorderRadius = 36
        Me.btnPortalregister.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnPortalregister.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnPortalregister.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnPortalregister.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnPortalregister.FillColor = System.Drawing.Color.DarkBlue
        Me.btnPortalregister.Font = New System.Drawing.Font("Segoe UI", 13.8!)
        Me.btnPortalregister.ForeColor = System.Drawing.Color.White
        Me.btnPortalregister.Location = New System.Drawing.Point(597, 583)
        Me.btnPortalregister.Name = "btnPortalregister"
        Me.btnPortalregister.Size = New System.Drawing.Size(483, 75)
        Me.btnPortalregister.TabIndex = 30
        Me.btnPortalregister.Text = "Register"
        Me.btnPortalregister.UseTransparentBackground = True
        '
        'GunaSeparator2
        '
        Me.GunaSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.GunaSeparator2.LineColor = System.Drawing.Color.Black
        Me.GunaSeparator2.Location = New System.Drawing.Point(578, 220)
        Me.GunaSeparator2.Name = "GunaSeparator2"
        Me.GunaSeparator2.Size = New System.Drawing.Size(502, 99)
        Me.GunaSeparator2.TabIndex = 31
        '
        'portalForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 708)
        Me.ControlBox = False
        Me.Controls.Add(Me.portalGradient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "portalForm"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "portalform"
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.portalGradient.ResumeLayout(False)
        Me.portalGradient.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnPortalexit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnPortalLogin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents GunaSeparator1 As Guna.UI.WinForms.GunaSeparator
    Friend WithEvents portalGradient As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents btnPortalregister As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GunaSeparator2 As Guna.UI.WinForms.GunaSeparator
End Class
