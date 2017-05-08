Imports MySql.Data.MySqlClient
Imports CrystalDecisions.CrystalReports.Engine
Public Class strukdepo
    Dim objRpt As New CrystalReport2()
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
            Else
                objRpt.PrintToPrinter(1, False, 0, 0)
                Button1.Text = "Print Customer"
                lblcetak.Text = "Cetak Struk untuk Customer"
                printcustop = "customer"
                Dim txtObject As TextObject = DirectCast(objRpt.ReportDefinition.Sections("Section1").ReportObjects("txtcopy"), TextObject)
                txtObject.Text = ""
                CrystalReportViewer1.Refresh()
                CrystalReportViewer1.Zoom(200)
                Me.Close()
                objConnection.Close()
                'Form1.Timer1.Start()
            End If
        End If
    End Sub

    Private Sub strukdepo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call atur()
        Dim objConnection2 As New MySqlConnection("Server='" & ip & "';port=3306;user id='root';password='';database='counter_pulsa'")
        objConnection2.Close()
        objConnection2.Open()
        If cetaknota = "cetak" Then
            Dim strsql As String = "select t.nota as 'Nota', d.id_member as 'ID Member', d.nama as 'Nama', t.jumlah as 'Jumlah',  i.infodeposit as 'Informasi' " _
                                   & "from (counter_pulsa.transaksi_deposit d,harga.informasi i) join (select id_trx,jumlah,nota from transaksi t where nota=" & cellklik & " and date(t.tgl_trx)=curdate()) t " _
                                   & "on t.id_trx=d.id_trx"
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
            lblcetak.Text = "Cetak Struk untuk Customer"
            CrystalReportViewer1.Zoom(150)
        Else
            Dim strsql As String = "select t.nota as 'Nota', d.id_member as 'ID Member', d.nama as 'Nama', t.jumlah as 'Jumlah',  i.infodeposit as 'Informasi' " _
                               & "from (counter_pulsa.transaksi_deposit d,harga.informasi i) join (select id_trx,jumlah,nota from transaksi t order by id_trx desc limit 1) t " _
                               & "on t.id_trx=d.id_trx"
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
            lblcetak.Text = "Cetak Struk untuk Customer"
            CrystalReportViewer1.Zoom(150)
        End If
    End Sub
End Class