using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Pedidos
    {
        public int IdPedido { set; get; }
        public string Fecha { set; get; }
        public int IdMesa { set; get; }
        public string Nombre { set; get; }
        public int IdMesero { set; get; }

        public Pedidos() { }
        ~Pedidos() { }
        public Pedidos(string fecha, int idMesa, string nombre, int idMesero)
        {
            Fecha = fecha;
            IdMesa = idMesa;
            Nombre = nombre;
            IdMesero = idMesero;

        }
        public Pedidos(int idPedido, string fecha, int idMesa, string nombre, int idMesero)
        {
            IdPedido = idPedido;
            Fecha = fecha;
            IdMesa = idMesa;
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
    }
    }
