Public Class ListadodeVentas
    Private Sub ListadodeVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_SistemaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.FillVentas(Me.Db_SistemaDataSet.Ventas)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class