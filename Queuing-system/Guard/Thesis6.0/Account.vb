Imports System.Data.OleDb

Public Class Account
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Dim con As OleDbConnection = New OleDbConnection(conString)


    Private Property cmd As OleDbCommand

    Public idsearch As String = ""

    Private Sub Account_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userTxt.Focus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Dim cmd As OleDbCommand = Nothing
            Dim reader As OleDbDataReader = Nothing
            Dim cmd1 = New OleDbCommand("select * from LoginGuard where Username = '" & userTxt.Text & "'", con)

            cmd1.Parameters.Add("Username", OleDbType.VarChar).Value = userTxt.Text

            con.Open()
            Dim reader1 As OleDbDataReader = cmd1.ExecuteReader()


            If currentTxt.Text = "" Then
                MsgBox("Enter your current password", vbCritical, "")
                Exit Sub
            ElseIf newTxt.Text = "" Then
                MsgBox("Enter your new password", vbCritical, "")

            ElseIf confirmTxt.Text = "" Then
                MsgBox("Enter your confirm password", vbCritical, "")
                Exit Sub
            ElseIf reader1.HasRows = 0 Then
                userTxt.Clear()
                MsgBox("Username not found", vbCritical, "")
                userTxt.Clear()
                Exit Sub
            ElseIf currentTxt.Text = newTxt.Text Then
                MsgBox("Your new password is too similar to your current password. Please try another password.", vbCritical, "")
                Exit Sub
            ElseIf reader1.HasRows Then

            End If

            Dim username As String = userTxt.Text.Trim()
            Dim currentpass As String = currentTxt.Text.Trim()
            Dim newpass As String = newTxt.Text.Trim()
            Dim confirmpass As String = confirmTxt.Text.Trim()
            Dim samepass As Boolean = False
            If newpass = confirmpass Then
                samepass = True
            End If
            If samepass = False Then
                MsgBox("Password MISMATCH!!", vbCritical, "")
                newTxt.Text = ""
                confirmTxt.Text = ""
                newTxt.Focus()
                Exit Sub
            End If

            cmd = New OleDbCommand("SELECT * FROM LoginGuard", con)
            reader = cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Dim match As Boolean = False
            idsearch = ""
            While (reader.Read())
                If username = reader("Username").ToString().Trim() And currentpass = reader("Password").ToString().Trim() Then
                    idsearch = reader("ID").ToString().Trim()

                    match = True
                    UpdateRecord()

                    Exit While
                End If
            End While
            If match = False Then
                MsgBox("Incorrect PASSWORD!", vbCritical, "")

                Exit Sub
            End If



        End Using
    End Sub
    Private Sub ClearTxtBoxes()
        userTxt.Clear()
        currentTxt.Clear()
        newTxt.Clear()
        confirmTxt.Clear()
    End Sub


    Private Sub UpdateRecord()


        Dim confirm = MsgBox("Are you sure you want to Change your PASSWORD?", vbYesNo Or vbQuestion, "Save changes")
        If confirm = vbYes Then


            Dim username As String = userTxt.Text.Trim()
            Dim newpass As String = newTxt.Text.Trim()


            Using con As OleDbConnection = New OleDbConnection(conString)

                'Using cmd As New OleDbCommand("UPDATE LoginSG SET [Username]=user, [Password]=pass", con)

                '    cmd.Parameters.Add(New OleDbParameter("user", CType(userTxt.Text.Trim, String)))
                '    cmd.Parameters.Add(New OleDbParameter("pass", CType(newTxt.Text.Trim, String)))

                '    con.Open()

                con.Open()
                cmd = New OleDbCommand("UPDATE LoginGuard SET  [Password] = '" & newpass & "' WHERE ID = " & idsearch, con)
                cmd.ExecuteNonQuery()
                MsgBox("Password Changed!", vbInformation, "")
                ClearTxtBoxes()
                Me.Close()
            End Using
            'End Using


        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearTxtBoxes()
        Me.Close()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If newTxt.UseSystemPasswordChar = True Then

            newTxt.UseSystemPasswordChar = False
            Button2.Text = "Show"

        Else

            newTxt.UseSystemPasswordChar = True

            Button2.Text = "Hide"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If currentTxt.UseSystemPasswordChar = True Then

            currentTxt.UseSystemPasswordChar = False
            Button1.Text = "Show"

        Else

            currentTxt.UseSystemPasswordChar = True

            Button1.Text = "Hide"
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


    Private Sub Account_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        userTxt.Focus()
    End Sub
End Class