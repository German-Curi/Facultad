using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BLL;

namespace GUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            //string user = txtUsuario.Text;
            //string password = txtPassword.Text;
            //string userName = "admin";
            //string passName = "admin";
            //if (user.Equals(userName) && password.Equals(passName))
            //{
            //    //Response.Write(" <script> alert('USUARIO CORRECTO') </script >");
            //    Response.Redirect("miUAI.aspx");
            //}
            //else
            //{
            //    Response.Write(" <script> alert('USUARIO INCORRECTO') </script >");

            //}

            alumno objAlumno = AlumnoLN.getInstance().AccesoSistema(txtUsuario.Text, txtPassword.Text);
            
            if(objAlumno != null)
            {
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