<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Examen.aspx.cs" Inherits="_20172578091_2.Examen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Origen destino (B):  "></asp:Label>
            <asp:Button ID="btnOrigen" runat="server" OnClick="btnOrigen_Click" Text="Paises invertidos ordenados alfabeticamente y que no contienen la letra r" Width="440px" />
            <br />
            <br />
            <br />
            <asp:ListBox ID="listFiltro" runat="server" AutoPostBack="True" OnSelectedIndexChanged="listFiltro_SelectedIndexChanged" SelectionMode="Multiple" style="z-index: 1; left: 10px; top: 125px; position: absolute; height: 272px; width: 210px; margin-left: 326px"></asp:ListBox>
            <asp:CheckBoxList ID="chbPaises" runat="server" AutoPostBack="True" Height="282px" OnSelectedIndexChanged="chbPaises_SelectedIndexChanged" Width="135px">
                <asp:ListItem>Canada</asp:ListItem>
                <asp:ListItem>Argentina</asp:ListItem>
                <asp:ListItem>Colombia</asp:ListItem>
                <asp:ListItem>Uruguay</asp:ListItem>
                <asp:ListItem>Italia</asp:ListItem>
                <asp:ListItem>Argelia</asp:ListItem>
                <asp:ListItem>España</asp:ListItem>
                <asp:ListItem>Portugal</asp:ListItem>
                <asp:ListItem>Alemania</asp:ListItem>
                <asp:ListItem>Bolivia</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <br />
            <asp:Button ID="btnDestino" runat="server" OnClick="btnDestino_Click" Text="Ver en fomulario destino los paises que contienen las silaba en o que terminen con la silaba ia" Width="581px" />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
