Public Class frmBusquedaEmpleados
    Dim objconexion As New db_conexion
    Public _idC As Integer

    Private Sub btnSeleccionarEmpleados_Click(sender As Object, e As EventArgs) Handles btnseleccionarEmpleados.Click
        seleccionarEmpleados()
    End Sub
    Private Sub frmbusquedaempleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdbuscarempleados.DataSource = objconexion.obtenerDatos().Tables("Empleados").DefaultView
    End Sub

    Private Sub txtbuscarEmpleados_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscarempleados.KeyUp
        FiltrardatosEmpleados(txtbuscarempleados.Text)
        If e.KeyCode = 13 Then
            seleccionarEmpleados()
        End If
    End Sub
    Private Sub seleccionarEmpleados()
        _idC = grdbuscarempleados.CurrentRow.Cells("idEmpleado").Value.ToString()
        Close()
    End Sub
    Private Sub FiltrardatosEmpleados(ByVal valor As String)
        Dim bs As New BindingSource
        bs.DataSource = grdbuscarempleados.DataSource
        bs.Filter = "nombre like '%" & valor & "%'"
        grdbuscarempleados.DataSource = bs
    End Sub

    Private Sub btnsCancelarempleados_Click(sender As Object, e As EventArgs) Handles btnCancelarEmpleado.Click
        _idC = 0
        Close()
    End Sub


End Class