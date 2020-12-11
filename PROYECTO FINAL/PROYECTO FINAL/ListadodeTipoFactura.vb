Public Class ListadodeTipoFactura
    Private Sub ListadodeTipoFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_SistemaDataSet.tipofactura' Puede moverla o quitarla según sea necesario.
        Me.tipofacturaTableAdapter.FillTipofactura(Me.Db_SistemaDataSet.tipofactura)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class