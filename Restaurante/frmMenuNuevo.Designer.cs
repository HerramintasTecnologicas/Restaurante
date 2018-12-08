namespace Restaurante
{
    partial class frmMenuNuevo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuNuevo));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.restaurante = new System.Windows.Forms.ToolStripDropDownButton();
            this.ControlMesas = new System.Windows.Forms.ToolStripMenuItem();
            this.Pedido = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Productos = new System.Windows.Forms.ToolStripDropDownButton();
            this.Inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.Insumos = new System.Windows.Forms.ToolStripMenuItem();
            this.Proveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.Categoria = new System.Windows.Forms.ToolStripMenuItem();
            this.Tipo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Reportes = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.Seguridad = new System.Windows.Forms.ToolStripDropDownButton();
            this.Meseros = new System.Windows.Forms.ToolStripMenuItem();
            this.Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Ayuda = new System.Windows.Forms.ToolStripDropDownButton();
            this.CerrarSesión = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.Caja = new System.Windows.Forms.ToolStripMenuItem();
            this.Apertura = new System.Windows.Forms.ToolStripMenuItem();
            this.Cierre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restaurante,
            this.toolStripSeparator1,
            this.Productos,
            this.toolStripSeparator3,
            this.Reportes,
            this.toolStripSeparator4,
            this.Seguridad,
            this.toolStripSeparator2,
            this.Ayuda,
            this.CerrarSesión,
            this.toolStripDropDownButton3});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1080, 37);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // restaurante
            // 
            this.restaurante.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ControlMesas,
            this.Pedido,
            this.Caja});
            this.restaurante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.restaurante.Image = global::Restaurante.Properties.Resources.LogoTenedor1;
            this.restaurante.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.restaurante.ImageTransparentColor = System.Drawing.Color.LemonChiffon;
            this.restaurante.Name = "restaurante";
            this.restaurante.Size = new System.Drawing.Size(118, 34);
            this.restaurante.Text = "Restaurante";
            // 
            // ControlMesas
            // 
            this.ControlMesas.BackColor = System.Drawing.SystemColors.Menu;
            this.ControlMesas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ControlMesas.Name = "ControlMesas";
            this.ControlMesas.Size = new System.Drawing.Size(186, 22);
            this.ControlMesas.Text = "Control de las Mesas";
            // 
            // Pedido
            // 
            this.Pedido.BackColor = System.Drawing.SystemColors.Menu;
            this.Pedido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Pedido.Name = "Pedido";
            this.Pedido.Size = new System.Drawing.Size(186, 22);
            this.Pedido.Text = "Nuevo pedido";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // Productos
            // 
            this.Productos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Inventario,
            this.Insumos,
            this.Proveedores,
            this.Categoria,
            this.Tipo});
            this.Productos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Productos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Productos.Image = global::Restaurante.Properties.Resources.business_inventory_maintenance_product_box_boxes_2;
            this.Productos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Productos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Productos.Name = "Productos";
            this.Productos.Padding = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Productos.Size = new System.Drawing.Size(119, 34);
            this.Productos.Text = "Productos";
            this.Productos.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // Inventario
            // 
            this.Inventario.BackColor = System.Drawing.SystemColors.Menu;
            this.Inventario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Inventario.Name = "Inventario";
            this.Inventario.Size = new System.Drawing.Size(201, 22);
            this.Inventario.Text = "Inventario";
            // 
            // Insumos
            // 
            this.Insumos.BackColor = System.Drawing.SystemColors.Menu;
            this.Insumos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Insumos.Name = "Insumos";
            this.Insumos.Size = new System.Drawing.Size(201, 22);
            this.Insumos.Text = "Insumos";
            // 
            // Proveedores
            // 
            this.Proveedores.BackColor = System.Drawing.SystemColors.Menu;
            this.Proveedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Proveedores.Name = "Proveedores";
            this.Proveedores.Size = new System.Drawing.Size(201, 22);
            this.Proveedores.Text = "Proveedores";
            // 
            // Categoria
            // 
            this.Categoria.BackColor = System.Drawing.SystemColors.Menu;
            this.Categoria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(201, 22);
            this.Categoria.Text = "Categoria del Producto";
            // 
            // Tipo
            // 
            this.Tipo.BackColor = System.Drawing.SystemColors.Menu;
            this.Tipo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem12,
            this.toolStripMenuItem21,
            this.toolStripMenuItem22});
            this.Tipo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(201, 22);
            this.Tipo.Text = "Tipo de Unidad";
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripMenuItem12.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem12.Text = "Agregar";
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripMenuItem21.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem21.Text = "Inhabilitar";
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripMenuItem22.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(130, 22);
            this.toolStripMenuItem22.Text = "Actualizar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 37);
            // 
            // Reportes
            // 
            this.Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem9,
            this.toolStripMenuItem10,
            this.toolStripMenuItem11});
            this.Reportes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Reportes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Reportes.Image = global::Restaurante.Properties.Resources.Listar;
            this.Reportes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Reportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Reportes.Name = "Reportes";
            this.Reportes.Padding = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Reportes.Size = new System.Drawing.Size(100, 34);
            this.Reportes.Text = "Reportes";
            this.Reportes.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripMenuItem9.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem9.Text = "Registrar Venta";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripMenuItem10.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem10.Text = "Anular Venta";
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStripMenuItem11.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem11.Text = "Buscar Factura";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 37);
            // 
            // Seguridad
            // 
            this.Seguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Meseros,
            this.Usuarios});
            this.Seguridad.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Seguridad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Seguridad.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Seguridad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Seguridad.Name = "Seguridad";
            this.Seguridad.Padding = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.Seguridad.Size = new System.Drawing.Size(89, 34);
            this.Seguridad.Text = "Seguridad";
            this.Seguridad.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            // 
            // Meseros
            // 
            this.Meseros.BackColor = System.Drawing.SystemColors.Menu;
            this.Meseros.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Meseros.Name = "Meseros";
            this.Meseros.Size = new System.Drawing.Size(180, 22);
            this.Meseros.Text = "Meseros";
            // 
            // Usuarios
            // 
            this.Usuarios.BackColor = System.Drawing.SystemColors.Menu;
            this.Usuarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Size = new System.Drawing.Size(180, 22);
            this.Usuarios.Text = "Usuarios";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // Ayuda
            // 
            this.Ayuda.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.Ayuda.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Ayuda.ImageTransparentColor = System.Drawing.Color.LemonChiffon;
            this.Ayuda.Name = "Ayuda";
            this.Ayuda.Size = new System.Drawing.Size(54, 34);
            this.Ayuda.Text = "Ayuda";
            // 
            // CerrarSesión
            // 
            this.CerrarSesión.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.CerrarSesión.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CerrarSesión.ImageTransparentColor = System.Drawing.Color.LemonChiffon;
            this.CerrarSesión.Name = "CerrarSesión";
            this.CerrarSesión.Size = new System.Drawing.Size(94, 34);
            this.CerrarSesión.Text = "Cerrar Sesión";
            this.CerrarSesión.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton3.Image")));
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(29, 34);
            this.toolStripDropDownButton3.Text = "toolStripDropDownButton3";
            // 
            // Caja
            // 
            this.Caja.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Apertura,
            this.Cierre,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.Caja.Name = "Caja";
            this.Caja.Size = new System.Drawing.Size(186, 22);
            this.Caja.Text = "Caja";
            // 
            // Apertura
            // 
            this.Apertura.Name = "Apertura";
            this.Apertura.Size = new System.Drawing.Size(189, 22);
            this.Apertura.Text = "Apertura de caja";
            // 
            // Cierre
            // 
            this.Cierre.Name = "Cierre";
            this.Cierre.Size = new System.Drawing.Size(189, 22);
            this.Cierre.Text = "Cierre de Caja";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(189, 22);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // frmMenuNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Restaurante.Properties.Resources.Logo_Especialidades_Las_Marías__3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuNuevo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuNuevo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton restaurante;
        private System.Windows.Forms.ToolStripMenuItem ControlMesas;
        private System.Windows.Forms.ToolStripMenuItem Pedido;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton Productos;
        private System.Windows.Forms.ToolStripMenuItem Inventario;
        private System.Windows.Forms.ToolStripMenuItem Insumos;
        private System.Windows.Forms.ToolStripMenuItem Proveedores;
        private System.Windows.Forms.ToolStripMenuItem Categoria;
        private System.Windows.Forms.ToolStripMenuItem Tipo;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem12;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem21;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem22;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripDropDownButton Reportes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripDropDownButton Seguridad;
        private System.Windows.Forms.ToolStripMenuItem Meseros;
        private System.Windows.Forms.ToolStripMenuItem Usuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton Ayuda;
        private System.Windows.Forms.ToolStripDropDownButton CerrarSesión;
        private System.Windows.Forms.ToolStripMenuItem Caja;
        private System.Windows.Forms.ToolStripMenuItem Apertura;
        private System.Windows.Forms.ToolStripMenuItem Cierre;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
    }
}