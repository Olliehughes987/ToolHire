using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsClient
        clsClient AnClient = new clsClient();
        //get the data from the session object
        AnClient = (clsClient)Session["AnClient"];
        //display the house number for this entry
        Response.Write(AnClient.ClientName);
    }
}