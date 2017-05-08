Imports MySql.Data.MySqlClient
Public Class frmlogin

    Private Sub SkypeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton1.Click
        If txtid.Text = Nothing And txtpin.Text = Nothing Then
            MessageBox.Show("Data tidak lengkap !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Call atur()
                Dim objConnection As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='counter_pulsa'")
                Dim strsql As String = "select id_member, nama, alamat, pin, saldo, status from federated_federated_member where id_member='" & txtid.Text & "' and pin='" & txtpin.Text & "' and status=1"
                objConnection.Close()
                objConnection.Open()
                Dim da As New MySqlDataAdapter(strsql, objConnection)
                Dim objcommand = New MySql.Data.MySqlClient.MySqlCommand(strsql, objConnection)
                cek = objcommand.ExecuteReader
                cek.Read()
                If cek.HasRows Then
                    frmsukses.lblpesan.Text = "Selamat datang " & cek("nama").ToString & " !!"
                    frmsukses.ShowDialog()
                    frmdepo.txtid.Text = cek("id_member").ToString
                    frmdepo.txtnama.Text = cek("nama").ToString
                    frmdepo.txtalamat.Text = cek("alamat").ToString
                    txtid.Text = Nothing
                    txtpin.Text = Nothing
                    Me.Close()
                    frmdepo.ShowDialog()
                Else
                    MessageBox.Show("Maaf, ID atau Pin anda salah !", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub SkypeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton2.Click
        Me.Close()
    End Sub

    Private Sub frmlogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtid.Focus()
        Me.SuspendLayout()
        Me.ResumeLayout()
    End Sub

    Private Sub txtid_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtid.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SkypeButton1_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub txtpin_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpin.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SkypeButton1_Click(Me, EventArgs.Empty)
        End If
    End Sub
End Class