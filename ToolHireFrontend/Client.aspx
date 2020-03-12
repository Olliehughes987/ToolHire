<%@ Page Language="C#" AutoEventWireup="true" CodeFile="client.aspx.cs" Inherits="client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
        <div>
        </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
&nbsp;ClientId:<asp:TextBox ID="txtClientId" runat="server" style="margin-left: 72px; margin-right: 2px; margin-top: 0px"></asp:TextBox>
        <br />
        <br />
        ClientName:<asp:TextBox ID="txtClientName" runat="server" style="margin-left: 52px"></asp:TextBox>
        <br />
        <br />
        BillingInformation:<asp:TextBox ID="txtBillingInformation" runat="server" style="margin-left: 19px"></asp:TextBox>
        <br />
        <br />
        SubscriptionType:<asp:DropDownList ID="txtSubscriptionType" runat="server" style="margin-left: 21px">
        </asp:DropDownList>
        <br />
        <br />
        SignUpDate:<asp:TextBox ID="txtSignUpDate" runat="server" style="margin-left: 51px"></asp:TextBox>
        <br />
        <br />
        Active:<asp:CheckBox ID="txtActive" runat="server" />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
        <br />
        

    </form>
</body>
</html>
