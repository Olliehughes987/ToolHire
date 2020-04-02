using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class Tools : System.Web.UI.Page
{ 
    
    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsTools AnTools = new clsTools();
        Int32 ToolId;
        Boolean Found = false;
        ToolId = Convert.ToInt32(txtToolId.Text);
        Found = AnTools.Find(ToolId);
        if (Found == true)
        {
            txtToolName.Text = AnTools.ToolName;
            txtGrade.Text = AnTools.Grade;
            txtCost.Text  = AnTools.Cost.ToString();
            txtDateAdded.Text = AnTools.DateAdded.ToString();
                
        }
    }
}