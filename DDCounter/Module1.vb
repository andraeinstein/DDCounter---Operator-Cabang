Imports MySql.Data.MySqlClient
Imports DDCounter.IniFile
Module Module1
    Dim inifile As IniFile
    Public ip As String
    Public lagi As String = "no"
    Public transaksi As String = "pulsa"
    Public urutid As Integer
    Public idtrxpul As Integer
    Public restartatauexit As String
    Public jumlahdata
    Public cellklik As Integer
    Public cetaknota As String
    Public printcustop

    Public Sub atur()
        inifile = New IniFile
        inifile.Load(Application.StartupPath + "/setting.ini")
        ip = inifile.GetKeyValue("setting", "ip")
    End Sub

    Public objCommand As MySqlCommand
    Public objDataSet As New DataSet
    Public objDataTable As New DataTable
    Public objDataReader As MySqlDataReader
    Public objDataAdapter As New MySqlDataAdapter
    Public StrSQL As String
    Public Username, Password, mProcess As String
    Public cur As New Form
    Public Msg As Integer
    Public db, user, pwd As String
    Public myConnectionString As String
    Public cek As MySqlDataReader
    Public ds As New DataSet
    Public tool As New ToolTip()

    Public Function Terbilang(ByVal nilai As Long) As String
        Dim bilangan As String() = {"", "satu", "dua", "tiga", "empat", "lima", _
        "enam", "tujuh", "delapan", "sembilan", "sepuluh", "sebelas"}
        If nilai < 12 Then
            Return " " & bilangan(nilai)
        ElseIf nilai < 20 Then
            Return Terbilang(nilai - 10) & " belas"
        ElseIf nilai < 100 Then
            Return (Terbilang(CInt((nilai \ 10))) & " puluh") + Terbilang(nilai Mod 10)
        ElseIf nilai < 200 Then
            Return " seratus" & Terbilang(nilai - 100)
        ElseIf nilai < 1000 Then
            Return (Terbilang(CInt((nilai \ 100))) & " ratus") + Terbilang(nilai Mod 100)
        ElseIf nilai < 2000 Then
            Return " seribu" & Terbilang(nilai - 1000)
        ElseIf nilai < 1000000 Then
            Return (Terbilang(CInt((nilai \ 1000))) & " ribu") + Terbilang(nilai Mod 1000)
        ElseIf nilai < 1000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000))) & " juta") + Terbilang(nilai Mod 1000000)
        ElseIf nilai < 1000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000))) & " milyar") + Terbilang(nilai Mod 1000000000)
        ElseIf nilai < 1000000000000000 Then
            Return (Terbilang(CInt((nilai \ 1000000000000))) & " triliun") + Terbilang(nilai Mod 1000000000000)
        Else
            Return ""
        End If
    End Function

    Public Function computeHash(ByVal textToHash As String) As String
        '//dibawah ini adalah sebuah fungsi untuk mengenkripsi text dengan metode MD5
        Dim MD5 As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim Bytes() As Byte = MD5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(textToHash))
        Dim s As String = Nothing
        For Each by As Byte In Bytes
            s += by.ToString("x2")
        Next
        Return s
    End Function
End Module
