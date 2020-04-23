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
        AnCheckUp.CheckUpId = Convert.ToInt32(txtCheckUpId.Text);
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









    protected void BtnFind_Click(object sender, EventArgs e)
    {
        clsCheckUp AnCheckUp = new clsCheckUp();
        Int32 CheckUpId;
        Boolean Found = false;
        CheckUpId = Convert.ToInt32(txtCheckUpId.Text);
        Found = AnCheckUp.Find(CheckUpId);
        if (Found == true)
        {
            txtCheckUpNo.Text = AnCheckUp.CheckUpNo.ToString();
            txtComments.Text = AnCheckUp.Comments;
            txtDateAdded.Text = AnCheckUp.DateAdded.ToString();
            txtOrderId.Text = AnCheckUp.OrderId.ToString();
            txtStaffId.Text = AnCheckUp.StaffId.ToString();
            txtToolReturn.Text = AnCheckUp.ToolReturn.ToString();

        }


    }
}