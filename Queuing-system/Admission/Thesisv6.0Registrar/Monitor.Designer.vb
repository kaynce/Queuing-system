<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Monitor
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.monitorSG = New System.Windows.Forms.Label()
        Me.monitorAdmission = New System.Windows.Forms.Label()
        Me.monitorCashier = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.monitorRegistrar = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.monitorRegistrarTimer = New System.Windows.Forms.Timer(Me.components)
        Me.monitorCashierTimer = New System.Windows.Forms.Timer(Me.components)
        Me.monitorAdmissionTimer = New System.Windows.Forms.Timer(Me.components)
        Me.monitorSGTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeTday = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.displayTxt = New System.Windows.Forms.TextBox()
        Me.displayTimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Thesisv6._0Registrar.My.Resources.Resources.Logooo
        Me.PictureBox1.Location = New System.Drawing.Point(6, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 222)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.Thesisv6._0Registrar.My.Resources.Resources.bpcpart3
        Me.PictureBox3.Location = New System.Drawing.Point(1143, 59)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(218, 222)
        Me.PictureBox3.TabIndex = 15
        Me.PictureBox3.TabStop = False
        '
        'monitorSG
        '
        Me.monitorSG.Font = New System.Drawing.Font("Arial Narrow", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monitorSG.Location = New System.Drawing.Point(458, 663)
        Me.monitorSG.Name = "monitorSG"
        Me.monitorSG.Size = New System.Drawing.Size(246, 68)
        Me.monitorSG.TabIndex = 22
        Me.monitorSG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'monitorAdmission
        '
        Me.monitorAdmission.Font = New System.Drawing.Font("Arial Narrow", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monitorAdmission.Location = New System.Drawing.Point(458, 514)
        Me.monitorAdmission.Name = "monitorAdmission"
        Me.monitorAdmission.Size = New System.Drawing.Size(246, 68)
        Me.monitorAdmission.TabIndex = 23
        Me.monitorAdmission.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'monitorCashier
        '
        Me.monitorCashier.Font = New System.Drawing.Font("Arial Narrow", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monitorCashier.Location = New System.Drawing.Point(458, 364)
        Me.monitorCashier.Name = "monitorCashier"
        Me.monitorCashier.Size = New System.Drawing.Size(246, 68)
        Me.monitorCashier.TabIndex = 24
        Me.monitorCashier.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(436, 632)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(292, 31)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "STUDENT GOVERNMENT:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(436, 333)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 31)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "CASHIER:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(436, 483)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 31)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "ADMISSION:"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(430, 623)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(304, 129)
        Me.Label6.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(430, 473)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(304, 129)
        Me.Label4.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(430, 324)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(304, 129)
        Me.Label3.TabIndex = 18
        '
        'monitorRegistrar
        '
        Me.monitorRegistrar.Font = New System.Drawing.Font("Arial Narrow", 60.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monitorRegistrar.Location = New System.Drawing.Point(55, 378)
        Me.monitorRegistrar.Name = "monitorRegistrar"
        Me.monitorRegistrar.Size = New System.Drawing.Size(301, 95)
        Me.monitorRegistrar.TabIndex = 27
        Me.monitorRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(43, 333)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(181, 37)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "REGISTRAR:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(25, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 172)
        Me.Label2.TabIndex = 25
        '
        'monitorRegistrarTimer
        '
        Me.monitorRegistrarTimer.Enabled = True
        Me.monitorRegistrarTimer.Interval = 1000
        '
        'monitorCashierTimer
        '
        Me.monitorCashierTimer.Enabled = True
        Me.monitorCashierTimer.Interval = 1000
        '
        'monitorAdmissionTimer
        '
        Me.monitorAdmissionTimer.Enabled = True
        Me.monitorAdmissionTimer.Interval = 1000
        '
        'monitorSGTimer
        '
        Me.monitorSGTimer.Enabled = True
        Me.monitorSGTimer.Interval = 1000
        '
        'TimeTday
        '
        Me.TimeTday.BackColor = System.Drawing.Color.Transparent
        Me.TimeTday.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeTday.Location = New System.Drawing.Point(824, -1)
        Me.TimeTday.Name = "TimeTday"
        Me.TimeTday.Size = New System.Drawing.Size(550, 39)
        Me.TimeTday.TabIndex = 28
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.bpcmalolos
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(756, 324)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(594, 428)
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'displayTxt
        '
        Me.displayTxt.Location = New System.Drawing.Point(1015, 808)
        Me.displayTxt.Name = "displayTxt"
        Me.displayTxt.Size = New System.Drawing.Size(113, 20)
        Me.displayTxt.TabIndex = 30
        '
        'displayTimer
        '
        Me.displayTimer.Enabled = True
        Me.displayTimer.Interval = 1000
        '
        'Monitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.PART4MONITOR2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1386, 788)
        Me.ControlBox = False
        Me.Controls.Add(Me.displayTxt)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TimeTday)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.monitorRegistrar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.monitorSG)
        Me.Controls.Add(Me.monitorAdmission)
        Me.Controls.Add(Me.monitorCashier)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Monitor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents monitorSG As System.Windows.Forms.Label
    Friend WithEvents monitorAdmission As System.Windows.Forms.Label
    Friend WithEvents monitorCashier As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents monitorRegistrar As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents monitorRegistrarTimer As System.Windows.Forms.Timer
    Friend WithEvents monitorCashierTimer As System.Windows.Forms.Timer
    Friend WithEvents monitorAdmissionTimer As System.Windows.Forms.Timer
    Friend WithEvents monitorSGTimer As System.Windows.Forms.Timer
    Friend WithEvents TimeTday As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents displayTxt As System.Windows.Forms.TextBox
    Friend WithEvents displayTimer As System.Windows.Forms.Timer
End Class
