<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPresupuesto
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
        Me.grbEdicion = New System.Windows.Forms.GroupBox()
        Me.btnBuscarPresupuesto = New System.Windows.Forms.Button()
        Me.btnEliminarPresupuesto = New System.Windows.Forms.Button()
        Me.btnModificarPresupuesto = New System.Windows.Forms.Button()
        Me.btnAgregarPresupuesto = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.btn_Ultimo_Presupuesto = New System.Windows.Forms.Button()
        Me.btnSiguientePresupuesto = New System.Windows.Forms.Button()
        Me.btnAnteriorPresupuesto = New System.Windows.Forms.Button()
        Me.btnPrimeroPresupuesto = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtIVA = New System.Windows.Forms.TextBox()
        Me.txtDimensionesProducto = New System.Windows.Forms.TextBox()
        Me.lblDimensiones = New System.Windows.Forms.Label()
        Me.txtMarcaProducto = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtNombreProducto = New System.Windows.Forms.TextBox()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.txtDescuentos = New System.Windows.Forms.TextBox()
        Me.lbldescuentos = New System.Windows.Forms.Label()
        Me.lblIIVA = New System.Windows.Forms.Label()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarPresupuesto)
        Me.grbEdicion.Controls.Add(Me.btnEliminarPresupuesto)
        Me.grbEdicion.Controls.Add(Me.btnModificarPresupuesto)
        Me.grbEdicion.Controls.Add(Me.btnAgregarPresupuesto)
        Me.grbEdicion.Location = New System.Drawing.Point(429, 363)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(359, 75)
        Me.grbEdicion.TabIndex = 5
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarPresupuesto
        '
        Me.btnBuscarPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarPresupuesto.Location = New System.Drawing.Point(278, 32)
        Me.btnBuscarPresupuesto.Name = "btnBuscarPresupuesto"
        Me.btnBuscarPresupuesto.Size = New System.Drawing.Size(75, 27)
        Me.btnBuscarPresupuesto.TabIndex = 17
        Me.btnBuscarPresupuesto.Text = "Buscar"
        Me.btnBuscarPresupuesto.UseVisualStyleBackColor = True
        '
        'btnEliminarPresupuesto
        '
        Me.btnEliminarPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPresupuesto.Location = New System.Drawing.Point(187, 32)
        Me.btnEliminarPresupuesto.Name = "btnEliminarPresupuesto"
        Me.btnEliminarPresupuesto.Size = New System.Drawing.Size(85, 27)
        Me.btnEliminarPresupuesto.TabIndex = 16
        Me.btnEliminarPresupuesto.Text = "Eliminar"
        Me.btnEliminarPresupuesto.UseVisualStyleBackColor = True
        '
        'btnModificarPresupuesto
        '
        Me.btnModificarPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPresupuesto.Location = New System.Drawing.Point(87, 32)
        Me.btnModificarPresupuesto.Name = "btnModificarPresupuesto"
        Me.btnModificarPresupuesto.Size = New System.Drawing.Size(94, 27)
        Me.btnModificarPresupuesto.TabIndex = 15
        Me.btnModificarPresupuesto.Text = "Modificar"
        Me.btnModificarPresupuesto.UseVisualStyleBackColor = True
        '
        'btnAgregarPresupuesto
        '
        Me.btnAgregarPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPresupuesto.Location = New System.Drawing.Point(6, 32)
        Me.btnAgregarPresupuesto.Name = "btnAgregarPresupuesto"
        Me.btnAgregarPresupuesto.Size = New System.Drawing.Size(75, 27)
        Me.btnAgregarPresupuesto.TabIndex = 14
        Me.btnAgregarPresupuesto.Text = "Nuevo"
        Me.btnAgregarPresupuesto.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblNum)
        Me.grbNavegacion.Controls.Add(Me.btn_Ultimo_Presupuesto)
        Me.grbNavegacion.Controls.Add(Me.btnSiguientePresupuesto)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorPresupuesto)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroPresupuesto)
        Me.grbNavegacion.Location = New System.Drawing.Point(12, 363)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(282, 75)
        Me.grbNavegacion.TabIndex = 4
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Location = New System.Drawing.Point(113, 32)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(36, 13)
        Me.lblNum.TabIndex = 11
        Me.lblNum.Text = "x de n"
        '
        'btn_Ultimo_Presupuesto
        '
        Me.btn_Ultimo_Presupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ultimo_Presupuesto.Location = New System.Drawing.Point(210, 27)
        Me.btn_Ultimo_Presupuesto.Name = "btn_Ultimo_Presupuesto"
        Me.btn_Ultimo_Presupuesto.Size = New System.Drawing.Size(53, 30)
        Me.btn_Ultimo_Presupuesto.TabIndex = 14
        Me.btn_Ultimo_Presupuesto.Text = ">|"
        Me.btn_Ultimo_Presupuesto.UseVisualStyleBackColor = True
        '
        'btnSiguientePresupuesto
        '
        Me.btnSiguientePresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguientePresupuesto.Location = New System.Drawing.Point(164, 29)
        Me.btnSiguientePresupuesto.Name = "btnSiguientePresupuesto"
        Me.btnSiguientePresupuesto.Size = New System.Drawing.Size(40, 27)
        Me.btnSiguientePresupuesto.TabIndex = 13
        Me.btnSiguientePresupuesto.Text = ">"
        Me.btnSiguientePresupuesto.UseVisualStyleBackColor = True
        '
        'btnAnteriorPresupuesto
        '
        Me.btnAnteriorPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorPresupuesto.Location = New System.Drawing.Point(57, 29)
        Me.btnAnteriorPresupuesto.Name = "btnAnteriorPresupuesto"
        Me.btnAnteriorPresupuesto.Size = New System.Drawing.Size(34, 27)
        Me.btnAnteriorPresupuesto.TabIndex = 12
        Me.btnAnteriorPresupuesto.Text = "<"
        Me.btnAnteriorPresupuesto.UseVisualStyleBackColor = True
        '
        'btnPrimeroPresupuesto
        '
        Me.btnPrimeroPresupuesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroPresupuesto.Location = New System.Drawing.Point(4, 29)
        Me.btnPrimeroPresupuesto.Name = "btnPrimeroPresupuesto"
        Me.btnPrimeroPresupuesto.Size = New System.Drawing.Size(47, 29)
        Me.btnPrimeroPresupuesto.TabIndex = 11
        Me.btnPrimeroPresupuesto.Text = "|<"
        Me.btnPrimeroPresupuesto.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtIVA)
        Me.grbDatos.Controls.Add(Me.txtDimensionesProducto)
        Me.grbDatos.Controls.Add(Me.lblDimensiones)
        Me.grbDatos.Controls.Add(Me.txtMarcaProducto)
        Me.grbDatos.Controls.Add(Me.lblDescripcion)
        Me.grbDatos.Controls.Add(Me.txtNombreProducto)
        Me.grbDatos.Controls.Add(Me.lblFactura)
        Me.grbDatos.Controls.Add(Me.txtDescuentos)
        Me.grbDatos.Controls.Add(Me.lbldescuentos)
        Me.grbDatos.Controls.Add(Me.lblIIVA)
        Me.grbDatos.Location = New System.Drawing.Point(12, 12)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(463, 335)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Presupuesto"
        '
        'txtIVA
        '
        Me.txtIVA.Location = New System.Drawing.Point(116, 28)
        Me.txtIVA.Name = "txtIVA"
        Me.txtIVA.Size = New System.Drawing.Size(88, 20)
        Me.txtIVA.TabIndex = 10
        '
        'txtDimensionesProducto
        '
        Me.txtDimensionesProducto.Location = New System.Drawing.Point(116, 192)
        Me.txtDimensionesProducto.Name = "txtDimensionesProducto"
        Me.txtDimensionesProducto.Size = New System.Drawing.Size(326, 20)
        Me.txtDimensionesProducto.TabIndex = 9
        '
        'lblDimensiones
        '
        Me.lblDimensiones.AutoSize = True
        Me.lblDimensiones.Location = New System.Drawing.Point(22, 192)
        Me.lblDimensiones.Name = "lblDimensiones"
        Me.lblDimensiones.Size = New System.Drawing.Size(85, 13)
        Me.lblDimensiones.TabIndex = 8
        Me.lblDimensiones.Text = "DIMENSIONES:"
        '
        'txtMarcaProducto
        '
        Me.txtMarcaProducto.Location = New System.Drawing.Point(116, 155)
        Me.txtMarcaProducto.Name = "txtMarcaProducto"
        Me.txtMarcaProducto.Size = New System.Drawing.Size(137, 20)
        Me.txtMarcaProducto.TabIndex = 7
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(27, 158)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(83, 13)
        Me.lblDescripcion.TabIndex = 6
        Me.lblDescripcion.Text = "DESCRIPCION:"
        '
        'txtNombreProducto
        '
        Me.txtNombreProducto.Location = New System.Drawing.Point(116, 110)
        Me.txtNombreProducto.Multiline = True
        Me.txtNombreProducto.Name = "txtNombreProducto"
        Me.txtNombreProducto.Size = New System.Drawing.Size(326, 16)
        Me.txtNombreProducto.TabIndex = 5
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Location = New System.Drawing.Point(47, 113)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(60, 13)
        Me.lblFactura.TabIndex = 4
        Me.lblFactura.Text = "FACTURA:"
        '
        'txtDescuentos
        '
        Me.txtDescuentos.Location = New System.Drawing.Point(116, 67)
        Me.txtDescuentos.Name = "txtDescuentos"
        Me.txtDescuentos.Size = New System.Drawing.Size(326, 20)
        Me.txtDescuentos.TabIndex = 3
        '
        'lbldescuentos
        '
        Me.lbldescuentos.AutoSize = True
        Me.lbldescuentos.Location = New System.Drawing.Point(35, 70)
        Me.lbldescuentos.Name = "lbldescuentos"
        Me.lbldescuentos.Size = New System.Drawing.Size(84, 13)
        Me.lbldescuentos.TabIndex = 2
        Me.lbldescuentos.Text = "DESCUENTOS:"
        '
        'lblIIVA
        '
        Me.lblIIVA.AutoSize = True
        Me.lblIIVA.Location = New System.Drawing.Point(64, 31)
        Me.lblIIVA.Name = "lblIIVA"
        Me.lblIIVA.Size = New System.Drawing.Size(27, 13)
        Me.lblIIVA.TabIndex = 0
        Me.lblIIVA.Text = "IVA:"
        '
        'frmPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmPresupuesto"
        Me.Text = "frmPresupuesto"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarPresupuesto As Button
    Friend WithEvents btnEliminarPresupuesto As Button
    Friend WithEvents btnModificarPresupuesto As Button
    Friend WithEvents btnAgregarPresupuesto As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblNum As Label
    Friend WithEvents btn_Ultimo_Presupuesto As Button
    Friend WithEvents btnSiguientePresupuesto As Button
    Friend WithEvents btnAnteriorPresupuesto As Button
    Friend WithEvents btnPrimeroPresupuesto As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtDimensionesProducto As TextBox
    Friend WithEvents lblDimensiones As Label
    Friend WithEvents txtMarcaProducto As TextBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtNombreProducto As TextBox
    Friend WithEvents lblFactura As Label
    Friend WithEvents txtDescuentos As TextBox
    Friend WithEvents lbldescuentos As Label
    Friend WithEvents lblIIVA As Label
    Friend WithEvents txtIVA As TextBox
End Class
