Imports MySql.Data.MySqlClient
Public Class frmlihatpulsa

    Private Sub frmlihatpulsa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call atur()
        Dim objConnection As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        objConnection.Close()
        objConnection.Open()
        Dim strsql2 As String = "select tampung.id_trx as ID, operator.nama as Operator, harga.denom as Nominal, tampung.no_tujuan as Nomor" _
                                & ", tampung.harga as Harga from tampung, harga, operator where tampung.kode_produk = harga.kode_produk " _
                                & "and harga.id_operator=operator.id_operator"
        Dim cmd As New MySqlCommand(strsql2, objConnection)
        Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da2.Fill(dt)
        DataGridView1.DataSource = dt
        objConnection.Close()
    End Sub

    Private Sub SkypeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton1.Click
        Me.Close()
    End Sub
End Class