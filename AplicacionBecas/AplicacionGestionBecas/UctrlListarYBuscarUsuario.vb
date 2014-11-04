Imports EntitiesLayer
Public Class UctrlListarYBuscarUsuario
    Dim ucntrlUsuario As UctrlCrearUsuario = New UctrlCrearUsuario()
    Dim ctrlUsuario As UCtrlConsultarUsuario = New UCtrlConsultarUsuario()

    Public Sub UctrlListarYBuscarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarUsuarios()
    End Sub

    '<summary> Método que se encarga de listar los usuarios que hay registrados en el sistema</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<param> No recibe valor  </param>
    '<returns> No retorna valor.</returns> 
    Public Sub listarUsuarios()
        Try
            dgUsuarios.Rows.Clear()
            Dim listaUsuarios As List(Of Usuario)
            listaUsuarios = objGestorUsuario.buscarUsuarios()

            For Each usuario As Usuario In listaUsuarios
                dgUsuarios.Rows.Add(usuario.identificacion, usuario.primerNombre & " " & usuario.primerApellido & " " & usuario.segundoApellido, usuario.rol.Nombre)
            Next
        Catch ex As Exception
            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            FrmIniciarSesion.principal.Controls.Add(ucntrlUsuario)
            uctrlAlerta.Location = New Point(300, 100)
            uctrlAlerta.BringToFront()
            uctrlAlerta.lblAlerta.Text = "No hay usuarios registrados"
            uctrlAlerta.Show()


        End Try

    End Sub

    Public Sub btnCrearUsuario_Click(sender As Object, e As EventArgs) Handles btnCrearUsuario.Click
        FrmIniciarSesion.principal.Controls.Add(ucntrlUsuario)
        ucntrlUsuario.setLista(Me)
        ucntrlUsuario.Location = New Point(300, 100)
        ucntrlUsuario.BringToFront()
        ucntrlUsuario.Show()
    End Sub

    Public Sub dgUsuarios_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgUsuarios.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dgUsuarios.CurrentCell.ColumnIndex = 3 Then
            Dim combo As ComboBox = CType(e.Control, ComboBox)
            If (combo IsNot Nothing) Then
                ' Remove an existing event-handler, if present, to avoid 
                ' adding multiple handlers when the editing control is reused.
                RemoveHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)

                ' Add the event handler. 
                AddHandler combo.SelectionChangeCommitted, New EventHandler(AddressOf ComboBox_SelectionChangeCommitted)
            End If
        End If
    End Sub

    '<summary> Método que se encarga de consultar un usuario del sistema</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<param name = "parametro"> variable que almacena el parametro con la identificacion del usuario que se desea consultar </param>
    '<returns> No retorna valor.</returns> 
    Public Sub consultarUsuario(ByVal pparametro As String)
        Me.Hide()
        ctrlUsuario.setParametro(pparametro)
        FrmIniciarSesion.principal.Controls.Add(ctrlUsuario)
        ctrlUsuario.Location = New Point(120, 0)
        ctrlUsuario.Show()

    End Sub

    '<summary> Método que se encarga de eliminar un usuario del sistema</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<param name = "parametro"> variable que almacena el parametro con la identificacion del usuario que se desea eliminar </param>
    '<returns> No retorna valor.</returns> 
    Public Sub eliminarUsuario(ByVal parametro As String)
        Dim ucntrl As UctrlEliminarUsuario = New UctrlEliminarUsuario()
        ucntrl.setParametro(parametro)
        ucntrl.refrescarLista(Me)
        'FrmIniciarSesion.principal.Controls.Add(ctrlUsuario)
        Me.Controls.Add(ucntrl)
        Me.dgUsuarios.SendToBack()
        Me.PbUsuarios.SendToBack()
        ucntrl.BringToFront()
        ucntrl.Location = New Point(280, 250)
        ucntrl.Show()
    End Sub

    '<summary> Método que se encarga de modificar un usuario del sistema</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<param name = "parametro"> variable que almacena el parametro con la identificacion del usuario que se desea modificar </param>
    '<returns> No retorna valor.</returns> 
    Public Sub modificarUsuario(ByVal pparametro As String)
        Dim ucntrl As UctrlModificarUsuario = New UctrlModificarUsuario()
        ucntrl.setParametro(pparametro)
        'frmPrincipal.Controls.Add(ucntrl)
        Me.Controls.Add(ucntrl)
        ucntrl.refrecarLista(Me)
        Me.dgUsuarios.SendToBack()
        Me.PbUsuarios.SendToBack()
        Me.btnCrearUsuario.SendToBack()
        Me.txtBuscar.SendToBack()
        ucntrl.Location = New Point(100, 50)
        ucntrl.Show()
    End Sub


    '<summary> Método que se encarga seleccionar las opciones del usuario</summary>
    '<author> Gabriela Gutiérrez Corrales </author> 
    '<returns> No retorna valor.</returns> 
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim combo As ComboBox = CType(sender, ComboBox)

        If combo.SelectedItem = "Ver" Then
            Dim parametro = dgUsuarios.CurrentRow.Cells(0).Value
            consultarUsuario(parametro)
        ElseIf combo.SelectedItem = "Editar" Then
            Dim parametro = dgUsuarios.CurrentRow.Cells(0).Value
            modificarUsuario(parametro)
        ElseIf combo.SelectedItem = "Eliminar" Then
            Dim parametro = dgUsuarios.CurrentRow.Cells(0).Value
            eliminarUsuario(parametro)
        End If
    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.TextChanged, txtBuscar.VisibleChanged
        Try
            Dim objUsuario As Usuario = objGestorUsuario.buscarUnUsuario(txtBuscar.Text)
            dgUsuarios.Rows.Clear()
            dgUsuarios.Rows.Add(objUsuario.identificacion, objUsuario.primerNombre & " " & objUsuario.primerApellido & " " & objUsuario.segundoApellido, objUsuario.rol.Nombre)
        Catch ex As Exception
            dgUsuarios.Rows.Clear()
            listarUsuarios()
        End Try

    End Sub

End Class




