Imports MySql.Data.MySqlClient
Imports CrystalDecisions.Shared
Imports CrystalDecisions.CrystalReports.Engine
Public Class struk
    Dim objRpt As New CrystalReport1()
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Call atur()
        Dim objConnection As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        objConnection.Close()
        objConnection.Open()
        objCommand = New MySqlCommand
        objCommand.Connection = objConnection
        objCommand.CommandType = CommandType.Text
        objCommand.CommandText = "update struk set ket='print'"
        objCommand.CommandTimeout = 0
        Dim rsl As Integer = objCommand.ExecuteNonQuery()
        If rsl > 0 Then
            If printcustop = "customer" Then
                objRpt.PrintToPrinter(1, False, 0, 0)
                Button1.Text = "Print Operator"
                lblcetak.Text = "Cetak Struk untuk Operator"
                printcustop = "operator"
                Dim txtObject As TextObject = DirectCast(objRpt.ReportDefinition.Sections("Section1").ReportObjects("txtcopy"), TextObject)
                txtObject.Text = "~ Copy"
                CrystalReportViewer1.ReportSource = objRpt
                CrystalReportViewer1.Refresh()
                CrystalReportViewer1.Zoom(200)
                Button1.Focus()
            Else
                objRpt.PrintToPrinter(1, False, 0, 0)
                Button1.Text = "Print Customer"
                lblcetak.Text = "Cetak Struk untuk Costumer"
                printcustop = "customer"
                Dim txtObject As TextObject = DirectCast(objRpt.ReportDefinition.Sections("Section1").ReportObjects("txtcopy"), TextObject)
                txtObject.Text = ""
                CrystalReportViewer1.Refresh()
                Me.Close()
                objConnection.Close()
                'Form1.Timer1.Start()
                CrystalReportViewer1.Zoom(200)
            End If
        End If
    End Sub

    Private Sub struk_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub struk_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Button1.Focus()
        Call atur()
        Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='harga'")
        objConnection2.Close()
        objConnection2.Open()
        If cetaknota = "cetak" Then
            Dim strsql As String = "select p.no_tujuan as 'No. Tujuan', concat(o.nama,'-',substring(cast(h.denom as char),1,length(cast(h.denom as char))-3)) as 'Operator', h.harga as 'Harga', t.nota as 'Nota', i.infopulsa as 'Informasi' " _
                                   & "from (counter_pulsa.transaksi_pulsa p,harga.harga h,harga.operator o,harga.informasi i) " _
                                   & "inner join (select t.id_trx,t.nota from counter_pulsa.transaksi t where nota= " & cellklik & " and date(t.tgl_trx)=curdate()) t " _
                                   & "on p.id_trx=t.id_trx and p.kode_produk=h.kode_produk and h.id_operator=o.id_operator"
            Dim cmd As New MySqlDataAdapter(strsql, objConnection2)
            objConnection2.Close()
            Dim ds As New DataSet1()
            cmd.Fill(ds, "DataTable1")

            objRpt.SetDataSource(ds.Tables(0))
            CrystalReportViewer1.ReportSource = objRpt
            CrystalReportViewer1.Refresh()

            Button1.Text = "Print Customer"
            printcustop = "customer"
            Dim txtObject As TextObject = DirectCast(objRpt.ReportDefinition.Sections("Section1").ReportObjects("txtcopy"), TextObject)
            txtObject.Text = ""
            lblcetak.Text = "Cetak Struk untuk Costumer"
            CrystalReportViewer1.Zoom(200)
        Else
            Dim strsql As String = "select p.no_tujuan as 'No. Tujuan', concat(o.nama,'-',substring(cast(h.denom as char),1,length(cast(h.denom as char))-3)) as 'Operator', h.harga as 'Harga', t.nota as 'Nota', i.infopulsa as 'Informasi'" _
        & "from (counter_pulsa.transaksi_pulsa p,harga.harga h,harga.operator o,harga.informasi i) " _
        & "inner join (select t.id_trx,t.nota from counter_pulsa.transaksi t order by t.id_trx desc limit " & jumlahdata & ") t " _
        & "on p.id_trx=t.id_trx and p.kode_produk=h.kode_produk and h.id_operator=o.id_operator"
            Dim cmd As New MySqlDataAdapter(strsql, objConnection2)
            objConnection2.Close()
            Dim ds As New DataSet1()
            cmd.Fill(ds, "DataTable1")

            objRpt.SetDataSource(ds.Tables(0))
            CrystalReportViewer1.ReportSource = objRpt
            CrystalReportViewer1.Refresh()

            Button1.Text = "Print Customer"
            printcustop = "customer"
            Dim txtObject As TextObject = DirectCast(objRpt.ReportDefinition.Sections("Section1").ReportObjects("txtcopy"), TextObject)
            txtObject.Text = ""
            lblcetak.Text = "Cetak Struk untuk Costumer"
            CrystalReportViewer1.Zoom(200)
        End If

        cetaknota = "tidak"
    End Sub

End Class