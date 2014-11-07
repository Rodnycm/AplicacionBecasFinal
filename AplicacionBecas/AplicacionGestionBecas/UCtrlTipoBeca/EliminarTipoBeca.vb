Imports EntitiesLayer
Public Class EliminarTipoBeca
    Dim nombre As String
    Dim id As Integer
    Dim estado As String
    Dim descripcion As String
    Dim buscar As uCtrlBuscarTipoBeca
    Public Sub setNombre(ByVal pnombre As String)
        nombre = pnombre
    End Sub
    Public Sub getUCtrBuscar(pbuscar As uCtrlBuscarTipoBeca)

        buscar = pbuscar

    End Sub
    Public Sub recibirDatos(ByVal pid As Integer, ByVal pnombre As String, ByVal pestado As String, ByVal pdescripcion As String)
        id = pid
        nombre = pnombre
        estado = pestado
        descripcion = pdescripcion

    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs)
        gestorTipoBeca.eliminarTipoBeca(Me.nombre)
        gestorTipoBeca.guardarCambios()
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Dim buscarTipoBeca As uCtrlBuscarTipoBeca = New uCtrlBuscarTipoBeca()
        Me.Hide()
        frmPrincipal.Controls.Add(buscarTipoBeca)
        buscarTipoBeca.Location = New Point(120, 0)
        buscarTipoBeca.Show()
    End Sub
    Public Sub refrescarLista(ByVal pbuscar As uCtrlBuscarTipoBeca)
        buscar = pbuscar
    End Sub
End Class
