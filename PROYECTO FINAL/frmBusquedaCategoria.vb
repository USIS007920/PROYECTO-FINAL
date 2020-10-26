Public Class frmBusquedaCategoria
    Dim objConexion As New db_conexion
    Public _idC As Integer
    Private Sub frmBusquedaCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdBuscarCategoria.DataSource = objConexion.obtenerDatos().Tables("Categoria").DefaultView
    End Sub

    Private Sub filtrarDatosCategoria(ByVal valor As String)
        Dim bs As New BindingSource()
        bs.DataSource = grdBuscarCategoria.DataSource
        bs.Filter = "categoria like '%" + valor + "%'"
        grdBuscarCategoria.DataSource = bs
    End Sub

    Private Sub seleccionarCategoria()
        _idC = grdBuscarCategoria.CurrentRow.Cells("idCategoria").Value.ToString()
        Close()
    End Sub

    Private Sub txtBuscarCategoria_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBuscarCategoria.KeyUp
        filtrarDatosCategoria(txtBuscarCategoria.Text)
        If e.KeyCode = 13 Then
            seleccionarCategoria()
        End If
    End Sub

    Private Sub btn_Selec_Cat_Click(sender As Object, e As EventArgs) Handles btnSeleccionarCategoria.Click
        seleccionarCategoria()
    End Sub

End Class