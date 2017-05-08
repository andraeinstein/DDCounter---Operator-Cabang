Imports MySql.Data.MySqlClient
Public Class frmMenu
    Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")

    'Kill proses untuk pindah tab
    Private Sub Form1_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        KeyboardJammer.Jam()
    End Sub

    Private Sub Form1_HandleDestroyed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleDestroyed
        KeyboardJammer.UnJam()
    End Sub

    'End proses pindah tab
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
        Timer1.Start()
        lagi = "no"
        tool.SetToolTip(btndep, "Pilih tombol ini jika ingin deposit.")
        tool.SetToolTip(btnpul, "Pilih tombol ini jika ingin pembelian / isi pulsa.")
        tool.SetToolTip(SkypeButton1, "Tombol untuk keluar")
        tool.SetToolTip(SkypeButton2, "Tombol untuk Restart Program")

        Call atur()
        Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        objConnection2.Close()
        objConnection2.Open()
        Dim strsql As String = "select infoclient,status from informasi where id=1"
        Dim cmd As New MySqlCommand(strsql, objConnection2)
        objDataReader = cmd.ExecuteReader
        objDataReader.Read()
        If objDataReader("status").ToString = "aktif" Then
            lblinfo.Text = objDataReader("infoclient").ToString
            objConnection2.Close()
            timerkanan.Enabled = True
        Else
            timerkanan.Enabled = False
        End If
    End Sub

    Private Sub btndep_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndep.Click
        Call atur()
        objConnection2.Close()
        objConnection2.Open()
        Dim strsql As String = "select id,pwd from pengguna where id=2"
        Dim cmd As New MySqlCommand(strsql, objConnection2)
        objDataReader = cmd.ExecuteReader
        objDataReader.Read()
        If objDataReader("pwd").ToString = "kunci" Then
            frmgagal.lblpesan.Text = "Aplikasi ini terkunci !"
            frmgagal.ShowDialog()
        Else
            frmlogin.txtid.Focus()
            frmlogin.ShowDialog()
        End If
    End Sub

    Private Sub btnpul_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnpul.Click
        Call atur()
        objConnection2.Close()
        objConnection2.Open()
        Dim strsql As String = "select id,pwd from pengguna where id=2"
        Dim cmd As New MySqlCommand(strsql, objConnection2)
        objDataReader = cmd.ExecuteReader
        objDataReader.Read()
        If objDataReader("pwd").ToString = "kunci" Then
            frmgagal.lblpesan.Text = "Aplikasi ini terkunci !"
            frmgagal.ShowDialog()
        Else
            With frmkartu
                .FormBorderStyle = Windows.Forms.FormBorderStyle.None
                .Timer1.Start()
                .lblmbuh.Visible = False
                .lbljumlah.Visible = False
                .btnbatal.Visible = False
                .btnlihat.Visible = False
                .btnkembali.Visible = True
                .ShowDialog()
            End With
        End If
    End Sub

    Private Sub SkypeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton1.Click
        restartatauexit = "X"
        frmexit.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblwaktu.Text = Now
    End Sub

    Private Sub timerkanan_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles timerkanan.Tick
        If lblinfo.Left <= -Me.Width Then
            lblinfo.Left = Me.Width
        Else
            lblinfo.Left = lblinfo.Left - 3
        End If
    End Sub

    Private Sub SkypeButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton2.Click
        restartatauexit = "_"
        frmexit.ShowDialog()
    End Sub

End Class
