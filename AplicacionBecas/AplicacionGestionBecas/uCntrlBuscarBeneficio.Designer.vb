<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCntrlBuscarBeneficio
    Inherits System.Windows.Forms.UserControl

    'UserControl reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCntrlBuscarBeneficio))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dtaBuscarBeneficio = New System.Windows.Forms.DataGridView()
        Me.dtaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaAplicabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaOpciones = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.pctbxBeneficios = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtaBuscarBeneficio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctbxBeneficios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'dtaBuscarBeneficio
        '
        Me.dtaBuscarBeneficio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtaBuscarBeneficio.BackgroundColor = System.Drawing.Color.White
        Me.dtaBuscarBeneficio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtaBuscarBeneficio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaBuscarBeneficio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtaBuscarBeneficio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaBuscarBeneficio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaId, Me.dtaNombre, Me.dtaPorcentaje, Me.dtaAplicabilidad, Me.dtaOpciones})
        Me.dtaBuscarBeneficio.GridColor = System.Drawing.Color.White
        Me.dtaBuscarBeneficio.Location = New System.Drawing.Point(50, 176)
        Me.dtaBuscarBeneficio.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dtaBuscarBeneficio.Name = "dtaBuscarBeneficio"
        Me.dtaBuscarBeneficio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaBuscarBeneficio.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtaBuscarBeneficio.RowHeadersVisible = False
        Me.dtaBuscarBeneficio.Size = New System.Drawing.Size(947, 271)
        Me.dtaBuscarBeneficio.TabIndex = 28
        '
        'dtaId
        '
        Me.dtaId.HeaderText = "Id"
        Me.dtaId.Name = "dtaId"
        '
        'dtaNombre
        '
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        '
        'dtaPorcentaje
        '
        Me.dtaPorcentaje.HeaderText = "Porcentaje"
        Me.dtaPorcentaje.Name = "dtaPorcentaje"
        '
        'dtaAplicabilidad
        '
        Me.dtaAplicabilidad.HeaderText = "Aplicabilidad"
        Me.dtaAplicabilidad.Name = "dtaAplicabilidad"
        '
        'dtaOpciones
        '
        Me.dtaOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dtaOpciones.HeaderText = "Opciones"
        Me.dtaOpciones.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.dtaOpciones.Name = "dtaOpciones"
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(36, 74)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(732, 25)
        Me.txtBuscar.TabIndex = 29
        Me.txtBuscar.Text = "Buscar:"
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.BackgroundImage = CType(resources.GetObject("btnMantenimiento.BackgroundImage"), System.Drawing.Image)
        Me.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMantenimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimiento.ForeColor = System.Drawing.Color.White
        Me.btnMantenimiento.Location = New System.Drawing.Point(789, 20)
        Me.btnMantenimiento.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Size = New System.Drawing.Size(222, 79)
        Me.btnMantenimiento.TabIndex = 27
        Me.btnMantenimiento.Text = "Crear Beneficio"
        Me.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMantenimiento.UseVisualStyleBackColor = True
        '
        'pctbxBeneficios
        '
        Me.pctbxBeneficios.BackColor = System.Drawing.Color.White
        Me.pctbxBeneficios.BackgroundImage = Global.UI.My.Resources.Resources.tablaFinalGrandeAzul
        Me.pctbxBeneficios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pctbxBeneficios.Location = New System.Drawing.Point(36, 136)
        Me.pctbxBeneficios.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pctbxBeneficios.Name = "pctbxBeneficios"
        Me.pctbxBeneficios.Size = New System.Drawing.Size(975, 321)
        Me.pctbxBeneficios.TabIndex = 26
        Me.pctbxBeneficios.TabStop = False
        '
        'uCntrlBuscarBeneficio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dtaBuscarBeneficio)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnMantenimiento)
        Me.Controls.Add(Me.pctbxBeneficios)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "uCntrlBuscarBeneficio"
        Me.Size = New System.Drawing.Size(1042, 497)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtaBuscarBeneficio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctbxBeneficios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents ErrorProvider2 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dtaBuscarBeneficio As System.Windows.Forms.DataGridView
    Friend WithEvents dtaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaPorcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaAplicabilidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaOpciones As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnMantenimiento As System.Windows.Forms.Button
    Friend WithEvents pctbxBeneficios As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider

End Class
