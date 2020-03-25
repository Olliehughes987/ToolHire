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


        public bool Find(int addressNo)
        {
            mToolId = 21;
            mCost = 21;
            mToolName = "Hammer";
            mDateAdded = Convert.ToDateTime("16/9/2015");
            mActive = true;
            mGrade= "Platinum";
            return true;
        }

    }
}