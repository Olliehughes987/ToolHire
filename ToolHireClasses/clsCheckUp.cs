using System;

namespace ToolHireClasses
{
    public class clsCheckUp
    {
        public string comments;
        private int mStaffId;
        private DateTime mDateAdded;
        private int mCheckUpId;
        private int mOrderId;
        private int mCheckUpNo;


        public bool ToolReturn { get; set; }
        public DateTime DateAdded 
        {
            get
            {
                return mDateAdded;
            }
            set
            {
                mDateAdded = value;
            }
        }
        public int CheckUpNo
        {
            get
            {
                return mCheckUpNo;
            }
            set
            {
                mCheckUpNo = value;
            }
        }
        public int OrderId
        {
            get
            {
                return mOrderId;
            }
            set
            {
                mOrderId = value;
            }
        }
 
        public int CheckUpId
        {
            get
            {
                return mCheckUpId;
            }
            set
            {
                mCheckUpId = value;
            }
        }
        public string Comments
        {
            get
            {
                return comments;
            }
            set
            {
                comments = value;
            }
        }

        public bool Find(int StaffId)
        {
            mStaffId = 12;
            mDateAdded = Convert.ToDateTime("16/9/2015");
            return true;
        }

    }


}