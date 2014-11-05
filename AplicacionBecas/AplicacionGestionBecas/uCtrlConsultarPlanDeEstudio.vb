Imports EntitiesLayer

Public Class uCtrlConsultarPlanDeEstudio

    Dim carrera As Carrera

    Private Sub uCtrlConsultarPlanDeEstudio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarCursos()
        llenarComboCursos()
    End Sub

    Public Sub listarCursos()

        limpiarGrid()

        Dim listaCursos As New List(Of Curso)
        listaCursos = objGestorCurso.consultarCursos

        For Each Curso In listaCursos

            dtaConsultarPlanEstudio.Rows.Add(Curso.nombre, Curso.creditos, Curso.precio)

        Next


    End Sub

    Public Sub llenarComboCursos()

        Try
            Dim listaCursos As New List(Of Curso)

            listaCursos = objGestorCurso.getCursoPorCuatrimestre()

            For i As Integer = 0 To listaRoles.Count - 1

                cmbCursos.Items.Add(listaRoles(i).Nombre)
            Next
        Catch ex As Exception
            alerta.lblAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()
        End Try


    End Sub

    Public Sub listarCursosPorCuatri()

        Dim listaCursos As New List(Of Curso)
        listaCursos = objGestorCurso.getCursoPorCuatrimestre(cmbCursos.SelectedItem)
        Dim precioTotal As Double
        Dim totalCreditos As Integer

        limpiarGrid()

        For i As Integer = 0 To listaCursos.Count - 1

            dtaConsultarPlanEstudio.Rows.Add(listaCursos.Item(i).nombre, listaCursos.Item(i).creditos, listaCursos.Item(i).precio)
            totalCreditos = totalCreditos + listaCursos.Item(i).creditos
            precioTotal = precioTotal + listaCursos.Item(i).precio
        Next

        lblSumaCreditos.Text = totalCreditos
        lblSumaPrecio.Text = precioTotal

    End Sub


    Public Sub limpiarGrid()

        dtaConsultarPlanEstudio.Rows.Clear()

    End Sub

    Private Sub cmbCursos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCursos.SelectedIndexChanged
        listarCursosPorCuatri()
    End Sub
End Class
