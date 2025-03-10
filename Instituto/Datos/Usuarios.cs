﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Instituto.Datos
{
    internal class Usuarios
    {
        public DataTable LoginUsuario(string loginUsuario, string passUsuario) 
        {
            SqlDataReader resultado;
            DataTable tabla = new DataTable();
            SqlConnection sqlConexion = new SqlConnection();
            try
            {
                sqlConexion = Conexion.getInstancia().crearConexion();
                //El sp se llama : spIngresoLogin
                SqlCommand comando = new SqlCommand("spIngresoLogin", sqlConexion);
                comando.CommandType = CommandType.StoredProcedure;

                //En el sp se crearon parametros Usu y Pass
                comando.Parameters.Add("Usu", SqlDbType.VarChar).Value = loginUsuario;
                comando.Parameters.Add("Pass", SqlDbType.VarChar).Value = passUsuario;

                sqlConexion.Open();

                resultado = comando.ExecuteReader();
                tabla.Load(resultado);

                return tabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                if (sqlConexion.State == ConnectionState.Open) 
                {
                    sqlConexion.Close();
                }
            }
        }
    }
}
