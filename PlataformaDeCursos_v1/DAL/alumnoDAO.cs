using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BE;
using System.Data;

namespace DAL
{
    public class alumnoDAO
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
            SqlCommand cmd ;
            alumno objAlumno = null;
            SqlDataReader dr;
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
                    objAlumno.ID = Convert.ToInt32(dr["ID_Alumno"].ToString());
                    objAlumno.Nombre = dr["Nombre"].ToString();
                    objAlumno.Apellido = dr["Apellido"].ToString();
                    objAlumno.TipoDocumento = dr["Tipo_Documento"].ToString();
                    objAlumno.NroDocumento = Convert.ToInt32(dr["Num_Documento"].ToString());
                    objAlumno.Edad = Convert.ToInt32(dr["Edad"].ToString());
                    objAlumno.Telefono = dr["Telefono"].ToString();
                    objAlumno.Email = dr["Email"].ToString();
                    objAlumno.Clave = dr["Contrasenia"].ToString();
                    //objAlumno.Estado = true;

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

        public List<curso> ObtenerCursosAlumno(int id)
        {
            SqlConnection conexion = null;
            SqlCommand cmd;
            List<curso> lsCurso = new List<curso>();
            SqlDataReader dr;
            try
            {
                conexion = Conexion.getInstance().ConexionBD();
                cmd = new SqlCommand("spCursos_Alumno", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_alumno", id);
                conexion.Open();
                dr = cmd.ExecuteReader();
                while (dr.HasRows)
                {
                   while(dr.Read())
                    {
                        curso auxcur = new curso();
                        auxcur.Nombre = dr["Curso"].ToString();
                        auxcur.Descripcion = dr["Descripcion"].ToString();
                        auxcur.Area = dr["Area"].ToString();
                        auxcur.Turno = dr["Turno"].ToString();
                        auxcur.Dia = dr["Dia"].ToString();
                        auxcur.Nombre_Profesor = dr["Nombre Profesor"].ToString();
                        auxcur.Apellido_profesor = dr["Apellido Profesor"].ToString();
                        lsCurso.Add(auxcur);
                    }
                    dr.NextResult();
                }
            }
            catch (Exception ex)
            {
                lsCurso = null;
                throw ex;
            }
            finally
            {
                conexion.Close();
            }
            return lsCurso;

        }

    }
}
