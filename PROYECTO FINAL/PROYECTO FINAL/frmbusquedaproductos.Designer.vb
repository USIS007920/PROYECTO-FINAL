<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbusquedaproductos
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
        Me.grdbuscarproducto = New System.Windows.Forms.DataGridView()
        Me.IdcategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DimensionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_SistemaDataSet1 = New PROYECTO_FINAL.Db_SistemaDataSet1()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Db_SistemaDataSet = New PROYECTO_FINAL.Db_SistemaDataSet()
        Me.lblbuscarproducto = New System.Windows.Forms.Label()
        Me.txtbuscarproductos = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarProducto = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ProductosTableAdapter = New PROYECTO_FINAL.Db_SistemaDataSetTableAdapters.ProductosTableAdapter()
        Me.ProductosTableAdapter1 = New PROYECTO_FINAL.Db_SistemaDataSet1TableAdapters.ProductosTableAdapter()
        CType(Me.grdbuscarproducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_SistemaDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Db_SistemaDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdbuscarproducto
        '
        Me.grdbuscarproducto.AllowUserToAddRows = False
        Me.grdbuscarproducto.AllowUserToDeleteRows = False
        Me.grdbuscarproducto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdbuscarproducto.AutoGenerateColumns = False
        Me.grdbuscarproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdbuscarproducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdcategoriaDataGridViewTextBoxColumn, Me.CodigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.DimensionesDataGridViewTextBoxColumn})
        Me.grdbuscarproducto.DataSource = Me.ProductosBindingSource1
        Me.grdbuscarproducto.Location = New System.Drawing.Point(12, 32)
        Me.grdbuscarproducto.Name = "grdbuscarproducto"
        Me.grdbuscarproducto.ReadOnly = True
        Me.grdbuscarproducto.Size = New System.Drawing.Size(776, 290)
        Me.grdbuscarproducto.TabIndex = 0
        '
        'IdcategoriaDataGridViewTextBoxColumn
        '
        Me.IdcategoriaDataGridViewTextBoxColumn.DataPropertyName = "idcategoria"
        Me.IdcategoriaDataGridViewTextBoxColumn.HeaderText = "idcategoria"
        Me.IdcategoriaDataGridViewTextBoxColumn.Name = "IdcategoriaDataGridViewTextBoxColumn"
        Me.IdcategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CodigoDataGridViewTextBoxColumn
        '
        Me.CodigoDataGridViewTextBoxColumn.DataPropertyName = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.HeaderText = "codigo"
        Me.CodigoDataGridViewTextBoxColumn.Name = "CodigoDataGridViewTextBoxColumn"
        Me.CodigoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DimensionesDataGridViewTextBoxColumn
        '
        Me.DimensionesDataGridViewTextBoxColumn.DataPropertyName = "dimensiones"
        Me.DimensionesDataGridViewTextBoxColumn.HeaderText = "dimensiones"
        Me.DimensionesDataGridViewTextBoxColumn.Name = "DimensionesDataGridViewTextBoxColumn"
        Me.DimensionesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProductosBindingSource1
        '
        Me.ProductosBindingSource1.DataMember = "Productos"
        Me.ProductosBindingSource1.DataSource = Me.Db_SistemaDataSet1
        '
        'Db_SistemaDataSet1
        '
        Me.Db_SistemaDataSet1.DataSetName = "Db_SistemaDataSet1"
        Me.Db_SistemaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.Db_SistemaDataSet
        '
        'Db_SistemaDataSet
        '
        Me.Db_SistemaDataSet.DataSetName = "Db_SistemaDataSet"
        Me.Db_SistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblbuscarproducto
        '
        Me.lblbuscarproducto.AutoSize = True
        Me.lblbuscarproducto.Location = New System.Drawing.Point(12, 13)
        Me.lblbuscarproducto.Name = "lblbuscarproducto"
        Me.lblbuscarproducto.Size = New System.Drawing.Size(54, 13)
        Me.lblbuscarproducto.TabIndex = 1
        Me.lblbuscarproducto.Text = "BUSCAR:"
        '
        'txtbuscarproductos
        '
        Me.txtbuscarproductos.Location = New System.Drawing.Point(72, 6)
        Me.txtbuscarproductos.Name = "txtbuscarproductos"
        Me.txtbuscarproductos.Size = New System.Drawing.Size(716, 20)
        Me.txtbuscarproductos.TabIndex = 2
        '
        'btnSeleccionarProducto
        '
        Me.btnSeleccionarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarProducto.Location = New System.Drawing.Point(505, 328)
        Me.btnSeleccionarProducto.Name = "btnSeleccionarProducto"
        Me.btnSeleccionarProducto.Size = New System.Drawing.Size(133, 30)
        Me.btnSeleccionarProducto.TabIndex = 3
        Me.btnSeleccionarProducto.Text = "Seleccionar Producto"
        Me.btnSeleccionarProducto.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(655, 328)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 30)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter1
        '
        Me.ProductosTableAdapter1.ClearBeforeFill = True
        '
        'frmbusquedaproductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSeleccionarProducto)
        Me.Controls.Add(Me.txtbuscarproductos)
        Me.Controls.Add(Me.lblbuscarproducto)
        Me.Controls.Add(Me.grdbuscarproducto)
        Me.Name = "frmbusquedaproductos"
        Me.Text = "busquedaproductos"
        CType(Me.grdbuscarproducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_SistemaDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Db_SistemaDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdbuscarproducto As DataGridView
    Friend WithEvents lblbuscarproducto As Label
    Friend WithEvents txtbuscarproductos As TextBox
    Friend WithEvents btnSeleccionarProducto As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Db_SistemaDataSet As Db_SistemaDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As Db_SistemaDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents Db_SistemaDataSet1 As Db_SistemaDataSet1
    Friend WithEvents ProductosBindingSource1 As BindingSource
    Friend WithEvents ProductosTableAdapter1 As Db_SistemaDataSet1TableAdapters.ProductosTableAdapter
    Friend WithEvents IdcategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DimensionesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
