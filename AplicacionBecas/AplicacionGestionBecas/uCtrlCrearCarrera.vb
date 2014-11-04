Public Class uCtrlCrearCarrera

    Dim ColorDialog1 As ColorDialog = New ColorDialog()

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton seleccionar color, este metodo 
    ''' muestra al usuario una paleta de colores</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click

        If ColorDialog1.ShowDialog() = DialogResult.OK Then
            btnColor.BackColor = ColorDialog1.Color
        End If
        btnColor.ForeColor = Color.White

    End Sub

    ''' <summary>Metodo que se ejecuta cuando el usuario da click al boton añadir y llama a la clase
    ''' gestor para enviar la informaciòn</summary>
    ''' <autor>Alvaro Artavia</autor>

    Private Sub btnAñadir_Click(sender As Object, e As EventArgs) Handles btnAñadir.Click

        Dim nombre As String = txtNombre.Text
        Dim codigo As String = txtCodigo.Text
        Dim color As String = "9922"
        Dim directorAcademico As String = ""

        objGestorCarrera.agregarCarrera(nombre, codigo, color)
        objGestorCarrera.guardarCambios()

    End Sub

End Class
