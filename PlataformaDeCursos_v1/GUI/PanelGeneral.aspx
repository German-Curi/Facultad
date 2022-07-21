<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="PanelGeneral.aspx.cs" Inherits="GUI.PanelGeneral" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <!-- ACA SE PONEN LOS SCRIPT Y LOS ESTILOS (JS y Css) -->
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<p></p>--%>

      <authentication mode="Forms">
    <forms name="Autentificacion" defaultUrl="PanelGeneral.aspx" loginUrl="Login.aspx" path="/" protection="All"/>
  </authentication>

</asp:Content>
