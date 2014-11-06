﻿Imports EntitiesLayer
Public Class uCtrlConsultarTipoBeca
    Public Shared crearTipo As uCtrlCrearTipoBeca = New uCtrlCrearTipoBeca()
    Dim listaBeneficios As New List(Of Beneficio)
    Dim listaRequisitos As New List(Of Requisito)
    Public Sub listarTiposBeca()

        Dim tipoBecas As List(Of TipoBeca) = gestorTipoBeca.consultarTipoBeca()

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
        'Try
        '    Dim requisitos As uCtrlConsultarRequisitos = New uCtrlConsultarRequisitos
        '    Dim nombre As String = dataGridVTipoBeca.CurrentRow.Cells(0).Value
        '    Dim tipoBeca As TipoBeca = gestorTipoBeca.buscarUnTipoBeca(nombre)
        '    Dim requisitosLista As List(Of Requisito) = objGestorRequisito.mostrarRequisitoTB(tipoBeca)
        '    If requisitosLista.Count > 0 Then
        '        requisitos.setListaRequisitos(requisitosLista)
        '        frmPrincipal.Controls.Add(requisitos)
        '        requisitos.Location = New Point(420, 100)
        '        requisitos.BringToFront()
        '        Me.SendToBack()
        '        requisitos.Show()
        '    End If
        'Catch ex As Exception
        '    MsgBox("El tipo de beca seleccionado no tiene requisitos asignados")

        'End Try
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
End Class