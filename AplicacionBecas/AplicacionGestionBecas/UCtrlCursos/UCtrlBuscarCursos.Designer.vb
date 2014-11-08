<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlBuscarCursos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlBuscarCursos))
        Me.txtBuscarCurso = New System.Windows.Forms.TextBox()
        Me.dtaListarCursos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columCuatrimestre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columCreditos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.columPrecio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBuscar = New System.Windows.Forms.Label()
        Me.btnCrearCurso = New System.Windows.Forms.Button()
        Me.imgBuscarCursos = New System.Windows.Forms.PictureBox()
        Me.lblTituloCursos = New System.Windows.Forms.Label()
        CType(Me.dtaListarCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBuscarCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscarCurso
        '
        Me.txtBuscarCurso.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCurso.ForeColor = System.Drawing.Color.Black
        Me.txtBuscarCurso.Location = New System.Drawing.Point(31, 158)
        Me.txtBuscarCurso.Name = "txtBuscarCurso"
        Me.txtBuscarCurso.Size = New System.Drawing.Size(746, 27)
        Me.txtBuscarCurso.TabIndex = 28
        Me.txtBuscarCurso.Text = "Buscar:"
        '
        'dtaListarCursos
        '
        Me.dtaListarCursos.AllowUserToAddRows = False
        Me.dtaListarCursos.BackgroundColor = System.Drawing.Color.White
        Me.dtaListarCursos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dtaListarCursos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtaListarCursos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dtaListarCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtaListarCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.columCuatrimestre, Me.columCreditos, Me.columPrecio, Me.ComboBox, Me.id})
        Me.dtaListarCursos.GridColor = System.Drawing.Color.White
        Me.dtaListarCursos.Location = New System.Drawing.Point(40, 235)
        Me.dtaListarCursos.Name = "dtaListarCursos"
        Me.dtaListarCursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtaListarCursos.RowHeadersVisible = False
        Me.dtaListarCursos.Size = New System.Drawing.Size(947, 271)
        Me.dtaListarCursos.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 145
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 200.0!
        Me.DataGridViewTextBoxColumn2.Frozen = True
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 145
        '
        'columCuatrimestre
        '
        Me.columCuatrimestre.HeaderText = "Cuatrimestre"
        Me.columCuatrimestre.Name = "columCuatrimestre"
        Me.columCuatrimestre.ReadOnly = True
        Me.columCuatrimestre.Width = 145
        '
        'columCreditos
        '
        Me.columCreditos.HeaderText = "Créditos"
        Me.columCreditos.Name = "columCreditos"
        Me.columCreditos.ReadOnly = True
        Me.columCreditos.Width = 145
        '
        'columPrecio
        '
        Me.columPrecio.HeaderText = "Precio"
        Me.columPrecio.Name = "columPrecio"
        Me.columPrecio.ReadOnly = True
        Me.columPrecio.Width = 145
        '
        'ComboBox
        '
        Me.ComboBox.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ComboBox.FillWeight = 200.0!
        Me.ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox.HeaderText = "Opciones"
        Me.ComboBox.Items.AddRange(New Object() {"Editar", "Eliminar"})
        Me.ComboBox.Name = "ComboBox"
        Me.ComboBox.Width = 145
        '
        'id
        '
        Me.id.HeaderText = ""
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.BackColor = System.Drawing.Color.White
        Me.lblBuscar.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscar.Location = New System.Drawing.Point(437, 150)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(0, 23)
        Me.lblBuscar.TabIndex = 30
        '
        'btnCrearCurso
        '
        Me.btnCrearCurso.BackgroundImage = CType(resources.GetObject("btnCrearCurso.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearCurso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearCurso.ForeColor = System.Drawing.Color.White
        Me.btnCrearCurso.Location = New System.Drawing.Point(783, 106)
        Me.btnCrearCurso.Name = "btnCrearCurso"
        Me.btnCrearCurso.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearCurso.TabIndex = 31
        Me.btnCrearCurso.Text = "Crear Curso"
        Me.btnCrearCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearCurso.UseVisualStyleBackColor = True
        '
        'imgBuscarCursos
        '
        Me.imgBuscarCursos.Image = CType(resources.GetObject("imgBuscarCursos.Image"), System.Drawing.Image)
        Me.imgBuscarCursos.Location = New System.Drawing.Point(30, 202)
        Me.imgBuscarCursos.Name = "imgBuscarCursos"
        Me.imgBuscarCursos.Size = New System.Drawing.Size(975, 321)
        Me.imgBuscarCursos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBuscarCursos.TabIndex = 26
        Me.imgBuscarCursos.TabStop = False
        '
        'lblTituloCursos
        '
        Me.lblTituloCursos.AutoSize = True
        Me.lblTituloCursos.Font = New System.Drawing.Font("Segoe UI Semilight", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloCursos.ForeColor = System.Drawing.Color.Black
        Me.lblTituloCursos.Location = New System.Drawing.Point(26, 17)
        Me.lblTituloCursos.Name = "lblTituloCursos"
        Me.lblTituloCursos.Size = New System.Drawing.Size(113, 45)
        Me.lblTituloCursos.TabIndex = 32
        Me.lblTituloCursos.Text = "Cursos"
        '
        'uCtrlBuscarCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.lblTituloCursos)
        Me.Controls.Add(Me.btnCrearCurso)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscarCurso)
        Me.Controls.Add(Me.dtaListarCursos)
        Me.Controls.Add(Me.imgBuscarCursos)
        Me.Location = New System.Drawing.Point(145, 50)
        Me.Name = "uCtrlBuscarCursos"
        Me.Size = New System.Drawing.Size(1037, 578)
        CType(Me.dtaListarCursos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBuscarCursos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscarCurso As System.Windows.Forms.TextBox
    Friend WithEvents dtaListarCursos As System.Windows.Forms.DataGridView
    Friend WithEvents imgBuscarCursos As System.Windows.Forms.PictureBox
    Friend WithEvents lblBuscar As System.Windows.Forms.Label
    Friend WithEvents btnCrearCurso As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columCuatrimestre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columCreditos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents columPrecio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ComboBox As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTituloCursos As System.Windows.Forms.Label

End Class
