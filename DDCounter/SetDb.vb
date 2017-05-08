Imports DDCounter.IniFile
Imports MySql.Data.MySqlClient
Public Class SetDb
    Dim inifile As IniFile

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        inifile = New IniFile
        With inifile
            .AddSection("setting").AddKey("ip").Value = TextBox1.Text
            .Save(Application.StartupPath + "/setting.ini")
        End With
        Try
            Call atur()
            Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
            Dim strsql As String = "select id,pwd from pengguna where pwd='" & computeHash(txtpwd.Text) & "'"
            objConnection2.Close()
            objConnection2.Open()
            Dim da As New MySqlDataAdapter(strsql, objConnection2)
            Dim objcommand = New MySql.Data.MySqlClient.MySqlCommand(strsql, objConnection2)
            cek = objcommand.ExecuteReader
            cek.Read()
            If cek.HasRows Then
                MsgBox("Koneksi Database Sukses !")
                frmMenu.Show()
                Me.Hide()
            Else
                MessageBox.Show("Password salah !!", "Set Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Database gagal : " & e.ToString)
        End Try
    End Sub

    Private Sub SetDb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        IniFile = New IniFile
        IniFile.Load(Application.StartupPath + "/setting.ini")
        TextBox1.Text = inifile.GetKeyValue("setting", "ip")
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            Button1_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub txtpwd_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpwd.KeyPress
        If e.KeyChar = Convert.ToChar(13) Then
            Button1_Click(Me, EventArgs.Empty)
        End If
    End Sub

End Class