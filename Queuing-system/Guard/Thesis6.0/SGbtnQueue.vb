Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class SGbtnQueue
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Private con As OleDbConnection = New OleDbConnection(conString)


    Private Sub purpose1_Click(sender As Object, e As EventArgs) Handles purpose1.Click

        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()

                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormSG.onqueuenumberTxt.Text = value
                ValidationFormSG.onqueuepurposeTxt.Text = purpose1.Text
                ValidationFormSG.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub RegistrarbtnQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

   
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
   
        DateTimePicker1.Value = DateTime.Now
     
        If purpose1.Text = Nothing Then
            purpose1.Visible = False
        Else
            purpose1.Visible = True
        End If
        'purpose2

        If purpose2.Text = Nothing Then
            purpose2.Visible = False
        Else
            purpose2.Visible = True
        End If
        'purpose3

        If purpose3.Text = Nothing Then
            purpose3.Visible = False
        Else
            purpose3.Visible = True
        End If
        'purpose4

        If purpose4.Text = Nothing Then
            purpose4.Visible = False
        Else
            purpose4.Visible = True
        End If
        'purpose5

        If purpose5.Text = Nothing Then
            purpose5.Visible = False
        Else
            purpose5.Visible = True
        End If
        'purpose6

        If purpose6.Text = Nothing Then
            purpose6.Visible = False
        Else
            purpose6.Visible = True
        End If
        'purpose7

        If purpose7.Text = Nothing Then
            purpose7.Visible = False
        Else
            purpose7.Visible = True
        End If
        'purpose8

        If purpose8.Text = Nothing Then
            purpose8.Visible = False
        Else
            purpose8.Visible = True
        End If
        'purpose9

        If purpose9.Text = Nothing Then
            purpose9.Visible = False
        Else
            purpose9.Visible = True
        End If


        If purpose9.Text = Nothing Then
            purpose9.Visible = False
        Else
            purpose9.Visible = True
        End If

        'purpose10

        If purpose10.Text = Nothing Then
            purpose10.Visible = False
        Else
            purpose10.Visible = True
        End If
        'purpose11

        If purpose11.Text = Nothing Then
            purpose11.Visible = False
        Else
            purpose11.Visible = True
        End If
        'purpose12

        If purpose12.Text = Nothing Then
            purpose12.Visible = False
        Else
            purpose12.Visible = True
        End If
        'purpose13

        If purpose13.Text = Nothing Then
            purpose13.Visible = False
        Else
            purpose13.Visible = True
        End If
        'purpose14

        If purpose14.Text = Nothing Then
            purpose14.Visible = False
        Else
            purpose14.Visible = True
        End If
        'purpose15

        If purpose15.Text = Nothing Then
            purpose15.Visible = False
        Else
            purpose15.Visible = True
        End If
        'purpose16

        If purpose16.Text = Nothing Then
            purpose16.Visible = False
        Else
            purpose16.Visible = True
        End If
        'purpose17

        If purpose17.Text = Nothing Then
            purpose17.Visible = False
        Else
            purpose17.Visible = True
        End If
        'purpose18

        If purpose18.Text = Nothing Then
            purpose18.Visible = False
        Else
            purpose18.Visible = True
        End If
 

        purpose10.Text = purpose1.Text
        purpose11.Text = purpose2.Text
        purpose12.Text = purpose3.Text
        purpose13.Text = purpose4.Text
        purpose14.Text = purpose5.Text
        purpose15.Text = purpose6.Text
        purpose16.Text = purpose7.Text
        purpose17.Text = purpose8.Text
        purpose18.Text = purpose9.Text

    

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles arrowbackRegistrar.Click

        Me.Close()

    End Sub

  

    Private Sub closeTimer_Tick(sender As Object, e As EventArgs) Handles closeTimer.Tick
        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd As New OleDbCommand("SELECT HasLogin FROM SGHasLogin", con)
                    con.Open()
                    Dim dtareader As OleDbDataReader = cmd.ExecuteReader
                    If dtareader.HasRows = 0 Then
                        Me.Close()

                        ValidationFormSG.Close()
                        ValidationFormPrioritySG.Close()
                    End If
                End Using
            End Using
        Catch
        Finally
        End Try

    End Sub

    
    Private Sub purpose2_Click(sender As Object, e As EventArgs) Handles purpose2.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormSG.onqueuenumberTxt.Text = value
                ValidationFormSG.onqueuepurposeTxt.Text = purpose2.Text
                ValidationFormSG.ShowDialog()
            End Using
        End Using

    End Sub

    Private Sub purpose3_Click(sender As Object, e As EventArgs) Handles purpose3.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormSG.onqueuenumberTxt.Text = value
                ValidationFormSG.onqueuepurposeTxt.Text = purpose3.Text
                ValidationFormSG.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose4_Click(sender As Object, e As EventArgs) Handles purpose4.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormSG.onqueuenumberTxt.Text = value
                ValidationFormSG.onqueuepurposeTxt.Text = purpose4.Text
                ValidationFormSG.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub purpose5_Click(sender As Object, e As EventArgs) Handles purpose5.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormSG.onqueuenumberTxt.Text = value
                ValidationFormSG.onqueuepurposeTxt.Text = purpose5.Text
                ValidationFormSG.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub purpose6_Click(sender As Object, e As EventArgs) Handles purpose6.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormSG.onqueuenumberTxt.Text = value
                ValidationFormSG.onqueuepurposeTxt.Text = purpose6.Text
                ValidationFormSG.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose7_Click(sender As Object, e As EventArgs) Handles purpose7.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormSG.onqueuenumberTxt.Text = value
                ValidationFormSG.onqueuepurposeTxt.Text = purpose7.Text
                ValidationFormSG.ShowDialog()


            End Using
        End Using
    End Sub

    Private Sub purpose8_Click(sender As Object, e As EventArgs) Handles purpose8.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormSG.onqueuenumberTxt.Text = value
                ValidationFormSG.onqueuepurposeTxt.Text = purpose8.Text
                ValidationFormSG.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub purpose9_Click(sender As Object, e As EventArgs) Handles purpose9.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormSG.onqueuenumberTxt.Text = value
                ValidationFormSG.onqueuepurposeTxt.Text = purpose9.Text
                ValidationFormSG.ShowDialog()


            End Using
        End Using
    End Sub

    Private Sub purpose10_Click(sender As Object, e As EventArgs) Handles purpose10.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")


                ValidationFormPrioritySG.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPrioritySG.onqueuenumberTxt2.Text = value
                ValidationFormPrioritySG.onqueuepurposeTxt.Text = purpose10.Text
                ValidationFormPrioritySG.ShowDialog()

            End Using
        End Using
    End Sub


    Private Sub purpose11_Click(sender As Object, e As EventArgs) Handles purpose11.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")


                ValidationFormPrioritySG.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPrioritySG.onqueuenumberTxt2.Text = value
                ValidationFormPrioritySG.onqueuepurposeTxt.Text = purpose11.Text
                ValidationFormPrioritySG.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub purpose12_Click(sender As Object, e As EventArgs) Handles purpose12.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")


                ValidationFormPrioritySG.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPrioritySG.onqueuenumberTxt2.Text = value
                ValidationFormPrioritySG.onqueuepurposeTxt.Text = purpose12.Text
                ValidationFormPrioritySG.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose13_Click(sender As Object, e As EventArgs) Handles purpose13.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormPrioritySG.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPrioritySG.onqueuenumberTxt2.Text = value
                ValidationFormPrioritySG.onqueuepurposeTxt.Text = purpose13.Text
                ValidationFormPrioritySG.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose14_Click(sender As Object, e As EventArgs) Handles purpose14.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormPrioritySG.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPrioritySG.onqueuenumberTxt2.Text = value
                ValidationFormPrioritySG.onqueuepurposeTxt.Text = purpose14.Text
                ValidationFormPrioritySG.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose15_Click(sender As Object, e As EventArgs) Handles purpose15.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormPrioritySG.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPrioritySG.onqueuenumberTxt2.Text = value
                ValidationFormPrioritySG.onqueuepurposeTxt.Text = purpose15.Text
                ValidationFormPrioritySG.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose16_Click(sender As Object, e As EventArgs) Handles purpose16.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormPrioritySG.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPrioritySG.onqueuenumberTxt2.Text = value
                ValidationFormPrioritySG.onqueuepurposeTxt.Text = purpose16.Text
                ValidationFormPrioritySG.ShowDialog()


            End Using
        End Using
    End Sub

    Private Sub purpose17_Click(sender As Object, e As EventArgs) Handles purpose17.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormPrioritySG.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPrioritySG.onqueuenumberTxt2.Text = value
                ValidationFormPrioritySG.onqueuepurposeTxt.Text = purpose17.Text
                ValidationFormPrioritySG.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub purpose18_Click(sender As Object, e As EventArgs) Handles purpose18.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from SGQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "SG0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(2)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "SG" + ID.ToString("D4")

                ValidationFormPrioritySG.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPrioritySG.onqueuenumberTxt2.Text = value
                ValidationFormPrioritySG.onqueuepurposeTxt.Text = purpose18.Text
                ValidationFormPrioritySG.ShowDialog()

            End Using
        End Using
    End Sub
End Class