Imports System.IO
Public Class unpw
    Private Sub sbutton_Click(sender As Object, e As EventArgs) Handles sbutton.Click
        Using writer As New StreamWriter("D:\os\un.txt")
            writer.Write(un.Text)
            writer.Close()
        End Using
        Using writer As New StreamWriter("D:\os\pw.txt")
            writer.Write(pw.Text)
            writer.Close()
        End Using
        Me.Close()
        darkness.Close()
    End Sub

    Private Sub unpw_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class