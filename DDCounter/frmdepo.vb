Imports MySql.Data.MySqlClient

Public Class frmdepo
    Private Sub btnok_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnok.Click
        If txtjumlah.Text = Nothing Then
            frmgagal.lblpesan.Text = "Isilah jumlah deposit terlebih dahulu !"
            frmgagal.ShowDialog()
        Else
            transaksi = "depo"
            frminfo.lblpesan.Text = "Deposit sejumlah Rp. " & txtjumlah.Text & " ?"
            frminfo.ShowDialog()
        End If
    End Sub

    Private Sub frmdepo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tool.SetToolTip(btnok, "Pilih tombol ini untuk memproses deposit.")
        tool.SetToolTip(btnout, "Pilih tombol ini untuk keluar.")
    End Sub

    Private Sub txtjumlah_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtjumlah.KeyPress
        'Textbox hanya boleh diisi angka
        If Char.IsDigit(e.KeyChar) = False And Char.IsControl(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = Convert.ToChar(13) Then
            btnok_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub txtjumlah_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtjumlah.TextChanged
        Try
            If String.IsNullOrEmpty(txtjumlah.Text) Then
                txtjumlah.Text = Nothing
                txtterbilang.Text = Nothing
            Else
                txtterbilang.Text = Terbilang(txtjumlah.Text) + "rupiah"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnout.Click
        Me.Close()
        MessageBox.Show("Terima kasih telah bertransaksi bersama kami...", "Thanks..", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class