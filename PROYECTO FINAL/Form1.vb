Public Class Form1

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ProvedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProvedoresToolStripMenuItem.Click
        Dim objProvedores As New frmProvedores
        objProvedores.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim objproductos As New Productos
        objproductos.Show()
    End Sub

    Private Sub NotaCreditoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotaCreditoToolStripMenuItem.Click
        Dim objnotacredito As New frmbusquedanotacredito
        objnotacredito.Show()
    End Sub

    Private Sub PresupuestoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PresupuestoToolStripMenuItem.Click
        Dim objPresupuesto As New frmbusquedapresupuesto
        objPresupuesto.Show()
    End Sub
End Class
