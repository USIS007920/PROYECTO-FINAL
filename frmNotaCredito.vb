Public Class frmNotaCredito
    Dim objconexion As New db_conexion()
    Dim datatable As New DataTable
    Dim posicion As Integer
    Dim accion As String = "nuevo"


    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicion = 0
        obtenerDatos()
    End Sub

    Sub obtenerDatos()
        datatable = objconexion.obtenerDatos().Tables("Empleados")
        datatable.PrimaryKey = New DataColumn() {datatable.Columns("idEmpleado")}
        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        If datatable.Rows.Count > 0 Then
            Me.Tag = datatable.Rows(posicion).ItemArray(0).ToString() 'id nota credito
            txtDatosNotaCredito.Text = datatable.Rows(posicion).ItemArray(1).ToString()
            txtFechaNotaCredito.Text = datatable.Rows(posicion).ItemArray(2).ToString()
            txtDescripcionNotaCredito.Text = datatable.Rows(posicion).ItemArray(3).ToString()
            txtImpuestosNotaCredito.Text = datatable.Rows(posicion).ItemArray(4).ToString()
            txtMontoTotalNotaCredito.Text = datatable.Rows(posicion).ItemArray(5).ToString()
            lblFechaNotacredito.Text = posicion + 1 & " de " & datatable.Rows.Count
        Else
            limpiarDatosNotaCredito()
            MessageBox.Show("No hay registros que mostrar", "Registro de Nota Creditio", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimeraNotaCredito_Click(sender As Object, e As EventArgs) Handles btnPrimeraNotaCredito.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteNotaCredito_Click(sender As Object, e As EventArgs) Handles btnSiguienteNotaCredito.Click
        If posicion < datatable.Rows.Count - 1 Then
            posicion += 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el ultimo registro.", "Registro de Nota Credito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnAnteriorNotaCredito_Click(sender As Object, e As EventArgs) Handles btnAnteriorNotaCrdito.Click
        If posicion > 0 Then
            posicion -= 1
            mostrarDatos()
        Else
            MessageBox.Show("Ya te encuentras en el primer registro.", "Registro de Nota Credito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub btn_Ultima_NotaCredito_Click(sender As Object, e As EventArgs) Handles btnUltimaNotaCredito.Click
        posicion = datatable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregrarNotaCredito_Click(sender As Object, e As EventArgs) Handles btnAgregarNotaCredito.Click
        If btnAgregarNotaCredito.Text = "Nuevo" Then
            btnAgregarNotaCredito.Text = "guardar"
            btnModificarNotaCredito.Text = "Cancelar"
            accion = "nuevo"
            HabDescontroles(False)
            limpiarDatosNotaCredito()
        Else
            HabDescontroles(True)
            btnAgregarNotaCredito.Text = "nuevo"
            btnModificarNotaCredito.Text = "Modificar"
        End If

    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarNotaCredito.Enabled = estado
        btnBuscarNotaCredito.Enabled = estado
    End Sub

    Private Sub limpiarDatosNotaCredito()
        txtDatosNotaCredito.Text = ""
        txtFechaNotaCredito.Text = ""
        txtDescripcionNotaCredito.Text = ""
        txtImpuestosNotaCredito.Text = ""
        txtMontoTotalNotaCredito.Text = ""
    End Sub
    Private Sub btnModificarNotaCredito_Click(sender As Object, e As EventArgs) Handles btnModificarNotaCredito.Click
        If btnModificarNotaCredito.Text = "Modificar" Then
            btnAgregarNotaCredito.Text = "Guardar"
            btnModificarNotaCredito.Text = "Cancelar"
            accion = "modificar"
            HabDescontroles(False)
        Else
            obtenerDatos()
            HabDescontroles(True)
            btnAgregarNotaCredito.Text = "Nuevo"
            btnModificarNotaCredito.Text = "Modificar"

        End If
    End Sub

    Private Sub btnEliminarNotaCredito_Click(sender As Object, e As EventArgs) Handles btnEliminarNotaCredito.Click
        If (MessageBox.Show("Esta seguro de borrar a" + txtDatosNotaCredito.Text, "Registro de Nota Credito",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            If posicion > 0 Then
                posicion -= 1
            End If
            obtenerDatos()
        End If

    End Sub

    Private Sub btnBuscarNotaCredito_Click(sender As Object, e As EventArgs) Handles btnBuscarNotaCredito.Click
        Dim objbuscarnotacredito As New frmBusquedaNotaCredito
        objbuscarnotacredito.ShowDialog()
    End Sub
End Class