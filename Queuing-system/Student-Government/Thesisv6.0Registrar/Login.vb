Imports System.Data.OleDb


Public Class Login
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Private con As OleDbConnection = New OleDbConnection(conString)
    Private cm As OleDbCommand
    Private adapter As OleDbDataAdapter
    Private dt As DataTable = New DataTable()

    Private Property cmd As OleDbCommand
    Private counter As Integer = 1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Try
            Dim attempt As Integer = 0

            Dim con As OleDbConnection = New OleDbConnection(conString)
            Dim cmd1 = New OleDbCommand("select * from LoginSG where Username = '" & usertxt.Text & "' and Password = '" & passtxt.Text & "'", con)
            cmd1.Parameters.Add("Username", OleDbType.VarChar).Value = usertxt.Text
            cmd1.Parameters.Add("Password", OleDbType.VarChar).Value = passtxt.Text

            Dim adapter1 As New OleDbDataAdapter(cmd1)
            Dim table1 As New DataTable
            adapter1.Fill(table1)

            Dim cmd3 As New OleDb.OleDbCommand("SELECT Password FROM LoginSG", con)
            con.Open()
            Dim dr1 As OleDb.OleDbDataReader = cmd3.ExecuteReader

          
            If table1.Rows.Count <> 0 Then
                'MsgBox("You are logined as " + table1.Rows(0)(6), vbInformation, "")
                'MsgBox("You are now logged in", vbInformation, "")
                'While dr1.Read()
                '    TextBox1.Text = dr1("Purpose1").ToString()
                'End While

                'If TextBox1.Text = passtxt.Text Then

                'Using con As OleDbConnection = New OleDbConnection(conString)
                Dim str1 As String
                str1 = "insert into SGHasLogin([HasLogin]) Values(?)"
                Using cmd2 As OleDbCommand = New OleDbCommand(str1, con)

                    cmd2.Parameters.Add(New OleDbParameter("HasLogin", CType(usertxt.Text, String)))


                    'con.Open()
                    cmd2.ExecuteNonQuery()


                    MsgBox("Welcome!", vbInformation, "Login")
                    SGPlace.updateRegandPLTimer.Enabled = True
                    SGPlace.totalOnqueueTimer.Enabled = True
                    SGPlace.newMonitorTimer.Enabled = True
                    SGPlace.ableNotif.Checked = True
                    SGPlace.priorityPLABLE.Checked = True
                    SGPlace.Show()
                    usertxt.Clear()
                    passtxt.Clear()
                    Me.Hide()
                End Using
                'Else
                '    MsgBox("Incorrect username or password", vbCritical, "Warning")

                'End If


            ElseIf usertxt.Text = "" Then
                MsgBox("Enter your username.", vbCritical, "Error")
            ElseIf passtxt.Text = "" Then
                MsgBox("Enter your password.", vbCritical, "Error")
            ElseIf usertxt.Text = "" And passtxt.Text = "" Then
                MsgBox("Enter your username and password.", vbCritical, "Error")
            ElseIf counter = 3 Then

                MsgBox("Maximum number of attempts exceeded.", vbCritical, "")
                Label1.Text = 30
                loginBtn.Enabled = False
                closeBtn.Enabled = False
                Timer1.Start()
                counter = 0
            Else
                MsgBox("Account not found! , attempt  " & counter & " out of 3.", vbCritical, "Warning")
                counter = counter + 1
                usertxt.Clear()
                passtxt.Clear()
                usertxt.Focus()


            End If
            'If attempt = 3 Then

            '    MsgBox("Too many attempt, wait 30 seconds")
            'End If

        Catch
        Finally
        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        usertxt.Clear()
        passtxt.Clear()
        'usertype.SelectedIndex = -1


        CreateAccount.ShowDialog()
        CreateAccount.surnameTxt.Focus()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'passtxtbox.UseSystemPasswordChar = True

        'Dim oPath As New GraphicsPath()
        'oPath.AddEllipse(Me.ClientRectangle)
        'Me.Region = New Region(oPath)
        FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog

        'usertxt.TextAlign = HorizontalAlignment.Center
        'usertxt.ForeColor = Color.Silver

        'passtxt.TextAlign = HorizontalAlignment.Center
        'passtxt.ForeColor = Color.Silver
        passtxt.UseSystemPasswordChar = True
        usertxt.Focus()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If passtxt.UseSystemPasswordChar = True Then

            passtxt.UseSystemPasswordChar = False
            Button2.Text = "Hide"

        Else

            passtxt.UseSystemPasswordChar = True

            Button2.Text = "Show"
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ForgotPassword.ShowDialog()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)

        Me.Close()
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
        Application.Exit()
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        loginBtn.Text = Label1.Text
        If Label1.Text = 10 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1



        ElseIf Label1.Text = 0 Then
            Timer1.Enabled = False
            loginBtn.Enabled = True
            closeBtn.Enabled = True
            Label1.Text = 30
            loginBtn.Text = "Log-In"

        Else
            Label1.Text = Val(Label1.Text) - 1

        End If
    End Sub

    Private Sub passtxt_TextChanged(sender As Object, e As EventArgs) Handles passtxt.TextChanged
        'passtxt.UseSystemPasswordChar = True
    End Sub
End Class

