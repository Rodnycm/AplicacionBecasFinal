Public Class UctrlEliminarUsuario

    Dim parametro As String
    Dim Uctrl As UctrlListarYBuscarUsuario

    Public Sub setParametro(ByVal pparametro As String)
        parametro = pparametro
    End Sub

    Public Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        objGestorUsuario.eliminarUsuario(Me.parametro)
        objGestorUsuario.guardarCambios()
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ucntrl As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
        Me.Hide()
        frmPrincipal.Controls.Add(ucntrl)
        ucntrl.Location = New Point(120, 0)
        ucntrl.Show()
    End Sub

    Public Sub refrescarLista(ByVal puctrl As UctrlListarYBuscarUsuario)
        Uctrl = puctrl
    End Sub

End Class

