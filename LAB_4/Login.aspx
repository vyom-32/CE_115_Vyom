<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

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
            

            <p>
                <asp:Label ID="Message" ForeColor="Red" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
