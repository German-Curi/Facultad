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
    public partial class misCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            alumno objAlumno = (alumno)Session["UserSessionAlumno"];
            grilla.DataSource = AlumnoLN.getInstance().ObtenerCursosAlumno(objAlumno.ID);
            grilla.DataBind();
        }
    }
}