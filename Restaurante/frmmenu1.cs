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
    public partial class frmmenu1 : Form
    {
        public int id2;
        public frmmenu1(int mesa)
        {

            InitializeComponent();
            this.id2 = mesa;
        }

        private void frmmenu1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            frmPedido pedido = new frmPedido(id2);
            pedido.ShowDialog();
        }
    }
}
