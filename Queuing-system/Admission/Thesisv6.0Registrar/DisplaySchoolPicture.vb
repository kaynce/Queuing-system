Public Class DisplaySchoolPicture

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (System.IO.File.Exists(displayTxt.Text)) Then
            PictureBox1.Image = Image.FromFile(displayTxt.Text)
        End If

        If displayTxt.Text = "" Then
            PictureBox1.Hide()
        Else
            PictureBox1.Show()
            displayTxt.Visible = True
            PictureBox1.Image = Image.FromFile(displayTxt.Text)
            Me.BackgroundImageLayout = ImageLayout.Stretch

        End If
    End Sub

    Private Sub displayTxt_TextChanged(sender As Object, e As EventArgs) Handles displayTxt.TextChanged

    End Sub

    Private Sub DisplaySchoolPicture_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        OpenFileDialog1.ShowDialog()
        displayTxt.Text = OpenFileDialog1.FileName
        If (System.IO.File.Exists(displayTxt.Text)) Then
            PictureBox1.Image = Image.FromFile(displayTxt.Text)
            Me.BackgroundImageLayout = ImageLayout.Stretch
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        'If (System.IO.File.Exists(displayTxt.Text)) Then
        '    PictureBox1.Image = Image.FromFile(displayTxt.Text)
        'End If

        'If displayTxt.Text = "" Then
        '    PictureBox1.Hide()
        'Else
        '    PictureBox1.Show()
        '    displayTxt.Visible = True

        'End If
    End Sub
End Class