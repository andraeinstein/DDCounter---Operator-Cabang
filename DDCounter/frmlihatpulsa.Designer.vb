<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmlihatpulsa
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.SkypeButton1 = New DDCounter.SkypeButton()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.DataGridView1.Location = New System.Drawing.Point(7, 8)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(472, 125)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 25
        '
        'SkypeButton1
        '
        Me.SkypeButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.SkypeButton1.Colors = New DDCounter.Bloom(-1) {}
        Me.SkypeButton1.Customization = ""
        Me.SkypeButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.SkypeButton1.Image = Nothing
        Me.SkypeButton1.ImageAllignmentMode = DDCounter.SkypeButton.AllignMode.Left
        Me.SkypeButton1.Location = New System.Drawing.Point(389, 139)
        Me.SkypeButton1.Name = "SkypeButton1"
        Me.SkypeButton1.NoRounding = False
        Me.SkypeButton1.Size = New System.Drawing.Size(90, 32)
        Me.SkypeButton1.TabIndex = 26
        Me.SkypeButton1.Text = "Kembali"
        Me.SkypeButton1.Text_Margin_Left = 12
        Me.SkypeButton1.Transparent = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label4.Location = New System.Drawing.Point(4, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 15)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Daftar pulsa yang akan dibeli"
        '
        'frmlihatpulsa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.DDCounter.My.Resources.Resources.blackwhite2
        Me.ClientSize = New System.Drawing.Size(487, 176)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.SkypeButton1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmlihatpulsa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SkypeButton1 As DDCounter.SkypeButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
