Imports System.IO
Public Class txtalrd
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        File.Delete(txtboxname.fname.Text)
        Using writer As New StreamWriter("D:\os\" & txtboxname.fname.Text & ".txt")
            writer.Write(notepadform.RichTextBox1.Text)
            writer.Close()
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.TopMost = False
        Me.Hide()
    End Sub
End Class