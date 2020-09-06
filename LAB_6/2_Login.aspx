<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Task2.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Username:-</td>
                    <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password:-</td>
                    <td><asp:TextBox ID="TextBox2" type="password"  runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" /></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Label ID="Label1" runat="server"></asp:Label></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
