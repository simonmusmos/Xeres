Public Class calcu
    Dim anss
    Dim inputz, poin As String
    Dim opin
    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        inputs.Text += "9"
        inputz += "9"
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        poin = 0
        If opin = 0 Then
            ans.Text = inputz
            opin = 4
        Else
            If opin = 1 Then
                ans.Text = Val(ans.Text) - inputz
            ElseIf opin = 2
                ans.Text = Val(ans.Text) * inputz
            ElseIf opin = 3
                ans.Text = Val(ans.Text) / inputz
            Else
                ans.Text = Val(ans.Text) + inputz
            End If

            opin = 4
        End If
        inputz = 0
        inputs.Text += " + "
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        inputs.Text += "0"
        inputz += "0"
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        inputs.Text += "1"
        inputz += "1"
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        inputs.Text += "2"
        inputz += "2"
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        inputs.Text += "3"
        inputz += "3"
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        inputs.Text += "6"
        inputz += "6"
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        inputs.Text += "5"
        inputz += "5"
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        inputs.Text += "4"
        inputz += "4"
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        inputs.Text += "8"
        inputz += "8"
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        inputs.Text += "7"
        inputz += "7"
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click
        poin = 0
        If opin = 0 Then
            ans.Text = inputz
            opin = 1
        Else
            If opin = 1 Then
                ans.Text = Val(ans.Text) - inputz
            ElseIf opin = 2
                ans.Text = Val(ans.Text) * inputz
            ElseIf opin = 3
                ans.Text = Val(ans.Text) / inputz
            Else
                ans.Text = Val(ans.Text) + inputz
            End If

            opin = 1
        End If
        inputz = 0
        inputs.Text += " - "
    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click
        poin = 0
        If opin = 0 Then
            ans.Text = inputz
            opin = 2
        Else
            If opin = 1 Then
                ans.Text = Val(ans.Text) - inputz
            ElseIf opin = 2
                ans.Text = Val(ans.Text) * inputz
            ElseIf opin = 3
                ans.Text = Val(ans.Text) / inputz
            Else
                ans.Text = Val(ans.Text) + inputz
            End If
            opin = 2
        End If
        inputz = 0
        inputs.Text += " * "
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        poin = 0
        If opin = 0 Then
            ans.Text = inputz
            opin = 3
        Else
            If opin = 1 Then
                ans.Text = Val(ans.Text) - inputz
            ElseIf opin = 2
                ans.Text = Val(ans.Text) * inputz
            ElseIf opin = 3
                ans.Text = Val(ans.Text) / inputz
            Else
                ans.Text = Val(ans.Text) + inputz
            End If

            opin = 3
        End If
        inputz = 0
        inputs.Text += " / "
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        If poin = 0 Then
            inputz += "."
            inputs.Text += "."
            poin += 1
        End If
    End Sub

    Private Sub Label19_Click(sender As Object, e As EventArgs) Handles Label19.Click

        If opin = 0 Then
            ans.Text = inputz
            opin = 3
        Else
            If opin = 1 Then
                ans.Text = Val(ans.Text) - inputz
            ElseIf opin = 2
                ans.Text = Val(ans.Text) * inputz
            ElseIf opin = 3
                ans.Text = Val(ans.Text) / inputz
            Else
                ans.Text = Val(ans.Text) + inputz
            End If

            opin = 4
        End If
        inputz = 0
        inputs.Text += " = "
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        inputs.Text = Nothing
        inputz = Nothing
        poin = 0
        opin = 0
        anss = 0
        ans.Text = Nothing
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        inputz = inputz * inputz
        inputs.Text += "^2"
    End Sub
End Class