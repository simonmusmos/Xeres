<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class stopwatch
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.hou = New System.Windows.Forms.Label()
        Me.min = New System.Windows.Forms.Label()
        Me.sec = New System.Windows.Forms.Label()
        Me.milis = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.hou)
        Me.Panel1.Controls.Add(Me.min)
        Me.Panel1.Controls.Add(Me.sec)
        Me.Panel1.Controls.Add(Me.milis)
        Me.Panel1.Location = New System.Drawing.Point(12, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 232)
        Me.Panel1.TabIndex = 3
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(407, 185)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Reset"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(278, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Stop"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(133, 185)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'hou
        '
        Me.hou.AutoSize = True
        Me.hou.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hou.Location = New System.Drawing.Point(67, 72)
        Me.hou.Name = "hou"
        Me.hou.Size = New System.Drawing.Size(103, 78)
        Me.hou.TabIndex = 6
        Me.hou.Text = "00"
        Me.hou.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'min
        '
        Me.min.AutoSize = True
        Me.min.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.min.Location = New System.Drawing.Point(176, 72)
        Me.min.Name = "min"
        Me.min.Size = New System.Drawing.Size(103, 78)
        Me.min.TabIndex = 5
        Me.min.Text = "00"
        Me.min.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'sec
        '
        Me.sec.AutoSize = True
        Me.sec.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sec.Location = New System.Drawing.Point(285, 72)
        Me.sec.Name = "sec"
        Me.sec.Size = New System.Drawing.Size(103, 78)
        Me.sec.TabIndex = 4
        Me.sec.Text = "00"
        Me.sec.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'milis
        '
        Me.milis.AutoSize = True
        Me.milis.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.milis.Location = New System.Drawing.Point(394, 72)
        Me.milis.Name = "milis"
        Me.milis.Size = New System.Drawing.Size(103, 78)
        Me.milis.TabIndex = 3
        Me.milis.Text = "00"
        Me.milis.TextAlign = System.Drawing.ContentAlignment.TopCenter
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
        'stopwatch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(622, 286)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stopwatch"
        Me.Text = "stopwatch"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents milis As Label
    Friend WithEvents sec As Label
    Friend WithEvents hou As Label
    Friend WithEvents min As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
