﻿Public Class frmEmpleados
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
        datatable.PrimaryKey = New DataColumn() {datatable.Columns("idempleado")}
        mostrarDatos()
    End Sub

    Sub mostrarDatos()
        If datatable.Rows.Count > 0 Then
            Me.Tag = datatable.Rows(posicion).ItemArray(0).ToString() 'id empleado
            txtcodigoempleado.Text = datatable.Rows(posicion).ItemArray(1).ToString()
            txtNombreEmpleado.Text = datatable.Rows(posicion).ItemArray(2).ToString()
            txtnumeroempleado.Text = datatable.Rows(posicion).ItemArray(3).ToString()
            txtdireccionempleado.Text = datatable.Rows(posicion).ItemArray(4).ToString()
            txtEmailEmpleado.Text = datatable.Rows(posicion).ItemArray(4).ToString()

            lblNombreEmpleado.Text = posicion + 1 & " de " & datatable.Rows.Count
        Else
            limpiarDatosEmpleados()
            MessageBox.Show("No hay registros que mostrar", "Registro de Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnPrimeroEmpleado_Click(sender As Object, e As EventArgs) Handles btnPrimeroEmpleado.Click
        posicion = 0
        mostrarDatos()
    End Sub

    Private Sub btnSiguienteEmpleado_Click(sender As Object, e As EventArgs) Handles btnSiguienteEmpleado.Click
        If posicion < DataTable.Rows.Count - 1 Then
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
        posicion = DataTable.Rows.Count - 1
        mostrarDatos()
    End Sub

    Private Sub btnAgregrarEmpleado_Click(sender As Object, e As EventArgs) Handles btnAgregarEmpleado.Click
        If btnAgregarEmpleado.Text = "Nuevo" Then 'Nuevo
            btnAgregarEmpleado.Text = "Guardar"
            btnModificarEmpleado.Text = "Cancelar"
            accion = "nuevo"

            HabDescontroles(False)
            limpiarDatosEmpleados()
        Else 'Guardar
            Dim msg = objconexion.mantenimientoDatosEmpleados(New String() {
                Me.Tag, txtEmailEmpleado.Text, txtNombreEmpleado.Text, txtdireccionempleado.Text, txtnumeroempleado.Text, txtEmailEmpleado.Text
            }, accion)
            If msg = "error" Then
                MessageBox.Show("Error al intentar guardar el registro, por favor intente nuevamente.", "Registro de Empleados",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                obtenerDatos()
                HabDescontroles(True)
                btnAgregarEmpleado.Text = "Nuevo"
                btnModificarEmpleado.Text = "Modificar"
            End If
        End If


    End Sub

    Private Sub HabDescontroles(ByVal estado As Boolean)
        grbDatos.Enabled = Not estado
        grbNavegacion.Enabled = estado
        btnEliminarEmpleado.Enabled = estado
        btnBuscarEmpleado.Enabled = estado
    End Sub

    Private Sub limpiarDatosEmpleados()
        txtcodigoempleado.Text = ""
        txtNombreEmpleado.Text = ""
        txtnumeroempleado.Text = ""
        txtdireccionempleado.Text = ""
        txtEmailEmpleado.Text = ""
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
        Dim objbuscarempleados As New frmbusquedaempleados
        objbuscarempleados.ShowDialog()
    End Sub


End Class