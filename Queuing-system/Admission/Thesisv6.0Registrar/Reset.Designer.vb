<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reset
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.passtxt = New System.Windows.Forms.TextBox()
        Me.usertxt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(2, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 31)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "Reset Queue Number"
        '
        'passtxt
        '
        Me.passtxt.BackColor = System.Drawing.Color.White
        Me.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passtxt.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passtxt.ForeColor = System.Drawing.Color.Black
        Me.passtxt.Location = New System.Drawing.Point(3, 170)
        Me.passtxt.Name = "passtxt"
        Me.passtxt.Size = New System.Drawing.Size(238, 37)
        Me.passtxt.TabIndex = 93
        '
        'usertxt
        '
        Me.usertxt.BackColor = System.Drawing.Color.White
        Me.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.usertxt.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.usertxt.ForeColor = System.Drawing.Color.Black
        Me.usertxt.Location = New System.Drawing.Point(2, 90)
        Me.usertxt.Name = "usertxt"
        Me.usertxt.Size = New System.Drawing.Size(238, 37)
        Me.usertxt.TabIndex = 92
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(197, 212)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 22)
        Me.Button2.TabIndex = 94
        Me.Button2.Text = "show"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.SteelBlue
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.Location = New System.Drawing.Point(3, 240)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(238, 44)
        Me.loginBtn.TabIndex = 91
        Me.loginBtn.Text = "Reset"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Image = Global.Thesisv6._0Registrar.My.Resources.Resources.close
        Me.closeBtn.Location = New System.Drawing.Point(218, -1)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(27, 24)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closeBtn.TabIndex = 143
        Me.closeBtn.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(2, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 31)
        Me.Label4.TabIndex = 144
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 31)
        Me.Label3.TabIndex = 145
        Me.Label3.Text = "Username:"
        '
        'Reset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.backgroundcreate
        Me.ClientSize = New System.Drawing.Size(247, 296)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passtxt)
        Me.Controls.Add(Me.usertxt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.loginBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Reset"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents passtxt As System.Windows.Forms.TextBox
    Friend WithEvents usertxt As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents closeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
