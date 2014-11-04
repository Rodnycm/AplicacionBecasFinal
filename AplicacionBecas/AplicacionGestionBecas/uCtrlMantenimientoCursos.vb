Public Class uCtrlMantenimientoCursos

    Public Property uCtrlCursos As uCtrlCurso = New uCtrlCurso()

    Private Sub btnCrearCurso_Click(sender As Object, e As EventArgs) Handles btnCrearCurso.Click

        uCtrlCursos = New uCtrlCurso()
        frmPrincipal.Controls.Add(uCtrlCursos)
        uCtrlCursos.BringToFront()
        uCtrlCursos.Show()

    End Sub
End Class
