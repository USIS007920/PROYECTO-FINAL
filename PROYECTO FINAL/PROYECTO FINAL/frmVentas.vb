Public Class frmVentas

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_SistemaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.FillVentas(Me.Db_SistemaDataSet.Ventas)
        actualizarDs()
        totalizar()
    End Sub

    Private Sub actualizarDs()
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet.dventasProductos' Puede moverla o quitarla según sea necesario.
        Me.D_ventaTableAdapter.Filld_venta(Me.Db_SistemaDataSet.d_venta)
        'TODO: esta línea de código carga datos en la tabla 'Db_sistemaDataSet.ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.FillVentas(Me.Db_SistemaDataSet.Ventas)
    End Sub

    Private Sub totalizar()
        Try
            Dim fila As DataGridViewRow
            Dim nfilas As Integer = D_ventaDataGridView.Rows.Count - 1
            Dim subtotal, sumas, iva, total As Double

            For i As Integer = 0 To nfilas
                fila = D_ventaDataGridView.Rows(i)
                subtotal = Double.Parse(fila.Cells("cantidad").Value.ToString()) * Double.Parse(fila.Cells("precio").Value.ToString())

                fila.Cells("subtotal").Value = subtotal.ToString()
                sumas += subtotal
            Next
            iva = If(IdTipofacturaComboBox.SelectedValue = 4, sumas * 0.13, 0)
            total = sumas + iva

            lblRespuestaSuma.Text = "$ " + Math.Round(sumas, 2).ToString()
            lblRespuestaIva.Text = "$ " + Math.Round(iva, 2).ToString()
            lblRespuestaTotal.Text = "$ " + Math.Round(total, 2).ToString()

            lblRespuestaIva.Text = (VentasBindingSource.Position + 1) & " de " & VentasBindingSource.Count
        Catch ex As Exception
            'MessageBox.Show("Error " + ex.Message)
        End Try
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        If btnModificar.Text = "Modificar" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"

            habdesh_controles(False)
        Else 'Cancelar
            D_ventaBindingSource.CancelEdit()
            VentasBindingSource.CancelEdit()

            habdesh_controles(True)
            btnAgregar.Text = "Nuevo"
            btnModificar.Text = "Modificar"
        End If
    End Sub
    Private Sub btnAgregarProducto_Click(sender As Object, e As EventArgs) Handles btnAgregarProducto.Click
        Dim objbusquedaproductos As New frmbusquedaproductos
        objbusquedaproductos.ShowDialog()
        If objbusquedaproductos._idP > 0 Then
            D_ventaBindingSource.AddNew()
            D_ventaDataGridView.CurrentRow.Cells("idProducto").Value = objbusquedaproductos._idP
            D_ventaDataGridView.CurrentRow.Cells("codigo").Value = objbusquedaproductos._codigoProducto
            D_ventaDataGridView.CurrentRow.Cells("descripcion").Value = objbusquedaproductos._nombreProducto
            D_ventaDataGridView.CurrentRow.Cells("marca").Value = ""
            D_ventaDataGridView.CurrentRow.Cells("medidas").Value = ""

            D_ventaDataGridView.CurrentRow.Cells("cantidad").Value = 1
            D_ventaDataGridView.CurrentRow.Cells("precio").Value = 0
        End If
    End Sub


    Private Sub btnPrimero_Click(sender As Object, e As EventArgs) Handles btnPrimero.Click
        VentasBindingSource.MoveFirst()
        totalizar()
    End Sub

    Private Sub btnAnterior_Click(sender As Object, e As EventArgs) Handles btnAnterior.Click
        VentasBindingSource.MovePrevious()
        totalizar()
    End Sub

    Private Sub btnSiguiente_Click(sender As Object, e As EventArgs) Handles btnSiguiente.Click
        VentasBindingSource.MoveNext()
        totalizar()
    End Sub

    Private Sub btn_Ultimo_Click(sender As Object, e As EventArgs) Handles btn_Ultimo.Click
        VentasBindingSource.MoveLast()
        totalizar()
    End Sub

    Private Sub habdesh_controles(ByVal valor As Boolean)
        Num_facturaTextBox.ReadOnly = valor
        IdClienteComboBox.Enabled = Not valor
        Fecha_ventaDateTimePicker.Enabled = Not valor
        IdTipofacturaComboBox.Enabled = Not valor
        IdPagoComboBox.Enabled = Not valor
        D_ventaDataGridView.ReadOnly = valor


        grbNavegacion.Visible = valor
        btnAgregarCliente.Visible = Not valor

        btnEliminar.Enabled = valor
        btnBuscar.Enabled = valor
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        If btnAgregar.Text = "Nuevo" Then
            btnAgregar.Text = "Guardar"
            btnModificar.Text = "Cancelar"

            habdesh_controles(False)
            VentasBindingSource.AddNew()

            IdClienteComboBox.SelectedValue = 1 'Cliente por default Ventas a Publico
            IdTipofacturaComboBox.SelectedValue = 3 'Tipo de factura por default consumidor final 
            IdPagoComboBox.SelectedValue = 1 'Tipo de Pago por default efectivo
            Fecha_ventaDateTimePicker.Value = Date.Now
        Else 'Guardar
            Try
                Dim idVenta As Object = Nothing
                Dim _idVenta = Integer.Parse(idVenta.Text)
                Me.Validate()
                VentasBindingSource.EndEdit()

                VentasTableAdapter.Connection.Open()
                Dim comand As New SqlClient.SqlCommand
                comand.Connection = VentasTableAdapter.Connection
                If _idVenta > 0 Then 'Modificanco
                    comand.CommandText = "delete from dventas where idVenta=" + _idVenta.ToString()
                    comand.ExecuteNonQuery()
                Else 'Agregando Nuevas Facturas
                    comand.CommandText = "SELECT ident_current('ventas') + 1 AS idVenta"
                    _idVenta = Integer.Parse(comand.ExecuteScalar().ToString())
                End If
                VentasTableAdapter.Connection.Close()

                Dim nfilas As Integer = D_ventaDataGridView.Rows.Count
                Dim valores(nfilas, 3) As String
                Dim fila As New DataGridViewRow

                For i = 0 To nfilas - 1
                    fila = D_ventaDataGridView.Rows(i)

                    valores(i, 0) = fila.Cells("idProducto").Value.ToString()
                    valores(i, 1) = fila.Cells("cantidad").Value.ToString()
                    valores(i, 2) = fila.Cells("precio").Value.ToString()
                Next
                TableAdapterManager.UpdateAll(Db_SistemaDataSet)

                For i = 0 To nfilas - 1
                    D_ventaTableAdapter.Insert(
                        _idVenta,
                        valores(i, 0),
                        valores(i, 1),
                        valores(i, 2)
                    )
                Next
                actualizarDs()
                VentasBindingSource.MoveLast()

                habdesh_controles(True)
                btnAgregar.Text = "Nuevo"
                btnModificar.Text = "Modificar"
            Catch ex As Exception
                MessageBox.Show("Error al intentar guardar: " + ex.Message,
                    "Registro de Facturas de Venta", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub DventasProductosDataGridView_KeyUp(sender As Object, e As KeyEventArgs) Handles D_ventaDataGridView.KeyUp
        Try
            totalizar()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub btnQuitarProducto_Click(sender As Object, e As EventArgs) Handles btnQuitarProducto.Click
        Try
            D_ventaDataGridView.Rows.Remove(D_ventaDataGridView.CurrentRow)
            totalizar()
        Catch ex As Exception
            MessageBox.Show("Error al intentar quitar la fila: " + ex.Message)
        End Try
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Dim objClientes As New frmClientes
        objClientes.Show()
    End Sub

End Class