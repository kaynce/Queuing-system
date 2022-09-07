Imports System.Data.OleDb
Imports System.Drawing.Printing

Public Class ValidationFormPriorityReg
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Private con As OleDbConnection = New OleDbConnection(conString)

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTimePicker1.Value = DateTime.Now

    End Sub

    Private Sub ValidationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintDocument1.PrintController = New System.Drawing.Printing.StandardPrintController()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        PrintDocument1.PrintController = New System.Drawing.Printing.StandardPrintController()
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

        'TIME FONT
        Dim fnt4 = New Font("Arial Narrow", 8, FontStyle.Regular)


        Dim SCHOOL As String = "BULACAN POLYTECHNIC COLLEGE"
        Dim SCHOOLCAMPUS As String = "Malolos Campus"
        Dim DESIGN2 As String = "Developed by KDP(ACT)_\"
        Dim NUMBER As String = onqueuenumberTxt.Text
        Dim PURPOSE As String = onqueuepurposeTxt.Text
        Dim TIME As String = DateTimePicker1.Text
        Dim DESIGN As String = "**************************************************"
        Dim DESIGN3 As String = "Thank You"

        e.Graphics.DrawString(SCHOOL, fnt, Brushes.Black, New PointF(3, 12))
        e.Graphics.DrawString(SCHOOLCAMPUS, fnt5, Brushes.Black, New PointF(55, 27))
        e.Graphics.DrawString("--------------" + DESIGN2 + "--------------", fnt6, Brushes.Black, New PointF(0, 130))
        e.Graphics.DrawString(NUMBER, fnt2, Brushes.Black, New PointF(28, 50))
        e.Graphics.DrawString(PURPOSE, fnt3, Brushes.Black, New PointF(3, 100))
        e.Graphics.DrawString(TIME, fnt4, Brushes.Black, New PointF(3, 115))
        e.Graphics.DrawString("--------------------" + DESIGN3 + "--------------------", fnt, Brushes.Black, New PointF(0, 143))
        e.Graphics.DrawString(DESIGN, fnt, Brushes.Black, New PointF(0, 205))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Dim str1 As String
                str1 = "insert into RegistrarQueue([Number]) Values(?)"
                Dim str2 As String
                str2 = "insert into RegistrarPriorityLane([Number],[Purpose],[Status]) Values(?,?,?)"

                Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                    Using cmd2 As OleDbCommand = New OleDbCommand(str2, con)

                        cmd1.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt2.Text, String)))

                        cmd2.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                        cmd2.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                        cmd2.Parameters.Add(New OleDbParameter("Status", CType("PENDING", String)))

                        con.Open()
                        cmd1.ExecuteNonQuery()
                        cmd2.ExecuteNonQuery()
                        PrintDialog1.Document = PrintDocument1
                        If PrintDialog1.PrintToFile = PrintAction.PrintToFile Then
                            PrintDocument1.Print()
                        End If
                        Me.Close()
                        RegistrarbtnQueue.Close()
                    End Using
                End Using
            End Using

        Catch
        Finally


        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        'RegistrarbtnQueue.Close()

    End Sub
End Class