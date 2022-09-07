Imports System.Data.OleDb

Public Class AdmissionPlace
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cm As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable = New DataTable()

    Private clickMonitor As Boolean = False
    Private Property cmd As OleDbCommand
    Private index As Integer = 0

    'Sub switchPanel(ByVal panel As Form)
    '    Panel1.Controls.Clear()
    '    panel.TopLevel = False
    '    Panel1.Controls.Add(panel)
    '    panel.Show()

    'End Sub
    Private Sub AdmissionPlace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.RegistrarDataGridView.Columns(0).Width = 10
        'Me.RegistrarDataGridView.Columns.Remove("ID")

        'Me.RegistrarDataGridView.Columns.RemoveAt(0)


        'If RegistrarDataGridView.ColumnCount > 0 Then
        '    Me.RegistrarDataGridView.Columns(0).Width = 10
        'Else
        '    Me.RegistrarDataGridView.Columns(0).Width = 10
        'End If

        'Dim i As Integer
        'i = 0
        'Do While i < RegistrarDataGridView.Columns(0).Width = 150

        'Loop



        MenuStrip1.ForeColor = Color.White
        'BUTTON TRANFERRING
        tcashierBtn.Visible = False
        tregistrarBtn.Visible = False
        tsgBtn.Visible = False



        updateRegandPLTimer.Enabled = True
        newMonitorTimer.Enabled = True
        totalOnqueueTimer.Enabled = True
        ableNotif.Checked = True
        priorityPLABLE.Checked = True

        'RegistrarTableAdapter.Fill(QueuingSystemDataSet.Registrar)

        AdminDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Retrieve2()

        'RegistrarDataGridView.AutoSize = DataGridViewAutoSizeColumnsMode.Fill
        'RegistrarDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'RegistrarDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells


        'RegistrarPriorityLaneDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        'RegistrarPriorityLaneDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells

        'RegistrarDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells
        'Me.RegistrarDataGridView.Columns(0).Width = 150
        'RegistrarDataGridView.Columns(2).Width = 100
        'RegistrarDataGridView.Columns(3).Width = 50


        'Dim columnwidth1 As DataGridViewColumn = Me.RegistrarDataGridView.Columns(1)
        'columnwidth1.Width = 100

        'Dim screen As Screen
        'screen = screen.AllScreens(1)
        'Monitor.StartPosition = FormStartPosition.Manual
        'Monitor.Location = screen.Bounds.Location + New Point(100, 100)
        'Monitor.Show()



        ''''dagdag
        'studentApproval_Load(Me, New System.EventArgs)

        'RegistrarDatagird
        AdminDataGridView.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None
        AdminDataGridView.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None
        AdminDataGridView.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        AdminDataGridView.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None



        'RegistrarDataGridView.DefaultCellStyle.SelectionBackColor = RegistrarDataGridView.DefaultCellStyle.BackColor
        'RegistrarDataGridView.DefaultCellStyle.SelectionForeColor = RegistrarDataGridView.DefaultCellStyle.ForeColor

        'RegistrarPriorityLaneDataGridView.DefaultCellStyle.SelectionBackColor = RegistrarPriorityLaneDataGridView.DefaultCellStyle.BackColor
        'RegistrarPriorityLaneDataGridView.DefaultCellStyle.SelectionForeColor = RegistrarPriorityLaneDataGridView.DefaultCellStyle.ForeColor

        AdminDataGridView.ForeColor = Color.Black
        AdminPriorityLaneDataGridView.ForeColor = Color.Black


        'RegistrarDataGridView.EnableHeadersVisualStyles = False

        Me.AdminDataGridView.DefaultCellStyle.SelectionBackColor = Me.AdminDataGridView.DefaultCellStyle.BackColor
        Me.AdminDataGridView.DefaultCellStyle.SelectionForeColor = Me.AdminDataGridView.DefaultCellStyle.ForeColor

        Me.AdminPriorityLaneDataGridView.DefaultCellStyle.SelectionBackColor = Me.AdminPriorityLaneDataGridView.DefaultCellStyle.BackColor
        Me.AdminPriorityLaneDataGridView.DefaultCellStyle.SelectionForeColor = Me.AdminPriorityLaneDataGridView.DefaultCellStyle.ForeColor


        'Dim a As Integer
        'For a = 5 To 10 Step +1
        '    Me.Opacity = a / 10
        '    Me.Refresh()
        '    Threading.Thread.Sleep(2)
        'Next


        'close fade away
        'Dim a As Integer
        'For a = 100 To 10 Step -1
        '    Me.Opacity = a / 100
        '    Me.Refresh()
        '    Threading.Thread.Sleep(15)
        'Next
        'Me.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        'Login.Show()
        'Me.Hide()
    End Sub
    'Private Sub Populate(number As String, purpose As String, status As String)

    '    Dim row As String() = New String() {number, purpose, status}
    '    Dim item As ListViewItem = New ListViewItem(row)

    '    ListView1.Items.Add(item)
    'End Sub
    Private Sub Delete(purpose As String)
        'SQP STMT
        Dim sql As String = "DELETE FROM AdminOnhold WHERE Number ='" + purpose + "' "

        cmd = New OleDbCommand(sql, con)
        'OPEN,CON,EXECUTE DELETE,CLOSE CON
        Try
            con.Open()

            adapter = New OleDbDataAdapter(cmd)

            adapter.DeleteCommand = con.CreateCommand()
            adapter.DeleteCommand.CommandText = sql

            'PROMPT FOR CONFIRMATION


            If cmd.ExecuteNonQuery() > 0 Then
                ClearTextBoxes()

            End If


            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            con.Close()

        End Try

    End Sub

    Private Sub ClearTextBoxes()
        onqueuenumberTxt.Text = ""
        onqueuepurposeTxt.Text = ""
        onqueuestatusTxt.Text = ""

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs)

        Retrieve2()
    End Sub

    Private Sub tcashierBtn_Click(sender As Object, e As EventArgs) Handles tcashierBtn.Click

        If onqueuenumberTxt.Text = Nothing Then
            MsgBox("Process number to transfer", vbInformation, "Queuing System")
        ElseIf onnumberTxt.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to transfer this client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into Cashier([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From Admin where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to cashier.", vbInformation, "Queuing System")
                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty

                            End Using
                        End Using
                    End Using
                Catch
                Finally
                End Try
            ElseIf vbNo Then
            End If

            'PRIORITYLANE
        ElseIf registrarnumberPL.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to transfer this priority client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into CashierPriorityLane([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From AdminPriorityLane where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to cashier.", vbInformation, "Queuing System")

                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty

                            End Using
                        End Using
                    End Using

                Catch
                Finally

                End Try
            ElseIf vbNo Then

            End If

            'ONHOLD
        ElseIf InStr(1, onholdTransfer.Text, "P", vbTextCompare) = False Then

            If MsgBox("Are you sure you want to transfer this client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into Cashier([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)
                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From AdminOnhold where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to cashier.", vbInformation, "Queuing System")

                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty
                                OnholdTxt.Clear()

                                Retrieve2()

                            End Using
                        End Using
                    End Using

                Catch
                Finally
                End Try
            ElseIf vbNo Then

            End If
            'ONHOLD PRIORITYLANE
        ElseIf InStr(1, onholdTransfer.Text, "P", vbTextCompare) Then

            If MsgBox("Are you sure you want to transfer this priority client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into CashierPriorityLane([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)
                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From AdminOnhold where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to cashier.", vbInformation, "Queuing System")

                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty
                                OnholdTxt.Clear()

                                Retrieve2()

                            End Using
                        End Using
                    End Using

                Catch
                Finally
                End Try
            ElseIf vbNo Then

            End If

        End If


    End Sub

    Private Sub doneregBtn_Click_2(sender As Object, e As EventArgs) Handles doneregBtn.Click

        If onqueuenumberTxt.Text = Nothing Then
            MsgBox("Please process number.", vbInformation, "Queuing System")



        ElseIf fordoneTxt.Text = onqueuenumberTxt.Text = True Then
            MsgBox("This number is already in the list. ", vbInformation, "Queuing System")

            onqueuenumberTxt.Text = ""
            onqueuepurposeTxt.Text = ""
            onqueuestatusTxt.Text = ""
            fordoneTxt.Text = ""


            'ONQUEUE REGISTRAR
        ElseIf onnumberTxt.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to finish this client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    onholdTransfer.Clear()
                    Dim str1 As String
                    str1 = "insert into AdminDone([Number],[Purpose],[Status]) Values(?,?,?)"
                    Dim str2 As String
                    str2 = "insert into AdminHistory([Number],[Purpose],[Day]) Values(?,?,?)"
                    Dim str3 As String
                    str3 = "insert into History([Number],[Purpose],[Day]) Values(?,?,?)"

                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                            Using cmd2 As OleDbCommand = New OleDbCommand(str2, con)
                                Using cmd3 As OleDbCommand = New OleDbCommand(str3, con)
                                    Using cmd4 As OleDbCommand = New OleDbCommand(str3, con)

                                        cmd1.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                        cmd1.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                        cmd1.Parameters.Add(New OleDbParameter("Status", CType("DONE", String)))

                                        cmd2.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                        cmd2.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                        cmd2.Parameters.Add(New OleDbParameter("Day", CType(DateTimePicker1.Text, String)))

                                        cmd3.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                        cmd3.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                        cmd3.Parameters.Add(New OleDbParameter("Day", CType(DateTimePicker1.Text, String)))


                                        cmd4.Connection = con
                                        cmd4.CommandText = "Delete From Admin where Number= @Number"
                                        cmd4.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))


                                        con.Open()
                                        cmd1.ExecuteNonQuery()
                                        cmd2.ExecuteNonQuery()
                                        cmd3.ExecuteNonQuery()
                                        cmd4.ExecuteNonQuery()

                                        onqueuenumberTxt.Text = ""
                                        onqueuepurposeTxt.Text = ""
                                        onqueuestatusTxt.Clear()

                                        onnumberTxt.Text = ""
                                        onpurposeTxt.Text = ""
                                        onstatusTxt.Text = ""
                                        MsgBox("Successfully finish.", vbInformation, "Queuing System")

                                    End Using
                                End Using
                            End Using
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error while transferring data on table..." & ex.Message, "Queuing System")
                Finally
                End Try

            ElseIf vbNo Then
                'MsgBox("ayos", vbInformation, "")
            End If


        ElseIf registrarnumberPL.Text = Nothing And onqueuenumberTxt.Text = Nothing Then
            MsgBox("Please select priority number. ", vbInformation, "")

            ''PRIORITY
        ElseIf registrarnumberPL.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to finish this client number?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    onholdTransfer.Clear()
                    Dim str1 As String
                    str1 = "insert into AdminDone([Number],[Purpose],[Status]) Values(?,?,?)"
                    Dim str2 As String
                    str2 = "insert into AdminHistory([Number],[Purpose],[Day]) Values(?,?,?)"
                    Dim str3 As String
                    str3 = "insert into History([Number],[Purpose],[Day]) Values(?,?,?)"

                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                            Using cmd2 As OleDbCommand = New OleDbCommand(str2, con)
                                Using cmd3 As OleDbCommand = New OleDbCommand(str3, con)
                                    Using cmd4 As OleDbCommand = New OleDbCommand(str3, con)

                                        cmd1.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                        cmd1.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                        cmd1.Parameters.Add(New OleDbParameter("Status", CType("DONE", String)))

                                        cmd2.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                        cmd2.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                        cmd2.Parameters.Add(New OleDbParameter("Day", CType(DateTimePicker1.Text, String)))

                                        cmd3.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                        cmd3.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                        cmd3.Parameters.Add(New OleDbParameter("Day", CType(DateTimePicker1.Text, String)))

                                        cmd4.Connection = con
                                        cmd4.CommandText = "Delete From AdminPriorityLane where Number= @Number"
                                        cmd4.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))


                                        con.Open()
                                        cmd1.ExecuteNonQuery()
                                        cmd2.ExecuteNonQuery()
                                        cmd3.ExecuteNonQuery()
                                        cmd4.ExecuteNonQuery()

                                        onqueuenumberTxt.Text = ""
                                        onqueuepurposeTxt.Text = ""
                                        onqueuestatusTxt.Clear()

                                        registrarnumberPL.Text = ""
                                        registrarpurposePL.Text = ""
                                        registrarstatusPL.Text = ""

                                        MsgBox("Successfully finish.", vbInformation, "Queuing System")

                                    End Using
                                End Using
                            End Using
                        End Using
                    End Using



                Catch ex As Exception
                    MessageBox.Show("Error while transferring data on table..." & ex.Message, "Tranferring Data")
                Finally
                End Try

            ElseIf vbNo Then
            End If

            'Onhold
        ElseIf onqueuenumberTxt.Text = OnholdTxt.Text = True Then
            If MsgBox("Are you sure you want to finish this number?", vbYesNo Or vbQuestion, "") = MsgBoxResult.Yes Then
                'Try
                onholdTransfer.Clear()
                Dim str1 As String
                str1 = "insert into AdminDone([Number],[Purpose],[Status]) Values(?,?,?)"
                Dim str2 As String
                str2 = "insert into AdminHistory([Number],[Purpose],[Day]) Values(?,?,?)"
                Dim str3 As String
                str3 = "insert into History([Number],[Purpose],[Day]) Values(?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(conString)


                    Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                        Using cmd2 As OleDbCommand = New OleDbCommand(str2, con)
                            Using cmd3 As OleDbCommand = New OleDbCommand(str3, con)
                                Using cmd4 As OleDbCommand = New OleDbCommand(str3, con)
                                    Using cmd5 As OleDbCommand = New OleDbCommand(str3, con)

                                        cmd1.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                        cmd1.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                        cmd1.Parameters.Add(New OleDbParameter("Status", CType("DONE", String)))

                                        cmd2.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                        cmd2.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                        cmd2.Parameters.Add(New OleDbParameter("Day", CType(DateTimePicker1.Text, String)))

                                        cmd3.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                        cmd3.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                        cmd3.Parameters.Add(New OleDbParameter("Day", CType(DateTimePicker1.Text, String)))




                                        cmd4.Connection = con
                                        cmd4.CommandText = "Delete From AdminOnhold where Number= @Number"
                                        cmd4.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                        'Dim sql = "Delete From AdminOnhold WHERE Number = @Number"
                                        'Dim sda As OleDbDataAdapter = New OleDbDataAdapter(sql, con)
                                        'Dim com As OleDbCommand = New OleDbCommand(sql, con)

                                        'com.Parameters.AddWithValue("@Number", onqueuenumberTxt.Text)

                                        'Dim con1 As OleDbConnection = New OleDbConnection(conString)
                                        'Dim sql = "Delete From AdminOnhold WHERE Number = @Number"

                                        'Dim cmd As OleDbCommand = New OleDbCommand(sql, con1)
                                        'con.Open()
                                        'cmd.Parameters.AddWithValue("@Number", onqueuenumberTxt.Text)
                                        'cmd.ExecuteNonQuery()




                                        'Dim name As String = ListView2.SelectedItems(0).SubItems(0).Text
                                        'Delete(name)


                                        cmd5.Connection = con
                                        cmd5.CommandText = "Delete From AdminOnholdHistory where Number= @Number"
                                        cmd5.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                        con.Open()
                                        cmd1.ExecuteNonQuery()
                                        cmd2.ExecuteNonQuery()
                                        cmd3.ExecuteNonQuery()

                                        cmd4.ExecuteNonQuery()

                                        cmd5.ExecuteNonQuery()

                                        MsgBox("Successfully finish.", vbInformation, "finish")

                                        onqueuenumberTxt.Text = ""
                                        onqueuepurposeTxt.Text = ""
                                        onqueuestatusTxt.Clear()


                                        Retrieve2()

                                    End Using
                                End Using
                            End Using
                        End Using
                    End Using
                End Using

                'Catch
                'Finally
                'End Try

            ElseIf vbNo Then
            End If
        Else
            MsgBox("Please process Now Serving", vbCritical, "")
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs)

        Try
            'Dim screen As Screen
            'Dim confirm = MsgBox(" Connect to monitor?(Extend these display)", vbYesNo, "Monitor")
            'If confirm = vbYes Then
            'screen = screen.AllScreens(1)
            'Monitor.StartPosition = FormStartPosition.Manual
            'Monitor.Location = screen.Bounds.Location + New Point(100, 100)
            'Monitor.Show()
        Catch ex As Exception
            'End If
            MsgBox("PLEASE CONNECT TO THE MONITOR")
        End Try
    End Sub
    Private Sub Populate2(number As String, purpose As String, status As String)

        Dim row As String() = New String() {number, purpose, status}
        Dim item As ListViewItem = New ListViewItem(row)

        ListView2.Items.Add(item)
    End Sub
    Private Sub Retrieve2()
        ListView2.Items.Clear()
        Dim sql As String = "SELECT * FROM AdminOnhold"
        cmd = New OleDbCommand(sql, con)
        'OPEM CON, RETRIEVE, FILL LISTVIEW
        Try

            If ConnectionState.Closed Then
                con.Open()

            End If
            adapter = New OleDbDataAdapter(cmd)
            adapter.Fill(dt)
            'LOOP THRU DATATABLE
            For Each row In dt.Rows
                Populate2(row(1), row(2), row(3))
            Next
            'CLEAR DATATABLE
            dt.Rows.Clear()


        Catch ex As Exception
            'MsgBox(ex.Message)

        Finally
            con.Close()
        End Try
    End Sub
    Private Sub ListView2_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView2.MouseDoubleClick

        Try
            Dim Number As String = ListView2.SelectedItems(0).SubItems(0).Text
            Dim Purpose As String = ListView2.SelectedItems(0).SubItems(1).Text
            Dim Status As String = ListView2.SelectedItems(0).SubItems(2).Text
            Dim confirm = MsgBox(" Are you sure you want to Nowserving it?", vbYesNo Or vbQuestion, "Nowserving")

            If confirm = vbYes Then
                onqueuenumberTxt.Text = Number
                onqueuepurposeTxt.Text = Purpose
                onqueuestatusTxt.Text = Status
                OnholdTxt.Text = Number


                'CLEAR TEXTBOXES 
                onnumberTxt.Clear()
                registrarnumberPL.Clear()




                'CheckBox1.Checked = False
                'CheckBox2.Checked = False
                'ListView2.Enabled = False
                Holdbtn.Enabled = False
                'Clear texboxes sa likod ng listview 
                'Timer4.Enabled = True

            End If
        Catch ex As Exception
            MsgBox("Try Again", vbInformation, "")
        End Try

    End Sub

    'Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click

    '    If onqueuenumberTxt.Text = Nothing Then
    '        MsgBox("No number to recall", vbInformation, "")

    '    ElseIf prioritylabel.Visible = True Then
    '        Dim SAPI As Object
    '        SAPI = CreateObject("SAPI.spvoice")
    '        SAPI.speak(nowservinglabelTxt.Text + prioritylabel.Text + onqueuenumberTxt.Text)
    '    Else

    '        Dim SAPI As Object
    '        SAPI = CreateObject("SAPI.spvoice")
    '        SAPI.speak(nowservinglabelTxt.Text + onqueuenumberTxt.Text)
    '    End If
    'End Sub
    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        AdmissionHistory.Show()
    End Sub

    Private Sub MonitorToolStripMenuItem1_Click_1(sender As Object, e As EventArgs)
        Try
            Dim screen As Screen
            'Dim confirm = MsgBox(" Connect to monitor?(Extend these display)", vbYesNo, "Monitor")
            'If confirm = vbYes Then
            screen = screen.AllScreens(1)
            'NewMonitor.StartPosition = FormStartPosition.Manual
            'NewMonitor.Location = screen.Bounds.Location + New Point(100, 100)
            'NewMonitor.Show()
        Catch ex As Exception
            'End If
            MsgBox("PLEASE CONNECT TO THE MONITOR")
        End Try
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs)
        'CashierHistory.Location = Screen.AllScreens(UBound(Screen.AllScreens)).Bounds.Location + New Point(100, 100)
        'CashierHistory.Show()
    End Sub

    Private Sub FinishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FinishToolStripMenuItem.Click
        AdmissionDone.ShowDialog()

    End Sub

    Private Sub AddPurposeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPurposeToolStripMenuItem.Click
        AdmissionaddPurpose.ShowDialog()
    End Sub

    Private Sub tregistrarBtn_Click(sender As Object, e As EventArgs) Handles tregistrarBtn.Click

        'Dim confirm = MsgBox("Are you sure you want to transfer this number?", vbYesNo Or vbQuestion, "")
        If onqueuenumberTxt.Text = Nothing Then
            MsgBox("Please process client number to transfer", vbInformation, "Queuing System")
        ElseIf onnumberTxt.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to transfer this client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into registrar([Number],[Purpose],[Status]) Values(?,?,?)"

                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From admin where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty

                                MsgBox("Successfully transferred to Registrar", vbInformation, "Queuing System")

                            End Using
                        End Using
                    End Using
                Catch

                Finally

                End Try

            ElseIf vbNo Then

            End If
            'Admission.Show() PRIORITYYLANE
        ElseIf registrarnumberPL.Text = onqueuenumberTxt.Text = True Then

            If MsgBox("Are you sure you want to transfer this priority client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Dim str As String
                str = "insert into RegistrarPriorityLane([Number],[Purpose],[Status]) Values(?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(conString)
                    Using cmd As OleDbCommand = New OleDbCommand(str, con)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                            cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                            cmd1.Connection = con
                            cmd1.CommandText = "Delete From AdminPriorityLane where Number= @Number"
                            cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd1.ExecuteNonQuery()
                            MsgBox("Successfully transferred to Registrar", vbInformation, "Queuing System")

                            onqueuenumberTxt.Text = String.Empty
                            onqueuepurposeTxt.Text = String.Empty
                            onqueuestatusTxt.Text = String.Empty

                        End Using
                    End Using
                End Using

            ElseIf vbNo Then

            End If

            'ONHOLD
        ElseIf InStr(1, onholdTransfer.Text, "P", vbTextCompare) = False Then

            If MsgBox("Are you sure you want to transfer this client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Dim str As String
                str = "insert into Registrar([Number],[Purpose],[Status]) Values(?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(conString)
                    Using cmd As OleDbCommand = New OleDbCommand(str, con)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                            cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                            cmd1.Connection = con
                            cmd1.CommandText = "Delete From AdminOnhold where Number= @Number"
                            cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd1.ExecuteNonQuery()

                            MsgBox("Successfully transferred to Registrar", vbInformation, "Queuing System")

                            onqueuenumberTxt.Text = String.Empty
                            onqueuepurposeTxt.Text = String.Empty
                            onqueuestatusTxt.Text = String.Empty
                            OnholdTxt.Clear()
                            Retrieve2()
                        End Using
                    End Using
                End Using

            ElseIf vbNo Then
            End If

            'ONHOLD PRIORITYLANE
        ElseIf InStr(1, onholdTransfer.Text, "P", vbTextCompare) Then

            If MsgBox("Are you sure you want to transfer this priority client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Dim str As String
                str = "insert into RegistrarPriorityLane([Number],[Purpose],[Status]) Values(?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(conString)
                    Using cmd As OleDbCommand = New OleDbCommand(str, con)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                            cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                            cmd1.Connection = con
                            cmd1.CommandText = "Delete From AdminOnhold where Number= @Number"
                            cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd1.ExecuteNonQuery()

                            MsgBox("Successfully transferred to Registrar", vbInformation, "Queuing System")

                            onqueuenumberTxt.Text = String.Empty
                            onqueuepurposeTxt.Text = String.Empty
                            onqueuestatusTxt.Text = String.Empty
                            OnholdTxt.Clear()
                            Retrieve2()


                        End Using
                    End Using
                End Using

            ElseIf vbNo Then
            End If
        End If
    End Sub

    Private Sub tsgBtn_Click(sender As Object, e As EventArgs) Handles tsgBtn.Click
        'Dim confirm = MsgBox("Are you sure you want to transfer this number?", vbYesNo Or vbQuestion, "")
        If onqueuenumberTxt.Text = Nothing Then
            MsgBox("Please process number to transfer", vbInformation, "Queuing System")

        ElseIf onnumberTxt.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to transfer this client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into SG([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)
                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From Admin where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to Student Government", vbInformation, "Queuing System")

                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty

                            End Using
                        End Using
                    End Using
                Catch

                Finally
                End Try
            ElseIf vbNo Then

            End If

            'PriorityLane
        ElseIf registrarnumberPL.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to transfer this priority client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into SGPriorityLane([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From AdminPriorityLane where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()


                                MsgBox("Successfully transferred to Student Government", vbInformation, "Queuing System")
                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty
                            End Using
                        End Using
                    End Using
                Catch
                Finally
                End Try

            ElseIf vbNo Then
            End If

            'ONHOLD
        ElseIf InStr(1, onholdTransfer.Text, "P", vbTextCompare) = False Then
            If MsgBox("Are you sure you want to transfer this client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into SG([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From AdminOnhold where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))
                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()


                                MsgBox("Successfully transferred to Student Government", vbInformation, "Queuing System")
                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty
                                OnholdTxt.Clear()
                                Retrieve2()

                            End Using
                        End Using
                    End Using
                Catch
                Finally
                End Try

            ElseIf vbNo Then
            End If

            'ONHOLD PRIORITYLANE
        ElseIf InStr(1, onholdTransfer.Text, "P", vbTextCompare) Then
            If MsgBox("Are you sure you want to transfer this priority client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into SGPriorityLane([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From AdminOnhold where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))
                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to Student Government", vbInformation, "Queuing System")

                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty
                                OnholdTxt.Clear()
                                Retrieve2()
                            End Using
                        End Using
                    End Using
                Catch
                Finally
                End Try

            ElseIf vbNo Then
            End If
        End If
    End Sub
    Private Sub totalOnqueueTimer_Tick(sender As Object, e As EventArgs) Handles totalOnqueueTimer.Tick
        Try
            Try
                Using con As OleDbConnection = New OleDbConnection(conString)
                    con.Open()
                    Using cmd1 = New OleDbCommand("SELECT COUNT(*)AS Row_Count FROM Admin ", con)
                        Dim Count As Integer = Convert.ToInt32(cmd1.ExecuteScalar())
                        totalonqueue.Text = Count.ToString

                        Using cmd2 = New OleDbCommand("SELECT COUNT(*)AS Row_Count FROM AdminPriorityLane ", con)
                            Dim Count2 As Integer = Convert.ToInt32(cmd2.ExecuteScalar())
                            totalPL.Text = Count2.ToString

                            'Total
                            total.Text = Val(totalonqueue.Text) + Val(totalPL.Text)
                        End Using
                    End Using
                End Using

            Catch
                'MsgBox("ERROR SA COUNT REGISTRAR AND PRIORITYLANE1")
            Finally
            End Try
        Catch
            'MsgBox("ERROR SA COUNT REGISTRAR AND PRIORITYLANE2")
        Finally
        End Try

    End Sub
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Dim confirm = MsgBox("Are you sure you want to Log out?", vbYesNo Or vbQuestion, "Log out")

        If confirm = vbYes Then
            'Login.Show()
            disableNotif.Checked = True
            AdmissionPopup.Close()
            Me.Hide()
        End If
    End Sub

    Private Sub Holdbtn_Click_1(sender As Object, e As EventArgs) Handles Holdbtn.Click

        If onqueuenumberTxt.Text = Nothing Then
            MsgBox("Process number to hold.", vbInformation, "Queuing System")
            'ONQUEUE
        ElseIf onnumberTxt.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to hold this client?", vbYesNo Or vbQuestion) = MsgBoxResult.Yes Then
                Try
                    Dim str1 As String
                    str1 = "insert into AdminOnholdHistory([Number],[Purpose],[Day]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                            cmd1.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Day", CType(DateTimePicker1.Text, String)))

                            Dim str2 As String
                            str2 = "insert into AdminOnhold([Number],[Purpose],[Status]) Values(?,?,?)"
                            Using cmd2 As OleDbCommand = New OleDbCommand(str2, con)
                                cmd2.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd2.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd2.Parameters.Add(New OleDbParameter("Status", CType("HOLD", String)))

                                Using cmd3 As OleDbCommand = New OleDbCommand(str2, con)
                                    cmd3.Connection = con
                                    cmd3.CommandText = "Delete From Admin where Number= @Number"
                                    cmd3.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                    con.Open()
                                    cmd1.ExecuteNonQuery()
                                    cmd2.ExecuteNonQuery()
                                    cmd3.ExecuteNonQuery()

                                    MsgBox("Hold Successfully.", vbInformation, "")
                                    onqueuenumberTxt.Text = ""
                                    onqueuepurposeTxt.Text = ""
                                    onqueuestatusTxt.Text = ""
                                    'AdmissionPlace_Load(Me, New System.EventArgs)
                                    Retrieve2()


                                End Using
                            End Using
                        End Using
                    End Using


                Catch ex As Exception
                    MessageBox.Show("Error while transferring data on table..." & ex.Message, "Tranferring Data")
                Finally
                End Try


            ElseIf vbNo Then
            End If
            'AdminONHOLDHISTORY
        ElseIf onqueuenumberTxt.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to hold this priority client?", vbYesNo Or vbQuestion) = MsgBoxResult.Yes Then
                Try
                    Dim str1 As String
                    str1 = "insert into AdminOnholdHistory([Number],[Purpose],[Day]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                            cmd1.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Day", CType(DateTimePicker1.Text, String)))

                            Dim str2 As String
                            str2 = "insert into AdminOnhold([Number],[Purpose],[Status]) Values(?,?,?)"
                            Using cmd2 As OleDbCommand = New OleDbCommand(str2, con)
                                cmd2.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd2.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd2.Parameters.Add(New OleDbParameter("Status", CType("HOLD", String)))

                                Using cmd3 As OleDbCommand = New OleDbCommand(str2, con)
                                    cmd3.Connection = con
                                    cmd3.CommandText = "Delete From AdminPriorityLane where Number= @Number"
                                    cmd3.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                    con.Open()
                                    cmd1.ExecuteNonQuery()
                                    cmd2.ExecuteNonQuery()
                                    cmd3.ExecuteNonQuery()

                                    MsgBox("Hold Successfully.", vbInformation, "")
                                    onqueuenumberTxt.Text = ""
                                    onqueuepurposeTxt.Text = ""
                                    onqueuestatusTxt.Text = ""
                                    Retrieve2()

                                End Using
                            End Using
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error while transferring data on table..." & ex.Message, "Tranferring Data")
                Finally
                End Try

            ElseIf vbNo Then
            End If

        ElseIf vbNo Then
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        onqueuenumberTxt.Text = ""
        onqueuepurposeTxt.Text = ""
        onqueuestatusTxt.Text = ""
        fordoneTxt.Clear()
        onholdTransfer.Clear()
    End Sub

    Private Sub updateRegandPLTimer_Tick(sender As Object, e As EventArgs) Handles updateRegandPLTimer.Tick
        DateTimePicker1.Value = DateTime.Now


        Try
            'con.Open()
            Using adapter As New OleDbDataAdapter
                Using ds1 As New DataSet
                    Dim str1 As String = "select * from Admin"

                    adapter.SelectCommand = New OleDbCommand(str1, con)
                    adapter.Fill(ds1)
                    Me.AdminDataGridView.DataSource = ds1.Tables(0)
                    Me.AdminDataGridView.Columns.Remove("ID")
                    Me.AdminDataGridView.Columns(0).Width = 80
                    Me.AdminDataGridView.Columns(1).Width = 230
                    Using ds2 As New DataSet
                        Dim str2 As String = "select * from AdminPriorityLane"

                        adapter.SelectCommand = New OleDbCommand(str2, con)
                        adapter.Fill(ds2)

                        'con.Close()
                        Me.AdminPriorityLaneDataGridView.DataSource = ds2.Tables(0)
                        Me.AdminPriorityLaneDataGridView.Columns.Remove("ID")
                        Me.AdminPriorityLaneDataGridView.Columns(0).Width = 80
                        Me.AdminPriorityLaneDataGridView.Columns(1).Width = 230
                        'RegistrarPlace_Load(Me, New System.EventArgs)
                    End Using

                    'Using ds3 As New DataSet
                    '    Dim str3 As String = "select * from AdminOnhold"

                    '    adapter.SelectCommand = New OleDbCommand(str3, con)
                    '    adapter.Fill(ds3)

                    '    'con.Close()
                    '    Me.AdminOnholdDataGridView.DataSource = ds3.Tables(0)
                    '    Me.AdminOnholdDataGridView.Columns.Remove("ID")
                    '    Me.AdminOnholdDataGridView.Columns(0).Width = 80
                    '    Me.AdminOnholdDataGridView.Columns(1).Width = 230
                    '    'RegistrarPlace_Load(Me, New System.EventArgs)
                    'End Using
                End Using
            End Using

        Catch
            'MsgBox("")
        Finally
        End Try
    End Sub
    Private Sub HistoryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem1.Click
        AdmissionHistory.ShowDialog()
    End Sub
    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        'RegistrarDataGridView.DataSource = Reset
    End Sub
    Private Sub notificationTimer_Tick(sender As Object, e As EventArgs) Handles notificationTimer.Tick


        If totalonqueue.Text <> 0 Then
            AdmissionPopup.Show()
            AdmissionPopup.Activate()
            'AdminPopup.Close()
        End If
        If totalPL.Text <> 0 Then
            AdmissionPopup.Show()
            AdmissionPopup.Activate()
            'AdminPopup.Close()
        End If

    End Sub

    Public Class myVar
        Private mValue As Integer
        Public Event VariableChanged(ByVal mvalue As Integer)
        Public Property Variable() As Integer
            Get
                Variable = mValue
            End Get
            Set(ByVal value As Integer)
                mValue = value
                RaiseEvent VariableChanged(mValue)
            End Set
        End Property
    End Class
    Private Sub ableNotif_CheckedChanged(sender As Object, e As EventArgs) Handles ableNotif.CheckedChanged
        notificationTimer.Enabled = True
    End Sub
    Private Sub disableNotif_CheckedChanged(sender As Object, e As EventArgs) Handles disableNotif.CheckedChanged
        notificationTimer.Enabled = False
        AdmissionPopup.Close()
    End Sub
    Private Sub Button10_Click_1(sender As Object, e As EventArgs)
        Try
            con.Open()
            Dim cmd1 As New OleDb.OleDbCommand("SELECT Number FROM Admin", con)
            Dim cmd2 As New OleDb.OleDbCommand("SELECT Purpose FROM Admin", con)
            Dim cmd3 As New OleDb.OleDbCommand("SELECT Status FROM Admin", con)
            Dim dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader
            Dim dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader
            Dim dr3 As OleDb.OleDbDataReader = cmd3.ExecuteReader
            While dr1.Read()
                While dr2.Read()
                    While dr3.Read()
                        onnumberTxt.Text = dr1("Number").ToString()
                        onpurposeTxt.Text = dr2("Purpose").ToString()
                        onstatusTxt.Text = dr3("Status").ToString()
                    End While
                End While
            End While

        Catch
            'MsgBox("ERROR SA CHECKBOX1")
        Finally
        End Try
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs)
        Try
            Dim cmd1 As New OleDb.OleDbCommand("SELECT Number FROM AdminPriorityLane", con)
            Dim cmd2 As New OleDb.OleDbCommand("SELECT Purpose FROM AdminPriorityLane", con)
            Dim cmd3 As New OleDb.OleDbCommand("SELECT Status FROM AdminPriorityLane", con)
            Dim dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader
            Dim dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader
            Dim dr3 As OleDb.OleDbDataReader = cmd3.ExecuteReader
            While dr1.Read()
                While dr2.Read()
                    While dr3.Read()
                        onnumberTxt.Text = dr1("Number").ToString()
                        onpurposeTxt.Text = dr2("Purpose").ToString()
                        onstatusTxt.Text = dr3("Status").ToString()
                    End While
                End While
            End While
        Catch
            'MsgBox("ERROR SA CHECKBOX1")
        Finally
        End Try
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Dim confirm = MsgBox("Are you sure you want to Log out?", vbYesNo Or vbQuestion, "Log out")
        'If confirm = vbYes Then
        '    Using con As OleDbConnection = New OleDbConnection(conString)
        '        Dim del As String = "DELETE FROM AdminHasLogin WHERE HasLogin "
        '        cmd = New OleDbCommand(del, con)
        '        'OPEN,CON,EXECUTE DELETE,CLOSE CON
        '        Try

        '            con.Open()
        '            adapter = New OleDbDataAdapter(cmd)

        '            adapter.DeleteCommand = con.CreateCommand()
        '            adapter.DeleteCommand.CommandText = del

        '            'PROMPT FOR CONFIRMATION


        '            If cmd.ExecuteNonQuery() > 0 Then
        '                ClearTextBoxes()

        '            End If
        '        Catch
        '        End Try
        '        updateRegandPLTimer.Enabled = False
        '        newMonitorTimer.Enabled = False
        '        totalOnqueueTimer.Enabled = False

        '        onqueuenumberTxt.Text = ""

        '        Login.Show()

        '        disableNotif.Checked = True
        '        AdmissionPopup.Close()
        '        AdmissionHistory.Close()
        '        'Application.Exit()
        '        Me.Hide()
        '    End Using
        'End If
        Try
            If confirm = vbYes Then
                onqueuenumberTxt.Text = ""
                Using con As OleDbConnection = New OleDbConnection(conString)
                    Using cmd2 As New OleDbCommand("UPDATE AdminMonitor SET Purpose1=pur1", con)
                        Dim del As String = "DELETE FROM AdminHasLogin WHERE HasLogin "

                        cmd = New OleDbCommand(del, con)

                        cmd2.Parameters.Add(New OleDbParameter("pur1", CType(onqueuenumberTxt.Text, String)))
                        'OPEN,CON,EXECUTE DELETE,CLOSE CON


                        con.Open()
                        adapter = New OleDbDataAdapter(cmd)

                        adapter.DeleteCommand = con.CreateCommand()
                        adapter.DeleteCommand.CommandText = del

                        'PROMPT FOR CONFIRMATION
                        If cmd.ExecuteNonQuery() > 0 Then
                            ClearTextBoxes()

                        End If
                        cmd2.ExecuteNonQuery()

                        updateRegandPLTimer.Enabled = False
                        newMonitorTimer.Enabled = False
                        totalOnqueueTimer.Enabled = False

                    End Using
                End Using
                Login.Show()
                disableNotif.Checked = True
                AdmissionPopup.Close()
                AdmissionHistory.Close()
                Me.Hide()
            End If
        Catch

        Finally
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd1 As New OleDb.OleDbCommand("SELECT Number FROM Admin", con)
                    Using cmd2 As New OleDb.OleDbCommand("SELECT Purpose FROM Admin", con)
                        Using cmd3 As New OleDb.OleDbCommand("SELECT Status FROM Admin", con)
                            con.Open()
                            Using dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader
                                Using dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader
                                    Using dr3 As OleDb.OleDbDataReader = cmd3.ExecuteReader

                                        If dr1.HasRows = 0 And priorityPLDISABLE.Checked = True Then
                                            MsgBox("There is no client on wait.", vbInformation, "Queuing System")
                                        ElseIf dr1.HasRows And priorityPLDISABLE.Checked = True Then
                                            If MsgBox("Are you sure you want to process client onqueue?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then

                                                onholdTransfer.Clear()
                                                Holdbtn.Enabled = True
                                                While dr1.Read()
                                                    While dr2.Read()
                                                        While dr3.Read()


                                                            onnumberTxt.Text = dr1("Number").ToString()
                                                            onpurposeTxt.Text = dr2("Purpose").ToString()
                                                            onstatusTxt.Text = dr3("Status").ToString()

                                                            onqueuenumberTxt.Text = onnumberTxt.Text
                                                            onqueuepurposeTxt.Text = onpurposeTxt.Text
                                                            onqueuestatusTxt.Text = onstatusTxt.Text

                                                            registrarnumberPL.Clear()
                                                            registrarpurposePL.Clear()
                                                            registrarstatusPL.Clear()
                                                        End While
                                                    End While
                                                End While

                                            ElseIf vbNo Then
                                            End If
                                        End If

                                    End Using
                                End Using
                            End Using
                        End Using
                    End Using
                End Using
            End Using
        Catch
        Finally
        End Try

        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd1 As New OleDb.OleDbCommand("SELECT Number FROM AdminPriorityLane", con)
                    Using cmd2 As New OleDb.OleDbCommand("SELECT Purpose FROM AdminPriorityLane", con)
                        Using cmd3 As New OleDb.OleDbCommand("SELECT Status FROM AdminPriorityLane", con)

                            con.Open()
                            Using dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader
                                Using dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader
                                    Using dr3 As OleDb.OleDbDataReader = cmd3.ExecuteReader

                                        If dr1.HasRows = 0 And priorityPLABLE.Checked = True Then
                                            MsgBox("There is no priority client on wait.", vbInformation, "Queuing System")
                                        ElseIf dr1.HasRows And priorityPLABLE.Checked = True Then
                                            If MsgBox("Are you sure you want to process client priority?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then

                                                onholdTransfer.Clear()
                                                Holdbtn.Enabled = True
                                                While dr1.Read()
                                                    While dr2.Read()
                                                        While dr3.Read()


                                                            registrarnumberPL.Text = dr1("Number").ToString()
                                                            registrarpurposePL.Text = dr2("Purpose").ToString()
                                                            registrarstatusPL.Text = dr3("Status").ToString()

                                                            onqueuenumberTxt.Text = registrarnumberPL.Text
                                                            onqueuepurposeTxt.Text = registrarpurposePL.Text
                                                            onqueuestatusTxt.Text = registrarstatusPL.Text

                                                            onnumberTxt.Clear()
                                                            onpurposeTxt.Clear()
                                                            onstatusTxt.Clear()
                                                        End While
                                                    End While
                                                End While
                                            End If
                                        End If

                                    End Using
                                End Using
                            End Using
                        End Using
                    End Using
                End Using
            End Using


        Catch
        Finally
        End Try


    End Sub

    Private Sub newMonitor_Tick(sender As Object, e As EventArgs) Handles newMonitorTimer.Tick

        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd As New OleDbCommand("UPDATE AdminMonitor SET Purpose1=pur1", con)
                    cmd.Parameters.Add(New OleDbParameter("pur1", CType(onqueuenumberTxt.Text, String)))

                    con.Open()
                    cmd.ExecuteNonQuery()

                End Using
            End Using

        Catch
            'MsgBox("NC1")
        Finally

        End Try


    End Sub



    Private Sub priorityPLDISABLE_CheckedChanged(sender As Object, e As EventArgs) Handles priorityPLDISABLE.CheckedChanged
        prioritylabel.Visible = False
    End Sub

    Private Sub priorityPLABLE_CheckedChanged(sender As Object, e As EventArgs) Handles priorityPLABLE.CheckedChanged
        prioritylabel.Visible = True
    End Sub

    Private Sub AbleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AbleToolStripMenuItem.Click
        tcashierBtn.Visible = True
    End Sub

    Private Sub DisableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableToolStripMenuItem.Click
        tcashierBtn.Visible = False
    End Sub

    Private Sub AbleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AbleToolStripMenuItem1.Click
        tregistrarBtn.Visible = True
    End Sub

    Private Sub DisableToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DisableToolStripMenuItem1.Click
        tregistrarBtn.Visible = False
    End Sub

    Private Sub AbleToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles AbleToolStripMenuItem2.Click
        tsgBtn.Visible = True
    End Sub

    Private Sub DisableToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DisableToolStripMenuItem2.Click
        tsgBtn.Visible = False
    End Sub

    Private Sub refreshBtn_Click(sender As Object, e As EventArgs) Handles refreshBtn.Click
        Try
            'refreshBtn.BackColor = Color.Blue
            Retrieve2()

        Catch ex As Exception
        Finally

        End Try
    End Sub




    Private Sub ManageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManageToolStripMenuItem.Click
        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using ds1 As New DataSet
                    Dim str1 As String = "select * from PendingLogs"

                    adapter.SelectCommand = New OleDb.OleDbCommand(str1, con)
                    adapter.Fill(ds1)
                    Approved.PendingLogsDataGridView.DataSource = ds1.Tables(0)
                    Approved.PendingLogsDataGridView.Columns.RemoveAt(0)
                    Approved.PendingLogsDataGridView.Columns(0).Width = 150

                    Approved.PendingLogsDataGridView.Columns(4).Width = 0
                    Approved.PendingLogsDataGridView.Columns(5).Width = 0
                    Approved.PendingLogsDataGridView.Columns(6).Width = 0
                    Approved.PendingLogsDataGridView.Columns(7).Width = 0
                    Approved.PendingLogsDataGridView.Columns(8).Width = 0


                End Using
            End Using
        Catch
            'MsgBox("")
        Finally
        End Try
        Approved.ShowDialog()
    End Sub

    Private Sub MonitorDisplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonitorDisplayToolStripMenuItem.Click


        'Try
        '    Dim screen As Screen
        '    screen = screen.AllScreens(1)
        '    Monitor.StartPosition = FormStartPosition.Manual
        '    Monitor.Location = screen.Bounds.Location + New Point(100, 100)
        '    Monitor.Show()
        '    clickMonitor = True
        'Catch
        'Finally
        'End Try

        'If clickMonitor = False Then
        '    Try
        '        Dim screen As Screen
        '        screen = screen.AllScreens(1)
        '        Monitor.StartPosition = FormStartPosition.Manual
        '        Monitor.Location = screen.Bounds.Location + New Point(100, 100)
        '        Monitor.Show()
        '        clickMonitor = True
        '    Catch
        '    Finally
        '    End Try


        'ElseIf clickMonitor = True Then
        '    Monitor.Close()
        '    clickMonitor = False
        'End If



    End Sub

    Private Sub DisplayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplayToolStripMenuItem.Click
        Try
            Dim screen As Screen
            screen = screen.AllScreens(1)
            Monitor.StartPosition = FormStartPosition.Manual
            Monitor.Location = screen.Bounds.Location + New Point(100, 100)
            Monitor.Show()

        Catch
        Finally
        End Try




    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Monitor.Close()
    End Sub

    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetToolStripMenuItem.Click
        Reset.ShowDialog()
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Account.ShowDialog()
    End Sub


  

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

 
    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs)
        DisplaySchoolPicture.ShowDialog()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Queuing Sytem examines every component of waiting in line to be served, including the arrival process, service process.", vbInformation, "Queuing System")
    End Sub

    Private Sub AccountToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click

        Account.ShowDialog()
    End Sub
End Class