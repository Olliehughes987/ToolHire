using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireTests;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsClient
        clsClient AnClient = new clsClient();

        ////capture the clients number
        //AnClient.ClientId = txtClientId.Text;
        ////capture the clients name
        //AnClient.ClientName = txtClientName.Text;
        ////capture the billing information
        //AnClient.BillingInformation = txtBillingInformation.Text;
        ////capture the subscription type
        //AnClient.SubscriptionType = txtSubscriptionType.Text;
        ////capture the sign up date
        //AnClient.SignUpDate = txtSignUpDate.Text;
        ////capture if the client is active or not
        //AnClient.Active = txtActive.Text;
        ////store the address in the session object
        //Session["AnClient"] = AnClient;
        ////redirect to the viewer page
        //Response.Write("ClientViewer.aspx");
        

        
       
    }
}