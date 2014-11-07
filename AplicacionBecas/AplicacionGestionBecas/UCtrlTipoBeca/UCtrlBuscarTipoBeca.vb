Imports EntitiesLayer


Public Class uCtrlBuscarTipoBeca

    Dim crearTipo As uCtrlCrearTipoBeca = New uCtrlCrearTipoBeca()
    Dim uCtrlConsultarTB As uCtrlConsultarTipoBeca = New uCtrlConsultarTipoBeca()

    
    Private Sub PantallaConsultarTipoBeca_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listarTiposBeca()

    End Sub
    Public Sub listarTiposBeca()
        Try
            Dim tipoBecas As List(Of TipoBeca) = gestorTipoBeca.consultarTipoBeca()
            dtaTipoBeca.Rows.Clear()

            For Each tipos As TipoBeca In tipoBecas

                dtaTipoBeca.Rows.Add(tipos.nombre, tipos.estado)

            Next
        Catch
            MsgBox("No se encontró un tipo de beca, ingrese uno")
        End Try

    End Sub


    Private Sub dtaTipoBeca_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtaTipoBeca.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dtaTipoBeca.CurrentCell.ColumnIndex = 2 Then
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
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim combo As ComboBox = CType(sender, ComboBox)

        If combo.SelectedItem = "Ver" Then

            verTipoBeca()

        ElseIf combo.SelectedItem = "Editar" Then

            editarTipoBeca()

        ElseIf combo.SelectedItem = "Eliminar" Then

            eliminarTipoBeca()

        End If

    End Sub
    Private Sub verTipoBeca()
        Dim nombre As String = dtaTipoBeca.CurrentRow.Cells(1).Value

        Dim uCtrlConsultarTipoBeca As New uCtrlConsultarTipoBeca

        'uCtrlConsultarTipoBeca.recibirInfo(nombre)
        frmPrincipal.Controls.Add(uCtrlConsultarTipoBeca)
        uCtrlConsultarTipoBeca.BringToFront()
        uCtrlConsultarTipoBeca.Show()
        uCtrlConsultarTipoBeca.Location = New Point(200, 150)
        Me.Hide()


    End Sub
    Private Sub editarTipoBeca()


        Dim nombre As String = dtaTipoBeca.CurrentRow.Cells(0).Value
        'Dim objD As Date = dtaTipoBeca.CurrentRow.Cells(1).Value
        Dim estado As String = dtaTipoBeca.CurrentRow.Cells(2).Value
        Dim descripcion As String = dtaTipoBeca.CurrentRow.Cells(3).Value


        Dim objTipoBeca As TipoBeca = gestorTipoBeca.buscarUnTipoBeca(nombre)
        Dim uCtrlModificarTB As New uCtrlModificarTipoBeca
        uCtrlModificarTB.objTipo = objTipoBeca

        frmPrincipal.Controls.Add(uCtrlModificarTB)
        uCtrlModificarTB.getFrmBuscar(Me)
        'uCtrlModificarTB.recieveData(id, nombre, objD, estado, descripcion)
        uCtrlModificarTB.BringToFront()
        uCtrlModificarTB.Show()
        uCtrlModificarTB.Location = New Point(290, 48)

    End Sub

    Private Sub eliminarTipoBeca()


        'Dim id As Integer = dtaTipoBeca.CurrentRow.Cells(0).Value
        Dim nombre As String = dtaTipoBeca.CurrentRow.Cells(0).Value
        Dim id As Integer = gestorTipoBeca.idTipoBeca(nombre)
        ' Dim objD As Date = dtaTipoBeca.CurrentRow.Cells(1).Value
        Dim estado As String = dtaTipoBeca.CurrentRow.Cells(1).Value
        Dim descripcion As String = dtaTipoBeca.CurrentRow.Cells(2).Value

        Dim eliminarTipoBeca As New EliminarTipoBeca

        frmPrincipal.Controls.Add(eliminarTipoBeca)
        eliminarTipoBeca.getUCtrBuscar(Me)
        eliminarTipoBeca.recibirDatos(id, nombre, estado, descripcion)
        eliminarTipoBeca.BringToFront()
        eliminarTipoBeca.Show()
        eliminarTipoBeca.Location = New Point(290, 48)


        listarTiposBeca()

    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.TextChanged
        Dim parametro As String = txtBarraBusqueda.Text

        Try
            Dim tipoBeca As TipoBeca = gestorTipoBeca.buscarUnTipoBeca(parametro)
            dtaTipoBeca.Rows.Clear()
            dtaTipoBeca.Rows.Add(1)
            dtaTipoBeca.Rows(0).Cells(0).Value = tipoBeca.nombre
            dtaTipoBeca.Rows(0).Cells(1).Value = tipoBeca.estado
        Catch ex As Exception
            dtaTipoBeca.Rows.Clear()
            listarTiposBeca()
        End Try
    End Sub


    Private Sub uCtrlBuscarTipoBeca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarTiposBeca()
    End Sub

    Private Sub btnCrearTipoBeca_Click(sender As Object, e As EventArgs) Handles btnCrearTipoBeca.Click
        crearTipo.Location = New Point(200, 250)
        crearTipo.BringToFront()
        FrmIniciarSesion.principal.Controls.Add(crearTipo)
        crearTipo.Show()
        Me.Hide()
    End Sub

End Class
