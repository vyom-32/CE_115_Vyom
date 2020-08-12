<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2Home.aspx.cs" Inherits="demoshopping._2Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome &nbsp;<asp:Label ID="username" runat="server"></asp:Label><br />
            <asp:Label ID="prices" runat="server">SamsungA51-25000/- Chromebook-40000/- iphoneX-70000/- sandisk32gb3.0-599/- Ikagai-789/- ShivaTrilogy-699/- RichDadPoorDad-549/- Fake-499/-</asp:Label><br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" AutoPostBack="true">
                <asp:ListItem Text="Electronics" Value="0" Selected="true" />
                <asp:ListItem Text="Books" Value="1" />
            </asp:RadioButtonList>
            <br/>
            <asp:ListBox ID="items" runat="server" OnSelectedIndexChanged="Items_SelectedIndexChanged" SelectionMode="Multiple">
                <asp:ListItem Value="0">SamsungA51</asp:ListItem>
                <asp:ListItem Value="1">Chromebook</asp:ListItem>
                <asp:ListItem Value="2">iphoneX</asp:ListItem>
                <asp:ListItem Value="3">sandisk32gb3.0</asp:ListItem>
                <asp:ListItem Value="4">Ikagai</asp:ListItem>
                <asp:ListItem Value="5">ShivaTrilogy</asp:ListItem>
                <asp:ListItem Value="6">RichDadPoorDad</asp:ListItem>
                <asp:ListItem Value="7">Fake</asp:ListItem>
            </asp:ListBox>
            <br/>
            <br/>
            <asp:Button ID="Place_order" runat="server" OnClick="Place_order_Click" Text="place order" />
        </div>
    </form>
</body>
</html>
