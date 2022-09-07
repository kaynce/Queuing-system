Imports System.Data.OleDb

Public Class ForgotPassword2
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Private con As OleDbConnection = New OleDbConnection(conString)
    Private cm As OleDbCommand
    Private adapter As OleDbDataAdapter
    Private dt As DataTable = New DataTable()

    Private Property cmd As OleDbCommand
    Private counter As Integer = 1
 
    Private Sub ForgotPassword2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        questionTxt.SelectionStart = 0
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        passLabel.Visible = False
        passTxt.Visible = False
        okBtn.Visible = False
        questionTxt.Clear()
        answerTxt.Clear()
        passTxt.Clear()

        Me.Close()

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim attempt As Integer = 0

        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd1 = New OleDbCommand("select * from LoginRegistrar where Question = '" & questionTxt.Text & "' and Answer = '" & answerTxt.Text & "'", con)
                cmd1.Parameters.Add("Question", OleDbType.VarChar).Value = questionTxt.Text
                cmd1.Parameters.Add("Answer", OleDbType.VarChar).Value = answerTxt.Text

                Using adapter1 As New OleDbDataAdapter(cmd1)
                    Using table1 As New DataTable
                        adapter1.Fill(table1)

                        'Dim cmd3 As New OleDb.OleDbCommand("SELECT Password FROM LoginRegistrar", con)
                        'con.Open()
                        'Dim dr1 As OleDb.OleDbDataReader = cmd3.ExecuteReader


                        If table1.Rows.Count <> 0 Then

                            Using con1 As OleDbConnection = New OleDbConnection(conString)
                                Using cmd2 As New OleDb.OleDbCommand("SELECT Password FROM LoginRegistrar", con)

                                    con.Open()
                                    Dim dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader
                                    While dr1.Read()

                                        passLabel.Visible = True
                                        passTxt.Visible = True
                                        okBtn.Visible = True
                                        passTxt.Text = dr1("Password").ToString()
                                    End While


                                End Using
                            End Using


                        ElseIf answerTxt.Text = "" Then
                            MsgBox("Please enter your answer", vbCritical, "Answer")
                        ElseIf counter = 3 Then

                            MsgBox("We're sorry, we can't retrieve your password.", vbCritical, "")
                            Me.Close()
                            ForgotPassword.Close()

                            counter = 0


                        Else
                            MsgBox("Wrong answer. ", vbCritical, "Warning")
                            counter = counter + 1
                            answerTxt.Clear()



                        End If


                    End Using
                End Using
            End Using

        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles okBtn.Click
        passLabel.Visible = False
        passTxt.Visible = False
        okBtn.Visible = False
        questionTxt.Clear()
        answerTxt.Clear()
        passTxt.Clear()
        Me.Close()
        ForgotPassword.Close()

    End Sub
End Class