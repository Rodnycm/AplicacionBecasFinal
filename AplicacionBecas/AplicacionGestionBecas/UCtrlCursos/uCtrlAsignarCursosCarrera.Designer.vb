<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlAsignarCursosCarrera
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
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAsignar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(14, 53)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(380, 259)
        Me.CheckedListBox1.TabIndex = 0
        '
        'btnCancelar
        '
        Me.btnCancelar.BackColor = System.Drawing.Color.Transparent
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnCancelar.Location = New System.Drawing.Point(232, 318)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 28)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = False
        '
        'btnAsignar
        '
        Me.btnAsignar.BackColor = System.Drawing.Color.Transparent
        Me.btnAsignar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAsignar.Font = New System.Drawing.Font("Segoe UI Light", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAsignar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(248, Byte), Integer))
        Me.btnAsignar.Location = New System.Drawing.Point(312, 318)
        Me.btnAsignar.Name = "btnAsignar"
        Me.btnAsignar.Size = New System.Drawing.Size(82, 28)
        Me.btnAsignar.TabIndex = 4
        Me.btnAsignar.Text = "Asignar"
        Me.btnAsignar.UseVisualStyleBackColor = False
        '
        'uCtrlAsignarCursosCarrera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.UI.My.Resources.Resources.tablaFinalGrandeAzul
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.btnAsignar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Name = "uCtrlAsignarCursosCarrera"
        Me.Size = New System.Drawing.Size(409, 357)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAsignar As System.Windows.Forms.Button

End Class
