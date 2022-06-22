<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="miUAI.aspx.cs" Inherits="GUI.miUAI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>miUAI</title>
        <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" integrity="sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk" crossorigin="anonymous">
<!-- Font Awesome -->
    <link rel="stylesheet" href="path/to/font-awesome/css/font-awesome.min.css">
</head>
<body>
    <nav class="navbar navbar-expand-lg  bg-dark fixed-top">
        <a class="navbar-brand text-danger font-weight-bold" href="PanelGeneral.aspx">
  		Página de Cursos
  	</a>
          <button align="right" class="navbar-toggler" type="button" data-toggle="collapse" data-target="#nav">
      <strong class="text-primary"href="PanelGeneral.aspx">HOME</strong>
    </button>
     <div class="collapse navbar-collapse" id="nav">
    <ul class="navbar-nav ml-auto">
<%--      <li class="nav-item">
        <a class="nav-link font-weight-bold" href="home">Home</a>--%>
      </li>
      <li class="nav-item">
        <a class="nav-link font-weight-bold" href="cursos">Cursos</a>
      </li>
      <li class="nav-item">
        <a class="nav-link font-weight-bold" href="inicio-de-sesion">Login</a>
      </li>
    </ul>
  </div>
</nav>
 <header>
     	<br><br>
		<div class="container">
			<div class="row">
				<div class="col-sm-6">
					<div class="header-left">
						<%--<img src = "images\ic.png" style="width: 100%" class="py-5 px-5">--%>
					</div>
				</div>
				<div class="col-md-6">
				<div class="header-right">
					<h1></h1>
                    <h1>Estado de situación</h1>
					<p>La UAI posee diez facultades: Arquitectura, Ciencias de la Comunicación, Ciencias de la Educación y Psicopedagogía, Ciencias Económicas, Derecho y Ciencias Políticas, Medicina y Ciencias de la Salud, Motricidad Humana y Deportes, Psicología y Relaciones Humanas, Tecnología Informática y Turismo y Hospitalidad.</p>
          <p>Nuestros Centros ofrecen una variada de Cursos de Capacitación Presencial y online a través de convenios con Instituciones de distinta índole que confían en la calidad educativa, seriedad, Trayectoria y  compromiso  que distinguen a nuestra plataforma.</p>
				</div>
                <div>
                    <asp:Label ID="lbl" runat="server" Text="Label"></asp:Label>
                </div>
			</div>
		</div>
	</div>
 </header>  
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
