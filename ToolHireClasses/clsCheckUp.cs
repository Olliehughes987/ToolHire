using System;

namespace ToolHireClasses
{
    public class clsCheckUp
    {
        private string mComments;
        private int mStaffId;
        private DateTime mDateAdded;
        private int mCheckUpId;
        private int mOrderId;
        private int mCheckUpNo;
        private bool mToolReturn;



        public bool ToolReturn
        {
            get
            {
                return mToolReturn;
            }
            set
            {
                mToolReturn = value;
            }
        }
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
                return mComments;
            }
            set
            {
                mComments = value;
            }
        }
        public int StaffId
        {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }
        }

        public bool Find(int CheckUpId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CheckUpId", CheckUpId);
            DB.Execute("sproc_tblCheckUpId_FilterByCheckUpId");
            if (DB.Count == 1)
            {

                mStaffId = Convert.ToInt32(DB.DataTable.Rows[0]["StaffId"]);
                mOrderId = Convert.ToInt32(DB.DataTable.Rows[0]["OrderId"]); ;
                mCheckUpNo = Convert.ToInt32(DB.DataTable.Rows[0]["CheckUpNo"]);
                mCheckUpId = Convert.ToInt32(DB.DataTable.Rows[0]["CheckUpId"]); ;
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateOfCheckup"]);
                mComments = Convert.ToString(DB.DataTable.Rows[0]["Comments"]); ;
                mToolReturn = Convert.ToBoolean(DB.DataTable.Rows[0]["ToolReturn"]);



                return true;
            }

            else

                return false;
        }
}


    }
