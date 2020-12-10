Public Class ListadodeProvedores
    Private Sub ListadodeProvedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_SistemaDataSet.Provedores' Puede moverla o quitarla según sea necesario.
        Me.ProvedoresTableAdapter.FillProvedores(Me.Db_SistemaDataSet.Provedores)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class