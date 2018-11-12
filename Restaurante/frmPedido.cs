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
    public partial class frmPedido : Form
    {
        public int id2;
        public frmPedido(int mesa)
        {
            this.id2 = mesa;
            InitializeComponent();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void frmPedido_Load(object sender, EventArgs e)
        {
            CargarCMBMeseros();
            CargarCMBMesa();
        }
        private void CargarCMBMesa()
        {
          
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "SELECT * FROM Restaurante.Mesas WHERE id= "+id2+";";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                // Establecer la conexión
                conexion.Abrir();
                SqlDataReader rdr = cmd.ExecuteReader();

                //MessageBox.Show(Convert.ToString(rdr[0]));
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
        private void dgwPedidoEstilo(DataGridView dgw)
        {
            dgw.DefaultCellStyle.BackColor = Color.LightBlue;
            dgw.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }
        private void CargarCMBMeseros()
        {
            DataTable dt = new DataTable();
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "select * FROM Restaurante.Meseros";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            cmbMesero.DisplayMember = "nombre";
            cmbMesero.ValueMember = "nombre";
            cmbMesero.DataSource = dt;
        }
        private int id = 0;
        private void CargarDGWinventario()
        {
            try
            {
                dgvInventario.DataSource = Clases.Inventario.GetDataView();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Inventario inventario = new Clases.Inventario();
            inventario.ObtenerInventario1(
                Convert.ToInt32(
                    dgvInventario.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                    )
                );
            dgvInventario.Select();
            this.id = inventario.IdInventario;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Comidas
            try
            {
                dgvInventario.DataSource = Clases.Inventario.GetDataView1(1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bebidas
            try
            {
                dgvInventario.DataSource = Clases.Inventario.GetDataView1(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //licores
            try
            {
                dgvInventario.DataSource = Clases.Inventario.GetDataView1(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int m = 1;
            MessageBox.Show("Comanda enviada");
            //return m;
        }

        private void btnPreFac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prefactura imprimiendo");
        }
    }
}
