using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class ToolsViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsTools AnTools = new clsTools();
        AnTools = (clsTools)Session["AnTools"];
        Response.Write(AnTools.ToolId);

    }


}