Public Class ListadodeDetalledeVentas
    Private Sub ListadodeDetalledeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_SistemaDataSet.d_venta' Puede moverla o quitarla según sea necesario.
        Me.d_ventaTableAdapter.Filld_venta(Me.Db_SistemaDataSet.d_venta)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class