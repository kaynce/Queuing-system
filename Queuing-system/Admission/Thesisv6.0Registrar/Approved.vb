Imports System.Data.OleDb

Public Class Approved

    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Dim con As OleDbConnection = New OleDbConnection(constring)
    Dim ds As DataSet = New DataSet
    Dim dataadapter As New OleDbDataAdapter("select * PendingLogs ", con)
    Dim cmd As OleDbCommand = New OleDbCommand()
    Dim dv As DataView
    Dim cm As CurrencyManager
    Dim datareader As OleDbDataReader
    Dim index As Integer = 0

    Dim inc As Integer
    Dim RecordNumber As Integer
    Dim maxrows As Integer
    Dim myDataSet As New DataSet
    Dim strConn As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"

    Dim adapter = New OleDbDataAdapter



    Private Sub Approved_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         Try

            Using con As OleDbConnection = New OleDbConnection(constring)
                Using ds1 As New DataSet
                    Dim str1 As String = "select * from PendingLogs"

                    adapter.SelectCommand = New OleDb.OleDbCommand(str1, con)
                    adapter.Fill(ds1)
                    PendingLogsDataGridView.DataSource = ds1.Tables(0)
                    PendingLogsDataGridView.Columns.RemoveAt(0)
                    PendingLogsDataGridView.Columns(0).Width = 150
                    PendingLogsDataGridView.Columns(4).Width = 0
                    PendingLogsDataGridView.Columns(5).Width = 0
                    PendingLogsDataGridView.Columns(6).Width = 0
                    PendingLogsDataGridView.Columns(7).Width = 0
                    PendingLogsDataGridView.Columns(8).Width = 0

                End Using
            End Using
        Catch
            'MsgBox("")
        Finally
        End Try

    End Sub
   

    Private Sub PendingLogsDataGridView_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles PendingLogsDataGridView.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.PendingLogsDataGridView.Rows(e.RowIndex)

            surnameTxt.Text = row.Cells("Surname").Value.ToString
            firstnameTxt.Text = row.Cells("Firstname").Value.ToString
            contactTxt.Text = row.Cells("Contact").Value.ToString
            usertypeTxt.Text = row.Cells("Usertype").Value.ToString
            usernameTxt.Text = row.Cells("Username").Value.ToString
            passwordTxt.Text = row.Cells("Password").Value.ToString
            questionTxt.Text = row.Cells("Question").Value.ToString
            answerTxt.Text = row.Cells("Answer").Value.ToString


        End If
    End Sub

    Private Sub approveBtn_Click_2(sender As Object, e As EventArgs) Handles approveBtn.Click
        If usertypeTxt.Text = "Registrar" Then
            If MsgBox("Are you sure you want to approve this client?", vbYesNo Or vbQuestion, "Approve") = MsgBoxResult.Yes Then

                Dim str1 As String
                str1 = "insert into LoginRegistrar([Surname],[Firstname],[Contact],[Usertype],[Username],[Password],[Question],[Answer]) Values(?,?,?,?,?,?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(constring)
                    Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                        Using cmd2 As OleDbCommand = New OleDbCommand(str1, con)

                            cmd1.Parameters.Add(New OleDbParameter("Surname", CType(surnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Firstname", CType(firstnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Contact", CType(contactTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Usertype", CType(usertypeTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Username", CType(usernameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Password", CType(passwordTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Question", CType(questionTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Answer", CType(answerTxt.Text, String)))

                            cmd2.Connection = con
                            cmd2.CommandText = "Delete From PendingLogs where Surname= @Surname"
                            cmd2.Parameters.Add(New OleDbParameter("@Surname", surnameTxt.Text))

                            con.Open()
                            cmd1.ExecuteNonQuery()
                            cmd2.ExecuteNonQuery()
                            surnameTxt.Clear()
                            firstnameTxt.Clear()
                            contactTxt.Clear()
                            usernameTxt.Clear()
                            passwordTxt.Clear()
                            questionTxt.Clear()
                            usertypeTxt.Clear()
                            answerTxt.Clear()

                            MsgBox("Successfully Approved.", vbInformation, "Approve")
                            Approved_Load(Me, New System.EventArgs)
                        End Using
                    End Using
                End Using
            End If

        ElseIf usertypeTxt.Text = "Guard" Then
            If MsgBox("Are you sure you want to approve this client?", vbYesNo Or vbQuestion, "Approve") = MsgBoxResult.Yes Then

                Dim str1 As String
                str1 = "insert into LoginGuard([Surname],[Firstname],[Contact],[Usertype],[Username],[Password],[Question],[Answer])  Values(?,?,?,?,?,?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(constring)
                    Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                        Using cmd2 As OleDbCommand = New OleDbCommand(str1, con)


                            cmd1.Parameters.Add(New OleDbParameter("Surname", CType(surnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Firstname", CType(firstnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Contact", CType(contactTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Usertype", CType(usertypeTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Username", CType(usernameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Password", CType(passwordTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Question", CType(questionTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Answer", CType(answerTxt.Text, String)))

                            cmd2.Connection = con
                            cmd2.CommandText = "Delete From PendingLogs where Surname= @Surname"
                            cmd2.Parameters.Add(New OleDbParameter("@Surname", surnameTxt.Text))

                            con.Open()
                            cmd1.ExecuteNonQuery()
                            cmd2.ExecuteNonQuery()

                            surnameTxt.Clear()
                            firstnameTxt.Clear()
                            contactTxt.Clear()
                            usernameTxt.Clear()
                            passwordTxt.Clear()
                            questionTxt.Clear()
                            usertypeTxt.Clear()
                            answerTxt.Clear()
                            MsgBox("Successfully Approved.", vbInformation, "Approve")
                            Approved_Load(Me, New System.EventArgs)
                        End Using
                    End Using
                End Using

            End If
        ElseIf usertypeTxt.Text = "Cashier" Then
            If MsgBox("Are you sure you want to approve this client?", vbYesNo Or vbQuestion, "Approve") = MsgBoxResult.Yes Then

                Dim str1 As String
                str1 = "insert into LoginCashier([Surname],[Firstname],[Contact],[Usertype],[Username],[Password],[Question],[Answer])  Values(?,?,?,?,?,?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(constring)
                    Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                        Using cmd2 As OleDbCommand = New OleDbCommand(str1, con)


                            cmd1.Parameters.Add(New OleDbParameter("Surname", CType(surnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Firstname", CType(firstnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Contact", CType(contactTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Usertype", CType(usertypeTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Username", CType(usernameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Password", CType(passwordTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Question", CType(questionTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Answer", CType(answerTxt.Text, String)))

                            cmd2.Connection = con
                            cmd2.CommandText = "Delete From PendingLogs where Surname= @Surname"
                            cmd2.Parameters.Add(New OleDbParameter("@Surname", surnameTxt.Text))

                            con.Open()
                            cmd1.ExecuteNonQuery()
                            cmd2.ExecuteNonQuery()

                            surnameTxt.Clear()
                            firstnameTxt.Clear()
                            contactTxt.Clear()
                            usernameTxt.Clear()
                            passwordTxt.Clear()
                            questionTxt.Clear()
                            usertypeTxt.Clear()
                            answerTxt.Clear()
                            MsgBox("Successfully Approved.", vbInformation, "Approve")
                            Approved_Load(Me, New System.EventArgs)
                        End Using
                    End Using
                End Using


            End If
        ElseIf usertypeTxt.Text = "Admission" Then
            If MsgBox("Are you sure you want to approve this client?", vbYesNo Or vbQuestion, "Approve") = MsgBoxResult.Yes Then

                Dim str1 As String
                str1 = "insert into LoginAdmin([Surname],[Firstname],[Contact],[Usertype],[Username],[Password],[Question],[Answer]) Values(?,?,?,?,?,?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(constring)
                    Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                        Using cmd2 As OleDbCommand = New OleDbCommand(str1, con)


                            cmd1.Parameters.Add(New OleDbParameter("Surname", CType(surnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Firstname", CType(firstnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Contact", CType(contactTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Usertype", CType(usertypeTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Username", CType(usernameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Password", CType(passwordTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Question", CType(questionTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Answer", CType(answerTxt.Text, String)))

                            cmd2.Connection = con
                            cmd2.CommandText = "Delete From PendingLogs where Surname= @Surname"
                            cmd2.Parameters.Add(New OleDbParameter("@Surname", surnameTxt.Text))

                            con.Open()
                            cmd1.ExecuteNonQuery()
                            cmd2.ExecuteNonQuery()
                            surnameTxt.Clear()
                            firstnameTxt.Clear()
                            contactTxt.Clear()
                            usernameTxt.Clear()
                            passwordTxt.Clear()
                            questionTxt.Clear()
                            usertypeTxt.Clear()
                            answerTxt.Clear()

                            MsgBox("Successfully Approved.", vbInformation, "Approve")
                            Approved_Load(Me, New System.EventArgs)
                        End Using
                    End Using
                End Using
            End If
        ElseIf usertypeTxt.Text = "Student Government" Then
            If MsgBox("Are you sure you want to approve this client?", vbYesNo Or vbQuestion, "Approve") = MsgBoxResult.Yes Then

                Dim str1 As String
                str1 = "insert into LoginSG([Surname],[Firstname],[Contact],[Usertype],[Username],[Password],[Question],[Answer])  Values(?,?,?,?,?,?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(constring)
                    Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                        Using cmd2 As OleDbCommand = New OleDbCommand(str1, con)


                            cmd1.Parameters.Add(New OleDbParameter("Surname", CType(surnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Firstname", CType(firstnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Contact", CType(contactTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Usertype", CType(usertypeTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Username", CType(usernameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Password", CType(passwordTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Question", CType(questionTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Answer", CType(answerTxt.Text, String)))

                            cmd2.Connection = con
                            cmd2.CommandText = "Delete From PendingLogs where Surname= @Surname"
                            cmd2.Parameters.Add(New OleDbParameter("@Surname", surnameTxt.Text))

                            con.Open()
                            cmd1.ExecuteNonQuery()
                            cmd2.ExecuteNonQuery()

                            surnameTxt.Clear()
                            firstnameTxt.Clear()
                            contactTxt.Clear()
                            usernameTxt.Clear()
                            passwordTxt.Clear()
                            questionTxt.Clear()
                            usertypeTxt.Clear()
                            answerTxt.Clear()

                            MsgBox("Successfully Approved.", vbInformation, "Approve")
                            Approved_Load(Me, New System.EventArgs)
                        End Using
                    End Using
                End Using
            End If
        ElseIf vbNo Then
            'MsgBox("ayos", vbInformation, "")

        ElseIf usertypeTxt.Text = "" Then
            MsgBox("Choose user to approve", vbInformation, "")
        End If
    End Sub



    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
       Try


            Using con As OleDbConnection = New OleDbConnection(constring)
                Using ds1 As New DataSet
                    Dim str1 As String = "select * from PendingLogs"

                    adapter.SelectCommand = New OleDb.OleDbCommand(str1, con)
                    adapter.Fill(ds1)
                    PendingLogsDataGridView.DataSource = ds1.Tables(0)
                    PendingLogsDataGridView.Columns.RemoveAt(0)
                    PendingLogsDataGridView.Columns(0).Width = 150

                    PendingLogsDataGridView.Columns(4).Width = 0
                    PendingLogsDataGridView.Columns(5).Width = 0
                    PendingLogsDataGridView.Columns(6).Width = 0
                    PendingLogsDataGridView.Columns(7).Width = 0
                    PendingLogsDataGridView.Columns(8).Width = 0

                End Using
            End Using
        Catch
            'MsgBox("")
        Finally
        End Try
    End Sub



    Private Sub approveBtn_Click(sender As Object, e As EventArgs)

    End Sub



    Private Sub declineBtn_Click(sender As Object, e As EventArgs) Handles declineBtn.Click


        If surnameTxt.Text = "" Then
            MsgBox("Select client to decline", vbInformation, "Decline")
        ElseIf surnameTxt.Text <> "" Then
            If MsgBox("Are you sure you want to decline this client?", vbYesNo Or vbQuestion, "Decline") = MsgBoxResult.Yes Then

                Dim str1 As String
                str1 = "insert into DeclinedLogs([Surname],[Firstname],[Contact],[Usertype],[Username],[Password],[Question],[Answer]) Values(?,?,?,?,?,?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(constring)
                    Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                        Using cmd2 As OleDbCommand = New OleDbCommand(str1, con)

                            cmd1.Parameters.Add(New OleDbParameter("Surname", CType(surnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Firstname", CType(firstnameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Contact", CType(contactTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Usertype", CType(usertypeTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Username", CType(usernameTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Password", CType(passwordTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Question", CType(questionTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Answer", CType(answerTxt.Text, String)))

                            cmd2.Connection = con
                            cmd2.CommandText = "Delete From PendingLogs where Surname= @Surname"
                            cmd2.Parameters.Add(New OleDbParameter("@Surname", surnameTxt.Text))

                            con.Open()
                            cmd1.ExecuteNonQuery()
                            cmd2.ExecuteNonQuery()
                            surnameTxt.Clear()
                            firstnameTxt.Clear()
                            contactTxt.Clear()
                            usernameTxt.Clear()
                            passwordTxt.Clear()
                            questionTxt.Clear()
                            usertypeTxt.Clear()
                            answerTxt.Clear()

                            MsgBox("Successfully Approved.", vbInformation, "Approve")
                            Approved_Load(Me, New System.EventArgs)

                        End Using
                    End Using
                End Using

            End If
        End If
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub Approved_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub
End Class