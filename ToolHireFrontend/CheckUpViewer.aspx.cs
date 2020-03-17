using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class CheckUpViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCheckUp AnCheckUp = new clsCheckUp();
        AnCheckUp = (clsCheckUp)Session["AnCheckUp"];
        Response.Write(AnCheckUp.StaffId);

    }


}