Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class RegistrarbtnQueue
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Private con As OleDbConnection = New OleDbConnection(conString)


    Private Sub purpose1_Click(sender As Object, e As EventArgs) Handles purpose1.Click

        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormReg.onqueuenumberTxt.Text = value
                ValidationFormReg.onqueuepurposeTxt.Text = purpose1.Text
                ValidationFormReg.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub RegistrarbtnQueue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.BackColor = Color.Transparent
        'Me.BackColor = Color.Transparent

   
        'Me.TransparencyKey = Color.White 'if this doesn't work you try:
        'Me.TransparencyKey = Me.BackColor
        'Printing.ShowPrintStatusDialog = False


        '        PrintDocument printDocument = new PrintDocument();
        'PrintController printController = new StandardPrintController();
        'printDocument.PrintController = printController;

        'Remove the pop up page1 of document 
        PrintDocument1.PrintController = New System.Drawing.Printing.StandardPrintController()

        'If purpose1.Visible = False Then
        '    MsgBox("Registrar is not available right now ", vbInformation, "")
        'End If
        'Timer1.Start()
    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'RegistrarbtnQueue_Load(Me, New System.EventArgs)
        'Me.TransparencyKey = Me.BackColor
        DateTimePicker1.Value = DateTime.Now
        PrintDocument1.PrintController = New System.Drawing.Printing.StandardPrintController()
        PrintDocument2.PrintController = New System.Drawing.Printing.StandardPrintController()



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

    Private Sub PrintDocument2_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument2.PrintPage
        'SCHOOL FONT
        Dim fnt = New Font("Arial Narrow", 9, FontStyle.Bold)
        'SCHOOL CAMPUS FONT
        Dim fnt5 = New Font("Arial Narrow", 9, FontStyle.Bold)
        'DEVELOPED FONT
        Dim fnt6 = New Font("Arial Narrow", 8, FontStyle.Regular)
        'NUMBER FONT
        Dim fnt2 = New Font("Arial Narrow", 30, FontStyle.Bold)
        'PURPOSE FONT
        Dim fnt3 = New Font("Arial Narrow", 11, FontStyle.Bold)
        'Dim fnt3 = New Font("Arial Narrow", 11, FontStyle.Bold Or FontStyle.Underline)
        'TIME FONT
        Dim fnt4 = New Font("Arial Narrow", 8, FontStyle.Regular)


        'Arial Narrow, 26.25pt, style=Bold
        'Dim ESC As String = Chr(&H1B)
        'Dim x = 100
        'Dim y = 100
        'Dim a = 200
        'Dim b = 200
        'Dim dy As Integer = CInt(fnt.GetHeight(e.Graphics))
        Dim SCHOOL As String = "BULACAN POLYTECHNIC COLLEGE"
        Dim SCHOOLCAMPUS As String = "Malolos Campus"
        Dim DESIGN2 As String = "Developed by KDP(ACT)_\"
        Dim NUMBER As String = "P-" + onqueuenumberTxt.Text
        Dim PURPOSE As String = onqueuepurposeTxt.Text
        Dim TIME As String = DateTimePicker1.Text
        Dim DESIGN As String = "**************************************************"
        Dim DESIGN3 As String = "Thank You"

        'e.Graphics.DrawString(DESIGN, fnt, Brushes.Black, New PointF(0, 100))
        'e.Graphics.DrawString(DESIGN, fnt, Brushes.Black, New PointF(0, 170))
        e.Graphics.DrawString(SCHOOL, fnt, Brushes.Black, New PointF(3, 12))
        e.Graphics.DrawString(SCHOOLCAMPUS, fnt5, Brushes.Black, New PointF(55, 27))
        e.Graphics.DrawString("--------------" + DESIGN2 + "--------------", fnt6, Brushes.Black, New PointF(0, 130))
        e.Graphics.DrawString(NUMBER, fnt2, Brushes.Black, New PointF(28, 50))
        e.Graphics.DrawString(PURPOSE, fnt3, Brushes.Black, New PointF(3, 100))
        e.Graphics.DrawString(TIME, fnt4, Brushes.Black, New PointF(3, 115))
        e.Graphics.DrawString("--------------------" + DESIGN3 + "--------------------", fnt, Brushes.Black, New PointF(0, 143))
        e.Graphics.DrawString(DESIGN, fnt, Brushes.Black, New PointF(0, 205))
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick


        Using con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;")
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                If ConnectionState.Broken Then
                    con.Open()
                End If

                Dim ID As Integer
                Dim value As String

                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                onqueuenumberTxt.Text = value
                onqueuepurposeTxt.Text = purpose1.Text
                onqueuestatusTxt.Text = "PENDING"

                Dim str1 As String
                str1 = "insert into RegistrarQueue([Number]) Values(?)"
                Dim str2 As String
                str2 = "insert into Registrar([Number],[Purpose],[Status]) Values(?,?,?)"

                Dim cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                Dim cmd2 As OleDbCommand = New OleDbCommand(str2, con)

                cmd1.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))

                cmd2.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                cmd2.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                cmd2.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                cmd1.ExecuteNonQuery()
                cmd2.ExecuteNonQuery()


            End Using
        End Using


    End Sub

    Private Sub closeTimer_Tick(sender As Object, e As EventArgs) Handles closeTimer.Tick
        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd As New OleDbCommand("SELECT HasLogin FROM RegistrarHasLogin", con)
                    con.Open()
                    Dim dtareader As OleDbDataReader = cmd.ExecuteReader
                    If dtareader.HasRows = 0 Then
                        Me.Close()

                        ValidationFormReg.Close()
                        ValidationFormPriorityReg.Close()
                    End If
                End Using
            End Using
        Catch
        Finally
        End Try



    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage

        'SCHOOL FONT
        Dim fnt = New Font("Arial Narrow", 9, FontStyle.Bold)
        'SCHOOL CAMPUS FONT
        Dim fnt5 = New Font("Arial Narrow", 9, FontStyle.Bold)
        'DEVELOPED FONT
        Dim fnt6 = New Font("Arial Narrow", 8, FontStyle.Regular)
        'NUMBER FONT
        Dim fnt2 = New Font("Arial Narrow", 30, FontStyle.Bold)
        'PURPOSE FONT
        Dim fnt3 = New Font("Arial Narrow", 11, FontStyle.Bold)
        'Dim fnt3 = New Font("Arial Narrow", 11, FontStyle.Bold Or FontStyle.Underline)
        'TIME FONT
        Dim fnt4 = New Font("Arial Narrow", 8, FontStyle.Regular)


        'Arial Narrow, 26.25pt, style=Bold
        'Dim ESC As String = Chr(&H1B)
        'Dim x = 100
        'Dim y = 100
        'Dim a = 200
        'Dim b = 200
        'Dim dy As Integer = CInt(fnt.GetHeight(e.Graphics))
        Dim SCHOOL As String = "BULACAN POLYTECHNIC COLLEGE"
        Dim SCHOOLCAMPUS As String = "Malolos Campus"
        Dim DESIGN2 As String = "Developed by KDP(ACT)_\"
        Dim NUMBER As String = onqueuenumberTxt.Text
        Dim PURPOSE As String = onqueuepurposeTxt.Text
        Dim TIME As String = DateTimePicker1.Text
        Dim DESIGN As String = "**************************************************"
        Dim DESIGN3 As String = "Thank You"

        'e.Graphics.DrawString(DESIGN, fnt, Brushes.Black, New PointF(0, 100))
        'e.Graphics.DrawString(DESIGN, fnt, Brushes.Black, New PointF(0, 170))
        e.Graphics.DrawString(SCHOOL, fnt, Brushes.Black, New PointF(3, 12))
        e.Graphics.DrawString(SCHOOLCAMPUS, fnt5, Brushes.Black, New PointF(55, 27))
        e.Graphics.DrawString("--------------" + DESIGN2 + "--------------", fnt6, Brushes.Black, New PointF(0, 130))
        e.Graphics.DrawString(NUMBER, fnt2, Brushes.Black, New PointF(40, 50))
        e.Graphics.DrawString(PURPOSE, fnt3, Brushes.Black, New PointF(3, 100))
        e.Graphics.DrawString(TIME, fnt4, Brushes.Black, New PointF(3, 115))
        e.Graphics.DrawString("--------------------" + DESIGN3 + "--------------------", fnt, Brushes.Black, New PointF(0, 143))
        e.Graphics.DrawString(DESIGN, fnt, Brushes.Black, New PointF(0, 205))
    End Sub
    Private Sub purpose2_Click(sender As Object, e As EventArgs) Handles purpose2.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormReg.onqueuenumberTxt.Text = value
                ValidationFormReg.onqueuepurposeTxt.Text = purpose2.Text
                ValidationFormReg.ShowDialog()
            End Using
        End Using

    End Sub

    Private Sub purpose3_Click(sender As Object, e As EventArgs) Handles purpose3.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormReg.onqueuenumberTxt.Text = value
                ValidationFormReg.onqueuepurposeTxt.Text = purpose3.Text
                ValidationFormReg.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose4_Click(sender As Object, e As EventArgs) Handles purpose4.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormReg.onqueuenumberTxt.Text = value
                ValidationFormReg.onqueuepurposeTxt.Text = purpose4.Text
                ValidationFormReg.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub purpose5_Click(sender As Object, e As EventArgs) Handles purpose5.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormReg.onqueuenumberTxt.Text = value
                ValidationFormReg.onqueuepurposeTxt.Text = purpose5.Text
                ValidationFormReg.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub purpose6_Click(sender As Object, e As EventArgs) Handles purpose6.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormReg.onqueuenumberTxt.Text = value
                ValidationFormReg.onqueuepurposeTxt.Text = purpose6.Text
                ValidationFormReg.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose7_Click(sender As Object, e As EventArgs) Handles purpose7.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormReg.onqueuenumberTxt.Text = value
                ValidationFormReg.onqueuepurposeTxt.Text = purpose7.Text
                ValidationFormReg.ShowDialog()


            End Using
        End Using
    End Sub

    Private Sub purpose8_Click(sender As Object, e As EventArgs) Handles purpose8.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormReg.onqueuenumberTxt.Text = value
                ValidationFormReg.onqueuepurposeTxt.Text = purpose8.Text
                ValidationFormReg.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub purpose9_Click(sender As Object, e As EventArgs) Handles purpose9.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormReg.onqueuenumberTxt.Text = value
                ValidationFormReg.onqueuepurposeTxt.Text = purpose9.Text
                ValidationFormReg.ShowDialog()


            End Using
        End Using
    End Sub

    Private Sub purpose10_Click(sender As Object, e As EventArgs) Handles purpose10.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")


                ValidationFormPriorityReg.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPriorityReg.onqueuenumberTxt2.Text = value
                ValidationFormPriorityReg.onqueuepurposeTxt.Text = purpose10.Text
                ValidationFormPriorityReg.ShowDialog()

            End Using
        End Using
    End Sub


    Private Sub purpose11_Click(sender As Object, e As EventArgs) Handles purpose11.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")


                ValidationFormPriorityReg.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPriorityReg.onqueuenumberTxt2.Text = value
                ValidationFormPriorityReg.onqueuepurposeTxt.Text = purpose11.Text
                ValidationFormPriorityReg.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub purpose12_Click(sender As Object, e As EventArgs) Handles purpose12.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")


                ValidationFormPriorityReg.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPriorityReg.onqueuenumberTxt2.Text = value
                ValidationFormPriorityReg.onqueuepurposeTxt.Text = purpose12.Text
                ValidationFormPriorityReg.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose13_Click(sender As Object, e As EventArgs) Handles purpose13.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormPriorityReg.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPriorityReg.onqueuenumberTxt2.Text = value
                ValidationFormPriorityReg.onqueuepurposeTxt.Text = purpose13.Text
                ValidationFormPriorityReg.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose14_Click(sender As Object, e As EventArgs) Handles purpose14.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormPriorityReg.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPriorityReg.onqueuenumberTxt2.Text = value
                ValidationFormPriorityReg.onqueuepurposeTxt.Text = purpose14.Text
                ValidationFormPriorityReg.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose15_Click(sender As Object, e As EventArgs) Handles purpose15.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormPriorityReg.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPriorityReg.onqueuenumberTxt2.Text = value
                ValidationFormPriorityReg.onqueuepurposeTxt.Text = purpose15.Text
                ValidationFormPriorityReg.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub purpose16_Click(sender As Object, e As EventArgs) Handles purpose16.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormPriorityReg.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPriorityReg.onqueuenumberTxt2.Text = value
                ValidationFormPriorityReg.onqueuepurposeTxt.Text = purpose16.Text
                ValidationFormPriorityReg.ShowDialog()


            End Using
        End Using
    End Sub

    Private Sub purpose17_Click(sender As Object, e As EventArgs) Handles purpose17.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormPriorityReg.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPriorityReg.onqueuenumberTxt2.Text = value
                ValidationFormPriorityReg.onqueuepurposeTxt.Text = purpose17.Text
                ValidationFormPriorityReg.ShowDialog()
            End Using
        End Using
    End Sub

    Private Sub purpose18_Click(sender As Object, e As EventArgs) Handles purpose18.Click
        Using con As OleDbConnection = New OleDbConnection(conString)
            Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con)
                Dim ID As Integer
                Dim value As String
                con.Open()
                value = cmd.ExecuteScalar().ToString()


                If String.IsNullOrEmpty(value) Then
                    value = "R0000"
                    onqueuenumberTxt.Text = value
                End If

                value = value.Substring(1)
                Int32.TryParse(value, ID)
                ID = ID + 1
                value = "R" + ID.ToString("D4")

                ValidationFormPriorityReg.onqueuenumberTxt.Text = "P-" + value
                ValidationFormPriorityReg.onqueuenumberTxt2.Text = value
                ValidationFormPriorityReg.onqueuepurposeTxt.Text = purpose18.Text
                ValidationFormPriorityReg.ShowDialog()

            End Using
        End Using
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles ERRASEMOTO.Tick
        Try
            Using con1 As OleDbConnection = New OleDbConnection(conString)
                Using cmd = New OleDbCommand("select Max(Number) from RegistrarQueue ", con1)
                    Dim ID As Integer
                    Dim value As String
                    con1.Open()
                    value = cmd.ExecuteScalar().ToString()


                    If String.IsNullOrEmpty(value) Then
                        value = "R0000"
                        onqueuenumberTxt.Text = value
                    End If

                    value = value.Substring(1)
                    Int32.TryParse(value, ID)
                    ID = ID + 1
                    value = "R" + ID.ToString("D4")

                    onqueuenumberTxt.Text = value
                    onqueuepurposeTxt.Text = purpose1.Text

                    Dim str1 As String
                    str1 = "insert into RegistrarQueue([Number]) Values(?)"
                    Dim str2 As String
                    str2 = "insert into Registrar([Number],[Purpose],[Status]) Values(?,?,?)"

                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                            Using cmd2 As OleDbCommand = New OleDbCommand(str2, con)

                                cmd1.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))

                                cmd2.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd2.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd2.Parameters.Add(New OleDbParameter("Status", CType("PENDING", String)))

                                con.Open()
                                cmd1.ExecuteNonQuery()
                                cmd2.ExecuteNonQuery()
                          
                            End Using
                        End Using
                    End Using
                End Using
            End Using

        Catch
        Finally


        End Try

    End Sub
End Class