Imports MySql.Data.MySqlClient
Public Class frminfo

    Private Sub SkypeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton1.Click
        If transaksi = "pulsa" Then
            urutid = urutid + 1
            Call atur()
            Dim objConnection As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='counter_pulsa'")
            Dim strsql As String = "select id_trx from transaksi order by id_trx desc limit 1"
            objConnection.Close()
            objConnection.Open()
            Dim da As New MySqlDataAdapter(strsql, objConnection)
            Dim objcommand = New MySql.Data.MySqlClient.MySqlCommand(strsql, objConnection)
            objDataReader = objcommand.ExecuteReader
            objDataReader.Read()
            If objDataReader.HasRows Then
                idtrxpul = objDataReader("id_trx") + urutid
                objConnection.Close()
            End If
            objConnection.Close()
            objConnection.Dispose()

            Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
            objConnection2.Close()
            objConnection2.Open()
            objcommand = New MySqlCommand
            objCommand.Connection = objConnection2
            objcommand.CommandType = CommandType.Text
            objcommand.CommandText = "insert into tampung(id_trx,kode_produk,no_tujuan,harga) values(" & idtrxpul & ",'" & frmbeli.DataGridView1.Item(3, frmbeli.DataGridView1.CurrentRow.Index).Value & "','" & frmbeli.txtnomor.Text & "'," & frmbeli.DataGridView1.Item(2, frmbeli.DataGridView1.CurrentRow.Index).Value & ")"
            objcommand.CommandTimeout = 0
            Dim rsl2 As Integer = objcommand.ExecuteNonQuery()
            If rsl2 > 0 Then
                frmlagi.ShowDialog()
                objConnection2.Close()
            End If
            objConnection2.Close()
            objConnection2.Dispose()
            Me.Close()
        Else
            Call atur()
            Dim objConnection As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='counter_pulsa'")
            objConnection.Close()
            objConnection.Open()
            objCommand = New MySqlCommand
            objCommand.Connection = objConnection
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = "update harga.akses set ket='depo'"
            objCommand.CommandTimeout = 0
            objCommand.ExecuteNonQuery()
            objConnection.Close()
            objConnection.Dispose()

            objConnection.Open()
            objCommand = New MySqlCommand
            objCommand.Connection = objConnection
            objCommand.CommandType = CommandType.Text
            objCommand.CommandText = "update harga.tampung2 set idres='" & frmdepo.txtid.Text & "', nama='" & frmdepo.txtnama.Text & "', depo=" & frmdepo.txtjumlah.Text & ""
            objCommand.CommandTimeout = 0
            objCommand.ExecuteNonQuery()
            Dim rsl2 As Integer = objCommand.ExecuteNonQuery()
            If rsl2 > 0 Then
                objConnection.Close()
                objConnection.Dispose()
                frmbayar.lblpesan.Text = "Silakan bayar Rp " & frmdepo.txtjumlah.Text & ",- ke kasir !"
                frmbayar.ShowDialog()
            End If
            objConnection.Close()
            objConnection.Dispose()
            Me.Close()
        End If
    End Sub

    Private Sub SkypeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton2.Click
        Me.Close()
    End Sub

End Class