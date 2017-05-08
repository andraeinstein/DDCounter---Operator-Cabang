Public Class frmsukses

    Private Sub SkypeButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SkypeButton1.Click
        frmdepo.txtjumlah.Text = Nothing
        frmdepo.txtterbilang.Text = Nothing
        frmkartu.Close()
        Me.Close()
    End Sub
End Class