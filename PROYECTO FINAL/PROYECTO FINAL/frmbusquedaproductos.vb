Public Class frmbusquedaproductos

    Dim objconexion As New db_conexion
    Public _idP As Integer
    Public _codigoProducto As String
    Public _nombreProducto As String
    Private Sub frmBusquedaProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdbuscarproducto.DataSource = objconexion.obtenerDatos().Tables("productos").DefaultView
    End Sub
    Private Sub filtrarDatosProductos(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdbuscarproducto.DataSource
        bs.Filter = "categoria like '%" + valor + "%' or codigo like '%" & valor & "%' or  descripcion like '%" & valor & "%'"
        grdbuscarproducto.DataSource = bs
    End Sub
    Private Sub seleccionarProducto()
        _idP = grdbuscarproducto.CurrentRow.Cells("idProducto").Value.ToString()
        _codigoProducto = grdbuscarproducto.CurrentRow.Cells("codigo").Value.ToString()
        _nombreProducto = grdbuscarproducto.CurrentRow.Cells("nombre").Value.ToString()
        Close()
    End Sub
    Private Sub btnSeleccionarProductos_Click(sender As Object, e As EventArgs) Handles btnSeleccionarProducto.Click
        seleccionarProducto()
    End Sub
    Private Sub txtBuscarProducto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscarproductos.KeyUp
        filtrarDatosProductos(txtbuscarproductos.Text)
        If e.KeyCode = 13 Then
            seleccionarProducto()
        End If
    End Sub


End Class