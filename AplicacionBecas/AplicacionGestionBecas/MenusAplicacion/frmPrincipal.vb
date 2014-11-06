Partial Public Class frmPrincipal

    Inherits Form

    Dim ucMenuMant As New uCtrlMenuMantenimiento()
    Dim ucMenuAcad As New uCtrlMenuAcademico()
    Dim ucMenuRep As New uCtrlMenuReportes()
    Dim ucMenuBecas As New uCtrlMenuBecas()

    Public Sub New()

        InitializeComponent()
        MenuLateral.Renderer = New MyRenderer()
        MenuHorizontal.Renderer = New MyRenderer2()

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click

        ocultarComponentes()

    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click

        ocultarComponentes()

    End Sub


    Private Sub AcadémicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcadémicoToolStripMenuItem.Click

        ocultarComponentes()

    End Sub


    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click

        ocultarComponentes()

    End Sub

    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click

        btnsMenus.Hide()
        Me.Controls.Add(ucMenuMant)
        ucMenuMant.Show()

    End Sub

    Private Sub btnAcademico_Click(sender As Object, e As EventArgs) Handles btnAcademico.Click

        ocultarComponentes()

    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click

        ocultarComponentes()

    End Sub

    Public Sub ocultarComponentes()

        ucMenuMant.uCtrlMantCarreras.Hide()
        ucMenuMant.uCtrlMantCursos.Hide()
        ucMenuMant.uCtrlMantRequisitos.Hide()
        ucMenuMant.uCntrlMantRol.Hide()
        ucMenuMant.ucntrlUsuario.Hide()
        ucMenuMant.uCntrlBuscarBeneficio.Hide()
        btnsMenus.Show()

    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        Dim UcntrlIniciar As UcntrlIniciar = New UcntrlIniciar()
        objGestorUsuario.cerrarSesion()
        Me.Hide()
        FrmIniciarSesion.Show()
        FrmIniciarSesion.Controls.Add(UcntrlIniciar)
        UcntrlIniciar.Location = New Point(135, 125)
    End Sub
End Class

Public Class MyRenderer

    Inherits ToolStripProfessionalRenderer

    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)

        Dim rc As New Rectangle(Point.Empty, e.Item.Size)
        Dim c As Color = IIf(e.Item.Selected, Color.FromArgb(96, 96, 96), Color.FromArgb(0, 48, 44, 43))

        Using brush As New SolidBrush(c)
            e.Graphics.FillRectangle(brush, rc)
        End Using

    End Sub

End Class

Public Class MyRenderer2

    Inherits ToolStripProfessionalRenderer

    Protected Overloads Overrides Sub OnRenderMenuItemBackground(ByVal e As ToolStripItemRenderEventArgs)

        Dim rc As New Rectangle(Point.Empty, e.Item.Size)
        Dim c As Color = IIf(e.Item.Selected, Color.FromArgb(50, 133, 43, 153), Color.FromArgb(0, 48, 44, 43))

        Using brush As New SolidBrush(c)
            e.Graphics.FillRectangle(brush, rc)
        End Using

    End Sub

End Class