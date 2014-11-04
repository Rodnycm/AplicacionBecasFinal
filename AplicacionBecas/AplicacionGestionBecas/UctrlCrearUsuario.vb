
Imports EntitiesLayer

Public Class UctrlCrearUsuario
    Dim alerta As UctrlAlerta = New UctrlAlerta()
    Dim lista As UctrlListarYBuscarUsuario
    Dim mBlnFormDragging As Boolean
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
            lista.dgUsuarios.Rows.Clear()
            lista.listarUsuarios()
            MsgBox("Usuario creado correctamente")
        Catch ex As Exception
            alerta.lblAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.Location = New Point(500, 250)
            alerta.BringToFront()
            alerta.Show()
        End Try

        lista.dgUsuarios.Rows.Clear()
        lista.listarUsuarios()

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

    Public Sub setLista(ByVal plista As UctrlListarYBuscarUsuario)
        lista = plista
    End Sub

    Public Sub uCtrlCrearUsuario_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    Public Sub uCtrlCrearUsuario_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = FrmIniciarSesion.principal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub

    Public Sub uCtrlCrearUsuario_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

End Class
