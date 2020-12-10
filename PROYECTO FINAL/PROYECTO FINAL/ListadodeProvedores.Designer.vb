<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadodeProvedores
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Db_SistemaDataSet = New PROYECTO_FINAL.Db_SistemaDataSet()
        Me.ProvedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProvedoresTableAdapter = New PROYECTO_FINAL.Db_SistemaDataSetTableAdapters.ProvedoresTableAdapter()
        CType(Me.Db_SistemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "dsReporteProvedores"
        ReportDataSource1.Value = Me.ProvedoresBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PROYECTO_FINAL.ReporteProvedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(39, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(699, 405)
        Me.ReportViewer1.TabIndex = 0
        '
        'Db_SistemaDataSet
        '
        Me.Db_SistemaDataSet.DataSetName = "Db_SistemaDataSet"
        Me.Db_SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProvedoresBindingSource
        '
        Me.ProvedoresBindingSource.DataMember = "Provedores"
        Me.ProvedoresBindingSource.DataSource = Me.Db_SistemaDataSet
        '
        'ProvedoresTableAdapter
        '
        Me.ProvedoresTableAdapter.ClearBeforeFill = True
        '
        'ListadodeProvedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "ListadodeProvedores"
        Me.Text = "ListadodeProvedores"
        CType(Me.Db_SistemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProvedoresBindingSource As BindingSource
    Friend WithEvents Db_SistemaDataSet As Db_SistemaDataSet
    Friend WithEvents ProvedoresTableAdapter As Db_SistemaDataSetTableAdapters.ProvedoresTableAdapter
End Class
