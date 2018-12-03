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
        public int id;
        //private void CargarCMBPedido(int id2)
        //{
        //    Clases.Pedidos pedidos = new Clases.Pedidos();
        //    pedidos.ObtenerPedido(id2, 1);
        //    id = pedidos.IdPedido;

        //    rtn = pedidos.RTN;
        //    nombre = pedidos.Nombre;
        //    idMesero = pedidos.IdMesero;
        //    estado = pedidos.Estado;
        //    CargarCMBMesero(idMesero);
        //    CargarDGWPedido(id);


        //}
        public static Color valorColor;
        public int color;
        public void Llamar(int mesa) {

            frmmenu1 pedido = new frmmenu1(mesa);

            if (pedido.ShowDialog() == DialogResult.OK)
            {
                 color = pedido.Color1;
            }
            
        }

        public void mesa(int c, PictureBox n)
        {
            if (c == 0)
            {
                PictureBox box = new PictureBox();
                n.BackColor = Color.Transparent;
            }
            else
            {
                if (c == 1)
                {
                    n.BackColor = Color.DarkRed;
                }
                else
                {
                    if (c == 2) { n.BackColor = Color.Yellow; }
                }
            }
        }
        //string color1;
        private void mesas1_Click(object sender, EventArgs e)
        {
            Llamar(1);
            mesa(color, mesas1);
        }


        private void mesas2_Click(object sender, EventArgs e)
        {
            Llamar(2);
            mesa(color, mesas2);
        }

        private void mesas3_Click(object sender, EventArgs e)
        {
            Llamar(3);
            mesa(color, mesas3);
        }

        private void mesas4_Click(object sender, EventArgs e)
        {
            Llamar(4);
            mesa(color, mesas4);
        }

        private void mesas5_Click(object sender, EventArgs e)
        {
            Llamar(5);
            mesa(color, mesas5);
        }

        private void mesas6_Click(object sender, EventArgs e)
        {
            Llamar(6);
            mesa(color, mesas6);
        }

        private void mesas7_Click(object sender, EventArgs e)
        {
            Llamar(7);
            mesa(color, mesas7);
        }

        private void mesas8_Click(object sender, EventArgs e)
        {
            Llamar(8);
            mesa(color, mesas8);
        }

        private void mesas9_Click(object sender, EventArgs e)
        {
            Llamar(9);
            mesa(color, mesas9);
        }

        private void mesas10_Click(object sender, EventArgs e)
        {
            Llamar(10);
            mesa(color, mesas10);
        }

        private void mesas11_Click(object sender, EventArgs e)
        {
            Llamar(11);
            mesa(color, mesas11);
        }

        private void mesas12_Click(object sender, EventArgs e)
        {
            Llamar(12);
            mesa(color, mesas12);
        }

        private void mesas13_Click(object sender, EventArgs e)
        {
            Llamar(13);
            mesa(color, mesas13);
        }

        private void mesas14_Click(object sender, EventArgs e)
        {
            Llamar(14);
            mesa(color, mesas14);
        }

        private void mesas15_Click(object sender, EventArgs e)
        {
            Llamar(15);
            mesa(color, mesas15);
        }

        private void mesas16_Click(object sender, EventArgs e)
        {
            Llamar(16);
            mesa(color, mesas16);
        }

        private void mesas17_Click(object sender, EventArgs e)
        {
            Llamar(17);
            mesa(color, mesas17);
        }

        private void mesas18_Click(object sender, EventArgs e)
        {
            Llamar(18);
            mesa(color, mesas18);
        }

        private void mesas19_Click(object sender, EventArgs e)
        {
            Llamar(19);
            mesa(color, mesas19);
        }

        private void mesas20_Click(object sender, EventArgs e)
        {
            Llamar(20);
            mesa(color, mesas20);
        }

        private void mesas21_Click(object sender, EventArgs e)
        {
            Llamar(21);
            mesa(color, mesas21);
        }

        private void mesas22_Click(object sender, EventArgs e)
        {
            Llamar(22);
            mesa(color, mesas22);
        }

        private void mesas23_Click(object sender, EventArgs e)
        {
            Llamar(23);
            mesa(color, mesas23);
        }

        private void mesas24_Click(object sender, EventArgs e)
        {
            Llamar(24);
            mesa(color, mesas24);
        }

        private void mesas25_Click(object sender, EventArgs e)
        {
            Llamar(25);
            mesa(color, mesas25);
        }

        private void mesas26_Click(object sender, EventArgs e)
        {
            Llamar(26);
            mesa(color, mesas26);
        }

        private void mesas27_Click(object sender, EventArgs e)
        {
            Llamar(27);
            mesa(color, mesas27);
        }

        private void mesas28_Click(object sender, EventArgs e)
        {
            Llamar(28);
            mesa(color, mesas28);
        }

        private void mesas29_Click(object sender, EventArgs e)
        {
            Llamar(29);
            mesa(color, mesas29);
        }

        private void mesas30_Click(object sender, EventArgs e)
        {
            Llamar(30);
            mesa(color, mesas30);
        }

        private void lab6_Click(object sender, EventArgs e)
        {

        }

        private void mesas31_Click(object sender, EventArgs e)
        {
            Llamar(31);
            mesa(color, mesas31);
        }

        private void mesas32_Click(object sender, EventArgs e)
        {
            Llamar(32);
            mesa(color, mesas32);
        }

        private void mesas33_Click(object sender, EventArgs e)
        {
            Llamar(33);
            mesa(color, mesas33);
        }

        private void mesas34_Click(object sender, EventArgs e)
        {
            Llamar(34);
            mesa(color, mesas34);
        }

        private void mesas35_Click(object sender, EventArgs e)
        {
            Llamar(35);
            mesa(color, mesas35);
        }

        private void mesas36_Click(object sender, EventArgs e)
        {
            Llamar(36);
            mesa(color, mesas36);
        }

        private void mesas37_Click(object sender, EventArgs e)
        {
            Llamar(37);
            mesa(color, mesas37);
        }

        private void mesas38_Click(object sender, EventArgs e)
        {
            Llamar(38);
            mesa(color, mesas38);
        }

        private void mesas39_Click(object sender, EventArgs e)
        {
            Llamar(39);
            mesa(color, mesas39);
        }

        private void mesas40_Click(object sender, EventArgs e)
        {
            Llamar(40);
            mesa(color, mesas40);
        }

        private void mesas41_Click(object sender, EventArgs e)
        {
            Llamar(41);
            mesa(color, mesas41);
        }

        private void mesas42_Click(object sender, EventArgs e)
        {
            Llamar(42);
            mesa(color, mesas42);
        }

        private void mesas43_Click(object sender, EventArgs e)
        {
            Llamar(43);
            mesa(color, mesas43);
        }

        private void mesas44_Click(object sender, EventArgs e)
        {
            Llamar(44);
            mesa(color, mesas44);
        }

        private void mesas45_Click(object sender, EventArgs e)
        {
            Llamar(45);
            mesa(color, mesas45);
        }

        private void mesas46_Click(object sender, EventArgs e)
        {
            Llamar(46);
            mesa(color, mesas46);
        }

        private void mesas47_Click(object sender, EventArgs e)
        {
            Llamar(47);
            mesa(color, mesas47);
        }

        private void mesas48_Click(object sender, EventArgs e)
        {
            Llamar(48);
            mesa(color, mesas48);
        }

        private void mesas49_Click(object sender, EventArgs e)
        {
            Llamar(49);
            mesa(color, mesas49);
        }

        private void mesas50_Click(object sender, EventArgs e)
        {
            Llamar(50);
            mesa(color, mesas50);
        }
    }
}
