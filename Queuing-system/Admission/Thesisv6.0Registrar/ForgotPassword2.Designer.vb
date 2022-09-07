<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword2))
        Me.okBtn = New System.Windows.Forms.Button()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        Me.passTxt = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.questionTxt = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.passLabel = New System.Windows.Forms.Label()
        Me.answerTxt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'okBtn
        '
        Me.okBtn.BackgroundImage = CType(resources.GetObject("okBtn.BackgroundImage"), System.Drawing.Image)
        Me.okBtn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.okBtn.ForeColor = System.Drawing.Color.White
        Me.okBtn.Location = New System.Drawing.Point(176, 318)
        Me.okBtn.Name = "okBtn"
        Me.okBtn.Size = New System.Drawing.Size(100, 32)
        Me.okBtn.TabIndex = 177
        Me.okBtn.Text = "Ok"
        Me.okBtn.UseVisualStyleBackColor = True
        Me.okBtn.Visible = False
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Image = Global.Thesisv6._0Registrar.My.Resources.Resources.close
        Me.closeBtn.Location = New System.Drawing.Point(452, 1)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(27, 24)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closeBtn.TabIndex = 176
        Me.closeBtn.TabStop = False
        '
        'passTxt
        '
        Me.passTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.passTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.passTxt.Location = New System.Drawing.Point(60, 264)
        Me.passTxt.Multiline = True
        Me.passTxt.Name = "passTxt"
        Me.passTxt.ReadOnly = True
        Me.passTxt.Size = New System.Drawing.Size(343, 40)
        Me.passTxt.TabIndex = 175
        Me.passTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.passTxt.Visible = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.backgroundcreate
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(181, 165)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 32)
        Me.Button2.TabIndex = 174
        Me.Button2.Text = "Continue"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'questionTxt
        '
        Me.questionTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.questionTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.questionTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.questionTxt.ForeColor = System.Drawing.Color.Black
        Me.questionTxt.Location = New System.Drawing.Point(36, 45)
        Me.questionTxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.questionTxt.Multiline = True
        Me.questionTxt.Name = "questionTxt"
        Me.questionTxt.ReadOnly = True
        Me.questionTxt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.questionTxt.Size = New System.Drawing.Size(392, 40)
        Me.questionTxt.TabIndex = 168
        Me.questionTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(189, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 25)
        Me.Label9.TabIndex = 171
        Me.Label9.Text = "Question:"
        Me.Label9.Visible = False
        '
        'passLabel
        '
        Me.passLabel.AutoSize = True
        Me.passLabel.BackColor = System.Drawing.Color.Transparent
        Me.passLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passLabel.ForeColor = System.Drawing.Color.Black
        Me.passLabel.Location = New System.Drawing.Point(162, 227)
        Me.passLabel.Name = "passLabel"
        Me.passLabel.Size = New System.Drawing.Size(146, 25)
        Me.passLabel.TabIndex = 172
        Me.passLabel.Text = "Your password!"
        Me.passLabel.Visible = False
        '
        'answerTxt
        '
        Me.answerTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.answerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.answerTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.answerTxt.ForeColor = System.Drawing.Color.Black
        Me.answerTxt.Location = New System.Drawing.Point(40, 113)
        Me.answerTxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.answerTxt.Multiline = True
        Me.answerTxt.Name = "answerTxt"
        Me.answerTxt.Size = New System.Drawing.Size(388, 40)
        Me.answerTxt.TabIndex = 170
        Me.answerTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(193, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 25)
        Me.Label8.TabIndex = 173
        Me.Label8.Text = "Answer:"
        '
        'ForgotPassword2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.chapter24
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(482, 385)
        Me.Controls.Add(Me.okBtn)
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.passTxt)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.questionTxt)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.passLabel)
        Me.Controls.Add(Me.answerTxt)
        Me.Controls.Add(Me.Label8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPassword2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents okBtn As System.Windows.Forms.Button
    Friend WithEvents closeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents passTxt As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents questionTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents passLabel As System.Windows.Forms.Label
    Friend WithEvents answerTxt As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
