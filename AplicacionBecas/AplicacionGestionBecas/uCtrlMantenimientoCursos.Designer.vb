<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlMantenimientoCursos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlMantenimientoCursos))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnCrearCurso = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(31, 126)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(975, 321)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'btnCrearCurso
        '
        Me.btnCrearCurso.BackgroundImage = CType(resources.GetObject("btnCrearCurso.BackgroundImage"), System.Drawing.Image)
        Me.btnCrearCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCrearCurso.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCrearCurso.ForeColor = System.Drawing.Color.White
        Me.btnCrearCurso.Location = New System.Drawing.Point(784, 32)
        Me.btnCrearCurso.Name = "btnCrearCurso"
        Me.btnCrearCurso.Size = New System.Drawing.Size(222, 79)
        Me.btnCrearCurso.TabIndex = 7
        Me.btnCrearCurso.Text = "Crear Curso"
        Me.btnCrearCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCrearCurso.UseVisualStyleBackColor = True
        '
        'uCtrlMantenimientoCursos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCrearCurso)
        Me.Location = New System.Drawing.Point(145, 124)
        Me.Name = "uCtrlMantenimientoCursos"
        Me.Size = New System.Drawing.Size(1037, 478)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnCrearCurso As System.Windows.Forms.Button

End Class
