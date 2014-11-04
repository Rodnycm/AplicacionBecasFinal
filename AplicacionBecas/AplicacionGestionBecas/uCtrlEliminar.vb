Public Class uCtrlEliminar

    Public Property codigo As String
    Public Property nombre As String

    Private Sub uCtrlEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblMensaje.Text = lblMensaje.Text + nombre + " ?"

    End Sub

    ''' <summary>Metodo encargado de eliminar la carrera cuando se da click al boton aceptar</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Dispose()

    End Sub

    ''' <summary>Metodo encargado de eliminar la carrera cuando se da click al boton aceptar</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        objGestorCarrera.eliminarCarrera(codigo)
        objGestorCarrera.guardarCambios()

    End Sub
End Class
