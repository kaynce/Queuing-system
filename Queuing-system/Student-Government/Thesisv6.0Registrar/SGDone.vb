Imports System.Data.OleDb

Public Class SGDone
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cm As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable = New DataTable()

    Private Property cmd As OleDbCommand

    Private Sub Done_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Retrieve()
    End Sub
    Private Sub Populate(number As String, purpose As String, status As String)

        Dim row As String() = New String() {number, purpose, status}
        Dim item As ListViewItem = New ListViewItem(row)

        ListView1.Items.Add(item)
    End Sub
    Private Sub Retrieve()
        ListView1.Items.Clear()
        Dim sql As String = "SELECT * FROM SGDone"
        cmd = New OleDbCommand(sql, con)
        'OPEM CON, RETRIEVE, FILL LISTVIEW
        Try
            con.Open()
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(dt)
            'LOOP THRU DATATABLE
            For Each row In dt.Rows
                Populate(row(1), row(2), row(3))
            Next
            'CLEAR DATATABLE
            dt.Rows.Clear()
            con.Close()

        Catch ex As Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
        Retrieve()
    End Sub

    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        Try
            Dim Number As String = ListView1.SelectedItems(0).SubItems(0).Text
            Dim Purpose As String = ListView1.SelectedItems(0).SubItems(1).Text
            Dim Status As String = ListView1.SelectedItems(0).SubItems(2).Text

            Dim confirm = MsgBox(" Are you sure you want to Nowserving it?", vbYesNo, "Nowserving")

            If confirm = vbYes Then
                'onholdnumberTxt.Text = Number
                'onholdpurposeTxt.Text = Purpose
                'onholdstatusTxt.Text = Status

                'CheckBox1.Checked = False
                'CheckBox2.Checked = False


                'Clear texboxes sa likod ng listview 
                'Timer4.Enabled = True


                'RegistarPlace.onholdnumberTxt.Text = onholdnumberTxt.Text

                'Me.RegistrarDoneTableAdapter.Fill(Me.QueuingSystemDataSet.RegistrarDone)


                SGPlace.onqueuenumberTxt.Text = Number
                SGPlace.onqueuepurposeTxt.Text = Purpose
                SGPlace.onqueuestatusTxt.Text = Status

                SGPlace.fordoneTxt.Text = Number

                SGPlace.Holdbtn.Enabled = False


            End If
        Catch ex As Exception
            MsgBox("Please Try Again", vbInformation, "")
        End Try
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Done_Load(Me, New System.EventArgs)
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        ListView1.Sorting = SortOrder.Ascending
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        ListView1.Sorting = SortOrder.Descending
    End Sub
End Class