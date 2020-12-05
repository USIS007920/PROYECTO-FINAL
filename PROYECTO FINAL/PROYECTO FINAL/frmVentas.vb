Public Class frmVentas
    Private Sub VentasBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VentasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VentasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Db_SistemaDataSet)

    End Sub

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Db_SistemaDataSet.Ventas' Puede moverla o quitarla según sea necesario.
        Me.VentasTableAdapter.FillVentas(Me.Db_SistemaDataSet.Ventas)

    End Sub



    Private Sub IdTipofacturaComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IdTipofacturaComboBox.SelectedIndexChanged

    End Sub
End Class