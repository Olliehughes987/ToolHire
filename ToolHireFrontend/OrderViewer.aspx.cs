﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class OrderViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsOrders AnOrder = new clsOrders();
        AnOrder = (clsOrders)Session["AnOrder"];
        Response.Write(AnOrder.OrderID);
    }
}