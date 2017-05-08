<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdepo
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
        Me.TeamViewerTheme1 = New DDCounter.TeamViewerTheme()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnok = New DDCounter.SkypeButton()
        Me.btnout = New DDCounter.SkypeButton()
        Me.txtjumlah = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtterbilang = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.lblnama = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TeamViewerTheme1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TeamViewerTheme1
        '
        Me.TeamViewerTheme1.Controls.Add(Me.GroupBox1)
        Me.TeamViewerTheme1.Controls.Add(Me.GroupBox2)
        Me.TeamViewerTheme1.Controls.Add(Me.Label8)
        Me.TeamViewerTheme1.Controls.Add(Me.Label7)
        Me.TeamViewerTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TeamViewerTheme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TeamViewerTheme1.Image = Nothing
        Me.TeamViewerTheme1.Location = New System.Drawing.Point(0, 0)
        Me.TeamViewerTheme1.MoveHeight = 19
        Me.TeamViewerTheme1.Name = "TeamViewerTheme1"
        Me.TeamViewerTheme1.Resizable = True
        Me.TeamViewerTheme1.Size = New System.Drawing.Size(545, 564)
        Me.TeamViewerTheme1.TabIndex = 0
        Me.TeamViewerTheme1.Text = "TeamViewerTheme1"
        Me.TeamViewerTheme1.TransparencyKey = System.Drawing.Color.Empty
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.btnok)
        Me.GroupBox1.Controls.Add(Me.btnout)
        Me.GroupBox1.Controls.Add(Me.txtjumlah)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtterbilang)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 257)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 295)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Deposit"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label11.Location = New System.Drawing.Point(216, 66)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(212, 15)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Masukkan jumlah uang untuk deposit"
        '
        'btnok
        '
        Me.btnok.Colors = New DDCounter.Bloom(-1) {}
        Me.btnok.Customization = ""
        Me.btnok.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnok.Image = Nothing
        Me.btnok.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.btnok.Location = New System.Drawing.Point(298, 246)
        Me.btnok.Name = "btnok"
        Me.btnok.NoRounding = False
        Me.btnok.Size = New System.Drawing.Size(104, 32)
        Me.btnok.TabIndex = 31
        Me.btnok.Text = "OK"
        Me.btnok.Text_Margin_Left = 35
        Me.btnok.Transparent = False
        '
        'btnout
        '
        Me.btnout.Colors = New DDCounter.Bloom(-1) {}
        Me.btnout.Customization = ""
        Me.btnout.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnout.Image = Nothing
        Me.btnout.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.btnout.Location = New System.Drawing.Point(408, 246)
        Me.btnout.Name = "btnout"
        Me.btnout.NoRounding = False
        Me.btnout.Size = New System.Drawing.Size(104, 32)
        Me.btnout.TabIndex = 19
        Me.btnout.Text = "Logout"
        Me.btnout.Text_Margin_Left = 23
        Me.btnout.Transparent = False
        '
        'txtjumlah
        '
        Me.txtjumlah.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtjumlah.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtjumlah.Location = New System.Drawing.Point(219, 19)
        Me.txtjumlah.Name = "txtjumlah"
        Me.txtjumlah.Size = New System.Drawing.Size(293, 41)
        Me.txtjumlah.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(159, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 27)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Rp. "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 27)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Jumlah      :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 27)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Terbilang  :"
        '
        'txtterbilang
        '
        Me.txtterbilang.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtterbilang.Location = New System.Drawing.Point(164, 95)
        Me.txtterbilang.Multiline = True
        Me.txtterbilang.Name = "txtterbilang"
        Me.txtterbilang.ReadOnly = True
        Me.txtterbilang.Size = New System.Drawing.Size(348, 134)
        Me.txtterbilang.TabIndex = 27
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.txtalamat)
        Me.GroupBox2.Controls.Add(Me.lblnama)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtid)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtnama)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(523, 156)
        Me.GroupBox2.TabIndex = 32
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Reseller"
        '
        'txtalamat
        '
        Me.txtalamat.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtalamat.Enabled = False
        Me.txtalamat.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtalamat.Location = New System.Drawing.Point(116, 106)
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(396, 36)
        Me.txtalamat.TabIndex = 15
        '
        'lblnama
        '
        Me.lblnama.AutoSize = True
        Me.lblnama.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnama.Location = New System.Drawing.Point(10, 65)
        Me.lblnama.Name = "lblnama"
        Me.lblnama.Size = New System.Drawing.Size(73, 27)
        Me.lblnama.TabIndex = 10
        Me.lblnama.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 27)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "ID"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(91, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 27)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = ":"
        '
        'txtid
        '
        Me.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtid.Enabled = False
        Me.txtid.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(116, 22)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(225, 36)
        Me.txtid.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(91, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(19, 27)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = ":"
        '
        'txtnama
        '
        Me.txtnama.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtnama.Enabled = False
        Me.txtnama.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnama.Location = New System.Drawing.Point(116, 64)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(292, 36)
        Me.txtnama.TabIndex = 14
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(91, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(19, 27)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = ":"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(417, 6)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 16)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "DD-Tronik © 2014"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(143, 41)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Deposit"
        '
        'frmdepo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 564)
        Me.ControlBox = False
        Me.Controls.Add(Me.TeamViewerTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmdepo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TeamViewerTheme1.ResumeLayout(False)
        Me.TeamViewerTheme1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TeamViewerTheme1 As DDCounter.TeamViewerTheme
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtjumlah As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtterbilang As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents lblnama As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnok As DDCounter.SkypeButton
    Friend WithEvents btnout As DDCounter.SkypeButton
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
