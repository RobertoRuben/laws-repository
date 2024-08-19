using System;
using System.Data.SqlClient;

namespace DataLayer.Config
{
    public class Conexion
    {
        private string dataBase;
        private string servidor;
        private string usuario;
        private string contraseña;
        private bool seguridad;
        private string puerto; 

        private static Conexion Con = null;

        private Conexion()
        {
            this.dataBase = "BDNORMATIVIDAD";
            this.servidor = "localhost";
            this.usuario = "sa";
            this.contraseña = "oracle#6403";
            this.seguridad = false;
            this.puerto = "1444"; 
        }

        public SqlConnection CrearConexion()
        {
            SqlConnection cadena = new SqlConnection();
            try
            {
                cadena.ConnectionString = "Server=" + this.servidor + "," + this.puerto + "; Database=" + this.dataBase + ";";
                if (this.seguridad)
                {
                    cadena.ConnectionString += "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString += "User Id=" + this.usuario + ";Password=" + this.contraseña;
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