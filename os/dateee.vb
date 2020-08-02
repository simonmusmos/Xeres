Public Class dateee
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_Time.Text = Date.Now.ToString("hh:mm tt")
        dnow.Text = Date.Now.ToString("ddd, MMMM dd, yyyy")

    End Sub

    Private Sub dateee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MonthCalendar1.Hide()
        alarm.TopMost = False
        alarm.Hide()
        alarmmm.Text = Module1.incalarm
        lbl_Time.Text = Date.Now.ToString("hh:mm tt")
        dnow.Text = Date.Now.ToString("ddd, MMMM dd, yyyy")
        Timer1.Start()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.TopMost = False
        Me.Hide()
        alarm.Show()
        alarm.TopMost = True
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        stopwatch.Show()
        stopwatch.TopMost = True
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        cdt.Show()
        cdt.TopMost = True
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        If MonthCalendar1.Visible = True Then
            MonthCalendar1.Hide()
        Else
            MonthCalendar1.Show()
        End If
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged

    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs)

    End Sub
End Class