<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Comversiones.aspx.cs" Inherits="EjemplosWeb.Comversiones" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Pruebas de Generacion"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblMonto1" runat="server" Text="Monto 1:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtM1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblMonto2" runat="server" Text="Monto 2:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtM2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblMonto3" runat="server" Text="Monto 3:"></asp:Label>
&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtM3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblResultado" runat="server" Text="Resaultado:"></asp:Label>
            <asp:TextBox ID="txtResultado" runat="server" OnTextChanged="TxtResultado_TextChanged"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="BtnInforme" runat="server" OnClick="BtnInforme_Click" Text="Informe" />
        </div>
    </form>
</body>
</html>
