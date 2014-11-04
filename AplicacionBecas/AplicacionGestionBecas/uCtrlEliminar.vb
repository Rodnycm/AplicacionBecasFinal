Public Class uCtrlEliminar

    Public Property codigo As String
    Public Property nombre As String
    Public Property mantenimientoCarreras As uCtrlMantenimientoCarreras
    Dim mBlnFormDragging As Boolean

    ''' <summary>Metodo encargado de eliminar la carrera cuando se da click al boton aceptar</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)

        Me.Dispose()

    End Sub

    ''' <summary>Metodo encargado de eliminar la carrera cuando se da click al boton aceptar</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        objGestorCarrera.eliminarCarrera(codigo)
        objGestorCarrera.guardarCambios()
        mantenimientoCarreras.dgvCarreras.Rows.Clear()
        mantenimientoCarreras.listarCarreras()

    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Dispose()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Dispose()

    End Sub

    Private Sub uCtrlElimininarCarrera_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = frmPrincipal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    Private Sub uCtrlElimininarCarrera_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = frmPrincipal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub

    Public Sub uCtrlElimininarCarrera_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

    Private Sub uCtrlEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BringToFront()

    End Sub
End Class
