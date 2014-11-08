Imports EntitiesLayer

Public Class uCtrlMantenimientoRequisitos

    Public Property UCtrlCrearRequisito As uCtrlMantenimientoCrearRequisito = New uCtrlMantenimientoCrearRequisito()

    Public Sub listarRequisitos()

        Try

            dgvRequisitos.Rows.Clear()
            Dim listaRequisitos As New List(Of Requisito)
            listaRequisitos = objGestorRequisito.consultarRequisitos

            For Each requisito As Requisito In listaRequisitos

                dgvRequisitos.Rows.Add(requisito.nombre, requisito.descripcion, "", requisito.Id)

            Next

        Catch ex As Exception

            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(300, 100)
            uctrlAlerta.BringToFront()
            uctrlAlerta.txtAlerta.Text = "No hay requisitos registrados"
            uctrlAlerta.Show()

        End Try

    End Sub


    Private Sub txtBuscar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown

        Dim param As String = txtBuscar.Text

        If e.KeyCode = 13 Then

            buscarRequisito(param)

        End If

    End Sub

    Private Sub buscarRequisito(ByVal param As String)

        Try

            Dim r As Requisito = objGestorRequisito.buscarRequisito(param)

            dgvRequisitos.Rows.Clear()
            dgvRequisitos.Rows.Add(r.nombre, r.descripcion, "", r.Id)

        Catch ex As Exception


            dgvRequisitos.Rows.Clear()
            listarRequisitos()

        End Try
       
    End Sub

    Private Sub uCtrlMantenimientoRequisitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listarRequisitos()

    End Sub

    Private Sub btnCrearRequisito_Click(sender As Object, e As EventArgs) Handles btnCrearRequisito.Click

        UCtrlCrearRequisito = New uCtrlMantenimientoCrearRequisito()
        UCtrlCrearRequisito.mantenimientoRequisito = Me
        FrmIniciarSesion.principal.Controls.Add(uCtrlCrearRequisito)
        uCtrlCrearRequisito.BringToFront()
        uCtrlCrearRequisito.Show()

    End Sub

    Private Sub dgvRequisitos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvRequisitos.EditingControlShowing



        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dgvRequisitos.CurrentCell.ColumnIndex = 2 Then
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
    ''' <autor>Valeria Ramírez Cordero</autor>



    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim combo As ComboBox = CType(sender, ComboBox)
        Dim fila As Integer = dgvRequisitos.CurrentCell.RowIndex

        If combo.SelectedItem = "Editar" Then

            modificarRequisito(fila)



        ElseIf combo.SelectedItem = "Eliminar" Then

            eliminarRequisito(fila)


            '

        End If
    End Sub

    Public Sub modificarRequisito(ByVal pfila As String)

        Dim nombre As String = pfila

        Dim ucntrl As UCtrlModificarRequisito = New UCtrlModificarRequisito()

        ucntrl.recieveData(nombre)

        'imgBuscarCursos.Hide()
        FrmIniciarSesion.principal.Controls.Add(ucntrl)
        ucntrl.BringToFront()
        ucntrl.Show()
        'ucntrl.setParametro(pparametro)
        ucntrl.Location = New Point(290, 48)
        ucntrl.refrecarLista(Me)

    End Sub

    Private Sub eliminarRequisito(numfila As Integer)
            Dim nombre As String = dgvRequisitos.Rows(numfila).Cells(1).Value
            Dim descripcion As String = dgvRequisitos.Rows(numfila).Cells(0).Value
            Dim idRequisito As Integer = dgvRequisitos.Rows(numfila).Cells(3).Value
            Dim uCtrlElirequsito As New UCtrlEliminarRequisitos()
            uCtrlElirequsito.recieveData(nombre, descripcion, idRequisito)
        uCtrlElirequsito.getFrmBuscar(Me)

            FrmIniciarSesion.principal.Controls.Add(uCtrlElirequsito)

            uCtrlElirequsito.Show()
            uCtrlElirequsito.Location = New Point(256, 226)
            uCtrlElirequsito.BringToFront()

    End Sub
 
End Class
