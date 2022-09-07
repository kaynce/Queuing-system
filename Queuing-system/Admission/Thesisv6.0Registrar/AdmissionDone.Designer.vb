<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdmissionDone
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
        Dim NumberLabel As System.Windows.Forms.Label
        Dim PurposeLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.onholdnumberTxt = New System.Windows.Forms.TextBox()
        Me.onholdpurposeTxt = New System.Windows.Forms.TextBox()
        Me.onholdstatusTxt = New System.Windows.Forms.TextBox()
        Me.closeBtn = New System.Windows.Forms.PictureBox()
        NumberLabel = New System.Windows.Forms.Label()
        PurposeLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumberLabel
        '
        NumberLabel.AutoSize = True
        NumberLabel.Location = New System.Drawing.Point(119, 106)
        NumberLabel.Name = "NumberLabel"
        NumberLabel.Size = New System.Drawing.Size(47, 13)
        NumberLabel.TabIndex = 133
        NumberLabel.Text = "Number:"
        '
        'PurposeLabel
        '
        PurposeLabel.AutoSize = True
        PurposeLabel.Location = New System.Drawing.Point(119, 132)
        PurposeLabel.Name = "PurposeLabel"
        PurposeLabel.Size = New System.Drawing.Size(49, 13)
        PurposeLabel.TabIndex = 135
        PurposeLabel.Text = "Purpose:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(119, 158)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 137
        StatusLabel.Text = "Status:"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(605, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(63, 26)
        Me.Button1.TabIndex = 141
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(143, 9)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(81, 16)
        Me.LinkLabel2.TabIndex = 140
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Descending"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Red
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(53, 9)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(72, 16)
        Me.LinkLabel1.TabIndex = 139
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Ascending"
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.ListView1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ListView1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.FullRowSelect = True
        Me.ListView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView1.Location = New System.Drawing.Point(31, 36)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(637, 153)
        Me.ListView1.TabIndex = 132
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Number"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Purpose"
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Status"
        Me.ColumnHeader3.Width = 167
        '
        'onholdnumberTxt
        '
        Me.onholdnumberTxt.Location = New System.Drawing.Point(174, 103)
        Me.onholdnumberTxt.Name = "onholdnumberTxt"
        Me.onholdnumberTxt.Size = New System.Drawing.Size(29, 20)
        Me.onholdnumberTxt.TabIndex = 134
        '
        'onholdpurposeTxt
        '
        Me.onholdpurposeTxt.Location = New System.Drawing.Point(174, 129)
        Me.onholdpurposeTxt.Name = "onholdpurposeTxt"
        Me.onholdpurposeTxt.Size = New System.Drawing.Size(29, 20)
        Me.onholdpurposeTxt.TabIndex = 136
        '
        'onholdstatusTxt
        '
        Me.onholdstatusTxt.Location = New System.Drawing.Point(174, 155)
        Me.onholdstatusTxt.Name = "onholdstatusTxt"
        Me.onholdstatusTxt.Size = New System.Drawing.Size(29, 20)
        Me.onholdstatusTxt.TabIndex = 138
        '
        'closeBtn
        '
        Me.closeBtn.BackColor = System.Drawing.Color.Transparent
        Me.closeBtn.Image = Global.Thesisv6._0Registrar.My.Resources.Resources.close
        Me.closeBtn.Location = New System.Drawing.Point(683, 1)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(27, 24)
        Me.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.closeBtn.TabIndex = 142
        Me.closeBtn.TabStop = False
        '
        'RegistrarDone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = Global.Thesisv6._0Registrar.My.Resources.Resources.backgroundcreate
        Me.ClientSize = New System.Drawing.Size(711, 222)
        Me.ControlBox = False
        Me.Controls.Add(Me.closeBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(NumberLabel)
        Me.Controls.Add(Me.onholdnumberTxt)
        Me.Controls.Add(PurposeLabel)
        Me.Controls.Add(Me.onholdpurposeTxt)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.onholdstatusTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "RegistrarDone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.closeBtn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents closeBtn As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents onholdnumberTxt As System.Windows.Forms.TextBox
    Friend WithEvents onholdpurposeTxt As System.Windows.Forms.TextBox
    Friend WithEvents onholdstatusTxt As System.Windows.Forms.TextBox
End Class
