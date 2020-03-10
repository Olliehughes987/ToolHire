using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class Orders : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        AnOrder.OrderID = TxtOrderID.Text;
        AnOrder.ClientID = TxtClientID.Text;
        AnOrder.DateAdded = Convert.ToDateTime(TxtDateAdded.Text);
        AnOrder.StaffID = TxtStaffID.Text;
        AnOrder.TotalCost = TxtTotalCost.Text;
        Response.Redirect("Orders.aspx");
    } 
}