<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GUI.Login" %>

<!DOCTYPE html>

<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login sistema</title>
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />
</head>
<body class="bg-black"> 
    <div class="form-box" id="login-box"> 
        <div class="header">Login</div>
        <form id="form1" runat="server">
            <div class="body bg-gray">


  <%--       <asp:Login ID="LoginUser" runat="server" EnableViewState="false" OnAuthenticate="LoginUser_Authenticate" Width="100%">
         <LayoutTemplate>--%>



                <div class="form-group"> 
                    <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Ingrese usuario" Width="100%"></asp:TextBox>
                </div>
                <div class="form-group">
                    <asp:TextBox TextMode="Password" ID="txtPassword" runat="server" CssClass="form-control" placeholder="Ingrese clave" Width="100%"></asp:TextBox>

                </div>
            </div>
            <div class="footer"> 

                <asp:Button ID="btnIngresar" runat="server" Text="Iniciar sesión" CssClass="btn bg-blue" OnClick="btnIngresar_Click" Width="31%" />
                <asp:Button ID="btnRegistrarAlumno" runat="server" Text="Registrar Alumno" CssClass="btn bg-olive" Width="31%" OnClick="btnRegistrarAlumno_Click" />
                <asp:Button ID="btnRegistrarProfesor" runat="server" Text="Registrar Profesor" CssClass="btn bg-olive" Width="31%" />

<%--            </LayoutTemplate>
            </asp:Login>--%>

            </div>
        </form>
    </div>
</body>
</html>
