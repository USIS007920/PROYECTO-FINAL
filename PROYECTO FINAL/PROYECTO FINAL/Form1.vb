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

    Private Sub PreciosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PreciosToolStripMenuItem.Click
        Dim objEmpleados As New frmEmpleados
        objEmpleados.Show()
    End Sub

    Private Sub FacturacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturacionToolStripMenuItem.Click
        Dim objVentas As New frmVentas
        objVentas.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Dim objClientes As New frmClientes
        objClientes.Show()
    End Sub

    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Dim objCategorias As New FrmBuscarCategorias
        objCategorias.Show()
    End Sub

    Private Sub ListadoDeProvedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProvedoresToolStripMenuItem.Click
        Dim objListadodeProvedores As New ListadodeProvedores
        objListadodeProvedores.Show()
    End Sub

    Private Sub ListadoDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        Dim objListadodeClientes As New ListadodeClientes
        objListadodeClientes.Show()
    End Sub

    Private Sub ListadoDeProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeProductosToolStripMenuItem.Click
        Dim objListadodeProductos As New ListadodeProductos
        objListadodeProductos.Show()
    End Sub

    Private Sub ListadoDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeVentasToolStripMenuItem.Click
        Dim objListadodeVentas As New ListadodeVentas
        objListadodeVentas.Show()
    End Sub

    Private Sub ListadoDePagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDePagoToolStripMenuItem.Click
        Dim objListadodePago As New ListadodePago
        objListadodePago.Show()
    End Sub

    Private Sub ListadoDeDetalleDeVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeDetalleDeVentasToolStripMenuItem.Click
        Dim objListadodeDetalledeVentas As New ListadodeDetalledeVentas
        objListadodeDetalledeVentas.Show()
    End Sub

    Private Sub ListadoDeTipoFacturaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListadoDeTipoFacturaToolStripMenuItem.Click
        Dim objListadodeTipoFactura As New ListadodeTipoFactura
        objListadodeTipoFactura.Show()
    End Sub
End Class
