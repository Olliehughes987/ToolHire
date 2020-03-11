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
                mToolId = Value;
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
                mToolId = Value;
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
                mToolId = Value;
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
                mToolId = Value;
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
                mToolId = Value;
            }
        }
        public int ToolId {
            get
            {
                return mToolId;
            }
            set
            {
                mToolId = Value;
            }
        }

        public int Value { get; private set; }

        public bool Find(int addressNo)
        {
            mToolId = 21;
            mCost = 21;
            mToolName = "Hammer";

            return true;
        }

    }
}