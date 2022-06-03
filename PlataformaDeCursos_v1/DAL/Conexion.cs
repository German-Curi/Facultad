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



    }
}
