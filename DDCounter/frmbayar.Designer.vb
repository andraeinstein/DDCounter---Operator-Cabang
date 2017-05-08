<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbayar
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblpesan = New System.Windows.Forms.Label()
        Me.lblproses = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lblinformasi = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblnota = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtterbilang = New System.Windows.Forms.TextBox()
        Me.SkypeButton2 = New DDCounter.SkypeButton()
        Me.SkypeButton1 = New DDCounter.SkypeButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Groupdepo = New System.Windows.Forms.GroupBox()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtdepo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Groupdepo.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DDCounter.My.Resources.Resources.notification_warning
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(8, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(98, 89)
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'lblpesan
        '
        Me.lblpesan.BackColor = System.Drawing.Color.Transparent
        Me.lblpesan.Font = New System.Drawing.Font("Lucida Sans Unicode", 30.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesan.ForeColor = System.Drawing.Color.Red
        Me.lblpesan.Location = New System.Drawing.Point(12, 185)
        Me.lblpesan.Name = "lblpesan"
        Me.lblpesan.Size = New System.Drawing.Size(625, 108)
        Me.lblpesan.TabIndex = 20
        Me.lblpesan.Text = "Label1"
        Me.lblpesan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblproses
        '
        Me.lblproses.BackColor = System.Drawing.Color.Transparent
        Me.lblproses.Font = New System.Drawing.Font("Lucida Sans Unicode", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblproses.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblproses.Location = New System.Drawing.Point(126, 298)
        Me.lblproses.Name = "lblproses"
        Me.lblproses.Size = New System.Drawing.Size(522, 36)
        Me.lblproses.TabIndex = 21
        Me.lblproses.Text = "Proses pengisian pulsa akan dilakukan setelah anda membayar sejumlah uang ......." & _
            "."
        Me.lblproses.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbltotal
        '
        Me.lbltotal.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(549, 146)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(88, 23)
        Me.lbltotal.TabIndex = 33
        Me.lbltotal.Text = "lbltotal"
        Me.lbltotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(449, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 23)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Harga Total : Rp."
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(122, 18)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(511, 125)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 30
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 500
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'lblinformasi
        '
        Me.lblinformasi.AutoSize = True
        Me.lblinformasi.BackColor = System.Drawing.Color.Transparent
        Me.lblinformasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.lblinformasi.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblinformasi.Location = New System.Drawing.Point(119, 151)
        Me.lblinformasi.Name = "lblinformasi"
        Me.lblinformasi.Size = New System.Drawing.Size(135, 15)
        Me.lblinformasi.TabIndex = 34
        Me.lblinformasi.Text = "Daftar pulsa yang dibeli"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblnota)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblinformasi)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.lbltotal)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(641, 174)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informasi Pembelian Pulsa"
        '
        'lblnota
        '
        Me.lblnota.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnota.Location = New System.Drawing.Point(355, 146)
        Me.lblnota.Name = "lblnota"
        Me.lblnota.Size = New System.Drawing.Size(74, 23)
        Me.lblnota.TabIndex = 41
        Me.lblnota.Text = "Label4"
        Me.lblnota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(297, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 23)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "No Nota :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtterbilang)
        Me.GroupBox2.Controls.Add(Me.SkypeButton2)
        Me.GroupBox2.Controls.Add(Me.SkypeButton1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtpass)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(641, 108)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Otorisasi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(81, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Terbilang"
        '
        'txtterbilang
        '
        Me.txtterbilang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtterbilang.Enabled = False
        Me.txtterbilang.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtterbilang.Location = New System.Drawing.Point(101, 14)
        Me.txtterbilang.Multiline = True
        Me.txtterbilang.Name = "txtterbilang"
        Me.txtterbilang.Size = New System.Drawing.Size(528, 49)
        Me.txtterbilang.TabIndex = 9
        '
        'SkypeButton2
        '
        Me.SkypeButton2.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton2.Customization = ""
        Me.SkypeButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton2.Image = Nothing
        Me.SkypeButton2.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton2.Location = New System.Drawing.Point(534, 69)
        Me.SkypeButton2.Name = "SkypeButton2"
        Me.SkypeButton2.NoRounding = False
        Me.SkypeButton2.Size = New System.Drawing.Size(95, 32)
        Me.SkypeButton2.TabIndex = 8
        Me.SkypeButton2.Text = "Batal"
        Me.SkypeButton2.Text_Margin_Left = 24
        Me.SkypeButton2.Transparent = False
        '
        'SkypeButton1
        '
        Me.SkypeButton1.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton1.Customization = ""
        Me.SkypeButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton1.Image = Nothing
        Me.SkypeButton1.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton1.Location = New System.Drawing.Point(427, 69)
        Me.SkypeButton1.Name = "SkypeButton1"
        Me.SkypeButton1.NoRounding = False
        Me.SkypeButton1.Size = New System.Drawing.Size(95, 32)
        Me.SkypeButton1.TabIndex = 7
        Me.SkypeButton1.Text = "OK"
        Me.SkypeButton1.Text_Margin_Left = 32
        Me.SkypeButton1.Transparent = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = ":"
        '
        'txtpass
        '
        Me.txtpass.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(101, 73)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(238, 28)
        Me.txtpass.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'Groupdepo
        '
        Me.Groupdepo.BackColor = System.Drawing.Color.Transparent
        Me.Groupdepo.Controls.Add(Me.txtid)
        Me.Groupdepo.Controls.Add(Me.txtdepo)
        Me.Groupdepo.Controls.Add(Me.Label8)
        Me.Groupdepo.Controls.Add(Me.Label9)
        Me.Groupdepo.Controls.Add(Me.txtnama)
        Me.Groupdepo.Location = New System.Drawing.Point(15, 252)
        Me.Groupdepo.Name = "Groupdepo"
        Me.Groupdepo.Size = New System.Drawing.Size(633, 76)
        Me.Groupdepo.TabIndex = 37
        Me.Groupdepo.TabStop = False
        Me.Groupdepo.Text = "Informasi Deposit"
        '
        'txtid
        '
        Me.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(90, 18)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(129, 23)
        Me.txtid.TabIndex = 14
        '
        'txtdepo
        '
        Me.txtdepo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtdepo.Enabled = False
        Me.txtdepo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdepo.Location = New System.Drawing.Point(343, 18)
        Me.txtdepo.Name = "txtdepo"
        Me.txtdepo.Size = New System.Drawing.Size(153, 23)
        Me.txtdepo.TabIndex = 18
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Nama"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(7, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 17)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "ID Reseller"
        '
        'txtnama
        '
        Me.txtnama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnama.Enabled = False
        Me.txtnama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(90, 47)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(181, 23)
        Me.txtnama.TabIndex = 16
        '
        'frmbayar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DDCounter.My.Resources.Resources.blackwhite2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 448)
        Me.ControlBox = False
        Me.Controls.Add(Me.Groupdepo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblproses)
        Me.Controls.Add(Me.lblpesan)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmbayar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Groupdepo.ResumeLayout(False)
        Me.Groupdepo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblpesan As System.Windows.Forms.Label
    Friend WithEvents lblproses As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents lblinformasi As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents SkypeButton2 As DDCounter.SkypeButton
    Friend WithEvents SkypeButton1 As DDCounter.SkypeButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtterbilang As System.Windows.Forms.TextBox
    Friend WithEvents lblnota As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Groupdepo As System.Windows.Forms.GroupBox
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtdepo As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
End Class
