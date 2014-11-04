Imports EntitiesLayer
Imports BLL


Public Class uCtrlModificarCurso

    Dim ucBuscarCursos As uCtrlBuscarCursos
    Dim Id As Integer
    Dim nombre As String
    Dim codigo As String
    Dim cuatrimestre As String
    Dim creditos As Integer
    Dim precio As Double
    Dim alerta As uCtrlAlerta



    Public Sub recieveData(pnombre As String, pcodigo As String, pcuatrimestre As String, pcreditos As Integer, pprecio As Double, pid As Integer)


        txtNombreCurso.Text = pnombre
        txtCodigoCurso.Text = pcodigo
        cmbCuatrimestreCurso.Text = pcuatrimestre
        txtCreditosCurso.Text = pcreditos
        txtPrecioCurso.Text = pprecio
        txtId.Text = pid
        MsgBox(pid)

    End Sub

    Private Sub btnAceptarModificarCurso_Click(sender As Object, e As EventArgs) Handles btnAceptarModificarCurso.Click


        nombre = txtNombreCurso.Text
        codigo = txtCodigoCurso.Text
        cuatrimestre = cmbCuatrimestreCurso.Text
        creditos = txtCreditosCurso.Text
        precio = txtPrecioCurso.Text
        Id = txtId.Text
        MsgBox(Id)

        Try
            objGestorCurso.modificarCurso(nombre, codigo, cuatrimestre, creditos, precio, Id)
            objGestorCurso.guardarCambios()
        Catch ex As Exception
            alerta = New uCtrlAlerta()
            alerta.lblAlerta.Text = ex.Message
            frmPrincipal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Location = New Point(290, 48)
            alerta.Show()
        End Try


        'ucBuscarCursos.listarCursos()
        'ucBuscarCursos.dtaListarCursos.Rows.Clear()

        Me.Hide()
        Me.Dispose()

    End Sub


    Private Sub btnCancelarAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregarCurso.Click
        ucBuscarCursos = New uCtrlBuscarCursos()
        Me.SendToBack()
        Me.Controls.Add(ucBuscarCursos)
        ucBuscarCursos.Show()


    End Sub


End Class
