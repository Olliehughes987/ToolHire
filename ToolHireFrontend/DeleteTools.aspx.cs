using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;
using ToolHireTests;

public partial class DeleteTools : System.Web.UI.Page
{
    Int32 ToolId;
    protected void Page_Load(object sender, EventArgs e)
    {
        ToolId = Convert.ToInt32(Session["ToolId"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsToolsCollection ToolsBook = new clsToolsCollection();
        ToolsBook.ThisTool.Find(ToolId);
        ToolsBook.Delete();
        Response.Redirect("ToolList.aspx");
    }
}