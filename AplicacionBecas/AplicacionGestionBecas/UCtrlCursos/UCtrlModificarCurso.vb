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
    Dim alerta As uCtrlAlerta



    Public Sub recieveData(pnombre As String, pcodigo As String, pcuatrimestre As String, pcreditos As String, pprecio As String, pid As Integer)


        txtNombreCurso.Text = pnombre
        txtCodigoCurso.Text = pcodigo
        cmbCuatrimestreCurso.Text = pcuatrimestre
        txtCreditosCurso.Text = pcreditos
        txtPrecioCurso.Text = pprecio
        txtId.Text = pid


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
        Id = txtId.Text


        Try
            objGestorCurso.modificarCurso(nombre, codigo, cuatrimestre, creditos, precio, Id)
            objGestorCurso.guardarCambios()


            ucBuscarCursos.dtaListarCursos.Rows.Clear()
            ucBuscarCursos.listarCursos()
            Me.Dispose()
        Catch ex As Exception
            alerta = New uCtrlAlerta()
            alerta.txtAlerta.Text = ex.Message
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