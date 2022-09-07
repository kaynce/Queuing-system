<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(476, 225)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 94
        Me.Label1.Text = "0"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.LinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Location = New System.Drawing.Point(330, 240)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(109, 15)
        Me.LinkLabel2.TabIndex = 88
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forgot Password?"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.SystemColors.HotTrack
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Location = New System.Drawing.Point(243, 306)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(172, 36)
        Me.LinkLabel1.TabIndex = 89
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "CreateAccount"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(131, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(404, 31)
        Me.Label2.TabIndex = 86
        Me.Label2.Text = "BULACAN POLYTECHNIC COLLEGE"
        '
        'passtxt
        '
        Me.passtxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passtxt.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtxt.ForeColor = System.Drawing.Color.Black
        Me.passtxt.Location = New System.Drawing.Point(222, 150)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(217, 37)
        Me.passtxt.TabIndex = 91
        Me.passtxt.UseSystemPasswordChar = True
        '
        'usertxt
        '
        Me.usertxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usertxt.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertxt.ForeColor = System.Drawing.Color.Black
        Me.usertxt.Location = New System.Drawing.Point(222, 105)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(217, 37)
        Me.usertxt.TabIndex = 90
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(445, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 22)
        Me.Button2.TabIndex = 92
        Me.Button2.Text = "show"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.loginBtn.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.backgroundcreate
        Me.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.loginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Purple
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.Color.White
        Me.loginBtn.Location = New System.Drawing.Point(222, 193)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(217, 44)
        Me.loginBtn.TabIndex = 87
        Me.loginBtn.Text = "Log-In"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(494, 242)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(18, 20)
        Me.TextBox1.TabIndex = 97
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(88, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 31)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(88, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 31)
        Me.Label4.TabIndex = 98
        Me.Label4.Text = "Password:"
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Image = Global.Thesisv6._0Registrar.My.Resources.Resources.close
        Me.closeBtn.Location = New System.Drawing.Point(585, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(27, 24)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closeBtn.TabIndex = 96
        Me.closeBtn.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(465, 212)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(53, 54)
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(233, 40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(190, 31)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Malolos Campus"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.chapter2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(615, 362)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.usertxt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents passtxt As System.Windows.Forms.TextBox
    Friend WithEvents usertxt As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents closeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
