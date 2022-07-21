using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BitacoraLN
    {
        #region "PATRON SINGLETON"
        private static BitacoraLN objBitacora = null;
        private BitacoraLN() { }
        public static BitacoraLN getInstance()
        {
            if (objBitacora == null)
            {
                objBitacora = new BitacoraLN();
            }
            return objBitacora;
        }
        #endregion
        public bool RegistrarBitacora(Bitacora objBitacora)
        {
            try
            {
                return BitacoraDAO.getInstance().RegistrarBitacora(objBitacora);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }
        public List<Bitacora> ObtenerBitacora()
        {
            try
            {
                return BitacoraDAO.getInstance().ObtenerBitacora();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
