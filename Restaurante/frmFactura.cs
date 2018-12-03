using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Restaurante
{
    public partial class frmFactura : Form
    {
        public frmFactura(int mesa)
        {

            this.id2 = mesa;
            InitializeComponent();
        }
        public int id2;
        public int Color1 { get; set; }
        public int id;
        public string rtn;
        public string nombre;
        public int idMesero;
        public int estado;

        /// <summary>
        /// Se llena el text de mesa
        /// </summary>
        private void CargarCMBMesa()
        {

            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "SELECT * FROM Restaurante.Mesas WHERE id= " + id2 + ";";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                // Establecer la conexión
                conexion.Abrir();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lblMesa.Items.Add(Convert.ToString(rdr[1]));
                    
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "¡Detalles de la excepción!");
            }
            finally
            {
                // Cerrar la conexión
                conexion.Cerrar();
            }
            //lblMesa.Text = Convert.ToString(cmd);
        }
        private void CargarCMBPedido()
        {
            Clases.Pedidos pedidos = new Clases.Pedidos();
            pedidos.ObtenerPedido(id2, 2);
            id = pedidos.IdPedido;

            rtn = pedidos.RTN;
            nombre = pedidos.Nombre;
            idMesero = pedidos.IdMesero;
            estado = pedidos.Estado;
            //CargarCMBMesero(idMesero);
            CargarDGWPedido(id);


        }

        private void frmFactura_Load(object sender, EventArgs e)
        {
            Encabezado();
            CargarCMBPedido();
        }
        private void CargarDGWPedido(int id)
        {
            try
            {
                MessageBox.Show(id.ToString());
                dgvDetalle.DataSource = Clases.Detalle.GetDataView1(id);

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
                if (hora >= 12 && hora < 18)
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
            if (id > 1 && Color1!=4)
            {
                Color1 = estado;
            }
            else
            {
                Color1 = 0;
            }
            DialogResult = DialogResult.OK;
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

        private void button3_Click(object sender, EventArgs e)
        {
            Color1 = 4;
        }
    }
}
