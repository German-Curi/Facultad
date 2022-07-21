using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BE;
using BLL;
using System.Security.Cryptography;
using System.Text;

namespace GUI
{
    public partial class Login : System.Web.UI.Page
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
                sb.Append (i.ToString("x2"));
            }
            return sb.ToString();
        }
        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            String pass = GetSHA1(txtPassword.Text);

            alumno objAlumno = AlumnoLN.getInstance().AccesoSistema(txtUsuario.Text, pass );
            Bitacora objBitacora = new Bitacora();
            bool DVH;
            BitacoraLN.getInstance().ObtenerBitacora();
            DVH = VerfificarDVH(BitacoraLN.getInstance().ObtenerBitacora());

            if(objAlumno.Nombre == "Admin")
            {
                Session["usuario"] = objAlumno;
                Response.Write(" <script> alert('USUARIO CORRECTO') </script >");
                Response.Redirect("Menu_Administrador.aspx");
            }

            if (objAlumno != null && DVH == true && objAlumno.Nombre != "Admin")
            {
                
                objBitacora.Usuario = txtUsuario.Text;
                objBitacora.Hora = DateTime.Now.ToString("HH:mm");
                objBitacora.Dia = DateTime.Now.ToString("d");
                objBitacora.Funcionalidad = "Login";
                objBitacora.Mensaje = "Inicio de Sesion";
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
                Session["usuario"] = objAlumno;
                Response.Write(" <script> alert('USUARIO CORRECTO') </script >");
                Response.Redirect("PanelGeneral.aspx");
            }
            if (objAlumno == null)
            {
                Response.Write(" <script> alert('USUARIO INCORRECTO') </script >");

                objBitacora.Usuario = txtUsuario.Text;
                objBitacora.Hora = DateTime.Now.ToString("HH:mm");
                objBitacora.Dia = DateTime.Now.ToString("d");
                objBitacora.Funcionalidad = "Login";
                objBitacora.Mensaje = "Credenciales incorrectas";
                objBitacora.Evento = "Error";

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
            if(DVH == false && objBitacora != null)
            {
                Response.Write(" <script> alert('ERROR EN BASE DE DATOS DEL SISTEMA') </script >");
            }
            

        }
        public bool VerfificarDVH(List<Bitacora> lsbit)
        {
            string auxDVH;
            //string auxDVV = "";
            Bitacora objBitacora = new Bitacora();
            foreach (Bitacora bit in lsbit)
            {   auxDVH=GetSHA1(
                GetSHA1(bit.Usuario)+
                GetSHA1(bit.Hora)+
                GetSHA1(bit.Dia)+
                GetSHA1(bit.Funcionalidad)+
                GetSHA1(bit.Mensaje)+
                GetSHA1(bit.Evento)
                );
                if (auxDVH != bit.DVH)
                {

                    objBitacora.Usuario = bit.Usuario;
                    objBitacora.Hora = DateTime.Now.ToString("HH:mm");
                    objBitacora.Dia = DateTime.Now.ToString("d");
                    objBitacora.Funcionalidad = "Login";
                    objBitacora.Mensaje = "Se modifico los registros de la bitacora (DVH)";
                    objBitacora.Evento = "Advertencia";

                    objBitacora.DVH = GetSHA1(
                        GetSHA1(objBitacora.Usuario) +
                        GetSHA1(objBitacora.Hora) +
                        GetSHA1(objBitacora.Dia) +
                        GetSHA1(objBitacora.Funcionalidad) +
                        GetSHA1(objBitacora.Mensaje) +
                        GetSHA1(objBitacora.Evento)
                        );

                    BitacoraLN.getInstance().RegistrarBitacora(objBitacora);
                    return false;
                }
                //else
                //{
                //    auxDVV += bit.DVH;
                //}
                
            }
            //auxDVV = GetSHA1(auxDVV);
            return true;
        }

        protected void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegistrarAlumno.aspx");

        }
    }
}