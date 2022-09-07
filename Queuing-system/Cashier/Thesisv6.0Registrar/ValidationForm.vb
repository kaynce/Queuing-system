Imports System.Data.OleDb

Public Class ValidationForm
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cm As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable = New DataTable()

    Private Property cmd As OleDbCommand

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Close()
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Dim str2 As String
                str2 = "insert into PendingLogs([Surname],[Firstname],[Contact],[Usertype],[Username],[Password],[Question],[Answer]) Values(?,?,?,?,?,?,?,?)"
                Using cmd2 As OleDbCommand = New OleDbCommand(str2, con)

                    cmd2.Parameters.Add(New OleDbParameter("Surname", CType(surnameTxt.Text, String)))
                    cmd2.Parameters.Add(New OleDbParameter("Firstname", CType(firstnameTxt.Text, String)))
                    cmd2.Parameters.Add(New OleDbParameter("Contact", CType(contactTxt.Text, String)))
                    cmd2.Parameters.Add(New OleDbParameter("Usertype", CType(userTypeTxt.Text, String)))
                    cmd2.Parameters.Add(New OleDbParameter("Username", CType(userTxt.Text, String)))
                    cmd2.Parameters.Add(New OleDbParameter("Password", CType(passTxt.Text, String)))
                    cmd2.Parameters.Add(New OleDbParameter("Question", CType(questionTxt.Text, String)))
                    cmd2.Parameters.Add(New OleDbParameter("Answer", CType(answerTxt.Text, String)))

                    con.Open()
                    cmd2.ExecuteNonQuery()


                    MsgBox("Information submitted.", vbInformation, "Submit information")
                    CreateAccount.firstnameTxt.Text = ""
                    CreateAccount.surnameTxt.Text = ""
                    CreateAccount.contactTxt.Text = ""
                    CreateAccount.userTxt.Text = ""
                    CreateAccount.passTxt.Text = ""
                    CreateAccount.confirmTxt.Text = ""
                    CreateAccount.questionTxt.SelectedIndex = -1
                    CreateAccount.answerTxt.Text = ""
                    CreateAccount.userTypeTxt.Text = ""
                    CreateAccount.userTypeTxt.SelectedIndex = -1

                 
                    Login.Show()
                    CreateAccount.Close()
                    Me.Close()

                End Using
            End Using


        Catch ex As Exception
            'con.Close()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        surnameTxt.Text = CreateAccount.surnameTxt.Text
        firstnameTxt.Text = CreateAccount.firstnameTxt.Text
        contactTxt.Text = CreateAccount.contactTxt.Text
        userTxt.Text = CreateAccount.userTxt.Text
        passTxt.Text = CreateAccount.passTxt.Text
        userTypeTxt.Text = CreateAccount.userTypeTxt.Text
        confirmTxt.Text = CreateAccount.confirmTxt.Text
        questionTxt.Text = CreateAccount.questionTxt.Text
        answerTxt.Text = CreateAccount.answerTxt.Text
        userTypeTxt.Text = CreateAccount.userTypeTxt.Text

        'CreateAccount.userTypeTxt.SelectedIndex = -1
    End Sub

    Private Sub ValidationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
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

    Private Sub passTxt_TextChanged(sender As Object, e As EventArgs) Handles passTxt.TextChanged

    End Sub

    Private Sub confirmTxt_TextChanged(sender As Object, e As EventArgs) Handles confirmTxt.TextChanged

    End Sub
End Class