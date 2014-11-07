<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UCtrlAsignarNotasCurso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UCtrlAsignarNotasCurso))
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.imgBuscarCursos = New System.Windows.Forms.PictureBox()
        Me.dgUsuarios = New System.Windows.Forms.DataGridView()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Identificación = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.opciones = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.imgBuscarCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'imgBuscarCursos
        '
        Me.imgBuscarCursos.Image = CType(resources.GetObject("imgBuscarCursos.Image"), System.Drawing.Image)
        Me.imgBuscarCursos.Location = New System.Drawing.Point(30, 202)
        Me.imgBuscarCursos.Name = "imgBuscarCursos"
        Me.imgBuscarCursos.Size = New System.Drawing.Size(975, 321)
        Me.imgBuscarCursos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBuscarCursos.TabIndex = 27
        Me.imgBuscarCursos.TabStop = False
        '
        'dgUsuarios
        '
        Me.dgUsuarios.AllowUserToAddRows = False
        Me.dgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgUsuarios.BackgroundColor = System.Drawing.Color.White
        Me.dgUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Identificación, Me.Nombre, Me.opciones})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgUsuarios.DefaultCellStyle = DataGridViewCellStyle17
        Me.dgUsuarios.GridColor = System.Drawing.Color.White
        Me.dgUsuarios.Location = New System.Drawing.Point(40, 235)
        Me.dgUsuarios.Name = "dgUsuarios"
        Me.dgUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgUsuarios.RowHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.dgUsuarios.RowHeadersVisible = False
        Me.dgUsuarios.Size = New System.Drawing.Size(947, 271)
        Me.dgUsuarios.TabIndex = 30
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI Light", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.Location = New System.Drawing.Point(31, 158)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(746, 29)
        Me.txtBuscar.TabIndex = 31
        Me.txtBuscar.Text = "Buscar:"
        '
        'Identificación
        '
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Identificación.DefaultCellStyle = DataGridViewCellStyle14
        Me.Identificación.FillWeight = 101.7639!
        Me.Identificación.HeaderText = "Identificación"
        Me.Identificación.Name = "Identificación"
        '
        'Nombre
        '
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.DefaultCellStyle = DataGridViewCellStyle15
        Me.Nombre.FillWeight = 271.8829!
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        '
        'opciones
        '
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Segoe UI Light", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.opciones.DefaultCellStyle = DataGridViewCellStyle16
        Me.opciones.FillWeight = 126.3532!
        Me.opciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.opciones.HeaderText = "Opciones"
        Me.opciones.Items.AddRange(New Object() {"Cursos"})
        Me.opciones.Name = "opciones"
        Me.opciones.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.opciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'UCtrlAsignarNotasCurso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgUsuarios)
        Me.Controls.Add(Me.imgBuscarCursos)
        Me.Name = "UCtrlAsignarNotasCurso"
        Me.Size = New System.Drawing.Size(1011, 528)
        CType(Me.imgBuscarCursos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents imgBuscarCursos As System.Windows.Forms.PictureBox
    Friend WithEvents dgUsuarios As System.Windows.Forms.DataGridView
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Identificación As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents opciones As System.Windows.Forms.DataGridViewComboBoxColumn

End Class
