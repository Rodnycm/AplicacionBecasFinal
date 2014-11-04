Imports EntitiesLayer

Public Class uCtrlModificarCarrera

    Public Property idCarrera As Integer
    Public Property mantenimientoCarreras As uCtrlMantenimientoCarreras
    Dim alerta As UctrlAlerta = New UctrlAlerta()
    Dim listaDirectores As List(Of Usuario)
    Dim mBlnFormDragging As Boolean
    Public Property directorAntiguo As String = ""

    Dim c As ColorDialog = New ColorDialog()

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton seleccionar color, este metodo 
    ''' muestra al usuario una paleta de colores</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click

        If c.ShowDialog() = DialogResult.OK Then
            btnColor.BackColor = c.Color
        End If

        btnColor.ForeColor = Color.White

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton modificar y llama a la clase
    ''' gestor para modificar la informaciòn</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub uCtrlModificarCarrera_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

        If mBlnFormDragging = True Then

            Dim position As Point = frmPrincipal.PointToClient(MousePosition)
            Me.Location = New Point(position)

        End If

    End Sub

    Private Sub uCtrlModificarCarrera_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

        mBlnFormDragging = False
        Dim position As Point = frmPrincipal.PointToClient(MousePosition)
        Location = New Point(position)

    End Sub

    Public Sub uCtrlModificarCarrera_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown

        mBlnFormDragging = True

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Dim nombre As String = txtNombre.Text
        Dim codigo As String = txtCodigo.Text
        Dim color As String = "#" + c.Color.R.ToString("X2") + c.Color.G.ToString("X2") + c.Color.B.ToString("X2")
        Dim directorAcademico As String = cmbAcademico.Text
        Dim idDirector As String = ""
        Dim idAntiguo As String = ""


        idDirector = buscarAntiguoDirector(directorAcademico)
        idAntiguo = buscarAntiguoDirector(Me.directorAntiguo)

        Try

            objGestorCarrera.modificarCarrera(nombre, codigo, color, idCarrera, idDirector, idAntiguo)

            mantenimientoCarreras.listarCarreras()

        Catch ex As Exception

            alerta.lblAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()

        End Try

        Me.Dispose()

    End Sub

    Public Sub llenarDirectoresCmb()

        Try

            listaDirectores = objGestorCarrera.consultarDirectoresAcademicos()

            For i As Integer = 0 To listaDirectores.Count - 1

                cmbAcademico.Items.Add(listaDirectores(i).primerNombre & " " & listaDirectores(i).primerApellido & " " & listaDirectores(i).segundoApellido)
            Next

        Catch ex As Exception

            alerta.lblAlerta.Text = ex.Message
            FrmIniciarSesion.principal.Controls.Add(alerta)
            alerta.BringToFront()
            alerta.Show()

        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Dispose()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Dispose()

    End Sub

    Private Sub uCtrlModificarCarrera_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        llenarDirectoresCmb()

    End Sub

    Public Function buscarAntiguoDirector(ByVal pdirector As String) As String
        Dim nombreCompleto As String
        Dim idDirector As String = ""
        For i As Integer = 0 To listaDirectores.Count - 1

            nombreCompleto = listaDirectores(i).primerNombre & " " & listaDirectores(i).primerApellido & " " &
            listaDirectores(i).segundoApellido

            If nombreCompleto.Equals(pdirector) Then

                idDirector = listaDirectores(i).identificacion

            End If
        Next
        Return idDirector
    End Function


End Class
