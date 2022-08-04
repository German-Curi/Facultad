<%@ Page Title="" Language="C#" MasterPageFile="~/Home_Admin.Master" AutoEventWireup="true" CodeBehind="BitacoraHome.aspx.cs" Inherits="GUI.BitacoraHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
            <h1>Bitacora Menu</h1>
            <asp:GridView ID="grilla" runat="server"></asp:GridView>  
        </div>
</asp:Content>
