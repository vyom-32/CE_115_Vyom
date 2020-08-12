<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1Home.aspx.cs" Inherits="cookieDemo.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Delete" runat="server" OnClick="Delete_Click" Text="Delete Cookie" />
            <p>
                <asp:Label ID="Message" runat="server"></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
