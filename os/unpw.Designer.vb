<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class unpw
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(unpw))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.un = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pw = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.sbutton = New Bunifu.Framework.UI.BunifuThinButton2()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.sbutton)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.pw)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.un)
        Me.Panel1.Location = New System.Drawing.Point(12, 53)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 423)
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 136)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username:"
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
        Me.un.Location = New System.Drawing.Point(119, 121)
        Me.un.Margin = New System.Windows.Forms.Padding(4)
        Me.un.Name = "un"
        Me.un.Size = New System.Drawing.Size(337, 44)
        Me.un.TabIndex = 3
        Me.un.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password:"
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
        Me.pw.Location = New System.Drawing.Point(119, 227)
        Me.pw.Margin = New System.Windows.Forms.Padding(4)
        Me.pw.Name = "pw"
        Me.pw.Size = New System.Drawing.Size(337, 44)
        Me.pw.TabIndex = 5
        Me.pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enter login Information"
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
        Me.sbutton.Location = New System.Drawing.Point(145, 325)
        Me.sbutton.Margin = New System.Windows.Forms.Padding(5)
        Me.sbutton.Name = "sbutton"
        Me.sbutton.Size = New System.Drawing.Size(180, 61)
        Me.sbutton.TabIndex = 102
        Me.sbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'unpw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(492, 488)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "unpw"
        Me.Text = "unpw"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents pw As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents un As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents sbutton As Bunifu.Framework.UI.BunifuThinButton2
End Class
