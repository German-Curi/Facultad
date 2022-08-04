<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="miPerfil.aspx.cs" Inherits="GUI.miPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
<!-- Font Awesome -->
    <link rel="stylesheet" href="path/to/font-awesome/css/font-awesome.min.css">

 <header>
     
		<div class="container">
			<div class="row">
				<div class="col-sm-6">
				</div>
				<div class="col-md-6">
				<div class="header-left">
					<!-- <h1>Mi perfil</h1 >-->
          
                </div>
			</div>
		</div>
	</div>
 </header>  

	<h1>Mi perfil</h1>
	<asp:Label ID="nombre_lbl" runat="server" >Nombre: </asp:Label>
	<asp:TextBox ID="nombre_txt" runat="server" Enabled="false"></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="apellido_lbl" runat="server" >Apellido: </asp:Label>
	<asp:TextBox ID="apellido_txt" runat="server" Enabled="false"></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="tipo_documento_lbl" runat="server" >Tipo de Documento: </asp:Label>
	<asp:TextBox ID="tipo_documento_txt" runat="server" Enabled="false"></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="num_documento_lbl" runat="server" >Numero de Documento: </asp:Label>
	<asp:TextBox ID="num_documento_txt" runat="server" Enabled="false"></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="fecha_nac_lbl" runat="server" >Edad: </asp:Label>
	<asp:TextBox ID="fecha_nac_txt" runat="server" Enabled="false"></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="telefono_lbl" runat="server" >Telefono: </asp:Label>
	<asp:TextBox ID="telefono_txt" runat="server" Enabled="false"></asp:TextBox>

	<br />
	<br />
	<asp:Label ID="email_lbl" runat="server" >E-Mail Institucional: </asp:Label>
	<asp:TextBox ID="email_txt" runat="server" Enabled="false"></asp:TextBox>

	<br />
	<br />
	<asp:Button ID="actualizar" runat="server" Text="Actualizar" OnClick="actualizar_Click" />
	<asp:Button ID="guardar" runat="server" Text="Guardar" />
</asp:Content>
