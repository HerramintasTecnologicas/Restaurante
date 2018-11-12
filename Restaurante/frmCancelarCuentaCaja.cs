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
    public partial class frmCancelarCuentaCaja : Form
    {
        public frmCancelarCuentaCaja()
        {
            InitializeComponent();
        }

        private void btnPagoEnDolares_Click(object sender, EventArgs e)
        {
            try
            {
                gbRegistrarCobroLempirasCancelarCuentaCaja.Hide();
                gbRegistrarCobroDolaresCancelarCuentaCaja.Show();
                gbRegistrarCobroDolaresCancelarCuentaCaja.BringToFront();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPagoLempiras_Click(object sender, EventArgs e)
        {
            try
            {
                gbRegistrarCobroDolaresCancelarCuentaCaja.Hide();
                gbRegistrarCobroLempirasCancelarCuentaCaja.Show();
                gbRegistrarCobroLempirasCancelarCuentaCaja.BringToFront();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSalirCobroDolar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirCancelarCuentaCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalirAperturarCaja_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
