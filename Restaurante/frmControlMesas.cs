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
    public partial class frmControlMesas : Form
    {
        public frmControlMesas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mesas1_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(1);
            pedido.ShowDialog();
        }

        private void mesas2_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(2);
            pedido.ShowDialog();
        }

        private void mesas3_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(3);
            pedido.ShowDialog();
        }

        private void mesas4_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(4);
            pedido.ShowDialog();
        }

        private void mesas5_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(5);
            pedido.ShowDialog();
        }

        private void mesas6_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(6);
            pedido.ShowDialog();
        }

        private void mesas7_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(7);
            pedido.ShowDialog();
        }

        private void mesas8_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(8);
            pedido.ShowDialog();
        }

        private void mesas9_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(9);
            pedido.ShowDialog();
        }

        private void mesas10_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(10);
            pedido.ShowDialog();
        }

        private void mesas11_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(11);
            pedido.ShowDialog();
        }

        private void mesas12_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(12);
            pedido.ShowDialog();
        }

        private void mesas13_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(13);
            pedido.ShowDialog();
        }

        private void mesas14_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(14);
            pedido.ShowDialog();
        }

        private void mesas15_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(15);
            pedido.ShowDialog();
        }

        private void mesas16_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(16);
            pedido.ShowDialog();
        }
    }
}
