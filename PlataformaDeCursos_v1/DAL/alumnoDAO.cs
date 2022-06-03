﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BE;
using System.Data;

namespace DAL
{
    internal class alumnoDAO
    {
        #region "PATRON SINGLETON"
        private static alumnoDAO daoalumno = null;
        private alumnoDAO() { }
        public static alumnoDAO getInstance()
        {
            if (daoalumno == null)
            {
                daoalumno = new alumnoDAO();
            }
            return daoalumno;
        }
        #endregion

        public alumno AccesoSistema(String user, String pass)
        {
            SqlConnection conexion = null;
            SqlCommand cmd = null;
            alumno objAlumno = null;
            SqlDataReader dr = null;
            try 
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spAccesoSistema", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmUser", user);
                cmd.Parameters.AddWithValue("@prmPass", pass);
                conexion.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    objAlumno = new alumno();
                    objAlumno.ID = Convert.ToInt32(dr["idAlumno"].ToString());
                    objAlumno.Nombre = dr["nombres"].ToString();
                    objAlumno.Apellido = dr["apellido"].ToString();
                    objAlumno.TipoDocumento = dr["tipoDocumennto"].ToString();
                    objAlumno.NroDocumento = Convert.ToInt32(dr["nroDocumento"].ToString());
                    objAlumno.Edad = Convert.ToInt32(dr["edad"].ToString());
                    objAlumno.Telefono = dr["telefono"].ToString();
                    objAlumno.Email = dr["email"].ToString();
                    objAlumno.Clave = dr["clave"].ToString();
                    objAlumno.Estado = true;

                }
            }
            catch (Exception ex)
            {
                objAlumno = null;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return objAlumno;
        }

    }
}
