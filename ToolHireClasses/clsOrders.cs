using System;

namespace ToolHireClasses
{
    public class clsOrders
    {
        private int mOrderID;
        private DateTime mDateAdded;
        private int mClientID;
        private int mStaffID;
        private int mTotalCost;
        private bool mActive;

        public bool Active {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }

        }
        public int OrderID
        {
            get
            {
                return mOrderID;
            }
            set
            {
                mOrderID = value;
            }
        }

        public DateTime DateAdded {
            get {
                return mDateAdded;
            }
            set {
                mDateAdded = value;
            }
        }
        public int ClientID {
            get {
                return mClientID;
            }
            set
            {
                mClientID = value;
            }
        }
        public int StaffID {
            get
            {
                return mStaffID;
            }
            set
            {
                mStaffID = value;
            }
        }
        public int TotalCost {
            get
            {
                return mTotalCost;
            }
            set
            {
                mTotalCost = value;
            }
        }


        public bool Find(int orderID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@OrderId", OrderID);
            DB.Execute("sproc_tblOrders_FilterByOrderID");

            if (DB.Count == 1)
            {
                mOrderID = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["OrderDate"]);
                mClientID = Convert.ToInt32(DB.DataTable.Rows[0]["ClientID"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Processed"]);
                mTotalCost = Convert.ToInt32(DB.DataTable.Rows[0]["TotalCost"]);
                mStaffID = Convert.ToInt32(DB.DataTable.Rows[0]["StaffID"]);
                return true;
            }
            else
            {
                return true;
            }

            
        }
    }
}