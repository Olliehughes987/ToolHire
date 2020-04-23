<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnCheckUp.aspx.cs" Inherits="AnCheckUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            CheckUpId:<asp:TextBox ID="txtCheckUpId" runat="server" style="margin-left: 84px" Width="352px" OnTextChanged="txtStaffId_TextChanged"></asp:TextBox>
            <asp:Button ID="BtnFind" runat="server" Text="Find" OnClick="BtnFind_Click" />
            <br />
            StaffId:<asp:TextBox ID="txtStaffId" runat="server" style="margin-left: 147px" Width="352px" OnTextChanged="txtStaffId_TextChanged"></asp:TextBox>
            <br />
            OrderId:<asp:TextBox ID="txtOrderId" runat="server" style="margin-left: 139px" Width="355px"></asp:TextBox>
            <br />
            No.OfCheckUps:<asp:TextBox ID="txtCheckUpNo" runat="server" style="margin-left: 10px" Width="357px"></asp:TextBox>
            <br />
            ToolsReturned:<asp:DropDownList ID="txtToolReturn" runat="server" style="margin-left: 45px" OnSelectedIndexChanged="txtToolReturn_SelectedIndexChanged" Width="122px">
                <asp:ListItem Selected="True">Yes</asp:ListItem>
                <asp:ListItem Enabled="False">No</asp:ListItem>
            </asp:DropDownList>
            <br />
            Comments:<asp:TextBox ID="txtComments" runat="server" style="margin-left: 102px" Width="365px"></asp:TextBox>
            <br />
            Date<asp:TextBox ID="txtDateAdded" runat="server" style="margin-left: 196px" Width="369px"></asp:TextBox>
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Btnsubmit" runat="server" Text="Submit" OnClick="Btnsubmit_Click" />   
            <asp:Button ID="Btncancel" runat="server" Text="Cancel" OnClick="Btncancel_Click" />   
        </div>
    </form>
</body>
</html>
