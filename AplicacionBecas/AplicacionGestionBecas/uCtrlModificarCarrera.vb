Public Class uCtrlModificarCarrera

    Public Property idCarrera As Integer
    Public Property mantenimientoCarreras As uCtrlMantenimientoCarreras
    Dim ColorDialog1 As ColorDialog = New ColorDialog()

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton seleccionar color, este metodo 
    ''' muestra al usuario una paleta de colores</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click

        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            btnColor.BackColor = ColorDialog1.Color
        End If

        btnColor.ForeColor = Color.White

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton modificar y llama a la clase
    ''' gestor para modificar la informaciòn</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim nombre As String = txtNombre.Text
        Dim codigo As String = txtCodigo.Text

        objGestorCarrera.modificarCarrera(nombre, codigo, "334455", idCarrera)
        objGestorCarrera.guardarCambios()
        mantenimientoCarreras.listarCarreras()
        Me.Dispose()

    End Sub

End Class
