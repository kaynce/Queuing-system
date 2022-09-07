Imports System.Data.OleDb

Public Class CashieraddPurpose
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Private con As OleDbConnection = New OleDbConnection(conString)
    Private cm As OleDbCommand
    Private adapter As OleDbDataAdapter
    Private dt As DataTable = New DataTable()

    Private Property cmd As OleDbCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        Try

            'Dim rowsAffected As String

            Using con As OleDbConnection = New OleDbConnection(conString)
                'Using cmd As New OleDbCommand("UPDATE RegistrarADDS SET Purpose1=@pur1 ,Purpose2=@pur2,Purpose3=@pur3,Purpose4=@pur4,Purpose5=@pur5,Purpose6=@pur6,Purpose7=@pur7,Purpose8=@pur8  WHERE Purpose9 =@pur9", con)
                'Using cmd As New OleDbCommand("UPDATE RegistrarADDS SET Purpose1=@pur1 WHERE Purpose2 = @pur2", con)
                Using cmd As New OleDbCommand("UPDATE CashierADDS SET Purpose1=pur1, Purpose2=pur2 , purpose3 =pur3,Purpose4=pur4, Purpose5=pur5 , purpose6 =pur6,Purpose7=pur7, Purpose8=pur8 , purpose9 =pur9", con)
                    cmd.Parameters.Add(New OleDbParameter("pur1", CType(purpose1.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("pur2", CType(purpose2.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("pur3", CType(purpose3.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("pur4", CType(purpose4.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("pur5", CType(purpose5.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("pur6", CType(purpose6.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("pur7", CType(purpose7.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("pur8", CType(purpose8.Text, String)))
                    cmd.Parameters.Add(New OleDbParameter("pur9", CType(purpose9.Text, String)))

                    'cmd.Parameters.Add("@pur1", OleDbType.Char).Value = purpose1.Text
                    'cmd.Parameters.Add("@pur2", OleDbType.Char).Value = purpose2.Text
                    'cmd.Parameters.Add("@offemail", OleDbType.VarBinary).Value = txtOfficerEmail
                    'cmd.Parameters.Add("@assname", OleDbType.VarBinary).Value = txtAssitName.Text
                    'cmd.Parameters.Add("@assemail", OleDbType.VarBinary).Value = txtAssitEmail
                    'cmd.Parameters.Add("@id", OleDbType.VarBinary).Value = txtRecordID.Text

                    Dim confirm = MsgBox("Are you sure you want to update this purpose?", vbYesNo Or vbQuestion, "Save changes")
                    If purpose1.Text = "" Then
                        MsgBox("Please enter purpose ", vbInformation, "")

                    ElseIf confirm = vbYes Then
                        con.Open()
                        cmd.ExecuteNonQuery()
                        MsgBox("Successfully Updated", vbInformation, "Update")
                        purpose1.Enabled = False
                        purpose2.Enabled = False
                        purpose3.Enabled = False
                        purpose4.Enabled = False
                        purpose5.Enabled = False
                        purpose6.Enabled = False
                        purpose7.Enabled = False
                        purpose8.Enabled = False
                        purpose9.Enabled = False
                    End If

                End Using
            End Using
        Catch
        Finally

        End Try



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles showBtn.Click
        Try
            purpose1.Enabled = True
            purpose2.Enabled = True
            purpose3.Enabled = True
            purpose4.Enabled = True
            purpose5.Enabled = True
            purpose6.Enabled = True
            purpose7.Enabled = True
            purpose8.Enabled = True
            purpose9.Enabled = True

            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd1 As New OleDb.OleDbCommand("SELECT Purpose1 FROM CashierADDS", con)
                    Using cmd2 As New OleDb.OleDbCommand("SELECT Purpose2 FROM CashierADDS", con)
                        Using cmd3 As New OleDb.OleDbCommand("SELECT Purpose3 FROM CashierADDS", con)
                            Using cmd4 As New OleDb.OleDbCommand("SELECT Purpose4 FROM CashierADDS", con)
                                Using cmd5 As New OleDb.OleDbCommand("SELECT Purpose5 FROM CashierADDS", con)
                                    Using cmd6 As New OleDb.OleDbCommand("SELECT Purpose6 FROM CashierADDS", con)
                                        Using cmd7 As New OleDb.OleDbCommand("SELECT Purpose7 FROM CashierADDS", con)
                                            Using cmd8 As New OleDb.OleDbCommand("SELECT Purpose8 FROM CashierADDS", con)
                                                Using cmd9 As New OleDb.OleDbCommand("SELECT Purpose9 FROM CashierADDS", con)
                                                    con.Open()
                                                    Using dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader
                                                        Using dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader
                                                            Using dr3 As OleDb.OleDbDataReader = cmd3.ExecuteReader
                                                                Using dr4 As OleDb.OleDbDataReader = cmd4.ExecuteReader
                                                                    Using dr5 As OleDb.OleDbDataReader = cmd5.ExecuteReader
                                                                        Using dr6 As OleDb.OleDbDataReader = cmd6.ExecuteReader
                                                                            Using dr7 As OleDb.OleDbDataReader = cmd7.ExecuteReader
                                                                                Using dr8 As OleDb.OleDbDataReader = cmd8.ExecuteReader
                                                                                    Using dr9 As OleDb.OleDbDataReader = cmd9.ExecuteReader


                                                                                        While dr1.Read()
                                                                                            purpose1.Text = dr1("Purpose1").ToString()

                                                                                            While dr2.Read()
                                                                                                purpose2.Text = dr2("Purpose2").ToString()

                                                                                                While dr3.Read()
                                                                                                    purpose3.Text = dr3("Purpose3").ToString()

                                                                                                    While dr4.Read()
                                                                                                        purpose4.Text = dr4("Purpose4").ToString()

                                                                                                        While dr5.Read()
                                                                                                            purpose5.Text = dr5("Purpose5").ToString()

                                                                                                            While dr6.Read()
                                                                                                                purpose6.Text = dr6("Purpose6").ToString()

                                                                                                                While dr7.Read()
                                                                                                                    purpose7.Text = dr7("Purpose7").ToString()

                                                                                                                    While dr8.Read()
                                                                                                                        purpose8.Text = dr8("Purpose8").ToString()

                                                                                                                        While dr9.Read()
                                                                                                                            purpose9.Text = dr9("Purpose9").ToString()

                                                                                                                        End While
                                                                                                                    End While
                                                                                                                End While
                                                                                                            End While
                                                                                                        End While
                                                                                                    End While
                                                                                                End While
                                                                                            End While
                                                                                        End While

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
                                End Using
                            End Using
                        End Using
                    End Using
                End Using
            End Using

        Finally
            'con.Close()
        End Try
    End Sub




    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        checkPassword(TextBox1.Text)
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        checkPassword(TextBox1.Text)
    End Sub

    Private Sub checkPassword(password As String)
        If Not password.Length > 5 Then
            Label1.Text = "The password must be more than 5 charcharacters"
            TextBox1.Clear()
        Else
            Label1.Text = "Password accepted"
        End If
    End Sub

    Private Sub RegistraraddPurpose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        checkPassword(TextBox1.Text)
    End Sub
    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        purpose1.Enabled = False
        purpose2.Enabled = False
        purpose3.Enabled = False
        purpose4.Enabled = False
        purpose5.Enabled = False
        purpose6.Enabled = False
        purpose7.Enabled = False
        purpose8.Enabled = False
        purpose9.Enabled = False
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub
End Class