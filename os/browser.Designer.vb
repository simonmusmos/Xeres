<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class browser
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
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(12, 88)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(719, 489)
        Me.WebBrowser1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.RichTextBox1)
        Me.Panel2.Location = New System.Drawing.Point(12, 44)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(719, 44)
        Me.Panel2.TabIndex = 6
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RichTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(64, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(577, 38)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(647, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(69, 38)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "GO"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(55, 35)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(743, 589)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.WebBrowser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "browser"
        Me.Text = "browser"
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
End Class
