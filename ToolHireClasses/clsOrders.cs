using System;

namespace ToolHireClasses
{
    public class clsOrders
    {
        private int mOrderID;

        private DateTime mDateAdded;
        private int mClientID;
        private int mStaffID;
        private double mTotalCost;
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
        public double TotalCost {
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
            mOrderID = 1;
            mClientID = 1;
            mStaffID = 1;
            mTotalCost = 15.00;
            mDateAdded = Convert.ToDateTime("18/02/2020");
            return true;
        }
    }
}