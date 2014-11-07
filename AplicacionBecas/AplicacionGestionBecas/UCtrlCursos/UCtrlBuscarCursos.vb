Imports EntitiesLayer
Imports BLL



Public Class uCtrlBuscarCursos

    Dim ucCrearCurso As CrearCursos
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
        Dim fila As String = dtaListarCursos.CurrentRow.Cells(1).Value()

        If combo.SelectedItem = "Editar" Then

            modificarCurso(fila)



        ElseIf combo.SelectedItem = "Eliminar" Then

            eliminarCurso(fila)


            '

        End If



    End Sub
  
    Public Sub modificarCurso(ByVal pfila As String)

        Dim codigo As String = pfila

        Dim ucntrl As uCtrlModificarCurso = New uCtrlModificarCurso()

        ucntrl.recieveData(codigo)

        'imgBuscarCursos.Hide()
        FrmIniciarSesion.principal.Controls.Add(ucntrl)
        ucntrl.BringToFront()
        ucntrl.Show()
        'ucntrl.setParametro(pparametro)
        ucntrl.Location = New Point(290, 48)
        ucntrl.refrecarLista(Me)

    End Sub

    Public Sub eliminarCurso(ByVal pfila As String)


        Dim codigo As String = pfila

        Dim ucntrl As uCtrlEliminarCurso = New uCtrlEliminarCurso()
        ucntrl.recieveData(codigo)
        FrmIniciarSesion.principal.Controls.Add(ucntrl)
        ucntrl.BringToFront()
        ucntrl.Show()
        ucntrl.Location = New Point(280, 48)
        ucntrl.refrecarLista(Me)

    End Sub
    Public Sub listarCursos()


        Try
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

        Catch ex As Exception

            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(300, 100)
            uctrlAlerta.BringToFront()
            Me.SendToBack()
            uctrlAlerta.lblAlerta.Text = "No hay usuarios registrados"
            uctrlAlerta.Show()

        End Try
        




    End Sub
    Public Sub buscarCursos(parametro As String)


        Dim buscarCursos As Curso
        buscarCursos = objGestorCurso.BuscarCurso(parametro)


    End Sub
    Public Sub txtBuscarCurso_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCurso.TextChanged


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
    Private Sub uCtrlBuscarCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        listarCursos()


    End Sub
    Private Sub btnCrearCurso_Click_1(sender As Object, e As EventArgs) Handles btnCrearCurso.Click


        ucCrearCurso = New CrearCursos()
        FrmIniciarSesion.principal.Controls.Add(ucCrearCurso)
        ucCrearCurso.Visible = True
        ucCrearCurso.BringToFront()
        ucCrearCurso.Show()
        ucCrearCurso.Location = New Point(290, 48)
        ucCrearCurso.refrecarLista(Me)


    End Sub


End Class