<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlMantenimientoCarreras
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlMantenimientoCarreras))
        Me.dgvCarreras = New System.Windows.Forms.DataGridView()
        Me.dtaCodigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dtaDirector = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificarcmb = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.UCtrlCarrera1 = New UI.uCtrlCrearCarrera()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCarreras, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCarreras
        '
        Me.dgvCarreras.BackgroundColor = System.Drawing.Color.White
        Me.dgvCarreras.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvCarreras.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCarreras.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCarreras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCarreras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaCodigo, Me.dtaNombre, Me.dtaDirector, Me.Modificarcmb, Me.id})
        Me.dgvCarreras.GridColor = System.Drawing.Color.White
        Me.dgvCarreras.Location = New System.Drawing.Point(40, 168)
        Me.dgvCarreras.Name = "dgvCarreras"
        Me.dgvCarreras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCarreras.RowHeadersVisible = False
        Me.dgvCarreras.ShowEditingIcon = False
        Me.dgvCarreras.Size = New System.Drawing.Size(947, 271)
        Me.dgvCarreras.TabIndex = 12
        '
        'dtaCodigo
        '
        Me.dtaCodigo.HeaderText = "Codigo"
        Me.dtaCodigo.Name = "dtaCodigo"
        Me.dtaCodigo.ReadOnly = True
        Me.dtaCodigo.Width = 150
        '
        'dtaNombre
        '
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        Me.dtaNombre.ReadOnly = True
        Me.dtaNombre.Width = 300
        '
        'dtaDirector
        '
        Me.dtaDirector.HeaderText = "Director Academico"
        Me.dtaDirector.Name = "dtaDirector"
        Me.dtaDirector.ReadOnly = True
        Me.dtaDirector.Width = 300
        '
        'Modificarcmb
        '
        Me.Modificarcmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificarcmb.HeaderText = "Modificar"
        Me.Modificarcmb.Items.AddRange(New Object() {"Editar", "Eliminar"})
        Me.Modificarcmb.Name = "Modificarcmb"
        Me.Modificarcmb.Width = 190
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(975, 321)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.BackgroundImage = CType(resources.GetObject("btnMantenimiento.BackgroundImage"), System.Drawing.Image)
        Me.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMantenimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimiento.ForeColor = System.Drawing.Color.White
        Me.btnMantenimiento.Location = New System.Drawing.Point(783, 41)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Size = New System.Drawing.Size(222, 79)
        Me.btnMantenimiento.TabIndex = 5
        Me.btnMantenimiento.Text = "Crear Carrera"
        Me.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMantenimiento.UseVisualStyleBackColor = True
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.HeaderText = "Editar"
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        '
        'UCtrlCarrera1
        '
        Me.UCtrlCarrera1.BackColor = System.Drawing.Color.White
        Me.UCtrlCarrera1.BackgroundImage = CType(resources.GetObject("UCtrlCarrera1.BackgroundImage"), System.Drawing.Image)
        Me.UCtrlCarrera1.Location = New System.Drawing.Point(119, 75)
        Me.UCtrlCarrera1.Name = "UCtrlCarrera1"
        Me.UCtrlCarrera1.Size = New System.Drawing.Size(461, 321)
        Me.UCtrlCarrera1.TabIndex = 7
        '
        'id
        '
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'uCtrlMantenimientoCarreras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dgvCarreras)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMantenimiento)
        Me.Location = New System.Drawing.Point(145, 124)
        Me.Name = "uCtrlMantenimientoCarreras"
        Me.Size = New System.Drawing.Size(1037, 478)
        CType(Me.dgvCarreras, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMantenimiento As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UCtrlCarrera1 As UI.uCtrlCrearCarrera
    Friend WithEvents dgvCarreras As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewImageColumn1 As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents dtaCodigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtaDirector As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificarcmb As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
