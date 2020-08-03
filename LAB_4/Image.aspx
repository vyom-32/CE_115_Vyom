<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image.aspx.cs" Inherits="WebApplication1.Image" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button" runat="server" OnClick="Button_Click" Text="Click Here" />
    </form>
    <asp:Image ID="Image_Field" Visible="false" runat="server" ImageUrl="~/1.jpg" />
</body>
</html>
