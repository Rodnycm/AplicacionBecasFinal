﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlMantenimientoRequisitos))
        Me.dgvRequisitos = New System.Windows.Forms.DataGridView()
        Me.dtaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modificarcmb = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.colmId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCrearRequisito = New System.Windows.Forms.Button()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        CType(Me.dgvRequisitos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvRequisitos
        '
        Me.dgvRequisitos.BackgroundColor = System.Drawing.Color.White
        Me.dgvRequisitos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvRequisitos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRequisitos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRequisitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRequisitos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dtaNombre, Me.descripcion, Me.Modificarcmb, Me.colmId})
        Me.dgvRequisitos.GridColor = System.Drawing.Color.White
        Me.dgvRequisitos.Location = New System.Drawing.Point(40, 235)
        Me.dgvRequisitos.Name = "dgvRequisitos"
        Me.dgvRequisitos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvRequisitos.RowHeadersVisible = False
        Me.dgvRequisitos.ShowEditingIcon = False
        Me.dgvRequisitos.Size = New System.Drawing.Size(952, 271)
        Me.dgvRequisitos.TabIndex = 15
        '
        'dtaNombre
        '
        Me.dtaNombre.HeaderText = "Nombre"
        Me.dtaNombre.Name = "dtaNombre"
        Me.dtaNombre.ReadOnly = True
        Me.dtaNombre.Width = 160
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Descripcion"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 570
        '
        'Modificarcmb
        '
        Me.Modificarcmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Modificarcmb.HeaderText = "Modificar"
        Me.Modificarcmb.Items.AddRange(New Object() {"Editar", "Eliminar"})
        Me.Modificarcmb.Name = "Modificarcmb"
        Me.Modificarcmb.Width = 190
        '
        'colmId
        '
        Me.colmId.HeaderText = ""
        Me.colmId.Name = "colmId"
        Me.colmId.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(30, 202)
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
        Me.btnCrearRequisito.Location = New System.Drawing.Point(783, 108)
        Me.btnCrearRequisito.Name = "btnCrearRequisito"
        Me.btnCrearRequisito.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearRequisito.TabIndex = 13
        Me.btnCrearRequisito.Text = "Crear Requisito"
        Me.btnCrearRequisito.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearRequisito.UseVisualStyleBackColor = True
        '
        'txtBuscar
        '
        Me.txtBuscar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar.ForeColor = System.Drawing.Color.Black
        Me.txtBuscar.Location = New System.Drawing.Point(31, 160)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(746, 27)
        Me.txtBuscar.TabIndex = 16
        Me.txtBuscar.Text = "Buscar:"
        '
        'uCtrlMantenimientoRequisitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.dgvRequisitos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCrearRequisito)
        Me.Location = New System.Drawing.Point(145, 50)
        Me.Name = "uCtrlMantenimientoRequisitos"
        Me.Size = New System.Drawing.Size(1037, 578)
        CType(Me.dgvRequisitos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRequisitos As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCrearRequisito As System.Windows.Forms.Button
    Friend WithEvents txtBuscar As System.Windows.Forms.TextBox
    Friend WithEvents dtaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modificarcmb As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colmId As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
