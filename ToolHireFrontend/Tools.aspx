<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Tools.aspx.cs" Inherits="Tools" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>         
         <asp:TextBox ID="txtGrade" runat="server" style="z-index: 1; left: 170px; top: 273px; position: absolute"></asp:TextBox>
         <asp:TextBox ID="txtToolName" runat="server" style="z-index: 1; left: 170px; top: 236px; position: absolute"></asp:TextBox>
         <asp:TextBox ID="txtToolId" runat="server" style="z-index: 1; left: 170px; top: 175px; position: absolute"></asp:TextBox>
         <asp:TextBox ID="txtCost" runat="server" style="z-index: 1; left: 170px; top: 204px; position: absolute"></asp:TextBox>
         <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 28px; top: 172px; position: absolute; width: 74px; right: 920px;" Text="ToolId"></asp:Label>
         <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 28px; top: 237px; position: absolute" Text="Tool Name"></asp:Label>
         <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 28px; top: 273px; position: absolute" Text="Grade"></asp:Label>
         <asp:Label ID="Label5" runat="server" style="z-index: 1; left: 28px; top: 311px; position: absolute" Text="Date Manufactured"></asp:Label>
         <asp:TextBox ID="txtDateAdded" runat="server" style="z-index: 1; left: 170px; top: 308px; position: absolute"></asp:TextBox>
        <div>
         </div>
         <p>
             &nbsp;</p>
         <p>
             &nbsp;</p>
         <asp:Button ID="OK" runat="server" style="z-index: 1; left: 153px; top: 369px; position: absolute" Text="OK" OnClick="OK_Click" />
         </div>
         <asp:Label ID="Label6" runat="server" style="z-index: 1; left: 29px; top: 205px; position: absolute; width: 38px; height: 19px;" Text="Cost"></asp:Label>
         <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 59px; top: 348px; position: absolute" Text="[lblError]"></asp:Label>
         <p>
         <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 379px; top: 173px; position: absolute" Text="Find" />
         </p>
    </form>
</body>
</html>
