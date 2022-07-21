<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="misCursos.aspx.cs" Inherits="GUI.misCursos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">



    <div class="header-left">
					<h1>Cursos</h1>
					<p>Listado de cursos inscriptos</p>

        <asp:GridView ID="grilla" runat="server"></asp:GridView>    
</div>



</asp:Content>
