Imports MySql.Data.MySqlClient
Public Class frmkartu
    Sub pertama()
        btnaxis.Visible = True
        btnceria.Visible = True
        btnesia.Visible = True
        btnflexi.Visible = True
        btnhepi.Visible = True
        btnindosat.Visible = True
        btnpln.Visible = True
        btnsmart.Visible = True
        btnstarone.Visible = True
        btntelkomsel.Visible = True
        btntri.Visible = True
        btnxl.Visible = True
        btnxlinternet.Visible = False
        btnbb.Visible = False
    End Sub
    Sub kedua()
        btnaxis.Visible = False
        btnceria.Visible = False
        btnesia.Visible = False
        btnflexi.Visible = False
        btnhepi.Visible = False
        btnindosat.Visible = False
        btnpln.Visible = False
        btnsmart.Visible = False
        btnstarone.Visible = False
        btntelkomsel.Visible = False
        btntri.Visible = False
        btnxl.Visible = False
        btnxlinternet.Visible = True
        btnbb.Visible = True
    End Sub
    Sub tampilharga()
        Call atur()
        Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        objConnection2.Open()
        Dim strsql As String = "select distinct ha.denom as Denom, if(right(ha.denom,1)=1,'SMS',if(right(ha.denom,1)=2,'Internet'," _
                               & "'Regular')) as 'Tipe', ha.harga as Harga,ha.kode_produk from harga as ha, hlrid as h, " _
                               & "operator as o, kartu as k where o.nama = '" & frmbeli.lbloperator.Text & "' and " _
                               & "h.id_kartu=k.id_kartu and o.id_operator=k.id_operator and (o.nama=o.nama and " _
                               & "o.id_operator=ha.id_operator) order by ha.denom asc"
        Dim cmd As New MySqlCommand(strsql, objConnection2)
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        frmbeli.DataGridView1.DataSource = dt
        objConnection2.Close()
        frmbeli.txtnomor.Text = Nothing
    End Sub
    Private Sub frmkartu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Call pertama()
    End Sub

    Private Sub SkypeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnkembali.Click
        Me.Close()
    End Sub

    Private Sub btnindosat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnindosat.Click
        frmbeli.lbloperator.Text = "INDOSAT"
        frmbeli.txtjenis.Text = "INDOSAT"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub btnxl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxl.Click
        frmbeli.lbloperator.Text = "PROXL"
        frmbeli.txtjenis.Text = "PROXL"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub btntelkomsel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntelkomsel.Click
        frmbeli.lbloperator.Text = "TELKOMSEL"
        frmbeli.txtjenis.Text = "TELKOMSEL"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub btntri_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntri.Click
        frmbeli.lbloperator.Text = "THREE"
        frmbeli.txtjenis.Text = "THREE"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub btnesia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnesia.Click
        frmbeli.lbloperator.Text = "ESIA"
        frmbeli.txtjenis.Text = "ESIA"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub btnsmart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsmart.Click
        frmbeli.lbloperator.Text = "SMART"
        frmbeli.txtjenis.Text = "SMART"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub btnflexi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnflexi.Click
        frmbeli.lbloperator.Text = "FLEXI"
        frmbeli.txtjenis.Text = "FLEXI"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub btnstarone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnstarone.Click
        frmbeli.lbloperator.Text = "STARONE"
        frmbeli.txtjenis.Text = "STARONE"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub btnceria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnceria.Click
        frmbeli.lbloperator.Text = "CERIA"
        frmbeli.txtjenis.Text = "CERIA"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub btnhepi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnhepi.Click
        frmbeli.lbloperator.Text = "HEPI"
        frmbeli.txtjenis.Text = "HEPI"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub btnpln_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpln.Click
        frmbeli.lbloperator.Text = "PLN"
        frmbeli.txtjenis.Text = "PLN"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblwaktu.Text = Now
    End Sub

    Private Sub btnlihat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlihat.Click
        frmlihatpulsa.ShowDialog()
    End Sub

    Private Sub btnbatal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbatal.Click
        lbljumlah.Text = lbljumlah.Text - 1
        lbljumlah.Visible = False
        lblmbuh.Visible = False
        btnlihat.Visible = False
        btnbatal.Visible = False
        btnpilihanlain.Visible = True
        lagi = "no"
        frmlagi.ShowDialog()
    End Sub

    Private Sub btnaxis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaxis.Click
        frmbeli.lbloperator.Text = "AXIS"
        frmbeli.txtjenis.Text = "AXIS"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If Label3.Visible = True Then
            Label3.Visible = False
        ElseIf Label3.Visible = False Then
            Label3.Visible = True
        End If
    End Sub

    Private Sub btnpilihanlain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpilihanlain.Click
        If btnpilihanlain.Text = "Pilihan Operator Lain >>" Then
            Call kedua()
            btnpilihanlain.Text = "<< Pilihan Operator Lain"
        Else
            Call pertama()
            btnpilihanlain.Text = "Pilihan Operator Lain >>"
        End If

    End Sub

    Private Sub btnxlinternet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnxlinternet.Click
        frmbeli.lbloperator.Text = "XL INTERNET"
        frmbeli.txtjenis.Text = "PROXL"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub

    Private Sub btnbb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnbb.Click
        frmbeli.lbloperator.Text = "XL BB"
        frmbeli.txtjenis.Text = "PROXL"
        tampilharga()
        frmbeli.ShowDialog()
    End Sub
End Class