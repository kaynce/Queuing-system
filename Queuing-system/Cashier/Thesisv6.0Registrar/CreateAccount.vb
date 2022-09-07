Imports System.Data.OleDb

Public Class CreateAccount
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Private con As OleDbConnection = New OleDbConnection(conString)
    Private cm As OleDbCommand
    Private adapter As OleDbDataAdapter
    Private dt As DataTable = New DataTable()

    Private Property cmd As OleDbCommand
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If userTxt.Text = Nothing And passTxt.Text = Nothing And confirmTxt.Text = Nothing And userTxt.Text = Nothing Then
            MsgBox("Please fill up the form.", vbExclamation, "")

        ElseIf contactTxt.Text = "+63 ___ ___ ____" Then
            MsgBox("Choose question.", vbExclamation, "")
        ElseIf surnameTxt.Text = "" Then
            MsgBox("Write your surname.", vbExclamation, "")
        ElseIf firstnameTxt.Text = "" Then
            MsgBox("Write your firstname.", vbExclamation, "")
        ElseIf contactTxt.Text = "" Then
            MsgBox("Write your contact.", vbExclamation, "")
        ElseIf userTxt.Text = "" Then
            MsgBox("Write your surname.", vbExclamation, "")
        ElseIf passTxt.Text = "" Then
            MsgBox("Write your password.", vbExclamation, "")
        ElseIf confirmTxt.Text = "" Then
            MsgBox("Write your Confirm-password.", vbExclamation, "")
        ElseIf questionTxt.Text = "" Then
            MsgBox("Choose question.", vbExclamation, "")
       
        ElseIf userTypeTxt.SelectedIndex = -1 Then
            MsgBox("Choose usertype.", vbExclamation, "")


        ElseIf passTxt.Text = confirmTxt.Text Then
            'ValidateForm.surnameTxt.Text = surnameTxt.Text
            'ValidateForm.firstnameTxt.Text = firstnameTxt.Text
            'ValidateForm.contactTxt.Text = contactTxt.Text
            'ValidateForm.userTxt.Text = userTxt.Text
            'ValidateForm.passTxt.Text = passTxt.Text
            'ValidateForm.usertypeTxt.Text = userTypeTxt.Text

            ValidationForm.ShowDialog()


        Else
            MsgBox("Password does not match.", vbExclamation, "")


        End If



        'If usertxt.Text.Length >= 5 Then


        'Else
        '    MessageBox.Show("The minimum character is 5")
        'End If
        'con.Open()
        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd1 = New OleDbCommand("select * from PendingLogsHistory where Username = '" & userTxt.Text & "'", con)
                    cmd1.Parameters.Add("@username1", OleDbType.VarChar).Value = userTxt.Text

                    con.Open()
                    Dim reader1 As OleDbDataReader = cmd1.ExecuteReader()
                    If (reader1.HasRows) Then
                        MsgBox("The username is already taken", vbCritical, "")
                        ValidationForm.Close()
                    End If
                End Using
            End Using

        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    Private Sub CreateAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        checkPassword(passTxt.Text)
        Label13.Text = ""
       
    End Sub

    Private Sub userTxt_TextChanged(sender As Object, e As EventArgs) Handles userTxt.TextChanged

        ''If userTxt.Text.Length = 10 Then
        '    MessageBox.Show("The minimum character is 10")
        '    userTxt.Clear()
        'End If
        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd1 = New OleDbCommand("select * from PendingLogs where Username = '" & userTxt.Text & "'", con)
                    Using cmd2 = New OleDbCommand("select * from PendingLogsHistory where Username = '" & userTxt.Text & "'", con)
                        Using cmd3 = New OleDbCommand("select * from LoginCashier where Username = '" & userTxt.Text & "'", con)


                            'cmd1.Parameters.Add(New OleDbParameter("Username", CType(userTxt.Text, String)))
                            'cmd2.Parameters.Add(New OleDbParameter("Username", CType(userTxt.Text, String)))
                            'cmd3.Parameters.Add(New OleDbParameter("Username", CType(userTxt.Text, String)))

                            cmd1.Parameters.Add("Username", OleDbType.VarChar).Value = userTxt.Text
                            cmd2.Parameters.Add("Username", OleDbType.VarChar).Value = userTxt.Text
                            cmd3.Parameters.Add("Username", OleDbType.VarChar).Value = userTxt.Text

                            con.Open()
                            Dim reader1 As OleDbDataReader = cmd1.ExecuteReader()
                            Dim reader2 As OleDbDataReader = cmd2.ExecuteReader()
                            Dim reader3 As OleDbDataReader = cmd3.ExecuteReader()

                            If (reader1.HasRows) Then
                                MsgBox("The username is already taken", vbCritical, "")
                                userTxt.Clear()
                            ElseIf (reader2.HasRows) Then
                                MsgBox("The username is already taken", vbCritical, "")
                                userTxt.Clear()
                            ElseIf (reader3.HasRows) Then
                                MsgBox("The username is already taken", vbCritical, "")
                                userTxt.Clear()
                            End If
                        End Using
                    End Using
                End Using
            End Using



        Catch ex As Exception
            con.Close()
        End Try
    End Sub

    Private Sub surnameTxt_TextChanged(sender As Object, e As EventArgs) Handles surnameTxt.TextChanged
      
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub
    Private Sub passTxt_Leave(sender As Object, e As EventArgs) Handles passTxt.Leave
        checkPassword(passTxt.Text)
    End Sub
    Private Sub checkPassword(password As String)
        If Not password.Length > 5 Then
            Label10.Text = "The password must be more than 5 charcharacters"
            passTxt.Clear()
        Else
            Label10.Text = ""
        End If
    End Sub



 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If passTxt.UseSystemPasswordChar = True Then

            passTxt.UseSystemPasswordChar = False
            Button2.Text = "Show"

        Else

            passTxt.UseSystemPasswordChar = True

            Button2.Text = "Hide"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If confirmTxt.UseSystemPasswordChar = True Then

            confirmTxt.UseSystemPasswordChar = False
            Button3.Text = "Show"

        Else

            confirmTxt.UseSystemPasswordChar = True

            Button3.Text = "Hide"
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If passTxt.Text <> "" And confirmTxt.Text <> "" And passTxt.Text = confirmTxt.Text = True Then
            Label13.Text = "Password match"
        Else
            Label13.Text = ""
        End If
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
     
        Me.Close()

    End Sub

  
    Private Sub contactTxt_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles contactTxt.MaskInputRejected

    End Sub

    Private Sub firstnameTxt_TextChanged(sender As Object, e As EventArgs) Handles firstnameTxt.TextChanged

    End Sub

    Private Sub contactTxt_Leave(sender As Object, e As EventArgs) Handles contactTxt.Leave
        'If contactTxt.Text = "" Then
        '    contactTxt.TextAlign = HorizontalAlignment.Center
        '    contactTxt.Text = "+63 000 000 0000"
        '    contactTxt.ForeColor = Color.Silver
        'End If
    End Sub

    Private Sub contactTxt_Enter(sender As Object, e As EventArgs) Handles contactTxt.Enter
        'If userTxt.Text = "Username" Then
        '    'usertxt.TextAlign = HorizontalAlignment.Left
        '    userTxt.Text = ""
        '    userTxt.ForeColor = Color.Black
        'End If
    End Sub

    Private Sub confirmTxt_TextChanged(sender As Object, e As EventArgs) Handles confirmTxt.TextChanged
        'confirmTxt.UseSystemPasswordChar = True
    End Sub

    Private Sub passTxt_TextChanged(sender As Object, e As EventArgs) Handles passTxt.TextChanged
        'passTxt.UseSystemPasswordChar = True
    End Sub
End Class