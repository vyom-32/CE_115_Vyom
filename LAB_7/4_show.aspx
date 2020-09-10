<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show.aspx.cs" Inherits="task4.show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" DataKeyNames="sid" DataSourceID="SqlDataSource1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="sid" HeaderText="sid" InsertVisible="False" ReadOnly="True" SortExpression="sid" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="sem" HeaderText="sem" SortExpression="sem" />
                <asp:BoundField DataField="cpi" HeaderText="cpi" SortExpression="cpi" />
                <asp:BoundField DataField="contactno" HeaderText="contactno" SortExpression="contactno" />
                <asp:BoundField DataField="emailid" HeaderText="emailid" SortExpression="emailid" />
            </Columns>
        </asp:GridView>
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConflictDetection="CompareAllValues" ConnectionString="<%$ ConnectionStrings:Database1ConnectionString %>" DeleteCommand="DELETE FROM [Student] WHERE [sid] = @original_sid AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([sem] = @original_sem) OR ([sem] IS NULL AND @original_sem IS NULL)) AND (([cpi] = @original_cpi) OR ([cpi] IS NULL AND @original_cpi IS NULL)) AND (([contactno] = @original_contactno) OR ([contactno] IS NULL AND @original_contactno IS NULL)) AND (([emailid] = @original_emailid) OR ([emailid] IS NULL AND @original_emailid IS NULL))" InsertCommand="INSERT INTO [Student] ([name], [sem], [cpi], [contactno], [emailid]) VALUES (@name, @sem, @cpi, @contactno, @emailid)" OldValuesParameterFormatString="original_{0}" SelectCommand="SELECT * FROM [Student]" UpdateCommand="UPDATE [Student] SET [name] = @name, [sem] = @sem, [cpi] = @cpi, [contactno] = @contactno, [emailid] = @emailid WHERE [sid] = @original_sid AND (([name] = @original_name) OR ([name] IS NULL AND @original_name IS NULL)) AND (([sem] = @original_sem) OR ([sem] IS NULL AND @original_sem IS NULL)) AND (([cpi] = @original_cpi) OR ([cpi] IS NULL AND @original_cpi IS NULL)) AND (([contactno] = @original_contactno) OR ([contactno] IS NULL AND @original_contactno IS NULL)) AND (([emailid] = @original_emailid) OR ([emailid] IS NULL AND @original_emailid IS NULL))">
            <DeleteParameters>
                <asp:Parameter Name="original_sid" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_sem" Type="Int32" />
                <asp:Parameter Name="original_cpi" Type="Double" />
                <asp:Parameter Name="original_contactno" Type="Decimal" />
                <asp:Parameter Name="original_emailid" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="sem" Type="Int32" />
                <asp:Parameter Name="cpi" Type="Double" />
                <asp:Parameter Name="contactno" Type="Decimal" />
                <asp:Parameter Name="emailid" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="name" Type="String" />
                <asp:Parameter Name="sem" Type="Int32" />
                <asp:Parameter Name="cpi" Type="Double" />
                <asp:Parameter Name="contactno" Type="Decimal" />
                <asp:Parameter Name="emailid" Type="String" />
                <asp:Parameter Name="original_sid" Type="Int32" />
                <asp:Parameter Name="original_name" Type="String" />
                <asp:Parameter Name="original_sem" Type="Int32" />
                <asp:Parameter Name="original_cpi" Type="Double" />
                <asp:Parameter Name="original_contactno" Type="Decimal" />
                <asp:Parameter Name="original_emailid" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
    </form>
</body>
</html>
