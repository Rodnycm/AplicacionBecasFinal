Public Class uCtrlMenuAcademico

    Dim uCtrlCarreras As uCtrlMantenimientoCarreras = New uCtrlMantenimientoCarreras()


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Controls.Add(uCtrlCarreras)
        'ucMenuAcad.Hide()
        uCtrlCarreras.Show()

    End Sub
End Class
