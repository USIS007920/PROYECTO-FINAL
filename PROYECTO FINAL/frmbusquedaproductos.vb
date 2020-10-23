Public Class frmbusquedaproductos

    Dim objconexion As New db_conexion



    Private Sub frmbusquedaproductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductosTableAdapter1.Fill(Me.Db_SistemaDataSet1.Productos)
        grdbuscarproducto.DataSource = objconexion.obtenerDatos().Tables("Productos").DefaultView
    End Sub


    Private Sub txtbuscarproductos_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscarproductos.KeyUp
        Filtrardatosproductos(txtbuscarproductos.Text)
    End Sub

    Private Sub Filtrardatosproductos(ByVal valor As String)
        Dim bs As New BindingSource
        bs.DataSource = grdbuscarproducto.DataSource
        bs.Filter = "nombre like '%" & valor & "%'"
        grdbuscarproducto.DataSource = bs
    End Sub
End Class