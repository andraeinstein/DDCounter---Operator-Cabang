Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Public Class frmbayar
    Dim second As Integer = 1
    Dim detik As Integer = 1
    Dim cekpass As String
    Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")

    Sub inputtransaksi()
        Dim i As Integer = DataGridView1.CurrentRow.Index
        objConnection2.Close()
        objConnection2.Open()
        objCommand.CommandType = CommandType.Text
        objCommand.CommandText = "insert into transaksi(tgl_trx,jumlah,kode_trx,ket,nota) values(now(),0,2,''," & lblnota.Text & ")"
        objCommand.CommandTimeout = 0
        objCommand.ExecuteNonQuery()
    End Sub

    Sub inputtransaksipulsa()
        Dim i As Integer = DataGridView1.CurrentRow.Index
        objCommand.CommandText = "insert into counter_pulsa.transaksi_pulsa(id_trx,kode_produk,no_tujuan,suplier) " _
            & "select t.id_trx,t.kode_produk,t.no_tujuan,s.id_suplier from harga.tampung t, " _
            & "counter_pulsa.suplier s where s.jenis=1"
        objCommand.CommandTimeout = 0
        objCommand.ExecuteNonQuery()
    End Sub

    Sub inputoutbox()
        Dim i As Integer = DataGridView1.CurrentRow.Index
        objCommand.CommandText = "insert into counter_pulsa.sms_outbox(tgl_sms,tgl_input,no_hp,nama,pesan,com) " _
            & "select now(),now(),s.no_hp,s.nama,concat(t.kode_produk,'.',t.no_tujuan,';',s.pin),s.port " _
            & "from counter_pulsa.suplier s, harga.tampung t where s.jenis=1"
        objCommand.CommandTimeout = 0
        objCommand.ExecuteNonQuery()
    End Sub

    Sub inputdepo()
        Call atur()
        Dim objConnection As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='counter_pulsa'")
        objConnection.Close()
        objConnection.Open()
        objCommand = New MySqlCommand
        objCommand.Connection = objConnection
        objCommand.CommandType = CommandType.Text
        objCommand.CommandText = "insert into transaksi(tgl_trx,jumlah,kode_trx,ket,nota) values(now(),'" & txtdepo.Text & "',1,''," & lblnota.Text & ")"
        objCommand.CommandTimeout = 0
        Dim rsl As Integer = objCommand.ExecuteNonQuery
        objCommand.CommandText = "insert into transaksi_deposit(id_trx,id_member,nama,suplier) select last_insert_id(),'" & txtid.Text & "','" & txtnama.Text & "',2 from suplier where jenis=0"
        objCommand.CommandTimeout = 0
        Dim rsl2 As Integer = objCommand.ExecuteNonQuery
        objCommand.CommandText = "insert into sms_outbox(tgl_sms,tgl_input,no_hp,nama,pesan,com) select now(),now(),no_hp,nama,concat('INFO.TRANSFER." & txtid.Text & "." & txtdepo.Text & ".',pin),port from suplier where jenis=0"
        objCommand.CommandTimeout = 0
        Dim rsl3 As Integer = objCommand.ExecuteNonQuery
        If rsl > 0 And rsl2 > 0 And rsl3 > 0 Then
            objConnection.Close()
        End If
    End Sub

    Sub hapustampung()
        Call atur()
        Dim objConnection As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        objConnection.Close()
        objConnection.Open()
        objCommand = New MySqlCommand
        objCommand.Connection = objConnection
        objCommand.CommandType = CommandType.Text
        objCommand.CommandText = "truncate tampung"
        objCommand.CommandTimeout = 0
        objCommand.ExecuteNonQuery()
        objConnection.Close()
    End Sub

    Sub cekpassword()
        Dim cek As MySqlDataReader
        Dim objConnection As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        Dim strsql As String = "select id,kata_awal from passotoritas where kata_awal='" & computeHash(Regex.Replace(txtpass.Text, "[^A-Za-z]", String.Empty)) & "' and id=1"
        objConnection.Close()
        objConnection.Open()
        Dim da As New MySqlDataAdapter(strsql, objConnection)
        Dim objcommand = New MySql.Data.MySqlClient.MySqlCommand(strsql, objConnection)
        cek = objcommand.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            Try
                If Regex.Replace(txtpass.Text, "[^0-9]", String.Empty) = Date.Today.Day Then
                    cekpass = "benar"
                Else
                    cekpass = "salah"
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub gantitulisan()
        lblpesan.ForeColor = Color.Blue
        lblpesan.Text = "Transaksi telah di terima dan segera diproses !!"
        lblproses.Visible = False
        Timer3.Start()
        Timer2.Stop()
        lblpesan.Visible = True
        PictureBox1.BackgroundImage = DDCounter.My.Resources.Resources.notification_done
    End Sub

    Sub cek()
        Call atur()
        'objConnection2.Close()
        objConnection2.Open()
        Dim strsql As String = "select ket from akses"
        Dim cmd As New MySqlCommand(strsql, objConnection2)
        objDataReader = cmd.ExecuteReader
        objDataReader.Read()
        If objDataReader("ket").ToString = "beres" Then
            objDataReader.Close()
            objConnection2.Close()
            objConnection2.Dispose()

            objConnection2.Open()
            objCommand = New MySqlCommand
            objCommand.Connection = objConnection2
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = "update akses set ket='siap'"
            objCommand.CommandTimeout = 0
            objCommand.ExecuteNonQuery()
            objConnection2.Close()
            Call gantitulisan()
        ElseIf objDataReader("ket").ToString = "benar" Then
            objDataReader.Close()
            objConnection2.Close()
            objConnection2.Dispose()

            objConnection2.Open()
            objCommand = New MySqlCommand
            objCommand.Connection = objConnection2
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = "update akses set ket='siap'"
            objCommand.CommandTimeout = 0
            objCommand.ExecuteNonQuery()
            objConnection2.Close()
            objConnection2.Dispose()
            Call gantitulisan()
            frmdepo.Close()
        ElseIf objDataReader("ket").ToString = "batal" Then
            objDataReader.Close()
            objConnection2.Close()
            objConnection2.Dispose()
            'frmgagal.lblpesan.Text = "Transaksi telah dibatalkan !"
            'frmgagal.ShowDialog()
            lblpesan.Text = "Transaksi telah dibatalkan !!"
            lblproses.Visible = False
            Timer3.Start()
            Timer2.Stop()
            lblpesan.Visible = True
            PictureBox1.BackgroundImage = DDCounter.My.Resources.Resources.notification_error
        End If
        objConnection2.Close()
        objConnection2.Dispose()
    End Sub

    Private Sub frmbayar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim total As Integer
        PictureBox1.BackgroundImage = DDCounter.My.Resources.Resources.notification_warning
        'Timer1.Start()
        'Timer2.Start()
        'untuk transaksi beli pulsa
        If transaksi = "pulsa" Then
            Groupdepo.Visible = False
            objConnection2.Close()
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

            For Each dgvRow As DataGridViewRow In DataGridView1.Rows
                If Not dgvRow.IsNewRow Then
                    total += CInt(dgvRow.Cells(4).Value)
                End If
            Next
            lbltotal.Text = total
            lblpesan.ForeColor = Color.Red
            lblpesan.Text = "Silahkan bayar Rp " & lbltotal.Text & ",- ke kasir !"
            lblproses.Visible = True

            GroupBox1.Text = "Informasi Pembelian Pulsa"
            lblinformasi.Text = "Daftar pulsa yang dibeli"
            lblproses.Text = "Proses pengisian pulsa akan dilakukan setelah anda membayar sejumlah uang ........"
            txtterbilang.Text = Terbilang(total) + " Rupiah"
        Else
            'untuk deposit
            Groupdepo.Visible = True
            txtid.Text = frmdepo.txtid.Text
            txtnama.Text = frmdepo.txtnama.Text
            txtdepo.Text = frmdepo.txtjumlah.Text
            objConnection2.Close()
            objConnection2.Open()
            Dim strsql2 As String = "select idres 'ID Reseller',nama Nama,depo 'Jumlah Deposit' from tampung2"
            Dim cmd As New MySqlCommand(strsql2, objConnection2)
            Dim da2 As MySqlDataAdapter = New MySqlDataAdapter(cmd)
            Dim dt As New DataTable()
            da2.Fill(dt)
            DataGridView1.DataSource = dt
            objConnection2.Close()

            For Each dgvRow As DataGridViewRow In DataGridView1.Rows
                If Not dgvRow.IsNewRow Then
                    total += CInt(dgvRow.Cells(2).Value)
                End If
            Next
            lbltotal.Text = total
            lblpesan.ForeColor = Color.Red
            lblpesan.Text = "Silahkan bayar Rp " & lbltotal.Text & ",- ke kasir !"
            lblproses.Visible = True

            GroupBox1.Text = "Informasi Deposit"
            lblinformasi.Text = "Informasi uang deposit"
            lblproses.Text = "Proses penambahan deposit akan dilakukan setelah anda menyerahkan sejumlah uang."
            txtterbilang.Text = Terbilang(total) + " Rupiah"
        End If
        objConnection2.Close()
        objConnection2.Dispose()

        jumlahdata = DataGridView1.Rows.Count

        objConnection2.Open()
        StrSQL = "select (t.nota)+1 as nota from counter_pulsa.transaksi t where kode_trx=2 or kode_trx=3 order by t.id_trx desc limit 1"
        Dim da As New MySqlDataAdapter(StrSQL, objConnection2)
        Dim objcommand = New MySql.Data.MySqlClient.MySqlCommand(StrSQL, objConnection2)
        objDataReader = objcommand.ExecuteReader
        objDataReader.Read()
        If objDataReader.HasRows Then
            lblnota.Text = objDataReader("nota")
        Else
            lblnota.Text = 1
        End If
        objConnection2.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        'second = second - 1
        'If second = 0 Then
        '    cek()
        '    second = 1
        'End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If lblpesan.Visible = True Then
            lblpesan.Visible = False
        ElseIf lblpesan.Visible = False Then
            lblpesan.Visible = True
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        detik = detik + 1
        If detik = 8 Then
            detik = 1
            Timer3.Stop()
            Me.Close()
            Timer2.Start()
        End If
    End Sub

    Private Sub SkypeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton1.Click
        'Call atur()
        Call cekpassword()
        Dim objConnection As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        If cekpass = "benar" Then
            'Try
            objConnection.Close()
            objConnection.Open()
            objCommand = New MySqlCommand
            objCommand.Connection = objConnection
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = "update akses set ket='beres'"
            objCommand.CommandTimeout = 0
            Dim rsl As Integer = objCommand.ExecuteNonQuery()
            If rsl > 0 Then
                Dim i As Integer = DataGridView1.CurrentRow.Index
                Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='counter_pulsa'")
                objConnection2.Close()
                objConnection2.Open()
                objCommand = New MySqlCommand
                objCommand.Connection = objConnection2

                If transaksi = "pulsa" Then
                    For a As Integer = 1 To jumlahdata
                        Call inputtransaksi()
                    Next
                    Call inputtransaksipulsa()
                    Call inputoutbox()
                    Call hapustampung()
                Else
                    Call inputdepo()
                End If

                objConnection.Close()
                objConnection2.Close()
            End If
            Call gantitulisan()
            'Me.Close()
            jumlahdata = DataGridView1.RowCount
            If transaksi = "pulsa" Then
                struk.ShowDialog()
            Else
                strukdepo.ShowDialog()
            End If
        Else
            MessageBox.Show("Password salah !!", "Set Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub SkypeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton2.Click
        Call atur()
        Dim objConnection As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        If transaksi = "pulsa" Then
            objConnection.Close()
            objConnection.Open()
            objCommand = New MySqlCommand
            objCommand.Connection = objConnection
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = "update harga.akses set ket='batal'"
            objCommand.CommandTimeout = 0
            Dim rsl As Integer = objCommand.ExecuteNonQuery()
            If rsl > 0 Then
                MessageBox.Show("Pembelian pulsa telah dibatalkan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
                objConnection.Close()
            End If
            Call hapustampung()
        Else
            MessageBox.Show("Penambahan saldo deposit telah dibatalkan !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            objConnection.Close()
        End If
        
    End Sub
End Class