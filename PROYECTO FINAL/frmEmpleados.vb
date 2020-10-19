Public Class frmEmpleados
    Dim objconexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objconexion.obtenerDatos().Tables("Empleados")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idEmpleados")}
        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString()
            txtNombreEmpleado.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtTelefonoEmpleado.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtDireccionEmpleado.Text = dataTable.Rows(posicion).ItemArray(3).ToString()
            txtEmailEmpleado.Text = dataTable.Rows(posicion).ItemArray(4).ToString()


            lblNum.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosProducto()
            MessageBox.Show("No hay registros que mostrar", "Registro de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimeroProducto_Click(sender As Object, e As EventArgs) Handles btnPrimeroEmpleado.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteEmpleado_Click(sender As Object, e As EventArgs) Handles btnSiguienteEmpleado.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorEmpleado_Click(sender As Object, e As EventArgs) Handles btnAnteriorEmpleado.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn_Ultimo_Empleado_Click(sender As Object, e As EventArgs) Handles btnUltimoEmpleado.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregrarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        If btnAgregarEmpleado.Text = "Nuevo" Then
            btnAgregarEmpleado.Text = "guardar"
            btnModificarEmpleado.Text = "Cancelar"
            accion = "nuevo"
            HabDescontroles(False)
            limpiarDatosProducto()
        Else
            HabDescontroles(True)
            btnAgregarEmpleado.Text = "nuevo"
            btnModificarEmpleado.Text = "Modificar"
        End If

    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarEmpleado.Enabled = estado
        btnBuscarEmpleado.Enabled = estado
    End Sub

    Private Sub limpiarDatosProducto()
        txtCodigoEmpleado.Text = ""
        txtCodigoEmpleado.Text = ""
        txtNombreEmpleado.Text = ""
        txtEmailEmpleado.Text = ""
        txtDireccionEmpleado.Text = ""
    End Sub
    Private Sub btnModificarEmpleado_Click(sender As Object, e As EventArgs) Handles btnModificarEmpleado.Click
        If btnModificarEmpleado.Text = "Modificar" Then
            btnAgregarEmpleado.Text = "Guardar"
            btnModificarEmpleado.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else
            obtenerDatos()
            HabDescontroles(True)
            btnAgregarEmpleado.Text = "Nuevo"
            btnModificarEmpleado.Text = "Modificar"

        End If
    End Sub

    Private Sub btnEliminarEmpleado_Click(sender As Object, e As EventArgs) Handles btnEliminarEmpleado.Click
        If (MessageBox.Show("Esta seguro de borrar a" + txtNombreEmpleado.Text, "Registro de Empleado",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            If posicion > 0 Then
                posicion -= 1
            End If
            obtenerDatos()
        End If

    End Sub

    Private Sub btnBuscarEmpleado_Click(sender As Object, e As EventArgs) Handles btnBuscarEmpleado.Click
        Dim objbuscarproducto As New frmbusquedaproductos
        objbuscarproducto.ShowDialog()
    End Sub

End Class