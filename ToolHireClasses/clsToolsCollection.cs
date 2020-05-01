using System;
using System.Collections.Generic;

namespace ToolHireClasses
{
    public class clsToolsCollection
    {
        List<clsTools> mToolsList = new List<clsTools>();

        clsTools mThisTool = new clsTools();

        public List<clsTools> ToolList
        {
            get
            {
                return mToolsList;
            }
            set
            {
                mToolsList = value;
            }
        }
        public int Count
        {
            get
            {
                return mToolsList.Count;
            }
            set
            {

            }
        }
        public clsTools ThisTool
        {
            get
            {
                return mThisTool;
            }
            set
            {
                mThisTool = value;
            }
        }

        public clsToolsCollection()
        {
            //object for data connection
            clsDataConnection DB = new clsDataConnection();
            //exectue stored procedure
            DB.Execute("sproc_tblTools_SelectAll");
            //PopulateArray array list with data table
            PopulateArray(DB);
        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ToolName", mThisTool.ToolName);
            DB.AddParameter("@Cost", mThisTool.Cost);
            DB.AddParameter("@DateManufactured", mThisTool.DateAdded);
            DB.AddParameter("@GradeOfTool", mThisTool.Grade);
            DB.AddParameter("@Availability", mThisTool.Active);
            return DB.Execute("sproc_tblTools_Insert");

        }

        public void Delete()
        {
            clsDataConnection Db = new clsDataConnection();
            Db.AddParameter("@ToolId", mThisTool.ToolId);
            Db.Execute("sproc_tblTools_Delete");
        }

        public void Update()
        {
            //Update an existing record vased on values of thisTool
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //set the parameters for the stored procedure
            DB.AddParameter("@ToolId", mThisTool.ToolId);
            DB.AddParameter("@ToolName", mThisTool.ToolName);
            DB.AddParameter("@Cost", mThisTool.Cost);
            DB.AddParameter("@DateManufactured", mThisTool.DateAdded);
            DB.AddParameter("@GradeOfTool", mThisTool.Grade);
            DB.AddParameter("@Availability", mThisTool.Active);
            DB.Execute("sproc_tblTools_Update");
        }

        public void ReportByToolName(string ToolName)
        {
            //filters the records based on a full or partial tool name
            //connect to the database
            clsDataConnection DB = new clsDataConnection();
            //Send the toolname parameter to the database
            DB.AddParameter("@ToolName", ToolName);
            //execute the stored procedure
            DB.Execute("sproc_tblTools_FilterByToolName");
            //populate the array list with a datatable
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            //populates the array list based on the data table in the parameter DB
            //var for the index
            Int32 Index = 0;
            //var to store the record count
            Int32 RecordCount;
            //get the count of records
            RecordCount = DB.Count;
            //clear private array list
            mToolsList = new List<clsTools>();
            //while there are no records to process
            while(Index < RecordCount)
            {
                //create a blank tool
                clsTools AnTools = new clsTools();
                //read in the fields from the current record
                AnTools.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnTools.ToolId = Convert.ToInt32(DB.DataTable.Rows[Index]["ToolId"]);
                AnTools.Cost = Convert.ToInt32(DB.DataTable.Rows[Index]["Cost"]);
                AnTools.ToolName = Convert.ToString(DB.DataTable.Rows[Index]["ToolName"]);
                AnTools.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateManufactured"]);
                AnTools.Grade = Convert.ToString(DB.DataTable.Rows[Index]["GradeOfTool"]);
                //add the record to the private data mamber
                mToolsList.Add(AnTools);
                //point at the next record
                Index++;
            }
        }
    }
}   