<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarAlumno.aspx.cs" Inherits="GUI.RegistrarAlumno" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Registro de Nuevo Alumno</h1>
            <asp:Label ID="nombre_lbl" runat="server" >Nombre: </asp:Label>
	<asp:TextBox ID="nombre_txt" runat="server" ></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="apellido_lbl" runat="server" >Apellido: </asp:Label>
	<asp:TextBox ID="apellido_txt" runat="server" ></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="tipo_documento_lbl" runat="server" >Tipo de Documento: </asp:Label>
	<asp:TextBox ID="tipo_documento_txt" runat="server" ></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="num_documento_lbl" runat="server" >Numero de Documento: </asp:Label>
	<asp:TextBox ID="num_documento_txt" runat="server" ></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="fecha_nac_lbl" runat="server" >Edad: </asp:Label>
	<asp:TextBox ID="fecha_nac_txt" runat="server" ></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="telefono_lbl" runat="server" >Telefono: </asp:Label>
	<asp:TextBox ID="telefono_txt" runat="server" ></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="email_lbl" runat="server" >E-Mail Institucional: </asp:Label>
	<asp:TextBox ID="email_txt" runat="server" ></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="Label1" runat="server" >Contraseña: </asp:Label>
	<asp:TextBox ID="contra_txt" TextMode="Password" runat="server" ></asp:TextBox>

	<br />
	<br />
	<asp:Button ID="guardar" runat="server" Text="Guardar" OnClick="guardar_Click" />
        </div>
    </form>
</body>
</html>
