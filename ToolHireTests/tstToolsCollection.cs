using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;  
using System.Collections.Generic;

namespace ToolHireTests
{
    [TestClass]
    public class tstToolsCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsToolsCollection AllTools = new clsToolsCollection();
            Assert.IsNotNull(AllTools);
        }

        [TestMethod]
        public void ToolListOK()
        {
            clsToolsCollection AllTools = new clsToolsCollection();
            List<clsTools> TestList = new List<clsTools>();
            clsTools TestItem = new clsTools();
            TestItem.Active = true;
            TestItem.ToolId = 1;
            TestItem.ToolName = "Screw Driver";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Cost = 21;
            TestItem.Grade = "Default";
            TestList.Add(TestItem);
            AllTools.ToolList = TestList;
            Assert.AreEqual(AllTools.ToolList, TestList);

        }

     

        [TestMethod]
        public void ThisToolOk()
        {
            clsToolsCollection AllTools = new clsToolsCollection();
            clsTools TestTools = new clsTools();
            TestTools.Active = true;
            TestTools.ToolId = 1;
            TestTools.ToolName = "Screw Driver";
            TestTools.DateAdded = DateTime.Now.Date;
            TestTools.Cost = 21;
            TestTools.Grade = "Default";
            AllTools.ThisTool = TestTools;
            Assert.AreEqual(AllTools.ThisTool, TestTools);
        }


        [TestMethod]
        public void ListAndCountOK()
        {
            clsToolsCollection AllTools = new clsToolsCollection();
            List<clsTools> TestList = new List<clsTools>();
            clsTools TestItem = new clsTools();
            TestItem.Active = true;
            TestItem.ToolId = 1;
            TestItem.ToolName = "Screw Driver";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Cost = 21;
            TestItem.Grade = "Default";
            TestList.Add(TestItem);
            AllTools.ToolList = TestList;
            Assert.AreEqual(AllTools.Count, TestList.Count);
        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsToolsCollection AllTools = new clsToolsCollection();
            clsTools TestItem = new clsTools();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.ToolId = 4;
            TestItem.Grade = "Default";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ToolName = "Spanner";
            TestItem.Cost = 1;
            AllTools.ThisTool = TestItem;
            PrimaryKey = AllTools.Add();
            TestItem.ToolId = PrimaryKey;
            AllTools.ThisTool.Find(PrimaryKey);
            Assert.AreEqual(AllTools.ThisTool, TestItem);
        }
        [TestMethod]
        public void DeleteMethodOk()
        {
            clsToolsCollection AllTools = new clsToolsCollection();
            clsTools TestItem = new clsTools();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.ToolId = 4;
            TestItem.Grade = "Default";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ToolName = "Spanner";
            TestItem.Cost = 1;
            AllTools.ThisTool = TestItem;
            PrimaryKey = AllTools.Add();
            TestItem.ToolId = PrimaryKey;
            AllTools.ThisTool.Find(PrimaryKey);
            AllTools.Delete();
            Boolean Found = AllTools.ThisTool.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOk()
        {
            clsToolsCollection AllTools = new clsToolsCollection();
            clsTools TestItem = new clsTools();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.Grade = "Default";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ToolName = "not Spanner";
            TestItem.Cost = 1;
            AllTools.ThisTool = TestItem;
            PrimaryKey = AllTools.Add();
            TestItem.ToolId = PrimaryKey;
            TestItem.Active = false;
            TestItem.Grade = "Default";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.ToolName = "Drill";
            TestItem.Cost = 6;
            AllTools.ThisTool = TestItem;
            AllTools.Update();
            AllTools.ThisTool.Find(PrimaryKey);
            Assert.AreEqual(AllTools.ThisTool, TestItem);
        }

        [TestMethod]
        public void ReportByToolNameMethodOk()
        {
            //create an instance of the class containing unfiltered results
            clsToolsCollection AllTools = new clsToolsCollection();
            //create an instance of the filtered data
            clsToolsCollection FilteredTools = new clsToolsCollection();
            FilteredTools.ReportByToolName("");
            //test to see that the two values are the same
            Assert.AreEqual(AllTools.Count, FilteredTools.Count);
        }

        [TestMethod]
        public void ReportByToolNameNoneFound()
        {
            //create an instance of the class containing unfiltered results
            clsToolsCollection FilteredTools = new clsToolsCollection();
            //Apply tool name that doesn't exist
            FilteredTools.ReportByToolName("euigq");
            //Test to see that there are no records
            Assert.AreEqual(0, FilteredTools.Count);
        }

        [TestMethod]
        public void ReportByToolNameTestDataFound()
        {
            //create an instance of the filtered data
            clsToolsCollection FilteredTools = new clsToolsCollection();
            //var to store outcome
            Boolean OK = true;
            //apply a tool name that doesn't exist 
            FilteredTools.ReportByToolName("Spanner");
            //check that the correct number of records are found 
            if (FilteredTools.Count == 2)
            {
                if(FilteredTools.ToolList[0].ToolId != 48)
                {
                    OK = false;
                }
                if(FilteredTools.ToolList[1].ToolId != 51)
                {
                    OK = false;
                }
            }
            else
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
