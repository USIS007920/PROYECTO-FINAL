<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Num_facturaLabel As System.Windows.Forms.Label
        Dim Fecha_ventaLabel As System.Windows.Forms.Label
        Dim IdTipofacturaLabel As System.Windows.Forms.Label
        Dim IdPagoLabel As System.Windows.Forms.Label
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.Db_SistemaDataSet = New PROYECTO_FINAL.Db_SistemaDataSet()
        Me.VentasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VentasTableAdapter = New PROYECTO_FINAL.Db_SistemaDataSetTableAdapters.VentasTableAdapter()
        Me.TableAdapterManager = New PROYECTO_FINAL.Db_SistemaDataSetTableAdapters.TableAdapterManager()
        Me.VentasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.VentasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Num_facturaTextBox = New System.Windows.Forms.TextBox()
        Me.Fecha_ventaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdTipofacturaTextBox = New System.Windows.Forms.TextBox()
        Me.IdPagoTextBox = New System.Windows.Forms.TextBox()
        Me.IdClienteTextBox = New System.Windows.Forms.TextBox()
        Me.D_ventaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.D_ventaTableAdapter = New PROYECTO_FINAL.Db_SistemaDataSetTableAdapters.d_ventaTableAdapter()
        Me.D_ventaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Num_facturaLabel = New System.Windows.Forms.Label()
        Fecha_ventaLabel = New System.Windows.Forms.Label()
        IdTipofacturaLabel = New System.Windows.Forms.Label()
        IdPagoLabel = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        CType(Me.Db_SistemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VentasBindingNavigator.SuspendLayout()
        CType(Me.D_ventaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.D_ventaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Num_facturaLabel
        '
        Num_facturaLabel.AutoSize = True
        Num_facturaLabel.Location = New System.Drawing.Point(551, 56)
        Num_facturaLabel.Name = "Num_facturaLabel"
        Num_facturaLabel.Size = New System.Drawing.Size(66, 13)
        Num_facturaLabel.TabIndex = 3
        Num_facturaLabel.Text = "num factura:"
        '
        'Fecha_ventaLabel
        '
        Fecha_ventaLabel.AutoSize = True
        Fecha_ventaLabel.Location = New System.Drawing.Point(12, 92)
        Fecha_ventaLabel.Name = "Fecha_ventaLabel"
        Fecha_ventaLabel.Size = New System.Drawing.Size(67, 13)
        Fecha_ventaLabel.TabIndex = 5
        Fecha_ventaLabel.Text = "fecha venta:"
        '
        'IdTipofacturaLabel
        '
        IdTipofacturaLabel.AutoSize = True
        IdTipofacturaLabel.Location = New System.Drawing.Point(299, 92)
        IdTipofacturaLabel.Name = "IdTipofacturaLabel"
        IdTipofacturaLabel.Size = New System.Drawing.Size(64, 13)
        IdTipofacturaLabel.TabIndex = 9
        IdTipofacturaLabel.Text = "Tipofactura:"
        '
        'IdPagoLabel
        '
        IdPagoLabel.AutoSize = True
        IdPagoLabel.Location = New System.Drawing.Point(496, 92)
        IdPagoLabel.Name = "IdPagoLabel"
        IdPagoLabel.Size = New System.Drawing.Size(59, 13)
        IdPagoLabel.TabIndex = 11
        IdPagoLabel.Text = "Tipo Pago:"
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(12, 59)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(42, 13)
        IdClienteLabel.TabIndex = 13
        IdClienteLabel.Text = "Cliente:"
        '
        'Db_SistemaDataSet
        '
        Me.Db_SistemaDataSet.DataSetName = "Db_SistemaDataSet"
        Me.Db_SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentasBindingSource
        '
        Me.VentasBindingSource.DataMember = "Ventas"
        Me.VentasBindingSource.DataSource = Me.Db_SistemaDataSet
        '
        'VentasTableAdapter
        '
        Me.VentasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClienteTableAdapter = Nothing
        Me.TableAdapterManager.d_ventaTableAdapter = Nothing
        Me.TableAdapterManager.pagoTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProvedoresTableAdapter = Nothing
        Me.TableAdapterManager.tipofacturaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PROYECTO_FINAL.Db_SistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VentasTableAdapter = Me.VentasTableAdapter
        '
        'VentasBindingNavigator
        '
        Me.VentasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VentasBindingNavigator.BindingSource = Me.VentasBindingSource
        Me.VentasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VentasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VentasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VentasBindingNavigatorSaveItem})
        Me.VentasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VentasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VentasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VentasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VentasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VentasBindingNavigator.Name = "VentasBindingNavigator"
        Me.VentasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VentasBindingNavigator.Size = New System.Drawing.Size(952, 25)
        Me.VentasBindingNavigator.TabIndex = 0
        Me.VentasBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'VentasBindingNavigatorSaveItem
        '
        Me.VentasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VentasBindingNavigatorSaveItem.Image = CType(resources.GetObject("VentasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VentasBindingNavigatorSaveItem.Name = "VentasBindingNavigatorSaveItem"
        Me.VentasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VentasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'Num_facturaTextBox
        '
        Me.Num_facturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "num_factura", True))
        Me.Num_facturaTextBox.Location = New System.Drawing.Point(623, 53)
        Me.Num_facturaTextBox.Name = "Num_facturaTextBox"
        Me.Num_facturaTextBox.Size = New System.Drawing.Size(149, 20)
        Me.Num_facturaTextBox.TabIndex = 4
        '
        'Fecha_ventaDateTimePicker
        '
        Me.Fecha_ventaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VentasBindingSource, "fecha_venta", True))
        Me.Fecha_ventaDateTimePicker.Location = New System.Drawing.Point(93, 88)
        Me.Fecha_ventaDateTimePicker.Name = "Fecha_ventaDateTimePicker"
        Me.Fecha_ventaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Fecha_ventaDateTimePicker.TabIndex = 6
        '
        'IdTipofacturaTextBox
        '
        Me.IdTipofacturaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "idTipofactura", True))
        Me.IdTipofacturaTextBox.Location = New System.Drawing.Point(369, 89)
        Me.IdTipofacturaTextBox.Name = "IdTipofacturaTextBox"
        Me.IdTipofacturaTextBox.Size = New System.Drawing.Size(121, 20)
        Me.IdTipofacturaTextBox.TabIndex = 10
        '
        'IdPagoTextBox
        '
        Me.IdPagoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "idPago", True))
        Me.IdPagoTextBox.Location = New System.Drawing.Point(554, 89)
        Me.IdPagoTextBox.Name = "IdPagoTextBox"
        Me.IdPagoTextBox.Size = New System.Drawing.Size(133, 20)
        Me.IdPagoTextBox.TabIndex = 12
        '
        'IdClienteTextBox
        '
        Me.IdClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VentasBindingSource, "idCliente", True))
        Me.IdClienteTextBox.Location = New System.Drawing.Point(93, 56)
        Me.IdClienteTextBox.Name = "IdClienteTextBox"
        Me.IdClienteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdClienteTextBox.TabIndex = 14
        '
        'D_ventaBindingSource
        '
        Me.D_ventaBindingSource.DataMember = "d_venta"
        Me.D_ventaBindingSource.DataSource = Me.Db_SistemaDataSet
        '
        'D_ventaTableAdapter
        '
        Me.D_ventaTableAdapter.ClearBeforeFill = True
        '
        'D_ventaDataGridView
        '
        Me.D_ventaDataGridView.AllowUserToAddRows = False
        Me.D_ventaDataGridView.AllowUserToDeleteRows = False
        Me.D_ventaDataGridView.AutoGenerateColumns = False
        Me.D_ventaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.D_ventaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.codigo, Me.descripcion, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.subtotal})
        Me.D_ventaDataGridView.DataSource = Me.D_ventaBindingSource
        Me.D_ventaDataGridView.Location = New System.Drawing.Point(15, 123)
        Me.D_ventaDataGridView.Name = "D_ventaDataGridView"
        Me.D_ventaDataGridView.ReadOnly = True
        Me.D_ventaDataGridView.Size = New System.Drawing.Size(540, 261)
        Me.D_ventaDataGridView.TabIndex = 14
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idDetalle"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idDetalle"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "idventa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "idventa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "idproducto"
        Me.DataGridViewTextBoxColumn3.HeaderText = "idproducto"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'codigo
        '
        Me.codigo.DataPropertyName = "idDetalle"
        Me.codigo.HeaderText = "CODIGO"
        Me.codigo.Name = "codigo"
        Me.codigo.ReadOnly = True
        '
        'descripcion
        '
        Me.descripcion.DataPropertyName = "idDetalle"
        Me.descripcion.HeaderText = "DESCRIPCION"
        Me.descripcion.Name = "descripcion"
        Me.descripcion.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cantidad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "cantidad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "precio"
        Me.DataGridViewTextBoxColumn5.HeaderText = "precio"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'subtotal
        '
        Me.subtotal.DataPropertyName = "idDetalle"
        Me.subtotal.HeaderText = "SUBTOTAL"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.ReadOnly = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 463)
        Me.Controls.Add(Me.D_ventaDataGridView)
        Me.Controls.Add(Num_facturaLabel)
        Me.Controls.Add(Me.Num_facturaTextBox)
        Me.Controls.Add(Fecha_ventaLabel)
        Me.Controls.Add(Me.Fecha_ventaDateTimePicker)
        Me.Controls.Add(IdTipofacturaLabel)
        Me.Controls.Add(Me.IdTipofacturaTextBox)
        Me.Controls.Add(IdPagoLabel)
        Me.Controls.Add(Me.IdPagoTextBox)
        Me.Controls.Add(IdClienteLabel)
        Me.Controls.Add(Me.IdClienteTextBox)
        Me.Controls.Add(Me.VentasBindingNavigator)
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.Db_SistemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VentasBindingNavigator.ResumeLayout(False)
        Me.VentasBindingNavigator.PerformLayout()
        CType(Me.D_ventaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.D_ventaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Db_SistemaDataSet As Db_SistemaDataSet
    Friend WithEvents VentasBindingSource As BindingSource
    Friend WithEvents VentasTableAdapter As Db_SistemaDataSetTableAdapters.VentasTableAdapter
    Friend WithEvents TableAdapterManager As Db_SistemaDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VentasBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents VentasBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Num_facturaTextBox As TextBox
    Friend WithEvents Fecha_ventaDateTimePicker As DateTimePicker
    Friend WithEvents IdTipofacturaTextBox As TextBox
    Friend WithEvents IdPagoTextBox As TextBox
    Friend WithEvents IdClienteTextBox As TextBox
    Friend WithEvents D_ventaBindingSource As BindingSource
    Friend WithEvents D_ventaTableAdapter As Db_SistemaDataSetTableAdapters.d_ventaTableAdapter
    Friend WithEvents D_ventaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents codigo As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents subtotal As DataGridViewTextBoxColumn
End Class
