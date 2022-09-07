Imports System.Data.OleDb

Public Class GuardPalace
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Private con As OleDbConnection = New OleDbConnection(conString)
    Private cm As OleDbCommand
    Private adapter As OleDbDataAdapter
    Private dt As DataTable = New DataTable()

    Private Property cmd As OleDbCommand
    Private index As Integer = 0

    Private Sub GuardPalace_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Focus()
        MenuStrip1.ForeColor = Color.White
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Sub switchPanel(ByVal panel As Form)
        'Try


        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
        'Catch ex As Exception
        'Finally

        'End Try
    End Sub




    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs)
        If CheckBox1.Checked Then
            logoutBtn.Visible = True
            MenuStrip1.Visible = True
        Else
            logoutBtn.Visible = False
            MenuStrip1.Visible = False
        End If
    End Sub
    Private Sub logoutBtn_Click_1(sender As Object, e As EventArgs)
        'If MessageBox.Show("Are you sure you want to Log out?", "Log out", MessageBoxButtons.YesNo) = DialogResult.Yes Then
        '    Login.Show()
        '    Me.Hide()
        'End If
    End Sub

    Private Sub registrarBtn_Click(sender As Object, e As EventArgs) Handles registrarBtn.Click

        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                con.Open()
                Using cmd1 As New OleDb.OleDbCommand("SELECT HasLogin FROM RegistrarHasLogin", con)

                    Using dtareader As OleDb.OleDbDataReader = cmd1.ExecuteReader

                        If dtareader.HasRows = 0 Then
                            'MsgBox("Registrar is not available right now.", vbInformation, "Registrar")
                            CashierbtnQueue.Close()
                            SGbtnQueue.Close()
                            AdminbtnQueue.Close()
                            NotAvailable.messageLabel.Text = "Registrar is not available right now."
                            NotAvailable.Timer1.Enabled = True
                            NotAvailable.countdownLabel.Text = 10

                            NotAvailable.ShowDialog()


                        ElseIf dtareader.HasRows <> 0 Then

                            Using cmd2 As New OleDbCommand("SELECT Purpose1 FROM RegistrarADDS", con)
                                Using cmd3 As New OleDbCommand("SELECT Purpose2 FROM RegistrarADDS", con)
                                    Using cmd4 As New OleDbCommand("SELECT Purpose3 FROM RegistrarADDS", con)
                                        Using cmd5 As New OleDbCommand("SELECT Purpose4 FROM RegistrarADDS", con)
                                            Using cmd6 As New OleDbCommand("SELECT Purpose5 FROM RegistrarADDS", con)
                                                Using cmd7 As New OleDbCommand("SELECT Purpose6 FROM RegistrarADDS", con)
                                                    Using cmd8 As New OleDbCommand("SELECT Purpose7 FROM RegistrarADDS", con)
                                                        Using cmd9 As New OleDbCommand("SELECT Purpose8 FROM RegistrarADDS", con)
                                                            Using cmd10 As New OleDbCommand("SELECT Purpose9 FROM RegistrarADDS", con)


                                                                Using dr1 As OleDb.OleDbDataReader = cmd2.ExecuteReader
                                                                    Using dr2 As OleDb.OleDbDataReader = cmd3.ExecuteReader
                                                                        Using dr3 As OleDb.OleDbDataReader = cmd4.ExecuteReader
                                                                            Using dr4 As OleDb.OleDbDataReader = cmd5.ExecuteReader
                                                                                Using dr5 As OleDb.OleDbDataReader = cmd6.ExecuteReader
                                                                                    Using dr6 As OleDb.OleDbDataReader = cmd7.ExecuteReader
                                                                                        Using dr7 As OleDb.OleDbDataReader = cmd8.ExecuteReader
                                                                                            Using dr8 As OleDb.OleDbDataReader = cmd9.ExecuteReader
                                                                                                Using dr9 As OleDb.OleDbDataReader = cmd10.ExecuteReader


                                                                                                    While dr1.Read()
                                                                                                        RegistrarbtnQueue.purpose1.Text = dr1("Purpose1").ToString()

                                                                                                        While dr2.Read()
                                                                                                            RegistrarbtnQueue.purpose2.Text = dr2("Purpose2").ToString()

                                                                                                            While dr3.Read()
                                                                                                                RegistrarbtnQueue.purpose3.Text = dr3("Purpose3").ToString()

                                                                                                                While dr4.Read()
                                                                                                                    RegistrarbtnQueue.purpose4.Text = dr4("Purpose4").ToString()

                                                                                                                    While dr5.Read()
                                                                                                                        RegistrarbtnQueue.purpose5.Text = dr5("Purpose5").ToString()

                                                                                                                        While dr6.Read()
                                                                                                                            RegistrarbtnQueue.purpose6.Text = dr6("Purpose6").ToString()

                                                                                                                            While dr7.Read()
                                                                                                                                RegistrarbtnQueue.purpose7.Text = dr7("Purpose7").ToString()

                                                                                                                                While dr8.Read()
                                                                                                                                    RegistrarbtnQueue.purpose8.Text = dr8("Purpose8").ToString()

                                                                                                                                    While dr9.Read()
                                                                                                                                        RegistrarbtnQueue.purpose9.Text = dr9("Purpose9").ToString()

                                                                                                                                        RegistrarbtnQueue.TransparencyKey = RegistrarbtnQueue.BackColor
                                                                                                                                        switchPanel(RegistrarbtnQueue)
                                                                                                                                        RegistrarbtnQueue.TransparencyKey = RegistrarbtnQueue.BackColor

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



                        End If
                    End Using
                End Using
            End Using

        Catch

        Finally
        End Try
    End Sub

    Private Sub cashierBtn_Click(sender As Object, e As EventArgs) Handles cashierBtn.Click
        Try

            Using con As OleDbConnection = New OleDbConnection(conString)
                con.Open()
                Using cmd1 As New OleDb.OleDbCommand("SELECT HasLogin FROM CashierHasLogin", con)

                    Using dtareader As OleDb.OleDbDataReader = cmd1.ExecuteReader
                        If dtareader.HasRows = 0 Then
                            RegistrarbtnQueue.Close()
                            SGbtnQueue.Close()
                            AdminbtnQueue.Close()
                            NotAvailable.messageLabel.Text = "Cashier is not available right now."
                            NotAvailable.Timer1.Enabled = True
                            NotAvailable.countdownLabel.Text = 10
                            NotAvailable.ShowDialog()

                        ElseIf dtareader.HasRows <> 0 Then

                            Using cmd2 As New OleDbCommand("SELECT Purpose1 FROM CashierADDS", con)
                                Using cmd3 As New OleDbCommand("SELECT Purpose2 FROM CashierADDS", con)
                                    Using cmd4 As New OleDbCommand("SELECT Purpose3 FROM CashierADDS", con)
                                        Using cmd5 As New OleDbCommand("SELECT Purpose4 FROM CashierADDS", con)
                                            Using cmd6 As New OleDbCommand("SELECT Purpose5 FROM CashierADDS", con)
                                                Using cmd7 As New OleDbCommand("SELECT Purpose6 FROM CashierADDS", con)
                                                    Using cmd8 As New OleDbCommand("SELECT Purpose7 FROM CashierADDS", con)
                                                        Using cmd9 As New OleDbCommand("SELECT Purpose8 FROM CashierADDS", con)
                                                            Using cmd10 As New OleDbCommand("SELECT Purpose9 FROM CashierADDS", con)


                                                                Using dr1 As OleDb.OleDbDataReader = cmd2.ExecuteReader
                                                                    Using dr2 As OleDb.OleDbDataReader = cmd3.ExecuteReader
                                                                        Using dr3 As OleDb.OleDbDataReader = cmd4.ExecuteReader
                                                                            Using dr4 As OleDb.OleDbDataReader = cmd5.ExecuteReader
                                                                                Using dr5 As OleDb.OleDbDataReader = cmd6.ExecuteReader
                                                                                    Using dr6 As OleDb.OleDbDataReader = cmd7.ExecuteReader
                                                                                        Using dr7 As OleDb.OleDbDataReader = cmd8.ExecuteReader
                                                                                            Using dr8 As OleDb.OleDbDataReader = cmd9.ExecuteReader
                                                                                                Using dr9 As OleDb.OleDbDataReader = cmd10.ExecuteReader


                                                                                                    While dr1.Read()
                                                                                                        CashierbtnQueue.purpose1.Text = dr1("Purpose1").ToString()

                                                                                                        While dr2.Read()
                                                                                                            CashierbtnQueue.purpose2.Text = dr2("Purpose2").ToString()

                                                                                                            While dr3.Read()
                                                                                                                CashierbtnQueue.purpose3.Text = dr3("Purpose3").ToString()

                                                                                                                While dr4.Read()
                                                                                                                    CashierbtnQueue.purpose4.Text = dr4("Purpose4").ToString()

                                                                                                                    While dr5.Read()
                                                                                                                        CashierbtnQueue.purpose5.Text = dr5("Purpose5").ToString()

                                                                                                                        While dr6.Read()
                                                                                                                            CashierbtnQueue.purpose6.Text = dr6("Purpose6").ToString()

                                                                                                                            While dr7.Read()
                                                                                                                                CashierbtnQueue.purpose7.Text = dr7("Purpose7").ToString()

                                                                                                                                While dr8.Read()
                                                                                                                                    CashierbtnQueue.purpose8.Text = dr8("Purpose8").ToString()

                                                                                                                                    While dr9.Read()
                                                                                                                                        CashierbtnQueue.purpose9.Text = dr9("Purpose9").ToString()

                                                                                                                                        switchPanel(CashierbtnQueue)

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

                        End If
                    End Using
                End Using
            End Using
        Catch

        Finally

        End Try
    End Sub

    Private Sub sgBtn_Click(sender As Object, e As EventArgs) Handles sgBtn.Click
        Try

            Using con As OleDbConnection = New OleDbConnection(conString)
                con.Open()
                Using cmd1 As New OleDb.OleDbCommand("SELECT HasLogin FROM SGHasLogin", con)

                    Using dtareader As OleDb.OleDbDataReader = cmd1.ExecuteReader
                        If dtareader.HasRows = 0 Then
                            CashierbtnQueue.Close()
                            RegistrarbtnQueue.Close()
                            AdminbtnQueue.Close()
                            NotAvailable.messageLabel.Text = "Student Government is not available right now."
                            NotAvailable.Timer1.Enabled = True
                            NotAvailable.countdownLabel.Text = 10
                            NotAvailable.ShowDialog()

                        ElseIf dtareader.HasRows <> 0 Then

                            Using cmd2 As New OleDbCommand("SELECT Purpose1 FROM SGADDS", con)
                                Using cmd3 As New OleDbCommand("SELECT Purpose2 FROM SGADDS", con)
                                    Using cmd4 As New OleDbCommand("SELECT Purpose3 FROM SGADDS", con)
                                        Using cmd5 As New OleDbCommand("SELECT Purpose4 FROM SGADDS", con)
                                            Using cmd6 As New OleDbCommand("SELECT Purpose5 FROM SGADDS", con)
                                                Using cmd7 As New OleDbCommand("SELECT Purpose6 FROM SGADDS", con)
                                                    Using cmd8 As New OleDbCommand("SELECT Purpose7 FROM SGADDS", con)
                                                        Using cmd9 As New OleDbCommand("SELECT Purpose8 FROM SGADDS", con)
                                                            Using cmd10 As New OleDbCommand("SELECT Purpose9 FROM SGADDS", con)


                                                                Using dr1 As OleDb.OleDbDataReader = cmd2.ExecuteReader
                                                                    Using dr2 As OleDb.OleDbDataReader = cmd3.ExecuteReader
                                                                        Using dr3 As OleDb.OleDbDataReader = cmd4.ExecuteReader
                                                                            Using dr4 As OleDb.OleDbDataReader = cmd5.ExecuteReader
                                                                                Using dr5 As OleDb.OleDbDataReader = cmd6.ExecuteReader
                                                                                    Using dr6 As OleDb.OleDbDataReader = cmd7.ExecuteReader
                                                                                        Using dr7 As OleDb.OleDbDataReader = cmd8.ExecuteReader
                                                                                            Using dr8 As OleDb.OleDbDataReader = cmd9.ExecuteReader
                                                                                                Using dr9 As OleDb.OleDbDataReader = cmd10.ExecuteReader


                                                                                                    While dr1.Read()
                                                                                                        SGbtnQueue.purpose1.Text = dr1("Purpose1").ToString()

                                                                                                        While dr2.Read()
                                                                                                            SGbtnQueue.purpose2.Text = dr2("Purpose2").ToString()

                                                                                                            While dr3.Read()
                                                                                                                SGbtnQueue.purpose3.Text = dr3("Purpose3").ToString()

                                                                                                                While dr4.Read()
                                                                                                                    SGbtnQueue.purpose4.Text = dr4("Purpose4").ToString()

                                                                                                                    While dr5.Read()
                                                                                                                        SGbtnQueue.purpose5.Text = dr5("Purpose5").ToString()

                                                                                                                        While dr6.Read()
                                                                                                                            SGbtnQueue.purpose6.Text = dr6("Purpose6").ToString()

                                                                                                                            While dr7.Read()
                                                                                                                                SGbtnQueue.purpose7.Text = dr7("Purpose7").ToString()

                                                                                                                                While dr8.Read()
                                                                                                                                    SGbtnQueue.purpose8.Text = dr8("Purpose8").ToString()

                                                                                                                                    While dr9.Read()
                                                                                                                                        SGbtnQueue.purpose9.Text = dr9("Purpose9").ToString()


                                                                                                                                        switchPanel(SGbtnQueue)


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


                        End If
                    End Using
                End Using
            End Using

        Catch

        Finally

        End Try
    End Sub

    Private Sub adminBtn_Click(sender As Object, e As EventArgs) Handles adminBtn.Click
        Try

            Using con As OleDbConnection = New OleDbConnection(conString)
                con.Open()
                Using cmd1 As New OleDb.OleDbCommand("SELECT HasLogin FROM AdminHasLogin", con)

                    Using dtareader As OleDb.OleDbDataReader = cmd1.ExecuteReader
                        If dtareader.HasRows = 0 Then
                            CashierbtnQueue.Close()
                            SGbtnQueue.Close()
                            RegistrarbtnQueue.Close()
                            NotAvailable.messageLabel.Text = "Admission is not available right now."
                            NotAvailable.Timer1.Enabled = True '


                            NotAvailable.countdownLabel.Text = 10
                            NotAvailable.ShowDialog()

                        ElseIf dtareader.HasRows <> 0 Then

                            Using cmd2 As New OleDbCommand("SELECT Purpose1 FROM AdminADDS", con)
                                Using cmd3 As New OleDbCommand("SELECT Purpose2 FROM AdminADDS", con)
                                    Using cmd4 As New OleDbCommand("SELECT Purpose3 FROM AdminADDS", con)
                                        Using cmd5 As New OleDbCommand("SELECT Purpose4 FROM AdminADDS", con)
                                            Using cmd6 As New OleDbCommand("SELECT Purpose5 FROM AdminADDS", con)
                                                Using cmd7 As New OleDbCommand("SELECT Purpose6 FROM AdminADDS", con)
                                                    Using cmd8 As New OleDbCommand("SELECT Purpose7 FROM AdminADDS", con)
                                                        Using cmd9 As New OleDbCommand("SELECT Purpose8 FROM AdminADDS", con)
                                                            Using cmd10 As New OleDbCommand("SELECT Purpose9 FROM AdminADDS", con)


                                                                Using dr1 As OleDb.OleDbDataReader = cmd2.ExecuteReader
                                                                    Using dr2 As OleDb.OleDbDataReader = cmd3.ExecuteReader
                                                                        Using dr3 As OleDb.OleDbDataReader = cmd4.ExecuteReader
                                                                            Using dr4 As OleDb.OleDbDataReader = cmd5.ExecuteReader
                                                                                Using dr5 As OleDb.OleDbDataReader = cmd6.ExecuteReader
                                                                                    Using dr6 As OleDb.OleDbDataReader = cmd7.ExecuteReader
                                                                                        Using dr7 As OleDb.OleDbDataReader = cmd8.ExecuteReader
                                                                                            Using dr8 As OleDb.OleDbDataReader = cmd9.ExecuteReader
                                                                                                Using dr9 As OleDb.OleDbDataReader = cmd10.ExecuteReader


                                                                                                    While dr1.Read()
                                                                                                        AdminbtnQueue.purpose1.Text = dr1("Purpose1").ToString()

                                                                                                        While dr2.Read()
                                                                                                            AdminbtnQueue.purpose2.Text = dr2("Purpose2").ToString()

                                                                                                            While dr3.Read()
                                                                                                                AdminbtnQueue.purpose3.Text = dr3("Purpose3").ToString()

                                                                                                                While dr4.Read()
                                                                                                                    AdminbtnQueue.purpose4.Text = dr4("Purpose4").ToString()

                                                                                                                    While dr5.Read()
                                                                                                                        AdminbtnQueue.purpose5.Text = dr5("Purpose5").ToString()

                                                                                                                        While dr6.Read()
                                                                                                                            AdminbtnQueue.purpose6.Text = dr6("Purpose6").ToString()

                                                                                                                            While dr7.Read()
                                                                                                                                AdminbtnQueue.purpose7.Text = dr7("Purpose7").ToString()

                                                                                                                                While dr8.Read()
                                                                                                                                    AdminbtnQueue.purpose8.Text = dr8("Purpose8").ToString()

                                                                                                                                    While dr9.Read()
                                                                                                                                        AdminbtnQueue.purpose9.Text = dr9("Purpose9").ToString()


                                                                                                                                        switchPanel(AdminbtnQueue)


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

                        End If
                    End Using
                End Using
            End Using


        Catch

        Finally

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'RegistraraddPurpose.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)
        'Dim confirm = MsgBox("Are you sure you want to Log out?", vbYesNo Or vbQuestion, "Log out")

        'If confirm = vbYes Then
        '    Login.Show()
        '    Me.Hide()
        'End If
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        'If RegistarPlace.REGISTRARLABEL.Visible = True Then

        '    RegistrarbtnQueue.arrowbackRegistrar.Visible = True
        'Else

        'End If
       
        'RegistrarbtnQueue.TransparencyKey = RegistrarbtnQueue.BackColor
    End Sub

 
    Private Sub Panel1_Leave(sender As Object, e As EventArgs) Handles Panel1.Leave
        'If Label1.Text = 30 Then
        '    Timer1.Enabled = True
        '    Label1.Text = Val(Label1.Text) - 1
        'ElseIf Label1.Text = 0 Then
        '    Timer1.Enabled = False
        '    Me.Close()
        'Else
        '    Label1.Text = Val(Label1.Text) - 1
        'End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            logoutBtn.Visible = True
            MenuStrip1.Visible = True
        ElseIf CheckBox1.Checked = False Then
            logoutBtn.Visible = False
            MenuStrip1.Visible = False
        End If
    End Sub


    Private Sub logoutBtn_Click_2(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Try
            Dim confirm = MsgBox("Are you sure you want to Log out?", vbYesNo Or vbQuestion, "Log out")

            If confirm = vbYes Then


                'Login.usertxt.Text = "Username"
                'Login.passtxt.Text = "Password"

                'Login.usertxt.TextAlign = HorizontalAlignment.Center
                'Login.usertxt.ForeColor = Color.Silver

                'Login.passtxt.TextAlign = HorizontalAlignment.Center
                'Login.passtxt.ForeColor = Color.Silver
                'Login.passtxt.Text = "Password"
                'Login.usertxt.Text = "Username"
                'Login.passtxt.UseSystemPasswordChar = False
                CheckBox1.Checked = False
                Login.Show()
                'Application.Exit()
                Me.Hide()
            End If
        Catch
        Finally
        End Try
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        Account.ShowDialog()
    End Sub
End Class
