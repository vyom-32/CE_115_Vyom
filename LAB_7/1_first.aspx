<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="first.aspx.cs" Inherits="task1.first" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            List :
            <asp:Label ID="Label1" runat="server"></asp:Label>
        </div>
        <p>
            Even numbers :
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <p>
            Odd Numbers :
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
        <p>
            All Numbers :
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </p>
        <p>
            Maximum :
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </p>
        <p>
            Minimum :
            <asp:Label ID="Label6" runat="server"></asp:Label>
        </p>
        <p>
            Average :
            <asp:Label ID="Label7" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
