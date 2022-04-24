<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generacion.aspx.cs" Inherits="EjemplosWeb.Generacion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Larger" Text="Pruebas de Generacion y Particion"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Cuantos"></asp:Label>
            <asp:TextBox ID="TxtCuantos" runat="server" style="margin-left: 74px"></asp:TextBox>
            <br />
            <br />
            <br />
            Selecciona inicio<asp:DropDownList ID="CmbInicio" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CmbInicio_SelectedIndexChanged" style="margin-left: 22px">
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="GrvDatos" runat="server" Width="900px">
            </asp:GridView>
            <br />
        </div>
    </form>
</body>
</html>
