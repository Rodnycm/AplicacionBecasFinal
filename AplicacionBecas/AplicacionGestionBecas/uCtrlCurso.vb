Public Class uCtrlCurso

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        Dim nombre As String = txtNombre.Text
        Dim codigo As String = txtCodigo.Text
        Dim creditos As Integer = txtCreditos.Text
        Dim cuatrimestre As String = txtCuatrimestre.Text
        Dim precio As Double = txtPrecio.Text

        'objGestorCurso.agregarCurso(nombre, codigo, cuatrimestre, creditos, precio)
        'objGestorCurso.guardarCambios()


    End Sub
End Class
