namespace Restaurante
{
    partial class frmResumenCaja
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResumenCaja));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtpHoraInicialResumenCaja = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicial = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbResuemnCaja = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalirAperturarCaja = new System.Windows.Forms.Button();
            this.btnBuscarResumenCaja = new System.Windows.Forms.Button();
            this.cbProductoResumenCaja = new System.Windows.Forms.ComboBox();
            this.lblProductoResumenCaja = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlTitulo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbResuemnCaja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(310, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // dtpHoraInicialResumenCaja
            // 
            this.dtpHoraInicialResumenCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpHoraInicialResumenCaja.Location = new System.Drawing.Point(82, 35);
            this.dtpHoraInicialResumenCaja.Name = "dtpHoraInicialResumenCaja";
            this.dtpHoraInicialResumenCaja.Size = new System.Drawing.Size(188, 22);
            this.dtpHoraInicialResumenCaja.TabIndex = 1;
            this.dtpHoraInicialResumenCaja.Value = new System.DateTime(2018, 11, 6, 0, 0, 0, 0);
            // 
            // lblHoraInicial
            // 
            this.lblHoraInicial.AutoSize = true;
            this.lblHoraInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraInicial.Location = new System.Drawing.Point(18, 39);
            this.lblHoraInicial.Name = "lblHoraInicial";
            this.lblHoraInicial.Size = new System.Drawing.Size(46, 16);
            this.lblHoraInicial.TabIndex = 2;
            this.lblHoraInicial.Text = "Fecha";
            // 
            // gbResuemnCaja
            // 
            this.gbResuemnCaja.Controls.Add(this.button1);
            this.gbResuemnCaja.Controls.Add(this.comboBox1);
            this.gbResuemnCaja.Controls.Add(this.label2);
            this.gbResuemnCaja.Controls.Add(this.btnSalirAperturarCaja);
            this.gbResuemnCaja.Controls.Add(this.btnBuscarResumenCaja);
            this.gbResuemnCaja.Controls.Add(this.cbProductoResumenCaja);
            this.gbResuemnCaja.Controls.Add(this.lblProductoResumenCaja);
            this.gbResuemnCaja.Controls.Add(this.lblHoraInicial);
            this.gbResuemnCaja.Controls.Add(this.dtpHoraInicialResumenCaja);
            this.gbResuemnCaja.Location = new System.Drawing.Point(12, 73);
            this.gbResuemnCaja.Name = "gbResuemnCaja";
            this.gbResuemnCaja.Size = new System.Drawing.Size(292, 348);
            this.gbResuemnCaja.TabIndex = 4;
            this.gbResuemnCaja.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(82, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 25);
            this.button1.TabIndex = 56;
            this.button1.Text = "Salidas Varias";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 131);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 32);
            this.label2.TabIndex = 54;
            this.label2.Text = "Servicio\r\nPublico";
            // 
            // btnSalirAperturarCaja
            // 
            this.btnSalirAperturarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnSalirAperturarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalirAperturarCaja.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSalirAperturarCaja.Location = new System.Drawing.Point(161, 297);
            this.btnSalirAperturarCaja.Name = "btnSalirAperturarCaja";
            this.btnSalirAperturarCaja.Size = new System.Drawing.Size(75, 25);
            this.btnSalirAperturarCaja.TabIndex = 53;
            this.btnSalirAperturarCaja.Text = "Salir";
            this.btnSalirAperturarCaja.UseVisualStyleBackColor = false;
            this.btnSalirAperturarCaja.Click += new System.EventHandler(this.btnSalirAperturarCaja_Click);
            // 
            // btnBuscarResumenCaja
            // 
            this.btnBuscarResumenCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(76)))), ((int)(((byte)(126)))));
            this.btnBuscarResumenCaja.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarResumenCaja.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnBuscarResumenCaja.Location = new System.Drawing.Point(41, 297);
            this.btnBuscarResumenCaja.Name = "btnBuscarResumenCaja";
            this.btnBuscarResumenCaja.Size = new System.Drawing.Size(75, 25);
            this.btnBuscarResumenCaja.TabIndex = 11;
            this.btnBuscarResumenCaja.Text = "Buscar";
            this.btnBuscarResumenCaja.UseVisualStyleBackColor = false;
            // 
            // cbProductoResumenCaja
            // 
            this.cbProductoResumenCaja.FormattingEnabled = true;
            this.cbProductoResumenCaja.Location = new System.Drawing.Point(82, 85);
            this.cbProductoResumenCaja.Name = "cbProductoResumenCaja";
            this.cbProductoResumenCaja.Size = new System.Drawing.Size(188, 21);
            this.cbProductoResumenCaja.TabIndex = 6;
            // 
            // lblProductoResumenCaja
            // 
            this.lblProductoResumenCaja.AutoSize = true;
            this.lblProductoResumenCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductoResumenCaja.Location = new System.Drawing.Point(18, 86);
            this.lblProductoResumenCaja.Name = "lblProductoResumenCaja";
            this.lblProductoResumenCaja.Size = new System.Drawing.Size(62, 16);
            this.lblProductoResumenCaja.TabIndex = 5;
            this.lblProductoResumenCaja.Text = "Producto";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 436);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(684, 79);
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            // 
            // pnlTitulo
            // 
            this.pnlTitulo.Controls.Add(this.label1);
            this.pnlTitulo.Location = new System.Drawing.Point(155, 5);
            this.pnlTitulo.Name = "pnlTitulo";
            this.pnlTitulo.Size = new System.Drawing.Size(337, 62);
            this.pnlTitulo.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(52, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Resumen de Caja";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Location = new System.Drawing.Point(640, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(29, 29);
            this.btnSalir.TabIndex = 51;
            this.btnSalir.TabStop = false;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmResumenCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 514);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pnlTitulo);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gbResuemnCaja);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(100, 0);
            this.Name = "frmResumenCaja";
            this.Text = "Resumen de Caja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbResuemnCaja.ResumeLayout(false);
            this.gbResuemnCaja.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlTitulo.ResumeLayout(false);
            this.pnlTitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dtpHoraInicialResumenCaja;
        private System.Windows.Forms.Label lblHoraInicial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbResuemnCaja;
        private System.Windows.Forms.ComboBox cbProductoResumenCaja;
        private System.Windows.Forms.Label lblProductoResumenCaja;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBuscarResumenCaja;
        private System.Windows.Forms.Panel pnlTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSalirAperturarCaja;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
    }
}