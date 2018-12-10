namespace Restaurante.Reportes
{
    partial class Inventario
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
            this.InventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventario1 = new Restaurante.DataSet.Inventario();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new Restaurante.DataSet.DataSet1();
            this.inventarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioTableAdapter = new Restaurante.DataSet.DataSet1TableAdapters.InventarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // InventarioBindingSource
            // 
            this.InventarioBindingSource.DataSource = this.inventario1;
            this.InventarioBindingSource.Position = 0;
            // 
            // inventario1
            // 
            this.inventario1.DataSetName = "Inventario";
            this.inventario1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "InventarioPro";
            reportDataSource1.Value = this.inventarioBindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Restaurante.Reportes.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(576, 503);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioBindingSource1
            // 
            this.inventarioBindingSource1.DataMember = "Inventario";
            this.inventarioBindingSource1.DataSource = this.dataSet1;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 503);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventario1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource InventarioBindingSource;
        private DataSet.Inventario inventario1;
        private DataSet.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource inventarioBindingSource1;
        private DataSet.DataSet1TableAdapters.InventarioTableAdapter inventarioTableAdapter;
    }
}