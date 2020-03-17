using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class Client : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //create a new instance of clsClient
        clsClient AnClient = new clsClient();
        //capture the client name
        AnClient.ClientName = txtClientName.Text;
        //capture the clients billing information
        AnClient.BillingInformation = txtBillingInformation.Text;
        //capture the clients subscription type
        AnClient.SubscriptionType = txtSubscriptionType.Text;
        //capture the clients sign up date
        AnClient.SignUpDate =Convert.ToDateTime( txtSignUpDate.Text);
        //capture if the client is active or not
        AnClient.Active =Convert.ToBoolean( txtActive.Text);
        //redirect to the viewer page
        Response.Write("Default.aspx");
    }
}