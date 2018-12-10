using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante.Reportes
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void Reportes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Detalle' Puede moverla o quitarla según sea necesario.
            this.detalleTableAdapter.Fill(this.dataSet1.Detalle);
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.pedido' Puede moverla o quitarla según sea necesario.
            this.pedidoTableAdapter.Fill(this.dataSet1.pedido);

            this.reportViewer1.RefreshReport();
        }
    }
}
