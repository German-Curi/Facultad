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
    public partial class BitacoraHome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            grilla.DataSource = BitacoraLN.getInstance().ObtenerBitacora();
            grilla.DataBind();
        }
    }
}