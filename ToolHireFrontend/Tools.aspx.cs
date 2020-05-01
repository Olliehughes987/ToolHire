using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class Tools : System.Web.UI.Page
{
    //varible to store the primary key with page level scope
    Int32 ToolId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the tool to be processed
        ToolId = Convert.ToInt32(Session["ToolId"]);
        if (IsPostBack == false)
        {
            //i this is not a new record
            if (ToolId != -1)
            {
                //display the current data for the record
                DisplayTools();
            }
        }

    }

    void DisplayTools()
    {
        //create a instance of the tool book
        clsToolsCollection ToolBook = new clsToolsCollection();
        //find record to update
        ToolBook.ThisTool.Find(ToolId);
        //Display the data for this record
        txtToolId.Text = ToolBook.ThisTool.ToolId.ToString();
        txtCost.Text = ToolBook.ThisTool.Cost.ToString();
        txtGrade.Text = ToolBook.ThisTool.Grade;
        txtDateAdded.Text = ToolBook.ThisTool.DateAdded.ToString();
        chkActive.Checked = ToolBook.ThisTool.Active;
        txtToolName.Text = ToolBook.ThisTool.ToolName;

    }

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

    



    protected void OK_Click(object sender, EventArgs e)
    {
        clsTools AnTools = new clsTools();
        string Grade = txtGrade.Text;
        string Cost = txtCost.Text;
        string ToolName = txtToolName.Text;
        string DateAdded = txtDateAdded.Text;
        string Error = "";
        Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
        if (Error == "")
        {
            //capture tool id
            AnTools.ToolId = ToolId;
            //capture grade
            AnTools.Grade = Grade;
            //capture cost
            AnTools.Cost = Convert.ToInt32(Cost);
            //capture toolname
            AnTools.ToolName = ToolName;
            //capture date added
            AnTools.DateAdded = Convert.ToDateTime(DateAdded);
            //capture active
            AnTools.Active = chkActive.Checked;
            //create a new instance of the tools collection 
            clsToolsCollection ToolsList = new clsToolsCollection();
            //if this is a new record then add  data
            if (ToolId == -1)
            {
                //set the this tool property
                ToolsList.ThisTool = AnTools;
                //add new record
                ToolsList.Add();
            }
            //otherwise it must be a update
            else
            {
                //find the record to update
                ToolsList.ThisTool.Find(ToolId);
                //set the this tool
                ToolsList.ThisTool = AnTools;
                //update the record
                ToolsList.Update();
            }
            //redirect back to list page
            Response.Redirect("ToolList.aspx");
            }
            else
            {
                //display error message
                lblError.Text = Error;
            }
        

    }
}