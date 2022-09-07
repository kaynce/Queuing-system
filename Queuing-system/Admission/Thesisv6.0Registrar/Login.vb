Imports System.Data.OleDb


Public Class Login
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    '    Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;
    'Jet OLEDB:Database Password=MyDbPassword;
    Private con As OleDbConnection = New OleDbConnection(conString)
    Private cm As OleDbCommand
    Private adapter As OleDbDataAdapter
    Private dt As DataTable = New DataTable()

    Private Property cmd As OleDbCommand
    Private counter As Integer = 1
    Public idsearch As String = ""

    Private Sub Calls()

        Dim str1 As String
        str1 = "insert into AdminHasLogin([HasLogin]) Values(?)"
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd2 As OleDbCommand = New OleDbCommand(str1, con)

                cmd2.Parameters.Add(New OleDbParameter("HasLogin", CType(usertxt.Text, String)))

                con.Open()
                cmd2.ExecuteNonQuery()

                MsgBox("Welcome!", vbInformation, "Login")
                AdmissionPlace.updateRegandPLTimer.Enabled = True
                AdmissionPlace.totalOnqueueTimer.Enabled = True
                AdmissionPlace.newMonitorTimer.Enabled = True
                AdmissionPlace.ableNotif.Checked = True
                AdmissionPlace.priorityPLABLE.Checked = True

                AdmissionPlace.Show()

                usertxt.Clear()
                passtxt.Clear()
                Me.Hide()
            End Using
        End Using

    End Sub
    Private Sub ClearTextBoxes()

        usertxt.Clear()
        passtxt.Clear()

    End Sub

   
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        usertxt.Clear()
        passtxt.Clear()
        'usertype.SelectedIndex = -1


        CreateAccount.ShowDialog()
        CreateAccount.surnameTxt.Focus()

    End Sub
    'Private Sub Login()
    Public Function ask()
        Dim con As New OleDbConnection
        Dim dt As New DataTable
        Dim ds As New DataSet
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
        ds.Tables.Add(dt)
        con.Open()
        Dim da As New OleDbDataAdapter("select * from LoginAdmin", con)
        da.Fill(dt)
        For Each DataRow In dt.Rows
            If usertxt.Text = DataRow(5) And passtxt.Text = DataRow(6) Then
                con.Close()
                Return True
            End If
        Next
        con.Close()
        Return False

    End Function

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

    Private Sub usertxt_TextChanged(sender As Object, e As EventArgs) Handles usertxt.TextChanged

    End Sub

    Private Sub passtxt_TextChanged(sender As Object, e As EventArgs) Handles passtxt.TextChanged
        'passtxt.UseSystemPasswordChar = True
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Try
            Dim attempt As Integer = 0
            Using con As OleDbConnection = New OleDbConnection(conString)
                Dim cmd1 = New OleDbCommand("select * from LoginAdmin where Username = '" & usertxt.Text & "' and Password = '" & passtxt.Text & "'", con)
                cmd1.Parameters.Add("Username", OleDbType.VarChar).Value = usertxt.Text
                cmd1.Parameters.Add("Password", OleDbType.VarChar).Value = passtxt.Text

                Dim adapter1 As New OleDbDataAdapter(cmd1)
                Dim table1 As New DataTable
                adapter1.Fill(table1)

                Dim cmd3 As New OleDb.OleDbCommand("SELECT Password FROM LoginAdmin", con)
                con.Open()
                Dim dr1 As OleDb.OleDbDataReader = cmd3.ExecuteReader


                Dim reader As OleDbDataReader = Nothing


                Dim username As String = usertxt.Text.Trim()
                Dim passtext As String = passtxt.Text.Trim()


                cmd = New OleDbCommand("SELECT * FROM LoginAdmin", con)
                reader = cmd.ExecuteReader
                Dim match As Boolean = False
                idsearch = ""
                While (reader.Read())
                    If username = reader("Username").ToString().Trim() And passtext = reader("Password").ToString().Trim() Then
                        idsearch = reader("ID").ToString().Trim()
                        match = True
                        Calls()
                        Exit While
                    ElseIf usertxt.Text = "" Then
                        MsgBox("Enter your username. ", vbCritical, "Error")
                    ElseIf passtxt.Text = "" Then
                        MsgBox("Enter your password.", vbCritical, "Error")
                    ElseIf usertxt.Text = "" And passtxt.Text = "" Then
                        MsgBox("Enter your username and password.", vbCritical, "Error")

                    ElseIf counter = 3 Then

                        MsgBox("Maximum number of attempts exceeded.", vbCritical, "Error")
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

                End While
               
              
                'If attempt = 3 Then

                '    MsgBox("Too many attempt, wait 30 seconds")
                'End If
            End Using
        Catch
        Finally
        End Try

    End Sub
    'Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click

    '    Using con As OleDbConnection = New OleDbConnection(conString)

    '        Dim reader As OleDbDataReader = Nothing
    '        Dim cmd = New OleDbCommand("select * from LoginAdmin where Username = '" & usertxt.Text & "' and Password = '" & passtxt.Text & "'", con)

    '        cmd.Parameters.Add("Username", OleDbType.VarChar).Value = usertxt.Text

    '        con.Open()
    '        Dim reader1 As OleDbDataReader = cmd.ExecuteReader()


    '        Dim username As String = usertxt.Text.Trim()
    '        Dim passtext As String = passtxt.Text.Trim()


    '        cmd = New OleDbCommand("SELECT * FROM LoginAdmin", con)
    '        reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
    '        Dim match As Boolean = False
    '        idsearch = ""
    '        While (reader.Read())
    '            If username = reader("Username").ToString().Trim() And passtext = reader("Password").ToString().Trim() Then
    '                idsearch = reader("ID").ToString().Trim()
    '                match = True
    '                Calls()
    '                Exit While
    '            End If
    '        End While
    '        If match = False Then
    '            MsgBox("Account not found!", vbCritical, "")
    '            Exit Sub
    '        End If
    '    End Using


    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
    End Sub
End Class

