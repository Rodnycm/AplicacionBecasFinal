﻿Imports EntitiesLayer

Public Class uCtrlMantenimientoRequisitos

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
            uctrlAlerta.lblAlerta.Text = "No hay requisitos registrados"
            uctrlAlerta.Show()

        End Try

    End Sub

    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.MouseClick

        txtBuscar.Text = ""

    End Sub

    Private Sub txtBuscar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown

        Dim param As String = txtBuscar.Text

        If e.KeyCode = 13 Then

            buscarRequisito(param)

        End If

    End Sub

    Private Sub buscarRequisito(ByVal param As String)

        Dim r As Requisito = objGestorRequisito.buscarRequisito(param)

        dgvRequisitos.Rows.Clear()
        dgvRequisitos.Rows.Add(r.nombre, r.descripcion, "", "")

        If r.nombre = "" Then

            dgvRequisitos.Rows.Clear()
            listarRequisitos()

        End If

    End Sub

    Private Sub uCtrlMantenimientoRequisitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listarRequisitos()

    End Sub

    Private Sub btnCrearRequisito_Click(sender As Object, e As EventArgs) Handles btnCrearRequisito.Click

    End Sub
End Class