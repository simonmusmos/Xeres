Public Class cdt
    Dim b, c, d, f As Integer
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        hou.Text = RichTextBox1.Text
        If RichTextBox1.Text = Nothing Then
            hou.Text = "00"
        End If
    End Sub
    Private Sub hou_Click(sender As Object, e As EventArgs) Handles hou.Click
        RichTextBox1.Focus()
    End Sub
    Private Sub RichTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RichTextBox1.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub min_Click(sender As Object, e As EventArgs) Handles min.Click
        mintb.Focus()
    End Sub
    Private Sub sec_Click(sender As Object, e As EventArgs) Handles sec.Click
        sectb.Focus()
    End Sub
    Private Sub milis_Click(sender As Object, e As EventArgs) Handles milis.Click
        milistb.Focus()
    End Sub
    Private Sub mintb_TextChanged(sender As Object, e As EventArgs) Handles mintb.TextChanged
        min.Text = mintb.Text
        If mintb.Text = Nothing Then
            min.Text = "00"
        End If
    End Sub
    Private Sub mintb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles mintb.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub sectb_TextChanged(sender As Object, e As EventArgs) Handles sectb.TextChanged
        sec.Text = sectb.Text
        If sectb.Text = Nothing Then
            sec.Text = "00"
        End If
    End Sub
    Private Sub milistb_TabIndexChanged(sender As Object, e As EventArgs) Handles milistb.TabIndexChanged
    End Sub
    Private Sub milistb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles milistb.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub sectb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles sectb.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
    Private Sub milistb_TextChanged(sender As Object, e As EventArgs) Handles milistb.TextChanged
        milis.Text = milistb.Text
        If milistb.Text = Nothing Then
            milis.Text = "00"
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "GO" Then
            If (milis.Text = "00" And min.Text = "00" And sec.Text = "00" And hou.Text = "00") = False Then
                Dim a As Integer
                a = Val(milis.Text) / 100
                sec.Text = Val(sec.Text) + a
                milis.Text = Val(milis.Text) Mod 100
                a = Val(sec.Text) / 60
                min.Text = Val(min.Text) + a
                sec.Text = Val(sec.Text) Mod 60
                a = Val(min.Text) / 60
                hou.Text = Val(hou.Text) + a
                min.Text = Val(min.Text) Mod 60
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
                Button1.Text = "Stop"
                Timer1.Start()
            End If
        Else
            Button1.Text = "GO"
            Timer1.Stop()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Text = "GO"
        Timer1.Stop()
        f = 0
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
        If hou.Text = "00" Then
            RichTextBox1.Text = Nothing
        End If
        If min.Text = "00" Then
            mintb.Text = Nothing
        End If
        If sec.Text = "00" Then
            sectb.Text = Nothing
        End If
        If milis.Text = "00" Then
            milistb.Text = Nothing
        End If
    End Sub
    Private Sub cdt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sectb.Location = New Point(-500, -500)
        milistb.Location = New Point(-500, -500)
        mintb.Location = New Point(-500, -500)
        RichTextBox1.Location = New Point(-500, -500)
    End Sub
    Public Sub DEC()
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        b = Val(milis.Text)
        c = Val(sec.Text)
        d = Val(min.Text)
        f = Val(hou.Text)
        b -= 1.45
        If b <= -1 Then
            b = 99
            c -= 1
            If c <= -1 Then
                c = 59
                d -= 1
                If d <= -1 Then
                    d = 59
                    f -= 1
                    hou.Text = f
                    RichTextBox1.Text = f
                    If Val(hou.Text) < 10 Then
                        hou.Text = "0" & hou.Text
                    End If
                    If hou.Text = "00" Then
                        RichTextBox1.Text = Nothing
                    End If
                End If
                min.Text = d
                mintb.Text = d
                If Val(min.Text) < 10 Then
                    min.Text = "0" & min.Text
                End If
                If min.Text = "00" Then
                    mintb.Text = Nothing
                End If
            End If
            sec.Text = c
            sectb.Text = c
            If Val(sec.Text) < 10 Then
                sec.Text = "0" & sec.Text
            End If
            If sec.Text = "00" Then
                sectb.Text = Nothing
            End If
        End If
        milis.Text = b
        milistb.Text = b
        If Val(milis.Text) < 10 Then
            milis.Text = "0" & milis.Text
        End If
        If milis.Text = "00" Then
            milistb.Text = Nothing
        End If
        If milis.Text = "00" And sec.Text = "00" And min.Text = "00" And hou.Text = "00" Then
            Timer1.Stop()
            MsgBox("times up!")
            Button1.Text = "GO"
        End If
    End Sub
End Class