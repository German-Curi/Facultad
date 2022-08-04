using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Security.Cryptography;
using System.Text;
using BE;
using BLL;

namespace GUI
{
    public partial class Registro_Alumnos_master : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string GetSHA1(String texto)
        {
            SHA1CryptoServiceProvider sh = new SHA1CryptoServiceProvider();
            sh.ComputeHash(ASCIIEncoding.ASCII.GetBytes(texto));
            byte[] re = sh.Hash;
            StringBuilder sb = new StringBuilder();
            foreach (byte i in re)
            {
                sb.Append(i.ToString("x2"));
            }
            return sb.ToString();
        }
        protected void guardar_Click(object sender, EventArgs e)
        {
            alumno auxalu = new alumno();
            Bitacora objBitacora = new Bitacora();
            auxalu.Nombre = nombre_txt.Text;
            auxalu.Apellido = apellido_txt.Text;
            auxalu.TipoDocumento = tipo_documento_txt.Text;
            auxalu.NroDocumento =int.Parse( num_documento_txt.Text);
            auxalu.Edad = int.Parse(fecha_nac_txt.Text);
            auxalu.Telefono = int.Parse(telefono_txt.Text);
            auxalu.Email = email_txt.Text;
            auxalu.Clave = GetSHA1(contra_txt.Text);
            auxalu.DVH = GetSHA1( GetSHA1(auxalu.Nombre) +
                                  GetSHA1(auxalu.Apellido) +
                                  GetSHA1(auxalu.TipoDocumento) +
                                  GetSHA1(auxalu.NroDocumento.ToString()) +
                                  GetSHA1(auxalu.Edad.ToString()) +
                                  GetSHA1(auxalu.Telefono.ToString()) +
                                  GetSHA1(auxalu.Email) +
                                  GetSHA1(auxalu.Clave)
                );
            AlumnoLN.getInstance().RegistrarAlumno(auxalu);

            objBitacora.Usuario = auxalu.Email;
            objBitacora.Hora = DateTime.Now.ToString("HH:mm");
            objBitacora.Dia = DateTime.Now.ToString("d");
            objBitacora.Funcionalidad = "Registro de nuevo Alumno";
            objBitacora.Mensaje = "Alumno Registrado";
            objBitacora.Evento = "Informacion";

            objBitacora.DVH = GetSHA1(
                GetSHA1(objBitacora.Usuario) +
                GetSHA1(objBitacora.Hora) +
                GetSHA1(objBitacora.Dia) +
                GetSHA1(objBitacora.Funcionalidad) +
                GetSHA1(objBitacora.Mensaje) +
                GetSHA1(objBitacora.Evento)
                );
            BitacoraLN.getInstance().RegistrarBitacora(objBitacora);

            Response.Write(" <script> alert('SE REGISTRO EL ALUMNO CORRECTAMENTE') </script >");
            
        }


    }
}