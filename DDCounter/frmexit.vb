Imports MySql.Data.MySqlClient
Public Class frmexit
    Private Sub SkypeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton1.Click
        Call atur()
        Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        Dim strsql As String = "select id,pwd from pengguna where pwd='" & computeHash(txtpwd.Text) & "' and id=1"
        objConnection2.Close()
        objConnection2.Open()
        Dim da As New MySqlDataAdapter(strsql, objConnection2)
        Dim objcommand = New MySql.Data.MySqlClient.MySqlCommand(strsql, objConnection2)
        cek = objcommand.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            If restartatauexit = "X" Then
                Application.Exit()
            Else
                Me.Close()
                frmMenu.WindowState = FormWindowState.Minimized
            End If
        Else
            MessageBox.Show("Password salah !!", "Set Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        txtpwd.Text = ""
    End Sub

    Private Sub SkypeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton2.Click
        Me.Close()
    End Sub

    Private Sub txtpwd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpwd.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            SkypeButton1_Click(Me, EventArgs.Empty)
        End If
    End Sub
End Class