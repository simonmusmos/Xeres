<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class alarm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.t = New System.Windows.Forms.ComboBox()
        Me.m = New System.Windows.Forms.ComboBox()
        Me.h = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dnow = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.dnow)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.t)
        Me.Panel1.Controls.Add(Me.m)
        Me.Panel1.Controls.Add(Me.h)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(12, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 160)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = ":"
        '
        't
        '
        Me.t.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.t.FormattingEnabled = True
        Me.t.Items.AddRange(New Object() {"AM", "PM"})
        Me.t.Location = New System.Drawing.Point(183, 42)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(55, 28)
        Me.t.TabIndex = 12
        Me.t.Text = "AM"
        '
        'm
        '
        Me.m.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.m.FormattingEnabled = True
        Me.m.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.m.Location = New System.Drawing.Point(111, 42)
        Me.m.Name = "m"
        Me.m.Size = New System.Drawing.Size(43, 28)
        Me.m.TabIndex = 11
        Me.m.Text = "00"
        '
        'h
        '
        Me.h.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.h.FormattingEnabled = True
        Me.h.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.h.Location = New System.Drawing.Point(40, 42)
        Me.h.Name = "h"
        Me.h.Size = New System.Drawing.Size(45, 28)
        Me.h.TabIndex = 10
        Me.h.Text = "01"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(169, 88)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(68, 29)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(95, 88)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 29)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dnow
        '
        Me.dnow.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dnow.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dnow.Location = New System.Drawing.Point(37, 120)
        Me.dnow.Name = "dnow"
        Me.dnow.Size = New System.Drawing.Size(250, 23)
        Me.dnow.TabIndex = 15
        Me.dnow.Text = "*One alarm at a time only"
        Me.dnow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'alarm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(337, 212)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "alarm"
        Me.Text = "alarm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents t As ComboBox
    Friend WithEvents m As ComboBox
    Friend WithEvents h As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dnow As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
