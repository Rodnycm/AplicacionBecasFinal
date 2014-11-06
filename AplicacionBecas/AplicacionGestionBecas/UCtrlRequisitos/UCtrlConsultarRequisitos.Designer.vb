<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlConsultarRequisitos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlConsultarRequisitos))
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dtgConsultarRequisito = New System.Windows.Forms.DataGridView()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtgConsultarRequisito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(386, 19)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 21)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCancelar.Location = New System.Drawing.Point(170, 321)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 33)
        Me.btnCancelar.TabIndex = 13
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'dtgConsultarRequisito
        '
        Me.dtgConsultarRequisito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgConsultarRequisito.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.nombre})
        Me.dtgConsultarRequisito.Location = New System.Drawing.Point(13, 104)
        Me.dtgConsultarRequisito.Name = "dtgConsultarRequisito"
        Me.dtgConsultarRequisito.Size = New System.Drawing.Size(381, 195)
        Me.dtgConsultarRequisito.TabIndex = 14
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        '
        'uCtrlConsultarRequisitos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.dtgConsultarRequisito)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Location = New System.Drawing.Point(300, 100)
        Me.Name = "uCtrlConsultarRequisitos"
        Me.Size = New System.Drawing.Size(409, 357)
        CType(Me.dtgConsultarRequisito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dtgConsultarRequisito As System.Windows.Forms.DataGridView
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
