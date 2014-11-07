Imports EntitiesLayer
Imports BLL

Public Class uCtrlEliminarCurso
    Dim id As Integer
    Dim nombreCurso As String
    Dim codigoCurso As String
    Dim ucBuscarCursos As uCtrlBuscarCursos
    Dim alerta As uCtrlAlerta


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        Me.Dispose()

    End Sub

    Public Sub recieveData(ByVal pid As Integer, ByVal pnombre As String, pcodigo As String)

        id = pid
        nombreCurso = pnombre
        codigoCurso = pcodigo


    End Sub
    Public Sub refrecarLista(ByVal puctrl As uCtrlBuscarCursos)
        ucBuscarCursos = puctrl
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            objGestorCurso.eliminarCurso(id, nombreCurso, codigoCurso)
            objGestorCurso.guardarCambios()
            ucBuscarCursos.dtaListarCursos.Rows.Clear()
            ucBuscarCursos.listarCursos()
            Me.Dispose()

        Catch ex As Exception
            alerta = New uCtrlAlerta()
            alerta.txtAlerta.Text = ex.Message
            frmPrincipal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Location = New Point(290, 48)
            alerta.Show()
        End Try


        Me.Dispose()


    End Sub

    Private Sub uCtrlEliminarCurso_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class