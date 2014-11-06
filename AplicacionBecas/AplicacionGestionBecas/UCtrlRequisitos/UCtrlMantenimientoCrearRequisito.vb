Public Class uCtrlMantenimientoCrearRequisito

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub
    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim nombre As String = txtNombre.Text
        Dim descripcion As String = txtDescripcion.Text

        objGestorRequisito.crearRequisito(nombre, descripcion)
        objGestorRequisito.guardarCambios()
    End Sub

End Class

