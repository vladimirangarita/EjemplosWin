<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Operadores.aspx.cs" Inherits="EjemplosWeb.Operadores" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Pruebas de Operadores Linq"></asp:Label>
            <br />
            <br />
            Casos:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtCasos" runat="server"></asp:TextBox>
            <br />
            <br />
            Cerrados:<asp:TextBox ID="TxtCerrados" runat="server"></asp:TextBox>
&nbsp;
            <br />
            <br />
            Duracion:<asp:TextBox ID="TxtDuracion" runat="server"></asp:TextBox>
&nbsp;<br />
            <br />
            <asp:Button ID="BtnCalcular" runat="server" OnClick="BtnCalcular_Click" Text="Calcular" />
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Numeros"></asp:Label>
            :
            <asp:TextBox ID="TxtNumeros" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Cuadrados:"></asp:Label>
            <asp:TextBox ID="TxtCuadrados" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnAgreggate" runat="server" OnClick="BtnAgreggate_Click" Text="Button" />
        </div>
    </form>
</body>
</html>
