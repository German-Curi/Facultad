<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Salir.aspx.cs" Inherits="GUI.Login" %>

<!DOCTYPE html>
<script runat="server">

    protected void btnSi_Click(object sender, EventArgs e)
    {
        Session["usuario"] = null;
        Response.Redirect("miUAI.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("PanelGeneral.aspx");
    }

</script>


<html class="bg-black" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login sistema</title>
    <link href="css/AdminLTE.css" rel="stylesheet" type="text/css" />
</head>
<body class="bg-black"> 
    <div class="form-box" id="login-box"> 
        <div class="header">
            <div id="exacc_xrfZYp6dJbzd1sQPvNiI4AI5" aria-hidden="true" class="iDjcJe IX9Lgd wwB5gf" jsname="jIA8B">
                <span>¿Cerrar Sesión?</span></div>
        </div>
        <form id="form1" runat="server">
            <div class="footer"> 

                <asp:Button ID="btnSi" runat="server" Text="Si" CssClass="btn bg-blue" Width="49%" OnClick="btnSi_Click" />
                <asp:Button ID="btnNo" runat="server" Text="No" CssClass="btn bg-olive" Width="49%" OnClick="btnNo_Click" />

<%--            </LayoutTemplate>
            </asp:Login>--%>

            </div>
        </form>
    </div>
</body>
</html>
