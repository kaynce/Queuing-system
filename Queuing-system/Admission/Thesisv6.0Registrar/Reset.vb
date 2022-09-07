Imports System.Data.OleDb

Public Class Reset

    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Dim con As OleDbConnection = New OleDbConnection(conString)


    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        If usertxt.Text = "" Then
            MsgBox("Please enter username.", vbCritical, "Queuing System")

        ElseIf passtxt.Text = "" Then
            MsgBox("Please enter password.", vbCritical, "Queuing System")


        ElseIf passtxt.Text = "" And usertxt.Text = "" Then
            MsgBox("Please enter username/passoword", vbCritical, "Queuing System")
        End If


        Using cmd = New OleDbCommand("select * from LoginAdmin where Username = '" & usertxt.Text & "' and Password = '" & passtxt.Text & "' ", con)
            cmd.Parameters.Add("@Username", OleDbType.VarChar).Value = usertxt.Text
            cmd.Parameters.Add("@Password", OleDbType.VarChar).Value = passtxt.Text



            Using adapter As New OleDbDataAdapter(cmd)
                Using table As New DataTable
                    adapter.Fill(table)

                    If table.Rows.Count <> 0 Then
                        'MsgBox("You are now logged in", vbInformation, "")
                        If MsgBox("Are you sure you want to reset queue number?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                            Using con As OleDbConnection = New OleDbConnection(conString)

                                Using cmd1 As OleDbCommand = New OleDbCommand("Delete * from RegistrarQueue", con)
                                    Using cmd11 As OleDbCommand = New OleDbCommand("Delete * from RegistrarOnhold", con)
                                        Using cmd111 As OleDbCommand = New OleDbCommand("Delete * from RegistrarDone", con)


                                            Using cmd2 As OleDbCommand = New OleDbCommand("Delete * from SGQueue", con)
                                                Using cmd22 As OleDbCommand = New OleDbCommand("Delete * from SGOnhold", con)
                                                    Using cmd222 As OleDbCommand = New OleDbCommand("Delete * from SGDone", con)

                                                        Using cmd3 As OleDbCommand = New OleDbCommand("Delete * from CashierQueue", con)
                                                            Using cmd33 As OleDbCommand = New OleDbCommand("Delete * from CashierOnhold", con)
                                                                Using cmd333 As OleDbCommand = New OleDbCommand("Delete * from CashierDone", con)


                                                                    Using cmd4 As OleDbCommand = New OleDbCommand("Delete * from AdminQueue", con)
                                                                        Using cmd44 As OleDbCommand = New OleDbCommand("Delete * from AdminOnhold", con)
                                                                            Using cmd444 As OleDbCommand = New OleDbCommand("Delete * from AdminDone", con)


                                                                                con.Open()
                                                                                cmd1.ExecuteNonQuery()
                                                                                cmd11.ExecuteNonQuery()
                                                                                cmd111.ExecuteNonQuery()

                                                                                cmd2.ExecuteNonQuery()
                                                                                cmd22.ExecuteNonQuery()
                                                                                cmd222.ExecuteNonQuery()

                                                                                cmd3.ExecuteNonQuery()
                                                                                cmd33.ExecuteNonQuery()
                                                                                cmd333.ExecuteNonQuery()

                                                                                cmd4.ExecuteNonQuery()
                                                                                cmd44.ExecuteNonQuery()
                                                                                cmd444.ExecuteNonQuery()



                                                                                MsgBox("Has been successfully reset.", vbInformation, "Queuing System")

                                                                                usertxt.Clear()
                                                                                passtxt.Clear()
                                                                                Me.Close()

                                                                            End Using
                                                                        End Using
                                                                    End Using
                                                                End Using
                                                            End Using
                                                        End Using
                                                    End Using
                                                End Using
                                            End Using
                                        End Using
                                    End Using
                                End Using
                            End Using
                        ElseIf vbNo Then

                        End If


                    End If
                End Using
            End Using
        End Using

    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
 
    End Sub

    'Private Sub usertxt_Leave(sender As Object, e As EventArgs) Handles usertxt.Leave
    '    If usertxt.Text = "" Then
    '        usertxt.TextAlign = HorizontalAlignment.Center
    '        usertxt.Text = "Username"
    '        usertxt.ForeColor = Color.Silver
    '    End If
    'End Sub

    'Private Sub usertxt_Enter(sender As Object, e As EventArgs) Handles usertxt.Enter
    '    If usertxt.Text = "Username" Then
    '        'usertxt.TextAlign = HorizontalAlignment.Left
    '        usertxt.Text = ""
    '        usertxt.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub passtxt_Leave(sender As Object, e As EventArgs) Handles passtxt.Leave
    '    If passtxt.Text = "" Then
    '        passtxt.TextAlign = HorizontalAlignment.Center
    '        passtxt.UseSystemPasswordChar = False
    '        passtxt.Text = "Password"
    '        passtxt.ForeColor = Color.Silver
    '    End If
    'End Sub

    'Private Sub passtxt_Enter(sender As Object, e As EventArgs) Handles passtxt.Enter
    '    If passtxt.Text = "Password" Then
    '        passtxt.UseSystemPasswordChar = True
    '        'passtxt.TextAlign = HorizontalAlignment.Left
    '        passtxt.Text = ""
    '        passtxt.ForeColor = Color.Black
    '    End If
    'End Sub

    Private Sub Reset_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'usertxt.TextAlign = HorizontalAlignment.Center
        'passtxt.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If passtxt.UseSystemPasswordChar = True Then

            passtxt.UseSystemPasswordChar = False
            Button2.Text = "Show"

        Else

            passtxt.UseSystemPasswordChar = True

            Button2.Text = "Hide"
        End If
    End Sub
End Class