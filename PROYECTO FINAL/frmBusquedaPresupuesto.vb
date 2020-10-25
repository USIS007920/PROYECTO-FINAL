Public Class frmBusquedaPresupuesto
    Dim objconexion As New db_conexion
    Public _idC As Integer

    Private Sub btnSeleccionarPresupuesto_Click(sender As Object, e As EventArgs) Handles btnseleccionarPresupuesto.Click
        seleccionarPresupuesto()
    End Sub
    Private Sub frmbusquedanotacredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdbuscarPresupuesto.DataSource = objconexion.obtenerDatos().Tables("Presupuesto").DefaultView
    End Sub

    Private Sub txtbuscarpresupuesto_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscarpresupuesto.KeyUp
        Filtrardatospresupuesto(txtbuscarpresupuesto.Text)
        If e.KeyCode = 13 Then
            seleccionarPresupuesto()
        End If
    End Sub
    Private Sub seleccionarPresupuesto()
        _idC = grdbuscarPresupuesto.CurrentRow.Cells("idProducto").Value.ToString()
        Close()
    End Sub
    Private Sub Filtrardatospresupuesto(ByVal valor As String)
        Dim bs As New BindingSource
        bs.DataSource = grdbuscarPresupuesto.DataSource
        bs.Filter = "nombre like '%" & valor & "%'"
        grdbuscarPresupuesto.DataSource = bs
    End Sub

    Private Sub btnsCancelarPresupuesto_Click(sender As Object, e As EventArgs) Handles btnCancelarPresupuesto.Click
        _idC = 0
        Close()
    End Sub
End Class