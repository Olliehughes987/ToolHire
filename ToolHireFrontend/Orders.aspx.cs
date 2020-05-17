using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class Orders : System.Web.UI.Page
{
    Int32 OrderID;

    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrders Orders = new clsOrders();
        Orders = (clsOrders)Session["Orders"];
        Response.Redirect("OrdersViewer.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        AnOrder.OrderID = Convert.ToInt32(TxtOrderID.Text);
        AnOrder.ClientID = Convert.ToInt32(TxtClientID.Text);
        AnOrder.DateAdded = Convert.ToDateTime(TxtOrderDate.Text);
        AnOrder.StaffID = Convert.ToInt32(TxtStaffID.Text);
        AnOrder.TotalCost = Convert.ToInt32(TxtTotalCost.Text);
        Session["AnOrder"] = AnOrder;
        Response.Redirect("Orders.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        Int32 OrderID;
        Boolean Found = false;
        OrderID = Convert.ToInt32(TxtOrderID.Text);
        Found = AnOrder.Find(OrderID);

        if (Found)
        {
            TxtClientID.Text = Convert.ToString(AnOrder.ClientID);
            TxtOrderDate.Text = Convert.ToString(AnOrder.DateAdded);
            TxtStaffID.Text = Convert.ToString(AnOrder.StaffID);
            TxtTotalCost.Text = Convert.ToString(AnOrder.TotalCost);

        }

    }
}