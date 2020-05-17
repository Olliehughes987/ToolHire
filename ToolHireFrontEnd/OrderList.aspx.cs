using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ToolHireClasses;

public partial class OrderList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) {
            DisplayOrders();
        }
    }

    void DisplayOrders()
    {
        ToolHireClasses.clsOrderCollection Orders = new ToolHireClasses.clsOrderCollection();
        lstOrders.DataSource = Orders.OrderList;
        lstOrders.DataValueField = "OrderId";
        lstOrders.DataTextField = "ClientID";
        lstOrders.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderID"] = -1;
        Response.Redirect("Orders.aspx");
    }


    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrders.SelectedIndex != -1) {
            OrderId = Convert.ToInt32(lstOrders.SelectedValue);
            Session["OrderID"] = OrderId;
            Response.Redirect("DeleteOrders.aspx");
        }
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        Int32 OrderId;
        if (lstOrders.SelectedIndex != -1)
        {
            OrderId = Convert.ToInt32(lstOrders.SelectedIndex);
            Session["OrderId"] = OrderId;
            Response.Redirect("Orders.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByClientID(txtEnterClientID.Text);
        lstOrders.DataSource = Orders.OrderList;
        lstOrders.DataValueField = "OrderId";
        lstOrders.DataTextField = "ClientID";
        lstOrders.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsOrderCollection Orders = new clsOrderCollection();
        Orders.ReportByClientID("");
        txtEnterClientID.Text = "";
        lstOrders.DataSource = Orders.OrderList;
        lstOrders.DataValueField = "OrderId";
        lstOrders.DataTextField = "ClientID";
        lstOrders.DataBind();
    }
}