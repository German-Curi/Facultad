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
    public partial class RegistrarAlumno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void guardar_Click(object sender, EventArgs e)
        {
            alumno auxalu = new alumno();
            auxalu.Nombre = nombre_txt.Text;
            auxalu.Apellido = apellido_txt.Text;
            auxalu.TipoDocumento = "1234";
            auxalu.NroDocumento = 1234;
            auxalu.Edad = 12;
            auxalu.Telefono = 1234;
            auxalu.Email = "gead@asda";
            auxalu.Clave = "cjnads";
            auxalu.DVH = "asdas";
            AlumnoLN.getInstance().RegistrarAlumno(auxalu);
        }
    }
}