﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Restaurante.Clases
{
    class Mesero
    {
        //Se encapsulan las variables a usar
        public int Id { set; get; }
        public string Identidad { set; get; }
        public string Nombre { set; get; }
        public string Apellido { set; get; }
        //Se define un constructor
        public Mesero() { }
        //Se define el destructor
        ~Mesero() { }
        //Constructor para insertar un mesero
        public Mesero(string identidad, string nombre, string apellido)
        {
            Identidad = identidad;
            Nombre = nombre;
            Apellido = apellido;

        }
        //Constructor para modificar un mesero
        public Mesero(int id, string identidad, string nombre, string apellido)
        {
            Id = id;
            Identidad = identidad;
            Nombre = nombre;
            Apellido = apellido;
        }
        //Constructor para eliminar un mesero
        public Mesero(int id)
        {
            Id = id;
        }
        //Funcion para llamar el store Procedure y asignar los parametros que insertaremos
        public void Agregar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_AgregarMesero", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                //Se abre la conexion
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("identidad", SqlDbType.NVarChar, 15));
                cmd.Parameters["identidad"].Value = Identidad;
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 25));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("apellido", SqlDbType.NVarChar, 25));
                cmd.Parameters["apellido"].Value = Apellido;
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                //Cuando ocurre un error se llama la clase excepcion que dira que fue cerca de meseros donde ocurrio ese error
                throw new Clases.Excepcion(ex.Message, ex, "Clase_Mesero");
            }
            finally
            {
                //Se cierra la conexion
                conexion.Cerrar();
            }
        }
        //Funcion para llamar el store Procedure y asignar los parametros que desean modificar
        public void Modificar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_ModificarMesero", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                cmd.Parameters["id"].Value = Id;
                cmd.Parameters.Add(new SqlParameter("identidad", SqlDbType.NVarChar, 15));
                cmd.Parameters["identidad"].Value = Identidad;
                cmd.Parameters.Add(new SqlParameter("nombre", SqlDbType.NVarChar, 25));
                cmd.Parameters["nombre"].Value = Nombre;
                cmd.Parameters.Add(new SqlParameter("apellido", SqlDbType.NVarChar, 25));
                cmd.Parameters["apellido"].Value = Apellido;
                cmd.ExecuteNonQuery();

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
        //Funcion para llamar el store Procedure para eliminar un mesero deseado
        public void Eliminar()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            SqlCommand cmd = new SqlCommand("SP_EliminarMesero", conexion.conexion);
            cmd.CommandType = CommandType.StoredProcedure;
            try
            {
                conexion.Abrir();
                cmd.Parameters.Add(new SqlParameter("id", SqlDbType.Int));
                cmd.Parameters["id"].Value = Id;
                cmd.ExecuteNonQuery();
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
        //Funcion para Consultar los datos de un mesero determinado
        public void ObtenerMesero(int id)
        {
            Conexión conexion = new Conexión();
            string sql = @"SELECT id, identidad, nombre, apellido FROM Restaurante.Meseros WHERE id = '" + id + "';";
            SqlCommand cmd = new SqlCommand(sql, conexion.conexion);
            try
            {
                conexion.Abrir();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Id = dr.GetInt32(0);
                    Identidad = dr.GetString(1);
                    Nombre = dr.GetString(2);
                    Apellido = dr.GetString(3);
                }
            }
            catch (SqlException ex)
            {
                throw new Clases.Excepcion(
                   String.Format("{0} \n\n{1}",
                   "no podemos obtener la informacion del Mesero", ex.Message), ex, "Clase_Meseros"); ;
            }
            finally
            {
                conexion.Cerrar();
            }

        }
        //Se aplican las funciones de ADO.NET donde usamos un dataAdapter
        public static DataView GetDataView()
        {
            Clases.Conexión conexion = new Clases.Conexión();
            //Se traen todos los datos de la tabla meseros y los almacena la variable sql
            string sql = @"SELECT   Restaurante.Meseros.id          as Código,
                                    Restaurante.Meseros.identidad   as Identidad,
                                    Restaurante.Meseros.nombre      as Mesero, 
                                    Restaurante.Meseros.apellido    as Apellido
                            FROM Restaurante.Meseros";
            try
            {
                SqlDataAdapter data = new SqlDataAdapter();
                data.SelectCommand = new SqlCommand(sql, conexion.conexion);
                DataSet ds = new DataSet();
                data.Fill(ds, "Restaurante.Meseros");
                DataTable dt = ds.Tables["Restaurante.Meseros"];
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