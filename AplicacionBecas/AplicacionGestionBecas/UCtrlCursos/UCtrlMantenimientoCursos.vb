Public Class uCtrlMantenimientoCursos

    Public Property uCtrlCursos As UI.CrearCursos

    Private Sub btnCrearCurso_Click(sender As Object, e As EventArgs) Handles btnCrearCurso.Click

        uCtrlCursos = New UI.CrearCursos()
        FrmIniciarSesion.principal.Controls.Add(uCtrlCursos)
        uCtrlCursos.BringToFront()
        uCtrlCursos.Show()

    End Sub
End Class
