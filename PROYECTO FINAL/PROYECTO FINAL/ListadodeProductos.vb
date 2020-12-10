Public Class ListadodeProductos
    Private Sub ListadodeProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_SistemaDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.Db_SistemaDataSet.Productos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class