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

        public string Valid(string ClientID,
                            string StaffID,
                            DateTime DateAdded,
                            string TotalCost)
        {
            DateTime DateTemp;
            String Error = "";
            if (ClientID.Length == 0) {
                Error = Error + "The Client ID may not be blank : ";
            }

            if (ClientID.Length > 6) {
                Error = Error + "The Client ID must be less than 6 characters : ";
            }

            if (StaffID.Length == 0)
            {
                Error = Error + "The Staff ID may not be blank : ";
            }

            if (StaffID.Length > 6)
            {
                Error = Error + "The Staff ID must be less than 6 characters : ";
            }

            if (TotalCost.Length == 0)
            {
                Error = Error + "The Total Cost may not be blank : ";
            }

            if (StaffID.Length > 6)
            {
                Error = Error + "The Total Cost must be less than 6 characters : ";
            }

            try
            {
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the past : ";
                }
                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be in the future : ";
                }
            } catch {
                Error = Error + "The date was not a valid date : ";
            }

            return Error;
        }
    }
}