Public Class browser
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(RichTextBox1.Text)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        WebBrowser1.Stop()
    End Sub
End Class