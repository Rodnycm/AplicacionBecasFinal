

Imports BLL
Imports EntitiesLayer


Public Class CrearCursos

    Dim alerta As uCtrlAlerta
    Dim ucBuscarCursos As New uCtrlBuscarCursos


    Private Sub btnAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnAgregarCurso.Click
        Dim nombre As String = txtNombreCurso.Text
        Dim codigo As String = txtCodigoCurso.Text
        Dim cuatrimestre As String = cmbCuatrimestreCurso.Text
        Dim creditos As String = txtCreditosCurso.Text
        Dim precio As String = txtPrecioCurso.Text


        Try
            objGestorCurso.agregarCurso(nombre, codigo, cuatrimestre, creditos, precio)
            objGestorCurso.guardarCambios()
            ucBuscarCursos.dtaListarCursos.Rows.Clear()
            ucBuscarCursos.listarCursos()
            Me.Dispose()
        Catch ex As Exception
            alerta = New uCtrlAlerta()
            alerta.lblAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Location = New Point(290, 48)
            alerta.Show()

         
        End Try


    End Sub

    Public Sub refrecarLista(ByVal puctrl As uCtrlBuscarCursos)
        ucBuscarCursos = puctrl
    End Sub
    Private Sub btnCancelarAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnCancelarAgregarCurso.Click


        Me.Hide()
        'dtaListarCursos.Clear()



    End Sub


    Private Sub imgCrearCurso_Click(sender As Object, e As EventArgs) Handles imgCrearCurso.Click

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub txtCreditosCurso_TextChanged(sender As Object, e As EventArgs) Handles txtCreditosCurso.TextChanged

    End Sub
End Class
