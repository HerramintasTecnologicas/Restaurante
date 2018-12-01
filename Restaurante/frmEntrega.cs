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
        public string rtn;
        public string nombre;
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
            
            rtn = pedidos.RTN;
            nombre = pedidos.Nombre;
            idMesero = pedidos.IdMesero;
            estado = pedidos.Estado;
            CargarCMBMesero(idMesero);
            CargarDGWPedido(id);


        }
        private void CargarDGWPedido(int id)
        {
            try
            {
                MessageBox.Show(id.ToString());
                dgvPedidos.DataSource = Clases.Detalle.GetDataView(id);
                dgvpedido.DataSource = Clases.Detalle.GetDataView(id);
                dgvPedidos.SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
                //dgvPedidos.SortedColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
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



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEntrega_Load(object sender, EventArgs e)
        {
            btnEntregado.Enabled = false;
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
            if (idgrid != -1)
            {
                dgvPedidos.Rows[idgrid].DefaultCellStyle.BackColor = Color.Green;
                desbloquear();
            }
        }
        int cuentaGrid=0;
        public void desbloquear()
        {

            for (int i = 0; i < dgvPedidos.RowCount; i++)
            {


                if (dgvPedidos.Rows[i].DefaultCellStyle.BackColor == Color.Green)
                {
                    cuentaGrid += 1;
                    if (cuentaGrid== dgvPedidos.RowCount)
                    {
                        btnEntregado.Enabled = true;
                    }
                }
            }
        }
        public int idgrid;

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
     
        }
        int tiempo=1000;

        private void btnEntregado_Click(object sender, EventArgs e)
        {

            if (idgrid != -1)
            {

                timer2.Interval =tiempo;
                dgvPedidos.Rows[idgrid].DefaultCellStyle.BackColor = Color.Orange;

                timer2.Start();

            }

        }
        public void tempo() {

            timer2.Enabled = false;
            timer2.Stop();

            dgvPedidos.Rows.RemoveAt(idgrid);
            if (dgvPedidos.Rows.Count == 0)
            {
                Clases.Restaurante.ModificarPedido(id, fecha1, id2, rtn, nombre, idMesero, 2);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                idgrid = e.RowIndex;
                dgvPedidos.Select();
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer2.Interval <= 2000)
            {
                timer2.Interval += 1000;
                //MessageBox.Show(timer2.Interval.ToString());
                
            }
            else
            {
                tempo();
                timer2.Stop();
            }
        }
    }
}
