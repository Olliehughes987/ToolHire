using System;
using System.Collections.Generic;

namespace ToolHireClasses
{
    public class clsOrderCollection
    {
        List<clsOrders> mOrderList = new List<clsOrders>();
        clsOrders mThisOrder = new clsOrders();

        public List<clsOrders> OrderList
        {
            get
            {
                return mOrderList;
            }
            set
            {
                mOrderList = value;
            }
        }

        public int Count
        {
            get
            {
                return mOrderList.Count;
            }
            set
            {

            }
        }

        public clsOrders ThisOrder
        {
            get
            {
                return mThisOrder;
            }
            set
            {
                mThisOrder = value;
            }

        }

        public clsOrderCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblAddress_SelectAll");
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClientID", mThisOrder.ClientID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@TotalCost", mThisOrder.TotalCost);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@Active", mThisOrder.Active);
            return DB.Execute("sproc_tblOrders_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", mThisOrder.OrderID);
            DB.Execute("sproc_tblOrders_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClientID", mThisOrder.ClientID);
            DB.AddParameter("@StaffID", mThisOrder.StaffID);
            DB.AddParameter("@TotalCost", mThisOrder.TotalCost);
            DB.AddParameter("@DateAdded", mThisOrder.DateAdded);
            DB.AddParameter("@Active", mThisOrder.Active);
            DB.Execute("sproc_tblOrders_Update");
        }

        public void ReportByClientID(string ClientID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ClientID", ClientID);
            DB.Execute("sproc_tblOrders_FilterByClientID");
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mOrderList = new List<clsOrders>();
            while (Index < RecordCount) {
                clsOrders AnOrder = new clsOrders();
                AnOrder.OrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                AnOrder.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                AnOrder.ClientID = Convert.ToInt32(DB.DataTable.Rows[0]["ClientID"]);
                AnOrder.Active = Convert.ToBoolean(DB.DataTable.Rows[0]["Processed"]);
                AnOrder.TotalCost = Convert.ToInt32(DB.DataTable.Rows[0]["TotalCost"]);
                AnOrder.StaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                mOrderList.Add(AnOrder);
                Index++;
            }
        }




    }

}