<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Account
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
        Me.currentTxt = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.newTxt = New System.Windows.Forms.TextBox()
        Me.confirmTxt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'currentTxt
        '
        Me.currentTxt.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.currentTxt.Location = New System.Drawing.Point(211, 133)
        Me.currentTxt.Multiline = True
        Me.currentTxt.Name = "currentTxt"
        Me.currentTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.currentTxt.Size = New System.Drawing.Size(179, 26)
        Me.currentTxt.TabIndex = 110
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(396, 196)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(44, 22)
        Me.Button3.TabIndex = 109
        Me.Button3.Text = "show"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(396, 138)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 22)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "show"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(396, 166)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(44, 22)
        Me.Button2.TabIndex = 107
        Me.Button2.Text = "show"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'userTxt
        '
        Me.userTxt.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userTxt.Location = New System.Drawing.Point(211, 102)
        Me.userTxt.Multiline = True
        Me.userTxt.Name = "userTxt"
        Me.userTxt.Size = New System.Drawing.Size(179, 26)
        Me.userTxt.TabIndex = 106
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(109, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(285, 43)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Change Password"
        '
        'newTxt
        '
        Me.newTxt.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.newTxt.Location = New System.Drawing.Point(211, 163)
        Me.newTxt.Multiline = True
        Me.newTxt.Name = "newTxt"
        Me.newTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newTxt.Size = New System.Drawing.Size(179, 26)
        Me.newTxt.TabIndex = 101
        '
        'confirmTxt
        '
        Me.confirmTxt.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.confirmTxt.Location = New System.Drawing.Point(211, 192)
        Me.confirmTxt.Multiline = True
        Me.confirmTxt.Name = "confirmTxt"
        Me.confirmTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmTxt.Size = New System.Drawing.Size(179, 26)
        Me.confirmTxt.TabIndex = 102
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(90, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 20)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "New Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 20)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Confirm Password:"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.White
        Me.btnSave.Location = New System.Drawing.Point(156, 252)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 33)
        Me.btnSave.TabIndex = 97
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.White
        Me.btnCancel.Location = New System.Drawing.Point(263, 252)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 33)
        Me.btnCancel.TabIndex = 99
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 100
        Me.Label3.Text = "User Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 20)
        Me.Label2.TabIndex = 98
        Me.Label2.Text = "Current Password:"
        '
        'Account
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.chapter2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(506, 311)
        Me.ControlBox = False
        Me.Controls.Add(Me.currentTxt)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.userTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.newTxt)
        Me.Controls.Add(Me.confirmTxt)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Account"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents currentTxt As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents newTxt As System.Windows.Forms.TextBox
    Friend WithEvents confirmTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
