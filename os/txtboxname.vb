Imports System.IO
Public Class txtboxname
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Dir("D:\os\" & fname.Text & ".txt") = Nothing Then

            Using writer As New StreamWriter("D:\os\" & fname.Text & ".txt")
                writer.Write(notepadform.RichTextBox1.Text)
                MsgBox(fname.Text)
                writer.Close()
            End Using

        Else
            txtalrd.Show()
            Me.TopMost = False
            txtalrd.TopMost = True
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TopMost = False
        Me.Hide()
    End Sub
End Class