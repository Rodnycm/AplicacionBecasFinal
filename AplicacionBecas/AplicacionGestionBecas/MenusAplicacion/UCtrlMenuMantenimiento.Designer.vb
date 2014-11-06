<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlMenuMantenimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlMenuMantenimiento))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnUsuarios = New System.Windows.Forms.Button()
        Me.btnCursos = New System.Windows.Forms.Button()
        Me.btnBeneficios = New System.Windows.Forms.Button()
        Me.btnCarreras = New System.Windows.Forms.Button()
        Me.btnRoles = New System.Windows.Forms.Button()
        Me.btnBecas = New System.Windows.Forms.Button()
        Me.btnRequisitos = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 162.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 190.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnUsuarios, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCursos, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBeneficios, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnCarreras, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRoles, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnBecas, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnRequisitos, 3, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(175, 134)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.40174!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.59826!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(850, 229)
        Me.TableLayoutPanel1.TabIndex = 13
        '
        'btnUsuarios
        '
        Me.btnUsuarios.BackgroundImage = CType(resources.GetObject("btnUsuarios.BackgroundImage"), System.Drawing.Image)
        Me.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsuarios.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsuarios.ForeColor = System.Drawing.Color.White
        Me.btnUsuarios.Location = New System.Drawing.Point(3, 3)
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(128, 99)
        Me.btnUsuarios.TabIndex = 5
        Me.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUsuarios.UseVisualStyleBackColor = True
        '
        'btnCursos
        '
        Me.btnCursos.BackgroundImage = CType(resources.GetObject("btnCursos.BackgroundImage"), System.Drawing.Image)
        Me.btnCursos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCursos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCursos.ForeColor = System.Drawing.Color.White
        Me.btnCursos.Location = New System.Drawing.Point(168, 122)
        Me.btnCursos.Name = "btnCursos"
        Me.btnCursos.Size = New System.Drawing.Size(128, 99)
        Me.btnCursos.TabIndex = 10
        Me.btnCursos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCursos.UseVisualStyleBackColor = True
        '
        'btnBeneficios
        '
        Me.btnBeneficios.BackgroundImage = CType(resources.GetObject("btnBeneficios.BackgroundImage"), System.Drawing.Image)
        Me.btnBeneficios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBeneficios.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeneficios.ForeColor = System.Drawing.Color.White
        Me.btnBeneficios.Location = New System.Drawing.Point(663, 3)
        Me.btnBeneficios.Name = "btnBeneficios"
        Me.btnBeneficios.Size = New System.Drawing.Size(128, 99)
        Me.btnBeneficios.TabIndex = 9
        Me.btnBeneficios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBeneficios.UseVisualStyleBackColor = True
        '
        'btnCarreras
        '
        Me.btnCarreras.BackgroundImage = CType(resources.GetObject("btnCarreras.BackgroundImage"), System.Drawing.Image)
        Me.btnCarreras.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCarreras.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCarreras.ForeColor = System.Drawing.Color.White
        Me.btnCarreras.Location = New System.Drawing.Point(3, 122)
        Me.btnCarreras.MaximumSize = New System.Drawing.Size(128, 99)
        Me.btnCarreras.MinimumSize = New System.Drawing.Size(128, 99)
        Me.btnCarreras.Name = "btnCarreras"
        Me.btnCarreras.Size = New System.Drawing.Size(128, 99)
        Me.btnCarreras.TabIndex = 8
        Me.btnCarreras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCarreras.UseVisualStyleBackColor = True
        '
        'btnRoles
        '
        Me.btnRoles.BackgroundImage = CType(resources.GetObject("btnRoles.BackgroundImage"), System.Drawing.Image)
        Me.btnRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRoles.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoles.ForeColor = System.Drawing.Color.White
        Me.btnRoles.Location = New System.Drawing.Point(168, 3)
        Me.btnRoles.Name = "btnRoles"
        Me.btnRoles.Size = New System.Drawing.Size(128, 99)
        Me.btnRoles.TabIndex = 6
        Me.btnRoles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRoles.UseVisualStyleBackColor = True
        '
        'btnBecas
        '
        Me.btnBecas.BackgroundImage = CType(resources.GetObject("btnBecas.BackgroundImage"), System.Drawing.Image)
        Me.btnBecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBecas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBecas.ForeColor = System.Drawing.Color.White
        Me.btnBecas.Location = New System.Drawing.Point(333, 3)
        Me.btnBecas.Name = "btnBecas"
        Me.btnBecas.Size = New System.Drawing.Size(128, 99)
        Me.btnBecas.TabIndex = 7
        Me.btnBecas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBecas.UseVisualStyleBackColor = True
        '
        'btnRequisitos
        '
        Me.btnRequisitos.BackgroundImage = CType(resources.GetObject("btnRequisitos.BackgroundImage"), System.Drawing.Image)
        Me.btnRequisitos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRequisitos.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRequisitos.ForeColor = System.Drawing.Color.White
        Me.btnRequisitos.Location = New System.Drawing.Point(501, 3)
        Me.btnRequisitos.Name = "btnRequisitos"
        Me.btnRequisitos.Size = New System.Drawing.Size(128, 99)
        Me.btnRequisitos.TabIndex = 11
        Me.btnRequisitos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRequisitos.UseVisualStyleBackColor = True
        '
        'uCtrlMenuMantenimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "uCtrlMenuMantenimiento"
        Me.Size = New System.Drawing.Size(1030, 640)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnUsuarios As System.Windows.Forms.Button
    Friend WithEvents btnCursos As System.Windows.Forms.Button
    Friend WithEvents btnBeneficios As System.Windows.Forms.Button
    Friend WithEvents btnCarreras As System.Windows.Forms.Button
    Friend WithEvents btnRoles As System.Windows.Forms.Button
    Friend WithEvents btnBecas As System.Windows.Forms.Button
    Friend WithEvents btnRequisitos As System.Windows.Forms.Button

End Class
