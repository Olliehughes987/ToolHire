<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ToolList.aspx.cs" Inherits="ToolList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstTools" runat="server" style="z-index: 1; left: 17px; top: 28px; position: absolute; height: 182px; width: 155px"></asp:ListBox>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 41px; top: 248px; position: absolute" Text="Add" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 96px; top: 249px; position: absolute" Text="Delete" />
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 30px; top: 221px; position: absolute"></asp:Label>
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 174px; top: 247px; position: absolute" Text="Edit" />
        <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 13px; top: 294px; position: absolute" Text="Enter a Tool Name"></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 164px; top: 290px; position: absolute"></asp:TextBox>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 85px; top: 346px; position: absolute" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 168px; top: 343px; position: absolute" Text="Clear" />
    </form>
</body>
</html>
