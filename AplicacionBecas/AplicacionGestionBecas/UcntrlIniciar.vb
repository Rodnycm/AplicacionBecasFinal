Imports EntitiesLayer
Public Class UcntrlIniciar

    Dim alerta As UctrlAlerta = New UctrlAlerta()

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
      
        'Dim nombreUsuario As String = txtNombreUsuario.Text
        'Dim contraseña As String = txtContraseña.Text
        Dim nombreUsuario As String = "backi-g@hotmail.com"
        Dim contraseña As String = "1234"
        Dim listaUsuarios As List(Of Usuario)

        Try

            listaUsuarios = objGestorUsuario.iniciarSesion(nombreUsuario, contraseña)

            If listaUsuarios.Count > 0 Then
                Me.Hide()
                Globals.userName = listaUsuarios(0).primerNombre
                FrmIniciarSesion.Hide()
                FrmIniciarSesion.principal.Show()
            Else
                alerta.lblAlerta.Text = "Nombre de usuario o contraseña incorrectos"
                FrmIniciarSesion.Controls.Add(alerta)
                alerta.BringToFront()
                alerta.Location = New Point(160, 200)
                alerta.Show()
            End If
        Catch ex As Exception
            alerta.lblAlerta.Text = ex.Message
            FrmIniciarSesion.Controls.Add(alerta)
            alerta.BringToFront()
            FrmIniciarSesion.SendToBack()
            alerta.Location = New Point(200, 100)
            alerta.Show()
        End Try

    End Sub

    Private Sub btnRecuperar_Click(sender As Object, e As EventArgs) Handles btnRecuperar.Click

        Dim uctrlRecuperar As UctrlRecuperarContraseña = New UctrlRecuperarContraseña()
        FrmIniciarSesion.Controls.Add(uctrlRecuperar)
        uctrlRecuperar.BringToFront()
        uctrlRecuperar.Location = New Point(140, 260)
    End Sub

End Class
