using System;

namespace ToolHireClasses
{
    public class clsStaff
    {
        private bool mActive;
        private string mName;
        private int mStaffId;
        private string mPosition;
        private DateTime mDateAdded;
        private string mPostcode;

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

        public string position
        {
            get
            {
                return mPosition;
            }
            set
            {
                mPosition = value;
            }
        }

        public string Name
        {
            get
            {
                return mName;
            }
            set
            {
                mName = value;
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

        public int StaffId {
            get
            {
                return mStaffId;
            }
            set
            {
                mStaffId = value;
            }


        }

        public string Postcode
        {
            get
            {
                return mPostcode;
            }
            set
            {
                mPostcode = value;
            }
        }

            public bool Find(int StaffId) {

            mStaffId = 10;
            mPosition = "Manager";
            mPostcode = "CV23 0SS";
            mName = "Jacob Hartwell";
            mDateAdded = Convert.ToDateTime("11/02/2019");
            mActive = true;
            return true;
        }
        
        }
    }



