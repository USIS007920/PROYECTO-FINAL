Public Class Productos
    Dim objconexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objconexion.obtenerDatos().Tables("Productos")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProducto")}
        mostrarDatos()
    End Sub


    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtCategoriaProducto.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtCodigoProducto.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtNombreProducto.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtMarcaProducto.Text = dataTable.Rows(posicion).ItemArray(4).ToString()
            txtDimensionesProducto.Text = dataTable.Rows(posicion).ItemArray(5).ToString()

            lblNum.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosProducto()
            MessageBox.Show("No hay registros que mostrar", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimeroProducto_Click(sender As Object, e As EventArgs) Handles btnPrimeroProducto.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteProducto_Click(sender As Object, e As EventArgs) Handles btnSiguienteProducto.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorProducto_Click(sender As Object, e As EventArgs) Handles btnAnteriorProducto.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Productos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn_Ultimo_Producto_Click(sender As Object, e As EventArgs) Handles btn_Ultimo_Producto.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregrarProduto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        If btnAgregarProducto.Text = "Nuevo" Then
            btnAgregarProducto.Text = "guardar"
            btnModificarProducto.Text = "Cancelar"
            accion = "nuevo"
            HabDescontroles(False)
            limpiarDatosProducto()
        Else
            HabDescontroles(True)
            btnAgregarProducto.Text = "nuevo"
            btnModificarProducto.Text = "Modificar"
        End If

    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarProducto.Enabled = estado
        btnBuscarProducto.Enabled = estado
    End Sub

    Private Sub limpiarDatosProducto()
        txtCategoriaProducto.Text = ""
        txtCodigoProducto.Text = ""
        txtNombreProducto.Text = ""
        txtMarcaProducto.Text = ""
        txtDimensionesProducto.Text = ""
    End Sub
    Private Sub btnModificarProducto_Click(sender As Object, e As EventArgs) Handles btnModificarProducto.Click
        If btnModificarProducto.Text = "Modificar" Then
            btnAgregarProducto.Text = "Guardar"
            btnModificarProducto.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else
            obtenerDatos()
            HabDescontroles(True)
            btnAgregarProducto.Text = "Nuevo"
            btnModificarProducto.Text = "Modificar"

        End If
    End Sub

    Private Sub btnEliminarProducto_Click(sender As Object, e As EventArgs) Handles btnEliminarProducto.Click
        If (MessageBox.Show("Esta seguro de borrar a" + txtNombreProducto.Text, "Registro de producto",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            If posicion > 0 Then
                posicion -= 1
            End If
            obtenerDatos()
        End If

    End Sub

    Private Sub btnBuscarProducto_Click(sender As Object, e As EventArgs) Handles btnBuscarProducto.Click
        Dim objbuscarproducto As New frmbusquedaproductos
        objbuscarproducto.ShowDialog()
    End Sub



End Class