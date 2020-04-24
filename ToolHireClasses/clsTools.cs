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

        public string Valid(string ToolName, string Cost, string Grade, string DateAdded)
        {
            string Error = "";
            DateTime DateTemp;
            if (ToolName.Length == 0)
            {
                Error = Error + "The tool name may not be blank";
            }
            if (ToolName.Length > 20)
            {
                Error = Error + "The ToolName must be less the 20 Characters";
            }
            try
            {
                DateTemp = Convert.ToDateTime(DateAdded);
                if (DateTemp < DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date cannot be in the past : ";
                }
                //check to see if the date is greater than today's date
                if (DateTemp > DateTime.Now.Date)
                {
                    //record the error
                    Error = Error + "The date can not be in the future";
                }
            }
            catch
            {
                Error = Error + "The date was not a valid date : ";
            }
            if (Grade.Length == 0)
            {
                Error = Error + "The Grade name may not be blank";
            }
            if (Grade.Length > 20)
            {
                Error = Error + "The Grade must be less the 20 Characters";
            }

            if (Cost.Length == 0)
            {
                Error = Error + "The Grade name may not be blank";
            }
            if (Cost.Length > 10  )
            {
                Error = Error + "The Grade must be less the 20 Characters";
            }
            return Error;
        }
    }
}