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

        public string Valid(string OrderId,
                            string StaffId,
                            string CheckUpNo,
                            string Comments,
                            string DateAdded)
        {
            String Error = "";
            DateTime DateTemp;
            if (CheckUpNo.Length == 0)
            {
                Error = Error + "The Comments cannot be blank: ";
            }

            if (CheckUpNo.Length > 4)
            {
                Error = Error + "The Check Up No must be less than 6 characters : ";
            }

            try
            {

                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    Error = Error + "the date cannot be past : ";
                }

                if (DateTemp > DateTime.Now.Date)
                {
                    Error = Error + "The date cannot be future : ";

                }
            }

            catch
            {
                Error = Error + "The Date was not a valid date : ";
            }
            if (OrderId.Length == 0)
            {
                Error = Error + "The Staff Id cant be blank : ";
            }
            if (OrderId.Length > 6)
            {
                Error = Error + "The Order Id must be less than 6 characters : ";
            }

            if (StaffId.Length == 0)
            {
                Error = Error + "Staff Id cant be blank : ";
            }
            if (StaffId.Length > 6)
            {
                Error = Error + "The Staff Id must be less than 6 characters : ";
            }
            if (Comments.Length == 0)
            {
                Error = Error + "The Comments cant be blank : ";
            }
            if (Comments.Length > 50)
            {
                Error = Error + "Reached Comments Limit : ";
            }

            return Error;
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
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateAdded"]);
                mComments = Convert.ToString(DB.DataTable.Rows[0]["Comments"]); ;
                mToolReturn = Convert.ToBoolean(DB.DataTable.Rows[0]["ToolReturn"]);



                return true;
            }

            else

                return false;
        }


    }
}


    
