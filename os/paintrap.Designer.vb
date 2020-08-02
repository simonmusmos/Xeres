<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paintrap
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(paintrap))
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.wtb = New System.Windows.Forms.TextBox()
        Me.ltb = New System.Windows.Forms.TextBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(41, 38)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(691, 94)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.ltb)
        Me.Panel2.Controls.Add(Me.wtb)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(0, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(691, 44)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Width:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(259, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Length:"
        '
        'wtb
        '
        Me.wtb.Location = New System.Drawing.Point(157, 13)
        Me.wtb.Name = "wtb"
        Me.wtb.Size = New System.Drawing.Size(55, 20)
        Me.wtb.TabIndex = 3
        '
        'ltb
        '
        Me.ltb.Location = New System.Drawing.Point(321, 13)
        Me.ltb.Name = "ltb"
        Me.ltb.Size = New System.Drawing.Size(55, 20)
        Me.ltb.TabIndex = 4
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.Panel1
        Me.BunifuDragControl1.Vertical = True
        '
        'paintrap
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(688, 467)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "paintrap"
        Me.Text = "paintrap"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ltb As TextBox
    Friend WithEvents wtb As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
