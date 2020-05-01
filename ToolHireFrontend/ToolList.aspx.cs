using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

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





    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ToolId"] = -1;
        Response.Redirect("Tools.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ToolId;
        if (lstTools.SelectedIndex != 1)
        {
            ToolId = Convert.ToInt32(lstTools.SelectedValue);
            Session["ToolId"] = ToolId;
            Response.Redirect("DeleteTools.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 ToolId;
        if (lstTools.SelectedIndex != -1)
        {
            ToolId = Convert.ToInt32(lstTools.SelectedValue);
            Session["ToolId"] = ToolId;
            Response.Redirect("AnTools.aspx");

        }
        else
        {
            lblError.Text = "Please select a record edit from this list";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        //create an instance of the tools collection
        clsToolsCollection Tool = new clsToolsCollection();
        Tool.ReportByToolName(txtFilter.Text);
        lstTools.DataSource = Tool.ToolList;
        //set the name of the primary key
        lstTools.DataValueField = "ToolId";
        //set the name of the field to display
        lstTools.DataTextField = "ToolName";
        //bind the data to the list
        lstTools.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        //create an instance of the tool collection
        clsToolsCollection Tool = new clsToolsCollection();
        Tool.ReportByToolName("");
        //clear any existing filter to tidy up the database
        txtFilter.Text = "";
        lstTools.DataSource = Tool.ToolList;
        //set the name of the primary key
        lstTools.DataValueField = "ToolId";
        //set the name of the field to display
        lstTools.DataTextField = "ToolName";
        //bind the data to the list
        lstTools.DataBind();

    }
}