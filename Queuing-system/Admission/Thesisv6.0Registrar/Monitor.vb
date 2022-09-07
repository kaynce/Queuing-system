Imports System.Data.OleDb

Public Class Monitor
    Private conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Private con As OleDbConnection = New OleDbConnection(conString)
    Private cm As OleDbCommand
    Private adapter As OleDbDataAdapter
    Private dt As DataTable = New DataTable()

    Private Property cmd As OleDbCommand
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles monitorRegistrarTimer.Tick

        TimeTday.Text = DateTime.Now.ToString("dddd,dd MMMM yyyy hh:mm tt")
        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd1 As New OleDbCommand("SELECT Purpose1 FROM RegistrarMonitor", con)
                    con.Open()
                    Using dr1 As OleDbDataReader = cmd1.ExecuteReader

                        While dr1.Read()

                            monitorRegistrar.Text = dr1("Purpose1").ToString()
                        End While

                    End Using
                End Using
            End Using

        Catch
            'con.Close()
            'MsgBox("ERROR SA CHECKBOX1")
        Finally
            'con.Close()
        End Try
    End Sub

    Private Sub monitorCashierTimer_Tick(sender As Object, e As EventArgs) Handles monitorCashierTimer.Tick
        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd1 As New OleDb.OleDbCommand("SELECT Purpose1 FROM CashierMonitor", con)
                    con.Open()
                    Using dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader

                        While dr1.Read()

                            monitorCashier.Text = dr1("Purpose1").ToString()
                        End While

                    End Using
                End Using
            End Using

        Catch
            'con.Close()
            'MsgBox("ERROR SA CHECKBOX1")
        Finally
            'con.Close()
        End Try
    End Sub

    Private Sub monitorAdmissionTimer_Tick(sender As Object, e As EventArgs) Handles monitorAdmissionTimer.Tick
        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd1 As New OleDb.OleDbCommand("SELECT Purpose1 FROM AdminMonitor", con)
                    con.Open()
                    Using dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader

                        While dr1.Read()

                            monitorAdmission.Text = dr1("Purpose1").ToString()
                        End While

                    End Using
                End Using
            End Using

        Catch
            'con.Close()
            'MsgBox("ERROR SA CHECKBOX1")
        Finally
            'con.Close()
        End Try
    End Sub

    Private Sub monitorSGTimer_Tick(sender As Object, e As EventArgs) Handles monitorSGTimer.Tick
        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd1 As New OleDb.OleDbCommand("SELECT Purpose1 FROM SGMonitor", con)
                    con.Open()
                    Using dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader

                        While dr1.Read()

                            monitorSG.Text = dr1("Purpose1").ToString()
                        End While

                    End Using
                End Using
            End Using

        Catch
            'con.Close()
            'MsgBox("ERROR SA CHECKBOX1")
        Finally
            'con.Close()
        End Try
    End Sub

    Private Sub Monitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class