
Imports EntitiesLayer
Imports BLL

Public Class uCtrlEliminarRol
    Dim listarRoles As uCtrlListarRol
    Dim nombre As String
    Dim IdROl As Integer

    '''<summary> Este Metodo esconde el usuario de control de eliminar Rol</summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        listarRoles.DGVRol.Rows.Clear()
        listarRoles.ListarRoles()
        Me.Dispose()
    End Sub

    Public Sub getFrmBuscar(plistarRoles As uCtrlListarRol)

        listarRoles = plistarRoles
    End Sub

    '''<summary>REcibe el dato del rol a eliminar </summary>
    '''<author>Rodny Castro Mathews </author> 
    '''<param name="pnombre"> Nombre del Rol a eliminar  </param> 
    Public Sub recieveData(ByVal pnombre As String, ByVal pid As Integer)
        nombre = pnombre
        IdROl = pid
    End Sub

    '''<summary>Elimina El rol seleccionado </summary>
    '''<author>Rodny Castro Mathews </author> 
    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            objGestorRol.eliminarRol(nombre, IdROl)
            objGestorRol.guardarCambios()
            Dim Uctrl As uCtrlConfirmacion = New uCtrlConfirmacion
            FrmIniciarSesion.principal.Controls.Add(Uctrl)
            Uctrl.lblConfirmacion.Text = "El rol se eliminó correctamente"
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

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class
