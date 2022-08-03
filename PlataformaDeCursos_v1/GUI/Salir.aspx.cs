using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GUI
{
    public partial class Salir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSi_Click(object sender, EventArgs e)
        {
            Session["usuario"] = null;
            Response.Redirect("miUAI.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            Response.Redirect("PanelGeneral.aspx");
        }
    }
}