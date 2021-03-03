Public Class frmCari
    Private Sub btnGetir_Click(sender As Object, e As EventArgs) Handles btnGetir.Click

        Dim soapClient As New DemoWebServiceReference.DemoWebServiceSoapClient()

        dgvCari.DataSource = soapClient.CariListesi
    End Sub
End Class
