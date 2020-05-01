using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;
using System.Collections.Generic;

namespace ToolHireTests
{
    [TestClass]
    public class tstCheckUpCollection
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void InstanceOK()
        {
            clsCheckUpCollection AllCheckUp = new clsCheckUpCollection();
            Assert.IsNotNull(AllCheckUp);
        }

        [TestMethod]
        public void CheckUpListOK()
        {
            clsCheckUpCollection AllCheckUp = new clsCheckUpCollection();
            List<clsCheckUp> TestList = new List<clsCheckUp>();
            clsCheckUp TestItem = new clsCheckUp();
            TestItem.ToolReturn = true;
            TestItem.CheckUpId = 1;
            TestItem.CheckUpNo = 1;
            TestItem.StaffId = 1;
            TestItem.OrderId = 1;
            TestItem.Comments = "some comment";
            TestItem.DateAdded = DateTime.Now.Date;
            TestList.Add(TestItem);
            AllCheckUp.CheckUpList = TestList;
            Assert.AreEqual(AllCheckUp.CheckUpList, TestList);

        }



        [TestMethod]
        public void ThisCheckUpOK()
        {
            clsCheckUpCollection AllCheckUp = new clsCheckUpCollection();
            clsCheckUp TestCheckUp = new clsCheckUp();
            TestCheckUp.ToolReturn = true;
            TestCheckUp.CheckUpNo = 1;
            TestCheckUp.CheckUpId = 1;
            TestCheckUp.StaffId = 1;
            TestCheckUp.OrderId = 1;
            TestCheckUp.Comments = "some comment";
            TestCheckUp.DateAdded = DateTime.Now.Date;
            AllCheckUp.ThisCheckUp = TestCheckUp;
            Assert.AreEqual(AllCheckUp.ThisCheckUp, TestCheckUp);
         }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsCheckUpCollection AllCheckUp = new clsCheckUpCollection();
            List<clsCheckUp> TestList = new List<clsCheckUp>();
            clsCheckUp TestItem = new clsCheckUp();
            TestItem.ToolReturn = true;
            TestItem.CheckUpId = 1;
            TestItem.StaffId = 1;
            TestItem.OrderId = 1;
            TestItem.CheckUpNo = 1;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.Comments = "some comment";
            TestList.Add(TestItem);
            AllCheckUp.CheckUpList = TestList;
            Assert.AreEqual(AllCheckUp.Count, TestList.Count);



        }

        





    }
}
