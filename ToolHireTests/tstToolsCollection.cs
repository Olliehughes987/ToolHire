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

      
    }
}
