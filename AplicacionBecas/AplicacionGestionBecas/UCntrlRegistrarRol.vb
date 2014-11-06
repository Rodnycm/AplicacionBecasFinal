Imports EntitiesLayer
Public Class UCntrlRegistrarRol

    Dim listarRoles As uCtrlListarRol
    Dim listaPermisos As New List(Of Permiso)

    '''<summary>crea un nuevo Rol en el sistema </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim nombre As String = txtNombre.Text

        Try
            objGestorRol.agregarRol(nombre)
            objGestorRol.guardarCambios()

            Dim Uctrl As uCtrlConfirmacion = New uCtrlConfirmacion
            FrmIniciarSesion.principal.Controls.Add(Uctrl)
            Uctrl.lblConfirmacion.Text = "El rol se creo correctamente"
            Uctrl.Location = New Point(300, 100)
            Uctrl.BringToFront()
            Uctrl.Show()

        Catch ex As Exception
            Dim UCtrl As UctrlAlerta = New UctrlAlerta()

            FrmIniciarSesion.principal.Controls.Add(UCtrl)
            UCtrl.lblAlerta.Text = ex.Message
            UCtrl.Location = New Point(300, 100)
            UCtrl.BringToFront()
            UCtrl.Show()
        End Try


        
        listarRoles.DGVRol.Rows.Clear()
        listarRoles.ListarRoles()
        Me.Dispose()
    End Sub

    ''' <summary>
    ''' Este metodo consigue la lista de roles
    ''' </summary>
    ''' <param name="plistarRoles"></param>
    ''' <remarks></remarks>
    Public Sub getFrmBuscar(plistarRoles As uCtrlListarRol)

        listarRoles = plistarRoles
    End Sub

    '''<summary>Este metodo oculta el usuario de control de registrar Rol </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        MostrarMenuMant()
        Me.Dispose()

    End Sub

    '''<summary>Este metodo muestr el menu de mantenimiento </summary>
    '''<author>Rodny Castro Mathews </author> 
    Public Sub MostrarMenuMant()
        Dim ucMenuMant As New uCtrlMenuMantenimiento()
        ucMenuMant.Show()
    End Sub

    ''' <summary>
    ''' Este metodo cierra Esta ventana
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub

    Public Sub listarPermisos()
        Try
            listaPermisos = objGestorRol.consultarPermisos()
            For i As Integer = 0 To listaPermisos.Count - 1
                CLBPermisos.Items.Add(listaPermisos.Item(i).Nombre)

            Next

            'CompararPermisos()
        Catch ex As Exception
            
        End Try

    End Sub

    Private Sub UCntrlRegistrarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPermisos()
    End Sub
End Class
