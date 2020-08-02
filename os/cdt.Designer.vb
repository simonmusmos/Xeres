<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cdt
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.milis = New System.Windows.Forms.Label()
        Me.sec = New System.Windows.Forms.Label()
        Me.min = New System.Windows.Forms.Label()
        Me.milistb = New System.Windows.Forms.RichTextBox()
        Me.sectb = New System.Windows.Forms.RichTextBox()
        Me.mintb = New System.Windows.Forms.RichTextBox()
        Me.hou = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.milis)
        Me.Panel1.Controls.Add(Me.sec)
        Me.Panel1.Controls.Add(Me.min)
        Me.Panel1.Controls.Add(Me.milistb)
        Me.Panel1.Controls.Add(Me.sectb)
        Me.Panel1.Controls.Add(Me.mintb)
        Me.Panel1.Controls.Add(Me.hou)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(554, 193)
        Me.Panel1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(135, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 29)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'milis
        '
        Me.milis.AutoSize = True
        Me.milis.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.milis.Location = New System.Drawing.Point(394, 70)
        Me.milis.Name = "milis"
        Me.milis.Size = New System.Drawing.Size(103, 78)
        Me.milis.TabIndex = 24
        Me.milis.Text = "00"
        Me.milis.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sec
        '
        Me.sec.AutoSize = True
        Me.sec.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.Location = New System.Drawing.Point(285, 70)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(103, 78)
        Me.sec.TabIndex = 23
        Me.sec.Text = "00"
        Me.sec.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'min
        '
        Me.min.AutoSize = True
        Me.min.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min.Location = New System.Drawing.Point(176, 70)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(103, 78)
        Me.min.TabIndex = 22
        Me.min.Text = "00"
        Me.min.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'milistb
        '
        Me.milistb.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.milistb.Location = New System.Drawing.Point(403, 91)
        Me.milistb.Name = "milistb"
        Me.milistb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.milistb.Size = New System.Drawing.Size(60, 53)
        Me.milistb.TabIndex = 21
        Me.milistb.Text = ""
        '
        'sectb
        '
        Me.sectb.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sectb.Location = New System.Drawing.Point(306, 91)
        Me.sectb.Name = "sectb"
        Me.sectb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.sectb.Size = New System.Drawing.Size(60, 53)
        Me.sectb.TabIndex = 20
        Me.sectb.Text = ""
        '
        'mintb
        '
        Me.mintb.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mintb.Location = New System.Drawing.Point(208, 91)
        Me.mintb.Name = "mintb"
        Me.mintb.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.mintb.Size = New System.Drawing.Size(60, 53)
        Me.mintb.TabIndex = 19
        Me.mintb.Text = ""
        '
        'hou
        '
        Me.hou.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hou.Location = New System.Drawing.Point(3, 70)
        Me.hou.Name = "hou"
        Me.hou.Size = New System.Drawing.Size(167, 78)
        Me.hou.TabIndex = 18
        Me.hou.Text = "00"
        Me.hou.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(89, 91)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.RichTextBox1.Size = New System.Drawing.Size(60, 53)
        Me.RichTextBox1.TabIndex = 17
        Me.RichTextBox1.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(383, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 20)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(274, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(165, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = ":"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(332, 150)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 30)
        Me.Button3.TabIndex = 26
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'cdt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(578, 236)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cdt"
        Me.Text = "cdt"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents hou As Label
    Friend WithEvents milis As Label
    Friend WithEvents sec As Label
    Friend WithEvents min As Label
    Friend WithEvents milistb As RichTextBox
    Friend WithEvents sectb As RichTextBox
    Friend WithEvents mintb As RichTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Button3 As Button
End Class
