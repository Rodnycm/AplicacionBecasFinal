Imports EntitiesLayer

Public Class UctrlCrearUsuario
    Dim alerta As UctrlAlerta = New UctrlAlerta()
    '<summary> Método que se encarga mandar al gestor la información para crear un nuevo usuario</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<param> No recibe valor  </param>
    '<returns> No retorna valor.</returns> 
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Dim pNombre As String = txtNombre.Text
        Dim sNombre As String = txtSegundoNombre.Text
        Dim pApellido As String = txtPrimerApellido.Text
        Dim sApellido As String = txtSegundoApellido.Text
        Dim identificacion As String = txtIdentificacion.Text
        Dim telefono As String = txtTelefono.Text
        Dim fechaNacimiento As Date = DtpFechaNacimiento.Value.Date
        Dim rol As String = cmbRoles.Text
        Dim genero As Integer
        Dim correoElectronico As String = txtCorreoElectronico.Text

        If (rbtMasculino.Checked = True) Then
            genero = 1
        Else
            If (rbtFemenino.Checked = True) Then
                genero = 2

            Else
                genero = 3
            End If
        End If

        Try
            objGestorUsuario.crearUsuario(pNombre, sNombre, pApellido, sApellido, identificacion, telefono, fechaNacimiento, rol, genero, correoElectronico)
            objGestorUsuario.guardarCambios()
        Catch ex As Exception
            alerta.lblAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()
        End Try
    End Sub


    '<summary> Método que se encarga de llenar un combo box de objetos Rol</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<param> No recibe valor  </param>
    '<returns> No retorna valor.</returns> 
    Public Sub llenarComboRoles()

        Try
            Dim listaRoles As List(Of Rol) = New List(Of Rol)

            listaRoles = objGestorRol.consultarRoles()

            For i As Integer = 0 To listaRoles.Count - 1

                cmbRoles.Items.Add(listaRoles(i).Nombre)
            Next
        Catch ex As Exception
            alerta.lblAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()
        End Try


    End Sub


    Private Sub UctrlCrearUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarComboRoles()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim ucntrl As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
        Me.SendToBack()
        FrmIniciarSesion.principal.Controls.Add(ucntrl)
        ucntrl.Location = New Point(120, 0)
        ucntrl.Show()
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        Dim ucntrl As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
        Me.SendToBack()
        FrmIniciarSesion.principal.Controls.Add(ucntrl)
        ucntrl.Location = New Point(120, 0)
        ucntrl.Show()
    End Sub

    Private Sub lblNombre_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub
    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub txtSegundoNombre_TextChanged(sender As Object, e As EventArgs) Handles txtSegundoNombre.TextChanged

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub txtPrimerApellido_TextChanged(sender As Object, e As EventArgs) Handles txtPrimerApellido.TextChanged

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub txtSegundoApellido_TextChanged(sender As Object, e As EventArgs) Handles txtSegundoApellido.TextChanged

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Sub txtIdentificacion_TextChanged(sender As Object, e As EventArgs) Handles txtIdentificacion.TextChanged

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Sub DtpFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles DtpFechaNacimiento.ValueChanged

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Private Sub rbtMasculino_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMasculino.CheckedChanged

    End Sub
    Private Sub rbtFemenino_CheckedChanged(sender As Object, e As EventArgs) Handles rbtFemenino.CheckedChanged

    End Sub
    Private Sub rbtOtro_CheckedChanged(sender As Object, e As EventArgs) Handles rbtOtro.CheckedChanged

    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    Private Sub cmbRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRoles.SelectedIndexChanged

    End Sub
    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
    Private Sub txtCorreoElectronico_TextChanged(sender As Object, e As EventArgs) Handles txtCorreoElectronico.TextChanged

    End Sub
End Class

