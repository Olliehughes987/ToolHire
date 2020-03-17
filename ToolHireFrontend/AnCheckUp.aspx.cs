using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class AnCheckUp : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Btnsubmit_Click(object sender, EventArgs e)
    {
        clsCheckUp AnCheckUp = new clsCheckUp();
        AnCheckUp.StaffId = Convert.ToInt32(txtStaffId.Text);
        AnCheckUp.OrderId = Convert.ToInt32(txtStaffId.Text);
        AnCheckUp.CheckUpNo = Convert.ToInt32(txtStaffId.Text);
        AnCheckUp.ToolReturn = Convert.ToBoolean(txtToolReturn.Text);
        AnCheckUp.Comments = txtComments.Text;
        AnCheckUp.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        Session["AnCheckUp"] = AnCheckUp;
        Response.Write("CheckUpViewer.aspx");


}

    protected void txtToolReturn_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Btncancel_Click(object sender, EventArgs e)
    {

    }

    protected void txtStaffId_TextChanged(object sender, EventArgs e)
    {

    }
}