<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlCrearTipoBeca
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlCrearTipoBeca))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.btnRequisitos = New System.Windows.Forms.Button()
        Me.btnBeneficios = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnX = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(105, 96)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(132, 20)
        Me.txtNombre.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Estado"
        '
        'txtEstado
        '
        Me.txtEstado.Location = New System.Drawing.Point(105, 146)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Light", 12.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(240, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 23)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(330, 149)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 5
        '
        'btnRequisitos
        '
        Me.btnRequisitos.BackColor = System.Drawing.Color.White
        Me.btnRequisitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequisitos.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequisitos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnRequisitos.Location = New System.Drawing.Point(16, 186)
        Me.btnRequisitos.Name = "btnRequisitos"
        Me.btnRequisitos.Size = New System.Drawing.Size(85, 33)
        Me.btnRequisitos.TabIndex = 6
        Me.btnRequisitos.Text = "Requisitos"
        Me.btnRequisitos.UseVisualStyleBackColor = False
        '
        'btnBeneficios
        '
        Me.btnBeneficios.BackColor = System.Drawing.Color.White
        Me.btnBeneficios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeneficios.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeneficios.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnBeneficios.Location = New System.Drawing.Point(105, 186)
        Me.btnBeneficios.Name = "btnBeneficios"
        Me.btnBeneficios.Size = New System.Drawing.Size(85, 33)
        Me.btnBeneficios.TabIndex = 7
        Me.btnBeneficios.Text = "Beneficios"
        Me.btnBeneficios.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.White
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCancelar.Location = New System.Drawing.Point(227, 265)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(92, 33)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAñadir
        '
        Me.btnAñadir.BackColor = System.Drawing.Color.White
        Me.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAñadir.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAñadir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAñadir.Location = New System.Drawing.Point(330, 265)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(92, 33)
        Me.btnAñadir.TabIndex = 9
        Me.btnAñadir.Text = "Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = False
        '
        'btnCerrar
        '
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCerrar.Location = New System.Drawing.Point(451, 4)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(20, 21)
        Me.btnCerrar.TabIndex = 10
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.White
        Me.Label13.Location = New System.Drawing.Point(3, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 25)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "Crear"
        '
        'btnX
        '
        Me.btnX.BackColor = System.Drawing.Color.Transparent
        Me.btnX.BackgroundImage = CType(resources.GetObject("btnX.BackgroundImage"), System.Drawing.Image)
        Me.btnX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnX.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnX.Location = New System.Drawing.Point(451, 4)
        Me.btnX.Name = "btnX"
        Me.btnX.Size = New System.Drawing.Size(20, 21)
        Me.btnX.TabIndex = 62
        Me.btnX.UseVisualStyleBackColor = False
        '
        'uCtrlCrearTipoBeca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.btnX)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnBeneficios)
        Me.Controls.Add(Me.btnRequisitos)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "uCtrlCrearTipoBeca"
        Me.Size = New System.Drawing.Size(474, 321)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEstado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents btnRequisitos As System.Windows.Forms.Button
    Friend WithEvents btnBeneficios As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAñadir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnX As System.Windows.Forms.Button

End Class
