Imports EntitiesLayer
Imports BLL
Public Class uCtrlEliminarCurso
    Dim id As Integer
    Dim nombreCurso As String
    Dim codigoCurso As String
    Dim ucBuscarCursos As uCtrlBuscarCursos
    Dim alerta As New UctrlAlerta
    Dim objCurso As Curso
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Me.Dispose()

    End Sub
    ''' <summary>Método que se encarga de recivir el parámetro por medio del cual se hará una instancia del objetoCurso</summary>
    ''' <param name="pcodigo">Código el cual corresponde al curso que se desea eliminar</param>
    ''' <autor>Valeria Ramírez</autor>
    ''' 
    Public Sub recieveData(pcodigo As String)
        codigoCurso = pcodigo
        objCurso = objGestorCurso.BuscarCurso(pcodigo)

    End Sub
    ''' <summary>Método que se encarga limpiar y listar los cursos una vez que han sido eliminados</summary>
    ''' <param name="puctrl">Control de usuario de Buscar Cursos</param>
    ''' <autor>Valeria Ramírez</autor>
    ''' 
    Public Sub refrecarLista(ByVal puctrl As uCtrlBuscarCursos)
        ucBuscarCursos = puctrl

    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            objGestorCurso.eliminarCurso(Me.codigoCurso)
            objGestorCurso.guardarCambios()
            ucBuscarCursos.dtaListarCursos.Rows.Clear()
            ucBuscarCursos.listarCursos()
            Me.Dispose()

        Catch ex As Exception

            alerta.txtAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.Location = New Point(375, 100)
            alerta.BringToFront()
            alerta.Show()
        End Try
        Me.Dispose()

    End Sub
End Class