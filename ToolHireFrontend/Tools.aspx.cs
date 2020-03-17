using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class Tools : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsTools AnTools = new clsTools();
        AnTools.ToolName = txtToolName.Text;
        AnTools.Grade = txtGrade.Text;
        AnTools.Cost = Convert.ToInt32(txtCost.Text);
        AnTools.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        Session["AnTools"] = AnTools;
        Response.Redirect("ToolViewer.aspx");

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

  
}