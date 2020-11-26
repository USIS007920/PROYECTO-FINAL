Public Class Ventas
    Private Sub VentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_SistemaDataSet)

    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_SistemaDataSet.d_venta' Puede moverla o quitarla según sea necesario.
        Me.D_ventaTableAdapter.Filld_venta(Me.Db_SistemaDataSet.d_venta)
        'TODO: esta línea de código carga datos en la tabla 'Db_SistemaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.FillVentas(Me.Db_SistemaDataSet.Ventas)

    End Sub


End Class