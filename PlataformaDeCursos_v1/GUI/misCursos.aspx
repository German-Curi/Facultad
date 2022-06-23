<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="misCursos.aspx.cs" Inherits="GUI.misCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="header-left">
					<h1>Cursos</h1>
					<p>Listado de cursos inscriptos</p>
		<table>
  <!-- Cabecera -->
  <tr>
    <th>Código</th>   <!-- Celda de cabecera de la columna 1 -->
    <th>Nombre</th>   <!-- Celda de cabecera de la columna 2 -->
    <th>Descripción</th>   <!-- Celda de cabecera de la columna 3 -->
  </tr>
  <!-- Primera fila -->
  <tr>
    <td>01</td>    <!-- Primera celda de la primera fila -->
    <td>Física</td>    <!-- Segunda celda de la primera fila -->
    <td>......</td>    <!-- Tercera celda de la primera fila -->
  </tr>
  <!-- Segunda fila -->
  <tr>
    <td>02</td>    <!-- Primera celda de la segunda fila -->
    <td>Matemática</td>    <!-- Segunda celda de la segunda fila -->
    <td>.....</td>    <!-- Tercera celda de la segunda fila -->
  </tr>
</table>

</div>



</asp:Content>
