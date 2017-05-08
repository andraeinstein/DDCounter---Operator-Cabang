<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class struk
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblcetak = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.CrystalReport11 = New DDCounter.CrystalReport1()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(359, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 28)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblcetak
        '
        Me.lblcetak.AutoSize = True
        Me.lblcetak.BackColor = System.Drawing.Color.Transparent
        Me.lblcetak.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblcetak.Location = New System.Drawing.Point(185, 450)
        Me.lblcetak.Name = "lblcetak"
        Me.lblcetak.Size = New System.Drawing.Size(128, 13)
        Me.lblcetak.TabIndex = 5
        Me.lblcetak.Text = "Klik OK untuk cetak struk"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.DisplayToolbar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(-1, -1)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.CrystalReport11
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(457, 432)
        Me.CrystalReportViewer1.TabIndex = 2
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'struk
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.DDCounter.My.Resources.Resources.blackwhite
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(455, 472)
        Me.Controls.Add(Me.lblcetak)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Button1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "struk"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Struk Penjualan Pulsa"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents CrystalReport11 As DDCounter.CrystalReport1
    Friend WithEvents lblcetak As System.Windows.Forms.Label
End Class
