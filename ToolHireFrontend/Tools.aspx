<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tools.aspx.cs" Inherits="Tools" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 47px; top: 200px; position: absolute" Text="OK" />
        <asp:TextBox ID="txtToolName" runat="server" style="z-index: 1; left: 90px; top: 12px; position: absolute; margin-top: 17px;"></asp:TextBox>
        <p>
            ToolName</p>
        <p>
            GradeOfTool</p>
        <p>
            Replacement cost<asp:TextBox ID="txtCost" runat="server"></asp:TextBox>
         </p>
        <p>
            DateManufactured</p>
        <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 139px; top: 149px; position: absolute"></asp:TextBox>
        <asp:DropDownList ID="txtGrade" runat="server" style="z-index: 1; left: 117px; top: 72px; position: absolute" OnSelectedIndexChanged="ddlGrade_SelectedIndexChanged">
            <asp:ListItem>Platinum </asp:ListItem>
            <asp:ListItem>Default</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 152px; top: 201px; position: absolute" Text="Button" OnClick="Button1_Click" />
    </form>
</body>
</html>
