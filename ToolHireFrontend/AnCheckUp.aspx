<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnCheckUp.aspx.cs" Inherits="AnCheckUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            StaffId:<asp:TextBox ID="txtStaffId" runat="server" style="margin-left: 74px" Width="118px" OnTextChanged="txtStaffId_TextChanged"></asp:TextBox>
            <br />
            OrderId:<asp:TextBox ID="txtOrderId" runat="server" style="margin-left: 65px"></asp:TextBox>
            <br />
            No.OfCheckUps:<asp:TextBox ID="txtCheckUpNo" runat="server" style="margin-left: 10px"></asp:TextBox>
            <br />
            ToolsReturned:<asp:DropDownList ID="txtToolReturn" runat="server" style="margin-left: 26px" OnSelectedIndexChanged="txtToolReturn_SelectedIndexChanged">
                <asp:ListItem Selected="True">Yes</asp:ListItem>
                <asp:ListItem Enabled="False">No</asp:ListItem>
            </asp:DropDownList>
            <br />
            Comments:<asp:TextBox ID="txtComments" runat="server" style="margin-left: 49px"></asp:TextBox>
            <br />
            Date<asp:TextBox ID="txtDateAdded" runat="server" style="margin-left: 88px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btnsubmit" runat="server" Text="Submit" OnClick="Btnsubmit_Click" />   
            <asp:Button ID="Btncancel" runat="server" Text="Cancel" OnClick="Btncancel_Click" />   
        </div>
    </form>
</body>
</html>
