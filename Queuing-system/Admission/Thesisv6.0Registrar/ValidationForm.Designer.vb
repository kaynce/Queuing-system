<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidationForm
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.contactTxt = New System.Windows.Forms.MaskedTextBox()
        Me.surnameTxt = New System.Windows.Forms.TextBox()
        Me.firstnameTxt = New System.Windows.Forms.TextBox()
        Me.answerTxt = New System.Windows.Forms.TextBox()
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.confirmTxt = New System.Windows.Forms.TextBox()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.questionTxt = New System.Windows.Forms.TextBox()
        Me.userTypeTxt = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(115, 477)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 25)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "Usertype:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(114, 378)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 25)
        Me.Label9.TabIndex = 158
        Me.Label9.Text = "Question:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(114, 428)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 25)
        Me.Label8.TabIndex = 159
        Me.Label8.Text = "Answer:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(65, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(173, 25)
        Me.Label7.TabIndex = 156
        Me.Label7.Text = "Confirm Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(108, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 25)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(110, 229)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 25)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Username:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(108, 181)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 25)
        Me.Label4.TabIndex = 153
        Me.Label4.Text = "Contact No:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(108, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Firstname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(110, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 25)
        Me.Label2.TabIndex = 151
        Me.Label2.Text = "Surname:"
        '
        'contactTxt
        '
        Me.contactTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.contactTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.contactTxt.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactTxt.ForeColor = System.Drawing.Color.Black
        Me.contactTxt.Location = New System.Drawing.Point(244, 169)
        Me.contactTxt.Mask = "+63 000 000 0000"
        Me.contactTxt.Name = "contactTxt"
        Me.contactTxt.ReadOnly = True
        Me.contactTxt.Size = New System.Drawing.Size(218, 37)
        Me.contactTxt.TabIndex = 168
        '
        'surnameTxt
        '
        Me.surnameTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.surnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.surnameTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surnameTxt.ForeColor = System.Drawing.Color.Black
        Me.surnameTxt.Location = New System.Drawing.Point(244, 70)
        Me.surnameTxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.surnameTxt.Multiline = True
        Me.surnameTxt.Name = "surnameTxt"
        Me.surnameTxt.ReadOnly = True
        Me.surnameTxt.Size = New System.Drawing.Size(218, 41)
        Me.surnameTxt.TabIndex = 162
        '
        'firstnameTxt
        '
        Me.firstnameTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.firstnameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.firstnameTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.firstnameTxt.ForeColor = System.Drawing.Color.Black
        Me.firstnameTxt.Location = New System.Drawing.Point(244, 120)
        Me.firstnameTxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.firstnameTxt.Multiline = True
        Me.firstnameTxt.Name = "firstnameTxt"
        Me.firstnameTxt.ReadOnly = True
        Me.firstnameTxt.Size = New System.Drawing.Size(218, 40)
        Me.firstnameTxt.TabIndex = 163
        '
        'answerTxt
        '
        Me.answerTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.answerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.answerTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.answerTxt.ForeColor = System.Drawing.Color.Black
        Me.answerTxt.Location = New System.Drawing.Point(244, 413)
        Me.answerTxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.answerTxt.Multiline = True
        Me.answerTxt.Name = "answerTxt"
        Me.answerTxt.ReadOnly = True
        Me.answerTxt.Size = New System.Drawing.Size(218, 40)
        Me.answerTxt.TabIndex = 164
        '
        'userTxt
        '
        Me.userTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.userTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.userTxt.ForeColor = System.Drawing.Color.Black
        Me.userTxt.Location = New System.Drawing.Point(244, 214)
        Me.userTxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.userTxt.Multiline = True
        Me.userTxt.Name = "userTxt"
        Me.userTxt.ReadOnly = True
        Me.userTxt.Size = New System.Drawing.Size(218, 40)
        Me.userTxt.TabIndex = 165
        '
        'confirmTxt
        '
        Me.confirmTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.confirmTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.confirmTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.confirmTxt.ForeColor = System.Drawing.Color.Black
        Me.confirmTxt.Location = New System.Drawing.Point(244, 313)
        Me.confirmTxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.confirmTxt.Multiline = True
        Me.confirmTxt.Name = "confirmTxt"
        Me.confirmTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.confirmTxt.ReadOnly = True
        Me.confirmTxt.Size = New System.Drawing.Size(218, 41)
        Me.confirmTxt.TabIndex = 161
        '
        'passTxt
        '
        Me.passTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.passTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.passTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.passTxt.ForeColor = System.Drawing.Color.Black
        Me.passTxt.Location = New System.Drawing.Point(244, 264)
        Me.passTxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.passTxt.Multiline = True
        Me.passTxt.Name = "passTxt"
        Me.passTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passTxt.ReadOnly = True
        Me.passTxt.Size = New System.Drawing.Size(218, 41)
        Me.passTxt.TabIndex = 160
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(225, 523)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(71, 25)
        Me.LinkLabel1.TabIndex = 169
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Submit"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(328, 523)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(70, 25)
        Me.LinkLabel2.TabIndex = 170
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Cancel"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'questionTxt
        '
        Me.questionTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.questionTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.questionTxt.ForeColor = System.Drawing.Color.Black
        Me.questionTxt.Location = New System.Drawing.Point(244, 362)
        Me.questionTxt.Multiline = True
        Me.questionTxt.Name = "questionTxt"
        Me.questionTxt.ReadOnly = True
        Me.questionTxt.Size = New System.Drawing.Size(218, 41)
        Me.questionTxt.TabIndex = 171
        '
        'userTypeTxt
        '
        Me.userTypeTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.userTypeTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.userTypeTxt.ForeColor = System.Drawing.Color.Black
        Me.userTypeTxt.Location = New System.Drawing.Point(244, 461)
        Me.userTypeTxt.Multiline = True
        Me.userTypeTxt.Name = "userTypeTxt"
        Me.userTypeTxt.ReadOnly = True
        Me.userTypeTxt.Size = New System.Drawing.Size(218, 41)
        Me.userTypeTxt.TabIndex = 172
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.SteelBlue
        Me.Button3.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(468, 335)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 21)
        Me.Button3.TabIndex = 174
        Me.Button3.Text = "Show"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SteelBlue
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(468, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 21)
        Me.Button2.TabIndex = 173
        Me.Button2.Text = "Show"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(136, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(415, 31)
        Me.Label10.TabIndex = 151
        Me.Label10.Text = "Please double check your information"
        '
        'ValidationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.chapter22
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(637, 697)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.userTypeTxt)
        Me.Controls.Add(Me.questionTxt)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.contactTxt)
        Me.Controls.Add(Me.surnameTxt)
        Me.Controls.Add(Me.firstnameTxt)
        Me.Controls.Add(Me.answerTxt)
        Me.Controls.Add(Me.userTxt)
        Me.Controls.Add(Me.confirmTxt)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ValidationForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ValidationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents contactTxt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents surnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents firstnameTxt As System.Windows.Forms.TextBox
    Friend WithEvents answerTxt As System.Windows.Forms.TextBox
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents confirmTxt As System.Windows.Forms.TextBox
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents questionTxt As System.Windows.Forms.TextBox
    Friend WithEvents userTypeTxt As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
