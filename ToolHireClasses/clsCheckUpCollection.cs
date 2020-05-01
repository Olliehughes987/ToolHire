using System;
using System.Collections.Generic;

namespace ToolHireClasses
{
    public class clsCheckUpCollection
    {
        List<clsCheckUp> mCheckUpList = new List<clsCheckUp>();

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
        public object ThisCheckUp { get; set; }

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





    }
}


