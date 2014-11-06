﻿Imports EntitiesLayer

Public Class uCtrlMantenimientoCarreras

    Implements IDisposable

    Public Property uCtrlCarrera As uCtrlCrearCarrera

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton crear carrera, muestra 
    ''' al usuario los datos para crear una carrera</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click

        uCtrlCarrera = New uCtrlCrearCarrera()
        uCtrlCarrera.mantenimientoCarreras = Me
        FrmIniciarSesion.principal.Controls.Add(uCtrlCarrera)
        uCtrlCarrera.BringToFront()
        uCtrlCarrera.Show()

    End Sub

    ''' <summary>Metodo lista en un datagridview las carreras encontradas</summary>
    ''' <autor>Alvaro Artavia</autor>

    Public Sub listarCarreras()

        Try

            dgvCarreras.Rows.Clear()
            Dim listaCarreras As New List(Of Carrera)
            listaCarreras = objGestorCarrera.consultarCarreras

            For Each carrera As Carrera In listaCarreras

                dgvCarreras.Rows.Add(carrera.codigo, carrera.nombre, carrera.directorAcademico.primerNombre & " " & carrera.directorAcademico.primerApellido & " " & carrera.directorAcademico.segundoApellido, "", "", carrera.Id)

            Next

        Catch ex As Exception

            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(300, 100)
            uctrlAlerta.BringToFront()
            uctrlAlerta.lblAlerta.Text = "No hay carreras registradas"
            uctrlAlerta.Show()

        End Try

    End Sub

    Private Sub dgvConsultaCarreras_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvCarreras.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dgvCarreras.CurrentCell.ColumnIndex = 4 Then
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
        Dim value4 As Object = dgvCarreras.Rows(numfila).Cells(5).Value

        Dim uCtrlModCarrera As New uCtrlModificarCarrera()
        uCtrlModCarrera.txtCodigo.Text = CType(value1, String)
        uCtrlModCarrera.txtNombre.Text = CType(value2, String)
        uCtrlModCarrera.idCarrera = CType(value4, Integer)
        uCtrlModCarrera.cmbAcademico.Text = value3
        uCtrlModCarrera.directorAntiguo = value3
        uCtrlModCarrera.mantenimientoCarreras = Me
        FrmIniciarSesion.principal.Controls.Add(uCtrlModCarrera)
        uCtrlModCarrera.Show()
        uCtrlModCarrera.BringToFront()

    End Sub

    ''' <summary>Metodo encargado instanciar la pantalla de eliminar carrera y enviar los datos</summary>
    ''' <param name="numfila">Numero de fila en la que se encuentra el combobox</param>
    ''' <autor>Alvaro Artavia</autor>

    Public Sub eliminarCarrera(numFila As Integer)

        Dim uCtrlElimCarrera As New uCtrlEliminarCarrera()
        Dim value1 As Object = dgvCarreras.Rows(numFila).Cells(0).Value
        Dim value2 As Object = dgvCarreras.Rows(numFila).Cells(1).Value
        uCtrlElimCarrera.nombre = CType(value2, String)
        uCtrlElimCarrera.codigo = CType(value1, String)
        FrmIniciarSesion.principal.Controls.Add(uCtrlElimCarrera)
        uCtrlElimCarrera.Show()
        uCtrlElimCarrera.BringToFront()
        uCtrlElimCarrera.mantenimientoCarreras = Me

    End Sub

    ''' <summary>Cuando el evento se ejecuta el nombre del textbox queda vacio</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.MouseClick

        txtBuscar.Text = ""

    End Sub

    ''' <summary>Cuando el evento se ejecuta al dar presionar la tecla enter llama al metodo eliminar carrera</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub txtBuscar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown

        Dim param As String = txtBuscar.Text

        If e.KeyCode = 13 Then

            buscarCarrera(param)

        End If

    End Sub

    ''' <summary>Busca la carrera por medio del parametro que el usuario digito</summary>
    ''' <param name="param">Parametro nombre o codigo para filtrar la busqueda</param>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub buscarCarrera(ByVal param As String)

        Try

            Dim c As Carrera = objGestorCarrera.buscarCarrera(param)
            dgvCarreras.Rows.Clear()
            dgvCarreras.Rows.Add(c.codigo, c.nombre, c.directorAcademico.primerNombre & " " & c.directorAcademico.primerApellido & " " & c.directorAcademico.segundoApellido, "", "", c.Id)

        Catch ex As Exception

            listarCarreras()

        End Try

    End Sub

    Public Sub asignarCursosACarrera()

        Dim listaCursos As New List(Of Curso)
        'listaCursos = objGestorCurso.listarCursos

    End Sub

    ''' <summary>Evento que se ejecuta cuando el usuario da click al boton cursos del datagridview</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub dgvCarreras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCarreras.CellContentClick

        If dgvCarreras.Columns(e.ColumnIndex).Name = "Cursos" Then

        End If

    End Sub

End Class
