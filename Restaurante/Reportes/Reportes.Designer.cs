namespace Restaurante.Reportes
{
    partial class Reportes
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.pedidoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Restaurante.DataSet.DataSet1();
            this.detalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pedidoTableAdapter = new Restaurante.DataSet.DataSet1TableAdapters.pedidoTableAdapter();
            this.detalleTableAdapter = new Restaurante.DataSet.DataSet1TableAdapters.DetalleTableAdapter();
            this.pedidoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pedidoBindingSource
            // 
            this.pedidoBindingSource.DataMember = "pedido";
            this.pedidoBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleBindingSource
            // 
            this.detalleBindingSource.DataMember = "Detalle";
            this.detalleBindingSource.DataSource = this.dataSet1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Pedido";
            reportDataSource1.Value = this.pedidoBindingSource1;
            reportDataSource2.Name = "Detalle";
            reportDataSource2.Value = this.detalleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Restaurante.Reportes.Comanda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(495, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // pedidoTableAdapter
            // 
            this.pedidoTableAdapter.ClearBeforeFill = true;
            // 
            // detalleTableAdapter
            // 
            this.detalleTableAdapter.ClearBeforeFill = true;
            // 
            // pedidoBindingSource1
            // 
            this.pedidoBindingSource1.DataMember = "pedido";
            this.pedidoBindingSource1.DataSource = this.dataSet1;
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.Load += new System.EventHandler(this.Reportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pedidoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSet.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource pedidoBindingSource;
        private DataSet.DataSet1TableAdapters.pedidoTableAdapter pedidoTableAdapter;
        private System.Windows.Forms.BindingSource detalleBindingSource;
        private DataSet.DataSet1TableAdapters.DetalleTableAdapter detalleTableAdapter;
        private System.Windows.Forms.BindingSource pedidoBindingSource1;
    }
}