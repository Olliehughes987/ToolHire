<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Client.aspx.cs" Inherits="Client" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
     <form id="form1" runat="server">
      

         <asp:Label ID="Label1" runat="server" Text="ClientName:"></asp:Label>
        <asp:TextBox ID="txtClientName" runat="server" style="margin-left: 52px"></asp:TextBox>
     
      
         <br />
        <br />
     
      
         <asp:Label ID="Label2" runat="server" Text="BillingInformation:"></asp:Label>
        <asp:TextBox ID="txtBillingInformation" runat="server" style="margin-left: 19px"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="Label4" runat="server" Text="SignUpDate:"></asp:Label>
         <asp:TextBox ID="txtSignUpDate" runat="server" style="margin-left: 51px"></asp:TextBox>
         <br />
         <br />
         <asp:Label ID="Label3" runat="server" Text="SubscriptionType:"></asp:Label>
          <asp:TextBox ID="txtSubscriptionType" runat="server" style="margin-left: 51px"></asp:TextBox>
         
         <br />
         
         <br />
        <asp:Label ID="Label5" runat="server" Text=" Active:"></asp:Label>
        <asp:CheckBox ID="txtActive" runat="server" />
         <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
        <br />
        

    </form>
</body>
</html>
