Public Class frmProvedores

    Dim objconexion As New db_conexion()
    Dim dataTable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"

    Private Sub frmClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub
    Sub obtenerDatos()
        dataTable = objconexion.obtenerDatos().Tables("Provedores")
        dataTable.PrimaryKey = New DataColumn() {dataTable.Columns("idProvedores")}
        mostrarDatos()
    End Sub
    Sub mostrarDatos()
        If dataTable.Rows.Count > 0 Then
            Me.Tag = dataTable.Rows(posicion).ItemArray(0).ToString() 'ID de Cliente
            txtCodigoProvedor.Text = dataTable.Rows(posicion).ItemArray(1).ToString()
            txtNombreProvedor.Text = dataTable.Rows(posicion).ItemArray(2).ToString()
            txtDireccionProvedor.Text = dataTable.Rows(posicion).ItemArray(3).ToString()


            lblCodigo.Text = posicion + 1 & " de " & dataTable.Rows.Count
        Else
            limpiarDatosProvedor()
            MessageBox.Show("No hay registros que mostrar", "Registro de Provedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimeroProvedor_Click(sender As Object, e As EventArgs) Handles btnPrimeroProvedor.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteProvedor_Click(sender As Object, e As EventArgs) Handles btnSiguienteProvedor.Click
        If posicion < dataTable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Provedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnAnteriorProvedor_Click(sender As Object, e As EventArgs) Handles btnAnteriorProvedor.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Provedores", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btnUltimoProvedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProvedor.Click
        posicion = dataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregrarProvedor_Click(sender As Object, e As EventArgs) Handles btnAgregarProvedor.Click
        If btnAgregarProvedor.Text = "Nuevo" Then
            btnAgregarProvedor.Text = "guardar"
            btnModificarProvedor.Text = "Cancelar"
            accion = "nuevo"
            HabDescontroles(False)
            limpiarDatosProvedor()
        Else
            HabDescontroles(True)
            btnAgregarProvedor.Text = "nuevo"
            btnModificarProvedor.Text = "Modificar"
        End If
    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarProvedor.Enabled = estado
        btnBuscarProvedor.Enabled = estado
    End Sub
    Private Sub limpiarDatosProvedor()
        txtCodigoProvedor.Text = ""
        txtNombreProvedor.Text = ""
        txtDireccionProvedor.Text = ""
    End Sub

    Private Sub btnModificarProvedor_Click(sender As Object, e As EventArgs) Handles btnModificarProvedor.Click
        If btnModificarProvedor.Text = "Modificar" Then 'Modificar
            btnAgregarProvedor.Text = "Guardar"
            btnModificarProvedor.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else 'Cancelar
            obtenerDatos()

            HabDescontroles(True)
            btnAgregarProvedor.Text = "Nuevo"
            btnModificarProvedor.Text = "Modificar"
        End If
    End Sub

    Private Sub btnEliminarProvedor_Click(sender As Object, e As EventArgs) Handles btnEliminarProvedor.Click
        If (MessageBox.Show("Esta seguro de borrar a" + txtNombreProvedor.Text, "Registro de provedores",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            If posicion > 0 Then
                posicion -= 1
            End If
            obtenerDatos()
        End If
    End Sub

    Private Sub btnBuscarProvedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProvedor.Click
        Dim objbuscarProvedor As New frmBuscarProvedores
        objbuscarProvedor.ShowDialog()
    End Sub


End Class