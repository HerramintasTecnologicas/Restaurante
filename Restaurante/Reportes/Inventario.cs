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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet1.Inventario' Puede moverla o quitarla según sea necesario.
            this.inventarioTableAdapter.Fill(this.dataSet1.Inventario);

            this.reportViewer1.RefreshReport();
        }
    }
}
