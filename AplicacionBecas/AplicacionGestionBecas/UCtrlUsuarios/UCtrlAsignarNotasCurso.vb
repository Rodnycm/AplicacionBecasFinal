Imports EntitiesLayer
Imports BLL

Public Class UCtrlAsignarNotasCurso

    Private Sub txtBuscar_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txtBuscar.KeyDown

        Dim param As String = txtBuscar.Text

        If e.KeyCode = 13 Then

            buscarUsuario(param)

        End If

    End Sub
    Private Sub ComboBox_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim combo As ComboBox = CType(sender, ComboBox)

        If combo.SelectedItem = "Ver" Then
            Dim parametro = dgUsuarios.CurrentRow.Cells(0).Value
            'consultarUsuario(parametro)
        End If

    End Sub
    Public Sub buscarUsuario(ByVal pparametro As String)
        Try
            Dim objUsuario As Usuario = objGestorUsuario.buscarUnUsuario(txtBuscar.Text)
            dgUsuarios.Rows.Clear()
            dgUsuarios.Rows.Add(objUsuario.identificacion, objUsuario.primerNombre & " " & objUsuario.primerApellido)
        Catch ex As Exception
            dgUsuarios.Rows.Clear()
            'listarUsuarios()
        End Try
    End Sub
    Private Sub txtBuscar_TextChanged(sender As Object, e As EventArgs) Handles txtBuscar.MouseClick

        txtBuscar.Text = ""

    End Sub

End Class
