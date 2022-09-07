Imports System.Data.OleDb

Public Class ForgotPassword
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Private con As OleDbConnection = New OleDbConnection(conString)
    Private cm As OleDbCommand
    Private adapter As OleDbDataAdapter
    Private dt As DataTable = New DataTable()

    Private Property cmd As OleDbCommand
    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub continueBtn_Click_1(sender As Object, e As EventArgs) Handles continueBtn.Click
        Dim attempt As Integer = 0

        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd1 = New OleDbCommand("select * from LoginGuard where Username = '" & userTxt.Text & "' and Usertype = '" & userTypeTxt.Text & "'", con)
                cmd1.Parameters.Add("Username", OleDbType.VarChar).Value = userTxt.Text
                cmd1.Parameters.Add("Usertype", OleDbType.VarChar).Value = userTypeTxt.Text

                Using adapter1 As New OleDbDataAdapter(cmd1)
                    Using table1 As New DataTable
                        adapter1.Fill(table1)

                        If table1.Rows.Count <> 0 Then

                            Using con1 As OleDbConnection = New OleDbConnection(conString)
                                Using cmd2 As New OleDb.OleDbCommand("SELECT Question FROM LoginGuard", con)

                                    con.Open()
                                    Using dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader
                                        While dr1.Read()
                                            ForgotPassword2.answerTxt.Focus()
                                            ForgotPassword2.questionTxt.Text = dr1("Question").ToString()
                                        End While


                                        userTxt.Clear()

                                        ForgotPassword2.ShowDialog()

                                    End Using
                                End Using
                            End Using


                        End If
                    End Using
                End Using
            End Using

        End Using
    End Sub

    Private Sub cancelBtn_Click_1(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Close()
    End Sub
End Class