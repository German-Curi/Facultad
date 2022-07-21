using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Data;
using System.Data.SqlClient;
namespace DAL
{
    public class BitacoraDAO
    {
        #region "PATRON SINGLETON"
        private static BitacoraDAO daobitacora = null;
        private BitacoraDAO() { }
        public static BitacoraDAO getInstance()
        {
            if (daobitacora == null)
            {
                daobitacora = new BitacoraDAO();
            }
            return daobitacora;
        }
        #endregion
        public bool RegistrarBitacora(Bitacora objbitacora)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            bool response = false;
            try
            {
                con = Conexion.getInstance().ConexionBD();
                
                cmd = new SqlCommand("spRegistrarBitacora",con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUsuario", objbitacora.Usuario);
                cmd.Parameters.AddWithValue("@prmHora", objbitacora.Hora);
                cmd.Parameters.AddWithValue("@prmDia", objbitacora.Dia);
                cmd.Parameters.AddWithValue("@prmFuncionalidad", objbitacora.Funcionalidad);
                cmd.Parameters.AddWithValue("@prmMensaje", objbitacora.Mensaje);
                cmd.Parameters.AddWithValue("@prmEvento", objbitacora.Evento);
                cmd.Parameters.AddWithValue("@prmDVH", objbitacora.DVH);
                con.Open();
                int filas  = cmd.ExecuteNonQuery();
                if (filas > 0) response = true;
            }
            catch (Exception ex)
            {
                response = false;
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return response;
        }
        public List<Bitacora> ObtenerBitacora()
        {
            SqlConnection con = null;
            SqlCommand cmd;
            List<Bitacora> lsbitacora = new List<Bitacora>();
            SqlDataReader dr;
            try
            {
                con = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spObtener_Bitacora",con);
                cmd.CommandType = CommandType.StoredProcedure;
                con.Open();
                dr = cmd.ExecuteReader();
                while (dr.HasRows)
                {
                    while (dr.Read()) 
                    {
                        Bitacora auxbit = new Bitacora();
                        auxbit.Usuario = dr["Usuario"].ToString();
                        auxbit.Hora = dr["Hora"].ToString();
                        auxbit.Dia = dr["Dia"].ToString();
                        auxbit.Funcionalidad = dr["Funcionalidad"].ToString();
                        auxbit.Mensaje = dr["Mensaje"].ToString();
                        auxbit.Evento = dr["Evento"].ToString();
                        auxbit.DVH = dr["DVH"].ToString();
                        
                        lsbitacora.Add(auxbit);
                    }
                    dr.NextResult();
                }
            }
            catch (Exception ex)
            {
                lsbitacora = null;
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return lsbitacora;
        }
    }
}
