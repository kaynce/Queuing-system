Imports System.Data.OleDb

Public Class Manage
    Dim constring As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Dim con As OleDbConnection = New OleDbConnection(constring)
    Dim ds As DataSet = New DataSet
    Dim dataadapter As New OleDbDataAdapter("select * PendingLogs ", con)
    Dim cmd As OleDbCommand = New OleDbCommand()
    Dim dv As DataView
    Dim cm As CurrencyManager
    Dim datareader As OleDbDataReader
    Dim index As Integer = 0
    Dim adapter = New OleDbDataAdapter

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub LinkLabel14_LinkClicked_1(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles approveLink.LinkClicked
        switchPanel(Approved)
        Try


            Using con As OleDbConnection = New OleDbConnection(constring)
                Using ds1 As New DataSet
                    Dim str1 As String = "select * from PendingLogs"

                    adapter.SelectCommand = New OleDb.OleDbCommand(str1, con)
                    adapter.Fill(ds1)
                    Approved.PendingLogsDataGridView.DataSource = ds1.Tables(0)
                    Approved.PendingLogsDataGridView.Columns.RemoveAt(0)
                    Approved.PendingLogsDataGridView.Columns(0).Width = 160
                    Approved.PendingLogsDataGridView.Columns(1).Width = 160
                    Approved.PendingLogsDataGridView.Columns(2).Width = 160
                    Approved.PendingLogsDataGridView.Columns(3).Width = 160

                End Using
            End Using
        Catch
            'MsgBox("")
        Finally
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

   
    Private Sub LinkLabel11_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel11.LinkClicked

    End Sub

    Private Sub Manage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class