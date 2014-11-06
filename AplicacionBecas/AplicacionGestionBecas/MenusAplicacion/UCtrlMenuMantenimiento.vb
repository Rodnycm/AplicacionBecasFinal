﻿Public Class uCtrlMenuMantenimiento

    Public Property uCtrlMantCarreras As uCtrlMantenimientoCarreras = New uCtrlMantenimientoCarreras
    Public Property uCtrlMantCursos As uCtrlMantenimientoCursos = New uCtrlMantenimientoCursos()
    Public Property uCtrlMantRequisitos As uCtrlMantenimientoRequisitos = New uCtrlMantenimientoRequisitos()
    Public Property uCntrlMantRol As uCtrlListarRol = New uCtrlListarRol()
    Public Property ucntrlUsuario As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
    Public Property uCntrlBuscarBeneficio As UCtrlBuscarBeneficio = New UCtrlBuscarBeneficio()
    Public Property uCtrlTipoBeca As uCtrlBuscarTipoBeca = New uCtrlBuscarTipoBeca
    '' Dim ListarRol As New ListarRol()
    Private Sub btnRequisitos_Click(sender As Object, e As EventArgs) Handles btnRequisitos.Click

        Me.Hide()
        'uCtrlMantRequisitos = New uCtrlMantenimientoRequisitos()
        FrmIniciarSesion.principal.Controls.Add(uCtrlMantRequisitos)
        uCtrlMantRequisitos.Show()

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton cursos, muestra 
    ''' al usuario el menu de cursos</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCursos_Click(sender As Object, e As EventArgs) Handles btnCursos.Click

        Me.Hide()
        'uCtrlMantCursos = New uCtrlMantenimientoCursos()
        FrmIniciarSesion.principal.Controls.Add(uCtrlMantCursos)
        uCtrlMantCursos.Show()

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton carreras, muestra 
    ''' al usuario el menu de carreras</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnCarreras_Click(sender As Object, e As EventArgs) Handles btnCarreras.Click

        Me.Hide()
        uCtrlMantCarreras = New uCtrlMantenimientoCarreras()
        FrmIniciarSesion.principal.Controls.Add(uCtrlMantCarreras)
        uCtrlMantCarreras.Show()

    End Sub

    Private Sub btnRoles_Click(sender As Object, e As EventArgs) Handles btnRoles.Click
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(uCntrlMantRol)
        uCntrlMantRol.Show()
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click

        'Dim ucntrlUsuario As UctrlListarYBuscarUsuario = New UctrlListarYBuscarUsuario()
        Me.SendToBack()
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(ucntrlUsuario)
        ucntrlUsuario.Show()

    End Sub

    Private Sub btnBeneficios_Click(sender As Object, e As EventArgs) Handles btnBeneficios.Click
        Me.Hide()
        FrmIniciarSesion.principal.Controls.Add(uCntrlBuscarBeneficio)
        uCntrlBuscarBeneficio.Show()
    End Sub

    Private Sub btnBecas_Click(sender As Object, e As EventArgs) Handles btnBecas.Click

        Me.Hide()
        uCtrlTipoBeca = New uCtrlBuscarTipoBeca()
        FrmIniciarSesion.principal.Controls.Add(uCtrlTipoBeca)
        uCtrlTipoBeca.Show()

    End Sub
End Class
