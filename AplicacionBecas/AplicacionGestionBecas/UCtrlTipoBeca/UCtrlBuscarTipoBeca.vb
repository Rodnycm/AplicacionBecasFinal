Imports EntitiesLayer


Public Class uCtrlBuscarTipoBeca

    Dim crearTipo As uCtrlCrearTipoBeca
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
            Dim uctrlAlerta As UctrlAlerta = New UctrlAlerta()
            Me.Controls.Add(uctrlAlerta)
            uctrlAlerta.Location = New Point(300, 100)
            uctrlAlerta.BringToFront()
            Me.SendToBack()
            uctrlAlerta.txtAlerta.Text = "Noy hay tipos de beca registrados"
            uctrlAlerta.Show()
        End Try

    End Sub


    Public Sub dtaTipoBeca_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dtaTipoBeca.EditingControlShowing
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
            Dim param = dtaTipoBeca.CurrentRow.Cells(0).Value
            verTipoBeca(param)
        ElseIf combo.SelectedItem = "Editar" Then

            editarTipoBeca()
        ElseIf combo.SelectedItem = "Eliminar" Then

            eliminarTipoBeca()
        End If
    End Sub

    Private Sub verTipoBeca(ByVal pparam As String)
        Dim nombre As String = pparam
        Dim uCtrlConsultarTipoBeca As New uCtrlConsultarTipoBeca()
        frmPrincipal.Controls.Add(uCtrlConsultarTipoBeca)
        uCtrlConsultarTipoBeca.enviarInfo(nombre)
        uCtrlConsultarTipoBeca.BringToFront()
        uCtrlConsultarTipoBeca.Location = New Point(200, 150)
        uCtrlConsultarTipoBeca.Show()




    End Sub
    Private Sub editarTipoBeca()


        Dim nombre As String = dtaTipoBeca.CurrentRow.Cells(0).Value
        'Dim objD As Date = dtaTipoBeca.CurrentRow.Cells(1).Value
        Dim estado As String = dtaTipoBeca.CurrentRow.Cells(1).Value
        Dim descripcion As String = dtaTipoBeca.CurrentRow.Cells(2).Value


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

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtBarraBusqueda.MouseClick

        txtBarraBusqueda.Text = ""

    End Sub

    ''' <summary>Cuando el evento se ejecuta al dar presionar la tecla enter llama al metodo eliminar carrera</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub txtBarraBusqueda_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs)

        Dim param As String = txtBarraBusqueda.Text

        If e.KeyCode = 13 Then

            buscarTipoBeca(param)

        End If

    End Sub

    Public Sub buscarTipoBeca(ByVal pparam)
        Try
            Dim tipoBeca As TipoBeca = gestorTipoBeca.buscarUnTipoBeca(pparam)
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

    Private Sub btnCrearTipoBeca_Click(sender As Object, e As EventArgs)
        crearTipo = New uCtrlCrearTipoBeca()
        FrmIniciarSesion.principal.Controls.Add(crearTipo)
        crearTipo.Location = New Point(300, 100)
        crearTipo.BringToFront()
        crearTipo.Show()


    End Sub

    Private Sub txtBarraBusqueda_TextChanged_1(sender As Object, e As EventArgs)
        If (txtBarraBusqueda.Text = "") Then
            listarTiposBeca()
        End If
    End Sub

    Private Sub txtBarraBusqueda_TextChanged(sender As Object, e As MouseEventArgs)

    End Sub
End Class
