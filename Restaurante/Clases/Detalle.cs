using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Detalle
    {
        public int IdDetallePedido { set; get; }
        public int IdPedido { set; get; }
        public int IdInventario { set; get; }
        public int Cantidad { set; get; }
        public decimal SubTotal { set; get; }
        

        public Detalle() { }
        ~Detalle() { }
        public Detalle(int idPedido, int idInventario, int cantidad,decimal subTotal)
        {
            IdPedido = idPedido;
            IdInventario = idInventario;
            Cantidad = cantidad;
            SubTotal = subTotal;
        }
        public Detalle(int idDetallePedido, int idPedido, int idInventario, int cantidad,decimal subTotal)
        {
            IdDetallePedido = idDetallePedido;
            IdPedido = idPedido;           
            IdInventario = idInventario;
            Cantidad = cantidad;
            SubTotal = subTotal;
        }
        public Detalle(int idDetallePedido) { IdDetallePedido = idDetallePedido; }
        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_AgregarDetallePedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idPedido", SqlDbType.Int));
                cmd.Parameters["idPedido"].Value = IdPedido;
                cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
                cmd.Parameters["idInventario"].Value = IdInventario;
                cmd.Parameters.Add(new SqlParameter("cantidad", SqlDbType.Int));
                cmd.Parameters["cantidad"].Value = Cantidad;
                cmd.Parameters.Add(new SqlParameter("subTotal", SqlDbType.Decimal));
                cmd.Parameters["subTotal"].Value = SubTotal;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_DetallePedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_ModificarDetallePedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idDetallePedido", SqlDbType.Int));
                cmd.Parameters["idDetallePedido"].Value = IdDetallePedido;
                cmd.Parameters.Add(new SqlParameter("idPedido", SqlDbType.Int));
                cmd.Parameters["idPedido"].Value = IdPedido;
                cmd.Parameters.Add(new SqlParameter("idInventario", SqlDbType.Int));
                cmd.Parameters["idInventario"].Value = IdInventario;
                cmd.Parameters.Add(new SqlParameter("Cantidad", SqlDbType.Int));
                cmd.Parameters["Cantidad"].Value = Cantidad;
                cmd.Parameters.Add(new SqlParameter("subTotal", SqlDbType.Decimal));
                cmd.Parameters["subTotal"].Value = SubTotal;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_DetallePedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarDetallePedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("idDetallePedido", SqlDbType.Int));
                cmd.Parameters["idDetallePedido"].Value = IdDetallePedido;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_DetallePedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }
    }
}
