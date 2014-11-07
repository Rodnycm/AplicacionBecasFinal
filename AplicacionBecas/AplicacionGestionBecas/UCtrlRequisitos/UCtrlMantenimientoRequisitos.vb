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

        Try

            Dim r As Requisito = objGestorRequisito.buscarRequisito(param)

            dgvRequisitos.Rows.Clear()
            dgvRequisitos.Rows.Add(r.nombre, r.descripcion, "", "")

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
End Class
