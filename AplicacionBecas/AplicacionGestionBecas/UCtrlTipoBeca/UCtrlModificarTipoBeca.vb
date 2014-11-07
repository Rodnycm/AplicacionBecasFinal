Imports EntitiesLayer
Public Class uCtrlModificarTipoBeca
    Dim buscar As uCtrlBuscarTipoBeca
    Dim listas As List(Of Beneficio)
    Dim listasR As List(Of Requisito)
    Dim listaRequisito As List(Of Requisito)
    Dim listaBeneficio As List(Of Beneficio)

    Dim listaIdBeneficios As List(Of Integer) = New List(Of Integer)
    Dim listaIdRequisitos As List(Of Integer) = New List(Of Integer)
    Dim listaIdBeneficiosRol As List(Of Integer) = New List(Of Integer)
    Dim listaIdRequisitosRol As List(Of Integer) = New List(Of Integer)

    Public objTipo As TipoBeca
   
    Public Sub getFrmBuscar(pbuscar As uCtrlBuscarTipoBeca)
        buscar = pbuscar
    End Sub
    Public Sub setListas(ByVal plista As List(Of Beneficio))
        listas = plista
    End Sub

    Public Sub setListasR(ByVal plistaR As List(Of Requisito))
        listasR = plistaR
    End Sub
    Public Sub recibirDatos(pnombre As String, pestado As String, pdescripcion As String)

        'txtNombre.Text = pnombre
        txtEstado.Text = pestado
        txtDescripcion.Text = pdescripcion

    End Sub
    Private Sub RequisitosRelacionados()
        For Each requisito As Requisito In gestorTipoBeca.buscarRequisitosRelacionadosTipoBeca(objTipo.id)
            listaIdRequisitosRol.Add(requisito.id)
        Next
    End Sub
    Private Sub BeneficiosRelacionados()
        For Each beneficio As Beneficio In gestorTipoBeca.buscarBeneficiosRelacionadosTipoBeca(objTipo.id)
            listaIdBeneficiosRol.Add(beneficio.id)
        Next
    End Sub
    Private Sub btnModificar_Click(sender As Object, e As EventArgs)
        Try
            Dim nombre As String = txtNombre.Text
            Dim estado As String = txtEstado.Text
            Dim descripcion As String = txtDescripcion.Text

            Dim listaIdBeneficiosSeleccionados As List(Of Integer) = obtenerBeneficiosSeleccionados()
            Dim listaIdRequisitosSeleccionados As List(Of Integer) = obtenerRequisitosSeleccionados()

            gestorTipoBeca.modificarTipoBeca(objTipo.Id, nombre, estado, descripcion, listaIdBeneficiosSeleccionados, listaIdRequisitosSeleccionados)
            gestorTipoBeca.guardarCambios()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Me.Hide()
        Me.Dispose()
    End Sub
    Private Function obtenerBeneficiosSeleccionados() As List(Of Integer)
        Dim listaBeneficiosSeleccionados As New List(Of Integer)
        For Each beneficioSeleccionado As Integer In ChkListaBeneficios.CheckedIndices
            listaBeneficiosSeleccionados.Add(listaIdBeneficios.Item(beneficioSeleccionado))
        Next
        Return listaBeneficiosSeleccionados
    End Function
    Private Function obtenerRequisitosSeleccionados() As List(Of Integer)
        Dim listaRequisitosSeleccionados As New List(Of Integer)
        For Each requisitoSeleccionado As Integer In chkListaRequisitos.CheckedIndices
            listaRequisitosSeleccionados.Add(listaIdRequisitos.Item(requisitoSeleccionado))
        Next
        Return listaRequisitosSeleccionados
    End Function
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Me.Dispose()
    End Sub
   

    Private Sub editar_load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerBeneficios()
        obtenerRequisitos()

        RequisitosRelacionados()
        BeneficiosRelacionados()

        txtNombre.Text = objTipo.nombre
        txtEstado.Text = objTipo.estado
        txtDescripcion.Text = objTipo.descripcion

        asociarBeneficios()
        asociarRequisitos()


    End Sub
    Private Sub asociarBeneficios()
        For Each beneficioDeBeca As Integer In listaIdBeneficiosRol
            For i As Integer = 0 To listaIdBeneficios.Count - 1
                If listaIdBeneficios.Item(i) = beneficioDeBeca Then
                    ChkListaBeneficios.SetItemChecked(i, True)
                End If
            Next
        Next
    End Sub
    Private Sub asociarRequisitos()
        For Each requisitosDeBeca As Integer In listaIdRequisitosRol
            For i As Integer = 0 To listaIdRequisitos.Count - 1
                If listaIdRequisitos.Item(i) = requisitosDeBeca Then
                    chkListaRequisitos.SetItemChecked(i, True)
                End If
            Next
        Next
    End Sub
    Private Sub obtenerRequisitos()
        For Each requisito As Requisito In objGestorRequisito.buscarRequisito()
            chkListaRequisitos.Items.Add(requisito.nombre)
            listaIdRequisitos.Add(requisito.Id)
        Next
    End Sub
    Private Sub obtenerBeneficios()
        For Each beneficio As Beneficio In objGestorBeneficio.buscarBeneficios()
            ChkListaBeneficios.Items.Add(beneficio.Nombre)
            listaIdBeneficios.Add(beneficio.Id)
        Next
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Dispose()
    End Sub
End Class
