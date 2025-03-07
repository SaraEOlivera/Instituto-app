using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Instituto.Datos
{
    public class Conexion
    {
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion conexion = null;

        private Conexion() 
        {
            this.baseDatos = "Instituto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "";
        }

        public SqlConnection crearConexion() 
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "server = .\\SQLEXPRESS; database = Instituto_DB; integrated security = true";
            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex;
            }
            return cadena;
        }

        public static Conexion getInstancia() 
        {
            if (conexion == null) 
            {
                conexion = new Conexion();
            }
            return conexion;
        }
    }
}
