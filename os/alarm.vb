Imports System.IO
Public Class alarm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.incalarm = h.Text & ":" & m.Text & " " & t.Text
        If Dir("D:\os\alarm.txt") = "" Then

        Else
            File.Delete("D:\os\alarm.txt")
        End If
        dateee.alarmmm.Text = Module1.incalarm
        Using writer As New StreamWriter("D:\os\alarm.txt")
            writer.Write(Module1.incalarm)
            writer.Close()
        End Using
        Me.TopMost = False
        Me.Hide()
        dateee.TopMost = True
        dateee.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class