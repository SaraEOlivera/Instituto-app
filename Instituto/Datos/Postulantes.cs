using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Instituto.Entidades;

namespace Instituto.Datos
{
    internal class Postulantes
    {
        public string NuevoPost(E_Postulante postulante) 
        {
            string salida;
            SqlConnection sqlConnection = new SqlConnection();
            try
            {
                sqlConnection = Conexion.getInstancia().crearConexion();
                SqlCommand comando = new SqlCommand("spNuevoPostulante", sqlConnection);
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.Add("Nombre", SqlDbType.VarChar).Value = postulante.NombrePost;
                comando.Parameters.Add("Apellido", SqlDbType.VarChar).Value = postulante.ApellidoPost;
                comando.Parameters.Add("TipoDocumento", SqlDbType.VarChar).Value = postulante.TipoDocuPost;
                comando.Parameters.Add("Documento", SqlDbType.Int).Value = postulante.DocumentoPost;

                SqlParameter parametrosCodigo = new SqlParameter();
                parametrosCodigo.ParameterName = "Respuesta";
                parametrosCodigo.SqlDbType = SqlDbType.Int;
                parametrosCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parametrosCodigo);
                sqlConnection.Open();
                comando.ExecuteNonQuery();
                salida = Convert.ToString(parametrosCodigo.Value);

            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally 
            {
                if(sqlConnection.State == ConnectionState.Open)
                    sqlConnection.Close(); 
            }
            return salida;
        }
    }
}
