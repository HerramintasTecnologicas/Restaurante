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
    public partial class reportecaja : Form
    {
        public reportecaja()
        {
            InitializeComponent();
        }

        private void reportecaja_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'inventario1.Caja' Puede moverla o quitarla según sea necesario.
            this.cajaTableAdapter.Fill1(this.inventario1.Caja);

            this.reportViewer1.RefreshReport();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {

        }
    }
}
