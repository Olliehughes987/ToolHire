<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tools.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 357px">
    <form id="form1" runat="server">
        ToolName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtToolName" runat="server" style="margin-right: 0px; margin-top: 0px; margin-bottom: 0px"></asp:TextBox>
        <br />
        GradeOfTool&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:DropDownList ID="ddlGradeOfToolList" runat="server">
            <asp:ListItem>Platinum</asp:ListItem>
            <asp:ListItem>Deafult</asp:ListItem>
        </asp:DropDownList>
        <br />
        ReplacementsCost&nbsp;&nbsp;&nbsp; <asp:TextBox ID="ReplacemntCostBox" runat="server" style="margin-right: 0px; margin-top: 0px; margin-bottom: 0px"></asp:TextBox>
        <br />
        DateManufactured&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="DateManufacturedBox" runat="server" style="margin-right: 0px; margin-top: 0px; margin-bottom: 0px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="OkButton" runat="server" OnClick="btnOK_Click" Text="  OK  " />
&nbsp;&nbsp;
        <asp:Button ID="CancelButton" runat="server" Text="Cancel" />
    </form>
</body>
</html>
