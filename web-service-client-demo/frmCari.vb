Public Class frmCari
    Private Sub btnGetir_Click(sender As Object, e As EventArgs) Handles btnGetir.Click

        Dim soapClient As New DemoWebServiceReference.DemoWebServiceSoapClient()

        dgvCari.DataSource = soapClient.CariListesi

    End Sub

    Private Sub btnKimlikSorgula_Click(sender As Object, e As EventArgs) Handles btnKimlikSorgula.Click
        Dim tcKimlikClient As New TCKimlikWebServiceReference.KPSPublicSoapClient()

        Dim testCitizen As Boolean = tcKimlikClient.TCKimlikNoDogrula(20141709150, "Emir", "Karpuz", 1991)

        If testCitizen Then
            MessageBox.Show("Vatandaşlık bilgileri doğru")
        Else
            MessageBox.Show("Hatalı bilgiler")
        End If
    End Sub
End Class
