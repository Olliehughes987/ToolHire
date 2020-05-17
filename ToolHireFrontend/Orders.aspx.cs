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
    Int32 StaffID;
    Int32 ClientID;
    Int32 TotalCost;
    DateTime DateAdded;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false) {
            if (OrderID != -1) {
                DisplayOrder();
            }
        }

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        string Error = "";
        AnOrder.OrderID = OrderID;
        AnOrder.ClientID = Convert.ToInt32(TxtClientID.Text);
        AnOrder.DateAdded = Convert.ToDateTime(TxtOrderDate.Text);
        AnOrder.StaffID = Convert.ToInt32(TxtStaffID.Text);
        AnOrder.TotalCost = Convert.ToInt32(TxtTotalCost.Text);
        AnOrder.Active = Processed.Checked;

        Error = AnOrder.Valid(Convert.ToString(ClientID), Convert.ToString(StaffID), DateAdded, Convert.ToString(TotalCost));
        if (Error == "")
        {
            clsOrders AnOrder = new clsOrders();
            AnOrder.OrderID = OrderID;
            AnOrder.ClientID = Convert.ToInt32(TxtClientID.Text);
            AnOrder.DateAdded = Convert.ToDateTime(TxtOrderDate.Text);
            AnOrder.StaffID = Convert.ToInt32(TxtStaffID.Text);
            AnOrder.TotalCost = Convert.ToInt32(TxtTotalCost.Text);
            AnOrder.Active = Processed.Checked;
            clsOrderCollection OrderList = new clsOrderCollection();
            if (OrderID == -1)
            {
                OrderList.ThisOrder = AnOrder;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisOrder.Find(OrderID);
                OrderList.ThisOrder = AnOrder;
                OrderList.Update();
            }
        }
        else
        {
            lblError.Text = Error;
        }

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

    void DisplayAddress(){
        clsOrderCollection OrderBook = new clsOrderCollection();
        OrderBook.Text.ThisOrder.Find(OrderID);
        TxtOrderID.Text = OrderBook.ThisOrder.OrderID.ToString();
        TxtClientID.Text = OrderBook.ThisOrder.ClientID.ToString();
        TxtStaffID.Text = OrderBook.ThisOrder.StaffID.ToString();
        TxtOrderDate.Text = OrderBook.ThisOrder.DateAdded.ToString();
        Processed.Checked = OrderBook.ThisOrder.Active;

    }
}