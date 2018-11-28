using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Restaurante.Clases
{
    class Caja
    {
        public int Id { get; set; }
        public decimal Apertura { get; set; }
        public decimal Cierre { get; set; }
        public decimal Dolares { get; set; }
        public decimal Pos { get; set; }
        public int Fiveh { get; set; }
        public int Hundred { get; set; }
        public int Fifty { get; set; }
        public int Twenty { get; set; }
        public int Ten { get; set; }
        public int Five { get; set; }
        public int Two { get; set; }
        public int One { get; set; }
        public string Fecha { get; set; }
        public int DetalleCaja { get; set; }

        public Caja() { }

        ~Caja() { }

        public Caja(int detalleCaja, decimal apertura, string fecha)
        {
            DetalleCaja = detalleCaja;
            Apertura = apertura;
            Fecha = fecha;
        }

        public Caja(int id, int detalleCaja, decimal apertura, string fecha)
        {
            Id = id;
            DetalleCaja = detalleCaja;
            Apertura = apertura;
            Fecha = fecha;
        }

        public Caja(int detalleCaja, decimal cierre, string fecha, decimal dolares, decimal pos, int fiveh,
                    int hundred, int fifty, int twenty, int ten, int five, int two, int one)
        {
            DetalleCaja = detalleCaja;
            Cierre = cierre;
            Fecha = fecha;
            Dolares = dolares;
            Pos = pos;
            Fiveh = fiveh;
            Hundred = hundred;
            Fifty = fifty;
            Twenty = twenty;
            Ten = ten;
            Five = five;
            Two = two;
            One = one;
        }

        public Caja(int id, int detalleCaja, decimal apertura, string fecha, decimal dolares, decimal pos, int fiveh,
                    int hundred, int fifty, int twenty, int ten, int five, int two, int one)
        {
            Id = id;
            DetalleCaja = detalleCaja;
            Apertura = apertura;
            Fecha = fecha;
            Dolares = dolares;
            Pos = pos;
            Fiveh = fiveh;
            Hundred = hundred;
            Fifty = fifty;
            Twenty = twenty;
            Ten = ten;
            Five = five;
            Two = two;
            One = one;
        }

        public void AgregarApertura()
        {
            Clases.Conexión conexión = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_Agregar_AperturaCaja", conexión.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                //Abrir Conexion
                conexión.Abrir();
                cmd.Parameters.Add(new SqlParameter("apertura", SqlDbType.Decimal, 18));
                cmd.Parameters["apertura"].Value = Apertura;
                cmd.Parameters.Add(new SqlParameter("idDetalleCaja", SqlDbType.Int));
                cmd.Parameters["idDetalleCaja"].Value = DetalleCaja;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase Caja");
            }
            finally
            {
                //Cerrar conexion
                conexión.Cerrar();
            }
        }

        public void AgregarCierre()
        {
            Clases.Conexión conexión = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_Agregar_CierreCaja", conexión.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                cmd.Parameters.Add(new SqlParameter("cierre", SqlDbType.Decimal));
                cmd.Parameters["cierre"].Value = Cierre;
                cmd.Parameters.Add(new SqlParameter("dolares", SqlDbType.Decimal));
                cmd.Parameters["dolares"].Value = Dolares;
                cmd.Parameters.Add(new SqlParameter("POS", SqlDbType.Decimal));
                cmd.Parameters["POS"].Value = Pos;
                cmd.Parameters.Add(new SqlParameter("quinientos", SqlDbType.Int));
                cmd.Parameters["quinientos"].Value = Fiveh;
                cmd.Parameters.Add(new SqlParameter("cien", SqlDbType.Int));
                cmd.Parameters["cien"].Value = Hundred;
                cmd.Parameters.Add(new SqlParameter("cincuenta", SqlDbType.Int));
                cmd.Parameters["cincuenta"].Value = Fifty;
                cmd.Parameters.Add(new SqlParameter("veinte", SqlDbType.Int));
                cmd.Parameters["veinte"].Value = Twenty;
                cmd.Parameters.Add(new SqlParameter("diez", SqlDbType.Int));
                cmd.Parameters["diez"].Value = Ten;
                cmd.Parameters.Add(new SqlParameter("cinco", SqlDbType.Int));
                cmd.Parameters["cinco"].Value = Five;
                cmd.Parameters.Add(new SqlParameter("dos", SqlDbType.Int));
                cmd.Parameters["dos"].Value = Two;
                cmd.Parameters.Add(new SqlParameter("uno", SqlDbType.Int));
                cmd.Parameters["uno"].Value = One;
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase Caja");
            }
            finally
            {
                conexión.Cerrar();
            }
        }

        public static DataView GetDataView()
        {
            Clases.Conexión conexión = new Clases.Conexión();
            string sql = @"SELECT Restaurante.Caja.id                   AS Id,
                                  Restaurante.DetalleCaja.Descripcion   AS Descripcion,
                                  SELECT Restaurante.Caja.id            AS Id,
                                  Restaurante.Caja.fecha                AS Fecha,
                                  Restaurante.Caja.cierre               AS Cierre,
                                  Restaurante.Caja.dolares              AS Dolares,
                                  Restaurante.Caja.POS                  AS POS,
                                  Restaurante.Caja.quinientos           AS L500,
                                  Restaurante.Caja.cien                 AS L100,
                                  Restaurante.Caja.cincuenta            AS L50  ,
                                  Restaurante.Caja.veinte               AS L20,
                                  Restaurante.Caja.diez                 AS L10,
                                  Restaurante.Caja.cinco                AS L5,
                                  Restaurante.Caja.dos                  AS L2,
                                  Restaurante.Caja.uno                  AS L1
                           FROM Restaurante.Caja
                           INNER JOIN Restaurante.DetalleCaja
                           ON Restaurante.DetalleCaja.id = Restaurante.Caja.idDetalleCaja";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = new SqlCommand(sql, conexión.conexion);
                DataSet ds = new DataSet();
                da.Fill(ds, "Restaurante.Caja");
                DataTable dt = ds.Tables["Restaurante.Caja"];
                DataView dv = new DataView(dt, "", "id", DataViewRowState.Unchanged);
                return dv;
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(ex.Message, ex, "Clase Caja");
            }
            finally
            {
                conexión.Cerrar();
            }
        }
    }
}
