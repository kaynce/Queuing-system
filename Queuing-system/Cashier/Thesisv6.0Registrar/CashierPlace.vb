Imports System.Data.OleDb

Public Class CashierPlace
    Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\DESKTOP-I9R457E\Thesis5.0Database\QueuingSystem.accdb;Jet OLEDB:Database Password=123;"
    Dim con As OleDbConnection = New OleDbConnection(conString)
    Dim cm As OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dt As DataTable = New DataTable()

    Private Property cmd As OleDbCommand
    Private index As Integer = 0

    'Sub switchPanel(ByVal panel As Form)
    '    Panel1.Controls.Clear()
    '    panel.TopLevel = False
    '    Panel1.Controls.Add(panel)
    '    panel.Show()


    'End Sub
    Private Sub RegistrarPlace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
     
        MenuStrip1.ForeColor = Color.Black
        'BUTTON TRANFERRING
        tregistrarBtn.Visible = False
        tadminBtn.Visible = False
        tsgBtn.Visible = False



        updateRegandPLTimer.Enabled = True
        newMonitorTimer.Enabled = True
        totalOnqueueTimer.Enabled = True
        ableNotif.Checked = True
        priorityPLABLE.Checked = True


        RegistrarDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        Retrieve2()

        'Dim screen As Screen
        'screen = screen.AllScreens(1)
        'Monitor.StartPosition = FormStartPosition.Manual
        'Monitor.Location = screen.Bounds.Location + New Point(100, 100)
        'Monitor.Show()




        'RegistrarDatagird
        RegistrarDataGridView.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None
        RegistrarDataGridView.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None
        RegistrarDataGridView.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None
        RegistrarDataGridView.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None

        RegistrarDataGridView.ForeColor = Color.Black
        RegistrarPriorityLaneDataGridView.ForeColor = Color.Black


        Me.RegistrarDataGridView.DefaultCellStyle.SelectionBackColor = Me.RegistrarDataGridView.DefaultCellStyle.BackColor
        Me.RegistrarDataGridView.DefaultCellStyle.SelectionForeColor = Me.RegistrarDataGridView.DefaultCellStyle.ForeColor

        Me.RegistrarPriorityLaneDataGridView.DefaultCellStyle.SelectionBackColor = Me.RegistrarPriorityLaneDataGridView.DefaultCellStyle.BackColor
        Me.RegistrarPriorityLaneDataGridView.DefaultCellStyle.SelectionForeColor = Me.RegistrarPriorityLaneDataGridView.DefaultCellStyle.ForeColor



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
        Dim sql As String = "DELETE FROM Registrar WHERE Number ='" + purpose + "' "

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

    Private Sub tcashierBtn_Click(sender As Object, e As EventArgs) Handles tregistrarBtn.Click

        If onqueuenumberTxt.Text = Nothing Then
            MsgBox("Process number to transfer", vbInformation, "Queuing System")

        ElseIf onnumberTxt.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to transfer this number?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into Registrar([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From Cashier where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to Registrar.", vbInformation, "Queuing System")
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
            If MsgBox("Are you sure you want to transfer this priority number?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into RegistrarPriorityLane([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From CashierPriorityLane where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to Registrar.", vbInformation, "Queuing System")

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
            '    'Onhold
        ElseIf InStr(1, onholdTransfer.Text, "P", vbTextCompare) = False Then

            If MsgBox("Are you sure you want to transfer this number?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into Registrar([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)
                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType("PENDING", String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From CashierOnhold where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to cashier.", vbInformation, "Queuing System")

                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty
                                onholdTransfer.Clear()
                                Retrieve2()

                            End Using
                        End Using
                    End Using

                Catch
                Finally
                End Try
            ElseIf vbNo Then

            End If
            'ONHOLD Registrar TRANSFER
        ElseIf InStr(1, onholdTransfer.Text, "P", vbTextCompare) Then

            If MsgBox("Are you sure you want to transfer this number?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into RegistrarPriorityLane([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)
                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType("PENDING", String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From CashierOnhold where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to Registrar.", vbInformation, "Queuing System")

                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty
                                onholdTransfer.Clear()
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
            MsgBox("This number is already in the list. ", vbInformation, "")

            onqueuenumberTxt.Text = ""
            onqueuepurposeTxt.Text = ""
            onqueuestatusTxt.Text = ""
            fordoneTxt.Text = ""

            'ONQUEUE CASHIER
        ElseIf onnumberTxt.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to finish this client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    onholdTransfer.Clear()
                    Dim str1 As String
                    str1 = "insert into CashierDone([Number],[Purpose],[Status]) Values(?,?,?)"
                    Dim str2 As String
                    str2 = "insert into CashierHistory([Number],[Purpose],[Day]) Values(?,?,?)"
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
                                        cmd4.CommandText = "Delete From Cashier where Number= @Number"
                                        cmd4.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                        con.Open()
                                        cmd1.ExecuteNonQuery()
                                        cmd2.ExecuteNonQuery()
                                        cmd3.ExecuteNonQuery()
                                        cmd4.ExecuteNonQuery()

                                        onqueuenumberTxt.Text = ""
                                        onqueuepurposeTxt.Text = ""
                                        onqueuestatusTxt.Clear()


                                        MsgBox("Successfully finish.", vbInformation, "Queuing System")
                                        onnumberTxt.Text = ""
                                        onpurposeTxt.Text = ""
                                        onstatusTxt.Text = ""

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
                'MsgBox("ayos", vbInformation, "")
            End If


        ElseIf registrarnumberPL.Text = Nothing And onqueuenumberTxt.Text = Nothing Then
            MsgBox("Please select priority number. ", vbInformation, "")

            ''PRIORITY
        ElseIf registrarnumberPL.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to finish this priority client?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    onholdTransfer.Clear()
                    Dim str1 As String
                    str1 = "insert into CashierDone([Number],[Purpose],[Status]) Values(?,?,?)"
                    Dim str2 As String
                    str2 = "insert into CashierHistory([Number],[Purpose],[Day]) Values(?,?,?)"
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
                                        cmd4.CommandText = "Delete From CashierPriorityLane where Number= @Number"
                                        cmd4.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))


                                        con.Open()
                                        cmd1.ExecuteNonQuery()
                                        cmd2.ExecuteNonQuery()
                                        cmd3.ExecuteNonQuery()
                                        cmd4.ExecuteNonQuery()

                                        onqueuenumberTxt.Text = ""
                                        onqueuepurposeTxt.Text = ""
                                        onqueuestatusTxt.Clear()


                                        MsgBox("Successfully finish.", vbInformation, "Queuing System")

                                        registrarnumberPL.Text = ""
                                        registrarpurposePL.Text = ""
                                        registrarstatusPL.Text = ""

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
            If MsgBox("Are you sure you want to finish this client?", vbYesNo Or vbQuestion, "") = MsgBoxResult.Yes Then
                Try
                    onholdTransfer.Clear()
                    Dim str1 As String
                    str1 = "insert into CashierDone([Number],[Purpose],[Status]) Values(?,?,?)"
                    Dim str2 As String
                    str2 = "insert into CashierHistory([Number],[Purpose],[Day]) Values(?,?,?)"
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
                                            cmd4.CommandText = "Delete From CashierOnhold where Number= @Number"
                                            cmd4.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                            cmd5.Connection = con
                                            cmd5.CommandText = "Delete From CashierOnholdHistory where Number= @Number"
                                            cmd5.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                            con.Open()
                                            cmd1.ExecuteNonQuery()
                                            cmd2.ExecuteNonQuery()
                                            cmd3.ExecuteNonQuery()
                                            cmd4.ExecuteNonQuery()
                                            cmd5.ExecuteNonQuery()

                                            MsgBox("Successfully finish.", vbInformation, "Queuing System")

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

                Catch
                Finally
                End Try

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
        Dim sql As String = "SELECT * FROM CashierOnhold"
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
                onholdTransfer.Text = Number
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

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        CashierHistory.Show()
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
        CashierDone.ShowDialog()

    End Sub

    Private Sub AddPurposeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddPurposeToolStripMenuItem.Click
        CashieraddPurpose.ShowDialog()
    End Sub

    Private Sub tadminBtn_Click(sender As Object, e As EventArgs) Handles tadminBtn.Click

        'Dim confirm = MsgBox("Are you sure you want to transfer this number?", vbYesNo Or vbQuestion, "")
        If onqueuenumberTxt.Text = Nothing Then
            MsgBox("Please process number to transfer", vbCritical, "Queuing System")
        ElseIf onnumberTxt.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to transfer this number?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Try
                    Dim str As String
                    str = "insert into Admin([Number],[Purpose],[Status]) Values(?,?,?)"

                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd As OleDbCommand = New OleDbCommand(str, con)
                            Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                                cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From Cashier where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()



                                MsgBox("Successfully transferred to Admission", vbInformation, "Queuing System")
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
            'Admission.Show() PRIORITYYLANE
        ElseIf registrarnumberPL.Text = onqueuenumberTxt.Text = True Then

            If MsgBox("Are you sure you want to transfer this priority number?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Dim str As String
                str = "insert into AdminPriorityLane([Number],[Purpose],[Status]) Values(?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(conString)
                    Using cmd As OleDbCommand = New OleDbCommand(str, con)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                            cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Status", CType(onqueuestatusTxt.Text, String)))

                            cmd1.Connection = con
                            cmd1.CommandText = "Delete From CashierPriorityLane where Number= @Number"
                            cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd1.ExecuteNonQuery()
                            MsgBox("Successfully transferred to Admission", vbInformation, "Queuing System")

                            onqueuenumberTxt.Text = String.Empty
                            onqueuepurposeTxt.Text = String.Empty
                            onqueuestatusTxt.Text = String.Empty

                        End Using
                    End Using
                End Using

            ElseIf vbNo Then

            End If

            'Onhold
        ElseIf InStr(1, onholdTransfer.Text, "P", vbTextCompare) = False Then

            If MsgBox("Are you sure you want to transfer this number?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Dim str As String
                str = "insert into Admin([Number],[Purpose],[Status]) Values(?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(conString)
                    Using cmd As OleDbCommand = New OleDbCommand(str, con)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                            cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Status", CType("PENDING", String)))

                            cmd1.Connection = con
                            cmd1.CommandText = "Delete From CashierOnhold where Number= @Number"
                            cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd1.ExecuteNonQuery()

                            MsgBox("Successfully transferred to Admission", vbInformation, "Queuing System")

                            onqueuenumberTxt.Text = String.Empty
                            onqueuepurposeTxt.Text = String.Empty
                            onqueuestatusTxt.Text = String.Empty
                            onholdTransfer.Clear()
                            Retrieve2()
                        End Using
                    End Using
                End Using

            ElseIf vbNo Then
            End If
            'Onhold
        ElseIf InStr(1, onholdTransfer.Text, "P", vbTextCompare) Then

            If MsgBox("Are you sure you want to transfer this number?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then
                Dim str As String
                str = "insert into AdminPriorityLane([Number],[Purpose],[Status]) Values(?,?,?)"

                Using con As OleDbConnection = New OleDbConnection(conString)
                    Using cmd As OleDbCommand = New OleDbCommand(str, con)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str, con)

                            cmd.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                            cmd.Parameters.Add(New OleDbParameter("Status", CType("PENDING", String)))

                            cmd1.Connection = con
                            cmd1.CommandText = "Delete From CashierOnhold where Number= @Number"
                            cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                            con.Open()
                            cmd.ExecuteNonQuery()
                            cmd1.ExecuteNonQuery()

                            MsgBox("Successfully transferred to Admission", vbInformation, "Queuing System")


                            onqueuenumberTxt.Text = String.Empty
                            onqueuepurposeTxt.Text = String.Empty
                            onqueuestatusTxt.Text = String.Empty
                            onholdTransfer.Clear()
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
            MsgBox("Please process number to transfer", vbCritical, "Queuing System")

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
                                cmd1.CommandText = "Delete From Cashier where Number= @Number"
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
                                cmd1.CommandText = "Delete From CashierPriorityLane where Number= @Number"
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

            'Onhold
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
                                cmd.Parameters.Add(New OleDbParameter("Status", CType("PENDING", String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From CashierOnhold where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))
                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to Student Government", vbInformation, "Queuing System")
                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty
                                Retrieve2()
                            End Using
                        End Using
                    End Using
                Catch
                Finally
                End Try

            ElseIf vbNo Then
            End If
            'OnholdPriorityTransfer
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
                                cmd.Parameters.Add(New OleDbParameter("Status", CType("PENDING", String)))

                                cmd1.Connection = con
                                cmd1.CommandText = "Delete From CashierOnhold where Number= @Number"
                                cmd1.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))
                                con.Open()
                                cmd.ExecuteNonQuery()
                                cmd1.ExecuteNonQuery()

                                MsgBox("Successfully transferred to Student Government", vbInformation, "Queuing System")

                                onqueuenumberTxt.Text = String.Empty
                                onqueuepurposeTxt.Text = String.Empty
                                onqueuestatusTxt.Text = String.Empty
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
                    Using cmd1 = New OleDbCommand("SELECT COUNT(*)AS Row_Count FROM Cashier ", con)
                        Dim Count As Integer = Convert.ToInt32(cmd1.ExecuteScalar())
                        totalonqueue.Text = Count.ToString

                        Using cmd2 = New OleDbCommand("SELECT COUNT(*)AS Row_Count FROM CashierPriorityLane ", con)
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
            CashierPopup.Close()
            Me.Hide()
        End If
    End Sub

    Private Sub Button2_Click_3(sender As Object, e As EventArgs)
        RegistrarPlace_Load(Me, New System.EventArgs)
    End Sub

    Private Sub Holdbtn_Click_1(sender As Object, e As EventArgs) Handles Holdbtn.Click

        If onqueuenumberTxt.Text = Nothing Then
            MsgBox("Process number to hold.", vbInformation, "Queuing System")
            'ONQUEUE
        ElseIf onnumberTxt.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to hold this client?", vbYesNo Or vbQuestion) = MsgBoxResult.Yes Then
                Try
                    Dim str1 As String
                    str1 = "insert into CashierOnholdHistory([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                            cmd1.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Status", CType(DateTimePicker1.Text, String)))

                            Dim str2 As String
                            str2 = "insert into CashierOnhold([Number],[Purpose],[Status]) Values(?,?,?)"
                            Using cmd2 As OleDbCommand = New OleDbCommand(str2, con)
                                cmd2.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd2.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd2.Parameters.Add(New OleDbParameter("Status", CType("HOLD", String)))

                                Using cmd3 As OleDbCommand = New OleDbCommand(str2, con)
                                    cmd3.Connection = con
                                    cmd3.CommandText = "Delete From Cashier where Number= @Number"
                                    cmd3.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                    con.Open()
                                    cmd1.ExecuteNonQuery()
                                    cmd2.ExecuteNonQuery()
                                    cmd3.ExecuteNonQuery()

                                    MsgBox("Hold Successfully.", vbInformation, "Queuing System")
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
            'REGISTRARONHOLDHISTORY
        ElseIf onqueuenumberTxt.Text = onqueuenumberTxt.Text = True Then
            If MsgBox("Are you sure you want to hold this client?", vbYesNo Or vbQuestion) = MsgBoxResult.Yes Then
                Try
                    Dim str1 As String
                    str1 = "insert into CashierOnholdHistory([Number],[Purpose],[Status]) Values(?,?,?)"
                    Using con As OleDbConnection = New OleDbConnection(conString)
                        Using cmd1 As OleDbCommand = New OleDbCommand(str1, con)
                            cmd1.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                            cmd1.Parameters.Add(New OleDbParameter("Status", CType(DateTimePicker1.Text, String)))

                            Dim str2 As String
                            str2 = "insert into CashierOnhold([Number],[Purpose],[Status]) Values(?,?,?)"
                            Using cmd2 As OleDbCommand = New OleDbCommand(str2, con)
                                cmd2.Parameters.Add(New OleDbParameter("Number", CType(onqueuenumberTxt.Text, String)))
                                cmd2.Parameters.Add(New OleDbParameter("Purpose", CType(onqueuepurposeTxt.Text, String)))
                                cmd2.Parameters.Add(New OleDbParameter("Status", CType("HOLD", String)))

                                Using cmd3 As OleDbCommand = New OleDbCommand(str2, con)
                                    cmd3.Connection = con
                                    cmd3.CommandText = "Delete From CashierPriorityLane where Number= @Number"
                                    cmd3.Parameters.Add(New OleDbParameter("@Number", onqueuenumberTxt.Text))

                                    con.Open()
                                    cmd1.ExecuteNonQuery()
                                    cmd2.ExecuteNonQuery()
                                    cmd3.ExecuteNonQuery()

                                    MsgBox("Hold Successfully.", vbInformation, "Queuing System")
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
                    Dim str1 As String = "select * from Cashier"

                    adapter.SelectCommand = New OleDbCommand(str1, con)
                    adapter.Fill(ds1)
                    Me.RegistrarDataGridView.DataSource = ds1.Tables(0)
                    Me.RegistrarDataGridView.Columns.Remove("ID")
                    Me.RegistrarDataGridView.Columns(0).Width = 80
                    Me.RegistrarDataGridView.Columns(1).Width = 230
                    Using ds2 As New DataSet
                        Dim str2 As String = "select * from CashierPriorityLane"

                        adapter.SelectCommand = New OleDbCommand(str2, con)
                        adapter.Fill(ds2)

                        'con.Close()
                        Me.RegistrarPriorityLaneDataGridView.DataSource = ds2.Tables(0)
                        Me.RegistrarPriorityLaneDataGridView.Columns.Remove("ID")
                        Me.RegistrarPriorityLaneDataGridView.Columns(0).Width = 80
                        Me.RegistrarPriorityLaneDataGridView.Columns(1).Width = 230
                        'RegistrarPlace_Load(Me, New System.EventArgs)
                    End Using
                End Using
            End Using

        Catch
            'MsgBox("")
        Finally
        End Try
    End Sub
    Private Sub HistoryToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HistoryToolStripMenuItem1.Click
        CashierHistory.ShowDialog()
    End Sub
    Private Sub Button8_Click_1(sender As Object, e As EventArgs)
        'RegistrarDataGridView.DataSource = Reset
    End Sub
    Private Sub notificationTimer_Tick(sender As Object, e As EventArgs) Handles notificationTimer.Tick


        If totalonqueue.Text <> 0 Then
            CashierPopup.Show()
            CashierPopup.Activate()
            'AdminPopup.Close()
        End If
        If totalPL.Text <> 0 Then
            CashierPopup.Show()
            CashierPopup.Activate()
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
        CashierPopup.Close()
    End Sub
    Private Sub Button10_Click_1(sender As Object, e As EventArgs)
        Try
            con.Open()
            Dim cmd1 As New OleDb.OleDbCommand("SELECT Number FROM Cashier", con)
            Dim cmd2 As New OleDb.OleDbCommand("SELECT Purpose FROM Cashier", con)
            Dim cmd3 As New OleDb.OleDbCommand("SELECT Status FROM Cashier", con)
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
            Dim cmd1 As New OleDb.OleDbCommand("SELECT Number FROM CashierPriorityLane", con)
            Dim cmd2 As New OleDb.OleDbCommand("SELECT Purpose FROM CashierPriorityLane", con)
            Dim cmd3 As New OleDb.OleDbCommand("SELECT Status FROM CashierPriorityLane", con)
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
        '        Dim del As String = "DELETE FROM CashierHasLogin WHERE HasLogin "
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
        '        CashierPopup.Close()
        '        CashierHistory.Close()
        '        'Application.Exit()
        '        Me.Hide()
        '    End Using
        'End If

        Try
            If confirm = vbYes Then
                onqueuenumberTxt.Text = ""
                Using con As OleDbConnection = New OleDbConnection(conString)
                    Using cmd2 As New OleDbCommand("UPDATE CashierMonitor SET Purpose1=pur1", con)
                        Dim del As String = "DELETE FROM CashierHasLogin WHERE HasLogin "

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
                CashierPopup.Close()
                CashierHistory.Close()
                Me.Hide()
            End If
        Catch

        Finally
        End Try
    End Sub

    Private Sub processBtn_Click(sender As Object, e As EventArgs) Handles processBtn.Click

        Try
            Using con As OleDbConnection = New OleDbConnection(conString)
                Using cmd1 As New OleDb.OleDbCommand("SELECT Number FROM Cashier", con)
                    Using cmd2 As New OleDb.OleDbCommand("SELECT Purpose FROM Cashier", con)
                        Using cmd3 As New OleDb.OleDbCommand("SELECT Status FROM Cashier", con)
                            con.Open()
                            Using dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader
                                Using dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader
                                    Using dr3 As OleDb.OleDbDataReader = cmd3.ExecuteReader

                                        If dr1.HasRows = 0 And priorityPLDISABLE.Checked = True Then
                                            MsgBox("There is no client on wait.", vbInformation, "Queuing System")
                                        ElseIf dr1.HasRows And priorityPLDISABLE.Checked = True Then
                                            If MsgBox("Are you sure you want to process onqueue?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then

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
                Using cmd1 As New OleDb.OleDbCommand("SELECT Number FROM CashierPriorityLane", con)
                    Using cmd2 As New OleDb.OleDbCommand("SELECT Purpose FROM CashierPriorityLane", con)
                        Using cmd3 As New OleDb.OleDbCommand("SELECT Status FROM CashierPriorityLane", con)

                            con.Open()
                            Using dr1 As OleDb.OleDbDataReader = cmd1.ExecuteReader
                                Using dr2 As OleDb.OleDbDataReader = cmd2.ExecuteReader
                                    Using dr3 As OleDb.OleDbDataReader = cmd3.ExecuteReader

                                        If dr1.HasRows = 0 And priorityPLABLE.Checked = True Then
                                            MsgBox("There is no priority client on wait.", vbInformation, "Queuing System")
                                        ElseIf dr1.HasRows And priorityPLABLE.Checked = True Then
                                            If MsgBox("Are you sure you want to process prioritylane?", vbYesNo Or vbQuestion, "Queuing System") = MsgBoxResult.Yes Then

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
                Using cmd As New OleDbCommand("UPDATE CashierMonitor SET Purpose1=pur1", con)
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
        tregistrarBtn.Visible = True
    End Sub

    Private Sub DisableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableToolStripMenuItem.Click
        tregistrarBtn.Visible = False
    End Sub

    Private Sub AbleToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AbleToolStripMenuItem1.Click
        tadminBtn.Visible = True
    End Sub

    Private Sub DisableToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DisableToolStripMenuItem1.Click
        tadminBtn.Visible = False
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


    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Queuing Sytem examines every component of waiting in line to be served, including the arrival process, service process.", vbInformation, "Queuing System")
    End Sub

    Private Sub AccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AccountToolStripMenuItem.Click
        Account.ShowDialog()
    End Sub
End Class