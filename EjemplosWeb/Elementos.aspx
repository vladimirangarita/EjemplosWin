<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Elementos.aspx.cs" Inherits="EjemplosWeb.Elementos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Elementos<br />
            <br />
            Caso:
            <asp:TextBox ID="TxtCaso" runat="server"></asp:TextBox>
            <br />
            <br />
            Fecha:<asp:TextBox ID="TxtFecha" runat="server"></asp:TextBox>
            <br />
            <br />
            Descripcion:
            <asp:TextBox ID="TxtDescripcion" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="BtnBuscar" runat="server" OnClick="BtnBuscar_Click" Text="Buscar" />
        </div>
    </form>
</body>
</html>
