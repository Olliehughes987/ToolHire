<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCheckUp.aspx.cs" Inherits="DeleteCheckUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 157px">
    <form id="form1" runat="server">
        <div style="height: 160px">
            Are you sure you want to delete this record?<br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="BtnNo" runat="server" Text="No" />
        </div>
    </form>
</body>
</html>
