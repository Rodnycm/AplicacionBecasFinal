Public Class uCtrlMenuReportes

    Private Sub btnConsultarBitacoraAcciones_Click(sender As Object, e As EventArgs) Handles btnConsultarBitacoraAcciones.Click

        Dim uCtrl As New uCtrlReporteRegistroAcciones()

        FrmIniciarSesion.principal.Controls.Add(uCtrl)
        uCtrl.Show()
        uCtrl.BringToFront()
        uCtrl.Location = New Point(170, 150)
        Me.Hide()

    End Sub
End Class
