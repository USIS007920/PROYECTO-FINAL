Public Class ListadodePago
    Private Sub ListadodePago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_SistemaDataSet.pago' Puede moverla o quitarla según sea necesario.
        Me.pagoTableAdapter.Fillpago(Me.Db_SistemaDataSet.pago)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class