using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using BE;
using BLL;
using System.Security.Cryptography;
using System.Text;
using GUI.Custom;

namespace GUI
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Session["UserSessionId"] = null;
            }
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

        //protected void btnIngresar_Click(object sender, EventArgs e)
        //{
        //    String pass = GetSHA1(txtPassword.Text);

        //    alumno objAlumno = AlumnoLN.getInstance().AccesoSistema(txtUsuario.Text, pass );
        //    Bitacora objBitacora = new Bitacora();
        //    bool DVH;
        //    BitacoraLN.getInstance().ObtenerBitacora();
        //    DVH = VerfificarDVH(BitacoraLN.getInstance().ObtenerBitacora());

        //    if(objAlumno.Nombre == "Admin")
        //    {
        //        Session["usuario"] = objAlumno;
        //        Response.Write(" <script> alert('USUARIO CORRECTO') </script >");
        //        Response.Redirect("Menu_Administrador.aspx");
        //    }

        //    if (objAlumno != null && DVH == true && objAlumno.Nombre != "Admin")
        //    {

        //        objBitacora.Usuario = txtUsuario.Text;
        //        objBitacora.Hora = DateTime.Now.ToString("HH:mm");
        //        objBitacora.Dia = DateTime.Now.ToString("d");
        //        objBitacora.Funcionalidad = "Login";
        //        objBitacora.Mensaje = "Inicio de Sesion";
        //        objBitacora.Evento = "Informacion";

        //        objBitacora.DVH = GetSHA1(
        //            GetSHA1(objBitacora.Usuario) +
        //            GetSHA1(objBitacora.Hora) +
        //            GetSHA1(objBitacora.Dia) +
        //            GetSHA1(objBitacora.Funcionalidad) +
        //            GetSHA1(objBitacora.Mensaje) +
        //            GetSHA1(objBitacora.Evento)
        //            );

        //        BitacoraLN.getInstance().RegistrarBitacora(objBitacora);
        //        Session["usuario"] = objAlumno;
        //        Response.Write(" <script> alert('USUARIO CORRECTO') </script >");
        //        Response.Redirect("PanelGeneral.aspx");
        //    }
        //    if (objAlumno == null)
        //    {
        //        Response.Write(" <script> alert('USUARIO INCORRECTO') </script >");

        //        objBitacora.Usuario = txtUsuario.Text;
        //        objBitacora.Hora = DateTime.Now.ToString("HH:mm");
        //        objBitacora.Dia = DateTime.Now.ToString("d");
        //        objBitacora.Funcionalidad = "Login";
        //        objBitacora.Mensaje = "Credenciales incorrectas";
        //        objBitacora.Evento = "Error";

        //        objBitacora.DVH = GetSHA1(
        //            GetSHA1(objBitacora.Usuario) +
        //            GetSHA1(objBitacora.Hora) +
        //            GetSHA1(objBitacora.Dia) +
        //            GetSHA1(objBitacora.Funcionalidad) +
        //            GetSHA1(objBitacora.Mensaje) +
        //            GetSHA1(objBitacora.Evento)
        //            );
        //        BitacoraLN.getInstance().RegistrarBitacora(objBitacora);


        //    }
        //    if(DVH == false && objBitacora != null)
        //    {
        //        Response.Write(" <script> alert('ERROR EN BASE DE DATOS DEL SISTEMA') </script >");
        //    }


        //}
        public bool VerfificarDVH(List<Bitacora> lsbit)
        {
            string auxDVH;
            //string auxDVV = "";
            Bitacora objBitacora = new Bitacora();
            foreach (Bitacora bit in lsbit)
            {
                auxDVH = GetSHA1(
                GetSHA1(bit.Usuario) +
                GetSHA1(bit.Hora) +
                GetSHA1(bit.Dia) +
                GetSHA1(bit.Funcionalidad) +
                GetSHA1(bit.Mensaje) +
                GetSHA1(bit.Evento)
                );
                if (auxDVH != bit.DVH)
                {

                    objBitacora.Usuario = bit.Usuario;
                    objBitacora.Hora = DateTime.Now.ToString("HH:mm");
                    objBitacora.Dia = DateTime.Now.ToString("d");
                    objBitacora.Funcionalidad = "Base de datos";
                    objBitacora.Mensaje = "Se modifico los registros de la bitacora";
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

        public bool VerfificarDVHalu(List<alumno> lsalu)
        {
            string auxDVH;
            //string auxDVV = "";
            Bitacora objBitacora = new Bitacora();
            foreach (alumno alu in lsalu)
            {
                auxDVH = GetSHA1(GetSHA1(alu.Nombre) +
                                  GetSHA1(alu.Apellido) +
                                  GetSHA1(alu.TipoDocumento) +
                                  GetSHA1(alu.NroDocumento.ToString()) +
                                  GetSHA1(alu.Edad.ToString()) +
                                  GetSHA1(alu.Telefono.ToString()) +
                                  GetSHA1(alu.Email) +
                                  GetSHA1(alu.Clave)
                );
                if (auxDVH != alu.DVH)
                {

                    objBitacora.Usuario = alu.Email;
                    objBitacora.Hora = DateTime.Now.ToString("HH:mm");
                    objBitacora.Dia = DateTime.Now.ToString("d");
                    objBitacora.Funcionalidad = "Base de datos";
                    objBitacora.Mensaje = "Se modifico el registro del Alumno";
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

        protected void LoginUser_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool DVH;
            bool DVHalu;
            String pass = GetSHA1(LoginUser.Password);
            Bitacora objBitacora = new Bitacora();
            
            DVH = VerfificarDVH(BitacoraLN.getInstance().ObtenerBitacora());
            DVHalu = VerfificarDVHalu(AlumnoLN.getInstance().ObtenerAlumnos());
            bool auth = Membership.ValidateUser(LoginUser.UserName, pass);
            alumno objAlumno = AlumnoLN.getInstance().AccesoSistema(LoginUser.UserName, pass);
            if (!DVH || !DVHalu)
            {
                if(objAlumno != null)
                {
                    if(objAlumno.Nombre != "Admin")
                    {
                        auth = false;
                    }
                }
               
                Response.Write(" <script> alert('ERROR EN BASE DE DATOS DEL SISTEMA') </script >");
            }

            if (auth)
            {
               

                if (objAlumno != null)
                {
                    objBitacora.Usuario = LoginUser.UserName;
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
                    SessionManager _SessionManager = new SessionManager(Session);

                    _SessionManager.UserSessionAlumno = objAlumno;
                    FormsAuthentication.RedirectFromLoginPage(LoginUser.UserName, false);

                    if (objAlumno.Nombre == "Admin")
                    {
                        Session["usuario"] = objAlumno;
                        Response.Write(" <script> alert('USUARIO CORRECTO') </script >");
                        Response.Redirect("PanelAdministrador.aspx");
                    }
                }

            }
            else
            {
            
                if(DVH)
                {
                    objBitacora.Usuario = LoginUser.UserName;
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
                    Response.Write("<script>alert('USUARIO INCORRECTO.')</script>");
                }
                
            }
        }
    }
}