Imports EntitiesLayer
Imports BLL

Public Class uCtrlEliminarCurso
    Dim idCurso As Integer
    Dim nombreCurso As String
    Dim codigoCurso As String
    Dim uBuscarCursos As uCtrlBuscarCursos
    Dim alerta As uCtrlAlerta


    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub

    Public Sub recieveData(ByVal pid As Integer, ByVal pnombre As String, pcodigo As String)

        idCurso = pid
        nombreCurso = pnombre
        codigoCurso = pcodigo

    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click

        Try
            objGestorCurso.eliminarCurso(idCurso, nombreCurso, codigoCurso)
            objGestorCurso.guardarCambios()

        Catch ex As Exception
            alerta = New uCtrlAlerta()
            alerta.lblAlerta.Text = ex.Message
            frmPrincipal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Location = New Point(290, 48)
            alerta.Show()
        End Try
        
      
       
    End Sub
End Class
