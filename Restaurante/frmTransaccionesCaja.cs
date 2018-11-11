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
    public partial class frmTransaccionesCaja : Form
    {
        public frmTransaccionesCaja()
        {
            InitializeComponent();
        }

        private void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            frmAperturaCaja ac = new frmAperturaCaja();
            ac.Show();
        }

        private void btnCierreCaja_Click(object sender, EventArgs e)
        {
            frmCierreCaja cc = new frmCierreCaja();
            cc.Show();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            frmPagosCaja pc = new frmPagosCaja();
            pc.Show();
        }

        private void btnSalidasCaja_Click(object sender, EventArgs e)
        {
            frmSalidasCaja sc = new frmSalidasCaja();
            sc.Show();
        }

        private void btnCancelarCuenta_Click(object sender, EventArgs e)
        {
            frmCancelarCuentaCaja cac = new frmCancelarCuentaCaja();
            cac.Show();
        }

        private void btnCambioDolar_Click(object sender, EventArgs e)
        {
            frmCambioDolar cd = new frmCambioDolar();
            cd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmResumenCaja rc = new frmResumenCaja();
            rc.Show();
        }
    }
}
