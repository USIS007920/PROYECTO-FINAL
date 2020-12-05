Public Class frmbusquedaempleados
    Dim objconexion As New db_conexion



    Private Sub frmbusquedaempleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdbuscarempleado.DataSource = objconexion.obtenerDatos().Tables("empleado").DefaultView
    End Sub


    Private Sub txtbuscarempleado_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscarempleados.KeyUp
        Filtrardatosproductos(txtbuscarempleados.Text)
    End Sub

    Private Sub Filtrardatosproductos(ByVal valor As String)
        Dim bs As New BindingSource
        bs.DataSource = grdbuscarempleado.DataSource
        bs.Filter = "nombre like '%" & valor & "%'"
        grdbuscarempleado.DataSource = bs
    End Sub
End Class