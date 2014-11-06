Imports EntitiesLayer
Public Class uCtrlConsultarTipoBeca
    Public Shared crearTipo As uCtrlCrearTipoBeca = New uCtrlCrearTipoBeca()
    Dim listaBeneficios As New List(Of Beneficio)
    Dim listaRequisitos As New List(Of Requisito)
    Public tipoBecas As List(Of TipoBeca)
    Public Sub listarTiposBeca()

        tipoBecas = gestorTipoBeca.consultarTipoBeca()

        For Each tipos As TipoBeca In tipoBecas

            dataGridVTipoBeca.Rows.Add(tipos.nombre, tipos.objD, tipos.estado, tipos.descripcion)

        Next

    End Sub
   
    Private Sub ListarTipoBeca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listarTiposBeca()
       

    End Sub
    Private Sub dataGridVTipoBeca_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridVTipoBeca.CellContentClick

        Dim senderGrid = DirectCast(sender, DataGridView)

        If dataGridVTipoBeca.Columns(e.ColumnIndex).Name = "Requisitos" Then

            requisitosConsultados()
            
        End If

        If dataGridVTipoBeca.Columns(e.ColumnIndex).Name = "Beneficios" Then
           beneficiosConsultados()
        End If
    End Sub
  

    Public Sub requisitosConsultados()
        Try
            Dim requisitos As uCtrlConsultarRequisitos = New uCtrlConsultarRequisitos
            Dim nombre As String = dataGridVTipoBeca.CurrentRow.Cells(0).Value
            Dim tipoBeca As TipoBeca = gestorTipoBeca.buscarUnTipoBeca(nombre)
            Dim requisitosLista As List(Of Requisito) = objGestorRequisito.mostrarRequisitoTB(tipoBeca)
            If requisitosLista.Count > 0 Then
                requisitos.setListaRequisitos(requisitosLista)
                frmPrincipal.Controls.Add(requisitos)
                requisitos.Location = New Point(420, 100)
                requisitos.BringToFront()
                Me.SendToBack()
                requisitos.Show()
            End If
        Catch ex As Exception
            MsgBox("El tipo de beca seleccionado no tiene requisitos asignados")

        End Try
    End Sub

    Public Sub beneficiosConsultados()
        Try
            Dim beneficios As uCtrlConsultarBeneficios = New uCtrlConsultarBeneficios
            Dim nombre As String = dataGridVTipoBeca.CurrentRow.Cells(0).Value
            Dim tipoBeca As TipoBeca = gestorTipoBeca.buscarUnTipoBeca(nombre)
            Dim beneficiosLista As List(Of Beneficio) = objGestorBeneficio.mostrarBeneficioTB(tipoBeca)
            If beneficiosLista.Count > 0 Then
                beneficios.setListaBeneficios(beneficiosLista)
                frmPrincipal.Controls.Add(beneficios)
                beneficios.Location = New Point(420, 100)
                beneficios.BringToFront()
                Me.SendToBack()
                beneficios.Show()
            End If
        Catch ex As Exception
            MsgBox("El tipo de beca seleccionado no tiene beneficios asignados")
           
        End Try
    End Sub
    Private Sub dataGridVTipoBeca_EditingControlShowing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dataGridVTipoBeca.EditingControlShowing
        ' Only for a DatagridComboBoxColumn at ColumnIndex 1.
        If dataGridVTipoBeca.CurrentCell.ColumnIndex = 2 Then
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



        If combo.SelectedItem = "Editar" Then

            editarTipoBeca()

        ElseIf combo.SelectedItem = "Eliminar" Then

            eliminarTipoBeca()

        End If

    End Sub
    'Private Sub verTipoBeca()
    '    Dim nombre As String = dataGridVTipoBeca.CurrentRow.Cells(1).Value

    '    Dim uCtrlConsultarTipoBeca As New uCtrlConsultarTipoBeca

    '    'uCtrlConsultarTipoBeca.recibirInfo(nombre)
    '    frmPrincipal.Controls.Add(uCtrlConsultarTipoBeca)
    '    uCtrlConsultarTipoBeca.BringToFront()
    '    uCtrlConsultarTipoBeca.Show()
    '    uCtrlConsultarTipoBeca.Location = New Point(200, 150)
    '    Me.Hide()


    'End Sub
    Private Sub editarTipoBeca()


        Dim nombre As String = dataGridVTipoBeca.CurrentRow.Cells(0).Value
        Dim estado As String = dataGridVTipoBeca.CurrentRow.Cells(1).Value
        Dim descripcion As String = dataGridVTipoBeca.CurrentRow.Cells(2).Value



        Dim uCtrlModificarTB As New uCtrlModificarTipoBeca


        frmPrincipal.Controls.Add(uCtrlModificarTB)
        'uCtrlModificarTB.getFrmBuscar(Me)
        uCtrlModificarTB.recibirDatos(nombre, estado, descripcion)
        uCtrlModificarTB.BringToFront()
        uCtrlModificarTB.Show()
        uCtrlModificarTB.Location = New Point(290, 48)

    End Sub

    Private Sub eliminarTipoBeca()



        Dim id As Integer = dataGridVTipoBeca.CurrentRow.Cells(0).Value
        Dim nombre As String = dataGridVTipoBeca.CurrentRow.Cells(1).Value
        Dim objD As Date = dataGridVTipoBeca.CurrentRow.Cells(2).Value
        Dim estado As String = dataGridVTipoBeca.CurrentRow.Cells(3).Value
        Dim descripcion As String = dataGridVTipoBeca.CurrentRow.Cells(4).Value

        Dim eliminarTipoBeca As New EliminarTipoBeca

        frmPrincipal.Controls.Add(eliminarTipoBeca)
        'eliminarTipoBeca.getUCtrlInstance(Me)
        'eliminarTipoBeca.recibirInfo(id, nombre, objD, estado, descripcion)
        'eliminarTipoBeca.BringToFront()
        'eliminarTipoBeca.Show()
        'eliminarTipoBeca.Location = New Point(290, 48)

        'eliminarTipoBeca.Rows.Clear()
        'listarTiposBeca()

    End Sub
End Class
