<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmsukses
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
        Me.SkypeButton1 = New DDCounter.SkypeButton()
        Me.lblpesan = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SkypeButton1
        '
        Me.SkypeButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SkypeButton1.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton1.Customization = ""
        Me.SkypeButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton1.Image = Nothing
        Me.SkypeButton1.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton1.Location = New System.Drawing.Point(345, 88)
        Me.SkypeButton1.Name = "SkypeButton1"
        Me.SkypeButton1.NoRounding = False
        Me.SkypeButton1.Size = New System.Drawing.Size(84, 32)
        Me.SkypeButton1.TabIndex = 13
        Me.SkypeButton1.Text = "OK"
        Me.SkypeButton1.Text_Margin_Left = 25
        Me.SkypeButton1.Transparent = False
        '
        'lblpesan
        '
        Me.lblpesan.Font = New System.Drawing.Font("Lucida Sans Unicode", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpesan.Location = New System.Drawing.Point(87, 10)
        Me.lblpesan.Name = "lblpesan"
        Me.lblpesan.Size = New System.Drawing.Size(341, 70)
        Me.lblpesan.TabIndex = 14
        Me.lblpesan.Text = "Label1"
        Me.lblpesan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.DDCounter.My.Resources.Resources.notification_done
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(9, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(77, 70)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'frmsukses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(438, 126)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblpesan)
        Me.Controls.Add(Me.SkypeButton1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmsukses"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SkypeButton1 As DDCounter.SkypeButton
    Friend WithEvents lblpesan As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
