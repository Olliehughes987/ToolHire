using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class OrdersViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        AnOrder = (clsOrders)Session["Orders"];
        Response.Write(AnOrder.OrderID);
    }
}


