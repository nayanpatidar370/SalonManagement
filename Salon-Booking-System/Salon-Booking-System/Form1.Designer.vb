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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Button1 = New Guna.UI2.WinForms.Guna2GradientButton()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Animated = True
        Me.Button2.BackColor = System.Drawing.Color.Transparent
        Me.Button2.BorderRadius = 25
        Me.Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Solway", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(193, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(116, 757)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(695, 163)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Schedule Appointment"
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.BackgroundImage = CType(resources.GetObject("Guna2CirclePictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Guna2CirclePictureBox1.Image = CType(resources.GetObject("Guna2CirclePictureBox1.Image"), System.Drawing.Image)
        Me.Guna2CirclePictureBox1.ImageRotate = 0!
        Me.Guna2CirclePictureBox1.InitialImage = Nothing
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(180, 370)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(89, 88)
        Me.Guna2CirclePictureBox1.TabIndex = 5
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Animated = True
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BorderRadius = 30
        Me.Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(216, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(132, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Solway", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(17, Byte), Integer))
        Me.Button1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Button1.ImageOffset = New System.Drawing.Point(48, -20)
        Me.Button1.ImageSize = New System.Drawing.Size(95, 95)
        Me.Button1.Location = New System.Drawing.Point(116, 309)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(210, 200)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Browse Gallery"
        Me.Button1.TextOffset = New System.Drawing.Point(5, 67)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(120.0!, 120.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1902, 953)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Controls.Add(Me.Button2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "KNK Salon"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2GradientButton
End Class
