Imports System.Data.OleDb
Imports System.Drawing.Printing


Public Class RegistrarHistory
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim adapter = New OleDbDataAdapter
    Dim clickMonitor As Boolean = False



    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)
        'Dim DA As New OleDbDataAdapter
        'DA = New OleDbDataAdapter("select * from RegistrarHistory where Day = '" & Format(DateTimePicker1.Value, "dd-MMMM-yyyy ") & "'", con)
        'con.Open()

        'Dim DT1 As New DataTable
        'DT1.Clear()
        'DA.Fill(DT1)

        'If DT1.Rows.Count = Nothing Then
        '    MsgBox("dATA NOT FOUND! " & vbCrLf & "Try another date!")
        '    con.Close()
        'Else

        '    'cmd.Connection = con
        '    con.Open()
        '    cmd.CommandText = "select * from RegistrarHistory where Day = '" & Format(Me.DateTimePicker1.Value, "dd-MMMM-yyyy ") & "'"
        '    adapter = New OleDbDataAdapter(cmd)
        '    dt.Rows.Clear()
        '    adapter.Fill(dt)


        '    If Not dt Is Nothing AndAlso dt.Rows.Count > 0 Then
        '        With RegistrarHistoryDataGridView
        '            .AutoGenerateColumns = False
        '            .DataSource = dt
        '            .Columns(0).DataPropertyName = "ID"
        '            .Columns(1).DataPropertyName = "Number"
        '            .Columns(2).DataPropertyName = "Purpose"
        '            .Columns(3).DataPropertyName = "Day"

        '        End With
        '    End If
        '    con.Close()
        'End If
        'con.Close()

        'Dim dt As New DataTable
        'Using da As New OleDb.OleDbDataAdapter("SELECT * FROM RegistrarHistory WHERE Day = ?", "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\user\Documents\QueuingSystem.accdb")
        '    da.SelectCommand.Parameters.AddWithValue("?", DateTimePicker1.Value.Date)
        '    da.Fill(dt)
        '    RegistrarHistoryDataGridView.DataSource = dt

        'End Using




        'Me.RegistrarHistoryDataGridView.Filter = "doj >= '" & DateTimePicker1.Value & "' and doj <= '" & DateTimePicker2.Value & "'"
    End Sub


    Private Sub RegistrarHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        '        For example, if you have an end date like 02/05/2019 00:00:00, then a record with a date and time like 02/05/2019 19:40:00 will not be included in the results because a time of 00:00:000 is midnight and every other time is after midnight.
        'If you want to avoid this situation then add a day to the ending date, like this

        '                Dim y = DateTimePicker2.Value.Date.AddDay(1)











        Panel1.Visible = True
        'Dim pkInstalledPrinters As String

        '' Find all printers installed
        'For Each pkInstalledPrinters In _
        '    PrinterSettings.InstalledPrinters
        '    ComboBox1.Items.Add(pkInstalledPrinters)
        'Next pkInstalledPrinters

        '' Set the combo to the first printer in the list
        'ComboBox1.SelectedIndex = 0

        PrintDocument1.PrintController = New System.Drawing.Printing.StandardPrintController()
        PrintDocument2.PrintController = New System.Drawing.Printing.StandardPrintController()

        For Each printer As String In _
        PrinterSettings.InstalledPrinters
            ComboBox1.Items.Add(printer)
        Next printer
        RegistrarHistoryDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal


        For Each printer As String In _
        PrinterSettings.InstalledPrinters
            ComboBox2.Items.Add(printer)
        Next printer
        RegistrarOnholdHistoryDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        'RegistrarDataGridView.AutoSize = DataGridViewAutoSizeColumnsMode.Fill
        'RegistrarDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'RegistrarDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells


        'RegistrarPriorityLaneDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'RegistrarPriorityLaneDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells




        'RegistrarDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        'RegistrarDataGridView.Columns(1).Width = 150
        'RegistrarDataGridView.Columns(2).Width = 100
        'RegistrarDataGridView.Columns(3).Width = 50


        'Dim columnwidth1 As DataGridViewColumn = RegistrarDataGridView.Columns(1)
        'columnwidth1.Width = 100

        'Dim screen As Screen
        'screen = screen.AllScreens(1)
        'Monitor.StartPosition = FormStartPosition.Manual
        'Monitor.Location = screen.Bounds.Location + New Point(100, 100)
        'Monitor.Show()



        ''''dagdag
        'studentApproval_Load(Me, New System.EventArgs)

        'RegistrarHistoryDatagird
        RegistrarHistoryDataGridView.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None
        RegistrarHistoryDataGridView.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None
        RegistrarHistoryDataGridView.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        RegistrarHistoryDataGridView.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None

        RegistrarHistoryDataGridView.DefaultCellStyle.SelectionBackColor = RegistrarHistoryDataGridView.DefaultCellStyle.BackColor
        RegistrarHistoryDataGridView.DefaultCellStyle.SelectionForeColor = RegistrarHistoryDataGridView.DefaultCellStyle.ForeColor

        'RegistrarOnholdHistoryDatagird
        RegistrarOnholdHistoryDataGridView.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None
        RegistrarOnholdHistoryDataGridView.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None
        RegistrarOnholdHistoryDataGridView.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        RegistrarOnholdHistoryDataGridView.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None

        RegistrarOnholdHistoryDataGridView.DefaultCellStyle.SelectionBackColor = RegistrarOnholdHistoryDataGridView.DefaultCellStyle.BackColor
        RegistrarOnholdHistoryDataGridView.DefaultCellStyle.SelectionForeColor = RegistrarOnholdHistoryDataGridView.DefaultCellStyle.ForeColor



        Try


            Using con As OleDbConnection = New OleDbConnection(conString)
                Using ds1 As New DataSet
                    Dim str1 As String = "select * from RegistrarHistory"

                    adapter.SelectCommand = New OleDb.OleDbCommand(str1, con)
                    adapter.Fill(ds1)
                    RegistrarHistoryDataGridView.DataSource = ds1.Tables(0)
                    RegistrarHistoryDataGridView.Columns.Remove("ID")
                End Using
            End Using
        Catch
            'MsgBox("")
        Finally
        End Try

        Try

            Using con As OleDbConnection = New OleDbConnection(conString)
                Using ds1 As New DataSet
                    Dim str1 As String = "select * from RegistrarOnholdHistory"

                    adapter.SelectCommand = New OleDb.OleDbCommand(str1, con)
                    adapter.Fill(ds1)
                    RegistrarOnholdHistoryDataGridView.DataSource = ds1.Tables(0)
                    RegistrarOnholdHistoryDataGridView.Columns.Remove("ID")
                End Using
            End Using


        Catch
            'MsgBox("")
        Finally
        End Try
    End Sub
    'Private Sub load_data(sql As String, dtg As DataGridView)
    '    Try
    '        con.Open()
    '        cmd = New OleDbCommand
    '        adapter = New OleDbDataAdapter
    '        dt = New DataTable

    '        With cmd
    '            .Connection = con
    '            .CommandText = sql
    '        End With
    '        With adapter
    '            .SelectCommand = cmd
    '            .Fill(dt)
    '        End With

    '        RegistrarHistoryDataGridView.DataSource = dt
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        con.Close()
    '        adapter.Dispose()
    '    End Try
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)




        'If DateTimePicker1.Value < DateTimePicker2.Value Then
        '    RegistrarHistoryBindingSource.Filter = "Day >= '" & DateTimePicker1.Value & "' and Day <= '" & DateTimePicker2.Value & "'"

        '    'ElseIf DateTimePicker1.Value > DateTimePicker2.Value Then

        '    '    RegistrarHistoryBindingSource.Filter = "Day <= '" & DateTimePicker1.Value & "' and Day >= '" & DateTimePicker2.Value & "'"

        'Else
        '    RegistrarHistoryBindingSource.Filter = "Day <= '" & DateTimePicker1.Value & "' and Day <= '" & DateTimePicker2.Value & "'"
        'End If


    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        'RegistrarHistory_Load(Me, New System.EventArgs)


        Try


            Using con As OleDbConnection = New OleDbConnection(conString)
                Using ds1 As New DataSet
                    Dim str1 As String = "select * from RegistrarHistory"

                    adapter.SelectCommand = New OleDb.OleDbCommand(str1, con)
                    adapter.Fill(ds1)
                    RegistrarHistoryDataGridView.DataSource = ds1.Tables(0)
                    RegistrarHistoryDataGridView.Columns.Remove("ID")
                End Using
            End Using
        Catch
            'MsgBox("")
        Finally
        End Try

    End Sub
    Private bitmap As Bitmap
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        'Dim bmc As New Bitmap(RegistrarHistoryDataGridView.Width, RegistrarHistoryDataGridView.Height)
        'RegistrarHistoryDataGridView.DrawToBitmap(bmc, New Rectangle(0, 0, RegistrarHistoryDataGridView.Width, RegistrarHistoryDataGridView.Height))
        'e.Graphics.DrawImage(bmc, 150, 10)

        'e.Graphics.DrawImage(bitmap, 0, 0)
        'Dim rectprint As RectangleF = e.PageSettings.PrintableArea
        'If Me.RegistrarHistoryDataGridView.Height - rectprint.Height > 0 Then e.HasMorePages = True
        'Dim height As Integer = RegistrarHistoryDataGridView.Height
        'RegistrarHistoryDataGridView.Height = RegistrarHistoryDataGridView.RowCount * RegistrarHistoryDataGridView.RowTemplate.Height
        'bitmap = New Bitmap(Me.RegistrarHistoryDataGridView.Width, Me.RegistrarHistoryDataGridView.Height)
        'RegistrarHistoryDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.RegistrarHistoryDataGridView.Width, Me.RegistrarHistoryDataGridView.Height))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

        'PageSetupDialog1.PageSettings = New Printing.PageSettings

        'PageSetupDialog1.ShowNetwork = False


        'If PageSetupDialog1.ShowDialog = DialogResult.OK Then
        '    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        '    PrintDocument1.Print()
        'End If

        'If PrintDialog1.ShowDialog = DialogResult.OK Then
        '    PrintDocument1.PrinterSettings = PrintDialog1.PrinterSettings
        '    PrintDocument1.DefaultPageSettings.Landscape = True
        '    Call PrintDocument1.Print()
        'End If

        ' Select the printer.


        'Dim height As Integer = RegistrarHistoryDataGridView.Height
        'RegistrarHistoryDataGridView.Height = RegistrarHistoryDataGridView.RowCount * RegistrarHistoryDataGridView.RowTemplate.Height
        'bitmap = New Bitmap(Me.RegistrarHistoryDataGridView.Width, Me.RegistrarHistoryDataGridView.Height)
        'RegistrarHistoryDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.RegistrarHistoryDataGridView.Width, Me.RegistrarHistoryDataGridView.Height))
        'PrintDialog1.Document = PrintDocument1
        'PrintDialog1.print()

        If ComboBox1.Text = "XP-58C" Then
            MsgBox("This printer is not available", vbCritical, "")
            ComboBox1.SelectedIndex = -1

        ElseIf ComboBox1.Text = "" Then
            MsgBox("Please select printer", vbCritical, "")
        Else
            PrintDialog1.ShowDialog()
            PrintDocument1.PrinterSettings.PrinterName = ComboBox1.Text
        End If
        'If ComboBox1.Text = "XP-58C(1)" Then
        '    MsgBox("This printer is not available")
        '    ComboBox1.SelectedIndex = -1
        'End If
        'If ComboBox1.Text = "XP-58C(2)" Then
        '    MsgBox("This printer is not available")
        '    ComboBox1.SelectedIndex = -1
        'End If
        'If ComboBox1.Text = "XP-58C(3)" Then
        '    MsgBox("This printer is not available")
        '    ComboBox1.SelectedIndex = -1
        'End If


        'PrintDialog1.ShowDialog()


        'PrintDocument1.PrinterSettings.PrinterName = ComboBox1.Text

        'PrintDocument1.Print()



    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Try
            Dim con As OleDbConnection = New OleDbConnection(conString)
            Dim ds1 As New DataSet
            Dim str1 As String = "select * from RegistrarHistory"
            'con.Open()
            'adapter.SelectCommand = New OleDbCommand(str1, con)
            'adapter.Fill(ds1)
            'RegistrarHistoryDataGridView.DataSource = ds1.Tables(0)
        Catch
            'MsgBox("")
        Finally
        End Try
    End Sub

    Private Sub RegistrarDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Try

            Using con As OleDbConnection = New OleDbConnection(conString)
                Using ds1 As New DataSet
                    Dim str1 As String = "select * from RegistrarOnholdHistory"

                    adapter.SelectCommand = New OleDb.OleDbCommand(str1, con)
                    adapter.Fill(ds1)
                    RegistrarOnholdHistoryDataGridView.DataSource = ds1.Tables(0)
                End Using
            End Using


        Catch
            'MsgBox("")
        Finally
        End Try
    End Sub

    Private Sub PrintDocument2_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument2.PrintPage
        'e.Graphics.DrawImage(bitmap, 0, 0)
        'Dim rectprint As RectangleF = e.PageSettings.PrintableArea
        'If Me.RegistrarOnholdHistoryDataGridView.Height - rectprint.Height > 0 Then e.HasMorePages = True
        'Dim height As Integer = RegistrarOnholdHistoryDataGridView.Height
        'RegistrarOnholdHistoryDataGridView.Height = RegistrarOnholdHistoryDataGridView.RowCount * RegistrarOnholdHistoryDataGridView.RowTemplate.Height
        'bitmap = New Bitmap(Me.RegistrarOnholdHistoryDataGridView.Width, Me.RegistrarOnholdHistoryDataGridView.Height)
        'RegistrarOnholdHistoryDataGridView.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.RegistrarOnholdHistoryDataGridView.Width, Me.RegistrarOnholdHistoryDataGridView.Height))
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Panel1.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Panel2.Visible = True
        Panel1.Visible = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

      
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'If clickMonitor = False Then

        '    Try
        '        Dim screen As Screen
        '        screen = screen.AllScreens(1)
        '        NewMonitor.StartPosition = FormStartPosition.Manual
        '        NewMonitor.Location = screen.Bounds.Location + New Point(100, 100)
        '        NewMonitor.Show()
        '        clickMonitor = True
        '    Catch ex As Exception
        '        'End If
        '        MsgBox("PLEASE CONNECT TO THE MONITOR")
        '    End Try
        'ElseIf clickMonitor = True Then
        '    NewMonitor.Close()
        '    clickMonitor = False
        'End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub searchBtn_Click_1(sender As Object, e As EventArgs) Handles searchBtn.Click
        Try

            Using con As OleDbConnection = New OleDbConnection(conString)
                Using ds1 As New DataSet
                    Dim str1 As String = "select * from RegistrarOnholdHistory"

                    adapter.SelectCommand = New OleDb.OleDbCommand(str1, con)
                    adapter.Fill(ds1)
                    RegistrarOnholdHistoryDataGridView.DataSource = ds1.Tables(0)
                    RegistrarOnholdHistoryDataGridView.Columns.Remove("ID")
                End Using
            End Using


        Catch
            'MsgBox("")
        Finally
        End Try
    End Sub
End Class