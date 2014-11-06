Imports EntitiesLayer
Public Class EliminarTipoBeca
    Dim nombre As String
    Public Sub setNombre(ByVal pnombre As String)
        nombre = pnombre
    End Sub
    Public Sub recibirData()

    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        'gestorTipoBeca.eliminarTipoBeca(Me.nombre)
        'gestorTipoBeca.guardarCambios()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim buscarTipoBeca As uCtrlBuscarTipoBeca = New uCtrlBuscarTipoBeca()
        Me.Hide()
        frmPrincipal.Controls.Add(buscarTipoBeca)
        buscarTipoBeca.Location = New Point(120, 0)
        buscarTipoBeca.Show()
    End Sub
End Class
