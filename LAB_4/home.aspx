<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="WebApplication1.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table ID="Table1" runat="server">
            
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    Full Name :
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="Full_name" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="Full_name_validator" ControlToValidate="Full_name" ForeColor="Red" runat="server" ErrorMessage="Full Name can not be empty"></asp:RequiredFieldValidator>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    Age :
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="Age" TextMode="Number" runat="server"></asp:TextBox>
                    <asp:RangeValidator ID="Age_validator" ForeColor="Red" ControlToValidate="Age" Display="Dynamic" MinimumValue="18" MaximumValue="50" SetFocusOnError="true" Type="Integer" runat="server" ErrorMessage="Age must be between 18 to 50"></asp:RangeValidator>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    Password :
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="Password" TextMode="Password" runat="server"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            
            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    Confirm Password :
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="Confirm_password" TextMode="Password" runat="server"></asp:TextBox>
                    <asp:CompareValidator ID="pass_validator" ControlToCompare="Password" ControlToValidate="Confirm_password" Display="Dynamic" ForeColor="Red" runat="server" ErrorMessage="Passwords does not match"></asp:CompareValidator>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    Gender :
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:RadioButton ID="Male" runat="server" GroupName="Gender" Text="Male" />
                    <asp:RadioButton ID="Female" runat="server" GroupName="Gender" Text="Female" />
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    Mobile No :
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="Mobile_no" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="Mobile_no_validator" ControlToValidate="Mobile_no" Display="Dynamic" ForeColor="Red" SetFocusOnError="true" ValidationExpression="\d{10}" runat="server" ErrorMessage="Enter valid mobile no"></asp:RegularExpressionValidator>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    Hobbies :
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:CheckBox ID="Swimming" runat="server" Text="Swimming" />
                    <asp:CheckBox ID="Volleyball" runat="server" Text="Vollyball" />
                    <asp:CheckBox ID="Archery" runat="server" Text="Archery" />
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    State :
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:DropDownList ID="State" runat="server" Height="16px" OnSelectedIndexChanged="State_Changed" AutoPostBack="true">
                        <asp:ListItem>Gujarat</asp:ListItem>
                        <asp:ListItem>Maharastra</asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    City :
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:DropDownList ID="City" runat="server">
                        <asp:ListItem>Ahmedabad</asp:ListItem>
                        <asp:ListItem>Vadodara</asp:ListItem>
                        <asp:ListItem>Mumbai</asp:ListItem>
                        <asp:ListItem>Pune</asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow runat="server">
                <asp:TableCell runat="server">
                    PAN :
                </asp:TableCell>
                <asp:TableCell runat="server">
                    <asp:TextBox ID="PAN" runat="server"></asp:TextBox>
                    <asp:CustomValidator ID="PAN_validator" ControlToValidate="PAN" Display="Dynamic"  ValidateEmptyText="false"  runat="server" ErrorMessage="Enter Valid PAN number" ForeColor="Red" OnServerValidate="PAN_validate"></asp:CustomValidator>
                </asp:TableCell>
            </asp:TableRow>

            <asp:TableRow runat="server">
                <asp:TableCell runat="server" ColumnSpan="2" HorizontalAlign="Center">
                    <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:Label ID="message" ForeColor="Red" runat="server"></asp:Label>
    </form>
    <asp:Table runat="server">

        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                    Full Name :
            </asp:TableCell>
            <asp:TableCell runat="server">
                    <asp:Label ID="Full_name_lable" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                    Age :
            </asp:TableCell>
            <asp:TableCell runat="server">
                    <asp:Label ID="Age_label" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                    Gender :
            </asp:TableCell>
            <asp:TableCell runat="server">
                    <asp:Label ID="Gender_label" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                    Mobile no :
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:Label ID="Mobile_no_label" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                    Hobbies :
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:Label ID="Hobbies_label" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                    State :
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:Label ID="State_label" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                    City :
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:Label ID="City_label" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

        <asp:TableRow runat="server">
            <asp:TableCell runat="server">
                    PAN :
            </asp:TableCell>
            <asp:TableCell runat="server">
                <asp:Label ID="PAN_label" runat="server"></asp:Label>
            </asp:TableCell>
        </asp:TableRow>

    </asp:Table>
</body>
</html>
