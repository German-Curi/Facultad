﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;

namespace GUI
{
    public partial class miUAI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            alumno objAlumno = (alumno)Session["usuario"];
            lbl.Text = objAlumno.Email;
        }
    }
}