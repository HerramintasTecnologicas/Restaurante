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

   


        private void frmPedido_Load(object sender, EventArgs e)
        {
            CargarCMBMeseros();
            CargarCMBMesa();
            foreach (DataGridViewColumn c in dgvPedido.Columns)
                if (c.Name != "Cantidads") c.ReadOnly = true;
        }
        public static int mesa1;
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
                     mesa1 = Convert.ToInt16(rdr[0]);
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
        //public static int cantidad=1;
        private void dgvInventario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int cantidad = 1;
                Clases.Inventario inventario = new Clases.Inventario();
                inventario.ObtenerInventario2(
                    Convert.ToInt32(
                        dgvInventario.Rows[e.RowIndex].Cells["Código"].Value.ToString()
                        )
                    );
                dgvInventario.Select();
                this.id = inventario.IdInventario;
                decimal importe = inventario.PrecioVenta * cantidad;
               // MessageBox.Show(Convert.ToString(id));
                producto(inventario.IdInventario, inventario.Descripcion, cantidad, inventario.PrecioVenta, importe);
            }
   
        }
        public void Total()
        {
            decimal total = 0;
            for (int i = 0; i < dgvPedido.Rows.Count ; i++)
            {
                total +=  Convert.ToDecimal(dgvPedido.Rows[i].Cells["PrecioI"].Value);

            }
            txtTotal.Text = Convert.ToString(total);
        }
        public void producto(int id, string nombre, int cantidad, decimal precio, decimal importe)
        {
            int igual = 0;
            for (int i = 0; i < dgvPedido.Rows.Count; i++)
            {
                if (Convert.ToInt16(dgvPedido.Rows[i].Cells["Código"].Value)==id)
                {
                    igual = 1;
                   int codigo = Convert.ToInt16(dgvPedido.Rows[i].Cells["Código"].Value);
                    suma(i, 1);
                   
                }
            }
            if (igual == 0)
            {
                        
                dgvPedido.Rows.Add(id.ToString(), nombre, cantidad.ToString(), precio.ToString(), importe.ToString());
                Total();
            }
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
                dgvInventario.DataSource = Clases.Inventario.GetDataView1(3);
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
                dgvInventario.DataSource = Clases.Inventario.GetDataView1(2);
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
            
            try
            {
                Clases.Mesero mesero = new Clases.Mesero();
                mesero.ObteneMeseroPorNombre(cmbMesero.SelectedValue.ToString());
  
                Clases.Restaurante.AgregarPedido
                    (
                        Convert.ToString(fecha1),
                        Convert.ToInt32(mesa1),
                         txtRTN.Text,
                        txtNombre.Text,
                        mesero.Id
                    );
                MessageBox.Show("Comanda enviada");
            }
            catch (Exception ex)
            {
                Clases.Mensaje.Advertencia(ex);
            }
            //int m = 1;
            
            //return m;
        }

        private void btnPreFac_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prefactura imprimiendo");
        }

        private void btnAumentarCantidad_Click(object sender, EventArgs e)
        {
            try
            {
                suma(id3,1);
            }
            catch (Exception ex)
            {

                Clases.Mensaje.Advertencia(ex);
            }
        }
        public int id3=0;
        //Selección fila completa.
  

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvPedido != null)
            {
                //DataGridViewRow fila = dgvPedido.Rows[e.RowIndex];
                id3 = e.RowIndex;
            }
        }


        string fecha1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            fecha1 = DateTime.Now.ToString();
            lblFecha.Text = fecha1;

        }

        public void suma(int id,int op)
        {

            if (Convert.ToInt16(dgvPedido.Rows[id].Cells["Cantidads"].Value) == 1 && op==-1)
            {
                MessageBox.Show("No se puede disminuir más la cantidad");
            }
            else
            {
                dgvPedido.Rows[id].Cells["Cantidads"].Value = Convert.ToInt16(dgvPedido.Rows[id].Cells["Cantidads"].Value.ToString()) + op;
                decimal cantidad = Convert.ToDecimal(dgvPedido.Rows[id].Cells["Cantidads"].Value.ToString());
                decimal importe = Convert.ToDecimal(dgvPedido.Rows[id].Cells["PrecioU"].Value.ToString());
                dgvPedido.Rows[id].Cells["PrecioI"].Value = importe * cantidad;
                Total();
            }
        }
  

        private void btnDisminuirCantidad_Click(object sender, EventArgs e)
        {
            suma(id3,-1);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedido != null)
                {
                    dgvPedido.Rows.RemoveAt(id3);
                    Total();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede disminuir más la cantidad");
                throw ex;
            }
        }


    }
}
