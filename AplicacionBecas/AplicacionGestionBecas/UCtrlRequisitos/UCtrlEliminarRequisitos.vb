Public Class UCtrlEliminarRequisitos

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

    End Sub
    Private Sub EliminarRequisito()
        Try
            ''objGestorRequisito.eliminarRequisito(nombre, IdROl)
            objGestorRol.guardarCambios()
            Dim Uctrl As uCtrlConfirmacion = New uCtrlConfirmacion
            FrmIniciarSesion.principal.Controls.Add(Uctrl)
            Uctrl.lblConfirmacion.Text = "El rol se eliminó correctamente"
            Uctrl.Location = New Point(300, 100)
            Uctrl.BringToFront()
            Uctrl.Show()

        Catch ex As Exception
            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

            FrmIniciarSesion.principal.Controls.Add(UCtrl)
            UCtrl.lblAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()
        End Try

    End Sub

    'Private Sub ValidarELiminarRequisito()

    '    If objGestorUsuario.buscarUsuariosPorRol() Is Nothing Then
    '        'EliminarRol()
    '    Else
    '        Dim UCtrl As UctrlAlerta = New UctrlAlerta()

    '        FrmIniciarSesion.principal.Controls.Add(UCtrl)
    '        UCtrl.lblAlerta.Text = "Este rol no se puede eliminar"
    '        UCtrl.Location = New Point(300, 100)
    '        UCtrl.BringToFront()
    '        UCtrl.Show()
    '    End If


    'End Sub
End Class
