<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uCtrlReporteRegistroAcciones
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
        Me.components = New System.ComponentModel.Container()
<<<<<<< HEAD
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(uCtrlReporteRegistroAcciones))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Tb_BitacoraAccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB_Proyecto2DataSetConsultarRegistroAcciones = New UI.DB_Proyecto2DataSetConsultarRegistroAcciones()
        Me.Tb_BitacoraAccionTableAdapter = New UI.DB_Proyecto2DataSetConsultarRegistroAccionesTableAdapters.Tb_BitacoraAccionTableAdapter()
        Me.DB_Proyecto2DataSet1 = New UI.DB_Proyecto2DataSet1()
        CType(Me.Tb_BitacoraAccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_Proyecto2DataSetConsultarRegistroAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_Proyecto2DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
=======
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DB_Proyecto2DataSetConsultarRegistroAcciones = New UI.DB_Proyecto2DataSetConsultarRegistroAcciones()
        Me.Tb_BitacoraAccionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tb_BitacoraAccionTableAdapter = New UI.DB_Proyecto2DataSetConsultarRegistroAccionesTableAdapters.Tb_BitacoraAccionTableAdapter()
        CType(Me.DB_Proyecto2DataSetConsultarRegistroAcciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tb_BitacoraAccionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
>>>>>>> origin/prophet94
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
<<<<<<< HEAD
        ReportDataSource1.Name = "DataSetRegistroAcciones"
        ReportDataSource1.Value = Me.Tb_BitacoraAccionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "UI.Report3.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(13, 41)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(947, 271)
        Me.ReportViewer1.TabIndex = 0
        '
        'Tb_BitacoraAccionBindingSource
        '
        Me.Tb_BitacoraAccionBindingSource.DataMember = "Tb_BitacoraAccion"
        Me.Tb_BitacoraAccionBindingSource.DataSource = Me.DB_Proyecto2DataSetConsultarRegistroAcciones
        '
=======
        ReportDataSource2.Name = "DataSetConsultarRegistroAccion"
        ReportDataSource2.Value = Me.Tb_BitacoraAccionBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionGestionBecas.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 31)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(715, 246)
        Me.ReportViewer1.TabIndex = 0
        '
>>>>>>> origin/prophet94
        'DB_Proyecto2DataSetConsultarRegistroAcciones
        '
        Me.DB_Proyecto2DataSetConsultarRegistroAcciones.DataSetName = "DB_Proyecto2DataSetConsultarRegistroAcciones"
        Me.DB_Proyecto2DataSetConsultarRegistroAcciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
<<<<<<< HEAD
        'Tb_BitacoraAccionTableAdapter
        '
        Me.Tb_BitacoraAccionTableAdapter.ClearBeforeFill = True
        '
        'DB_Proyecto2DataSet1
        '
        Me.DB_Proyecto2DataSet1.DataSetName = "DB_Proyecto2DataSet1"
        Me.DB_Proyecto2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
=======
        'Tb_BitacoraAccionBindingSource
        '
        Me.Tb_BitacoraAccionBindingSource.DataMember = "Tb_BitacoraAccion"
        Me.Tb_BitacoraAccionBindingSource.DataSource = Me.DB_Proyecto2DataSetConsultarRegistroAcciones
        '
        'Tb_BitacoraAccionTableAdapter
        '
        Me.Tb_BitacoraAccionTableAdapter.ClearBeforeFill = True
>>>>>>> origin/prophet94
        '
        'uCtrlReporteRegistroAcciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< HEAD
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "uCtrlReporteRegistroAcciones"
        Me.Size = New System.Drawing.Size(975, 321)
        CType(Me.Tb_BitacoraAccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_Proyecto2DataSetConsultarRegistroAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_Proyecto2DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
=======
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "uCtrlReporteRegistroAcciones"
        Me.Size = New System.Drawing.Size(745, 323)
        CType(Me.DB_Proyecto2DataSetConsultarRegistroAcciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tb_BitacoraAccionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> origin/prophet94
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents Tb_BitacoraAccionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DB_Proyecto2DataSetConsultarRegistroAcciones As UI.DB_Proyecto2DataSetConsultarRegistroAcciones
    Friend WithEvents Tb_BitacoraAccionTableAdapter As UI.DB_Proyecto2DataSetConsultarRegistroAccionesTableAdapters.Tb_BitacoraAccionTableAdapter
<<<<<<< HEAD
    Friend WithEvents DB_Proyecto2DataSet1 As UI.DB_Proyecto2DataSet1
=======
>>>>>>> origin/prophet94

End Class
