<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtCategoriaProducto = New System.Windows.Forms.ComboBox()
        Me.txtDimensionesProducto = New System.Windows.Forms.TextBox()
        Me.lblDimensiones = New System.Windows.Forms.Label()
        Me.txtMarcaProducto = New System.Windows.Forms.TextBox()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCodigoProducto = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.btn_Ultimo_Producto = New System.Windows.Forms.Button()
        Me.btnSiguienteProducto = New System.Windows.Forms.Button()
        Me.btnAnteriorProducto = New System.Windows.Forms.Button()
        Me.btnPrimeroProducto = New System.Windows.Forms.Button()
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarProducto = New System.Windows.Forms.Button()
        Me.btnEliminarProducto = New System.Windows.Forms.Button()
        Me.btnModificarProducto = New System.Windows.Forms.Button()
        Me.btnAgregarProducto = New System.Windows.Forms.Button()
        Me.grbDatos.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbEdicion.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtCategoriaProducto)
        Me.grbDatos.Controls.Add(Me.txtDimensionesProducto)
        Me.grbDatos.Controls.Add(Me.lblDimensiones)
        Me.grbDatos.Controls.Add(Me.txtMarcaProducto)
        Me.grbDatos.Controls.Add(Me.lblMarca)
        Me.grbDatos.Controls.Add(Me.txtNombreProducto)
        Me.grbDatos.Controls.Add(Me.lblNombre)
        Me.grbDatos.Controls.Add(Me.txtCodigoProducto)
        Me.grbDatos.Controls.Add(Me.lblCodigo)
        Me.grbDatos.Controls.Add(Me.lblCategoria)
        Me.grbDatos.Location = New System.Drawing.Point(27, 12)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(464, 309)
        Me.grbDatos.TabIndex = 0
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Productos"
        '
        'txtCategoriaProducto
        '
        Me.txtCategoriaProducto.FormattingEnabled = True
        Me.txtCategoriaProducto.Location = New System.Drawing.Point(117, 25)
        Me.txtCategoriaProducto.Name = "txtCategoriaProducto"
        Me.txtCategoriaProducto.Size = New System.Drawing.Size(121, 21)
        Me.txtCategoriaProducto.TabIndex = 10
        '
        'txtDimensionesProducto
        '
        Me.txtDimensionesProducto.Location = New System.Drawing.Point(125, 273)
        Me.txtDimensionesProducto.Name = "txtDimensionesProducto"
        Me.txtDimensionesProducto.Size = New System.Drawing.Size(326, 20)
        Me.txtDimensionesProducto.TabIndex = 9
        '
        'lblDimensiones
        '
        Me.lblDimensiones.AutoSize = True
        Me.lblDimensiones.Location = New System.Drawing.Point(34, 273)
        Me.lblDimensiones.Name = "lblDimensiones"
        Me.lblDimensiones.Size = New System.Drawing.Size(85, 13)
        Me.lblDimensiones.TabIndex = 8
        Me.lblDimensiones.Text = "DIMENSIONES:"
        '
        'txtMarcaProducto
        '
        Me.txtMarcaProducto.Location = New System.Drawing.Point(101, 223)
        Me.txtMarcaProducto.Name = "txtMarcaProducto"
        Me.txtMarcaProducto.Size = New System.Drawing.Size(137, 20)
        Me.txtMarcaProducto.TabIndex = 7
        '
        'lblMarca
        '
        Me.lblMarca.AutoSize = True
        Me.lblMarca.Location = New System.Drawing.Point(39, 226)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(40, 13)
        Me.lblMarca.TabIndex = 6
        Me.lblMarca.Text = "Marca:"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(95, 110)
        Me.txtNombreProducto.Multiline = True
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(326, 93)
        Me.txtNombreProducto.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(34, 110)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "NOMBRE:"
        '
        'txtCodigoProducto
        '
        Me.txtCodigoProducto.Location = New System.Drawing.Point(95, 73)
        Me.txtCodigoProducto.Name = "txtCodigoProducto"
        Me.txtCodigoProducto.Size = New System.Drawing.Size(326, 20)
        Me.txtCodigoProducto.TabIndex = 3
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(39, 73)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 13)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "CODIGO:"
        '
        'lblCategoria
        '
        Me.lblCategoria.AutoSize = True
        Me.lblCategoria.Location = New System.Drawing.Point(39, 28)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(72, 13)
        Me.lblCategoria.TabIndex = 0
        Me.lblCategoria.Text = "CATEGORIA:"
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblNum)
        Me.grbNavegacion.Controls.Add(Me.btn_Ultimo_Producto)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteProducto)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorProducto)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroProducto)
        Me.grbNavegacion.Location = New System.Drawing.Point(27, 327)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(421, 75)
        Me.grbNavegacion.TabIndex = 1
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(188, 40)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(36, 13)
        Me.lblNum.TabIndex = 11
        Me.lblNum.Text = "x de n"
        '
        'btn_Ultimo_Producto
        '
        Me.btn_Ultimo_Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ultimo_Producto.Location = New System.Drawing.Point(340, 32)
        Me.btn_Ultimo_Producto.Name = "btn_Ultimo_Producto"
        Me.btn_Ultimo_Producto.Size = New System.Drawing.Size(75, 27)
        Me.btn_Ultimo_Producto.TabIndex = 14
        Me.btn_Ultimo_Producto.Text = ">|"
        Me.btn_Ultimo_Producto.UseVisualStyleBackColor = True
        '
        'btnSiguienteProducto
        '
        Me.btnSiguienteProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteProducto.Location = New System.Drawing.Point(259, 32)
        Me.btnSiguienteProducto.Name = "btnSiguienteProducto"
        Me.btnSiguienteProducto.Size = New System.Drawing.Size(75, 27)
        Me.btnSiguienteProducto.TabIndex = 13
        Me.btnSiguienteProducto.Text = ">"
        Me.btnSiguienteProducto.UseVisualStyleBackColor = True
        '
        'btnAnteriorProducto
        '
        Me.btnAnteriorProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorProducto.Location = New System.Drawing.Point(85, 32)
        Me.btnAnteriorProducto.Name = "btnAnteriorProducto"
        Me.btnAnteriorProducto.Size = New System.Drawing.Size(75, 27)
        Me.btnAnteriorProducto.TabIndex = 12
        Me.btnAnteriorProducto.Text = "<"
        Me.btnAnteriorProducto.UseVisualStyleBackColor = True
        '
        'btnPrimeroProducto
        '
        Me.btnPrimeroProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroProducto.Location = New System.Drawing.Point(4, 32)
        Me.btnPrimeroProducto.Name = "btnPrimeroProducto"
        Me.btnPrimeroProducto.Size = New System.Drawing.Size(75, 27)
        Me.btnPrimeroProducto.TabIndex = 11
        Me.btnPrimeroProducto.Text = "|<"
        Me.btnPrimeroProducto.UseVisualStyleBackColor = True
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarProducto)
        Me.grbEdicion.Controls.Add(Me.btnEliminarProducto)
        Me.grbEdicion.Controls.Add(Me.btnModificarProducto)
        Me.grbEdicion.Controls.Add(Me.btnAgregarProducto)
        Me.grbEdicion.Location = New System.Drawing.Point(467, 327)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(378, 75)
        Me.grbEdicion.TabIndex = 2
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarProducto
        '
        Me.btnBuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProducto.Location = New System.Drawing.Point(278, 32)
        Me.btnBuscarProducto.Name = "btnBuscarProducto"
        Me.btnBuscarProducto.Size = New System.Drawing.Size(75, 27)
        Me.btnBuscarProducto.TabIndex = 17
        Me.btnBuscarProducto.Text = "Buscar"
        Me.btnBuscarProducto.UseVisualStyleBackColor = True
        '
        'btnEliminarProducto
        '
        Me.btnEliminarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProducto.Location = New System.Drawing.Point(187, 32)
        Me.btnEliminarProducto.Name = "btnEliminarProducto"
        Me.btnEliminarProducto.Size = New System.Drawing.Size(85, 27)
        Me.btnEliminarProducto.TabIndex = 16
        Me.btnEliminarProducto.Text = "Eliminar"
        Me.btnEliminarProducto.UseVisualStyleBackColor = True
        '
        'btnModificarProducto
        '
        Me.btnModificarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProducto.Location = New System.Drawing.Point(87, 32)
        Me.btnModificarProducto.Name = "btnModificarProducto"
        Me.btnModificarProducto.Size = New System.Drawing.Size(94, 27)
        Me.btnModificarProducto.TabIndex = 15
        Me.btnModificarProducto.Text = "Modificar"
        Me.btnModificarProducto.UseVisualStyleBackColor = True
        '
        'btnAgregarProducto
        '
        Me.btnAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProducto.Location = New System.Drawing.Point(6, 32)
        Me.btnAgregarProducto.Name = "btnAgregarProducto"
        Me.btnAgregarProducto.Size = New System.Drawing.Size(75, 27)
        Me.btnAgregarProducto.TabIndex = 14
        Me.btnAgregarProducto.Text = "Nuevo"
        Me.btnAgregarProducto.UseVisualStyleBackColor = True
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 529)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "Productos"
        Me.Text = "Registro de Productos"
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbEdicion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCodigoProducto As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtDimensionesProducto As TextBox
    Friend WithEvents lblDimensiones As Label
    Friend WithEvents txtMarcaProducto As TextBox
    Friend WithEvents lblMarca As Label
    Friend WithEvents txtCategoriaProducto As ComboBox
    Friend WithEvents btn_Ultimo_Producto As Button
    Friend WithEvents btnSiguienteProducto As Button
    Friend WithEvents btnAnteriorProducto As Button
    Friend WithEvents btnPrimeroProducto As Button
    Friend WithEvents lblNum As Label
    Friend WithEvents btnAgregarProducto As Button
    Friend WithEvents btnBuscarProducto As Button
    Friend WithEvents btnEliminarProducto As Button
    Friend WithEvents btnModificarProducto As Button
End Class
