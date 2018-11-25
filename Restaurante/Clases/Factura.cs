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

        public Factura(int idFactura,int idPedido, int idUsuario, decimal subTotal, decimal descuento, decimal exento, decimal sub15, decimal sub18, decimal total)
        {
            IdFactura = idFactura;
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
                cmd.Parameters.Add(new SqlParameter("idFactura", SqlDbType.Int));
                cmd.Parameters["idFactura"].Value = IdFactura;
                cmd.Parameters.Add(new SqlParameter("idPedido", SqlDbType.Int));
                cmd.Parameters["idPedido"].Value = IdPedido;
                cmd.Parameters.Add(new SqlParameter("idUsuario", SqlDbType.Int));
                cmd.Parameters["idUsuario"].Value = IdUsuario;
                cmd.Parameters.Add(new SqlParameter("subTotal", SqlDbType.Decimal));
                cmd.Parameters["subTotal"].Value = SubTotal;
                cmd.Parameters.Add(new SqlParameter("descuento", SqlDbType.Decimal));
                cmd.Parameters["descuento"].Value = Descuento;
                cmd.Parameters.Add(new SqlParameter("exento", SqlDbType.Decimal));
                cmd.Parameters["exento"].Value = Exento;
                cmd.Parameters.Add(new SqlParameter("sub15", SqlDbType.Decimal));
                cmd.Parameters["sub15"].Value = Sub15;
                cmd.Parameters.Add(new SqlParameter("sub18", SqlDbType.Decimal));
                cmd.Parameters["sub18"].Value = Sub18;
                cmd.Parameters.Add(new SqlParameter("total", SqlDbType.Decimal));
                cmd.Parameters["total"].Value = Total;
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
