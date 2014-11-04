Imports EntitiesLayer

Public Class uCtrlMantenimientoRequisitos

    Dim uCntrlRequisito As uCtrlMantenimientoCrearRequisito = New uCtrlMantenimientoCrearRequisito()
    Dim uCntrlRol As UCntrlRegistrarRol = New UCntrlRegistrarRol()
    Dim ucntrlUsuario As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()


    Public Sub listarCarreras()

        Dim listaRequisitos As New List(Of Requisito)
        listaRequisitos = objGestorRequisito.consultarRequisitos

        For k As Integer = 0 To listaRequisitos.Count - 1

            dgvRequisitos.Rows.Add(1)
            dgvRequisitos.Rows(k).Cells(0).Value = listaRequisitos.Item(k).nombre
            dgvRequisitos.Rows(k).Cells(1).Value = listaRequisitos.Item(k).descripcion

        Next

    End Sub

    Private Sub dtaConsultaCarreras_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRequisitos.CellContentClick

    End Sub

    Private Sub uCtrlMantenimientoRequisitos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        listarCarreras()

    End Sub

    Private Sub btnCrearRequisito_Click(sender As Object, e As EventArgs) Handles btnCrearRequisito.Click

        Me.Hide()
        frmPrincipal.Controls.Add(uCntrlRequisito)
        uCntrlRequisito.Location = New Point(400, 150)
        uCntrlRequisito.Show()

    End Sub
End Class
