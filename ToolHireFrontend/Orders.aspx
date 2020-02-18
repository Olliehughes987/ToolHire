<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="width: 253px; height: 192px">
    <form id="form1" runat="server">
        <br />
        <asp:Image ID="Image1" runat="server" Height="132px" ImageUrl="~/toolhire.png" Width="123px" />
        <br />
        <br />
        OrderID&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" style="margin-left: 16px" Width="132px"></asp:TextBox>
        <br />
        ClientID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" Width="134px"></asp:TextBox>
        <br />
        StaffID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server" Width="134px"></asp:TextBox>
        <br />
        DateAdded
        <asp:TextBox ID="TextBox4" runat="server" Width="134px"></asp:TextBox>
        <br />
        TotalCost&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" Width="134px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="Processed" runat="server" />
        <br />
        <asp:Button ID="OKButton" runat="server" Text="OK" Width="41px" />
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" style="margin-left: 18px" Width="59px" />
    </form>
    </body>
</html>
