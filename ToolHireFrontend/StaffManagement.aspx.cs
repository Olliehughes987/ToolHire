using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;
public partial class StaffManagement : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        clsStaff AnStaff = new clsStaff();
        // Capture staff name
        AnStaff.Name = txtName.Text;
        // Capture staff id
        AnStaff.StaffId = Convert.ToInt32(intStaffId.Text);
        // Capture staff postcode
        AnStaff.Postcode = txtPostcode.Text;
        // Capture staff position
        AnStaff.position = txtPosition.Text;
        // Capture Staff Active
        AnStaff.Active = Convert.ToBoolean(boolActive.Text);
        // Capture Staff DateAdded
        AnStaff.DateAdded = Convert.ToDateTime(txtDateAdded.Text);

        // Stores data in the session object
        Session["AnStaff"] = AnStaff;
        // redirect to viewer page
        Response.Redirect("StaffManagementViewer.aspx");
    }
}