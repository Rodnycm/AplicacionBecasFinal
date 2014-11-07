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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlBuscarTipoBeca))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtBarraBusqueda = New System.Windows.Forms.TextBox()
        Me.dtaTipoBeca = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCrearTipoBeca = New System.Windows.Forms.Button()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opciones = New System.Windows.Forms.DataGridViewComboBoxColumn()
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
        Me.dtaTipoBeca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtaTipoBeca.BackgroundColor = System.Drawing.Color.White
        Me.dtaTipoBeca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtaTipoBeca.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaTipoBeca.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dtaTipoBeca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaTipoBeca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.Estado, Me.opciones})
        Me.dtaTipoBeca.GridColor = System.Drawing.Color.White
<<<<<<< HEAD
        Me.dtaTipoBeca.Location = New System.Drawing.Point(42, 233)
        Me.dtaTipoBeca.Name = "dtaTipoBeca"
        Me.dtaTipoBeca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtaTipoBeca.RowHeadersVisible = False
        Me.dtaTipoBeca.Size = New System.Drawing.Size(803, 222)
        Me.dtaTipoBeca.TabIndex = 17
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'mantenimiento
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.mantenimiento.DefaultCellStyle = DataGridViewCellStyle2
        Me.mantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.mantenimiento.HeaderText = "Opciones"
        Me.mantenimiento.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.mantenimiento.Name = "mantenimiento"
        '
        'txtBarraBusqueda
        '
        Me.txtBarraBusqueda.Location = New System.Drawing.Point(30, 158)
        Me.txtBarraBusqueda.Name = "txtBarraBusqueda"
        Me.txtBarraBusqueda.Size = New System.Drawing.Size(746, 20)
        Me.txtBarraBusqueda.TabIndex = 18
        Me.txtBarraBusqueda.Text = "Buscar:"
=======
        Me.dtaTipoBeca.Location = New System.Drawing.Point(41, 209)
        Me.dtaTipoBeca.Name = "dtaTipoBeca"
        Me.dtaTipoBeca.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtaTipoBeca.RowHeadersVisible = False
        Me.dtaTipoBeca.Size = New System.Drawing.Size(947, 271)
        Me.dtaTipoBeca.TabIndex = 21
>>>>>>> origin/BackiGC
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
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'opciones
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.opciones.DefaultCellStyle = DataGridViewCellStyle2
        Me.opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opciones.HeaderText = "Opciones"
        Me.opciones.Items.AddRange(New Object() {"Ver", "Editar", "Eliminar"})
        Me.opciones.Name = "opciones"
        '
        'uCtrlBuscarTipoBeca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtBarraBusqueda)
        Me.Controls.Add(Me.dtaTipoBeca)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCrearTipoBeca)
        Me.Location = New System.Drawing.Point(783, 108)
        Me.Name = "uCtrlBuscarTipoBeca"
        Me.Size = New System.Drawing.Size(1037, 578)
        CType(Me.dtaTipoBeca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBarraBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents dtaTipoBeca As System.Windows.Forms.DataGridView
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents opciones As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCrearTipoBeca As System.Windows.Forms.Button

End Class
