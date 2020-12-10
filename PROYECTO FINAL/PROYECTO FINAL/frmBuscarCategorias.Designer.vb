<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBuscarCategorias
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
        Me.btnCancelarProducto = New System.Windows.Forms.Button()
        Me.btnSeleccionarCategoria = New System.Windows.Forms.Button()
        Me.grdBuscarCategoria = New System.Windows.Forms.DataGridView()
        Me.idCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblBuscarProducto = New System.Windows.Forms.Label()
        Me.txtBuscarCategoria = New System.Windows.Forms.TextBox()
        CType(Me.grdBuscarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProducto.Location = New System.Drawing.Point(739, 465)
        Me.btnCancelarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(104, 33)
        Me.btnCancelarProducto.TabIndex = 15
        Me.btnCancelarProducto.Text = "Cancelar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'btnSeleccionarCategoria
        '
        Me.btnSeleccionarCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarCategoria.Location = New System.Drawing.Point(501, 465)
        Me.btnSeleccionarCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarCategoria.Name = "btnSeleccionarCategoria"
        Me.btnSeleccionarCategoria.Size = New System.Drawing.Size(220, 33)
        Me.btnSeleccionarCategoria.TabIndex = 14
        Me.btnSeleccionarCategoria.Text = "Seleccionar Categoria"
        Me.btnSeleccionarCategoria.UseVisualStyleBackColor = True
        '
        'grdBuscarCategoria
        '
        Me.grdBuscarCategoria.AllowUserToAddRows = False
        Me.grdBuscarCategoria.AllowUserToDeleteRows = False
        Me.grdBuscarCategoria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdBuscarCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBuscarCategoria.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idCategoria, Me.categoria})
        Me.grdBuscarCategoria.Location = New System.Drawing.Point(37, 46)
        Me.grdBuscarCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarCategoria.Name = "grdBuscarCategoria"
        Me.grdBuscarCategoria.ReadOnly = True
        Me.grdBuscarCategoria.RowHeadersWidth = 102
        Me.grdBuscarCategoria.RowTemplate.Height = 40
        Me.grdBuscarCategoria.Size = New System.Drawing.Size(806, 407)
        Me.grdBuscarCategoria.TabIndex = 13
        '
        'idCategoria
        '
        Me.idCategoria.DataPropertyName = "idCategoria"
        Me.idCategoria.HeaderText = "ID"
        Me.idCategoria.MinimumWidth = 12
        Me.idCategoria.Name = "idCategoria"
        Me.idCategoria.ReadOnly = True
        Me.idCategoria.Visible = False
        Me.idCategoria.Width = 450
        '
        'categoria
        '
        Me.categoria.DataPropertyName = "categoria"
        Me.categoria.HeaderText = "CATEGORIA"
        Me.categoria.MinimumWidth = 12
        Me.categoria.Name = "categoria"
        Me.categoria.ReadOnly = True
        Me.categoria.Width = 350
        '
        'lblBuscarProducto
        '
        Me.lblBuscarProducto.AutoSize = True
        Me.lblBuscarProducto.Location = New System.Drawing.Point(34, 9)
        Me.lblBuscarProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarProducto.Name = "lblBuscarProducto"
        Me.lblBuscarProducto.Size = New System.Drawing.Size(54, 13)
        Me.lblBuscarProducto.TabIndex = 17
        Me.lblBuscarProducto.Text = "BUSCAR:"
        '
        'txtBuscarCategoria
        '
        Me.txtBuscarCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarCategoria.Location = New System.Drawing.Point(89, 6)
        Me.txtBuscarCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarCategoria.Name = "txtBuscarCategoria"
        Me.txtBuscarCategoria.Size = New System.Drawing.Size(1472, 20)
        Me.txtBuscarCategoria.TabIndex = 16
        '
        'frmBuscarCategorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 508)
        Me.Controls.Add(Me.lblBuscarProducto)
        Me.Controls.Add(Me.txtBuscarCategoria)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.btnSeleccionarCategoria)
        Me.Controls.Add(Me.grdBuscarCategoria)
        Me.Name = "frmBuscarCategorias"
        Me.Text = "frmBuscarCategorias"
        CType(Me.grdBuscarCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancelarProducto As Button
    Friend WithEvents btnSeleccionarCategoria As Button
    Friend WithEvents grdBuscarCategoria As DataGridView
    Friend WithEvents idCategoria As DataGridViewTextBoxColumn
    Friend WithEvents categoria As DataGridViewTextBoxColumn
    Friend WithEvents lblBuscarProducto As Label
    Friend WithEvents txtBuscarCategoria As TextBox
End Class
