Imports EntitiesLayer
Public Class uCtrlModificarTipoBeca

    Private Sub uCtrlModificarTipoBeca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click
        Dim nombre As String = txtNombre.Text
        Dim estado As String = txtEstado.Text
        Dim descripcion As String = txtDescripcion.Text

        gestorTipoBeca.modificarTipoBeca(nombre, estado, descripcion)
        gestorTipoBeca.guardarCambios()




        Me.Hide()
        Me.Dispose()
    End Sub
End Class
