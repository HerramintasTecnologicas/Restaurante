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
        public frmPedido(int mesa)
        {
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
            DataTable dt = new DataTable();
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = "SELECT estado FROM Restaurante.Mesas WHERE "+ id+" =id ";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            lblMesa.Text = Convert.ToString(dt);
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
            try
            {
                dgvInventario.DataSource = Clases.Inventario.GetDataView1(3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
