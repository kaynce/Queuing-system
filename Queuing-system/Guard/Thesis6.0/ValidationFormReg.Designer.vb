<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ValidationFormReg
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.onqueuenumberTxt = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.onqueuepurposeTxt = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(87, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 50)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(87, 255)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 50)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(56, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 62)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your  Number"
        '
        'onqueuenumberTxt
        '
        Me.onqueuenumberTxt.BackColor = System.Drawing.Color.Transparent
        Me.onqueuenumberTxt.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onqueuenumberTxt.ForeColor = System.Drawing.Color.Black
        Me.onqueuenumberTxt.Location = New System.Drawing.Point(61, 71)
        Me.onqueuenumberTxt.Name = "onqueuenumberTxt"
        Me.onqueuenumberTxt.Size = New System.Drawing.Size(196, 76)
        Me.onqueuenumberTxt.TabIndex = 2
        Me.onqueuenumberTxt.Text = "R0001"
        Me.onqueuenumberTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dddd,dd MMMM yyyy hh:mmtt"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(48, 322)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(260, 20)
        Me.DateTimePicker1.TabIndex = 372
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(28, 311)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(293, 40)
        Me.PictureBox1.TabIndex = 373
        Me.PictureBox1.TabStop = False
        '
        'onqueuepurposeTxt
        '
        Me.onqueuepurposeTxt.BackColor = System.Drawing.Color.Transparent
        Me.onqueuepurposeTxt.Font = New System.Drawing.Font("Arial Narrow", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.onqueuepurposeTxt.Location = New System.Drawing.Point(56, 133)
        Me.onqueuepurposeTxt.Name = "onqueuepurposeTxt"
        Me.onqueuepurposeTxt.Size = New System.Drawing.Size(228, 62)
        Me.onqueuepurposeTxt.TabIndex = 2
        Me.onqueuepurposeTxt.Text = "GOOD MORAL"
        Me.onqueuepurposeTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Location = New System.Drawing.Point(15, 136)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(278, 58)
        Me.PictureBox2.TabIndex = 374
        Me.PictureBox2.TabStop = False
        '
        'ValidationFormReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Thesis6._0.My.Resources.Resources.chapter24
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(318, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.onqueuenumberTxt)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.onqueuepurposeTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ValidationFormReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents onqueuenumberTxt As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents onqueuepurposeTxt As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
End Class
