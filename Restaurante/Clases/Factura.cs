using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Factura
    {
        public int IdFactura { set; get; }
        public int IdPedido { set; get; }
        public int IdUsuario { set; get; }
        public decimal SubTotal { set; get; }
        public decimal Descuento { set; get; }
        public decimal Exento { set; get; }
        public decimal Sub15 { set; get; }
        public decimal Sub18 { set; get; }
        public decimal Total { set; get; }

        public Factura(int idPedido, int idUsuario, decimal subTotal, decimal descuento, decimal exento, decimal sub15, decimal sub18, decimal total)
        {
            IdPedido = idPedido;
            IdUsuario = idUsuario;
            SubTotal = subTotal;
            Descuento = descuento;
            Exento = exento;
            Sub15 = sub15;
            Sub18 = sub18;
            Total = total;
        }

        public Factura(){}
        ~Factura() { }
        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_AgregarFactura", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Inventario");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

    }
}
