<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="task1.Insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server"></asp:Label> 
            <table>
                <tr>
                    <td>Name:-</td>
                    <td><asp:TextBox ID="Name" runat="server" required="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Sem:-</td>
                    <td><asp:TextBox ID="Sem" runat="server" required="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Mobile No:-</td>
                    <td><asp:TextBox ID="Mono" runat="server" required="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>email</td>
                    <td><asp:TextBox ID="Email" runat="server" required="True"></asp:TextBox></td>
                </tr>
                <tr>
                    <td colspan="2"><asp:Button ID="Button1" runat="server" Text="insert" OnClick="Button1_Click" style="height: 29px" /></td>
          
                </tr>
            </table>
        </div>
        <div>
        <asp:GridView ID="GridViewStudent" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000000" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <br />
       
    </div>
    </form>
</body>
</html>
