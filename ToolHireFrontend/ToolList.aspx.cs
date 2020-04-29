using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ToolList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayTools();
        }

    }
    void DisplayTools()
    {
        ToolHireClasses.clsToolsCollection Tools = new ToolHireClasses.clsToolsCollection();
        lstTools.DataSource = Tools.ToolList;
        lstTools.DataValueField = "ToolId";
        lstTools.DataTextField = "ToolName";
        lstTools.DataBind();
    }



    
}