using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class CheckUpList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (IsPostBack == false)
        {
            DisplayAllCheckUp();
        }

    }

    void DisplayAllCheckUp()
    {
        ToolHireClasses.clsCheckUpCollection AnCheckUp = new ToolHireClasses.clsCheckUpCollection();
        lstCheckUplist.DataSource = AnCheckUp.CheckUpList;
        lstCheckUplist.DataValueField = "CheckUpId";
        lstCheckUplist.DataTextField = "Comments";
        lstCheckUplist.DataBind();
    }



    protected void lstCheckUplist_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CheckUpId"] = -1;
        Response.Redirect("AnCheckUp.aspx");
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CheckUpId;

        if (lstCheckUplist.SelectedIndex != -1)
        {
            CheckUpId = Convert.ToInt32(lstCheckUplist.SelectedValue);
            Session["CheckUpId"] = CheckUpId;
            Response.Redirect("DeleteCheckUp.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }
}