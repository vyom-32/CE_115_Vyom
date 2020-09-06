<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="task1.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server"></asp:Label>
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

        <asp:TextBox ID="TextBox1" placeholder="Enter id" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;
           <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Fetch" OnClick="Button1_Click" />
        <br />
        <br />

        <table id="Table1" visible="false" runat="server">
            <tr>
                <td>Name:-</td>
                <td>
                    <asp:TextBox ID="oname" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Sem:-</td>
                <td>
                    <asp:TextBox ID="osem" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Mobile No:-</td>
                <td>
                    <asp:TextBox ID="omono" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td>Email:-</td>
                <td>
                    <asp:TextBox ID="oemail" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="Button2" runat="server" Text="update" OnClick="Button2_Click" /></td>
            </tr>
        </table>
    </form>
</body>
</html>
