<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 921px; width: 763px">
    <form id="form1" runat="server">
        <div style="height: 917px; width: 764px">
            OrderID&nbsp;
            <asp:TextBox ID="TxtOrderID" runat="server"></asp:TextBox>
            &nbsp;<asp:Button ID="btnFind" runat="server" Height="37px" OnClick="btnFind_Click" Text="Find" Width="84px" />
            <br />
            OrderDate
            <asp:TextBox ID="TxtOrderDate" runat="server"></asp:TextBox>
            <br />
            ClientID
            <asp:TextBox ID="TxtClientID" runat="server"></asp:TextBox>
            <br />
            StaffID
            <asp:TextBox ID="TxtStaffID" runat="server"></asp:TextBox>
            <br />
            TotalCost
            <asp:TextBox ID="TxtTotalCost" runat="server"></asp:TextBox>
            <br />
            <asp:CheckBox ID="Processed" runat="server" />
            <br />
            <asp:Button ID="btnOK" runat="server" Height="44px" OnClick="btnOK_Click" Text="OK" Width="83px" />
            <asp:Button ID="btnCancel" runat="server" Height="46px" Text="Cancel" Width="117px" />
        </div>
    </form>
</body>
</html>
