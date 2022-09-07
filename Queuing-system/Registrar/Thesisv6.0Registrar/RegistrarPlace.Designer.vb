<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrarPlace
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
        Me.components = New System.ComponentModel.Container()
        Dim PurposeLabel1 As System.Windows.Forms.Label
        Dim StatusLabel1 As System.Windows.Forms.Label
        Dim NumberLabel1 As System.Windows.Forms.Label
        Dim NumberLabel2 As System.Windows.Forms.Label
        Dim PurposeLabel2 As System.Windows.Forms.Label
        Dim StatusLabel2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrarPlace))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.updateRegandPLTimer = New System.Windows.Forms.Timer(Me.components)
        Me.totalOnqueueTimer = New System.Windows.Forms.Timer(Me.components)
        Me.notificationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FinishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddPurposeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HistoryToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CashierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdmissionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StudentGovernmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbleToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.disableNotif = New System.Windows.Forms.RadioButton()
        Me.ableNotif = New System.Windows.Forms.RadioButton()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.total = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Holdbtn = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.tcashierBtn = New System.Windows.Forms.Button()
        Me.tadminBtn = New System.Windows.Forms.Button()
        Me.tsgBtn = New System.Windows.Forms.Button()
        Me.onholdTransfer = New System.Windows.Forms.TextBox()
        Me.nowservinglabelTxt = New System.Windows.Forms.Label()
        Me.prioritylabel = New System.Windows.Forms.Label()
        Me.onqueuepurposeTxt = New System.Windows.Forms.Label()
        Me.onqueuenumberTxt = New System.Windows.Forms.Label()
        Me.doneregBtn = New System.Windows.Forms.Button()
        Me.totalPL = New System.Windows.Forms.Label()
        Me.totalonqueue = New System.Windows.Forms.Label()
        Me.REGISTRARLABEL = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.fordoneTxt = New System.Windows.Forms.TextBox()
        Me.onqueuestatusTxt = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.onnumberTxt = New System.Windows.Forms.TextBox()
        Me.onpurposeTxt = New System.Windows.Forms.TextBox()
        Me.onstatusTxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.registrarpurposePL = New System.Windows.Forms.TextBox()
        Me.registrarnumberPL = New System.Windows.Forms.TextBox()
        Me.registrarstatusPL = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.priorityPLDISABLE = New System.Windows.Forms.RadioButton()
        Me.priorityPLABLE = New System.Windows.Forms.RadioButton()
        Me.newMonitorTimer = New System.Windows.Forms.Timer(Me.components)
        Me.nxtBtn = New System.Windows.Forms.Button()
        Me.previousBtn = New System.Windows.Forms.Button()
        Me.lastBtn = New System.Windows.Forms.Button()
        Me.firstBtn = New System.Windows.Forms.Button()
        Me.OnholdTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.RegistrarPriorityLaneDataGridView = New System.Windows.Forms.DataGridView()
        Me.RegistrarDataGridView = New System.Windows.Forms.DataGridView()
        Me.refreshBtn = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        PurposeLabel1 = New System.Windows.Forms.Label()
        StatusLabel1 = New System.Windows.Forms.Label()
        NumberLabel1 = New System.Windows.Forms.Label()
        NumberLabel2 = New System.Windows.Forms.Label()
        PurposeLabel2 = New System.Windows.Forms.Label()
        StatusLabel2 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrarPriorityLaneDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RegistrarDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.refreshBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PurposeLabel1
        '
        PurposeLabel1.AutoSize = True
        PurposeLabel1.Location = New System.Drawing.Point(8, 73)
        PurposeLabel1.Name = "PurposeLabel1"
        PurposeLabel1.Size = New System.Drawing.Size(49, 13)
        PurposeLabel1.TabIndex = 145
        PurposeLabel1.Text = "Purpose:"
        '
        'StatusLabel1
        '
        StatusLabel1.AutoSize = True
        StatusLabel1.Location = New System.Drawing.Point(8, 96)
        StatusLabel1.Name = "StatusLabel1"
        StatusLabel1.Size = New System.Drawing.Size(40, 13)
        StatusLabel1.TabIndex = 147
        StatusLabel1.Text = "Status:"
        '
        'NumberLabel1
        '
        NumberLabel1.AutoSize = True
        NumberLabel1.Location = New System.Drawing.Point(8, 47)
        NumberLabel1.Name = "NumberLabel1"
        NumberLabel1.Size = New System.Drawing.Size(47, 13)
        NumberLabel1.TabIndex = 143
        NumberLabel1.Text = "Number:"
        '
        'NumberLabel2
        '
        NumberLabel2.AutoSize = True
        NumberLabel2.Location = New System.Drawing.Point(12, 35)
        NumberLabel2.Name = "NumberLabel2"
        NumberLabel2.Size = New System.Drawing.Size(47, 13)
        NumberLabel2.TabIndex = 151
        NumberLabel2.Text = "Number:"
        '
        'PurposeLabel2
        '
        PurposeLabel2.AutoSize = True
        PurposeLabel2.Location = New System.Drawing.Point(12, 61)
        PurposeLabel2.Name = "PurposeLabel2"
        PurposeLabel2.Size = New System.Drawing.Size(49, 13)
        PurposeLabel2.TabIndex = 153
        PurposeLabel2.Text = "Purpose:"
        '
        'StatusLabel2
        '
        StatusLabel2.AutoSize = True
        StatusLabel2.Location = New System.Drawing.Point(12, 87)
        StatusLabel2.Name = "StatusLabel2"
        StatusLabel2.Size = New System.Drawing.Size(40, 13)
        StatusLabel2.TabIndex = 155
        StatusLabel2.Text = "Status:"
        '
        'updateRegandPLTimer
        '
        Me.updateRegandPLTimer.Interval = 1000
        '
        'totalOnqueueTimer
        '
        Me.totalOnqueueTimer.Interval = 1000
        '
        'notificationTimer
        '
        Me.notificationTimer.Interval = 1000
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1035, 28)
        Me.MenuStrip1.TabIndex = 171
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FinishToolStripMenuItem, Me.AccountToolStripMenuItem, Me.AddPurposeToolStripMenuItem, Me.HistoryToolStripMenuItem1, Me.CashierToolStripMenuItem, Me.AdmissionToolStripMenuItem, Me.StudentGovernmentToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'FinishToolStripMenuItem
        '
        Me.FinishToolStripMenuItem.Name = "FinishToolStripMenuItem"
        Me.FinishToolStripMenuItem.Size = New System.Drawing.Size(286, 24)
        Me.FinishToolStripMenuItem.Text = "Finish "
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(286, 24)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'AddPurposeToolStripMenuItem
        '
        Me.AddPurposeToolStripMenuItem.Name = "AddPurposeToolStripMenuItem"
        Me.AddPurposeToolStripMenuItem.Size = New System.Drawing.Size(286, 24)
        Me.AddPurposeToolStripMenuItem.Text = "Add purpose"
        '
        'HistoryToolStripMenuItem1
        '
        Me.HistoryToolStripMenuItem1.Name = "HistoryToolStripMenuItem1"
        Me.HistoryToolStripMenuItem1.Size = New System.Drawing.Size(286, 24)
        Me.HistoryToolStripMenuItem1.Text = "History"
        '
        'CashierToolStripMenuItem
        '
        Me.CashierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbleToolStripMenuItem, Me.DisableToolStripMenuItem})
        Me.CashierToolStripMenuItem.Name = "CashierToolStripMenuItem"
        Me.CashierToolStripMenuItem.Size = New System.Drawing.Size(286, 24)
        Me.CashierToolStripMenuItem.Text = "Tranfer >>Cashier"
        '
        'AbleToolStripMenuItem
        '
        Me.AbleToolStripMenuItem.Name = "AbleToolStripMenuItem"
        Me.AbleToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.AbleToolStripMenuItem.Text = "Able"
        '
        'DisableToolStripMenuItem
        '
        Me.DisableToolStripMenuItem.Name = "DisableToolStripMenuItem"
        Me.DisableToolStripMenuItem.Size = New System.Drawing.Size(128, 24)
        Me.DisableToolStripMenuItem.Text = "Disable"
        '
        'AdmissionToolStripMenuItem
        '
        Me.AdmissionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbleToolStripMenuItem1, Me.DisableToolStripMenuItem1})
        Me.AdmissionToolStripMenuItem.Name = "AdmissionToolStripMenuItem"
        Me.AdmissionToolStripMenuItem.Size = New System.Drawing.Size(286, 24)
        Me.AdmissionToolStripMenuItem.Text = "Transfer>>Admission"
        '
        'AbleToolStripMenuItem1
        '
        Me.AbleToolStripMenuItem1.Name = "AbleToolStripMenuItem1"
        Me.AbleToolStripMenuItem1.Size = New System.Drawing.Size(128, 24)
        Me.AbleToolStripMenuItem1.Text = "Able"
        '
        'DisableToolStripMenuItem1
        '
        Me.DisableToolStripMenuItem1.Name = "DisableToolStripMenuItem1"
        Me.DisableToolStripMenuItem1.Size = New System.Drawing.Size(128, 24)
        Me.DisableToolStripMenuItem1.Text = "Disable"
        '
        'StudentGovernmentToolStripMenuItem
        '
        Me.StudentGovernmentToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbleToolStripMenuItem2, Me.DisableToolStripMenuItem2})
        Me.StudentGovernmentToolStripMenuItem.Name = "StudentGovernmentToolStripMenuItem"
        Me.StudentGovernmentToolStripMenuItem.Size = New System.Drawing.Size(286, 24)
        Me.StudentGovernmentToolStripMenuItem.Text = "Transfer>>Student Government"
        '
        'AbleToolStripMenuItem2
        '
        Me.AbleToolStripMenuItem2.Name = "AbleToolStripMenuItem2"
        Me.AbleToolStripMenuItem2.Size = New System.Drawing.Size(128, 24)
        Me.AbleToolStripMenuItem2.Text = "Able"
        '
        'DisableToolStripMenuItem2
        '
        Me.DisableToolStripMenuItem2.Name = "DisableToolStripMenuItem2"
        Me.DisableToolStripMenuItem2.Size = New System.Drawing.Size(128, 24)
        Me.DisableToolStripMenuItem2.Text = "Disable"
        '
        'GroupBox8
        '
        Me.GroupBox8.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox8.Controls.Add(Me.disableNotif)
        Me.GroupBox8.Controls.Add(Me.ableNotif)
        Me.GroupBox8.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox8.ForeColor = System.Drawing.Color.Black
        Me.GroupBox8.Location = New System.Drawing.Point(830, 191)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(180, 54)
        Me.GroupBox8.TabIndex = 489
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Notification!"
        '
        'disableNotif
        '
        Me.disableNotif.AutoSize = True
        Me.disableNotif.BackColor = System.Drawing.Color.Transparent
        Me.disableNotif.Location = New System.Drawing.Point(79, 21)
        Me.disableNotif.Name = "disableNotif"
        Me.disableNotif.Size = New System.Drawing.Size(65, 20)
        Me.disableNotif.TabIndex = 440
        Me.disableNotif.TabStop = True
        Me.disableNotif.Text = "Disable"
        Me.disableNotif.UseVisualStyleBackColor = False
        '
        'ableNotif
        '
        Me.ableNotif.AutoSize = True
        Me.ableNotif.BackColor = System.Drawing.Color.Transparent
        Me.ableNotif.Location = New System.Drawing.Point(29, 21)
        Me.ableNotif.Name = "ableNotif"
        Me.ableNotif.Size = New System.Drawing.Size(49, 20)
        Me.ableNotif.TabIndex = 441
        Me.ableNotif.TabStop = True
        Me.ableNotif.Text = "Able"
        Me.ableNotif.UseVisualStyleBackColor = False
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.SystemColors.HighlightText
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView2.FullRowSelect = True
        Me.ListView2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView2.Location = New System.Drawing.Point(31, 358)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(404, 125)
        Me.ListView2.TabIndex = 459
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Number"
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Purpose"
        Me.ColumnHeader2.Width = 230
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        Me.ColumnHeader3.Width = 73
        '
        'GroupBox9
        '
        Me.GroupBox9.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox9.Controls.Add(Me.total)
        Me.GroupBox9.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox9.ForeColor = System.Drawing.Color.Black
        Me.GroupBox9.Location = New System.Drawing.Point(830, 108)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(180, 79)
        Me.GroupBox9.TabIndex = 471
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Total Onqueue"
        '
        'total
        '
        Me.total.AutoSize = True
        Me.total.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold)
        Me.total.ForeColor = System.Drawing.Color.Black
        Me.total.Location = New System.Drawing.Point(68, 25)
        Me.total.Name = "total"
        Me.total.Size = New System.Drawing.Size(36, 43)
        Me.total.TabIndex = 92
        Me.total.Text = "0"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button9.BackgroundImage = CType(resources.GetObject("Button9.BackgroundImage"), System.Drawing.Image)
        Me.Button9.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button9.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(194, 89)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(128, 55)
        Me.Button9.TabIndex = 485
        Me.Button9.Text = "Clear"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Holdbtn
        '
        Me.Holdbtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Holdbtn.BackgroundImage = CType(resources.GetObject("Holdbtn.BackgroundImage"), System.Drawing.Image)
        Me.Holdbtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Holdbtn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Holdbtn.ForeColor = System.Drawing.Color.White
        Me.Holdbtn.Location = New System.Drawing.Point(19, 89)
        Me.Holdbtn.Name = "Holdbtn"
        Me.Holdbtn.Size = New System.Drawing.Size(128, 55)
        Me.Holdbtn.TabIndex = 483
        Me.Holdbtn.Text = "Hold"
        Me.Holdbtn.UseVisualStyleBackColor = False
        '
        'GroupBox10
        '
        Me.GroupBox10.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox10.Controls.Add(Me.tcashierBtn)
        Me.GroupBox10.Controls.Add(Me.tadminBtn)
        Me.GroupBox10.Controls.Add(Me.tsgBtn)
        Me.GroupBox10.Location = New System.Drawing.Point(439, 442)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(420, 84)
        Me.GroupBox10.TabIndex = 473
        Me.GroupBox10.TabStop = False
        '
        'tcashierBtn
        '
        Me.tcashierBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tcashierBtn.BackgroundImage = CType(resources.GetObject("tcashierBtn.BackgroundImage"), System.Drawing.Image)
        Me.tcashierBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tcashierBtn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tcashierBtn.ForeColor = System.Drawing.Color.White
        Me.tcashierBtn.Location = New System.Drawing.Point(10, 19)
        Me.tcashierBtn.Name = "tcashierBtn"
        Me.tcashierBtn.Size = New System.Drawing.Size(128, 55)
        Me.tcashierBtn.TabIndex = 99
        Me.tcashierBtn.Text = "Transfer>>Cashier"
        Me.tcashierBtn.UseVisualStyleBackColor = False
        '
        'tadminBtn
        '
        Me.tadminBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tadminBtn.BackgroundImage = CType(resources.GetObject("tadminBtn.BackgroundImage"), System.Drawing.Image)
        Me.tadminBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tadminBtn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tadminBtn.ForeColor = System.Drawing.Color.White
        Me.tadminBtn.Location = New System.Drawing.Point(145, 19)
        Me.tadminBtn.Name = "tadminBtn"
        Me.tadminBtn.Size = New System.Drawing.Size(128, 55)
        Me.tadminBtn.TabIndex = 119
        Me.tadminBtn.Text = "Transfer>>Admission"
        Me.tadminBtn.UseVisualStyleBackColor = False
        '
        'tsgBtn
        '
        Me.tsgBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tsgBtn.BackgroundImage = CType(resources.GetObject("tsgBtn.BackgroundImage"), System.Drawing.Image)
        Me.tsgBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tsgBtn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.tsgBtn.ForeColor = System.Drawing.Color.White
        Me.tsgBtn.Location = New System.Drawing.Point(279, 19)
        Me.tsgBtn.Name = "tsgBtn"
        Me.tsgBtn.Size = New System.Drawing.Size(128, 55)
        Me.tsgBtn.TabIndex = 120
        Me.tsgBtn.Text = "Transfer>>Student Government"
        Me.tsgBtn.UseVisualStyleBackColor = False
        '
        'onholdTransfer
        '
        Me.onholdTransfer.Location = New System.Drawing.Point(901, 496)
        Me.onholdTransfer.Name = "onholdTransfer"
        Me.onholdTransfer.Size = New System.Drawing.Size(128, 20)
        Me.onholdTransfer.TabIndex = 521
        '
        'nowservinglabelTxt
        '
        Me.nowservinglabelTxt.AutoSize = True
        Me.nowservinglabelTxt.BackColor = System.Drawing.Color.Transparent
        Me.nowservinglabelTxt.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nowservinglabelTxt.ForeColor = System.Drawing.Color.Black
        Me.nowservinglabelTxt.Location = New System.Drawing.Point(565, 72)
        Me.nowservinglabelTxt.Name = "nowservinglabelTxt"
        Me.nowservinglabelTxt.Size = New System.Drawing.Size(161, 33)
        Me.nowservinglabelTxt.TabIndex = 449
        Me.nowservinglabelTxt.Text = "Now Serving"
        '
        'prioritylabel
        '
        Me.prioritylabel.BackColor = System.Drawing.Color.Transparent
        Me.prioritylabel.Font = New System.Drawing.Font("Arial Narrow", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.prioritylabel.ForeColor = System.Drawing.Color.Black
        Me.prioritylabel.Location = New System.Drawing.Point(552, 105)
        Me.prioritylabel.Name = "prioritylabel"
        Me.prioritylabel.Size = New System.Drawing.Size(205, 42)
        Me.prioritylabel.TabIndex = 445
        Me.prioritylabel.Text = "Priority Number"
        Me.prioritylabel.Visible = False
        '
        'onqueuepurposeTxt
        '
        Me.onqueuepurposeTxt.BackColor = System.Drawing.Color.White
        Me.onqueuepurposeTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.onqueuepurposeTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onqueuepurposeTxt.ForeColor = System.Drawing.Color.Black
        Me.onqueuepurposeTxt.Location = New System.Drawing.Point(501, 244)
        Me.onqueuepurposeTxt.Name = "onqueuepurposeTxt"
        Me.onqueuepurposeTxt.Size = New System.Drawing.Size(303, 39)
        Me.onqueuepurposeTxt.TabIndex = 469
        Me.onqueuepurposeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'onqueuenumberTxt
        '
        Me.onqueuenumberTxt.BackColor = System.Drawing.Color.White
        Me.onqueuenumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.onqueuenumberTxt.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onqueuenumberTxt.ForeColor = System.Drawing.Color.Black
        Me.onqueuenumberTxt.Location = New System.Drawing.Point(501, 149)
        Me.onqueuenumberTxt.Name = "onqueuenumberTxt"
        Me.onqueuenumberTxt.Size = New System.Drawing.Size(303, 83)
        Me.onqueuenumberTxt.TabIndex = 468
        Me.onqueuenumberTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'doneregBtn
        '
        Me.doneregBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.doneregBtn.BackgroundImage = CType(resources.GetObject("doneregBtn.BackgroundImage"), System.Drawing.Image)
        Me.doneregBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.doneregBtn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.doneregBtn.ForeColor = System.Drawing.Color.White
        Me.doneregBtn.Location = New System.Drawing.Point(194, 20)
        Me.doneregBtn.Name = "doneregBtn"
        Me.doneregBtn.Size = New System.Drawing.Size(128, 55)
        Me.doneregBtn.TabIndex = 455
        Me.doneregBtn.Text = "Done"
        Me.doneregBtn.UseVisualStyleBackColor = False
        '
        'totalPL
        '
        Me.totalPL.AutoSize = True
        Me.totalPL.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold)
        Me.totalPL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.totalPL.Location = New System.Drawing.Point(911, 57)
        Me.totalPL.Name = "totalPL"
        Me.totalPL.Size = New System.Drawing.Size(32, 37)
        Me.totalPL.TabIndex = 448
        Me.totalPL.Text = "0"
        '
        'totalonqueue
        '
        Me.totalonqueue.AutoSize = True
        Me.totalonqueue.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold)
        Me.totalonqueue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.totalonqueue.Location = New System.Drawing.Point(860, 57)
        Me.totalonqueue.Name = "totalonqueue"
        Me.totalonqueue.Size = New System.Drawing.Size(32, 37)
        Me.totalonqueue.TabIndex = 447
        Me.totalonqueue.Text = "0"
        '
        'REGISTRARLABEL
        '
        Me.REGISTRARLABEL.AutoSize = True
        Me.REGISTRARLABEL.BackColor = System.Drawing.Color.Transparent
        Me.REGISTRARLABEL.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.REGISTRARLABEL.ForeColor = System.Drawing.Color.Black
        Me.REGISTRARLABEL.Location = New System.Drawing.Point(551, 25)
        Me.REGISTRARLABEL.Name = "REGISTRARLABEL"
        Me.REGISTRARLABEL.Size = New System.Drawing.Size(188, 42)
        Me.REGISTRARLABEL.TabIndex = 446
        Me.REGISTRARLABEL.Text = "REGISTRAR"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(45, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 457
        Me.Label13.Text = "PriorityLane"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.BackColor = System.Drawing.Color.Transparent
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Black
        Me.Label33.Location = New System.Drawing.Point(45, 39)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(58, 13)
        Me.Label33.TabIndex = 458
        Me.Label33.Text = "Onqueue"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(48, 344)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(33, 13)
        Me.Label10.TabIndex = 456
        Me.Label10.Text = "Hold"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(926, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 486
        Me.Label5.Text = "DoneProcess"
        '
        'fordoneTxt
        '
        Me.fordoneTxt.Location = New System.Drawing.Point(910, 371)
        Me.fordoneTxt.Name = "fordoneTxt"
        Me.fordoneTxt.Size = New System.Drawing.Size(100, 20)
        Me.fordoneTxt.TabIndex = 487
        '
        'onqueuestatusTxt
        '
        Me.onqueuestatusTxt.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.onqueuestatusTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onqueuestatusTxt.Location = New System.Drawing.Point(847, 438)
        Me.onqueuestatusTxt.Multiline = True
        Me.onqueuestatusTxt.Name = "onqueuestatusTxt"
        Me.onqueuestatusTxt.Size = New System.Drawing.Size(31, 21)
        Me.onqueuestatusTxt.TabIndex = 454
        Me.onqueuestatusTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Checked = False
        Me.DateTimePicker1.CustomFormat = "dd MMMM yyyy "
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(926, 482)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(63, 20)
        Me.DateTimePicker1.TabIndex = 261
        '
        'onnumberTxt
        '
        Me.onnumberTxt.Location = New System.Drawing.Point(65, 40)
        Me.onnumberTxt.Name = "onnumberTxt"
        Me.onnumberTxt.Size = New System.Drawing.Size(29, 20)
        Me.onnumberTxt.TabIndex = 144
        '
        'onpurposeTxt
        '
        Me.onpurposeTxt.Location = New System.Drawing.Point(65, 66)
        Me.onpurposeTxt.Name = "onpurposeTxt"
        Me.onpurposeTxt.Size = New System.Drawing.Size(29, 20)
        Me.onpurposeTxt.TabIndex = 146
        '
        'onstatusTxt
        '
        Me.onstatusTxt.Location = New System.Drawing.Point(64, 94)
        Me.onstatusTxt.Name = "onstatusTxt"
        Me.onstatusTxt.Size = New System.Drawing.Size(29, 20)
        Me.onstatusTxt.TabIndex = 148
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(24, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "Registrar^"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.onstatusTxt)
        Me.GroupBox3.Controls.Add(StatusLabel1)
        Me.GroupBox3.Controls.Add(Me.onpurposeTxt)
        Me.GroupBox3.Controls.Add(PurposeLabel1)
        Me.GroupBox3.Controls.Add(Me.onnumberTxt)
        Me.GroupBox3.Controls.Add(NumberLabel1)
        Me.GroupBox3.Location = New System.Drawing.Point(841, 399)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(79, 39)
        Me.GroupBox3.TabIndex = 466
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "ProcessingOnqueue"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(19, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 55)
        Me.Button1.TabIndex = 498
        Me.Button1.Text = "Process"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'registrarpurposePL
        '
        Me.registrarpurposePL.Location = New System.Drawing.Point(65, 58)
        Me.registrarpurposePL.Name = "registrarpurposePL"
        Me.registrarpurposePL.Size = New System.Drawing.Size(54, 20)
        Me.registrarpurposePL.TabIndex = 159
        '
        'registrarnumberPL
        '
        Me.registrarnumberPL.Location = New System.Drawing.Point(65, 32)
        Me.registrarnumberPL.Name = "registrarnumberPL"
        Me.registrarnumberPL.Size = New System.Drawing.Size(56, 20)
        Me.registrarnumberPL.TabIndex = 154
        '
        'registrarstatusPL
        '
        Me.registrarstatusPL.Location = New System.Drawing.Point(67, 84)
        Me.registrarstatusPL.Name = "registrarstatusPL"
        Me.registrarstatusPL.Size = New System.Drawing.Size(54, 20)
        Me.registrarstatusPL.TabIndex = 156
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 13)
        Me.Label16.TabIndex = 106
        Me.Label16.Text = "RegistrarPriorityLane^"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.registrarstatusPL)
        Me.GroupBox4.Controls.Add(StatusLabel2)
        Me.GroupBox4.Controls.Add(Me.registrarnumberPL)
        Me.GroupBox4.Controls.Add(PurposeLabel2)
        Me.GroupBox4.Controls.Add(NumberLabel2)
        Me.GroupBox4.Controls.Add(Me.registrarpurposePL)
        Me.GroupBox4.Location = New System.Drawing.Point(841, 356)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(79, 34)
        Me.GroupBox4.TabIndex = 467
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "ProcessingPriority"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.priorityPLDISABLE)
        Me.GroupBox1.Controls.Add(Me.priorityPLABLE)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(831, 251)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(180, 54)
        Me.GroupBox1.TabIndex = 489
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PriorityLane"
        '
        'priorityPLDISABLE
        '
        Me.priorityPLDISABLE.Location = New System.Drawing.Point(77, 22)
        Me.priorityPLDISABLE.Name = "priorityPLDISABLE"
        Me.priorityPLDISABLE.Size = New System.Drawing.Size(90, 17)
        Me.priorityPLDISABLE.TabIndex = 0
        Me.priorityPLDISABLE.TabStop = True
        Me.priorityPLDISABLE.Text = "Disable"
        Me.priorityPLDISABLE.UseVisualStyleBackColor = True
        '
        'priorityPLABLE
        '
        Me.priorityPLABLE.AutoSize = True
        Me.priorityPLABLE.Location = New System.Drawing.Point(27, 21)
        Me.priorityPLABLE.Name = "priorityPLABLE"
        Me.priorityPLABLE.Size = New System.Drawing.Size(49, 20)
        Me.priorityPLABLE.TabIndex = 500
        Me.priorityPLABLE.TabStop = True
        Me.priorityPLABLE.Text = "Able"
        Me.priorityPLABLE.UseVisualStyleBackColor = True
        '
        'newMonitorTimer
        '
        Me.newMonitorTimer.Interval = 1000
        '
        'nxtBtn
        '
        Me.nxtBtn.Location = New System.Drawing.Point(864, 481)
        Me.nxtBtn.Name = "nxtBtn"
        Me.nxtBtn.Size = New System.Drawing.Size(75, 23)
        Me.nxtBtn.TabIndex = 500
        Me.nxtBtn.Text = "Next"
        Me.nxtBtn.UseVisualStyleBackColor = True
        '
        'previousBtn
        '
        Me.previousBtn.Location = New System.Drawing.Point(945, 481)
        Me.previousBtn.Name = "previousBtn"
        Me.previousBtn.Size = New System.Drawing.Size(75, 23)
        Me.previousBtn.TabIndex = 504
        Me.previousBtn.Text = "Previous"
        Me.previousBtn.UseVisualStyleBackColor = True
        '
        'lastBtn
        '
        Me.lastBtn.Location = New System.Drawing.Point(864, 510)
        Me.lastBtn.Name = "lastBtn"
        Me.lastBtn.Size = New System.Drawing.Size(75, 23)
        Me.lastBtn.TabIndex = 505
        Me.lastBtn.Text = "Last"
        Me.lastBtn.UseVisualStyleBackColor = True
        '
        'firstBtn
        '
        Me.firstBtn.Location = New System.Drawing.Point(945, 510)
        Me.firstBtn.Name = "firstBtn"
        Me.firstBtn.Size = New System.Drawing.Size(75, 23)
        Me.firstBtn.TabIndex = 506
        Me.firstBtn.Text = "MoveFirst"
        Me.firstBtn.UseVisualStyleBackColor = True
        '
        'OnholdTxt
        '
        Me.OnholdTxt.Location = New System.Drawing.Point(916, 412)
        Me.OnholdTxt.Name = "OnholdTxt"
        Me.OnholdTxt.Size = New System.Drawing.Size(100, 20)
        Me.OnholdTxt.TabIndex = 508
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(917, 396)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "RegistrarOnhold"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Button9)
        Me.GroupBox2.Controls.Add(Me.Holdbtn)
        Me.GroupBox2.Controls.Add(Me.doneregBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(482, 283)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(342, 160)
        Me.GroupBox2.TabIndex = 509
        Me.GroupBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Location = New System.Drawing.Point(806, 47)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(169, 55)
        Me.PictureBox3.TabIndex = 515
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(841, 347)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(192, 213)
        Me.PictureBox2.TabIndex = 514
        Me.PictureBox2.TabStop = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.closeBtn.Image = Global.Thesisv6._0Registrar.My.Resources.Resources.logout
        Me.closeBtn.Location = New System.Drawing.Point(1006, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(27, 24)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closeBtn.TabIndex = 497
        Me.closeBtn.TabStop = False
        '
        'RegistrarPriorityLaneDataGridView
        '
        Me.RegistrarPriorityLaneDataGridView.AllowUserToAddRows = False
        Me.RegistrarPriorityLaneDataGridView.AllowUserToDeleteRows = False
        Me.RegistrarPriorityLaneDataGridView.AllowUserToResizeRows = False
        Me.RegistrarPriorityLaneDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RegistrarPriorityLaneDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.RegistrarPriorityLaneDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RegistrarPriorityLaneDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.RegistrarPriorityLaneDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.RegistrarPriorityLaneDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RegistrarPriorityLaneDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.RegistrarPriorityLaneDataGridView.ColumnHeadersHeight = 30
        Me.RegistrarPriorityLaneDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RegistrarPriorityLaneDataGridView.DefaultCellStyle = DataGridViewCellStyle2
        Me.RegistrarPriorityLaneDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.RegistrarPriorityLaneDataGridView.Location = New System.Drawing.Point(32, 205)
        Me.RegistrarPriorityLaneDataGridView.Name = "RegistrarPriorityLaneDataGridView"
        Me.RegistrarPriorityLaneDataGridView.ReadOnly = True
        Me.RegistrarPriorityLaneDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RegistrarPriorityLaneDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.RegistrarPriorityLaneDataGridView.RowHeadersVisible = False
        Me.RegistrarPriorityLaneDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RegistrarPriorityLaneDataGridView.Size = New System.Drawing.Size(401, 125)
        Me.RegistrarPriorityLaneDataGridView.TabIndex = 518
        '
        'RegistrarDataGridView
        '
        Me.RegistrarDataGridView.AllowUserToAddRows = False
        Me.RegistrarDataGridView.AllowUserToDeleteRows = False
        Me.RegistrarDataGridView.AllowUserToResizeRows = False
        Me.RegistrarDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.RegistrarDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.RegistrarDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.RegistrarDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.RegistrarDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.RegistrarDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RegistrarDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.RegistrarDataGridView.ColumnHeadersHeight = 30
        Me.RegistrarDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.RegistrarDataGridView.DefaultCellStyle = DataGridViewCellStyle5
        Me.RegistrarDataGridView.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.RegistrarDataGridView.Location = New System.Drawing.Point(33, 55)
        Me.RegistrarDataGridView.MultiSelect = False
        Me.RegistrarDataGridView.Name = "RegistrarDataGridView"
        Me.RegistrarDataGridView.ReadOnly = True
        Me.RegistrarDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.RegistrarDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.RegistrarDataGridView.RowHeadersVisible = False
        Me.RegistrarDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.RegistrarDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.RegistrarDataGridView.Size = New System.Drawing.Size(401, 125)
        Me.RegistrarDataGridView.TabIndex = 517
        '
        'refreshBtn
        '
        Me.refreshBtn.BackColor = System.Drawing.Color.Transparent
        Me.refreshBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.refreshBtn.Image = Global.Thesisv6._0Registrar.My.Resources.Resources.Refresh
        Me.refreshBtn.Location = New System.Drawing.Point(407, 332)
        Me.refreshBtn.Name = "refreshBtn"
        Me.refreshBtn.Size = New System.Drawing.Size(28, 27)
        Me.refreshBtn.TabIndex = 519
        Me.refreshBtn.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(929, 519)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 520
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(948, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 521
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(934, 519)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 533
        Me.Label7.Text = "ACT 2-B"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(918, 501)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 16)
        Me.Label6.TabIndex = 532
        Me.Label6.Text = "Abelido, Kleo T."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(899, 482)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 16)
        Me.Label4.TabIndex = 531
        Me.Label4.Text = "Guatato, Dhan Carlo B."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(887, 466)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(148, 16)
        Me.Label3.TabIndex = 530
        Me.Label3.Text = "Tamunday, John Patrick R."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(915, 447)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 16)
        Me.Label2.TabIndex = 529
        Me.Label2.Text = "Developed by:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 515)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(40, 16)
        Me.LinkLabel1.TabIndex = 534
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "About"
        '
        'RegistrarPlace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.registrarbackground3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1035, 540)
        Me.ControlBox = False
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox10)
        Me.Controls.Add(Me.ListView2)
        Me.Controls.Add(Me.refreshBtn)
        Me.Controls.Add(Me.RegistrarPriorityLaneDataGridView)
        Me.Controls.Add(Me.RegistrarDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.onqueuestatusTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OnholdTxt)
        Me.Controls.Add(Me.firstBtn)
        Me.Controls.Add(Me.lastBtn)
        Me.Controls.Add(Me.previousBtn)
        Me.Controls.Add(Me.nxtBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox9)
        Me.Controls.Add(Me.nowservinglabelTxt)
        Me.Controls.Add(Me.prioritylabel)
        Me.Controls.Add(Me.onqueuepurposeTxt)
        Me.Controls.Add(Me.onqueuenumberTxt)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.totalPL)
        Me.Controls.Add(Me.totalonqueue)
        Me.Controls.Add(Me.REGISTRARLABEL)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.fordoneTxt)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.onholdTransfer)
        Me.Controls.Add(Me.TextBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RegistrarPlace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrarPriorityLaneDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RegistrarDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.refreshBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents updateRegandPLTimer As System.Windows.Forms.Timer
    Friend WithEvents totalOnqueueTimer As System.Windows.Forms.Timer
    Friend WithEvents notificationTimer As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FinishToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddPurposeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HistoryToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents disableNotif As System.Windows.Forms.RadioButton
    Friend WithEvents ableNotif As System.Windows.Forms.RadioButton
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents total As System.Windows.Forms.Label
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Holdbtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents tcashierBtn As System.Windows.Forms.Button
    Friend WithEvents tadminBtn As System.Windows.Forms.Button
    Friend WithEvents tsgBtn As System.Windows.Forms.Button
    Friend WithEvents nowservinglabelTxt As System.Windows.Forms.Label
    Friend WithEvents prioritylabel As System.Windows.Forms.Label
    Friend WithEvents onqueuepurposeTxt As System.Windows.Forms.Label
    Friend WithEvents onqueuenumberTxt As System.Windows.Forms.Label
    Friend WithEvents doneregBtn As System.Windows.Forms.Button
    Friend WithEvents totalPL As System.Windows.Forms.Label
    Friend WithEvents totalonqueue As System.Windows.Forms.Label
    Friend WithEvents REGISTRARLABEL As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents fordoneTxt As System.Windows.Forms.TextBox
    Friend WithEvents onqueuestatusTxt As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents onnumberTxt As System.Windows.Forms.TextBox
    Friend WithEvents onpurposeTxt As System.Windows.Forms.TextBox
    Friend WithEvents onstatusTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents closeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents registrarpurposePL As System.Windows.Forms.TextBox
    Friend WithEvents registrarnumberPL As System.Windows.Forms.TextBox
    Friend WithEvents registrarstatusPL As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents priorityPLDISABLE As System.Windows.Forms.RadioButton
    Friend WithEvents priorityPLABLE As System.Windows.Forms.RadioButton
    Friend WithEvents newMonitorTimer As System.Windows.Forms.Timer
    Friend WithEvents nxtBtn As System.Windows.Forms.Button
    Friend WithEvents previousBtn As System.Windows.Forms.Button
    Friend WithEvents lastBtn As System.Windows.Forms.Button
    Friend WithEvents firstBtn As System.Windows.Forms.Button
    Friend WithEvents OnholdTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CashierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdmissionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentGovernmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbleToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents RegistrarPriorityLaneDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents RegistrarDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents refreshBtn As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents onholdTransfer As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
