using System;
using System.Collections.Generic;

namespace ToolHireClasses
{
    public class clsCheckUpCollection
    {
        //private data members
        List<clsCheckUp> mCheckUpList = new List<clsCheckUp>();
        clsCheckUp mThisCheckUp = new clsCheckUp();

        public List<clsCheckUp> CheckUpList
        {
            get
            {
                return mCheckUpList;
            }
            set
            {
                mCheckUpList = value;
            }


        }


        public int Count
        {
            get
            {
                return mCheckUpList.Count;

            }
            set
            {

            }
        }

        public clsCheckUp ThisCheckUp
        {
            get
            {
                return mThisCheckUp;
            }
            set
            {
                mThisCheckUp = value;
            }
        }
      

    
        public clsCheckUpCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblCheckUp_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsCheckUp AnCheckUp = new clsCheckUp();
                AnCheckUp.ToolReturn = Convert.ToBoolean(DB.DataTable.Rows[Index]["ToolReturn"]);
                AnCheckUp.CheckUpId = Convert.ToInt32(DB.DataTable.Rows[Index]["CheckUpId"]);
                AnCheckUp.StaffId = Convert.ToInt32(DB.DataTable.Rows[Index]["StaffId"]);
                AnCheckUp.OrderId = Convert.ToInt32(DB.DataTable.Rows[Index]["OrderId"]);
                AnCheckUp.Comments = Convert.ToString(DB.DataTable.Rows[Index]["Comments"]);
                AnCheckUp.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateAdded"]);
                AnCheckUp.CheckUpNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CheckUpNo"]);
                mCheckUpList.Add(AnCheckUp);
                Index++;
            }

        }


        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("CheckUpNo", mThisCheckUp.CheckUpNo);
            DB.AddParameter("StaffId", mThisCheckUp.StaffId);
            DB.AddParameter("OrderId", mThisCheckUp.OrderId);
            DB.AddParameter("ToolReturn", mThisCheckUp.ToolReturn);
            DB.AddParameter("Comments", mThisCheckUp.Comments);
            DB.AddParameter("DateAdded", mThisCheckUp.DateAdded);
            return DB.Execute("sproc_tblCheckUp_Insert");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CheckUpId", mThisCheckUp.CheckUpId);
            DB.Execute("sproc_tblCheckUp_Delete");
        }

    }
}


