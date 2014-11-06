
Imports EntitiesLayer


Public Class uCtrlModificarRol

    Dim nombre As String
    Dim idRol As Integer
    Dim listarRoles As uCtrlListarRol
    Dim listaPermisos As New List(Of Permiso)
    Dim listaPermisosRol As New List(Of Permiso)

    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name>  

    Public Sub getFrmBuscar(plistarRoles As uCtrlListarRol)

        listarRoles = plistarRoles
    End Sub
    Public Sub recieveData(ByVal pnombre As String, ByVal pidRol As Integer)
        txtNombre.Text = pnombre
        idRol = pidRol
    End Sub

    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name>  
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub



    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 

    Public Sub listarPermisos()
        Try
            listaPermisos = objGestorRol.consultarPermisos()
            For i As Integer = 0 To listaPermisos.Count - 1
                CLBPermisos.Items.Add(listaPermisos.Item(i).Nombre)

            Next

            CompararPermisos()
        Catch ex As Exception
            
        End Try
        
    End Sub



    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name> 
    Private Sub uCtrlModificarRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarPermisos()
        ''CompararPermisos()
    End Sub
    ''' <summary>
    ''' Este Metodo compara y pone un check a los permisos que este rol tenga asignados. 
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub CompararPermisos()
        listaPermisosRol = objGestorRol.consultarPermisosPorRol(idRol)

        For j As Integer = 0 To listaPermisosRol.Count - 1
            For i As Integer = 0 To listaPermisos.Count - 1
                If (listaPermisosRol.Item(j).Id = listaPermisos.Item(i).Id) Then

                    CLBPermisos.SetItemChecked(i, True)
                End If

            Next
        Next
        
    End Sub

    ''' <summary>
    ''' Esconde la pantalla
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
    End Sub
    '''<summary> Descripción del método o clase</summary>
    '''<author> Autor del código.</author> 
    '''<name> Parámetros que recibe el método </name>  
    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click

        
        asignarPermisosAUnRol()


        Try
            EditarRol()
            Dim Uctrl As uCtrlConfirmacion = New uCtrlConfirmacion
            FrmIniciarSesion.principal.Controls.Add(Uctrl)
            Uctrl.lblConfirmacion.Text = "El rol se modifico correctamente"
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

    Sub EditarRol()
        nombre = txtNombre.Text

        objGestorRol.modificarRol(nombre, idRol)
        objGestorRol.guardarCambios()
    End Sub

    Sub asignarPermisosAUnRol()

        Dim listaPermisosSeleccionados As New List(Of Permiso)
        Dim ListaPermisosQuitar As New List(Of Permiso)
        Dim listaIdROlesPermisos As New List(Of Integer)

        listaPermisosSeleccionados = PermisosSeleccionados()
        ListaPermisosQuitar = PermisosNoSeleccionados(listaPermisosSeleccionados)
        listaPermisosSeleccionados = ValidarPermisos(listaPermisosSeleccionados, ListaPermisosQuitar)

        If ListaPermisosQuitar.Count <> Nothing Then

            For i As Integer = 0 To ListaPermisosQuitar.Count - 1
                objGestorRol.eliminarPermisoAUnRol(ListaPermisosQuitar.Item(i).Id, idRol)
            Next

        End If

        If listaPermisosSeleccionados.Count <> Nothing Then
            For i As Integer = 0 To listaPermisosSeleccionados.Count - 1
                objGestorRol.asignarPermisoAUnRol(listaPermisosSeleccionados.Item(i).Id(), idRol)

            Next
        End If
    End Sub

    Public Function PermisosSeleccionados()
        Dim indexSeleccionado As Integer = 0
        Dim listaPermisosSeleccionados As New List(Of Permiso)
        Try

            For Each indexSeleccionado In CLBPermisos.CheckedIndices

                listaPermisosSeleccionados.Add(listaPermisos.Item(indexSeleccionado))

            Next indexSeleccionado




        Catch
        End Try

        Return listaPermisosSeleccionados
    End Function

    Public Function PermisosNoSeleccionados(ByVal plistaPermisosSeleccionados As List(Of Permiso))

        Dim ListaPermisosQuitar As New List(Of Permiso)
        ListaPermisosQuitar = listaPermisos
        Try

            For j As Integer = 0 To plistaPermisosSeleccionados.Count - 1
                Dim result As Boolean = False
                For i As Integer = 0 To listaPermisos.Count - 1 And result = True

                    If (plistaPermisosSeleccionados.Item(j).Id = listaPermisos.Item(i).Id) Then
                        ListaPermisosQuitar.RemoveAt(i)
                        result = True
                    End If

                Next
            Next


        Catch ex As Exception

        End Try

        Return ListaPermisosQuitar

    End Function

    Public Function ValidarPermisos(ByVal plistaPermisos As List(Of Permiso), ByVal plistaQuitar As List(Of Permiso))
        Dim listaPermisos As List(Of Permiso) = Nothing
        For j As Integer = 0 To plistaPermisos.Count - 1
            For i As Integer = 0 To plistaQuitar.Count - 1
                If (plistaPermisos.Item(j).Id = plistaQuitar(i).Id) Then
                    listaPermisos.Add(plistaPermisos.Item(i))
                End If

            Next
        Next

        Return listaPermisos
    End Function


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class
