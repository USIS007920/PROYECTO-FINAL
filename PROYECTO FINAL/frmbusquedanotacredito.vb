Public Class frmbusquedanotacredito
    Dim objconexion As New db_conexion
    Public _idC As Integer

    Private Sub btnSeleccionarnotacredito_Click(sender As Object, e As EventArgs) Handles btnseleccionarnotacredito.Click
        seleccionarnotacredito()
    End Sub
    Private Sub frmbusquedanotacredito_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdbuscarnotacredito.DataSource = objconexion.obtenerDatos().Tables("NotaCredito").DefaultView
    End Sub

    Private Sub txtbuscarproductos_KeyUp(sender As Object, e As KeyEventArgs) Handles txtbuscarnotacredito.KeyUp
        Filtrardatosnotacredito(txtbuscarnotacredito.Text)
        If e.KeyCode = 13 Then
            seleccionarnotacredito()
        End If
    End Sub
    Private Sub seleccionarnotacredito()
        _idC = grdbuscarnotacredito.CurrentRow.Cells("idNotaCredito").Value.ToString()
        Close()
    End Sub
    Private Sub Filtrardatosnotacredito(ByVal valor As String)
        Dim bs As New BindingSource
        bs.DataSource = grdbuscarnotacredito.DataSource
        bs.Filter = "nombre like '%" & valor & "%'"
        grdbuscarnotacredito.DataSource = bs
    End Sub

    Private Sub btnsCancelarnotacredito_Click(sender As Object, e As EventArgs) Handles btnCancelarnotacredito.Click
        _idC = 0
        Close()
    End Sub
End Class