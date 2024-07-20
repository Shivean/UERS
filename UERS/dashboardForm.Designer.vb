<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dashboardForm
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
        Me.btnDashboardexit = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.SuspendLayout()
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'btnDashboardexit
        '
        Me.btnDashboardexit.BackColor = System.Drawing.Color.Transparent
        Me.btnDashboardexit.BorderRadius = 5
        Me.btnDashboardexit.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboardexit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnDashboardexit.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnDashboardexit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnDashboardexit.FillColor = System.Drawing.Color.DarkBlue
        Me.btnDashboardexit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btnDashboardexit.ForeColor = System.Drawing.Color.LavenderBlush
        Me.btnDashboardexit.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnDashboardexit.IndicateFocus = True
        Me.btnDashboardexit.Location = New System.Drawing.Point(1125, 12)
        Me.btnDashboardexit.Name = "btnDashboardexit"
        Me.btnDashboardexit.Size = New System.Drawing.Size(63, 39)
        Me.btnDashboardexit.TabIndex = 13
        Me.btnDashboardexit.Text = "✖️"
        Me.btnDashboardexit.UseTransparentBackground = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1200, 708)
        Me.Guna2GradientPanel1.TabIndex = 15
        '
        'dashboardForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 708)
        Me.Controls.Add(Me.btnDashboardexit)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dashboardForm"
        Me.Text = "dashboardForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents btnDashboardexit As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
End Class
