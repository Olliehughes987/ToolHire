using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

    }

    protected void btnOK_Click(Object sender, EventArgs e)
    {
        clsTools AnTools = new clsTools();
        //AnTools.ToolName = txtToolName.Text;
        //AnTools.Grade = txtGrade.Text;
        //AnTools.Cost = txtCost.Text;
        //AnTools.DateAdded = txtDateAdded.Text;

        Session["AnTools"] = AnTools;
        Response.Redirect("ToolViewer.aspx");
    }

}