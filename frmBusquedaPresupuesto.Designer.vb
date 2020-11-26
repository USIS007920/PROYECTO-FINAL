<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaPresupuesto
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
        Me.btnCancelarPresupuesto = New System.Windows.Forms.Button()
        Me.btnseleccionarPresupuesto = New System.Windows.Forms.Button()
        Me.txtbuscarpresupuesto = New System.Windows.Forms.TextBox()
        Me.lblbuscarpresupuesto = New System.Windows.Forms.Label()
        Me.grdbuscarPresupuesto = New System.Windows.Forms.DataGridView()
        CType(Me.grdbuscarPresupuesto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarPresupuesto
        '
        Me.btnCancelarPresupuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarPresupuesto.Location = New System.Drawing.Point(655, 341)
        Me.btnCancelarPresupuesto.Name = "btnCancelarPresupuesto"
        Me.btnCancelarPresupuesto.Size = New System.Drawing.Size(133, 30)
        Me.btnCancelarPresupuesto.TabIndex = 14
        Me.btnCancelarPresupuesto.Text = "Cancelar"
        Me.btnCancelarPresupuesto.UseVisualStyleBackColor = True
        '
        'btnseleccionarPresupuesto
        '
        Me.btnseleccionarPresupuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnseleccionarPresupuesto.Location = New System.Drawing.Point(506, 341)
        Me.btnseleccionarPresupuesto.Name = "btnseleccionarPresupuesto"
        Me.btnseleccionarPresupuesto.Size = New System.Drawing.Size(133, 30)
        Me.btnseleccionarPresupuesto.TabIndex = 13
        Me.btnseleccionarPresupuesto.Text = "Seleccionar Presupuesto"
        Me.btnseleccionarPresupuesto.UseVisualStyleBackColor = True
        '
        'txtbuscarpresupuesto
        '
        Me.txtbuscarpresupuesto.Location = New System.Drawing.Point(72, 6)
        Me.txtbuscarpresupuesto.Name = "txtbuscarpresupuesto"
        Me.txtbuscarpresupuesto.Size = New System.Drawing.Size(716, 20)
        Me.txtbuscarpresupuesto.TabIndex = 12
        '
        'lblbuscarpresupuesto
        '
        Me.lblbuscarpresupuesto.AutoSize = True
        Me.lblbuscarpresupuesto.Location = New System.Drawing.Point(12, 13)
        Me.lblbuscarpresupuesto.Name = "lblbuscarpresupuesto"
        Me.lblbuscarpresupuesto.Size = New System.Drawing.Size(54, 13)
        Me.lblbuscarpresupuesto.TabIndex = 11
        Me.lblbuscarpresupuesto.Text = "BUSCAR:"
        '
        'grdbuscarPresupuesto
        '
        Me.grdbuscarPresupuesto.AllowUserToAddRows = False
        Me.grdbuscarPresupuesto.AllowUserToDeleteRows = False
        Me.grdbuscarPresupuesto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdbuscarPresupuesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdbuscarPresupuesto.Location = New System.Drawing.Point(12, 32)
        Me.grdbuscarPresupuesto.Name = "grdbuscarPresupuesto"
        Me.grdbuscarPresupuesto.ReadOnly = True
        Me.grdbuscarPresupuesto.Size = New System.Drawing.Size(776, 290)
        Me.grdbuscarPresupuesto.TabIndex = 10
        '
        'frmBusquedaPresupuesto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnCancelarPresupuesto)
        Me.Controls.Add(Me.btnseleccionarPresupuesto)
        Me.Controls.Add(Me.txtbuscarpresupuesto)
        Me.Controls.Add(Me.lblbuscarpresupuesto)
        Me.Controls.Add(Me.grdbuscarPresupuesto)
        Me.Name = "frmBusquedaPresupuesto"
        Me.Text = "frmBusquedaPresupuesto"
        CType(Me.grdbuscarPresupuesto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarPresupuesto As Button
    Friend WithEvents btnseleccionarPresupuesto As Button
    Friend WithEvents txtbuscarpresupuesto As TextBox
    Friend WithEvents lblbuscarpresupuesto As Label
    Friend WithEvents grdbuscarPresupuesto As DataGridView
End Class
