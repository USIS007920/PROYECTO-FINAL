<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbusquedanotacredito
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
        Me.btnCancelarnotacredito = New System.Windows.Forms.Button()
        Me.btnseleccionarnotacredito = New System.Windows.Forms.Button()
        Me.txtbuscarnotacredito = New System.Windows.Forms.TextBox()
        Me.lblbuscarnotacredito = New System.Windows.Forms.Label()
        Me.grdbuscarnotacredito = New System.Windows.Forms.DataGridView()
        CType(Me.grdbuscarnotacredito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarnotacredito
        '
        Me.btnCancelarnotacredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarnotacredito.Location = New System.Drawing.Point(655, 343)
        Me.btnCancelarnotacredito.Name = "btnCancelarnotacredito"
        Me.btnCancelarnotacredito.Size = New System.Drawing.Size(133, 30)
        Me.btnCancelarnotacredito.TabIndex = 9
        Me.btnCancelarnotacredito.Text = "Cancelar"
        Me.btnCancelarnotacredito.UseVisualStyleBackColor = True
        '
        'btnseleccionarnotacredito
        '
        Me.btnseleccionarnotacredito.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnseleccionarnotacredito.Location = New System.Drawing.Point(506, 343)
        Me.btnseleccionarnotacredito.Name = "btnseleccionarnotacredito"
        Me.btnseleccionarnotacredito.Size = New System.Drawing.Size(133, 30)
        Me.btnseleccionarnotacredito.TabIndex = 8
        Me.btnseleccionarnotacredito.Text = "Seleccionar Producto"
        Me.btnseleccionarnotacredito.UseVisualStyleBackColor = True
        '
        'txtbuscarnotacredito
        '
        Me.txtbuscarnotacredito.Location = New System.Drawing.Point(72, 8)
        Me.txtbuscarnotacredito.Name = "txtbuscarnotacredito"
        Me.txtbuscarnotacredito.Size = New System.Drawing.Size(716, 20)
        Me.txtbuscarnotacredito.TabIndex = 7
        '
        'lblbuscarnotacredito
        '
        Me.lblbuscarnotacredito.AutoSize = True
        Me.lblbuscarnotacredito.Location = New System.Drawing.Point(12, 15)
        Me.lblbuscarnotacredito.Name = "lblbuscarnotacredito"
        Me.lblbuscarnotacredito.Size = New System.Drawing.Size(54, 13)
        Me.lblbuscarnotacredito.TabIndex = 6
        Me.lblbuscarnotacredito.Text = "BUSCAR:"
        '
        'grdbuscarnotacredito
        '
        Me.grdbuscarnotacredito.AllowUserToAddRows = False
        Me.grdbuscarnotacredito.AllowUserToDeleteRows = False
        Me.grdbuscarnotacredito.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdbuscarnotacredito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdbuscarnotacredito.Location = New System.Drawing.Point(12, 34)
        Me.grdbuscarnotacredito.Name = "grdbuscarnotacredito"
        Me.grdbuscarnotacredito.ReadOnly = True
        Me.grdbuscarnotacredito.Size = New System.Drawing.Size(776, 290)
        Me.grdbuscarnotacredito.TabIndex = 5
        '
        'frmbusquedanotacredito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelarnotacredito)
        Me.Controls.Add(Me.btnseleccionarnotacredito)
        Me.Controls.Add(Me.txtbuscarnotacredito)
        Me.Controls.Add(Me.lblbuscarnotacredito)
        Me.Controls.Add(Me.grdbuscarnotacredito)
        Me.Name = "frmbusquedanotacredito"
        Me.Text = "frmbusquedanotacredito"
        CType(Me.grdbuscarnotacredito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarnotacredito As Button
    Friend WithEvents btnseleccionarnotacredito As Button
    Friend WithEvents txtbuscarnotacredito As TextBox
    Friend WithEvents lblbuscarnotacredito As Label
    Friend WithEvents grdbuscarnotacredito As DataGridView
End Class
