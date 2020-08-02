<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ksmash
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.score = New System.Windows.Forms.Label()
        Me.tmer = New System.Windows.Forms.Label()
        Me.highscore = New System.Windows.Forms.Label()
        Me.countdown = New System.Windows.Forms.Timer(Me.components)
        Me.re = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.re, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.re)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.score)
        Me.Panel1.Controls.Add(Me.tmer)
        Me.Panel1.Controls.Add(Me.highscore)
        Me.Panel1.Location = New System.Drawing.Point(12, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 390)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(435, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Current Score:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'score
        '
        Me.score.Cursor = System.Windows.Forms.Cursors.Hand
        Me.score.Font = New System.Drawing.Font("Century Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.score.Location = New System.Drawing.Point(16, 106)
        Me.score.Name = "score"
        Me.score.Size = New System.Drawing.Size(408, 268)
        Me.score.TabIndex = 3
        Me.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tmer
        '
        Me.tmer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tmer.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tmer.Location = New System.Drawing.Point(3, 83)
        Me.tmer.Name = "tmer"
        Me.tmer.Size = New System.Drawing.Size(435, 23)
        Me.tmer.TabIndex = 2
        Me.tmer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'highscore
        '
        Me.highscore.Cursor = System.Windows.Forms.Cursors.Hand
        Me.highscore.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.highscore.Location = New System.Drawing.Point(273, 9)
        Me.highscore.Name = "highscore"
        Me.highscore.Size = New System.Drawing.Size(165, 23)
        Me.highscore.TabIndex = 1
        Me.highscore.Text = "Highscore:"
        Me.highscore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'countdown
        '
        Me.countdown.Interval = 1000
        '
        're
        '
        Me.re.Location = New System.Drawing.Point(15, 12)
        Me.re.Name = "re"
        Me.re.Size = New System.Drawing.Size(40, 35)
        Me.re.TabIndex = 5
        Me.re.TabStop = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'ksmash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(465, 445)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ksmash"
        Me.Text = "ksmash"
        Me.Panel1.ResumeLayout(False)
        CType(Me.re, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents score As Label
    Friend WithEvents tmer As Label
    Friend WithEvents highscore As Label
    Friend WithEvents countdown As Timer
    Friend WithEvents re As PictureBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
