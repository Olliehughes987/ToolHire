<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Client.aspx.cs" Inherits="Client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 106px; top: 236px; position: absolute" Text="OK" />
        <asp:TextBox ID="txtClientId" runat="server" style="z-index: 1; left: 113px; top: 163px; position: absolute"></asp:TextBox>
    </form>
</body>
</html>
