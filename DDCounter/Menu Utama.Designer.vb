<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenu
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.timerkanan = New System.Windows.Forms.Timer(Me.components)
        Me.TeamViewerTheme1 = New DDCounter.TeamViewerTheme()
        Me.SkypeButton2 = New DDCounter.SkypeButton()
        Me.lblinfo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblwaktu = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkypeButton1 = New DDCounter.SkypeButton()
        Me.btndep = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TutupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AltTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TaskManagerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WIndowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnpul = New System.Windows.Forms.Button()
        Me.TeamViewerTheme1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'timerkanan
        '
        Me.timerkanan.Interval = 50
        '
        'TeamViewerTheme1
        '
        Me.TeamViewerTheme1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TeamViewerTheme1.Controls.Add(Me.SkypeButton2)
        Me.TeamViewerTheme1.Controls.Add(Me.lblinfo)
        Me.TeamViewerTheme1.Controls.Add(Me.Label4)
        Me.TeamViewerTheme1.Controls.Add(Me.Label3)
        Me.TeamViewerTheme1.Controls.Add(Me.lblwaktu)
        Me.TeamViewerTheme1.Controls.Add(Me.Label2)
        Me.TeamViewerTheme1.Controls.Add(Me.Label1)
        Me.TeamViewerTheme1.Controls.Add(Me.SkypeButton1)
        Me.TeamViewerTheme1.Controls.Add(Me.btndep)
        Me.TeamViewerTheme1.Controls.Add(Me.MenuStrip1)
        Me.TeamViewerTheme1.Controls.Add(Me.btnpul)
        Me.TeamViewerTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TeamViewerTheme1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.TeamViewerTheme1.Image = Nothing
        Me.TeamViewerTheme1.Location = New System.Drawing.Point(0, 0)
        Me.TeamViewerTheme1.MoveHeight = 19
        Me.TeamViewerTheme1.Name = "TeamViewerTheme1"
        Me.TeamViewerTheme1.Resizable = True
        Me.TeamViewerTheme1.Size = New System.Drawing.Size(982, 641)
        Me.TeamViewerTheme1.TabIndex = 0
        Me.TeamViewerTheme1.Text = "TeamViewerTheme1"
        Me.TeamViewerTheme1.TransparencyKey = System.Drawing.Color.Empty
        '
        'SkypeButton2
        '
        Me.SkypeButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SkypeButton2.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton2.Customization = ""
        Me.SkypeButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton2.Image = Nothing
        Me.SkypeButton2.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton2.Location = New System.Drawing.Point(927, 87)
        Me.SkypeButton2.Name = "SkypeButton2"
        Me.SkypeButton2.NoRounding = False
        Me.SkypeButton2.Size = New System.Drawing.Size(24, 32)
        Me.SkypeButton2.TabIndex = 23
        Me.SkypeButton2.Text = "_"
        Me.SkypeButton2.Text_Margin_Left = 0
        Me.SkypeButton2.Transparent = False
        '
        'lblinfo
        '
        Me.lblinfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblinfo.AutoSize = True
        Me.lblinfo.BackColor = System.Drawing.Color.Transparent
        Me.lblinfo.Font = New System.Drawing.Font("Cambria", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblinfo.ForeColor = System.Drawing.Color.Red
        Me.lblinfo.Location = New System.Drawing.Point(953, 604)
        Me.lblinfo.Name = "lblinfo"
        Me.lblinfo.Size = New System.Drawing.Size(17, 28)
        Me.lblinfo.TabIndex = 22
        Me.lblinfo.Text = " "
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(516, 501)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(214, 15)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Tombol ini untuk isi / pembelian pulsa"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Location = New System.Drawing.Point(203, 501)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Tombol ini untuk deposit"
        '
        'lblwaktu
        '
        Me.lblwaktu.AutoSize = True
        Me.lblwaktu.BackColor = System.Drawing.Color.Transparent
        Me.lblwaktu.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaktu.ForeColor = System.Drawing.Color.White
        Me.lblwaktu.Location = New System.Drawing.Point(16, 5)
        Me.lblwaktu.Name = "lblwaktu"
        Me.lblwaktu.Size = New System.Drawing.Size(31, 16)
        Me.lblwaktu.TabIndex = 19
        Me.lblwaktu.Text = "jam"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(852, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "DD-Tronik © 2014"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cambria", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 41)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "DD-Tronik Refill System"
        '
        'SkypeButton1
        '
        Me.SkypeButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SkypeButton1.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton1.Customization = ""
        Me.SkypeButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton1.Image = Nothing
        Me.SkypeButton1.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton1.Location = New System.Drawing.Point(955, 87)
        Me.SkypeButton1.Name = "SkypeButton1"
        Me.SkypeButton1.NoRounding = False
        Me.SkypeButton1.Size = New System.Drawing.Size(24, 32)
        Me.SkypeButton1.TabIndex = 12
        Me.SkypeButton1.Text = "X"
        Me.SkypeButton1.Text_Margin_Left = 0
        Me.SkypeButton1.Transparent = False
        '
        'btndep
        '
        Me.btndep.BackgroundImage = Global.DDCounter.My.Resources.Resources.Budget_icon
        Me.btndep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btndep.Font = New System.Drawing.Font("Centaur", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndep.Location = New System.Drawing.Point(206, 272)
        Me.btndep.Name = "btndep"
        Me.btndep.Size = New System.Drawing.Size(272, 220)
        Me.btndep.TabIndex = 6
        Me.btndep.Text = "DEPOSIT"
        Me.btndep.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TutupToolStripMenuItem, Me.AltTabToolStripMenuItem, Me.TaskManagerToolStripMenuItem, Me.WIndowsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(982, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'TutupToolStripMenuItem
        '
        Me.TutupToolStripMenuItem.Name = "TutupToolStripMenuItem"
        Me.TutupToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.TutupToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.TutupToolStripMenuItem.Text = "Tutup"
        '
        'AltTabToolStripMenuItem
        '
        Me.AltTabToolStripMenuItem.Name = "AltTabToolStripMenuItem"
        Me.AltTabToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Tab), System.Windows.Forms.Keys)
        Me.AltTabToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AltTabToolStripMenuItem.Text = "AltTab"
        '
        'TaskManagerToolStripMenuItem
        '
        Me.TaskManagerToolStripMenuItem.Name = "TaskManagerToolStripMenuItem"
        Me.TaskManagerToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
                    Or System.Windows.Forms.Keys.Delete), System.Windows.Forms.Keys)
        Me.TaskManagerToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
        Me.TaskManagerToolStripMenuItem.Text = "Task Manager"
        '
        'WIndowsToolStripMenuItem
        '
        Me.WIndowsToolStripMenuItem.Name = "WIndowsToolStripMenuItem"
        Me.WIndowsToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.WIndowsToolStripMenuItem.Text = "WIndows"
        '
        'btnpul
        '
        Me.btnpul.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnpul.BackgroundImage = Global.DDCounter.My.Resources.Resources.Buy_now_icon
        Me.btnpul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnpul.Font = New System.Drawing.Font("Centaur", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpul.Location = New System.Drawing.Point(519, 272)
        Me.btnpul.Name = "btnpul"
        Me.btnpul.Size = New System.Drawing.Size(272, 220)
        Me.btnpul.TabIndex = 7
        Me.btnpul.Text = "ISI PULSA"
        Me.btnpul.UseVisualStyleBackColor = True
        '
        'frmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(982, 641)
        Me.Controls.Add(Me.TeamViewerTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DDCounter"
        Me.TeamViewerTheme1.ResumeLayout(False)
        Me.TeamViewerTheme1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TeamViewerTheme1 As DDCounter.TeamViewerTheme
    Friend WithEvents btndep As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents TutupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AltTabToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TaskManagerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WIndowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnpul As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents SkypeButton1 As DDCounter.SkypeButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblwaktu As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblinfo As System.Windows.Forms.Label
    Friend WithEvents timerkanan As System.Windows.Forms.Timer
    Friend WithEvents SkypeButton2 As DDCounter.SkypeButton

End Class
