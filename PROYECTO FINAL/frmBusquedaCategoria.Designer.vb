<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaCategoria
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_Selec_Cat = New System.Windows.Forms.Button()
        CType(Me.grdBuscarCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancelarProducto
        '
        Me.btnCancelarProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarProducto.Location = New System.Drawing.Point(655, 552)
        Me.btnCancelarProducto.Margin = New System.Windows.Forms.Padding(1)
        Me.btnCancelarProducto.Name = "btnCancelarProducto"
        Me.btnCancelarProducto.Size = New System.Drawing.Size(57, 10)
        Me.btnCancelarProducto.TabIndex = 17
        Me.btnCancelarProducto.Text = "Cancelar"
        Me.btnCancelarProducto.UseVisualStyleBackColor = True
        '
        'btnSeleccionarCategoria
        '
        Me.btnSeleccionarCategoria.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSeleccionarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionarCategoria.Location = New System.Drawing.Point(417, 552)
        Me.btnSeleccionarCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.btnSeleccionarCategoria.Name = "btnSeleccionarCategoria"
        Me.btnSeleccionarCategoria.Size = New System.Drawing.Size(173, 10)
        Me.btnSeleccionarCategoria.TabIndex = 16
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
        Me.grdBuscarCategoria.Location = New System.Drawing.Point(22, 45)
        Me.grdBuscarCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.grdBuscarCategoria.Name = "grdBuscarCategoria"
        Me.grdBuscarCategoria.ReadOnly = True
        Me.grdBuscarCategoria.RowHeadersWidth = 102
        Me.grdBuscarCategoria.RowTemplate.Height = 40
        Me.grdBuscarCategoria.Size = New System.Drawing.Size(734, 305)
        Me.grdBuscarCategoria.TabIndex = 15
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
        Me.lblBuscarProducto.Location = New System.Drawing.Point(19, 13)
        Me.lblBuscarProducto.Margin = New System.Windows.Forms.Padding(1, 0, 1, 0)
        Me.lblBuscarProducto.Name = "lblBuscarProducto"
        Me.lblBuscarProducto.Size = New System.Drawing.Size(54, 13)
        Me.lblBuscarProducto.TabIndex = 14
        Me.lblBuscarProducto.Text = "BUSCAR:"
        '
        'txtBuscarCategoria
        '
        Me.txtBuscarCategoria.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBuscarCategoria.Location = New System.Drawing.Point(74, 10)
        Me.txtBuscarCategoria.Margin = New System.Windows.Forms.Padding(1)
        Me.txtBuscarCategoria.Name = "txtBuscarCategoria"
        Me.txtBuscarCategoria.Size = New System.Drawing.Size(682, 20)
        Me.txtBuscarCategoria.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(639, 377)
        Me.Button1.Margin = New System.Windows.Forms.Padding(1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 33)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_Selec_Cat
        '
        Me.btn_Selec_Cat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Selec_Cat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Selec_Cat.Location = New System.Drawing.Point(401, 377)
        Me.btn_Selec_Cat.Margin = New System.Windows.Forms.Padding(1)
        Me.btn_Selec_Cat.Name = "btn_Selec_Cat"
        Me.btn_Selec_Cat.Size = New System.Drawing.Size(236, 33)
        Me.btn_Selec_Cat.TabIndex = 18
        Me.btn_Selec_Cat.Text = "Seleccionar Categoria"
        Me.btn_Selec_Cat.UseVisualStyleBackColor = True
        '
        'frmBusquedaCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 488)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Selec_Cat)
        Me.Controls.Add(Me.btnCancelarProducto)
        Me.Controls.Add(Me.btnSeleccionarCategoria)
        Me.Controls.Add(Me.grdBuscarCategoria)
        Me.Controls.Add(Me.lblBuscarProducto)
        Me.Controls.Add(Me.txtBuscarCategoria)
        Me.Name = "frmBusquedaCategoria"
        Me.Text = "frmBusquedaCategoria"
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
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_Selec_Cat As Button
End Class
