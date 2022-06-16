using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class AlumnoLN
    {
        #region "PATRON SINGLETON"
        private static AlumnoLN objAlumno = null;
        private AlumnoLN() { }
        public static AlumnoLN getInstance()
        {
            if (objAlumno == null)
            {
                objAlumno = new AlumnoLN();
            }
            return objAlumno;
        }
        #endregion

        public alumno AccesoSistema(String user, String pass)
        {
            try
            {
                return alumnoDAO.getInstance().AccesoSistema(user, pass);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
