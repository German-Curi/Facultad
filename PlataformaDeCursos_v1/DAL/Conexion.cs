using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class Conexion
    {
        #region "PATRON SINGLETON"
        private static Conexion conexion = null; 
        private Conexion() { } 
        public static Conexion getInstance()
        {
            if (conexion == null)
            {
                conexion = new Conexion();
            }
            return conexion;
        }
        #endregion

        public SqlConnection ConexionBD()
        {
            //string cn_ger = @"Data Source=GCURI\SQLEXPRESS;Initial Catalog=PlataformaDeCursos_bd;Integrated Security=True";
            //string cn_flv = "Data Source=DESKTOP-KRLDK5C;Initial Catalog=PlataformaDeCursos_bd;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; // USAR CUANDO CAMBIO UBICACION DE LA BASE DE DATOS.
            string cn_flv = " Data Source=.;Initial Catalog=PlataformaDeCursos_bd;Integrated Security=True";
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = cn_flv;
            return conexion;
        }

    }
}
