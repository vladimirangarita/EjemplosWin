<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Consultas.aspx.cs" Inherits="EjemplosWeb.Consultas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Pruebas de Linq"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:GridView ID="GrvResultados" runat="server">
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="btnWhere" runat="server" Text="Where" OnClick="btnWhere_Click" />
        <asp:Button ID="BtnXML" runat="server" OnClick="BtnXML_Click" Text="XML" />
        <asp:Button ID="BtnDistinct" runat="server" OnClick="BtnDistinct_Click" Text="Distinct" />
        <asp:Button ID="BtnAgrupar" runat="server" OnClick="BtnAgrupar_Click" Text="Agrupar" />
    </form>
</body>
</html>
