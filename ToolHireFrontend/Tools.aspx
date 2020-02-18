<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tools.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 357px">
    <form id="form1" runat="server">
        ToolId&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" style="margin-right: 0px; margin-top: 0px; margin-bottom: 0px"></asp:TextBox>
        <br />
        ToolName&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" style="margin-right: 0px; margin-top: 0px; margin-bottom: 0px"></asp:TextBox>
        <br />
        GradeOfTool&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" style="margin-right: 0px; margin-top: 0px; margin-bottom: 0px"></asp:TextBox>
        <br />
        Availabilitiy&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:CheckBox ID="Available" runat="server" />
        <br />
        ReplacementsCost&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server" style="margin-right: 0px; margin-top: 0px; margin-bottom: 0px"></asp:TextBox>
        <br />
        DateManufactured&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox6" runat="server" style="margin-right: 0px; margin-top: 0px; margin-bottom: 0px"></asp:TextBox>
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="  OK  " />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="Cancel" />
    </form>
</body>
</html>
