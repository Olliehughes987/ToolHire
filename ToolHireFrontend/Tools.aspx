<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tools.aspx.cs" Inherits="Tools" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>         
         <asp:TextBox ID="txtGrade" runat="server" style="z-index: 1; left: 179px; top: 265px; position: absolute"></asp:TextBox>
         <asp:TextBox ID="txtToolName" runat="server" style="z-index: 1; left: 176px; top: 192px; position: absolute"></asp:TextBox>
         <asp:TextBox ID="txtToolId" runat="server" style="z-index: 1; left: 171px; top: 77px; position: absolute"></asp:TextBox>
         <asp:TextBox ID="txtCost" runat="server" style="z-index: 1; left: 173px; top: 131px; position: absolute"></asp:TextBox>
         <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 30px; top: 83px; position: absolute; width: 66px" Text="ToolId"></asp:Label>
         <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 36px; top: 118px; position: absolute" Text="Cost"></asp:Label>
         <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 32px; top: 191px; position: absolute" Text="Tool Name"></asp:Label>
         <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 48px; top: 263px; position: absolute" Text="Grade"></asp:Label>
         <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 51px; top: 313px; position: absolute" Text="Date Manufactured"></asp:Label>
         <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 180px; top: 312px; position: absolute"></asp:TextBox>
         <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 349px; top: 75px; position: absolute" Text="Find" />
        <div>
    </form>
</body>
</html>
