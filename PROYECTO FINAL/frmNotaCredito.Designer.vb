<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNotaCredito
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
        Me.btnBuscarNotaCredito = New System.Windows.Forms.Button()
        Me.btnEliminarNotaCredito = New System.Windows.Forms.Button()
        Me.btnModificarNotaCredito = New System.Windows.Forms.Button()
        Me.btnAgregarNotaCredito = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosNotasCreditos = New System.Windows.Forms.Label()
        Me.btnUltimaNotaCredito = New System.Windows.Forms.Button()
        Me.btnSiguienteNotaCredito = New System.Windows.Forms.Button()
        Me.btnAnteriorNotaCrdito = New System.Windows.Forms.Button()
        Me.btnPrimeraNotaCredito = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lblFechaNotacredito = New System.Windows.Forms.Label()
        Me.lblMedidasProducto = New System.Windows.Forms.Label()
        Me.txtMontoTotalNotaCredito = New System.Windows.Forms.TextBox()
        Me.lblMarcaProducto = New System.Windows.Forms.Label()
        Me.txtImpuestosNotaCredito = New System.Windows.Forms.TextBox()
        Me.lblDescripcionProducto = New System.Windows.Forms.Label()
        Me.txtDescripcionNotaCredito = New System.Windows.Forms.TextBox()
        Me.txtFechaNotaCredito = New System.Windows.Forms.TextBox()
        Me.lblCodigoProducto = New System.Windows.Forms.Label()
        Me.txtDatosNotaCredito = New System.Windows.Forms.TextBox()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarNotaCredito)
        Me.grbEdicion.Controls.Add(Me.btnEliminarNotaCredito)
        Me.grbEdicion.Controls.Add(Me.btnModificarNotaCredito)
        Me.grbEdicion.Controls.Add(Me.btnAgregarNotaCredito)
        Me.grbEdicion.Location = New System.Drawing.Point(282, 389)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(315, 68)
        Me.grbEdicion.TabIndex = 8
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarNotaCredito
        '
        Me.btnBuscarNotaCredito.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarNotaCredito.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscarNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarNotaCredito.Name = "btnBuscarNotaCredito"
        Me.btnBuscarNotaCredito.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscarNotaCredito.TabIndex = 8
        Me.btnBuscarNotaCredito.Text = "Buscar"
        Me.btnBuscarNotaCredito.UseVisualStyleBackColor = True
        '
        'btnEliminarNotaCredito
        '
        Me.btnEliminarNotaCredito.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarNotaCredito.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminarNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarNotaCredito.Name = "btnEliminarNotaCredito"
        Me.btnEliminarNotaCredito.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminarNotaCredito.TabIndex = 7
        Me.btnEliminarNotaCredito.Text = "Eliminar"
        Me.btnEliminarNotaCredito.UseVisualStyleBackColor = True
        '
        'btnModificarNotaCredito
        '
        Me.btnModificarNotaCredito.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarNotaCredito.Location = New System.Drawing.Point(69, 19)
        Me.btnModificarNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarNotaCredito.Name = "btnModificarNotaCredito"
        Me.btnModificarNotaCredito.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarNotaCredito.TabIndex = 6
        Me.btnModificarNotaCredito.Text = "Modificar"
        Me.btnModificarNotaCredito.UseVisualStyleBackColor = True
        '
        'btnAgregarNotaCredito
        '
        Me.btnAgregarNotaCredito.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarNotaCredito.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregarNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarNotaCredito.Name = "btnAgregarNotaCredito"
        Me.btnAgregarNotaCredito.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarNotaCredito.TabIndex = 5
        Me.btnAgregarNotaCredito.Text = "Nuevo"
        Me.btnAgregarNotaCredito.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosNotasCreditos)
        Me.grbNavegacion.Controls.Add(Me.btnUltimaNotaCredito)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteNotaCredito)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorNotaCrdito)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeraNotaCredito)
        Me.grbNavegacion.Location = New System.Drawing.Point(10, 389)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(270, 68)
        Me.grbNavegacion.TabIndex = 7
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosNotasCreditos
        '
        Me.lblRegistrosNotasCreditos.AutoSize = True
        Me.lblRegistrosNotasCreditos.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosNotasCreditos.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosNotasCreditos.Name = "lblRegistrosNotasCreditos"
        Me.lblRegistrosNotasCreditos.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosNotasCreditos.TabIndex = 4
        Me.lblRegistrosNotasCreditos.Text = "x de n"
        '
        'btnUltimaNotaCredito
        '
        Me.btnUltimaNotaCredito.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimaNotaCredito.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimaNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimaNotaCredito.Name = "btnUltimaNotaCredito"
        Me.btnUltimaNotaCredito.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimaNotaCredito.TabIndex = 3
        Me.btnUltimaNotaCredito.Text = ">|"
        Me.btnUltimaNotaCredito.UseVisualStyleBackColor = True
        '
        'btnSiguienteNotaCredito
        '
        Me.btnSiguienteNotaCredito.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteNotaCredito.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguienteNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteNotaCredito.Name = "btnSiguienteNotaCredito"
        Me.btnSiguienteNotaCredito.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguienteNotaCredito.TabIndex = 2
        Me.btnSiguienteNotaCredito.Text = ">"
        Me.btnSiguienteNotaCredito.UseVisualStyleBackColor = True
        '
        'btnAnteriorNotaCrdito
        '
        Me.btnAnteriorNotaCrdito.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorNotaCrdito.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriorNotaCrdito.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorNotaCrdito.Name = "btnAnteriorNotaCrdito"
        Me.btnAnteriorNotaCrdito.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriorNotaCrdito.TabIndex = 1
        Me.btnAnteriorNotaCrdito.Text = "<"
        Me.btnAnteriorNotaCrdito.UseVisualStyleBackColor = True
        '
        'btnPrimeraNotaCredito
        '
        Me.btnPrimeraNotaCredito.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeraNotaCredito.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimeraNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeraNotaCredito.Name = "btnPrimeraNotaCredito"
        Me.btnPrimeraNotaCredito.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimeraNotaCredito.TabIndex = 0
        Me.btnPrimeraNotaCredito.Text = "|<"
        Me.btnPrimeraNotaCredito.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtDatosNotaCredito)
        Me.grbDatos.Controls.Add(Me.lblFechaNotacredito)
        Me.grbDatos.Controls.Add(Me.lblMedidasProducto)
        Me.grbDatos.Controls.Add(Me.txtMontoTotalNotaCredito)
        Me.grbDatos.Controls.Add(Me.lblMarcaProducto)
        Me.grbDatos.Controls.Add(Me.txtImpuestosNotaCredito)
        Me.grbDatos.Controls.Add(Me.lblDescripcionProducto)
        Me.grbDatos.Controls.Add(Me.txtDescripcionNotaCredito)
        Me.grbDatos.Controls.Add(Me.txtFechaNotaCredito)
        Me.grbDatos.Controls.Add(Me.lblCodigoProducto)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(10, 10)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(587, 377)
        Me.grbDatos.TabIndex = 6
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Nota Credito"
        '
        'lblFechaNotacredito
        '
        Me.lblFechaNotacredito.AutoSize = True
        Me.lblFechaNotacredito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNotacredito.Location = New System.Drawing.Point(23, 55)
        Me.lblFechaNotacredito.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblFechaNotacredito.Name = "lblFechaNotacredito"
        Me.lblFechaNotacredito.Size = New System.Drawing.Size(66, 17)
        Me.lblFechaNotacredito.TabIndex = 9
        Me.lblFechaNotacredito.Text = "DATOS:"
        '
        'lblMedidasProducto
        '
        Me.lblMedidasProducto.AutoSize = True
        Me.lblMedidasProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMedidasProducto.Location = New System.Drawing.Point(23, 301)
        Me.lblMedidasProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMedidasProducto.Name = "lblMedidasProducto"
        Me.lblMedidasProducto.Size = New System.Drawing.Size(126, 17)
        Me.lblMedidasProducto.TabIndex = 8
        Me.lblMedidasProducto.Text = "MONTO TOTAL:"
        '
        'txtMontoTotalNotaCredito
        '
        Me.txtMontoTotalNotaCredito.Location = New System.Drawing.Point(161, 301)
        Me.txtMontoTotalNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.txtMontoTotalNotaCredito.Name = "txtMontoTotalNotaCredito"
        Me.txtMontoTotalNotaCredito.Size = New System.Drawing.Size(191, 20)
        Me.txtMontoTotalNotaCredito.TabIndex = 7
        '
        'lblMarcaProducto
        '
        Me.lblMarcaProducto.AutoSize = True
        Me.lblMarcaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMarcaProducto.Location = New System.Drawing.Point(23, 243)
        Me.lblMarcaProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblMarcaProducto.Name = "lblMarcaProducto"
        Me.lblMarcaProducto.Size = New System.Drawing.Size(102, 17)
        Me.lblMarcaProducto.TabIndex = 6
        Me.lblMarcaProducto.Text = "IMPUESTOS:"
        '
        'txtImpuestosNotaCredito
        '
        Me.txtImpuestosNotaCredito.Location = New System.Drawing.Point(141, 240)
        Me.txtImpuestosNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.txtImpuestosNotaCredito.Name = "txtImpuestosNotaCredito"
        Me.txtImpuestosNotaCredito.Size = New System.Drawing.Size(191, 20)
        Me.txtImpuestosNotaCredito.TabIndex = 5
        '
        'lblDescripcionProducto
        '
        Me.lblDescripcionProducto.AutoSize = True
        Me.lblDescripcionProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcionProducto.Location = New System.Drawing.Point(23, 180)
        Me.lblDescripcionProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDescripcionProducto.Name = "lblDescripcionProducto"
        Me.lblDescripcionProducto.Size = New System.Drawing.Size(116, 17)
        Me.lblDescripcionProducto.TabIndex = 4
        Me.lblDescripcionProducto.Text = "DESCRIPCION:"
        '
        'txtDescripcionNotaCredito
        '
        Me.txtDescripcionNotaCredito.Location = New System.Drawing.Point(141, 179)
        Me.txtDescripcionNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDescripcionNotaCredito.Name = "txtDescripcionNotaCredito"
        Me.txtDescripcionNotaCredito.Size = New System.Drawing.Size(333, 20)
        Me.txtDescripcionNotaCredito.TabIndex = 3
        '
        'txtFechaNotaCredito
        '
        Me.txtFechaNotaCredito.Location = New System.Drawing.Point(141, 121)
        Me.txtFechaNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.txtFechaNotaCredito.Name = "txtFechaNotaCredito"
        Me.txtFechaNotaCredito.Size = New System.Drawing.Size(95, 20)
        Me.txtFechaNotaCredito.TabIndex = 1
        '
        'lblCodigoProducto
        '
        Me.lblCodigoProducto.AutoSize = True
        Me.lblCodigoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigoProducto.Location = New System.Drawing.Point(23, 121)
        Me.lblCodigoProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblCodigoProducto.Name = "lblCodigoProducto"
        Me.lblCodigoProducto.Size = New System.Drawing.Size(63, 17)
        Me.lblCodigoProducto.TabIndex = 0
        Me.lblCodigoProducto.Text = "FECHA:"
        '
        'txtDatosNotaCredito
        '
        Me.txtDatosNotaCredito.Location = New System.Drawing.Point(100, 52)
        Me.txtDatosNotaCredito.Margin = New System.Windows.Forms.Padding(1)
        Me.txtDatosNotaCredito.Name = "txtDatosNotaCredito"
        Me.txtDatosNotaCredito.Size = New System.Drawing.Size(95, 20)
        Me.txtDatosNotaCredito.TabIndex = 10
        '
        'frmNotaCredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmNotaCredito"
        Me.Text = "frmNotaCredito"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarNotaCredito As Button
    Friend WithEvents btnEliminarNotaCredito As Button
    Friend WithEvents btnModificarNotaCredito As Button
    Friend WithEvents btnAgregarNotaCredito As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosNotasCreditos As Label
    Friend WithEvents btnUltimaNotaCredito As Button
    Friend WithEvents btnSiguienteNotaCredito As Button
    Friend WithEvents btnAnteriorNotaCrdito As Button
    Friend WithEvents btnPrimeraNotaCredito As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblFechaNotacredito As Label
    Friend WithEvents lblMedidasProducto As Label
    Friend WithEvents txtMontoTotalNotaCredito As TextBox
    Friend WithEvents lblMarcaProducto As Label
    Friend WithEvents txtImpuestosNotaCredito As TextBox
    Friend WithEvents lblDescripcionProducto As Label
    Friend WithEvents txtDescripcionNotaCredito As TextBox
    Friend WithEvents txtFechaNotaCredito As TextBox
    Friend WithEvents lblCodigoProducto As Label
    Friend WithEvents txtDatosNotaCredito As TextBox
End Class
