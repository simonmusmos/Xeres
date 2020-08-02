<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dateee
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
        Me.lbl_Time = New System.Windows.Forms.Label()
        Me.dnow = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.alarmmm = New System.Windows.Forms.Label()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Silver
        Me.Panel1.Controls.Add(Me.MonthCalendar1)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.alarmmm)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dnow)
        Me.Panel1.Controls.Add(Me.lbl_Time)
        Me.Panel1.Location = New System.Drawing.Point(12, 35)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(639, 297)
        Me.Panel1.TabIndex = 1
        '
        'lbl_Time
        '
        Me.lbl_Time.AutoSize = True
        Me.lbl_Time.Font = New System.Drawing.Font("Century Gothic", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Time.Location = New System.Drawing.Point(115, 112)
        Me.lbl_Time.Name = "lbl_Time"
        Me.lbl_Time.Size = New System.Drawing.Size(245, 78)
        Me.lbl_Time.TabIndex = 2
        Me.lbl_Time.Text = "00:00   "
        Me.lbl_Time.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'dnow
        '
        Me.dnow.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.dnow.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dnow.Location = New System.Drawing.Point(222, 190)
        Me.dnow.Name = "dnow"
        Me.dnow.Size = New System.Drawing.Size(138, 23)
        Me.dnow.TabIndex = 3
        Me.dnow.Text = "Tue, December 12, 2009"
        Me.dnow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Alarm"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(480, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Incoming Alarm:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'alarmmm
        '
        Me.alarmmm.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.alarmmm.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.alarmmm.Location = New System.Drawing.Point(480, 35)
        Me.alarmmm.Name = "alarmmm"
        Me.alarmmm.Size = New System.Drawing.Size(138, 23)
        Me.alarmmm.TabIndex = 6
        Me.alarmmm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me
        Me.BunifuDragControl1.Vertical = True
        '
        'Label3
        '
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(105, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Stopwatch"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(191, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 23)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Countdown Timer"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(314, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Calendar"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MonthCalendar1.Location = New System.Drawing.Point(241, 35)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 10
        '
        'dateee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(663, 344)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "dateee"
        Me.Text = "dateee"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lbl_Time As Label
    Friend WithEvents dnow As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents alarmmm As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
End Class
