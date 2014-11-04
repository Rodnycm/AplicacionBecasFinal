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
        Me.btnCrearCurso = New System.Windows.Forms.Button()
        Me.txtBuscarCurso = New System.Windows.Forms.TextBox()
        Me.btnBuscarCurso = New System.Windows.Forms.Button()
        Me.dtaListarCursos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.dtaListarCursos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCrearCurso
        '
        Me.btnCrearCurso.Location = New System.Drawing.Point(549, 107)
        Me.btnCrearCurso.Name = "btnCrearCurso"
        Me.btnCrearCurso.Size = New System.Drawing.Size(75, 23)
        Me.btnCrearCurso.TabIndex = 29
        Me.btnCrearCurso.Text = "Crear Curso "
        Me.btnCrearCurso.UseVisualStyleBackColor = True
        '
        'txtBuscarCurso
        '
        Me.txtBuscarCurso.Location = New System.Drawing.Point(100, 110)
        Me.txtBuscarCurso.Name = "txtBuscarCurso"
        Me.txtBuscarCurso.Size = New System.Drawing.Size(163, 20)
        Me.txtBuscarCurso.TabIndex = 28
        '
        'btnBuscarCurso
        '
        Me.btnBuscarCurso.Location = New System.Drawing.Point(279, 108)
        Me.btnBuscarCurso.Name = "btnBuscarCurso"
        Me.btnBuscarCurso.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscarCurso.TabIndex = 27
        Me.btnBuscarCurso.Text = "Buscar"
        Me.btnBuscarCurso.UseVisualStyleBackColor = True
        '
        'dtaListarCursos
        '
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
        Me.dtaListarCursos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.dtaListarCursos.GridColor = System.Drawing.Color.White
        Me.dtaListarCursos.Location = New System.Drawing.Point(100, 215)
        Me.dtaListarCursos.Name = "dtaListarCursos"
        Me.dtaListarCursos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dtaListarCursos.RowHeadersVisible = False
        Me.dtaListarCursos.Size = New System.Drawing.Size(524, 195)
        Me.dtaListarCursos.TabIndex = 25
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 200
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(97, 175)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(601, 260)
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'uCtrlBuscarCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.btnCrearCurso)
        Me.Controls.Add(Me.txtBuscarCurso)
        Me.Controls.Add(Me.btnBuscarCurso)
        Me.Controls.Add(Me.dtaListarCursos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "uCtrlBuscarCursos"
        Me.Size = New System.Drawing.Size(1070, 486)
        CType(Me.dtaListarCursos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCrearCurso As System.Windows.Forms.Button
    Friend WithEvents txtBuscarCurso As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscarCurso As System.Windows.Forms.Button
    Friend WithEvents dtaListarCursos As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
