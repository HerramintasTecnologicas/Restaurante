using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante
{
    public partial class frmFactura : Form
    {
        public frmFactura()
        {
            InitializeComponent();
        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            Encabezado();
        }
        private void CargarDGWPedido(int id)
        {
            try
            {
                MessageBox.Show(id.ToString());
                dgvPedido.DataSource = Clases.Detalle.GetDataView(id);

                dgvPedido.SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                //dgvPedidos.SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Encabezado()
        {

            lblSetFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            int hora = DateTime.Now.Hour;
            if (hora > 0 && hora < 12)
            {
                lblSetJornada.Text = "Matutina";
            }
            else
            {
                if (hora >= 12 && hora < 6)
                {
                    lblSetJornada.Text = "Vespertina";
                }
                else
                {
                    lblSetJornada.Text = "Nocturna";
                }
            }

        }

        private void dgvPedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
