<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlRegistrarBeneficio
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
        Me.txtAplicacion = New System.Windows.Forms.TextBox()
        Me.txPorcentaje = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblAplicacion = New System.Windows.Forms.Label()
        Me.txtPorcentaje = New System.Windows.Forms.TextBox()
        Me.lblPorcentaje = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblCrear = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtAplicacion
        '
        Me.txtAplicacion.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.txtAplicacion.ForeColor = System.Drawing.Color.Black
        Me.txtAplicacion.Location = New System.Drawing.Point(179, 191)
        Me.txtAplicacion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAplicacion.Name = "txtAplicacion"
        Me.txtAplicacion.Size = New System.Drawing.Size(121, 25)
        Me.txtAplicacion.TabIndex = 19
        '
        'txPorcentaje
        '
        Me.txPorcentaje.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.txPorcentaje.ForeColor = System.Drawing.Color.Black
        Me.txPorcentaje.Location = New System.Drawing.Point(179, 132)
        Me.txPorcentaje.Margin = New System.Windows.Forms.Padding(4)
        Me.txPorcentaje.Name = "txPorcentaje"
        Me.txPorcentaje.Size = New System.Drawing.Size(121, 25)
        Me.txPorcentaje.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(454, 393)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(2, 2)
        Me.TextBox1.TabIndex = 17
        '
        'lblAplicacion
        '
        Me.lblAplicacion.AutoSize = True
        Me.lblAplicacion.BackColor = System.Drawing.Color.Transparent
        Me.lblAplicacion.Font = New System.Drawing.Font("Segoe UI Light", 12.75!)
        Me.lblAplicacion.Location = New System.Drawing.Point(18, 189)
        Me.lblAplicacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAplicacion.Name = "lblAplicacion"
        Me.lblAplicacion.Size = New System.Drawing.Size(120, 23)
        Me.lblAplicacion.TabIndex = 16
        Me.lblAplicacion.Text = "A que se aplica"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.txtPorcentaje.Location = New System.Drawing.Point(269, 161)
        Me.txtPorcentaje.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPorcentaje.Multiline = True
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(2, 2)
        Me.txtPorcentaje.TabIndex = 15
        '
        'lblPorcentaje
        '
        Me.lblPorcentaje.AutoSize = True
        Me.lblPorcentaje.BackColor = System.Drawing.Color.Transparent
        Me.lblPorcentaje.Font = New System.Drawing.Font("Segoe UI Light", 12.75!)
        Me.lblPorcentaje.Location = New System.Drawing.Point(17, 130)
        Me.lblPorcentaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPorcentaje.Name = "lblPorcentaje"
        Me.lblPorcentaje.Size = New System.Drawing.Size(131, 23)
        Me.lblPorcentaje.TabIndex = 14
        Me.lblPorcentaje.Text = "Porcentaje (0.00)"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI Light", 9.75!)
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.Location = New System.Drawing.Point(179, 76)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(121, 25)
        Me.txtNombre.TabIndex = 13
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.BackColor = System.Drawing.Color.Transparent
        Me.lblNombre.Font = New System.Drawing.Font("Segoe UI Light", 12.75!)
        Me.lblNombre.Location = New System.Drawing.Point(17, 76)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(71, 23)
        Me.lblNombre.TabIndex = 12
        Me.lblNombre.Text = "Nombre"
        '
        'lblCrear
        '
        Me.lblCrear.AutoSize = True
        Me.lblCrear.BackColor = System.Drawing.Color.Transparent
        Me.lblCrear.Font = New System.Drawing.Font("Segoe UI Light", 13.0!)
        Me.lblCrear.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCrear.Location = New System.Drawing.Point(17, 0)
        Me.lblCrear.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCrear.Name = "lblCrear"
        Me.lblCrear.Size = New System.Drawing.Size(53, 25)
        Me.lblCrear.TabIndex = 22
        Me.lblCrear.Text = "Crear"
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Light", 12.75!)
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCancelar.Location = New System.Drawing.Point(231, 290)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(86, 29)
        Me.btnCancelar.TabIndex = 21
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAñadir
        '
        Me.btnAñadir.BackColor = System.Drawing.Color.Transparent
        Me.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAñadir.Font = New System.Drawing.Font("Segoe UI Light", 12.75!)
        Me.btnAñadir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAñadir.Location = New System.Drawing.Point(354, 290)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(86, 29)
        Me.btnAñadir.TabIndex = 20
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackColor = System.Drawing.Color.Transparent
        Me.btnCerrar.BackgroundImage = Global.UI.My.Resources.Resources.cerrar
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(451, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 21)
        Me.btnCerrar.TabIndex = 23
        Me.btnCerrar.UseVisualStyleBackColor = False
        '
        'uCtrlRegistrarBeneficio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.UI.My.Resources.Resources.tablaFinalMedianaAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblCrear)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.txtAplicacion)
        Me.Controls.Add(Me.txPorcentaje)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblAplicacion)
        Me.Controls.Add(Me.txtPorcentaje)
        Me.Controls.Add(Me.lblPorcentaje)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Font = New System.Drawing.Font("Segoe UI Light", 12.75!)
        Me.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.Name = "uCtrlRegistrarBeneficio"
        Me.Size = New System.Drawing.Size(474, 356)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents txtAplicacion As System.Windows.Forms.TextBox
    Friend WithEvents txPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblAplicacion As System.Windows.Forms.Label
    Friend WithEvents txtPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents lblPorcentaje As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblCrear As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button

End Class
