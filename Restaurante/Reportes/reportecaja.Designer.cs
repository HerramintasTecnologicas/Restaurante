namespace Restaurante.Reportes
{
    partial class reportecaja
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Inventario = new Restaurante.Reportes.Inventario();
            this.inventario1 = new Restaurante.DataSet.Inventario();
            this.inventario1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cajaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cajaTableAdapter = new Restaurante.DataSet.InventarioTableAdapters.CajaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CajaTODO";
            reportDataSource1.Value = this.cajaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Restaurante.Reportes.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(533, 583);
            this.reportViewer1.TabIndex = 0;
            // 
            // Inventario
            // 
            this.Inventario.ClientSize = new System.Drawing.Size(576, 503);
            this.Inventario.Location = new System.Drawing.Point(1522, 156);
            this.Inventario.Name = "Inventario";
            this.Inventario.Text = "Inventario";
            this.Inventario.Visible = false;
            this.Inventario.Load += new System.EventHandler(this.Inventario_Load);
            // 
            // inventario1
            // 
            this.inventario1.DataSetName = "Inventario";
            this.inventario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventario1BindingSource
            // 
            this.inventario1BindingSource.DataSource = this.inventario1;
            this.inventario1BindingSource.Position = 0;
            // 
            // cajaBindingSource
            // 
            this.cajaBindingSource.DataMember = "Caja";
            this.cajaBindingSource.DataSource = this.inventario1BindingSource;
            // 
            // cajaTableAdapter
            // 
            this.cajaTableAdapter.ClearBeforeFill = true;
            // 
            // reportecaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 583);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportecaja";
            this.Text = "reportecaja";
            this.Load += new System.EventHandler(this.reportecaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cajaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Inventario Inventario;
        private DataSet.Inventario inventario1;
        private System.Windows.Forms.BindingSource inventario1BindingSource;
        private System.Windows.Forms.BindingSource cajaBindingSource;
        private DataSet.InventarioTableAdapters.CajaTableAdapter cajaTableAdapter;
    }
}