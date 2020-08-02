<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcomeform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcomeform))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.un = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.pw = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.sbutton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-500, -500)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 510)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(-500, -500)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1280, 510)
        Me.Panel3.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.sbutton)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.pw)
        Me.Panel2.Controls.Add(Me.un)
        Me.Panel2.Location = New System.Drawing.Point(399, 333)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(482, 354)
        Me.Panel2.TabIndex = 2
        '
        'un
        '
        Me.un.BorderColorFocused = System.Drawing.Color.Blue
        Me.un.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.un.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.un.BorderThickness = 1
        Me.un.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.un.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.un.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.un.isPassword = False
        Me.un.Location = New System.Drawing.Point(128, 63)
        Me.un.Margin = New System.Windows.Forms.Padding(4)
        Me.un.Name = "un"
        Me.un.Size = New System.Drawing.Size(337, 44)
        Me.un.TabIndex = 0
        Me.un.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'pw
        '
        Me.pw.BorderColorFocused = System.Drawing.Color.Blue
        Me.pw.BorderColorIdle = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pw.BorderColorMouseHover = System.Drawing.Color.Blue
        Me.pw.BorderThickness = 1
        Me.pw.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.pw.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.pw.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pw.isPassword = False
        Me.pw.Location = New System.Drawing.Point(128, 179)
        Me.pw.Margin = New System.Windows.Forms.Padding(4)
        Me.pw.Name = "pw"
        Me.pw.Size = New System.Drawing.Size(337, 44)
        Me.pw.TabIndex = 1
        Me.pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password:"
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(353, -188)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(573, 376)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(353, 322)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(573, 376)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'sbutton
        '
        Me.sbutton.ActiveBorderThickness = 1
        Me.sbutton.ActiveCornerRadius = 50
        Me.sbutton.ActiveFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sbutton.ActiveForecolor = System.Drawing.Color.White
        Me.sbutton.ActiveLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sbutton.BackColor = System.Drawing.Color.Silver
        Me.sbutton.BackgroundImage = CType(resources.GetObject("sbutton.BackgroundImage"), System.Drawing.Image)
        Me.sbutton.ButtonText = "LOGIN"
        Me.sbutton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sbutton.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbutton.ForeColor = System.Drawing.Color.SeaGreen
        Me.sbutton.IdleBorderThickness = 1
        Me.sbutton.IdleCornerRadius = 50
        Me.sbutton.IdleFillColor = System.Drawing.Color.Transparent
        Me.sbutton.IdleForecolor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sbutton.IdleLineColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.sbutton.Location = New System.Drawing.Point(179, 258)
        Me.sbutton.Margin = New System.Windows.Forms.Padding(5)
        Me.sbutton.Name = "sbutton"
        Me.sbutton.Size = New System.Drawing.Size(180, 61)
        Me.sbutton.TabIndex = 101
        Me.sbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'welcomeform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1280, 1024)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "welcomeform"
        Me.Text = "welcomeform"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Panel2 As Panel
    Friend WithEvents sbutton As Bunifu.Framework.UI.BunifuThinButton2
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pw As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents un As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
