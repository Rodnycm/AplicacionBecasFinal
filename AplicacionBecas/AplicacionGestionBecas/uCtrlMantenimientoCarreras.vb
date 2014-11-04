Imports EntitiesLayer

Public Class uCtrlMantenimientoCarreras

    Public Property uCtrlCarrera As uCtrlCrearCarrera = New uCtrlCrearCarrera()

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton crear carrera, muestra 
    ''' al usuario los datos para crear una carrera</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click

        uCtrlCarrera = New uCtrlCrearCarrera()
        frmPrincipal.Controls.Add(uCtrlCarrera)
        uCtrlCarrera.BringToFront()
        uCtrlCarrera.Show()

    End Sub

    ''' <summary>Metodo lista en un datagridview las carreras encontradas</summary>
    ''' <autor>Alvaro Artavia</autor>

    Public Sub listarCarreras()

        Dim listaCarreras As New List(Of Carrera)
        listaCarreras = objGestorCarrera.consultarCarreras

        For k As Integer = 0 To listaCarreras.Count - 1

            dgvCarreras.Rows.Add(1)
            dgvCarreras.Rows(k).Cells(0).Value = listaCarreras.Item(k).Nombre
            dgvCarreras.Rows(k).Cells(1).Value = listaCarreras.Item(k).codigo
            dgvCarreras.Rows(k).Cells(4).Value = listaCarreras.Item(k).Id

        Next

    End Sub

    Private Sub dgvConsultaCarreras_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvCarreras.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dgvCarreras.CurrentCell.ColumnIndex = 3 Then
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


    ''' <summary>Metodo encargado de controlar cuando se da click al combobox se ejecuten las acciones</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim combo As ComboBox = CType(sender, ComboBox)
        Dim fila As Integer = dgvCarreras.CurrentCell.RowIndex

        If combo.SelectedItem = "Editar" Then


            MsgBox(fila)
            modificarCarrera(fila)

        ElseIf combo.SelectedItem = "Eliminar" Then

            eliminarCarrera(fila)

        End If

    End Sub

    Private Sub uCtrlMantenimientoCarreras_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listarCarreras()

    End Sub


    ''' <summary>Metodo encargado instanciar la pantalla de modificar carrera y enviar los datos</summary>
    ''' <param name="numfila">Numero de fila en la que se encuentra el combobox</param>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub modificarCarrera(numfila As Integer)

        Dim value1 As Object = dgvCarreras.Rows(numfila).Cells(0).Value
        Dim value2 As Object = dgvCarreras.Rows(numfila).Cells(1).Value
        Dim value3 As Object = dgvCarreras.Rows(numfila).Cells(2).Value

        Dim uCtrlModCarrera As New uCtrlModificarCarrera()
        uCtrlModCarrera.txtCodigo.Text = CType(value1, String)
        uCtrlModCarrera.txtNombre.Text = CType(value2, String)
        uCtrlModCarrera.mantenimientoCarreras = Me
        frmPrincipal.Controls.Add(uCtrlModCarrera)
        uCtrlModCarrera.Show()
        uCtrlModCarrera.BringToFront()

    End Sub

    ''' <summary>Metodo encargado instanciar la pantalla de eliminar carrera y enviar los datos</summary>
    ''' <param name="numfila">Numero de fila en la que se encuentra el combobox</param>
    ''' <autor>Alvaro Artavia</autor>

    Public Sub eliminarCarrera(numFila As Integer)

        Dim uCtrlElimCarrera As New uCtrlEliminar()
        Dim value1 As Object = dgvCarreras.Rows(numFila).Cells(0).Value
        Dim value2 As Object = dgvCarreras.Rows(numFila).Cells(1).Value
        uCtrlElimCarrera.nombre = CType(value2, String)
        uCtrlElimCarrera.codigo = CType(value1, String)
        frmPrincipal.Controls.Add(uCtrlElimCarrera)
        uCtrlElimCarrera.Show()
        uCtrlElimCarrera.BringToFront()

    End Sub

    'Private Sub dtaConsultaCarreras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtaConsultaCarreras.CellContentClick

    '    Dim senderGrid = DirectCast(sender, DataGridView)
    '    If TypeOf senderGrid.Columns(e.ColumnIndex) Is DataGridViewComboBoxColumn AndAlso e.RowIndex >= 0 Then
    '    End If

    'End Sub

    Private Sub dgvCarreras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarreras.CellContentClick

    End Sub
End Class
