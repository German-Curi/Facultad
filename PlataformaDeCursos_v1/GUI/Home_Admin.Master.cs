using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
namespace GUI
{
    public partial class Home_Admin : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserSessionAlumno"] != null)
                {
                    alumno objAlumno = (alumno)Session["UserSessionAlumno"];
                    txtAdmin.Text = objAlumno.Nombre;
                }
            }
        }
    }
}