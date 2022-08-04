using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using GUI.Custom;
using System.Web.Services;
using System.Web.Security;
using BE;
using BLL;
using System.Security.Cryptography;
using System.Text;

namespace GUI
{
    public partial class Salir : System.Web.UI.Page
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
                sb.Append(i.ToString("x2"));
            }
            return sb.ToString();
        }

        protected void btnSi_Click(object sender, EventArgs e)
        {
            if (Session["UserSessionAlumno"] != null)
            {
                alumno objAlumno = (alumno)Session["UserSessionAlumno"];
                Bitacora objBitacora = new Bitacora();
                objBitacora.Usuario = objAlumno.Email;
                objBitacora.Hora = DateTime.Now.ToString("HH:mm");
                objBitacora.Dia = DateTime.Now.ToString("d");
                objBitacora.Funcionalidad = "Logout";
                objBitacora.Mensaje = "Cerrar Sesion";
                objBitacora.Evento = "Informacion";

                objBitacora.DVH = GetSHA1(
                    GetSHA1(objBitacora.Usuario) +
                    GetSHA1(objBitacora.Hora) +
                    GetSHA1(objBitacora.Dia) +
                    GetSHA1(objBitacora.Funcionalidad) +
                    GetSHA1(objBitacora.Mensaje) +
                    GetSHA1(objBitacora.Evento)
                    );

                BitacoraLN.getInstance().RegistrarBitacora(objBitacora);
            }
            Session["UserSessionId"] = null;
            Session["UserSessionAlumno"] = null;
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
            Response.Redirect("Login.aspx");
        }

        protected void btnNo_Click(object sender, EventArgs e)
        {
            if (Session["UserSessionAlumno"] != null)
            {
                alumno objAlumno = (alumno)Session["UserSessionAlumno"];
                if (objAlumno.Nombre == "Admin")
                {
                    Response.Redirect("PanelAdministrador.aspx");
                }
                else
                {
                    Response.Redirect("PanelGeneral.aspx");
                }
            }
            
        }
    }
}