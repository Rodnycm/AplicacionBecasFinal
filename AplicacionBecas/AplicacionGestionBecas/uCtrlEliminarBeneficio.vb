Public Class uCtrlEliminarBeneficio

    Dim id As Integer
    Dim nombre As String
    Dim porcentaje As Double
    Dim aplicabilidad As String
    Dim uCtrl As uCntrlBuscarBeneficio


    ''' <summary>
    ''' Recibe una instancia del userControlBuscarBeneficio y la setea.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="puCtrl">Es una instancia del user control</param>
    ''' <remarks></remarks>
    Public Sub getUCtrlInstance(puCtrl As uCntrlBuscarBeneficio)

        uCtrl = puCtrl

    End Sub

    ''' <summary>
    ''' Recibe la informaciondel beneficio que sera eliminado.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="pid">Es el id del beneficio</param>
    ''' <param name="pnombre">El nombre del beneficio</param>
    ''' <param name="pporcentaje">El porcentaje del beneficio</param>
    ''' <param name="paplicabilidad">La aplicabilidad del beneficio</param>
    ''' <remarks></remarks>
    Public Sub recibirInfo(ByVal pid As Integer, ByVal pnombre As String, ByVal pporcentaje As Double, ByVal paplicabilidad As String)

        id = pid
        nombre = pnombre
        porcentaje = pporcentaje
        aplicabilidad = paplicabilidad

    End Sub

    ''' <summary>
    ''' Envia los parametros del beneficio al gestor.
    ''' Refresa la el dataGrid con la informacion nueva.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        objGestorBeneficio.eliminarBeneficio(id, nombre, porcentaje, aplicabilidad)
        MsgBox("beneficio eliminado")
        objGestorBeneficio.guardarCambios()

        uCtrl.dtaBuscarBeneficio.Rows.Clear()
        uCtrl.listarBeneficios()

        Me.Dispose()
        Me.Hide()


    End Sub

    ''' <summary>
    ''' Esconde y destruye el popup de eliminar beneficio.
    ''' </summary>
    ''' <author>Mathias Muller</author>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Dispose()
        Me.Hide()
    End Sub
End Class
