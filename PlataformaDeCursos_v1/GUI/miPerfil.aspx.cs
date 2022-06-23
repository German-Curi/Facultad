using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;

namespace GUI
{
    public partial class miPerfil : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] != null)
            {
                alumno objAlumno = (alumno)Session["usuario"];
                nombre_txt.Text = objAlumno.Nombre;
                apellido_txt.Text = objAlumno.Apellido;
                tipo_documento_txt.Text = objAlumno.TipoDocumento;
                num_documento_txt.Text = objAlumno.NroDocumento.ToString();
                fecha_nac_txt.Text = objAlumno.Edad.ToString();
                telefono_txt.Text = objAlumno.Telefono;
                email_txt.Text = objAlumno.Email;
            }
        }

        protected void actualizar_Click(object sender, EventArgs e)
        {
            nombre_txt.Enabled = true;
            apellido_txt.Enabled = true;
            tipo_documento_txt.Enabled = true;
            num_documento_txt.Enabled = true;
            fecha_nac_txt.Enabled = true;
            telefono_txt.Enabled = true;
            email_txt.Enabled = true;
        }
    }
}