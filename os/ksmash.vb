Imports System.IO
Public Class ksmash
    Dim scre
    Dim cd = 45
    Private Sub ksmash_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub ksmash_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If cd > 0 Then
            scre += 1
            score.Text = scre
        End If

    End Sub

    Private Sub ksmash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        countdown.Start()
        If Dir("D:\os\hs.txt") = "" Then
            highscore.Text = "Highscore: "
        Else

            Dim a1 = File.ReadAllText("D:\os\hs.txt")
            highscore.Text = "Highscore: " & a1
        End If
    End Sub

    Private Sub countdown_Tick(sender As Object, e As EventArgs) Handles countdown.Tick
        If cd > 0 Then
            re.Enabled = False
            cd -= 1
            tmer.Text = cd
        End If
        If cd = 0 Then
            re.Enabled = True
            If Val(score.Text) > Val(highscore.Text) Then
                Label2.Text = "Congratulations, you Have beaten the highscore with the score of: "
                If Dir("D:\os\hs.txt") = "" Then

                Else
                    File.Delete("D:\os\hs.txt")
                End If
                highscore.Text = "Highscore: " & score.Text
                Using writer As New StreamWriter("D:\os\hs.txt")
                    writer.Write(score.Text)
                    writer.Close()
                End Using

            Else
                Label2.Text = "Game Over! Your Score is: "
            End If

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles re.Click
        cd = 45
        scre = 0
        score.Text = Nothing
        countdown.Start()
        Label2.Text = "Current Score:"
    End Sub
End Class