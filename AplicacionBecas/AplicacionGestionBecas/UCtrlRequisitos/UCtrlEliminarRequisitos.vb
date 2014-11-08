Public Class UCtrlEliminarRequisitos
    Dim listarRequisitos As uCtrlMantenimientoRequisitos
    Dim idRequisito As Integer
    Dim nombre As String
    Dim descripcion As String

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Public Sub getFrmBuscar(plistarRequisitos As uCtrlMantenimientoRequisitos)

        listarRequisitos = plistarRequisitos
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ValidarELiminarRequisito()

        listarRequisitos.dgvRequisitos.Rows.Clear()
        listarRequisitos.listarRequisitos()
        Me.Dispose()
    End Sub
    Private Sub EliminarRequisito()
        Try
            objGestorRequisito.eliminarRequisito(nombre, descripcion, idRequisito)
            objGestorRequisito.guardarCambios()
            Dim Uctrl As uCtrlConfirmacion = New uCtrlConfirmacion
            FrmIniciarSesion.principal.Controls.Add(Uctrl)
            Uctrl.txtConfirmacion.Text = "El requisito se eliminó correctamente"
            Uctrl.Location = New Point(300, 100)
            Uctrl.BringToFront()
            Uctrl.Show()

        Catch ex As Exception
            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

            FrmIniciarSesion.principal.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(375, 100)
            UCtrl.BringToFront()
            UCtrl.Show()
        End Try

    End Sub
    Public Sub recieveData(ByVal pid As Integer, ByVal pnombre As String, ByVal pdescripcion As String)
        idRequisito = pid
        nombre = pnombre
        descripcion = pdescripcion
    End Sub

    Private Sub ValidarELiminarRequisito()

        If objGestorUsuario.buscarUsuariosPorRol(idRequisito) Is Nothing Then
            objGestorRequisito.eliminarRequisito(nombre, descripcion, idRequisito)
        Else
            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

            FrmIniciarSesion.principal.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = "Este requisito no se puede eliminar"
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()
        End If



    End Sub
End Class
