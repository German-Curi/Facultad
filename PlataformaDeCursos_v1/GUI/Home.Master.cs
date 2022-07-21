using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
namespace GUI
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                alumno objAlumno = (alumno)Session["usuario"];
                txtUsuario.Text = objAlumno.Nombre +" "+objAlumno.Apellido;
            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
                
                Session["usuario"] = null;
                Response.Write(" <script> alert('SESION CERRADA') </script >");
                Response.Redirect("miUAI.aspx");

            }

    }
}