using System;
using System.Data.SqlClient;

namespace DataLayer.Config
{
    public class Conexion
    {
        private string dataBase;
        private string servidor;
        private string usuario;
        private string password;
        private bool security;
        private string port; 

        private static Conexion Con = null;

        private Conexion()
        {
            this.dataBase = "BDNORMATIVIDAD";
            this.servidor = "localhost";
            this.usuario = "sa";
            this.password = "oracle#6403";
            this.security = false;
            this.port = "1444"; 
        }

        public SqlConnection CreateConnection()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.servidor + "," + this.port + "; Database=" + this.dataBase + ";";
                if (this.security)
                {
                    cadena.ConnectionString += "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString += "User Id=" + this.usuario + ";Password=" + this.password;
                }
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
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}