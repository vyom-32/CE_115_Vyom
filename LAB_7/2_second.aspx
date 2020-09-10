<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="second.aspx.cs" Inherits="task2.second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Names :
            <asp:Label ID="Label1" runat="server"></asp:Label>

        </div>
        <p>
            Names with the first letter ‘K’ :
            <asp:Label ID="Label2" runat="server"></asp:Label>
        </p>
        <p>
            Names with string length less than 4 :
            <asp:Label ID="Label3" runat="server"></asp:Label>
        </p>
        <p>
            Names with string length equal to 3 :
            <asp:Label ID="Label4" runat="server"></asp:Label>
        </p>
        <p>
            Names in Ascending order :
            <asp:Label ID="Label5" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
