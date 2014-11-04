<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuLateral = New System.Windows.Forms.MenuStrip()
        Me.InicioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AcadémicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BecasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnsMenus = New System.Windows.Forms.TableLayoutPanel()
        Me.btnMantenimiento = New System.Windows.Forms.Button()
        Me.btnReportes = New System.Windows.Forms.Button()
        Me.btnAcademico = New System.Windows.Forms.Button()
        Me.btnBecas = New System.Windows.Forms.Button()
        Me.MenuLateral.SuspendLayout()
        Me.btnsMenus.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuLateral
        '
        Me.MenuLateral.BackColor = System.Drawing.Color.FromArgb(CType(CType(72, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(67, Byte), Integer))
        Me.MenuLateral.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuLateral.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuLateral.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InicioToolStripMenuItem, Me.MantenimientoToolStripMenuItem, Me.AcadémicoToolStripMenuItem, Me.BecasToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuLateral.Location = New System.Drawing.Point(0, 0)
        Me.MenuLateral.Name = "MenuLateral"
        Me.MenuLateral.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.MenuLateral.Size = New System.Drawing.Size(131, 661)
        Me.MenuLateral.TabIndex = 0
        Me.MenuLateral.Text = "MenuStrip1"
        '
        'InicioToolStripMenuItem
        '
        Me.InicioToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.InicioToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 120, 0, 0)
        Me.InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        Me.InicioToolStripMenuItem.Size = New System.Drawing.Size(124, 25)
        Me.InicioToolStripMenuItem.Text = "Inicio"
        Me.InicioToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MantenimientoToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 20, 0, 20)
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(124, 25)
        Me.MantenimientoToolStripMenuItem.Text = "Mantenimiento"
        Me.MantenimientoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'AcadémicoToolStripMenuItem
        '
        Me.AcadémicoToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AcadémicoToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.AcadémicoToolStripMenuItem.Name = "AcadémicoToolStripMenuItem"
        Me.AcadémicoToolStripMenuItem.Size = New System.Drawing.Size(124, 25)
        Me.AcadémicoToolStripMenuItem.Text = "Académico"
        Me.AcadémicoToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BecasToolStripMenuItem
        '
        Me.BecasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.BecasToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.BecasToolStripMenuItem.Name = "BecasToolStripMenuItem"
        Me.BecasToolStripMenuItem.Size = New System.Drawing.Size(124, 25)
        Me.BecasToolStripMenuItem.Text = "Becas"
        Me.BecasToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportesToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 20)
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(124, 25)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        Me.ReportesToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnsMenus
        '
        Me.btnsMenus.ColumnCount = 4
        Me.btnsMenus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.39516!))
        Me.btnsMenus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.60484!))
        Me.btnsMenus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 244.0!))
        Me.btnsMenus.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252.0!))
        Me.btnsMenus.Controls.Add(Me.btnReportes, 3, 0)
        Me.btnsMenus.Controls.Add(Me.btnAcademico, 1, 0)
        Me.btnsMenus.Controls.Add(Me.btnBecas, 2, 0)
        Me.btnsMenus.Controls.Add(Me.btnMantenimiento, 0, 0)
        Me.btnsMenus.Location = New System.Drawing.Point(175, 134)
        Me.btnsMenus.Name = "btnsMenus"
        Me.btnsMenus.RowCount = 1
        Me.btnsMenus.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.btnsMenus.Size = New System.Drawing.Size(975, 87)
        Me.btnsMenus.TabIndex = 8
        '
        'btnMantenimiento
        '
        Me.btnMantenimiento.BackgroundImage = CType(resources.GetObject("btnMantenimiento.BackgroundImage"), System.Drawing.Image)
        Me.btnMantenimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMantenimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMantenimiento.ForeColor = System.Drawing.Color.White
        Me.btnMantenimiento.Location = New System.Drawing.Point(3, 3)
        Me.btnMantenimiento.Name = "btnMantenimiento"
        Me.btnMantenimiento.Size = New System.Drawing.Size(222, 79)
        Me.btnMantenimiento.TabIndex = 4
        Me.btnMantenimiento.Text = "Mantenimiento"
        Me.btnMantenimiento.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnMantenimiento.UseVisualStyleBackColor = True
        '
        'btnReportes
        '
        Me.btnReportes.BackgroundImage = CType(resources.GetObject("btnReportes.BackgroundImage"), System.Drawing.Image)
        Me.btnReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReportes.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReportes.ForeColor = System.Drawing.Color.White
        Me.btnReportes.Location = New System.Drawing.Point(725, 3)
        Me.btnReportes.Name = "btnReportes"
        Me.btnReportes.Size = New System.Drawing.Size(225, 79)
        Me.btnReportes.TabIndex = 6
        Me.btnReportes.Text = "Reportes"
        Me.btnReportes.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnReportes.UseVisualStyleBackColor = True
        '
        'btnAcademico
        '
        Me.btnAcademico.BackgroundImage = CType(resources.GetObject("btnAcademico.BackgroundImage"), System.Drawing.Image)
        Me.btnAcademico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAcademico.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAcademico.ForeColor = System.Drawing.Color.White
        Me.btnAcademico.Location = New System.Drawing.Point(239, 3)
        Me.btnAcademico.Name = "btnAcademico"
        Me.btnAcademico.Size = New System.Drawing.Size(222, 79)
        Me.btnAcademico.TabIndex = 5
        Me.btnAcademico.Text = "Académico"
        Me.btnAcademico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAcademico.UseVisualStyleBackColor = True
        '
        'btnBecas
        '
        Me.btnBecas.BackgroundImage = CType(resources.GetObject("btnBecas.BackgroundImage"), System.Drawing.Image)
        Me.btnBecas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBecas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBecas.ForeColor = System.Drawing.Color.White
        Me.btnBecas.Location = New System.Drawing.Point(481, 3)
        Me.btnBecas.Name = "btnBecas"
        Me.btnBecas.Size = New System.Drawing.Size(225, 79)
        Me.btnBecas.TabIndex = 7
        Me.btnBecas.Text = "Becas"
        Me.btnBecas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnBecas.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.btnsMenus)
        Me.Controls.Add(Me.MenuLateral)
        Me.Name = "frmPrincipal"
        Me.Text = "Gestión de Becas"
        Me.MenuLateral.ResumeLayout(False)
        Me.MenuLateral.PerformLayout()
        Me.btnsMenus.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuLateral As System.Windows.Forms.MenuStrip
    Friend WithEvents InicioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcadémicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BecasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnReportes As System.Windows.Forms.Button
    Friend WithEvents btnMantenimiento As System.Windows.Forms.Button
    Friend WithEvents btnBecas As System.Windows.Forms.Button
    Friend WithEvents btnAcademico As System.Windows.Forms.Button
    Friend WithEvents btnsMenus As System.Windows.Forms.TableLayoutPanel

End Class
