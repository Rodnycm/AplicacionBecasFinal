Partial Public Class frmPrincipal

    Inherits Form

    Dim ucMenuMant As New uCtrlMenuMantenimiento()
    Dim ucMenuAcad As New uCtrlMenuAcademico()
    Dim ucMenuRep As New uCtrlMenuReportes()
    Dim ucMenuBecas As New uCtrlMenuBecas()
    'Public Property uCtrlMantCarreras As uCtrlMantenimientoCarreras = New uCtrlMantenimientoCarreras()

    Public Sub New()

        InitializeComponent()
        MenuLateral.Renderer = New MyRenderer()

    End Sub

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click

        ucMenuRep.Hide()
        ucMenuMant.Hide()
        ucMenuAcad.Hide()
        ucMenuMant.uCtrlMantCarreras.Dispose()
        btnsMenus.Show()

    End Sub

    Private Sub MantenimientoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoToolStripMenuItem.Click

        ucMenuRep.Hide()
        ucMenuAcad.Hide()
        btnsMenus.Hide()
        ucMenuMant.uCtrlMantCarreras.Dispose()
        Me.Controls.Add(ucMenuMant)
        ucMenuMant.Show()

    End Sub


    Private Sub AcadémicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AcadémicoToolStripMenuItem.Click

        ucMenuRep.Hide()
        btnsMenus.Hide()
        ucMenuMant.Hide()
        ucMenuMant.uCtrlMantCarreras.Dispose()
        Me.Controls.Add(ucMenuAcad)
        ucMenuAcad.Show()

    End Sub


    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click

        btnsMenus.Hide()
        ucMenuMant.Hide()
        ucMenuAcad.Hide()
        ucMenuMant.uCtrlMantCarreras.Dispose()
        Me.Controls.Add(ucMenuRep)
        ucMenuRep.Show()

    End Sub

    Private Sub btnMantenimiento_Click(sender As Object, e As EventArgs) Handles btnMantenimiento.Click

        btnsMenus.Hide()
        Me.Controls.Add(ucMenuMant)
        ucMenuMant.Show()

    End Sub

    Private Sub btnAcademico_Click(sender As Object, e As EventArgs) Handles btnAcademico.Click

        btnsMenus.Hide()
        Me.Controls.Add(ucMenuAcad)
        ucMenuAcad.Show()

    End Sub

    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click

        btnsMenus.Hide()
        ucMenuMant.Hide()
        ucMenuAcad.Hide()
        Me.Controls.Add(ucMenuRep)
        ucMenuRep.Show()

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