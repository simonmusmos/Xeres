Public Class paintrap
    Dim mustpaint As Boolean
    Private Sub paintrap_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wtb.Text = 1
        ltb.Text = 1
        Cursor = Cursors.Hand
        mustpaint = False
    End Sub

    Private Sub paintrap_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        mustpaint = True

    End Sub

    Private Sub paintrap_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        Dim a1, a2 As Integer
        a1 = Val(wtb.Text)
        a2 = Val(ltb.Text)
        If mustpaint = True Then
            Dim graphic As Graphics = CreateGraphics()
            graphic.FillEllipse(New SolidBrush(ColorDialog1.Color), e.X, e.Y, a1, a2)
        End If
    End Sub

    Private Sub paintrap_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        mustpaint = False
    End Sub

    Private Sub paintrap_Move(sender As Object, e As EventArgs) Handles Me.Move

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        ColorDialog1.ShowDialog()
    End Sub
End Class