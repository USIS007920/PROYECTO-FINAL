Public Class frmBuscarProvedores
    Dim objconexion As New db_conexion
    Public _idC As Integer

    Private Sub btnSeleccionarProvedores_Click(sender As Object, e As EventArgs) Handles btnCancelarProvedor.Click
        seleccionarProvedores()
    End Sub

    Private Sub frmBuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarProvedores.DataSource = objconexion.obtenerDatos().Tables("Provedores").DefaultView
    End Sub

    Private Sub txtBuscarCliente_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscarProvedores.KeyUp
        filtrarDatosProvedores(txtbuscarProvedores.Text)
        If e.KeyCode = 13 Then
            seleccionarProvedores()
        End If
    End Sub
    Private Sub seleccionarProvedores()
        _idC = grdBuscarProvedores.CurrentRow.Cells("idProvedores").Value.ToString()
        Close()
    End Sub
    Private Sub filtrarDatosProvedores(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarProvedores.DataSource
        bs.Filter = "codigo like '%" & valor & "%' or  nombre like '%" & valor & "%'"
        grdBuscarProvedores.DataSource = bs
    End Sub

    Private Sub btnCancelarProvedores_Click(sender As Object, e As EventArgs) Handles btnCancelarProvedor.Click
        _idC = 0
        Close()
    End Sub
End Class