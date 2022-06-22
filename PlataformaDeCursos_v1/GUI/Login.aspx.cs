using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BLL;
using System.Security.Cryptography;
using System.Text;

namespace GUI
{
    public partial class Login : System.Web.UI.Page
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
                sb.Append (i.ToString("x2"));
            }
            return sb.ToString();
        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            String pass = GetSHA1(txtPassword.Text);

            alumno objAlumno = AlumnoLN.getInstance().AccesoSistema(txtUsuario.Text, pass );
            
            if(objAlumno != null)
            {
                Session["usuario"] = objAlumno;
                Response.Write(" <script> alert('USUARIO CORRECTO') </script >");
                Response.Redirect("miUAI.aspx");
            }
            else
            {
                Response.Write(" <script> alert('USUARIO INCORRECTO') </script >");

            }

        }
    }
}