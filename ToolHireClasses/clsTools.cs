using System;

namespace ToolHireClasses
{
    public class clsTools
    {
        private int mToolId;
        private string mGrade;
        private string mToolName;
        private int mCost;
        private bool mActive;
        private DateTime mDateAdded;


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
        public bool Active
        {
            get
            {
                return mActive;
            }
            set
            {
                mActive = value;
            }
        }
        public int Cost
        {
            get
            {
                return mCost;
            }
            set
            {
                mCost = value;
            }
        }
        public string ToolName
        {
            get
            {
                return mToolName;
            }
            set
            {
                mToolName = value;
            }
        }
        public string Grade
        {
            get
            {
                return mGrade;
            }
            set
            {
                mGrade = value;
            }
        }
        public int ToolId {
            get
            {
                return mToolId;
            }
            set
            {
                mToolId = value;
            }
        }

        


        public bool Find(int ToolId)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ToolId", ToolId);
            DB.Execute("sproc_tblTools_FilterByToolId");
            if (DB.Count == 1)
            {
                mToolId = Convert.ToInt32(DB.DataTable.Rows[0]["ToolId"]);
                mCost = Convert.ToInt32(DB.DataTable.Rows[0]["Cost"]);
                mToolName = Convert.ToString(DB.DataTable.Rows[0]["ToolName"]);
                mDateAdded = Convert.ToDateTime(DB.DataTable.Rows[0]["DateManufactured"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Availability"]);
                mGrade = Convert.ToString(DB.DataTable.Rows[0]["GradeOfTool"]);
                return true;
            }
            else
            {
                return false;
            }
        }
        

    }
}