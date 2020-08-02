Imports System.Drawing.Drawing2D
Imports System.IO
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim con As New MySqlConnection("Server=localhost; User Id=root; Password= ; Database= foros")
    ' tick will be used to draw 60 marks for each second on the clock
    Dim tick As Integer = 270
    'tick2 will be used to draw 12 bold marks on each hour on the clock
    Dim tick2 As Integer = 270
    Dim c1
    Dim sql
    Dim rdr As MySqlDataReader
    Dim com As New MySqlCommand
    Private Sub calculbl_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub calculbl_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub calcupb_Leave(sender As Object, e As EventArgs)

    End Sub

    Private Sub calcupb_MouseEnter(sender As Object, e As EventArgs)

    End Sub

    Private Sub calcupb_MouseLeave(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_MouseUp(sender As Object, e As MouseEventArgs)
        'PictureBox2.BackColor = Color.Transparent
        'Label1.BackColor = Color.Transparent
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        c1 = 0
        Timer1.Start()
        bcklout.Hide()
        formclck.Hide()
        bcklout.Visible = False
        formclck.Visible = False
        Dim ada As New MySqlDataAdapter("SELECT * FROM os", con)
        Dim dt As New DataTable
        Try
            ada.Fill(dt)
            Me.BackgroundImageLayout = dt.Rows(0).Item("layout")
            'MsgBox(Me.BackgroundImageLayout)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If Dir("D:\os\bck.txt") = "" Then
            Me.BackgroundImage = Nothing
        Else

            Dim a1 = File.ReadAllText("D:\os\bck.txt")
            Me.BackgroundImage = Image.FromFile(a1)
        End If
        If Dir("D:\os\alarm.txt") = "" Then
            Module1.incalarm = Nothing
        Else

            Dim a2 = File.ReadAllText("D:\os\alarm.txt")
            Module1.incalarm = a2
        End If
        If welcomeform.s = 1 Then
            darkness.Size = Me.Size
            darkness.Location = Me.Location
            darkness.TopMost = True
            darkness.Show()
            unpw.TopMost = True
            unpw.Show()
            unpw.BringToFront()
        End If
    End Sub

    Private Sub calcupb_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        calcu.Show()
    End Sub

    Private Sub calculbl_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        calcu.Show()
        calcu.TopMost = True
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim a = Date.Now.DayOfWeek
        Dim c
        dtee.Text = Date.Now.ToString("hh:mm:ss tt")
        If a = 1 Then
            c = "Monday"
        ElseIf a = 2
            c = "Tuesday"
        ElseIf a = 3
            c = "Wednesday"
        ElseIf a = 4
            c = "Thursday"
        ElseIf a = 5
            c = "Friday"
        ElseIf a = 6
            c = "Saturday"
        Else
            c = "Sunday"
        End If
        dte.Text = c & " " & Date.Now.ToString("MMMM dd, yyyy")
        If dtee.Text = Module1.incalarm Then
            MsgBox("Hoy gising")
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_MouseDoubleClick(sender As Object, e As MouseEventArgs)
        notepadform.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ' timer2 will draw the shape of the clock and the marks


    End Sub

    Private Sub Form1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Me.MouseDoubleClick
        formclck.Show()
        formclck.Left = Control.MousePosition.X
        formclck.Top = Control.MousePosition.Y
        formclck.Visible = True
    End Sub

    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        formclck.Hide()
        bcklout.Hide()
        bcklout.Visible = False
        formclck.Visible = False
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        bcklout.Show()
        bcklout.Top = formclck.Top + 20
        bcklout.Left = formclck.Left + formclck.Width
        bcklout.Visible = True

    End Sub

    Private Sub bcklout_VisibleChanged(sender As Object, e As EventArgs) Handles bcklout.VisibleChanged
        ' MsgBox(1)
        If Me.BackgroundImageLayout = 0 Then
            'MsgBox(Me.BackgroundImageLayout.ToString)
            l1.Checked = True
        ElseIf Me.BackgroundImageLayout = 1
            l3.Checked = True
        ElseIf Me.BackgroundImageLayout = 2
            l4.Checked = True
        ElseIf Me.BackgroundImageLayout = 3
            l2.Checked = True
        Else
            l5.Checked = True
        End If
    End Sub

    Private Sub l1_CheckedChanged(sender As Object, e As EventArgs) Handles l1.CheckedChanged

    End Sub

    Private Sub l2_CheckedChanged(sender As Object, e As EventArgs) Handles l2.CheckedChanged

    End Sub

    Private Sub l3_CheckedChanged(sender As Object, e As EventArgs) Handles l3.CheckedChanged

    End Sub

    Private Sub l4_CheckedChanged(sender As Object, e As EventArgs) Handles l4.CheckedChanged

    End Sub

    Private Sub l5_CheckedChanged(sender As Object, e As EventArgs) Handles l5.CheckedChanged

    End Sub
    Public Sub nottopmost()
        calcu.TopMost = False
        notepadform.TopMost = False
    End Sub
    Public Sub yestopmost()
        calcu.TopMost = True
        notepadform.TopMost = True
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        nottopmost()
        Dim OpenFile1 As New OpenFileDialog




        OpenFile1.Filter = ".png Files (PNG Images Only)|*.png"


        OpenFile1.Title = "Open a Document."
        If (OpenFile1.ShowDialog = System.Windows.Forms.DialogResult.OK) Then



            Me.BackgroundImage = Image.FromFile(OpenFile1.FileName)
                If Dir("D:\os\bck.txt") = "" Then

                Else
                    File.Delete("D:\os\bck.txt")
                End If
                Using writer As New StreamWriter("D:\os\bck.txt")
                    writer.Write(OpenFile1.FileName)
                    writer.Close()
                End Using
                bcklout.Hide()
                formclck.Hide()
            End If
            yestopmost()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles prcs.Paint

    End Sub

    Private Sub Panel3_MouseEnter(sender As Object, e As EventArgs) Handles prcs.MouseEnter
        Timer3.Start()
        Timer4.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If prcs.Top > 974 Then
            prcs.Top -= 4
        End If
        If prcs.Top <= 974 Then
            prcs.Top = 974
            Timer3.Stop()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        If prcs.Top < 1021 Then
            prcs.Top += 4
        End If
        If prcs.Top >= 1021 Then
            prcs.Top = 1021
            Timer4.Stop()
        End If
    End Sub

    Private Sub prcs_MouseLeave(sender As Object, e As EventArgs) Handles prcs.MouseLeave
        Timer4.Start()
        Timer3.Stop()
    End Sub

    Private Sub l3_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles l3.ContextMenuStripChanged

    End Sub

    Private Sub l3_Click(sender As Object, e As EventArgs) Handles l3.Click
        If l3.Checked = True Then
            Me.BackgroundImageLayout = 1
            sql = "UPDATE os SET layout = '" & 1 & "'"
            Try
                con.Open()
                com = New MySqlCommand(sql, con)
                rdr = com.ExecuteReader
                rdr.Close()
                con.Close()
            Catch ex As Exception
                MsgBox("Error 5: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub l2_Click(sender As Object, e As EventArgs) Handles l2.Click
        If l2.Checked = True Then
            Me.BackgroundImageLayout = 3
            sql = "UPDATE os SET layout = '" & 3 & "'"
            Try
                con.Open()
                com = New MySqlCommand(sql, con)
                rdr = com.ExecuteReader
                rdr.Close()
                con.Close()
            Catch ex As Exception
                MsgBox("Error 5: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub l1_Click(sender As Object, e As EventArgs) Handles l1.Click
        If l1.Checked = True Then
            Me.BackgroundImageLayout = 0
            sql = "UPDATE os SET layout = '" & 0 & "'"
            Try
                con.Open()
                com = New MySqlCommand(sql, con)
                rdr = com.ExecuteReader
                rdr.Close()
                con.Close()
            Catch ex As Exception
                MsgBox("Error 5: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub l4_Click(sender As Object, e As EventArgs) Handles l4.Click
        If l4.Checked = True Then
            Me.BackgroundImageLayout = 2
            sql = "UPDATE os SET layout = '" & 2 & "'"
            Try
                con.Open()
                com = New MySqlCommand(sql, con)
                rdr = com.ExecuteReader
                rdr.Close()
                con.Close()
            Catch ex As Exception
                MsgBox("Error 5: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub l5_Click(sender As Object, e As EventArgs) Handles l5.Click
        If l5.Checked = True Then
            Me.BackgroundImageLayout = 4
            sql = "UPDATE os SET layout = '" & 4 & "'"
            Try
                con.Open()
                com = New MySqlCommand(sql, con)
                rdr = com.ExecuteReader
                rdr.Close()
                con.Close()
            Catch ex As Exception
                MsgBox("Error 5: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs)
        ColorDialog1.ShowDialog()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles clcu.Click
        calcu.Show()
        calcu.TopMost = True
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles npad.Click
        notepadform.Show()
        notepadform.TopMost = True
    End Sub

    Private Sub npad_MouseEnter(sender As Object, e As EventArgs) Handles npad.MouseEnter
        Timer3.Start()
        Timer4.Stop()
    End Sub

    Private Sub npad_MouseLeave(sender As Object, e As EventArgs) Handles npad.MouseLeave
        Timer4.Start()
        Timer3.Stop()
    End Sub

    Private Sub clcu_MouseLeave(sender As Object, e As EventArgs) Handles clcu.MouseLeave
        Timer4.Start()
        Timer3.Stop()
    End Sub

    Private Sub clcu_MouseEnter(sender As Object, e As EventArgs) Handles clcu.MouseEnter
        Timer3.Start()
        Timer4.Stop()
    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ksmash.Show()
        ksmash.TopMost = True
    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Timer4.Start()
        Timer3.Stop()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox1.MouseEnter
        Timer3.Start()
        Timer4.Stop()
    End Sub

    Private Sub dte_Click(sender As Object, e As EventArgs) Handles dte.Click

    End Sub

    Private Sub dte_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dte.MouseDoubleClick
        dateee.Show()
        dateee.TopMost = True
        alarm.TopMost = False
        alarm.Hide()
    End Sub

    Private Sub dtee_Click(sender As Object, e As EventArgs) Handles dtee.Click
        dateee.Show()
        dateee.TopMost = True
        alarm.TopMost = False
        alarm.Hide()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles PictureBox3.Click
        paintrap.Show()
        paintrap.TopMost = True
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox3.MouseEnter
        Timer3.Start()
        Timer4.Stop()
    End Sub

    Private Sub PictureBox3_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox3.MouseLeave
        Timer3.Stop()
        Timer4.Start()
    End Sub

    Private Sub PictureBox2_Click_2(sender As Object, e As EventArgs) Handles PictureBox2.Click
        browser.Show()
        browser.TopMost = True
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox2.MouseEnter
        Timer3.Start()
        Timer4.Stop()
    End Sub

    Private Sub PictureBox2_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox2.MouseLeave
        Timer3.Stop()
        Timer4.Start()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Me.Close()
        End
    End Sub

    Private Sub PictureBox5_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox5.MouseLeave
        Timer3.Stop()
        Timer4.Start()
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As EventArgs) Handles PictureBox5.MouseEnter
        Timer4.Stop()
        Timer3.Start()
    End Sub
End Class
