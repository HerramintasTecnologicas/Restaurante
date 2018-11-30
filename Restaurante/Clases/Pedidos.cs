using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace Restaurante.Clases
{
    class Pedidos
    {
        public int IdPedido { set; get; }
        public string Fecha { set; get; }
        public int IdMesa { set; get; }
        public string RTN { set; get; }
        public string Nombre { set; get; }
        public int IdMesero { set; get;}
        public Pedidos() { }
        ~Pedidos() { }
        public Pedidos(string fecha, int idMesa, string rtn,string nombre, int idMesero)
        {
            Fecha = fecha;
            IdMesa = idMesa;
            RTN = rtn;
            Nombre = nombre;
            IdMesero = idMesero;

        }
        public Pedidos(int idPedido, string fecha, int idMesa,string rtn, string nombre, int idMesero)
        {
            IdPedido = idPedido;
            Fecha = fecha;
            IdMesa = idMesa;
            RTN = rtn;
            Nombre = nombre;
            IdMesero = idMesero;
        }
        public Pedidos(int idPedido) { IdPedido = idPedido; }

        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_AgregarPedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("fecha", SqlDbType.NVarChar,19));
                cmd.Parameters["fecha"].Value = Fecha;
                cmd.Parameters.Add(new SqlParameter("idMesa", SqlDbType.Int));
                cmd.Parameters["idMesa"].Value = IdMesa;
                cmd.Parameters.Add(new SqlParameter("RTN", SqlDbType.NVarChar,14));
                cmd.Parameters["RTN"].Value = RTN;
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar,50));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("idMesero", SqlDbType.Int));
                cmd.Parameters["idMesero"].Value = IdMesero;

                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Pedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Modificar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_ModificarPedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                cmd.Parameters["id"].Value = IdPedido;
                cmd.Parameters.Add(new SqlParameter("Fecha", SqlDbType.NVarChar,19));
                cmd.Parameters["Fecha"].Value = Fecha;
                cmd.Parameters.Add(new SqlParameter("idMesa", SqlDbType.Int));
                cmd.Parameters["idMesa"].Value = IdMesa;
                cmd.Parameters.Add(new SqlParameter("RTN", SqlDbType.NVarChar,14));
                cmd.Parameters["RTN"].Value = RTN;
                cmd.Parameters.Add(new SqlParameter("NombreCliente", SqlDbType.NVarChar,50));
                cmd.Parameters["NombreCliente"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("idMesero", SqlDbType.Int));
                cmd.Parameters["idMesero"].Value = IdMesero;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Pedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        public void Eliminar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarPedido", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                cmd.Parameters["id"].Value = IdPedido;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Pedido");
            }
            finally
            {
                conexion.Cerrar();
            }
        }
        public static DataView GetDataView()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            string sql = @"SELECT   Restaurante.Pedidos.id                      as Código,
                                    Restaurante.Inventario.descripcion          as Nombre,
                                    Restaurante.Inventario.costo                as Costo,
                                    Restaurante.Inventario.precioVenta          as PrecioVenta,
                                    Restaurante.Inventario.cantidad             as Cantidad,
                                    Restaurante.Inventario.cantidadMinima       as CantidadMin,
                                    Restaurante.CategoriaProducto.descripcion   as Categoría,
                                    Restaurante.TipoProducto.nombre             as TipoProducto,
                                    Restaurante.Proveedores.nombre              as Proveedor
                            FROM Restaurante.Pedidos
                            INNER JOIN Restaurante.Inventario
                            ON Restaurante.Proveedores.idProveedor = Restaurante.Inventario.idProveedor
                            INNER JOIN Restaurante.TipoProducto
                            ON Restaurante.TipoProducto.idTipoProducto = Restaurante.Inventario.idTipoProducto
                            INNER JOIN Restaurante.CategoriaProducto
                            ON Restaurante.CategoriaProducto.idCategoria = Restaurante.Inventario.idCategoria";

            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Restaurante.Pedidos");
                DataTable dt = ds.Tables["Restaurante.Pedidos"];
                DataView dv = new DataView(dt,
                    "",
                    "Código",
                    DataViewRowState.Unchanged);
                return dv;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Cerrar();
            }

        }
    }
}
