Imports EntitiesLayer

Public Class UCtrlIniciar

    Dim alerta As UctrlAlerta

    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click

        'Dim nombreUsuario As String = txtNombreUsuario.Text
        'Dim contraseña As String = txtContraseña.Text
<<<<<<< HEAD:AplicacionBecas/AplicacionGestionBecas/MenusAplicacion/UCtrlIniciar.vb
=======

>>>>>>> origin/valeram:AplicacionBecas/AplicacionGestionBecas/UcntrlIniciar.vb
        Dim nombreUsuario As String = "backi-g@hotmail.com"
        Dim contraseña As String = "1234"
        Dim listaUsuarios As List(Of Usuario)

        Try

            listaUsuarios = objGestorUsuario.iniciarSesion(nombreUsuario, contraseña)

            If listaUsuarios.Count > 0 Then
                Me.Hide()
                Globals.userName = listaUsuarios(0).primerNombre

                Globals.userRol = listaUsuarios(0).rol
                FrmIniciarSesion.Hide()
                FrmIniciarSesion.principal.Show()
            Else
                alerta = New UctrlAlerta()
                alerta.lblAlerta.Text = "Nombre de usuario o contraseña incorrectos"
                Me.Controls.Add(alerta)
                alerta.BringToFront()
                alerta.Location = New Point(100, 150)
                alerta.Show()
            End If
        Catch ex As Exception
            alerta = New UctrlAlerta()
            alerta.lblAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()

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

