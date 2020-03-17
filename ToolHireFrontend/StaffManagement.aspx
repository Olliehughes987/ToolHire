<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffManagement.aspx.cs" Inherits="StaffManagement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
      <form id="form1" runat="server">
        <div>
            Staff Management</div>
        <p>
            StaffId<asp:TextBox ID="intStaffId" runat="server" style="margin-left: 70px" Width="117px" SkinID="intId"></asp:TextBox>
        </p>
        <p style="margin-bottom: 0px">
            Staff Name<asp:TextBox ID="txtName" runat="server" style="margin-left: 42px"></asp:TextBox>
        </p>
        <p style="margin-bottom: 0px">
            Staff Postcode<asp:TextBox ID="txtPostcode" runat="server" style="margin-left: 26px"></asp:TextBox>
        </p>
        <p style="margin-bottom: 0px">
            Date Hired<asp:TextBox ID="txtDateAdded" runat="server" Height="16px" style="margin-left: 47px; margin-right: 0px; margin-top: 3px; margin-bottom: 2px"></asp:TextBox>
        </p>
        <p style="margin-bottom: 0px">
            Staff Position<asp:TextBox ID="txtPosition" runat="server" style="margin-left: 32px"></asp:TextBox>
        </p>
        <p style="margin-bottom: 0px">
            &nbsp;</p>
        <asp:CheckBoxList ID="boolActive" runat="server">
            <asp:ListItem>Availability</asp:ListItem>
        </asp:CheckBoxList>
        <br />
        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="BtnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>
