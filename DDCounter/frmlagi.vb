Imports MySql.Data.MySqlClient
Public Class frmlagi
    Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
    Dim total As Integer

    Sub loaddata()
        Call atur()
        Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        objConnection2.Open()
        Dim strsql2 As String = "select tampung.id_trx as ID, operator.nama as Operator, harga.denom as Nominal, tampung.no_tujuan as Nomor" _
                                & ", tampung.harga as Harga from tampung, harga, operator where tampung.kode_produk = harga.kode_produk " _
                                & "and harga.id_operator=operator.id_operator"

        Dim cmd As New MySqlCommand(strsql2, objConnection2)
        Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da2.Fill(dt)
        DataGridView1.DataSource = dt
        objConnection2.Close()

        If DataGridView1.Columns.Count < 6 Then
            Dim btn As New DataGridViewButtonColumn()
            DataGridView1.Columns.Add(btn)
            btn.HeaderText = "Hapus Nomor"
            btn.Text = "Hapus"
            btn.Name = "btnhapus"
            btn.UseColumnTextForButtonValue = True
        Else
        End If
    End Sub

    Private Sub SkypeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton1.Click
        Me.Close()
        frmbeli.Close()
        With frmkartu
            .Show()
            .btnpilihanlain.Visible = False
            .lblmbuh.Visible = True
            .lbljumlah.Visible = True
            .btnbatal.Visible = True
            .btnlihat.Visible = True
            .btnkembali.Visible = False
            .lbljumlah.Text = .lbljumlah.Text + 1
        End With
        lagi = "yes"
    End Sub

    Private Sub frmlagi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call loaddata()
    End Sub

    Private Sub SkypeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton2.Click
        If DataGridView1.Rows.Count < 1 Then
            frmgagal.lblpesan.Text = "Tidak ada data, Silakan input nomor HP anda !"
            frmgagal.Show()
        Else
            Call atur()
            objConnection2.Close()
            objConnection2.Open()
            objCommand = New MySqlCommand
            objCommand.Connection = objConnection2
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = "update akses set ket='butuh'"
            objCommand.CommandTimeout = 0
            objCommand.ExecuteNonQuery()
            Me.Close()
            lagi = "no"
            Me.Close()
            frmbeli.Close()
            frmkartu.Close()
            frmbayar.ShowDialog()
            urutid = 0
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        Dim tujuan As String
        Dim idt As String

        If e.ColumnIndex = 5 Then
            tujuan = DataGridView1.Item(3, e.RowIndex).Value.ToString
            idt = DataGridView1.Item(4, e.RowIndex).Value
            objConnection2.Close()
            objConnection2.Open()
            objCommand = New MySqlCommand
            objCommand.Connection = objConnection2
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = "delete from tampung where no_tujuan='" & tujuan & "' and id_trx=" & idt & ""
            objCommand.CommandTimeout = 0
            objCommand.ExecuteNonQuery()
            Call loaddata()
            objConnection2.Close()
            'MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)
        ElseIf e.ColumnIndex = 0 Then
            tujuan = DataGridView1.Item(4, e.RowIndex).Value.ToString
            idt = DataGridView1.Item(1, e.RowIndex).Value.ToString
            objConnection2.Close()
            objConnection2.Open()
            objCommand = New MySqlCommand
            objCommand.Connection = objConnection2
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = "delete from tampung where no_tujuan='" & tujuan & "' and id_trx=" & idt & ""
            objCommand.CommandTimeout = 0
            objCommand.ExecuteNonQuery()
            Call loaddata()
            objConnection2.Close()
            'MsgBox(("Row : " + e.RowIndex.ToString & "  Col : ") + e.ColumnIndex.ToString)
        End If
    End Sub

    Private Sub SkypeButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton3.Click
        Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        objConnection2.Close()
        objConnection2.Open()
        objCommand = New MySqlCommand
        objCommand.Connection = objConnection2
        objCommand.CommandType = CommandType.Text
        objCommand.CommandText = "truncate tampung"
        objCommand.CommandTimeout = 0
        objCommand.ExecuteNonQuery()
        objConnection2.Close()
        frmgagal.lblpesan.Text = "Pembelian Pulsa dibatalkan"
        frmgagal.ShowDialog()
        Me.Close()
        frmbeli.Close()
        frmkartu.Close()
    End Sub
End Class