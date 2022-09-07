<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GuardPalace
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
        Me.cashierBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.adminBtn = New System.Windows.Forms.Button()
        Me.sgBtn = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.logoutBtn = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.registrarBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.logoutBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cashierBtn
        '
        Me.cashierBtn.BackColor = System.Drawing.Color.White
        Me.cashierBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cashierBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cashierBtn.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold)
        Me.cashierBtn.ForeColor = System.Drawing.Color.Black
        Me.cashierBtn.Location = New System.Drawing.Point(9, 209)
        Me.cashierBtn.Name = "cashierBtn"
        Me.cashierBtn.Size = New System.Drawing.Size(299, 173)
        Me.cashierBtn.TabIndex = 20
        Me.cashierBtn.Text = "CASHIER"
        Me.cashierBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(317, -3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1069, 908)
        Me.Panel1.TabIndex = 24
        '
        'adminBtn
        '
        Me.adminBtn.BackColor = System.Drawing.Color.White
        Me.adminBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.adminBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.adminBtn.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold)
        Me.adminBtn.ForeColor = System.Drawing.Color.Black
        Me.adminBtn.Location = New System.Drawing.Point(9, 574)
        Me.adminBtn.Name = "adminBtn"
        Me.adminBtn.Size = New System.Drawing.Size(299, 173)
        Me.adminBtn.TabIndex = 23
        Me.adminBtn.Text = "ADMISSION"
        Me.adminBtn.UseVisualStyleBackColor = False
        '
        'sgBtn
        '
        Me.sgBtn.BackColor = System.Drawing.Color.White
        Me.sgBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sgBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sgBtn.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold)
        Me.sgBtn.ForeColor = System.Drawing.Color.Black
        Me.sgBtn.Location = New System.Drawing.Point(9, 390)
        Me.sgBtn.Name = "sgBtn"
        Me.sgBtn.Size = New System.Drawing.Size(299, 173)
        Me.sgBtn.TabIndex = 22
        Me.sgBtn.Text = "STUDENT GOVERNMENT"
        Me.sgBtn.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1352, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(269, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "30"
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1352, 28)
        Me.MenuStrip2.TabIndex = 27
        Me.MenuStrip2.Text = "MenuStrip2"
        Me.MenuStrip2.Visible = False
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(44, 24)
        Me.FileToolStripMenuItem1.Text = "File"
        '
        'logoutBtn
        '
        Me.logoutBtn.BackColor = System.Drawing.Color.Transparent
        Me.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutBtn.Image = Global.Thesis6._0.My.Resources.Resources.gnome_panel_force_quit
        Me.logoutBtn.Location = New System.Drawing.Point(1329, 0)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(27, 24)
        Me.logoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoutBtn.TabIndex = 28
        Me.logoutBtn.TabStop = False
        Me.logoutBtn.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.BackColor = System.Drawing.Color.Transparent
        Me.CheckBox1.Location = New System.Drawing.Point(1352, -1)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(15, 14)
        Me.CheckBox1.TabIndex = 29
        Me.CheckBox1.UseVisualStyleBackColor = False
        '
        'registrarBtn
        '
        Me.registrarBtn.BackColor = System.Drawing.Color.White
        Me.registrarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.registrarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.registrarBtn.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.registrarBtn.ForeColor = System.Drawing.Color.Black
        Me.registrarBtn.Location = New System.Drawing.Point(9, 30)
        Me.registrarBtn.Name = "registrarBtn"
        Me.registrarBtn.Size = New System.Drawing.Size(299, 173)
        Me.registrarBtn.TabIndex = 19
        Me.registrarBtn.Text = "REGISTRAR"
        Me.registrarBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(247, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(60, 18)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'GuardPalace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.Thesis6._0.My.Resources.Resources.chapter4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1352, 781)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.logoutBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cashierBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.adminBtn)
        Me.Controls.Add(Me.sgBtn)
        Me.Controls.Add(Me.registrarBtn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "GuardPalace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.logoutBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cashierBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents adminBtn As System.Windows.Forms.Button
    Friend WithEvents sgBtn As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents logoutBtn As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents registrarBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
