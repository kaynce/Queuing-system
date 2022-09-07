Public Class NotAvailable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = 1000

        If countdownLabel.Text = 10 Then

            countdownLabel.Text = Val(countdownLabel.Text) - 1

        ElseIf countdownLabel.Text = 0 Then

            Timer1.Enabled = False
            countdownLabel.Text = 10
            Me.Close()
        Else
            countdownLabel.Text = Val(countdownLabel.Text) - 1
        End If

    End Sub

    Private Sub RegistrarnotAvailable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class