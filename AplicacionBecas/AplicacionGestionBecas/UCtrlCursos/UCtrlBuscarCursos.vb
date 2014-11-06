Imports EntitiesLayer
Imports BLL



Public Class uCtrlBuscarCursos

    Dim ucCrearCurso As UCtrlCrearCursos
    Dim ucModificarCurso As uCtrlModificarCurso
    Dim ucEliminarCurso As uCtrlEliminarCurso
    Dim idCurso As Integer
    Dim nombreCurso As String
    Dim codigoCurso As String


    Private Sub dtaListarCursos_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtaListarCursos.EditingControlShowing



        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dtaListarCursos.CurrentCell.ColumnIndex = 5 Then
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
        Dim fila As Integer = dtaListarCursos.CurrentCell.RowIndex

        If combo.SelectedItem = "Editar" Then

            Dim parametro = dtaListarCursos.CurrentRow.Cells(0).Value
            modificarCurso()


            'modificarCarrera(fila)

        ElseIf combo.SelectedItem = "Eliminar" Then

            eliminarCurso()


            'eliminarCarrera(fila)

        End If



    End Sub

    Public Sub modificarCurso()


        'Dim id As Integer

        Dim nombre As String = dtaListarCursos.CurrentRow.Cells(0).Value
        Dim codigo As String = dtaListarCursos.CurrentRow.Cells(1).Value
        Dim cuatrimestre As String = dtaListarCursos.CurrentRow.Cells(2).Value
        Dim creditos As Integer = dtaListarCursos.CurrentRow.Cells(3).Value
        Dim precio As Double = dtaListarCursos.CurrentRow.Cells(4).Value
        Dim id As Integer = dtaListarCursos.CurrentRow.Cells(6).Value

        Dim ucntrl As uCtrlModificarCurso = New uCtrlModificarCurso()

        ucntrl.recieveData(nombre, codigo, cuatrimestre, creditos, precio, id)

        'imgBuscarCursos.Hide()
        frmPrincipal.Controls.Add(ucntrl)
        ucntrl.BringToFront()
        ucntrl.Show()
        'ucntrl.setParametro(pparametro)
        ucntrl.Location = New Point(290, 48)




    End Sub

    Public Sub eliminarCurso()

        Dim nombre As String = dtaListarCursos.CurrentRow.Cells(0).Value
        Dim codigo As String = dtaListarCursos.CurrentRow.Cells(1).Value
        Dim id As Integer = dtaListarCursos.CurrentRow.Cells(6).Value

        Dim ucntrl As uCtrlEliminarCurso = New uCtrlEliminarCurso()
        ucntrl.recieveData(idCurso, nombre, codigo)

        frmPrincipal.Controls.Add(ucntrl)
        ucntrl.BringToFront()
        ucntrl.Show()
        ucntrl.Location = New Point(280, 48)


    End Sub
    Public Sub listarCursos()



        Dim listarCursos As List(Of Curso)
        listarCursos = objGestorCurso.consultarCursos()

        For i As Integer = 0 To listarCursos.Count - 1

            dtaListarCursos.Rows.Add(1)
            dtaListarCursos.Rows(i).Cells(1).Value = listarCursos.Item(i).codigo
            dtaListarCursos.Rows(i).Cells(0).Value = listarCursos.Item(i).nombre
            dtaListarCursos.Rows(i).Cells(2).Value = listarCursos.Item(i).cuatrimestre
            dtaListarCursos.Rows(i).Cells(3).Value = listarCursos.Item(i).creditos
            dtaListarCursos.Rows(i).Cells(4).Value = listarCursos.Item(i).precio
            dtaListarCursos.Rows(i).Cells(6).Value = listarCursos.Item(i).Id
        Next




    End Sub
    Public Sub buscarCursos(parametro As String)


        Dim buscarCursos As Curso
        buscarCursos = objGestorCurso.BuscarCurso(parametro)


    End Sub
    Public Sub txtBuscarCurso_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCurso.TextChanged, txtBuscarCurso.VisibleChanged


        Dim parametro As String = txtBuscarCurso.Text

        Try
            Dim objCurso As Curso = objGestorCurso.BuscarCurso(parametro)

            dtaListarCursos.Rows.Clear()
            dtaListarCursos.Rows.Add(1)
            dtaListarCursos.Rows(0).Cells(0).Value = objCurso.nombre
            dtaListarCursos.Rows(0).Cells(1).Value = objCurso.codigo
            dtaListarCursos.Rows(0).Cells(2).Value = objCurso.cuatrimestre
            dtaListarCursos.Rows(0).Cells(3).Value = objCurso.creditos
            dtaListarCursos.Rows(0).Cells(4).Value = objCurso.precio
            dtaListarCursos.Rows(0).Cells(6).Value = objCurso.Id


        Catch ex As Exception
            dtaListarCursos.Rows.Clear()
            listarCursos()



        End Try


    End Sub
    Private Sub btnCrearCurso_Click(sender As Object, e As EventArgs)


        ucCrearCurso = New UCtrlCrearCursos()
        frmPrincipal.Controls.Add(ucCrearCurso)
        ucCrearCurso.BringToFront()
        ucCrearCurso.Show()
        ucCrearCurso.Location = New Point(300, 100)



    End Sub
    Private Sub uCtrlBuscarCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        listarCursos()


    End Sub
    Private Sub btnCrearCurso_Click_1(sender As Object, e As EventArgs) Handles btnCrearCurso.Click


        ucCrearCurso = New UCtrlCrearCursos()
        frmPrincipal.Controls.Add(ucCrearCurso)
        ucCrearCurso.BringToFront()
        ucCrearCurso.Show()
        ucCrearCurso.Location = New Point(290, 48)



    End Sub

    Private Sub dtaListarCursos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtaListarCursos.CellContentClick

    End Sub
End Class
