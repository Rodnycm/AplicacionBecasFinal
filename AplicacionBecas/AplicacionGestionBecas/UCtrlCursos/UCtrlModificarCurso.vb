Imports EntitiesLayer

Imports BLL


Public Class uCtrlModificarCurso

    Dim ucBuscarCursos As uCtrlBuscarCursos
    Dim Id As Integer
    Dim nombre As String
    Dim codigo As String
    Dim cuatrimestre As String
    Dim creditos As String
    Dim precio As String
    Dim alerta As UctrlAlerta
    Dim objCurso As Curso




    Public Sub recieveData(pcodigo As String)


        objCurso = objGestorCurso.BuscarCurso(pcodigo)
        llenarInfoModificar(objCurso)

    End Sub

    Public Sub llenarInfoModificar(ByVal pobjCurso As Curso)

        txtNombreCurso.Text = pobjCurso.nombre
        txtCodigoCurso.Text = pobjCurso.codigo
        txtCreditosCurso.Text = pobjCurso.creditos
        txtPrecioCurso.Text = pobjCurso.precio
        cmbCuatrimestreCurso.Text = pobjCurso.cuatrimestre


    End Sub
    Public Sub refrecarLista(ByVal puctrl As uCtrlBuscarCursos)
        ucBuscarCursos = puctrl
    End Sub
    Private Sub btnAceptarModificarCurso_Click(sender As Object, e As EventArgs) Handles btnAceptarModificarCurso.Click


        nombre = txtNombreCurso.Text
        codigo = txtCodigoCurso.Text
        cuatrimestre = cmbCuatrimestreCurso.Text
        creditos = txtCreditosCurso.Text
        precio = txtPrecioCurso.Text
        Id = objCurso.Id

        Try

            objGestorCurso.modificarCurso(codigo, nombre, cuatrimestre, creditos, precio, Id)
            objGestorCurso.guardarCambios()
            ucBuscarCursos.dtaListarCursos.Rows.Clear()
            ucBuscarCursos.listarCursos()
            Me.Dispose()
        Catch ex As Exception

            alerta = New UctrlAlerta()
            alerta.lblAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Location = New Point(290, 48)
            alerta.Show()
        End Try

     

    End Sub


    Private Sub btnCancelarAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregarCurso.Click
        ucBuscarCursos = New uCtrlBuscarCursos()
        Me.SendToBack()
        Me.Controls.Add(ucBuscarCursos)
        ucBuscarCursos.Show()


    End Sub

End Class