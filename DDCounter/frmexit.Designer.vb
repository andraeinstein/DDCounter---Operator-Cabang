<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmexit
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
        Me.txtpwd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SkypeButton1 = New DDCounter.SkypeButton()
        Me.SkypeButton2 = New DDCounter.SkypeButton()
        Me.SuspendLayout()
        '
        'txtpwd
        '
        Me.txtpwd.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpwd.Location = New System.Drawing.Point(164, 12)
        Me.txtpwd.Name = "txtpwd"
        Me.txtpwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpwd.Size = New System.Drawing.Size(240, 41)
        Me.txtpwd.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Lucida Sans Unicode", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 27)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Password"
        '
        'SkypeButton1
        '
        Me.SkypeButton1.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton1.Customization = ""
        Me.SkypeButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton1.Image = Nothing
        Me.SkypeButton1.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton1.Location = New System.Drawing.Point(202, 63)
        Me.SkypeButton1.Name = "SkypeButton1"
        Me.SkypeButton1.NoRounding = False
        Me.SkypeButton1.Size = New System.Drawing.Size(98, 32)
        Me.SkypeButton1.TabIndex = 6
        Me.SkypeButton1.Text = "OK"
        Me.SkypeButton1.Text_Margin_Left = 32
        Me.SkypeButton1.Transparent = False
        '
        'SkypeButton2
        '
        Me.SkypeButton2.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton2.Customization = ""
        Me.SkypeButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton2.Image = Nothing
        Me.SkypeButton2.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton2.Location = New System.Drawing.Point(306, 63)
        Me.SkypeButton2.Name = "SkypeButton2"
        Me.SkypeButton2.NoRounding = False
        Me.SkypeButton2.Size = New System.Drawing.Size(98, 32)
        Me.SkypeButton2.TabIndex = 7
        Me.SkypeButton2.Text = "Batal"
        Me.SkypeButton2.Text_Margin_Left = 25
        Me.SkypeButton2.Transparent = False
        '
        'frmexit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DDCounter.My.Resources.Resources.blackwhite2
        Me.ClientSize = New System.Drawing.Size(416, 105)
        Me.ControlBox = False
        Me.Controls.Add(Me.SkypeButton2)
        Me.Controls.Add(Me.SkypeButton1)
        Me.Controls.Add(Me.txtpwd)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmexit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtpwd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SkypeButton1 As DDCounter.SkypeButton
    Friend WithEvents SkypeButton2 As DDCounter.SkypeButton
End Class
