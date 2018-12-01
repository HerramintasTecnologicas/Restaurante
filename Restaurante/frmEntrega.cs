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
    public partial class frmEntrega : Form
    {
        public frmEntrega(int mesa)
        {
            this.id2=mesa;
        InitializeComponent();
        }
        public int id2;
        private void btnSalir_Click(object sender, EventArgs e)
        {
            
        }
        public int mesa1;
        public int id;
        public int idMesero;
        public int estado;
        
        /// <summary>
        /// Se llena el text de mesa
        /// </summary>
        private void CargarCMBPedido()
        {
            Clases.Pedidos pedidos = new Clases.Pedidos();
            pedidos.ObtenerPedido(id2,1);
            id = pedidos.IdPedido;
            idMesero = pedidos.IdMesero;
            estado = pedidos.Estado;
            CargarCMBMesero(idMesero);
            CargarDGWPedido(id);


        }
        private void CargarDGWPedido(int id4)
        {
            try
            {
                dgvPedido.DataSource = Clases.Detalle.GetDataView(id4);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
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
        private void CargarCMBMesero(int id3)
        {

            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "SELECT * FROM Restaurante.Meseros WHERE id= " + id3 + ";";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                // Establecer la conexión
                conexion.Abrir();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    lblMesero.Items.Add(Convert.ToString(rdr[2]));
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
        /// <summary>
        /// Se encarga de darle estilos a los grid
        /// </summary>
        //private void dgwPedidoEstilo(DataGridView dgw)
        //{
        //    dgw.DefaultCellStyle.BackColor = Color.LightBlue;
        //    dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        //}


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEntrega_Load(object sender, EventArgs e)
        {

            CargarCMBPedido();
            CargarCMBMesa();
        }
        string fecha1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha1 = DateTime.Now.ToString();
            lblFecha.Text = fecha1;
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (idgrid != 0)
            {


                dgvPedido.Rows[idgrid].DefaultCellStyle.BackColor = Color.Green;
            }
        }
         public int idgrid;

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                idgrid = e.RowIndex;
                dgvPedido.Select();
            }
        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            if (idgrid != 0)
            {


                dgvPedido.Rows[idgrid].DefaultCellStyle.BackColor = Color.Orange;
            }

        }
    }
}
