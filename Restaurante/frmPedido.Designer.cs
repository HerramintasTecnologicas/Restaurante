namespace Restaurante
{
    partial class frmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedido));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.updo = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCaja = new System.Windows.Forms.TextBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.cmbMesero = new System.Windows.Forms.ComboBox();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnModificarInsumo = new System.Windows.Forms.Button();
            this.btnEliminarInsumo = new System.Windows.Forms.Button();
            this.btnAgregarInsumo = new System.Windows.Forms.Button();
            this.txtCantidadInsumo = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.updo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(118, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 47);
            this.button2.TabIndex = 81;
            this.button2.Text = "Por salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 47);
            this.button1.TabIndex = 80;
            this.button1.Text = "Por salir";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // updo
            // 
            this.updo.Location = new System.Drawing.Point(660, 50);
            this.updo.Name = "updo";
            this.updo.Size = new System.Drawing.Size(55, 20);
            this.updo.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(590, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 76;
            this.label3.Text = "Comenzales";
            // 
            // lb3
            // 
            this.lb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(498, 48);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(52, 28);
            this.lb3.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 74;
            this.label2.Text = "Numero de mesa:";
            // 
            // txtCaja
            // 
            this.txtCaja.Location = new System.Drawing.Point(321, 51);
            this.txtCaja.Name = "txtCaja";
            this.txtCaja.Size = new System.Drawing.Size(78, 20);
            this.txtCaja.TabIndex = 73;
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(269, 54);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(46, 13);
            this.lblProveedor.TabIndex = 72;
            this.lblProveedor.Text = "N# Caja";
            // 
            // cmbMesero
            // 
            this.cmbMesero.FormattingEnabled = true;
            this.cmbMesero.Location = new System.Drawing.Point(71, 51);
            this.cmbMesero.Name = "cmbMesero";
            this.cmbMesero.Size = new System.Drawing.Size(181, 21);
            this.cmbMesero.TabIndex = 70;
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(23, 54);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(42, 13);
            this.lblUnidad.TabIndex = 71;
            this.lblUnidad.Text = "Mesero";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(914, 34);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(73, 38);
            this.btnSalir.TabIndex = 69;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-23, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1036, 34);
            this.label1.TabIndex = 67;
            this.label1.Text = "Control de Pedidos\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.AllowUserToDeleteRows = false;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(18, 121);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(419, 130);
            this.dgvInventario.TabIndex = 82;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 272);
            this.panel1.TabIndex = 83;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCantidadInsumo);
            this.panel2.Controls.Add(this.lblProducto);
            this.panel2.Controls.Add(this.dgvInventario);
            this.panel2.Location = new System.Drawing.Point(522, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 272);
            this.panel2.TabIndex = 84;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 227);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-46, 528);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1102, 91);
            this.pictureBox1.TabIndex = 86;
            this.pictureBox1.TabStop = false;
            // 
            // btnModificarInsumo
            // 
            this.btnModificarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnModificarInsumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificarInsumo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnModificarInsumo.Location = new System.Drawing.Point(459, 206);
            this.btnModificarInsumo.Name = "btnModificarInsumo";
            this.btnModificarInsumo.Size = new System.Drawing.Size(58, 25);
            this.btnModificarInsumo.TabIndex = 88;
            this.btnModificarInsumo.Text = "Modificar";
            this.btnModificarInsumo.UseVisualStyleBackColor = false;
            // 
            // btnEliminarInsumo
            // 
            this.btnEliminarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnEliminarInsumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarInsumo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEliminarInsumo.Location = new System.Drawing.Point(458, 253);
            this.btnEliminarInsumo.Name = "btnEliminarInsumo";
            this.btnEliminarInsumo.Size = new System.Drawing.Size(59, 25);
            this.btnEliminarInsumo.TabIndex = 89;
            this.btnEliminarInsumo.Text = "Eliminar";
            this.btnEliminarInsumo.UseVisualStyleBackColor = false;
            // 
            // btnAgregarInsumo
            // 
            this.btnAgregarInsumo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnAgregarInsumo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAgregarInsumo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarInsumo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAgregarInsumo.Location = new System.Drawing.Point(459, 156);
            this.btnAgregarInsumo.Name = "btnAgregarInsumo";
            this.btnAgregarInsumo.Size = new System.Drawing.Size(59, 25);
            this.btnAgregarInsumo.TabIndex = 87;
            this.btnAgregarInsumo.Text = "Agregar";
            this.btnAgregarInsumo.UseVisualStyleBackColor = false;
            // 
            // txtCantidadInsumo
            // 
            this.txtCantidadInsumo.Location = new System.Drawing.Point(118, 64);
            this.txtCantidadInsumo.Name = "txtCantidadInsumo";
            this.txtCantidadInsumo.Size = new System.Drawing.Size(109, 20);
            this.txtCantidadInsumo.TabIndex = 83;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(33, 67);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 84;
            this.lblProducto.Text = "Producto";
            // 
            // frmPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 620);
            this.Controls.Add(this.btnEliminarInsumo);
            this.Controls.Add(this.btnModificarInsumo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAgregarInsumo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCaja);
            this.Controls.Add(this.lblProveedor);
            this.Controls.Add(this.cmbMesero);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPedido";
            this.Text = "frmPedido";
            ((System.ComponentModel.ISupportInitialize)(this.updo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown updo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCaja;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.ComboBox cmbMesero;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnModificarInsumo;
        private System.Windows.Forms.Button btnEliminarInsumo;
        private System.Windows.Forms.Button btnAgregarInsumo;
        private System.Windows.Forms.TextBox txtCantidadInsumo;
        private System.Windows.Forms.Label lblProducto;
    }
}