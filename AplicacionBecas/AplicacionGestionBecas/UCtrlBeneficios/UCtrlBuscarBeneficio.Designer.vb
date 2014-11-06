<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCtrlBuscarBeneficio
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
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCtrlBuscarBeneficio))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dtaBuscarBeneficio = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.pctbxBeneficios = New System.Windows.Forms.PictureBox()
        Me.dtaId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaPorcentaje = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaAplicabilidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaOpciones = New System.Windows.Forms.DataGridViewComboBoxColumn()
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaBuscarBeneficio.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtaBuscarBeneficio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaBuscarBeneficio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaId, Me.dtaNombre, Me.dtaPorcentaje, Me.dtaAplicabilidad, Me.dtaOpciones})
        Me.dtaBuscarBeneficio.GridColor = System.Drawing.Color.White
        Me.dtaBuscarBeneficio.Location = New System.Drawing.Point(40, 235)
        Me.dtaBuscarBeneficio.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.dtaBuscarBeneficio.Name = "dtaBuscarBeneficio"
        Me.dtaBuscarBeneficio.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaBuscarBeneficio.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dtaBuscarBeneficio.RowHeadersVisible = False
        Me.dtaBuscarBeneficio.Size = New System.Drawing.Size(947, 271)
        Me.dtaBuscarBeneficio.TabIndex = 28
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(31, 160)
        Me.txtBuscar.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(732, 27)
        Me.txtBuscar.TabIndex = 29
        Me.txtBuscar.Text = "Buscar:"
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.BackgroundImage = CType(resources.GetObject("btnMantenimiento.BackgroundImage"), System.Drawing.Image)
        Me.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMantenimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimiento.ForeColor = System.Drawing.Color.White
        Me.btnMantenimiento.Location = New System.Drawing.Point(783, 108)
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
        Me.pctbxBeneficios.Location = New System.Drawing.Point(30, 202)
        Me.pctbxBeneficios.Margin = New System.Windows.Forms.Padding(2, 1, 2, 1)
        Me.pctbxBeneficios.Name = "pctbxBeneficios"
        Me.pctbxBeneficios.Size = New System.Drawing.Size(975, 321)
        Me.pctbxBeneficios.TabIndex = 26
        Me.pctbxBeneficios.TabStop = False
        '
        'dtaId
        '
        Me.dtaId.HeaderText = "Id"
        Me.dtaId.Name = "dtaId"
        '
        'dtaNombre
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dtaNombre.DefaultCellStyle = DataGridViewCellStyle2
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        '
        'dtaPorcentaje
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dtaPorcentaje.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtaPorcentaje.HeaderText = "Porcentaje"
        Me.dtaPorcentaje.Name = "dtaPorcentaje"
        '
        'dtaAplicabilidad
        '
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dtaAplicabilidad.DefaultCellStyle = DataGridViewCellStyle4
        Me.dtaAplicabilidad.HeaderText = "Aplicabilidad"
        Me.dtaAplicabilidad.Name = "dtaAplicabilidad"
        '
        'dtaOpciones
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.dtaOpciones.DefaultCellStyle = DataGridViewCellStyle5
        Me.dtaOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.dtaOpciones.HeaderText = "Opciones"
        Me.dtaOpciones.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.dtaOpciones.Name = "dtaOpciones"
        '
        'UCtrlBuscarBeneficio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dtaBuscarBeneficio)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.btnMantenimiento)
        Me.Controls.Add(Me.pctbxBeneficios)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.Location = New System.Drawing.Point(145, 50)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "UCtrlBuscarBeneficio"
        Me.Size = New System.Drawing.Size(1037, 578)
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


    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents btnMantenimiento As System.Windows.Forms.Button
    Friend WithEvents pctbxBeneficios As System.Windows.Forms.PictureBox
    Friend WithEvents ErrorProvider3 As System.Windows.Forms.ErrorProvider
    Friend WithEvents dtaId As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaPorcentaje As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaAplicabilidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaOpciones As System.Windows.Forms.DataGridViewComboBoxColumn


End Class
