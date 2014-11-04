Public Class uCtrlMenuMantenimiento

    Public Property uCtrlMantCarreras As uCtrlMantenimientoCarreras = New uCtrlMantenimientoCarreras()
    Public Property uCtrlMantCursos As uCtrlMantenimientoCursos = New uCtrlMantenimientoCursos()
    Public Property uCtrlMantRequisitos As uCtrlMantenimientoRequisitos = New uCtrlMantenimientoRequisitos()
    Public Property uCntrlMantRol As uCtrlListarRol = New uCtrlListarRol()
    Public Property ucntrlUsuario As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
    Public Property uCntrlBuscarBeneficio As uCntrlBuscarBeneficio = New uCntrlBuscarBeneficio()
    '' Dim ListarRol As New ListarRol()
    Private Sub btnRequisitos_Click(sender As Object, e As EventArgs) Handles btnRequisitos.Click

        Me.Hide()
        uCtrlMantRequisitos = New uCtrlMantenimientoRequisitos()
        frmPrincipal.Controls.Add(uCtrlMantRequisitos)
        uCtrlMantRequisitos.Show()

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton cursos, muestra 
    ''' al usuario el menu de cursos</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click

        Me.Hide()
        uCtrlMantCursos = New uCtrlMantenimientoCursos()
        frmPrincipal.Controls.Add(uCtrlMantCursos)
        uCtrlMantCursos.Show()

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton carreras, muestra 
    ''' al usuario el menu de carreras</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCarreras_Click(sender As Object, e As EventArgs) Handles btnCarreras.Click

        Me.Hide()
        uCtrlMantCarreras = New uCtrlMantenimientoCarreras()
        frmPrincipal.Controls.Add(uCtrlMantCarreras)
        uCtrlMantCarreras.Show()

    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(uCntrlMantRol)
        uCntrlMantRol.Location = New Point(210, 100)
        uCntrlMantRol.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

        Dim ucntrlUsuario As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()

        Me.SendToBack()
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(ucntrlUsuario)
        ucntrlUsuario.Location = New Point(120, 0)
        ucntrlUsuario.Show()

    End Sub

    Private Sub btnBeneficios_Click(sender As Object, e As EventArgs) Handles btnBeneficios.Click
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(uCntrlBuscarBeneficio)
        uCntrlBuscarBeneficio.Show()
        uCntrlBuscarBeneficio.Location = New Point(130, 50)
    End Sub

    Private Sub btnBecas_Click(sender As Object, e As EventArgs) Handles btnBecas.Click

    End Sub
End Class
