Imports EntitiesLayer

Public Class uCtrlBuscarCursos

    Private Sub dtaListarCursos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtaListarCursos.CellContentClick

    End Sub



    Public Sub listarCursos()
        'Dim listaCursos As List(Of Curso)
        'listaCursos = objGestorCurso.buscarCurso()


        'For i As Integer = 0 To listaCursos.Count - 1
        '    dtaListarCursos.Rows.Add(1)
        '    dtaListarCursos.Rows(i).Cells(0).Value = listaCursos.Item(i).nombre
        '    dtaListarCursos.Rows(i).Cells(1).Value = listaCursos.Item(i).codigo

        'Next

    End Sub

    Private Sub txtBuscarCurso_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCurso.TextChanged
        If txtBuscarCurso.Text = "" Then

            listarCursos()

        End If
    End Sub
End Class
