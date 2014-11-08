<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlBuscarTipoBeca
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlBuscarTipoBeca))
        Me.txtBarraBusqueda = New System.Windows.Forms.TextBox()
        Me.dtaTipoBeca = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Requisitos = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Beneficios = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.opciones = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCrearTipoBeca = New System.Windows.Forms.Button()
        CType(Me.dtaTipoBeca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBarraBusqueda
        '
        Me.txtBarraBusqueda.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.txtBarraBusqueda.Location = New System.Drawing.Point(32, 134)
        Me.txtBarraBusqueda.Name = "txtBarraBusqueda"
        Me.txtBarraBusqueda.Size = New System.Drawing.Size(746, 27)
        Me.txtBarraBusqueda.TabIndex = 22
        Me.txtBarraBusqueda.Text = "Buscar:"
        '
        'dtaTipoBeca
        '
        Me.dtaTipoBeca.AllowUserToAddRows = False
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtaTipoBeca.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle15
        Me.dtaTipoBeca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtaTipoBeca.BackgroundColor = System.Drawing.Color.White
        Me.dtaTipoBeca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtaTipoBeca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaTipoBeca.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.dtaTipoBeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaTipoBeca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Fecha, Me.Estado, Me.Descripcion, Me.Requisitos, Me.Beneficios, Me.opciones})
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtaTipoBeca.DefaultCellStyle = DataGridViewCellStyle20
        Me.dtaTipoBeca.GridColor = System.Drawing.Color.White
        Me.dtaTipoBeca.Location = New System.Drawing.Point(42, 211)
        Me.dtaTipoBeca.Name = "dtaTipoBeca"
        Me.dtaTipoBeca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaTipoBeca.RowHeadersDefaultCellStyle = DataGridViewCellStyle21
        Me.dtaTipoBeca.RowHeadersVisible = False
        Me.dtaTipoBeca.Size = New System.Drawing.Size(947, 271)
        Me.dtaTipoBeca.TabIndex = 21
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha Creación"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.Visible = False
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripción"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Visible = False
        '
        'Requisitos
        '
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Transparent
        Me.Requisitos.DefaultCellStyle = DataGridViewCellStyle17
        Me.Requisitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Requisitos.HeaderText = "Requisitos"
        Me.Requisitos.Name = "Requisitos"
        Me.Requisitos.Text = "Ver"
        Me.Requisitos.UseColumnTextForButtonValue = True
        Me.Requisitos.Visible = False
        '
        'Beneficios
        '
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.Transparent
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.Transparent
        Me.Beneficios.DefaultCellStyle = DataGridViewCellStyle18
        Me.Beneficios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Beneficios.HeaderText = "Beneficios"
        Me.Beneficios.Name = "Beneficios"
        Me.Beneficios.Text = "Ver"
        Me.Beneficios.UseColumnTextForButtonValue = True
        Me.Beneficios.Visible = False
        '
        'opciones
        '
        DataGridViewCellStyle19.BackColor = System.Drawing.Color.White
        Me.opciones.DefaultCellStyle = DataGridViewCellStyle19
        Me.opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opciones.HeaderText = "Opciones"
        Me.opciones.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.opciones.Name = "opciones"
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.White
        Me.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVolver.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnVolver.Location = New System.Drawing.Point(917, 521)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 29)
        Me.btnVolver.TabIndex = 66
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        Me.btnVolver.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 176)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(975, 321)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'btnCrearTipoBeca
        '
        Me.btnCrearTipoBeca.BackgroundImage = CType(resources.GetObject("btnCrearTipoBeca.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearTipoBeca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearTipoBeca.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearTipoBeca.ForeColor = System.Drawing.Color.White
        Me.btnCrearTipoBeca.Location = New System.Drawing.Point(784, 82)
        Me.btnCrearTipoBeca.Name = "btnCrearTipoBeca"
        Me.btnCrearTipoBeca.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearTipoBeca.TabIndex = 19
        Me.btnCrearTipoBeca.Text = "Crear Tipo de Beca"
        Me.btnCrearTipoBeca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearTipoBeca.UseVisualStyleBackColor = True
        '
        'uCtrlBuscarTipoBeca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.txtBarraBusqueda)
        Me.Controls.Add(Me.btnCrearTipoBeca)
        Me.Controls.Add(Me.dtaTipoBeca)
        Me.Controls.Add(Me.PictureBox1)
        Me.Location = New System.Drawing.Point(145, 50)
        Me.Name = "uCtrlBuscarTipoBeca"
        Me.Size = New System.Drawing.Size(1037, 578)
        CType(Me.dtaTipoBeca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBarraBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dtaTipoBeca As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCrearTipoBeca As System.Windows.Forms.Button
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Requisitos As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Beneficios As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents opciones As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
