Public Class uCtrlMenuMantenimiento

    Public Property uCtrlMantCarreras As uCtrlMantenimientoCarreras
    Public Property uCtrlMantCursos As uCtrlMantenimientoCursos
    Public Property uCtrlMantRequisitos As uCtrlMantenimientoRequisitos
    Public Property uCntrlMantRol As uCtrlListarRol
    Public Property ucntrlUsuario As UctrlListarYBuscarUsuario
    Public Property uCntrlBuscarBeneficio As uCtrlListarYBuscarBeneficiosvb
    '' Dim ListarRol As New ListarRol()
    Private Sub btnRequisitos_Click(sender As Object, e As EventArgs) Handles btnRequisitos.Click
        uCtrlMantRequisitos = New uCtrlMantenimientoRequisitos()
        Me.Hide()
        'uCtrlMantRequisitos = New uCtrlMantenimientoRequisitos()
        FrmIniciarSesion.principal.Controls.Add(uCtrlMantRequisitos)
        uCtrlMantRequisitos.Show()

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton cursos, muestra 
    ''' al usuario el menu de cursos</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click
        uCtrlMantCursos = New uCtrlMantenimientoCursos()
        Me.Hide()
        'uCtrlMantCursos = New uCtrlMantenimientoCursos()
        FrmIniciarSesion.principal.Controls.Add(uCtrlMantCursos)
        uCtrlMantCursos.Show()

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton carreras, muestra 
    ''' al usuario el menu de carreras</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCarreras_Click(sender As Object, e As EventArgs) Handles btnCarreras.Click
        uCtrlMantCarreras = New uCtrlMantenimientoCarreras()
        Me.Hide()
        'uCtrlMantCarreras = New uCtrlMantenimientoCarreras()
        FrmIniciarSesion.principal.Controls.Add(uCtrlMantCarreras)
        uCtrlMantCarreras.Show()

    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        uCntrlMantRol = New uCtrlListarRol()
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(uCntrlMantRol)
        uCntrlMantRol.Location = New Point(210, 100)
        uCntrlMantRol.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        ucntrlUsuario = New UctrlListarYBuscarUsuario()
        'Dim ucntrlUsuario As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()

        Me.SendToBack()
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(ucntrlUsuario)
        ucntrlUsuario.Location = New Point(120, 0)
        ucntrlUsuario.Show()

    End Sub

    Private Sub btnBeneficios_Click(sender As Object, e As EventArgs) Handles btnBeneficios.Click
        uCntrlBuscarBeneficio = New uCtrlListarYBuscarBeneficiosvb()
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(uCntrlBuscarBeneficio)
        uCntrlBuscarBeneficio.Show()
        uCntrlBuscarBeneficio.Location = New Point(130, 50)
    End Sub

    Private Sub btnBecas_Click(sender As Object, e As EventArgs) Handles btnBecas.Click

    End Sub
End Class
