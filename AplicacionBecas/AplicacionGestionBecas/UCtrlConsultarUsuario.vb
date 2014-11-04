Imports EntitiesLayer
Public Class UCtrlConsultarUsuario

    Dim parametro As String

    Public Sub setParametro(ByVal pparametro As String)
        parametro = pparametro
    End Sub




    Private Sub UCtrlConsultarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim objUsuario As Usuario = objGestorUsuario.buscarUnUsuario(Me.parametro)
        Dim genero As String
        dgUsuarios.Rows.Clear()

        If objUsuario.genero = 1 Then
            genero = "Masculino"
        ElseIf objUsuario.genero = 2 Then
            genero = "Femenino"
        Else
            genero = "Otro"
        End If
        dgUsuarios.Rows.Add(1)
        dgUsuarios.Rows(0).Cells(0).Value = objUsuario.identificacion
        dgUsuarios.Rows(0).Cells(1).Value = objUsuario.primerNombre & " " & objUsuario.primerApellido & " " & objUsuario.segundoApellido
        dgUsuarios.Rows(0).Cells(2).Value = objUsuario.telefono
        dgUsuarios.Rows(0).Cells(3).Value = objUsuario.fechaNacimiento
        dgUsuarios.Rows(0).Cells(4).Value = genero
        dgUsuarios.Rows(0).Cells(5).Value = objUsuario.rol.Nombre
        dgUsuarios.Rows(0).Cells(6).Value = objUsuario.correoElectronico

    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Dim ucntrl As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
        Me.Hide()
        frmPrincipal.Controls.Add(ucntrl)
        ucntrl.Location = New Point(120, 0)
        ucntrl.Show()
    End Sub
End Class
