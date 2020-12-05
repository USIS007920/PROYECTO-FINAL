<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEmpleados
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
        Me.btnBuscarEmpleado = New System.Windows.Forms.Button()
        Me.btnEliminarEmpleado = New System.Windows.Forms.Button()
        Me.btnModificarEmpleado = New System.Windows.Forms.Button()
        Me.btnAgregarEmpleado = New System.Windows.Forms.Button()
        Me.grbNavegacion = New System.Windows.Forms.GroupBox()
        Me.lblRegistrosEmpleado = New System.Windows.Forms.Label()
        Me.btnUltimoEmpleado = New System.Windows.Forms.Button()
        Me.btnSiguienteEmpleado = New System.Windows.Forms.Button()
        Me.btnAnteriorEmpleado = New System.Windows.Forms.Button()
        Me.btnPrimeroEmpleado = New System.Windows.Forms.Button()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.lblDireccionEmpleado = New System.Windows.Forms.Label()
        Me.txtEmailEmpleado = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpleado = New System.Windows.Forms.TextBox()
        Me.lblNombreEmpleado = New System.Windows.Forms.Label()
        Me.lblTelefonoEmpleados = New System.Windows.Forms.Label()
        Me.txtnumeroempleado = New System.Windows.Forms.TextBox()
        Me.txtcodigoempleado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdireccionempleado = New System.Windows.Forms.TextBox()
        Me.lblDirec_Empleado = New System.Windows.Forms.Label()
        Me.grbEdicion.SuspendLayout()
        Me.grbNavegacion.SuspendLayout()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbEdicion
        '
        Me.grbEdicion.Controls.Add(Me.btnBuscarEmpleado)
        Me.grbEdicion.Controls.Add(Me.btnEliminarEmpleado)
        Me.grbEdicion.Controls.Add(Me.btnModificarEmpleado)
        Me.grbEdicion.Controls.Add(Me.btnAgregarEmpleado)
        Me.grbEdicion.Location = New System.Drawing.Point(379, 465)
        Me.grbEdicion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Name = "grbEdicion"
        Me.grbEdicion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbEdicion.Size = New System.Drawing.Size(315, 68)
        Me.grbEdicion.TabIndex = 5
        Me.grbEdicion.TabStop = False
        Me.grbEdicion.Text = "Edicion"
        '
        'btnBuscarEmpleado
        '
        Me.btnBuscarEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarEmpleado.Location = New System.Drawing.Point(237, 19)
        Me.btnBuscarEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnBuscarEmpleado.Name = "btnBuscarEmpleado"
        Me.btnBuscarEmpleado.Size = New System.Drawing.Size(75, 39)
        Me.btnBuscarEmpleado.TabIndex = 8
        Me.btnBuscarEmpleado.Text = "Buscar"
        Me.btnBuscarEmpleado.UseVisualStyleBackColor = True
        '
        'btnEliminarEmpleado
        '
        Me.btnEliminarEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarEmpleado.Location = New System.Drawing.Point(158, 19)
        Me.btnEliminarEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnEliminarEmpleado.Name = "btnEliminarEmpleado"
        Me.btnEliminarEmpleado.Size = New System.Drawing.Size(80, 39)
        Me.btnEliminarEmpleado.TabIndex = 7
        Me.btnEliminarEmpleado.Text = "Eliminar"
        Me.btnEliminarEmpleado.UseVisualStyleBackColor = True
        '
        'btnModificarEmpleado
        '
        Me.btnModificarEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarEmpleado.Location = New System.Drawing.Point(69, 19)
        Me.btnModificarEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnModificarEmpleado.Name = "btnModificarEmpleado"
        Me.btnModificarEmpleado.Size = New System.Drawing.Size(90, 39)
        Me.btnModificarEmpleado.TabIndex = 6
        Me.btnModificarEmpleado.Text = "Modificar"
        Me.btnModificarEmpleado.UseVisualStyleBackColor = True
        '
        'btnAgregarEmpleado
        '
        Me.btnAgregarEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarEmpleado.Location = New System.Drawing.Point(2, 19)
        Me.btnAgregarEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAgregarEmpleado.Name = "btnAgregarEmpleado"
        Me.btnAgregarEmpleado.Size = New System.Drawing.Size(68, 39)
        Me.btnAgregarEmpleado.TabIndex = 5
        Me.btnAgregarEmpleado.Text = "Nuevo"
        Me.btnAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'grbNavegacion
        '
        Me.grbNavegacion.Controls.Add(Me.lblRegistrosEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnUltimoEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnSiguienteEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnAnteriorEmpleado)
        Me.grbNavegacion.Controls.Add(Me.btnPrimeroEmpleado)
        Me.grbNavegacion.Location = New System.Drawing.Point(107, 465)
        Me.grbNavegacion.Margin = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Name = "grbNavegacion"
        Me.grbNavegacion.Padding = New System.Windows.Forms.Padding(1)
        Me.grbNavegacion.Size = New System.Drawing.Size(270, 68)
        Me.grbNavegacion.TabIndex = 4
        Me.grbNavegacion.TabStop = False
        Me.grbNavegacion.Text = "Navegacion"
        '
        'lblRegistrosEmpleado
        '
        Me.lblRegistrosEmpleado.AutoSize = True
        Me.lblRegistrosEmpleado.Location = New System.Drawing.Point(86, 34)
        Me.lblRegistrosEmpleado.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblRegistrosEmpleado.Name = "lblRegistrosEmpleado"
        Me.lblRegistrosEmpleado.Size = New System.Drawing.Size(36, 13)
        Me.lblRegistrosEmpleado.TabIndex = 4
        Me.lblRegistrosEmpleado.Text = "x de n"
        '
        'btnUltimoEmpleado
        '
        Me.btnUltimoEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUltimoEmpleado.Location = New System.Drawing.Point(226, 19)
        Me.btnUltimoEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnUltimoEmpleado.Name = "btnUltimoEmpleado"
        Me.btnUltimoEmpleado.Size = New System.Drawing.Size(41, 39)
        Me.btnUltimoEmpleado.TabIndex = 3
        Me.btnUltimoEmpleado.Text = ">|"
        Me.btnUltimoEmpleado.UseVisualStyleBackColor = True
        '
        'btnSiguienteEmpleado
        '
        Me.btnSiguienteEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguienteEmpleado.Location = New System.Drawing.Point(187, 19)
        Me.btnSiguienteEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSiguienteEmpleado.Name = "btnSiguienteEmpleado"
        Me.btnSiguienteEmpleado.Size = New System.Drawing.Size(41, 39)
        Me.btnSiguienteEmpleado.TabIndex = 2
        Me.btnSiguienteEmpleado.Text = ">"
        Me.btnSiguienteEmpleado.UseVisualStyleBackColor = True
        '
        'btnAnteriorEmpleado
        '
        Me.btnAnteriorEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnteriorEmpleado.Location = New System.Drawing.Point(42, 19)
        Me.btnAnteriorEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnAnteriorEmpleado.Name = "btnAnteriorEmpleado"
        Me.btnAnteriorEmpleado.Size = New System.Drawing.Size(41, 39)
        Me.btnAnteriorEmpleado.TabIndex = 1
        Me.btnAnteriorEmpleado.Text = "<"
        Me.btnAnteriorEmpleado.UseVisualStyleBackColor = True
        '
        'btnPrimeroEmpleado
        '
        Me.btnPrimeroEmpleado.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrimeroEmpleado.Location = New System.Drawing.Point(2, 19)
        Me.btnPrimeroEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.btnPrimeroEmpleado.Name = "btnPrimeroEmpleado"
        Me.btnPrimeroEmpleado.Size = New System.Drawing.Size(41, 39)
        Me.btnPrimeroEmpleado.TabIndex = 0
        Me.btnPrimeroEmpleado.Text = "|<"
        Me.btnPrimeroEmpleado.UseVisualStyleBackColor = True
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.lblDirec_Empleado)
        Me.grbDatos.Controls.Add(Me.txtdireccionempleado)
        Me.grbDatos.Controls.Add(Me.txtcodigoempleado)
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Controls.Add(Me.lblTelefonoEmpleados)
        Me.grbDatos.Controls.Add(Me.txtnumeroempleado)
        Me.grbDatos.Controls.Add(Me.lblDireccionEmpleado)
        Me.grbDatos.Controls.Add(Me.txtEmailEmpleado)
        Me.grbDatos.Controls.Add(Me.txtNombreEmpleado)
        Me.grbDatos.Controls.Add(Me.lblNombreEmpleado)
        Me.grbDatos.Enabled = False
        Me.grbDatos.Location = New System.Drawing.Point(107, 7)
        Me.grbDatos.Margin = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Padding = New System.Windows.Forms.Padding(1)
        Me.grbDatos.Size = New System.Drawing.Size(587, 449)
        Me.grbDatos.TabIndex = 3
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos de empledo"
        '
        'lblDireccionEmpleado
        '
        Me.lblDireccionEmpleado.AutoSize = True
        Me.lblDireccionEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccionEmpleado.Location = New System.Drawing.Point(14, 305)
        Me.lblDireccionEmpleado.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblDireccionEmpleado.Name = "lblDireccionEmpleado"
        Me.lblDireccionEmpleado.Size = New System.Drawing.Size(52, 17)
        Me.lblDireccionEmpleado.TabIndex = 6
        Me.lblDireccionEmpleado.Text = "Email:"
        '
        'txtEmailEmpleado
        '
        Me.txtEmailEmpleado.Location = New System.Drawing.Point(121, 297)
        Me.txtEmailEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.txtEmailEmpleado.Multiline = True
        Me.txtEmailEmpleado.Name = "txtEmailEmpleado"
        Me.txtEmailEmpleado.Size = New System.Drawing.Size(333, 25)
        Me.txtEmailEmpleado.TabIndex = 5
        '
        'txtNombreEmpleado
        '
        Me.txtNombreEmpleado.Location = New System.Drawing.Point(121, 72)
        Me.txtNombreEmpleado.Margin = New System.Windows.Forms.Padding(1)
        Me.txtNombreEmpleado.Name = "txtNombreEmpleado"
        Me.txtNombreEmpleado.Size = New System.Drawing.Size(263, 20)
        Me.txtNombreEmpleado.TabIndex = 1
        '
        'lblNombreEmpleado
        '
        Me.lblNombreEmpleado.AutoSize = True
        Me.lblNombreEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreEmpleado.Location = New System.Drawing.Point(14, 72)
        Me.lblNombreEmpleado.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblNombreEmpleado.Name = "lblNombreEmpleado"
        Me.lblNombreEmpleado.Size = New System.Drawing.Size(69, 17)
        Me.lblNombreEmpleado.TabIndex = 0
        Me.lblNombreEmpleado.Text = "Nombre:"
        '
        'lblTelefonoEmpleados
        '
        Me.lblTelefonoEmpleados.AutoSize = True
        Me.lblTelefonoEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefonoEmpleados.Location = New System.Drawing.Point(15, 122)
        Me.lblTelefonoEmpleados.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblTelefonoEmpleados.Name = "lblTelefonoEmpleados"
        Me.lblTelefonoEmpleados.Size = New System.Drawing.Size(77, 17)
        Me.lblTelefonoEmpleados.TabIndex = 10
        Me.lblTelefonoEmpleados.Text = "Telefono:"
        '
        'txtnumeroempleado
        '
        Me.txtnumeroempleado.Location = New System.Drawing.Point(121, 122)
        Me.txtnumeroempleado.Margin = New System.Windows.Forms.Padding(1)
        Me.txtnumeroempleado.Name = "txtnumeroempleado"
        Me.txtnumeroempleado.Size = New System.Drawing.Size(263, 20)
        Me.txtnumeroempleado.TabIndex = 9
        '
        'txtcodigoempleado
        '
        Me.txtcodigoempleado.Location = New System.Drawing.Point(121, 15)
        Me.txtcodigoempleado.Margin = New System.Windows.Forms.Padding(1)
        Me.txtcodigoempleado.Name = "txtcodigoempleado"
        Me.txtcodigoempleado.Size = New System.Drawing.Size(95, 20)
        Me.txtcodigoempleado.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.900001!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 18)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Codigo:"
        '
        'txtdireccionempleado
        '
        Me.txtdireccionempleado.Location = New System.Drawing.Point(121, 166)
        Me.txtdireccionempleado.Multiline = True
        Me.txtdireccionempleado.Name = "txtdireccionempleado"
        Me.txtdireccionempleado.Size = New System.Drawing.Size(263, 80)
        Me.txtdireccionempleado.TabIndex = 13
        '
        'lblDirec_Empleado
        '
        Me.lblDirec_Empleado.AllowDrop = True
        Me.lblDirec_Empleado.AutoSize = True
        Me.lblDirec_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirec_Empleado.Location = New System.Drawing.Point(18, 166)
        Me.lblDirec_Empleado.Name = "lblDirec_Empleado"
        Me.lblDirec_Empleado.Size = New System.Drawing.Size(80, 16)
        Me.lblDirec_Empleado.TabIndex = 14
        Me.lblDirec_Empleado.Text = "Direccion:"
        '
        'frmEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 541)
        Me.Controls.Add(Me.grbEdicion)
        Me.Controls.Add(Me.grbNavegacion)
        Me.Controls.Add(Me.grbDatos)
        Me.Name = "frmEmpleados"
        Me.Text = "frmEmpleados"
        Me.grbEdicion.ResumeLayout(False)
        Me.grbNavegacion.ResumeLayout(False)
        Me.grbNavegacion.PerformLayout()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grbEdicion As GroupBox
    Friend WithEvents btnBuscarEmpleado As Button
    Friend WithEvents btnEliminarEmpleado As Button
    Friend WithEvents btnModificarEmpleado As Button
    Friend WithEvents btnAgregarEmpleado As Button
    Friend WithEvents grbNavegacion As GroupBox
    Friend WithEvents lblRegistrosEmpleado As Label
    Friend WithEvents btnUltimoEmpleado As Button
    Friend WithEvents btnSiguienteEmpleado As Button
    Friend WithEvents btnAnteriorEmpleado As Button
    Friend WithEvents btnPrimeroEmpleado As Button
    Friend WithEvents grbDatos As GroupBox
    Friend WithEvents lblDireccionEmpleado As Label
    Friend WithEvents txtEmailEmpleado As TextBox
    Friend WithEvents txtNombreEmpleado As TextBox
    Friend WithEvents lblNombreEmpleado As Label
    Friend WithEvents txtdireccionempleado As TextBox
    Friend WithEvents txtcodigoempleado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lblTelefonoEmpleados As Label
    Friend WithEvents txtnumeroempleado As TextBox
    Friend WithEvents lblDirec_Empleado As Label
End Class
