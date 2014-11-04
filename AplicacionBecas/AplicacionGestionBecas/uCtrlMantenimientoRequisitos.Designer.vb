<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlMantenimientoRequisitos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlMantenimientoRequisitos))
        Me.dgvRequisitos = New System.Windows.Forms.DataGridView()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificarcmb = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCrearRequisito = New System.Windows.Forms.Button()
        CType(Me.dgvRequisitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRequisitos
        '
        Me.dgvRequisitos.BackgroundColor = System.Drawing.Color.White
        Me.dgvRequisitos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRequisitos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequisitos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequisitos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaNombre, Me.descripcion, Me.Modificarcmb})
        Me.dgvRequisitos.GridColor = System.Drawing.Color.White
        Me.dgvRequisitos.Location = New System.Drawing.Point(41, 159)
        Me.dgvRequisitos.Name = "dgvRequisitos"
        Me.dgvRequisitos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRequisitos.RowHeadersVisible = False
        Me.dgvRequisitos.ShowEditingIcon = False
        Me.dgvRequisitos.Size = New System.Drawing.Size(947, 271)
        Me.dgvRequisitos.TabIndex = 15
        '
        'dtaNombre
        '
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        Me.dtaNombre.ReadOnly = True
        Me.dtaNombre.Width = 300
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
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
        Me.PictureBox1.Location = New System.Drawing.Point(31, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(975, 321)
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'btnCrearRequisito
        '
        Me.btnCrearRequisito.BackgroundImage = CType(resources.GetObject("btnCrearRequisito.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearRequisito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearRequisito.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearRequisito.ForeColor = System.Drawing.Color.White
        Me.btnCrearRequisito.Location = New System.Drawing.Point(784, 32)
        Me.btnCrearRequisito.Name = "btnCrearRequisito"
        Me.btnCrearRequisito.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearRequisito.TabIndex = 13
        Me.btnCrearRequisito.Text = "Crear Requisito"
        Me.btnCrearRequisito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearRequisito.UseVisualStyleBackColor = True
        '
        'uCtrlMantenimientoRequisitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.dgvRequisitos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCrearRequisito)
        Me.Location = New System.Drawing.Point(145, 124)
        Me.Name = "uCtrlMantenimientoRequisitos"
        Me.Size = New System.Drawing.Size(1037, 478)
        CType(Me.dgvRequisitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvRequisitos As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCrearRequisito As System.Windows.Forms.Button
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificarcmb As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
