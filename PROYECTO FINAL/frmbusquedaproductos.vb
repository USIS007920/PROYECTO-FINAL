Public Class frmbusquedaproductos
    Dim objconexion As New db_conexion
    Public _idC As Integer

    Private Sub btnSeleccionarProducto_Click(sender As Object, e As EventArgs) Handles btnseleccionarProducto.Click
        seleccionarProducto()
    End Sub
    Private Sub frmbusquedaproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductosTableAdapter1.Fill(Me.Db_SistemaDataSet1.Productos)
        grdbuscarproducto.DataSource = objconexion.obtenerDatos().Tables("Productos").DefaultView
    End Sub

    Private Sub txtbuscarproductos_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscarproductos.KeyUp
        Filtrardatosproductos(txtbuscarproductos.Text)
        If e.KeyCode = 13 Then
            seleccionarProducto()
        End If
    End Sub
    Private Sub seleccionarProducto()
        _idC = grdbuscarproducto.CurrentRow.Cells("idProducto").Value.ToString()
        Close()
    End Sub
    Private Sub Filtrardatosproductos(ByVal valor As String)
        Dim bs As New BindingSource
        bs.DataSource = grdbuscarproducto.DataSource
        bs.Filter = "nombre like '%" & valor & "%'"
        grdbuscarproducto.DataSource = bs
    End Sub

    Private Sub btnsCancelarProducto_Click(sender As Object, e As EventArgs) Handles btnCancelarProducto.Click
        _idC = 0
        Close()
    End Sub
End Class