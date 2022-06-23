<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="miPerfil.aspx.cs" Inherits="GUI.miPerfil" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
<!-- Font Awesome -->
    <link rel="stylesheet" href="path/to/font-awesome/css/font-awesome.min.css">



          <button align="right" class="navbar-toggler" type="button" data-toggle="collapse" data-target="#nav">
      <strong class="text-primary"href="PanelGeneral.aspx">HOME</strong>
    </button>

    <ul class="navbar-nav ml-auto"/>
<%--      <li class="nav-item">
        <a class="nav-link font-weight-bold" href="home">Home</a>--%>
    <ul>
      <li class="nav-item">
        <a class="nav-link font-weight-bold" href="#">Estado de Situación</a>
      </li>
      <li class="nav-item">
        <a class="nav-link font-weight-bold" href="#">Calendario</a>
      </li>
    </ul>
 

 <header>
     
		<div class="container">
			<div class="row">
				<div class="col-sm-6">
				</div>
				<div class="col-md-6">
				<div class="header-left">
					<h1>Mi perfil</h1>
					<p>La UAI posee diez facultades: Arquitectura, Ciencias de la Comunicación, Ciencias de la Educación y Psicopedagogía, Ciencias Económicas, Derecho y Ciencias Políticas, Medicina y Ciencias de la Salud, Motricidad Humana y Deportes, Psicología y Relaciones Humanas, Tecnología Informática y Turismo y Hospitalidad.</p>
          <p>Nuestros Centros ofrecen una variada de Cursos de Capacitación Presencial y online a través de convenios con Instituciones de distinta índole que confían en la calidad educativa, seriedad, Trayectoria y  compromiso  que distinguen a nuestra plataforma.</p>
				</div>
                <div>
                    <asp:Label ID="lbl" runat="server" Text="2022"></asp:Label>
                </div>
			</div>
		</div>
	</div>
 </header>  

        <div>
        </div>
    </form>




</asp:Content>
