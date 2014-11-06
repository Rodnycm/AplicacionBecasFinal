Public Class uCtrlMantenimientoCursos

    Public Property uCtrlCursos As UCtrlCrearCursos

    Private Sub btnCrearCurso_Click(sender As Object, e As EventArgs) Handles btnCrearCurso.Click

        uCtrlCursos = New UCtrlCrearCursos()
        frmPrincipal.Controls.Add(uCtrlCursos)
        uCtrlCursos.BringToFront()
        uCtrlCursos.Show()

    End Sub
End Class
