<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarProvedores
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
        Me.btnCancelarProvedor = New System.Windows.Forms.Button()
        Me.btnSeleccionarProvedor = New System.Windows.Forms.Button()
        Me.txtbuscarProvedores = New System.Windows.Forms.TextBox()
        Me.lblbuscarProvedores = New System.Windows.Forms.Label()
        Me.grdBuscarProvedores = New System.Windows.Forms.DataGridView()
        Me.CODIGO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DIRECCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.grdBuscarProvedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarProvedor
        '
        Me.btnCancelarProvedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarProvedor.Location = New System.Drawing.Point(655, 371)
        Me.btnCancelarProvedor.Name = "btnCancelarProvedor"
        Me.btnCancelarProvedor.Size = New System.Drawing.Size(133, 30)
        Me.btnCancelarProvedor.TabIndex = 9
        Me.btnCancelarProvedor.Text = "Cancelar"
        Me.btnCancelarProvedor.UseVisualStyleBackColor = True
        '
        'btnSeleccionarProvedor
        '
        Me.btnSeleccionarProvedor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarProvedor.Location = New System.Drawing.Point(505, 371)
        Me.btnSeleccionarProvedor.Name = "btnSeleccionarProvedor"
        Me.btnSeleccionarProvedor.Size = New System.Drawing.Size(133, 30)
        Me.btnSeleccionarProvedor.TabIndex = 8
        Me.btnSeleccionarProvedor.Text = "Seleccionar Provedor"
        Me.btnSeleccionarProvedor.UseVisualStyleBackColor = True
        '
        'txtbuscarProvedores
        '
        Me.txtbuscarProvedores.Location = New System.Drawing.Point(72, 49)
        Me.txtbuscarProvedores.Name = "txtbuscarProvedores"
        Me.txtbuscarProvedores.Size = New System.Drawing.Size(716, 20)
        Me.txtbuscarProvedores.TabIndex = 7
        '
        'lblbuscarProvedores
        '
        Me.lblbuscarProvedores.AutoSize = True
        Me.lblbuscarProvedores.Location = New System.Drawing.Point(12, 56)
        Me.lblbuscarProvedores.Name = "lblbuscarProvedores"
        Me.lblbuscarProvedores.Size = New System.Drawing.Size(54, 13)
        Me.lblbuscarProvedores.TabIndex = 6
        Me.lblbuscarProvedores.Text = "BUSCAR:"
        '
        'grdBuscarProvedores
        '
        Me.grdBuscarProvedores.AllowUserToAddRows = False
        Me.grdBuscarProvedores.AllowUserToDeleteRows = False
        Me.grdBuscarProvedores.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarProvedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarProvedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CODIGO, Me.NOMBRE, Me.DIRECCION})
        Me.grdBuscarProvedores.Location = New System.Drawing.Point(12, 75)
        Me.grdBuscarProvedores.Name = "grdBuscarProvedores"
        Me.grdBuscarProvedores.ReadOnly = True
        Me.grdBuscarProvedores.Size = New System.Drawing.Size(776, 290)
        Me.grdBuscarProvedores.TabIndex = 5
        '
        'CODIGO
        '
        Me.CODIGO.HeaderText = "CODIGO"
        Me.CODIGO.Name = "CODIGO"
        Me.CODIGO.ReadOnly = True
        Me.CODIGO.Visible = False
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "NOMBRE"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Visible = False
        '
        'DIRECCION
        '
        Me.DIRECCION.HeaderText = "DIRECCION"
        Me.DIRECCION.Name = "DIRECCION"
        Me.DIRECCION.ReadOnly = True
        Me.DIRECCION.Visible = False
        '
        'frmBuscarProvedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelarProvedor)
        Me.Controls.Add(Me.btnSeleccionarProvedor)
        Me.Controls.Add(Me.txtbuscarProvedores)
        Me.Controls.Add(Me.lblbuscarProvedores)
        Me.Controls.Add(Me.grdBuscarProvedores)
        Me.Name = "frmBuscarProvedores"
        Me.Text = "Busqueda de Registros de Provedores"
        CType(Me.grdBuscarProvedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarProvedor As Button
    Friend WithEvents btnSeleccionarProvedor As Button
    Friend WithEvents txtbuscarProvedores As TextBox
    Friend WithEvents lblbuscarProvedores As Label
    Friend WithEvents grdBuscarProvedores As DataGridView
    Friend WithEvents CODIGO As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents DIRECCION As DataGridViewTextBoxColumn
End Class
