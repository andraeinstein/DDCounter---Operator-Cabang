<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlagi
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblpesan = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkypeButton2 = New DDCounter.SkypeButton()
        Me.SkypeButton1 = New DDCounter.SkypeButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.SkypeButton3 = New DDCounter.SkypeButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblpesan
        '
        Me.lblpesan.BackColor = System.Drawing.Color.Transparent
        Me.lblpesan.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesan.Location = New System.Drawing.Point(101, 0)
        Me.lblpesan.Name = "lblpesan"
        Me.lblpesan.Size = New System.Drawing.Size(403, 37)
        Me.lblpesan.TabIndex = 21
        Me.lblpesan.Text = "Pembelian Pulsa :"
        Me.lblpesan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.DataGridView1.Location = New System.Drawing.Point(105, 37)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(472, 125)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 185)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(403, 37)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Apakah anda ingin mengisi pulsa lagi?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SkypeButton2
        '
        Me.SkypeButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SkypeButton2.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton2.Customization = ""
        Me.SkypeButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton2.Image = Nothing
        Me.SkypeButton2.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton2.Location = New System.Drawing.Point(433, 223)
        Me.SkypeButton2.Name = "SkypeButton2"
        Me.SkypeButton2.NoRounding = False
        Me.SkypeButton2.Size = New System.Drawing.Size(144, 32)
        Me.SkypeButton2.TabIndex = 23
        Me.SkypeButton2.Text = "Tidak / Selesai"
        Me.SkypeButton2.Text_Margin_Left = 20
        Me.SkypeButton2.Transparent = False
        '
        'SkypeButton1
        '
        Me.SkypeButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SkypeButton1.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton1.Customization = ""
        Me.SkypeButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton1.Image = Nothing
        Me.SkypeButton1.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton1.Location = New System.Drawing.Point(340, 223)
        Me.SkypeButton1.Name = "SkypeButton1"
        Me.SkypeButton1.NoRounding = False
        Me.SkypeButton1.Size = New System.Drawing.Size(84, 32)
        Me.SkypeButton1.TabIndex = 20
        Me.SkypeButton1.Text = "Ya"
        Me.SkypeButton1.Text_Margin_Left = 27
        Me.SkypeButton1.Transparent = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(102, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Daftar pulsa yang akan dibeli"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.DDCounter.My.Resources.Resources.notification_warning
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 37)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 70)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'SkypeButton3
        '
        Me.SkypeButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SkypeButton3.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton3.Customization = ""
        Me.SkypeButton3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton3.Image = Nothing
        Me.SkypeButton3.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton3.Location = New System.Drawing.Point(12, 223)
        Me.SkypeButton3.Name = "SkypeButton3"
        Me.SkypeButton3.NoRounding = False
        Me.SkypeButton3.Size = New System.Drawing.Size(84, 32)
        Me.SkypeButton3.TabIndex = 27
        Me.SkypeButton3.Text = "Batal"
        Me.SkypeButton3.Text_Margin_Left = 18
        Me.SkypeButton3.Transparent = False
        '
        'frmlagi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DDCounter.My.Resources.Resources.blackwhite2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(589, 264)
        Me.ControlBox = False
        Me.Controls.Add(Me.SkypeButton3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.SkypeButton2)
        Me.Controls.Add(Me.lblpesan)
        Me.Controls.Add(Me.SkypeButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmlagi"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SkypeButton2 As DDCounter.SkypeButton
    Friend WithEvents lblpesan As System.Windows.Forms.Label
    Friend WithEvents SkypeButton1 As DDCounter.SkypeButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SkypeButton3 As DDCounter.SkypeButton
End Class
