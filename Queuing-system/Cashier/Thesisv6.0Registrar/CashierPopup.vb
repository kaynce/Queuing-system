﻿
Public Class CashierPopup

    Private Sub CashierPopup_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Visible = True
        Me.BringToFront()
        Me.Activate()


        Dim x As Integer
        Dim y As Integer

        x = Screen.PrimaryScreen.WorkingArea.Width
        y = Screen.PrimaryScreen.WorkingArea.Height - Me.Height


        Me.ShowInTaskbar = False



        Do Until x = Screen.PrimaryScreen.WorkingArea.Width - Me.Width

            x = x - 1
            Me.Location = New Point(x, y)



        Loop
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class