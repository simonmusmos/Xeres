Imports System.IO
Public Class welcomeform
    Public s
    Private Sub welcomeform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Location = New Point(0, 0)
        Panel3.Location = New Point(0, 510)
        If Dir("D:\os\un.txt") = "" And Dir("D:\os\pw.txt") = "" Then
            s = 1
        Else
            Module1.un = File.ReadAllText("D:\os\un.txt")
            Module1.pw = File.ReadAllText("D:\os\pw.txt")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Panel1.Top -= 4
        Panel3.Top += 4
        If Panel1.Top <= -510 Then
            If s = 1 Then
                Me.Hide()
                Form1.Show()
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Timer1.Start()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Timer1.Start()
    End Sub

    Private Sub sbutton_Click(sender As Object, e As EventArgs) Handles sbutton.Click
        If s = 0 Then
            If un.Text = Module1.un And pw.Text = Module1.pw Then
                Form1.Show()
                Me.Hide()
            Else
                MsgBox("Invalid Username or Password")
            End If
        End If
    End Sub
End Class