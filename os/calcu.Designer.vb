<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calcu
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
        Me.ans = New System.Windows.Forms.Label()
        Me.inputs = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel1.Controls.Add(Me.ans)
        Me.Panel1.Controls.Add(Me.inputs)
        Me.Panel1.Location = New System.Drawing.Point(27, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(357, 83)
        Me.Panel1.TabIndex = 0
        '
        'ans
        '
        Me.ans.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ans.Location = New System.Drawing.Point(60, 55)
        Me.ans.Name = "ans"
        Me.ans.Size = New System.Drawing.Size(294, 17)
        Me.ans.TabIndex = 1
        Me.ans.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'inputs
        '
        Me.inputs.AutoSize = True
        Me.inputs.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputs.Location = New System.Drawing.Point(16, 10)
        Me.inputs.Name = "inputs"
        Me.inputs.Size = New System.Drawing.Size(0, 17)
        Me.inputs.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.Label20)
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Location = New System.Drawing.Point(12, 39)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(407, 393)
        Me.Panel2.TabIndex = 2
        '
        'Label20
        '
        Me.Label20.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label20.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(280, 89)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(104, 51)
        Me.Label20.TabIndex = 19
        Me.Label20.Text = "CLR"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label19.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label19.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(280, 339)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(104, 40)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "="
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label17.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(280, 277)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(101, 51)
        Me.Label17.TabIndex = 16
        Me.Label17.Text = "^2"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label16.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label16.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(338, 206)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(46, 51)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "/"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label15.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label15.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(338, 136)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 51)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "*"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label14.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label14.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(280, 206)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 51)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "+"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label13.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(280, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 51)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "-"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Gray
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(206, 339)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 40)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "."
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Gray
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(42, 339)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(131, 40)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "0"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Gray
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(206, 277)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 51)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "3"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gray
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(127, 277)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 51)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "2"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Gray
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 51)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "1"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gray
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(206, 206)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 51)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "6"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Gray
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(127, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 51)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "5"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gray
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 206)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(46, 51)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "4"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Gray
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(206, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 51)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "9"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Gray
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(127, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 51)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "8"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gray
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 51)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "7"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'calcu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(431, 444)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "calcu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "calcu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents inputs As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents ans As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
