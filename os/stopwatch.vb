Public Class stopwatch
    Dim a, b, c, d, e
    Private Sub h_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub m_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Stop()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
        a = 0
        b = 0
        c = 0
        d = 0
        milis.Text = 0
        min.Text = 0
        sec.Text = 0
        hou.Text = 0
        If Val(milis.Text) < 10 Then
            milis.Text = "0" & milis.Text
        End If
        If Val(sec.Text) < 10 Then
            sec.Text = "0" & sec.Text
        End If
        If Val(min.Text) < 10 Then
            min.Text = "0" & min.Text
        End If
        If Val(hou.Text) < 10 Then
            hou.Text = "0" & hou.Text
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub stopwatch_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        a += 1

        If a = 100 Then
            a = 0
            b += 1
            If b = 60 Then
                b = 0
                c += 1
                If c = 60 Then
                    c = 0
                    d += 1
                    hou.Text = d

                    If Val(hou.Text) < 10 Then
                        hou.Text = "0" & hou.Text
                    End If
                End If
                min.Text = c

                If Val(min.Text) < 10 Then
                    min.Text = "0" & min.Text
                End If

            End If
            sec.Text = b

            If Val(sec.Text) < 10 Then
                sec.Text = "0" & sec.Text
            End If

        End If
        milis.Text = a
        If Val(milis.Text) < 10 Then
            milis.Text = "0" & milis.Text
        End If

    End Sub
End Class