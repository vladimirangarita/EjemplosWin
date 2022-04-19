<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Verificadores.aspx.cs" Inherits="EjemplosWeb.Verificadores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Pruebas de Metodos Verificadores"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Valor"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtValor" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Resultado"></asp:Label>
            <asp:TextBox ID="TxtResultdo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnAll" runat="server" OnClick="BtnAll_Click" Text="All" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnAny" runat="server" Text="Any" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="BtnContains" runat="server" Text="Contains" />
        </div>
    </form>
</body>
</html>
