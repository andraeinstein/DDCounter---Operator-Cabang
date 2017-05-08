<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlogin
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtpin = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SkypeButton2 = New DDCounter.SkypeButton()
        Me.SkypeButton1 = New DDCounter.SkypeButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtpin)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtid)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(481, 129)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Masukkan ID dan PIN"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 27)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = ":"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(19, 27)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = ":"
        '
        'txtpin
        '
        Me.txtpin.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpin.Location = New System.Drawing.Point(168, 74)
        Me.txtpin.Name = "txtpin"
        Me.txtpin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpin.Size = New System.Drawing.Size(134, 41)
        Me.txtpin.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 27)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Pin"
        '
        'txtid
        '
        Me.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtid.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(168, 22)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(304, 41)
        Me.txtid.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 27)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID Reseller"
        '
        'SkypeButton2
        '
        Me.SkypeButton2.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton2.Customization = ""
        Me.SkypeButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton2.Image = Nothing
        Me.SkypeButton2.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton2.Location = New System.Drawing.Point(396, 140)
        Me.SkypeButton2.Name = "SkypeButton2"
        Me.SkypeButton2.NoRounding = False
        Me.SkypeButton2.Size = New System.Drawing.Size(95, 32)
        Me.SkypeButton2.TabIndex = 6
        Me.SkypeButton2.Text = "Batal"
        Me.SkypeButton2.Text_Margin_Left = 23
        Me.SkypeButton2.Transparent = False
        '
        'SkypeButton1
        '
        Me.SkypeButton1.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton1.Customization = ""
        Me.SkypeButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton1.Image = Nothing
        Me.SkypeButton1.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton1.Location = New System.Drawing.Point(295, 140)
        Me.SkypeButton1.Name = "SkypeButton1"
        Me.SkypeButton1.NoRounding = False
        Me.SkypeButton1.Size = New System.Drawing.Size(95, 32)
        Me.SkypeButton1.TabIndex = 5
        Me.SkypeButton1.Text = "Login"
        Me.SkypeButton1.Text_Margin_Left = 20
        Me.SkypeButton1.Transparent = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Location = New System.Drawing.Point(7, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(204, 15)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Masukkan ID Reseller dan Pin anda"
        '
        'frmlogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DDCounter.My.Resources.Resources.blackwhite2
        Me.ClientSize = New System.Drawing.Size(503, 179)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SkypeButton2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.SkypeButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmlogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtpin As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SkypeButton1 As DDCounter.SkypeButton
    Friend WithEvents SkypeButton2 As DDCounter.SkypeButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
