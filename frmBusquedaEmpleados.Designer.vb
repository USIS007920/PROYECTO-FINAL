<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaEmpleados
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
        Me.btnCancelarEmpleado = New System.Windows.Forms.Button()
        Me.btnseleccionarEmpleados = New System.Windows.Forms.Button()
        Me.txtbuscarempleados = New System.Windows.Forms.TextBox()
        Me.lblbuscarempleados = New System.Windows.Forms.Label()
        Me.grdbuscarempleados = New System.Windows.Forms.DataGridView()
        CType(Me.grdbuscarempleados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarEmpleado
        '
        Me.btnCancelarEmpleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarEmpleado.Location = New System.Drawing.Point(655, 347)
        Me.btnCancelarEmpleado.Name = "btnCancelarEmpleado"
        Me.btnCancelarEmpleado.Size = New System.Drawing.Size(133, 30)
        Me.btnCancelarEmpleado.TabIndex = 9
        Me.btnCancelarEmpleado.Text = "Cancelar"
        Me.btnCancelarEmpleado.UseVisualStyleBackColor = True
        '
        'btnseleccionarEmpleados
        '
        Me.btnseleccionarEmpleados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnseleccionarEmpleados.Location = New System.Drawing.Point(506, 347)
        Me.btnseleccionarEmpleados.Name = "btnseleccionarEmpleados"
        Me.btnseleccionarEmpleados.Size = New System.Drawing.Size(133, 30)
        Me.btnseleccionarEmpleados.TabIndex = 8
        Me.btnseleccionarEmpleados.Text = "Seleccionar Empleado"
        Me.btnseleccionarEmpleados.UseVisualStyleBackColor = True
        '
        'txtbuscarempleados
        '
        Me.txtbuscarempleados.Location = New System.Drawing.Point(72, 12)
        Me.txtbuscarempleados.Name = "txtbuscarempleados"
        Me.txtbuscarempleados.Size = New System.Drawing.Size(716, 20)
        Me.txtbuscarempleados.TabIndex = 7
        '
        'lblbuscarempleados
        '
        Me.lblbuscarempleados.AutoSize = True
        Me.lblbuscarempleados.Location = New System.Drawing.Point(12, 19)
        Me.lblbuscarempleados.Name = "lblbuscarempleados"
        Me.lblbuscarempleados.Size = New System.Drawing.Size(54, 13)
        Me.lblbuscarempleados.TabIndex = 6
        Me.lblbuscarempleados.Text = "BUSCAR:"
        '
        'grdbuscarempleados
        '
        Me.grdbuscarempleados.AllowUserToAddRows = False
        Me.grdbuscarempleados.AllowUserToDeleteRows = False
        Me.grdbuscarempleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdbuscarempleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdbuscarempleados.Location = New System.Drawing.Point(12, 38)
        Me.grdbuscarempleados.Name = "grdbuscarempleados"
        Me.grdbuscarempleados.ReadOnly = True
        Me.grdbuscarempleados.Size = New System.Drawing.Size(776, 290)
        Me.grdbuscarempleados.TabIndex = 5
        '
        'frmBusquedaEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelarEmpleado)
        Me.Controls.Add(Me.btnseleccionarEmpleados)
        Me.Controls.Add(Me.txtbuscarempleados)
        Me.Controls.Add(Me.lblbuscarempleados)
        Me.Controls.Add(Me.grdbuscarempleados)
        Me.Name = "frmBusquedaEmpleados"
        Me.Text = "frmBusquedaEmpleados"
        CType(Me.grdbuscarempleados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarEmpleado As Button
    Friend WithEvents btnseleccionarEmpleados As Button
    Friend WithEvents txtbuscarempleados As TextBox
    Friend WithEvents lblbuscarempleados As Label
    Friend WithEvents grdbuscarempleados As DataGridView
End Class
