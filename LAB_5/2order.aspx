<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2order.aspx.cs" Inherits="demoshopping._2order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>Here is your selected products and total price<br/><br/>
            <asp:Label ID="Products" runat="server"></asp:Label><br/>
            <asp:Label ID="Total_price" runat="server"></asp:Label><br/>
        </div>
    </form>
</body>
</html>
