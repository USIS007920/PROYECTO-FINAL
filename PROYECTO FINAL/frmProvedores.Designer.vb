<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProvedores
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
        Me.btnBuscarProvedor = New System.Windows.Forms.Button()
        Me.btnEliminarProvedor = New System.Windows.Forms.Button()
        Me.btnModificarProvedor = New System.Windows.Forms.Button()
        Me.btnAgregarProvedor = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.btn_Ultimo_Provedor = New System.Windows.Forms.Button()
        Me.btnSiguienteProvedor = New System.Windows.Forms.Button()
        Me.btnAnteriorProvedor = New System.Windows.Forms.Button()
        Me.btnPrimeroProvedor = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.txtNombreProvedor = New System.Windows.Forms.TextBox()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.txtDireccionProvedor = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtCodigoProvedor = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarProvedor)
        Me.grbEdicion.Controls.Add(Me.btnEliminarProvedor)
        Me.grbEdicion.Controls.Add(Me.btnModificarProvedor)
        Me.grbEdicion.Controls.Add(Me.btnAgregarProvedor)
        Me.grbEdicion.Location = New System.Drawing.Point(431, 345)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Size = New System.Drawing.Size(378, 75)
        Me.grbEdicion.TabIndex = 5
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarProvedor
        '
        Me.btnBuscarProvedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarProvedor.Location = New System.Drawing.Point(278, 32)
        Me.btnBuscarProvedor.Name = "btnBuscarProvedor"
        Me.btnBuscarProvedor.Size = New System.Drawing.Size(75, 27)
        Me.btnBuscarProvedor.TabIndex = 17
        Me.btnBuscarProvedor.Text = "Buscar"
        Me.btnBuscarProvedor.UseVisualStyleBackColor = True
        '
        'btnEliminarProvedor
        '
        Me.btnEliminarProvedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarProvedor.Location = New System.Drawing.Point(187, 32)
        Me.btnEliminarProvedor.Name = "btnEliminarProvedor"
        Me.btnEliminarProvedor.Size = New System.Drawing.Size(85, 27)
        Me.btnEliminarProvedor.TabIndex = 16
        Me.btnEliminarProvedor.Text = "Eliminar"
        Me.btnEliminarProvedor.UseVisualStyleBackColor = True
        '
        'btnModificarProvedor
        '
        Me.btnModificarProvedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarProvedor.Location = New System.Drawing.Point(87, 32)
        Me.btnModificarProvedor.Name = "btnModificarProvedor"
        Me.btnModificarProvedor.Size = New System.Drawing.Size(94, 27)
        Me.btnModificarProvedor.TabIndex = 15
        Me.btnModificarProvedor.Text = "Modificar"
        Me.btnModificarProvedor.UseVisualStyleBackColor = True
        '
        'btnAgregarProvedor
        '
        Me.btnAgregarProvedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarProvedor.Location = New System.Drawing.Point(6, 32)
        Me.btnAgregarProvedor.Name = "btnAgregarProvedor"
        Me.btnAgregarProvedor.Size = New System.Drawing.Size(75, 27)
        Me.btnAgregarProvedor.TabIndex = 14
        Me.btnAgregarProvedor.Text = "Nuevo"
        Me.btnAgregarProvedor.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblNum)
        Me.grbNavegacion.Controls.Add(Me.btn_Ultimo_Provedor)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteProvedor)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorProvedor)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroProvedor)
        Me.grbNavegacion.Location = New System.Drawing.Point(-9, 345)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Size = New System.Drawing.Size(421, 75)
        Me.grbNavegacion.TabIndex = 4
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
        'btn_Ultimo_Provedor
        '
        Me.btn_Ultimo_Provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Ultimo_Provedor.Location = New System.Drawing.Point(340, 32)
        Me.btn_Ultimo_Provedor.Name = "btn_Ultimo_Provedor"
        Me.btn_Ultimo_Provedor.Size = New System.Drawing.Size(75, 27)
        Me.btn_Ultimo_Provedor.TabIndex = 14
        Me.btn_Ultimo_Provedor.Text = ">|"
        Me.btn_Ultimo_Provedor.UseVisualStyleBackColor = True
        '
        'btnSiguienteProvedor
        '
        Me.btnSiguienteProvedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteProvedor.Location = New System.Drawing.Point(259, 32)
        Me.btnSiguienteProvedor.Name = "btnSiguienteProvedor"
        Me.btnSiguienteProvedor.Size = New System.Drawing.Size(75, 27)
        Me.btnSiguienteProvedor.TabIndex = 13
        Me.btnSiguienteProvedor.Text = ">"
        Me.btnSiguienteProvedor.UseVisualStyleBackColor = True
        '
        'btnAnteriorProvedor
        '
        Me.btnAnteriorProvedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorProvedor.Location = New System.Drawing.Point(85, 32)
        Me.btnAnteriorProvedor.Name = "btnAnteriorProvedor"
        Me.btnAnteriorProvedor.Size = New System.Drawing.Size(75, 27)
        Me.btnAnteriorProvedor.TabIndex = 12
        Me.btnAnteriorProvedor.Text = "<"
        Me.btnAnteriorProvedor.UseVisualStyleBackColor = True
        '
        'btnPrimeroProvedor
        '
        Me.btnPrimeroProvedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroProvedor.Location = New System.Drawing.Point(4, 32)
        Me.btnPrimeroProvedor.Name = "btnPrimeroProvedor"
        Me.btnPrimeroProvedor.Size = New System.Drawing.Size(75, 27)
        Me.btnPrimeroProvedor.TabIndex = 11
        Me.btnPrimeroProvedor.Text = "|<"
        Me.btnPrimeroProvedor.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.txtNombreProvedor)
        Me.grbDatos.Controls.Add(Me.lbldireccion)
        Me.grbDatos.Controls.Add(Me.txtDireccionProvedor)
        Me.grbDatos.Controls.Add(Me.lblNombre)
        Me.grbDatos.Controls.Add(Me.txtCodigoProvedor)
        Me.grbDatos.Controls.Add(Me.lblCodigo)
        Me.grbDatos.Location = New System.Drawing.Point(-9, 30)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(464, 309)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de Productos"
        '
        'txtNombreProvedor
        '
        Me.txtNombreProvedor.Location = New System.Drawing.Point(79, 89)
        Me.txtNombreProvedor.Name = "txtNombreProvedor"
        Me.txtNombreProvedor.Size = New System.Drawing.Size(342, 20)
        Me.txtNombreProvedor.TabIndex = 7
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Location = New System.Drawing.Point(16, 139)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(69, 13)
        Me.lbldireccion.TabIndex = 6
        Me.lbldireccion.Text = "DIRECCION:"
        '
        'txtDireccionProvedor
        '
        Me.txtDireccionProvedor.Location = New System.Drawing.Point(89, 133)
        Me.txtDireccionProvedor.Multiline = True
        Me.txtDireccionProvedor.Name = "txtDireccionProvedor"
        Me.txtDireccionProvedor.Size = New System.Drawing.Size(332, 78)
        Me.txtDireccionProvedor.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(16, 92)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(57, 13)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "NOMBRE:"
        '
        'txtCodigoProvedor
        '
        Me.txtCodigoProvedor.Location = New System.Drawing.Point(70, 37)
        Me.txtCodigoProvedor.Name = "txtCodigoProvedor"
        Me.txtCodigoProvedor.Size = New System.Drawing.Size(345, 20)
        Me.txtCodigoProvedor.TabIndex = 3
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(21, 40)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(52, 13)
        Me.lblCodigo.TabIndex = 2
        Me.lblCodigo.Text = "CODIGO:"
        '
        'frmProvedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmProvedores"
        Me.Text = "frmProvedores"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarProvedor As Button
    Friend WithEvents btnEliminarProvedor As Button
    Friend WithEvents btnModificarProvedor As Button
    Friend WithEvents btnAgregarProvedor As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblNum As Label
    Friend WithEvents btn_Ultimo_Provedor As Button
    Friend WithEvents btnSiguienteProvedor As Button
    Friend WithEvents btnAnteriorProvedor As Button
    Friend WithEvents btnPrimeroProvedor As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents txtNombreProvedor As TextBox
    Friend WithEvents lbldireccion As Label
    Friend WithEvents txtDireccionProvedor As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtCodigoProvedor As TextBox
    Friend WithEvents lblCodigo As Label
End Class
