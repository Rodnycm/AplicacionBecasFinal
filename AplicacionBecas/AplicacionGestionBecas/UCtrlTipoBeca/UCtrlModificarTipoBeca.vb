Imports EntitiesLayer
Public Class uCtrlModificarTipoBeca
    Dim buscar As uCtrlBuscarTipoBeca
    Dim listas As List(Of Beneficio)
    Dim listasR As List(Of Requisito)
    'Dim modificar As uCtrlModificarTipoBeca = New uCtrlModificarTipoBeca()
    Public objTipo As TipoBeca
   
    Public Sub getFrmBuscar(pbuscar As uCtrlBuscarTipoBeca)
        buscar = pbuscar
    End Sub
    Public Sub setListas(ByVal plista As List(Of Beneficio))
        listas = plista
    End Sub

    Public Sub setListasR(ByVal plistaR As List(Of Requisito))
        listasR = plistaR
    End Sub
    Public Sub recibirDatos(pnombre As String, pestado As String, pdescripcion As String)

        'txtNombre.Text = pnombre
        txtEstado.Text = pestado
        txtDescripcion.Text = pdescripcion

    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim nombre As String = txtNombre.Text
            Dim estado As String = txtEstado.Text
            Dim descripcion As String = txtDescripcion.Text
            'RequisitosRelacionados()
            'BeneficiosRelacionados()
            gestorTipoBeca.modificarTipoBeca(nombre, estado, descripcion)

            gestorTipoBeca.guardarCambios()
            'gestorTipoBeca.modificarRequisitos(listasR, tipoB)
            'gestorTipoBeca.modificarBeneficios(listas, tipoB)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Hide()
        Me.Dispose()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Me.Dispose()
    End Sub
    Private Sub btnRequisitos_Click(sender As Object, e As EventArgs) Handles btnRequisitos.Click
        Dim requisito As uCtrlAsignarRequisitos = New uCtrlAsignarRequisitos()
        frmPrincipal.Controls.Add(requisito)
        'requisito.enviarrequisitos(modificar)
        requisito.Location = New Point(150, 250)
        requisito.BringToFront()
        requisito.Show()
    End Sub
    Private Sub btnBeneficios_Click(sender As Object, e As EventArgs) Handles btnBeneficios.Click
        Dim beneficio As SeleccionarBeneficios = New SeleccionarBeneficios()
        frmPrincipal.Controls.Add(beneficio)
        'beneficio.enviarbeneficios(modificar)
        beneficio.Location = New Point(150, 250)
        beneficio.BringToFront()
        beneficio.Show()
    End Sub

    Private Sub editar_load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNombre.Text = objTipo.nombre
        txtEstado.Text = objTipo.estado
        txtDescripcion.Text = objTipo.descripcion

    End Sub
End Class
