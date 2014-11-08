Imports EntitiesLayer
Public Class uCtrlCrearTipoBeca
    Dim listas As List(Of Beneficio)
    Dim listasR As List(Of Requisito)
    Dim uCtrlBuscarTB As uCtrlBuscarTipoBeca
    Dim uCtrlConsultarTb As uCtrlConsultarTipoBeca

    Public Sub setListas(ByVal plista As List(Of Beneficio))
        listas = plista
    End Sub

    Public Sub setListasR(ByVal plistaR As List(Of Requisito))
        listasR = plistaR
    End Sub
    'Public Sub getFrmBuscarTipoBeca(puCtrlBuscarTB As uCtrlBuscarTipoBeca)

    '    uCtrlBuscarTipoBeca = puCtrlBuscarTB
    'End Sub
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        Try
            Dim nombre As String = txtNombre.Text
            Dim estado As String = txtEstado.Text
            Dim descripcion As String = txtDescripcion.Text
            Dim tipo As TipoBeca = gestorTipoBeca.agregarTipoBeca(nombre, estado, descripcion)
            gestorTipoBeca.guardarCambios()
            gestorTipoBeca.asignarBeneficioTipoBeca(listas, tipo)
            gestorTipoBeca.asignarRequisitoTipoBeca(listasR, tipo)


        Catch ex As Exception
            Dim UCtrl As UctrlAlerta = New UctrlAlerta()
            FrmIniciarSesion.principal.Controls.Add(UCtrl)
            UCtrl.txtAlerta.Text = ex.Message
            UCtrl.Location = New Point(400, 250)
            UCtrl.BringToFront()
            UCtrl.Show()

        End Try


    End Sub
    
    Private Sub btnBeneficios_Click(sender As Object, e As EventArgs) Handles btnBeneficios.Click
        Dim beneficio As SeleccionarBeneficios = New SeleccionarBeneficios()
        FrmIniciarSesion.principal.Controls.Add(beneficio)
        beneficio.enviarbeneficios(Me)
        beneficio.Location = New Point(470, 180)
        beneficio.BringToFront()
        beneficio.Show()


    End Sub

    Private Sub btnRequisitos_Click(sender As Object, e As EventArgs) Handles btnRequisitos.Click
        Dim requisito As uCtrlAsignarRequisitos = New uCtrlAsignarRequisitos()
        FrmIniciarSesion.principal.Controls.Add(requisito)
        requisito.enviarrequisitos(Me)
        requisito.Location = New Point(470, 180)
        requisito.BringToFront()
        requisito.Show()
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Hide()
        'uCtrlBuscarTB.dtaTipoBeca.Rows.Clear()
        'uCtrlBuscarTB.listarTiposBeca()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Me.Hide()
        'uCtrlBuscarTB.dtaTipoBeca.Rows.Clear()
        'uCtrlBuscarTB.listarTiposBeca()
    End Sub
End Class
