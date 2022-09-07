<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Approved
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Label1 As System.Windows.Forms.Label
        Dim AnswerLabel As System.Windows.Forms.Label
        Dim UsernameLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim UsertypeLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim Contact_NoLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Approved))
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.questionTxt = New System.Windows.Forms.TextBox()
        Me.PendingLogsDataGridView = New System.Windows.Forms.DataGridView()
        Me.answerTxt = New System.Windows.Forms.TextBox()
        Me.contactTxt = New System.Windows.Forms.TextBox()
        Me.usernameTxt = New System.Windows.Forms.TextBox()
        Me.passwordTxt = New System.Windows.Forms.TextBox()
        Me.usertypeTxt = New System.Windows.Forms.TextBox()
        Me.surnameTxt = New System.Windows.Forms.TextBox()
        Me.firstnameTxt = New System.Windows.Forms.TextBox()
        Me.declineBtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.approveBtn = New System.Windows.Forms.Button()
        Me.refreshBtn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Label1 = New System.Windows.Forms.Label()
        AnswerLabel = New System.Windows.Forms.Label()
        UsernameLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        UsertypeLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        Contact_NoLabel = New System.Windows.Forms.Label()
        CType(Me.PendingLogsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.BackColor = System.Drawing.Color.Transparent
        Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Label1.Location = New System.Drawing.Point(776, 100)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(84, 23)
        Label1.TabIndex = 554
        Label1.Text = "Question:"
        '
        'AnswerLabel
        '
        AnswerLabel.AutoSize = True
        AnswerLabel.BackColor = System.Drawing.Color.Transparent
        AnswerLabel.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        AnswerLabel.Location = New System.Drawing.Point(788, 133)
        AnswerLabel.Name = "AnswerLabel"
        AnswerLabel.Size = New System.Drawing.Size(72, 23)
        AnswerLabel.TabIndex = 553
        AnswerLabel.Text = "Answer:"
        '
        'UsernameLabel
        '
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = System.Drawing.Color.Transparent
        UsernameLabel.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsernameLabel.Location = New System.Drawing.Point(772, 36)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New System.Drawing.Size(92, 23)
        UsernameLabel.TabIndex = 541
        UsernameLabel.Text = "Username:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = System.Drawing.Color.Transparent
        PasswordLabel.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        PasswordLabel.Location = New System.Drawing.Point(773, 68)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(90, 23)
        PasswordLabel.TabIndex = 543
        PasswordLabel.Text = "Password:"
        '
        'UsertypeLabel
        '
        UsertypeLabel.AutoSize = True
        UsertypeLabel.BackColor = System.Drawing.Color.Transparent
        UsertypeLabel.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        UsertypeLabel.ForeColor = System.Drawing.Color.White
        UsertypeLabel.Location = New System.Drawing.Point(285, 139)
        UsertypeLabel.Name = "UsertypeLabel"
        UsertypeLabel.Size = New System.Drawing.Size(83, 23)
        UsertypeLabel.TabIndex = 545
        UsertypeLabel.Text = "Usertype:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.BackColor = System.Drawing.Color.Transparent
        SurnameLabel.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SurnameLabel.ForeColor = System.Drawing.Color.White
        SurnameLabel.Location = New System.Drawing.Point(293, 36)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(83, 23)
        SurnameLabel.TabIndex = 547
        SurnameLabel.Text = "Surname:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.BackColor = System.Drawing.Color.Transparent
        FirstnameLabel.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FirstnameLabel.ForeColor = System.Drawing.Color.White
        FirstnameLabel.Location = New System.Drawing.Point(285, 70)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(91, 23)
        FirstnameLabel.TabIndex = 549
        FirstnameLabel.Text = "Firstname:"
        '
        'Contact_NoLabel
        '
        Contact_NoLabel.AutoSize = True
        Contact_NoLabel.BackColor = System.Drawing.Color.Transparent
        Contact_NoLabel.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Contact_NoLabel.ForeColor = System.Drawing.Color.White
        Contact_NoLabel.Location = New System.Drawing.Point(277, 104)
        Contact_NoLabel.Name = "Contact_NoLabel"
        Contact_NoLabel.Size = New System.Drawing.Size(99, 23)
        Contact_NoLabel.TabIndex = 551
        Contact_NoLabel.Text = "Contact No:"
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(126, 583)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(75, 23)
        Me.previousBtn.TabIndex = 508
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'questionTxt
        '
        Me.questionTxt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.questionTxt.Location = New System.Drawing.Point(903, 100)
        Me.questionTxt.Name = "questionTxt"
        Me.questionTxt.Size = New System.Drawing.Size(189, 29)
        Me.questionTxt.TabIndex = 557
        '
        'PendingLogsDataGridView
        '
        Me.PendingLogsDataGridView.AllowUserToDeleteRows = False
        Me.PendingLogsDataGridView.AllowUserToResizeColumns = False
        Me.PendingLogsDataGridView.AllowUserToResizeRows = False
        Me.PendingLogsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PendingLogsDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.PendingLogsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.PendingLogsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.PendingLogsDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.PendingLogsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PendingLogsDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.PendingLogsDataGridView.ColumnHeadersHeight = 30
        Me.PendingLogsDataGridView.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.PendingLogsDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.PendingLogsDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.PendingLogsDataGridView.Location = New System.Drawing.Point(12, 170)
        Me.PendingLogsDataGridView.MultiSelect = False
        Me.PendingLogsDataGridView.Name = "PendingLogsDataGridView"
        Me.PendingLogsDataGridView.ReadOnly = True
        Me.PendingLogsDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PendingLogsDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.PendingLogsDataGridView.RowHeadersVisible = False
        Me.PendingLogsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.PendingLogsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.PendingLogsDataGridView.Size = New System.Drawing.Size(914, 187)
        Me.PendingLogsDataGridView.TabIndex = 556
        '
        'answerTxt
        '
        Me.answerTxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.answerTxt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.answerTxt.Location = New System.Drawing.Point(903, 133)
        Me.answerTxt.Name = "answerTxt"
        Me.answerTxt.ReadOnly = True
        Me.answerTxt.Size = New System.Drawing.Size(188, 29)
        Me.answerTxt.TabIndex = 555
        '
        'contactTxt
        '
        Me.contactTxt.BackColor = System.Drawing.Color.White
        Me.contactTxt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.contactTxt.Location = New System.Drawing.Point(396, 100)
        Me.contactTxt.Name = "contactTxt"
        Me.contactTxt.ReadOnly = True
        Me.contactTxt.Size = New System.Drawing.Size(189, 29)
        Me.contactTxt.TabIndex = 552
        '
        'usernameTxt
        '
        Me.usernameTxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.usernameTxt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usernameTxt.Location = New System.Drawing.Point(902, 30)
        Me.usernameTxt.Name = "usernameTxt"
        Me.usernameTxt.ReadOnly = True
        Me.usernameTxt.Size = New System.Drawing.Size(189, 29)
        Me.usernameTxt.TabIndex = 542
        '
        'passwordTxt
        '
        Me.passwordTxt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.passwordTxt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.passwordTxt.Location = New System.Drawing.Point(902, 65)
        Me.passwordTxt.Name = "passwordTxt"
        Me.passwordTxt.ReadOnly = True
        Me.passwordTxt.Size = New System.Drawing.Size(189, 29)
        Me.passwordTxt.TabIndex = 544
        '
        'usertypeTxt
        '
        Me.usertypeTxt.BackColor = System.Drawing.Color.White
        Me.usertypeTxt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.usertypeTxt.Location = New System.Drawing.Point(396, 135)
        Me.usertypeTxt.Name = "usertypeTxt"
        Me.usertypeTxt.ReadOnly = True
        Me.usertypeTxt.Size = New System.Drawing.Size(189, 29)
        Me.usertypeTxt.TabIndex = 546
        '
        'surnameTxt
        '
        Me.surnameTxt.BackColor = System.Drawing.Color.White
        Me.surnameTxt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.surnameTxt.Location = New System.Drawing.Point(396, 30)
        Me.surnameTxt.Name = "surnameTxt"
        Me.surnameTxt.ReadOnly = True
        Me.surnameTxt.Size = New System.Drawing.Size(189, 29)
        Me.surnameTxt.TabIndex = 548
        '
        'firstnameTxt
        '
        Me.firstnameTxt.BackColor = System.Drawing.Color.White
        Me.firstnameTxt.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold)
        Me.firstnameTxt.Location = New System.Drawing.Point(396, 65)
        Me.firstnameTxt.Name = "firstnameTxt"
        Me.firstnameTxt.ReadOnly = True
        Me.firstnameTxt.Size = New System.Drawing.Size(189, 29)
        Me.firstnameTxt.TabIndex = 550
        '
        'declineBtn
        '
        Me.declineBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.declineBtn.BackgroundImage = CType(resources.GetObject("declineBtn.BackgroundImage"), System.Drawing.Image)
        Me.declineBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.declineBtn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.declineBtn.ForeColor = System.Drawing.Color.White
        Me.declineBtn.Location = New System.Drawing.Point(506, 363)
        Me.declineBtn.Name = "declineBtn"
        Me.declineBtn.Size = New System.Drawing.Size(128, 55)
        Me.declineBtn.TabIndex = 561
        Me.declineBtn.Text = "Decline"
        Me.declineBtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.Thesisv6._0Registrar.My.Resources.Resources.Refresh
        Me.PictureBox2.Location = New System.Drawing.Point(898, 141)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(28, 27)
        Me.PictureBox2.TabIndex = 560
        Me.PictureBox2.TabStop = False
        '
        'approveBtn
        '
        Me.approveBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.approveBtn.BackgroundImage = CType(resources.GetObject("approveBtn.BackgroundImage"), System.Drawing.Image)
        Me.approveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.approveBtn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.approveBtn.ForeColor = System.Drawing.Color.White
        Me.approveBtn.Location = New System.Drawing.Point(363, 363)
        Me.approveBtn.Name = "approveBtn"
        Me.approveBtn.Size = New System.Drawing.Size(128, 55)
        Me.approveBtn.TabIndex = 558
        Me.approveBtn.Text = "Approve"
        Me.approveBtn.UseVisualStyleBackColor = False
        '
        'refreshBtn
        '
        Me.refreshBtn.BackColor = System.Drawing.Color.Transparent
        Me.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshBtn.Image = Global.Thesisv6._0Registrar.My.Resources.Resources.Refresh
        Me.refreshBtn.Location = New System.Drawing.Point(948, 178)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(28, 27)
        Me.refreshBtn.TabIndex = 520
        Me.refreshBtn.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(978, 113)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 298)
        Me.PictureBox1.TabIndex = 516
        Me.PictureBox1.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Image = Global.Thesisv6._0Registrar.My.Resources.Resources.close
        Me.closeBtn.Location = New System.Drawing.Point(913, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(27, 24)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closeBtn.TabIndex = 562
        Me.closeBtn.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(792, 170)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(117, 187)
        Me.PictureBox3.TabIndex = 563
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Location = New System.Drawing.Point(743, 30)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(415, 134)
        Me.PictureBox4.TabIndex = 564
        Me.PictureBox4.TabStop = False
        '
        'Approved
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.backgroundcreate
        Me.ClientSize = New System.Drawing.Size(938, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.declineBtn)
        Me.Controls.Add(Me.approveBtn)
        Me.Controls.Add(Me.questionTxt)
        Me.Controls.Add(Me.PendingLogsDataGridView)
        Me.Controls.Add(Label1)
        Me.Controls.Add(AnswerLabel)
        Me.Controls.Add(Me.answerTxt)
        Me.Controls.Add(Me.contactTxt)
        Me.Controls.Add(UsernameLabel)
        Me.Controls.Add(Me.usernameTxt)
        Me.Controls.Add(PasswordLabel)
        Me.Controls.Add(Me.passwordTxt)
        Me.Controls.Add(UsertypeLabel)
        Me.Controls.Add(Me.usertypeTxt)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.surnameTxt)
        Me.Controls.Add(FirstnameLabel)
        Me.Controls.Add(Me.firstnameTxt)
        Me.Controls.Add(Contact_NoLabel)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.previousBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Approved"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PendingLogsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents previousBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents refreshBtn As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents approveBtn As System.Windows.Forms.Button
    Friend WithEvents questionTxt As System.Windows.Forms.TextBox
    Friend WithEvents PendingLogsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents answerTxt As System.Windows.Forms.TextBox
    Friend WithEvents contactTxt As System.Windows.Forms.TextBox
    Friend WithEvents usernameTxt As System.Windows.Forms.TextBox
    Friend WithEvents passwordTxt As System.Windows.Forms.TextBox
    Friend WithEvents usertypeTxt As System.Windows.Forms.TextBox
    Friend WithEvents surnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents firstnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents declineBtn As System.Windows.Forms.Button
    Friend WithEvents closeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
End Class
