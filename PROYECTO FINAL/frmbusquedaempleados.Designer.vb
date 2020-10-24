<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbusquedaempleados
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
        Me.txtbuscarempleados = New System.Windows.Forms.TextBox()
        Me.lblbuscarempleados = New System.Windows.Forms.Label()
        Me.grdbuscarempleado = New System.Windows.Forms.DataGridView()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NIT = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAIL = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TELEFONO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.grdbuscarempleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbuscarempleados
        '
        Me.txtbuscarempleados.Location = New System.Drawing.Point(72, 12)
        Me.txtbuscarempleados.Name = "txtbuscarempleados"
        Me.txtbuscarempleados.Size = New System.Drawing.Size(716, 20)
        Me.txtbuscarempleados.TabIndex = 5
        '
        'lblbuscarempleados
        '
        Me.lblbuscarempleados.AutoSize = True
        Me.lblbuscarempleados.Location = New System.Drawing.Point(12, 19)
        Me.lblbuscarempleados.Name = "lblbuscarempleados"
        Me.lblbuscarempleados.Size = New System.Drawing.Size(54, 13)
        Me.lblbuscarempleados.TabIndex = 4
        Me.lblbuscarempleados.Text = "BUSCAR:"
        '
        'grdbuscarempleado
        '
        Me.grdbuscarempleado.AllowUserToAddRows = False
        Me.grdbuscarempleado.AllowUserToDeleteRows = False
        Me.grdbuscarempleado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdbuscarempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdbuscarempleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NOMBRE, Me.NIT, Me.EMAIL, Me.TELEFONO})
        Me.grdbuscarempleado.Location = New System.Drawing.Point(12, 38)
        Me.grdbuscarempleado.Name = "grdbuscarempleado"
        Me.grdbuscarempleado.ReadOnly = True
        Me.grdbuscarempleado.Size = New System.Drawing.Size(776, 290)
        Me.grdbuscarempleado.TabIndex = 3
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        '
        'NIT
        '
        Me.NIT.HeaderText = "NIT"
        Me.NIT.Name = "NIT"
        Me.NIT.ReadOnly = True
        '
        'EMAIL
        '
        Me.EMAIL.HeaderText = "EMAIL"
        Me.EMAIL.Name = "EMAIL"
        Me.EMAIL.ReadOnly = True
        '
        'TELEFONO
        '
        Me.TELEFONO.HeaderText = "TELEFONO"
        Me.TELEFONO.Name = "TELEFONO"
        Me.TELEFONO.ReadOnly = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(610, 352)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(133, 30)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(452, 352)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Seleccionar Empleado"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmbusquedaempleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtbuscarempleados)
        Me.Controls.Add(Me.lblbuscarempleados)
        Me.Controls.Add(Me.grdbuscarempleado)
        Me.Name = "frmbusquedaempleados"
        Me.Text = "frmbusquedaempleados"
        CType(Me.grdbuscarempleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbuscarempleados As TextBox
    Friend WithEvents lblbuscarempleados As Label
    Friend WithEvents grdbuscarempleado As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents NIT As DataGridViewTextBoxColumn
    Friend WithEvents EMAIL As DataGridViewTextBoxColumn
    Friend WithEvents TELEFONO As DataGridViewTextBoxColumn
End Class
