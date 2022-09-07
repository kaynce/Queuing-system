<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ForgotPassword))
        Me.continueBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.userTxt = New System.Windows.Forms.TextBox()
        Me.userTypeTxt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout
        '
        'continueBtn
        '
        Me.continueBtn.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.backgroundcreate
        Me.continueBtn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.continueBtn.ForeColor = System.Drawing.Color.White
        Me.continueBtn.Location = New System.Drawing.Point(257, 220)
        Me.continueBtn.Name = "continueBtn"
        Me.continueBtn.Size = New System.Drawing.Size(100, 32)
        Me.continueBtn.TabIndex = 171
        Me.continueBtn.Text = "Continue"
        Me.continueBtn.UseVisualStyleBackColor = True
        '
        'cancelBtn
        '
        Me.cancelBtn.BackgroundImage = CType(resources.GetObject("cancelBtn.BackgroundImage"), System.Drawing.Image)
        Me.cancelBtn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold)
        Me.cancelBtn.ForeColor = System.Drawing.Color.White
        Me.cancelBtn.Location = New System.Drawing.Point(257, 258)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(100, 32)
        Me.cancelBtn.TabIndex = 172
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(265, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 25)
        Me.Label1.TabIndex = 170
        Me.Label1.Text = "Usertype"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(244, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 25)
        Me.Label5.TabIndex = 169
        Me.Label5.Text = "Your username"
        '
        'userTxt
        '
        Me.userTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.userTxt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.userTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.userTxt.ForeColor = System.Drawing.Color.Black
        Me.userTxt.Location = New System.Drawing.Point(200, 98)
        Me.userTxt.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.userTxt.Multiline = True
        Me.userTxt.Name = "userTxt"
        Me.userTxt.Size = New System.Drawing.Size(220, 40)
        Me.userTxt.TabIndex = 167
        Me.userTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'userTypeTxt
        '
        Me.userTypeTxt.BackColor = System.Drawing.SystemColors.Highlight
        Me.userTypeTxt.Font = New System.Drawing.Font("Arial Narrow", 18.0!, System.Drawing.FontStyle.Bold)
        Me.userTypeTxt.Location = New System.Drawing.Point(200, 173)
        Me.userTypeTxt.Multiline = True
        Me.userTypeTxt.Name = "userTypeTxt"
        Me.userTypeTxt.ReadOnly = True
        Me.userTypeTxt.Size = New System.Drawing.Size(220, 40)
        Me.userTypeTxt.TabIndex = 173
        Me.userTypeTxt.Text = "Registrar"
        Me.userTypeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.chapter2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(615, 362)
        Me.ControlBox = false
        Me.Controls.Add(Me.userTypeTxt)
        Me.Controls.Add(Me.continueBtn)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.userTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ForgotPassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ForgotPassword"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents continueBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents userTxt As System.Windows.Forms.TextBox
    Friend WithEvents userTypeTxt As System.Windows.Forms.TextBox
End Class
