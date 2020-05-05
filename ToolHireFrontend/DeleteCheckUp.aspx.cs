using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;


public partial class DeleteCheckUp : System.Web.UI.Page
{
    Int32 CheckUpId;

    protected void Page_Load(object sender, EventArgs e)
    {
        CheckUpId = Convert.ToInt32(Session["CheckUpId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsCheckUpCollection AllCheckUp = new clsCheckUpCollection();
        AllCheckUp.ThisCheckUp.Find(CheckUpId);
        AllCheckUp.Delete();
        Response.Redirect("CheckUpList.aspx");

    }
}