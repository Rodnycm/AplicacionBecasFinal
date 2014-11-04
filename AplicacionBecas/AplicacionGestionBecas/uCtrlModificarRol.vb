
Imports EntitiesLayer


Public Class uCtrlModificarRol

    Dim nombre As String
    Dim idRol As String
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
            MsgBox("No tiene Permisos Asignados")
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
        EditarRol()

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
        Dim indexSeleccionado As Integer = 0
        Dim listaPermisosSeleccionados As New List(Of Permiso)
        Dim ListaPermisosQuitar As New List(Of Permiso)
        Dim listaIdROlesPermisos As New List(Of Integer)

        Try

            For Each indexSeleccionado In CLBPermisos.CheckedIndices

                listaPermisosSeleccionados.Add(listaPermisos.Item(indexSeleccionado))

            Next indexSeleccionado
        Catch
            MsgBox("Debe escoger almenos una opcion")
        End Try


        For i As Integer = 0 To listaPermisosSeleccionados.Count - 1
            objGestorRol.asignarPermisoAUnRol(listaPermisosSeleccionados.Item(i).Id(), idRol)

        Next

        For j As Integer = 0 To listaPermisosSeleccionados.Count - 1
            For i As Integer = 0 To listaPermisos.Count - 1
                If (listaPermisosSeleccionados.Item(j).Id <> listaPermisos.Item(i).Id) Then
                    ListaPermisosQuitar.Add(listaPermisos.Item(i))
                End If

            Next
        Next

        For i As Integer = 0 To ListaPermisosQuitar.Count - 1
            listaIdROlesPermisos = objGestorRol.ConsultarIdPermisoROl(ListaPermisosQuitar.Item(i).Id, idRol)
        Next


        'For i As Integer = 0 To listaIdROlesPermisos.Count - 1
        '    objGestorRol.eliminarPermisoAUnRol(listaIdROlesPermisos.Item(i))
        'Next

    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class
