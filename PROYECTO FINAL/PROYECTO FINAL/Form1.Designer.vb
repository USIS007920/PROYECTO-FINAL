<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProvedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PreciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FacturacionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProvedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDePagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeDetalleDeVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListadoDeTipoFacturaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.EmpresaToolStripMenuItem, Me.VentasToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(96, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.ProvedoresToolStripMenuItem, Me.PreciosToolStripMenuItem, Me.ClientesToolStripMenuItem})
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Image = CType(resources.GetObject("ProductosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ProvedoresToolStripMenuItem
        '
        Me.ProvedoresToolStripMenuItem.Image = CType(resources.GetObject("ProvedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProvedoresToolStripMenuItem.Name = "ProvedoresToolStripMenuItem"
        Me.ProvedoresToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ProvedoresToolStripMenuItem.Text = "Provedores"
        '
        'PreciosToolStripMenuItem
        '
        Me.PreciosToolStripMenuItem.Image = CType(resources.GetObject("PreciosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.PreciosToolStripMenuItem.Name = "PreciosToolStripMenuItem"
        Me.PreciosToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.PreciosToolStripMenuItem.Text = "Empleados"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Image = CType(resources.GetObject("ClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturacionToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'FacturacionToolStripMenuItem
        '
        Me.FacturacionToolStripMenuItem.Image = CType(resources.GetObject("FacturacionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FacturacionToolStripMenuItem.Name = "FacturacionToolStripMenuItem"
        Me.FacturacionToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FacturacionToolStripMenuItem.Text = "Facturacion"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Image = CType(resources.GetObject("CategoriasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeProvedoresToolStripMenuItem, Me.ListadoDeClientesToolStripMenuItem, Me.ListadoDeProductosToolStripMenuItem, Me.ListadoDeVentasToolStripMenuItem, Me.ListadoDePagoToolStripMenuItem, Me.ListadoDeDetalleDeVentasToolStripMenuItem, Me.ListadoDeTipoFacturaToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ListadoDeProvedoresToolStripMenuItem
        '
        Me.ListadoDeProvedoresToolStripMenuItem.Image = CType(resources.GetObject("ListadoDeProvedoresToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListadoDeProvedoresToolStripMenuItem.Name = "ListadoDeProvedoresToolStripMenuItem"
        Me.ListadoDeProvedoresToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ListadoDeProvedoresToolStripMenuItem.Text = "Listado de Provedores"
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Image = CType(resources.GetObject("ListadoDeClientesToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de Clientes"
        '
        'ListadoDeProductosToolStripMenuItem
        '
        Me.ListadoDeProductosToolStripMenuItem.Image = CType(resources.GetObject("ListadoDeProductosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListadoDeProductosToolStripMenuItem.Name = "ListadoDeProductosToolStripMenuItem"
        Me.ListadoDeProductosToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ListadoDeProductosToolStripMenuItem.Text = "Listado de Productos"
        '
        'ListadoDeVentasToolStripMenuItem
        '
        Me.ListadoDeVentasToolStripMenuItem.Image = CType(resources.GetObject("ListadoDeVentasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListadoDeVentasToolStripMenuItem.Name = "ListadoDeVentasToolStripMenuItem"
        Me.ListadoDeVentasToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ListadoDeVentasToolStripMenuItem.Text = "Listado de Ventas"
        '
        'ListadoDePagoToolStripMenuItem
        '
        Me.ListadoDePagoToolStripMenuItem.Image = CType(resources.GetObject("ListadoDePagoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListadoDePagoToolStripMenuItem.Name = "ListadoDePagoToolStripMenuItem"
        Me.ListadoDePagoToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ListadoDePagoToolStripMenuItem.Text = "Listado de Pago"
        '
        'ListadoDeDetalleDeVentasToolStripMenuItem
        '
        Me.ListadoDeDetalleDeVentasToolStripMenuItem.Image = CType(resources.GetObject("ListadoDeDetalleDeVentasToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListadoDeDetalleDeVentasToolStripMenuItem.Name = "ListadoDeDetalleDeVentasToolStripMenuItem"
        Me.ListadoDeDetalleDeVentasToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ListadoDeDetalleDeVentasToolStripMenuItem.Text = "Listado de Detalle de Ventas"
        '
        'ListadoDeTipoFacturaToolStripMenuItem
        '
        Me.ListadoDeTipoFacturaToolStripMenuItem.Image = CType(resources.GetObject("ListadoDeTipoFacturaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListadoDeTipoFacturaToolStripMenuItem.Name = "ListadoDeTipoFacturaToolStripMenuItem"
        Me.ListadoDeTipoFacturaToolStripMenuItem.Size = New System.Drawing.Size(220, 22)
        Me.ListadoDeTipoFacturaToolStripMenuItem.Text = "Listado de Tipo Factura"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProvedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PreciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturacionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeProvedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDePagoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeDetalleDeVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListadoDeTipoFacturaToolStripMenuItem As ToolStripMenuItem
End Class
