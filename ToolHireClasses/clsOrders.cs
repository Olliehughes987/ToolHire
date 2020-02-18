using System;

namespace ToolHireClasses
{
    public class clsOrders
    {
        private int mOrderID;
        public bool Active { get; set; }
        private DateTime mDateAdded;
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
        public int ClientID { get; set; }
        public int StaffID { get; set; }
        public double TotalCost { get; set; }

        public bool Find(int orderID)
        {
            mOrderID = 1;
            mDateAdded = Convert.ToDateTime("18/02/2020");
            return true;
        }
    }
}