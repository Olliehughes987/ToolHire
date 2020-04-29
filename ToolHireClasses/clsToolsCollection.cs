using System;
using System.Collections.Generic;

namespace ToolHireClasses
{
    public class clsToolsCollection
    {
        List<clsTools> mToolsList = new List<clsTools>();

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
        public clsTools ThisTool { get; set; }

        public clsToolsCollection()
        {
            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblTools_SelectAll");
            RecordCount = DB.Count;
            while (Index < RecordCount)
            {
                clsTools AnTools = new clsTools();
                AnTools.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Availability"]);
                AnTools.ToolId = Convert.ToInt32(DB.DataTable.Rows[Index]["ToolId"]);
                AnTools.Cost = Convert.ToInt32(DB.DataTable.Rows[Index]["Cost"]);
                AnTools.ToolName = Convert.ToString(DB.DataTable.Rows[Index]["ToolName"]);
                AnTools.DateAdded = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateManufactured"]);
                AnTools.Grade = Convert.ToString(DB.DataTable.Rows[Index]["GradeOfTool"]);
                mToolsList.Add(AnTools);
                Index++;
            }



        }
    }
}