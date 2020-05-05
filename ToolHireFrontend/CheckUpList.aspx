<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CheckUpList.aspx.cs" Inherits="CheckUpList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 812px;
        }
    </style>
</head>
<body style="height: 807px">
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstCheckUplist" runat="server" Height="671px" OnSelectedIndexChanged="lstCheckUplist_SelectedIndexChanged" Width="616px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>
