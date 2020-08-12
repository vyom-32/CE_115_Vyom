<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="2Login.aspx.cs" Inherits="demoshopping._2Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username :
            <asp:TextBox ID="username" runat="server"></asp:TextBox>
            <br/>
            
            Password :
            <asp:TextBox ID="Password" TextMode="Password" runat="server"></asp:TextBox>

            
            <asp:Button ID="Login_b" Text="Login" runat="server" OnClick="Login_b_click" />
            <br/>
            <asp:Label ID="error" ForeColor="Red" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
