Imports System.IO
Public Class notepadform
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        txtboxname.Show()
        txtboxname.TopMost = True
        ' Dim fileName2 As String = "D:\os\filedemo_file.txt"
        ' File.WriteAllText(fileName2, "This is a demo using the File class")
        Module1.snp = RichTextBox1.Text
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Form1.nottopmost()
        Dim OpenFile1 As New OpenFileDialog
        OpenFile1.Filter = "txt Files (Text Files)|*.txt"
        OpenFile1.Title = "Open a Document."
        If (OpenFile1.ShowDialog = System.Windows.Forms.DialogResult.OK) Then
            RichTextBox1.LoadFile(OpenFile1.FileName, RichTextBoxStreamType.PlainText)
        End If
        Form1.yestopmost()
    End Sub
End Class