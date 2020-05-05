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
        public void InstanceOK()
        {
            clsCheckUpCollection AllCheckUp = new clsCheckUpCollection();
            Assert.IsNotNull(AllCheckUp);
        }

        [TestMethod]
        public void ThisCheckUpOK()
        {
            clsCheckUpCollection AllCheckUp = new clsCheckUpCollection();
            clsCheckUp TestCheckUp = new clsCheckUp();
            TestCheckUp.ToolReturn = true;
            TestCheckUp.CheckUpId = 1;
            TestCheckUp.CheckUpNo = 1;
            TestCheckUp.StaffId = 1;
            TestCheckUp.OrderId = 1;
            TestCheckUp.Comments = "some comment";
            TestCheckUp.DateAdded = DateTime.Now.Date;
            AllCheckUp.ThisCheckUp = TestCheckUp;
            Assert.AreEqual(AllCheckUp.ThisCheckUp, TestCheckUp);

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

        [TestMethod]
        public void AddMethodOK()
        {
            clsCheckUpCollection AllCheckUp = new clsCheckUpCollection();
            clsCheckUp TestItem = new clsCheckUp();
            Int32 PrimaryKey = 0;
            TestItem.CheckUpId = 1;
            TestItem.ToolReturn = true;
            TestItem.CheckUpNo = 1;
            TestItem.StaffId = 1;
            TestItem.OrderId = 1;
            TestItem.Comments = "some comment";
            TestItem.DateAdded = DateTime.Now.Date;
            AllCheckUp.ThisCheckUp = TestItem;
            PrimaryKey = AllCheckUp.Add();
            TestItem.CheckUpId = PrimaryKey;
            AllCheckUp.ThisCheckUp.Find(PrimaryKey);
            Assert.AreEqual(AllCheckUp.ThisCheckUp, TestItem);



        }

        [TestMethod]
        public void DeleteMethodOK()
        {
            clsCheckUpCollection AllCheckUp = new clsCheckUpCollection();
            clsCheckUp TestItem = new clsCheckUp();
            Int32 PrimaryKey = 0;
            TestItem.ToolReturn = true;
            TestItem.CheckUpId = 1;
            TestItem.CheckUpNo = 1;
            TestItem.StaffId = 1;
            TestItem.OrderId = 1;
            TestItem.Comments = "some comment";
            TestItem.DateAdded = DateTime.Now.Date;
            AllCheckUp.ThisCheckUp = TestItem;
            PrimaryKey = AllCheckUp.Add();
            TestItem.CheckUpId = PrimaryKey;
            AllCheckUp.ThisCheckUp.Find(PrimaryKey);
            AllCheckUp.Delete();
            Boolean Found = AllCheckUp.ThisCheckUp.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsCheckUpCollection AllCheckUp = new clsCheckUpCollection();
            clsCheckUp TestItem = new clsCheckUp();
            Int32 PrimaryKey = 0;
            TestItem.ToolReturn = true;
            TestItem.CheckUpNo = 1;
            TestItem.Comments = "some comment";
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.StaffId = 1;
            TestItem.OrderId = 1;
            AllCheckUp.ThisCheckUp = TestItem;
            PrimaryKey = AllCheckUp.Add();
            TestItem.CheckUpId = PrimaryKey;
            TestItem.ToolReturn = false;
            TestItem.Comments = "another comment";
            TestItem.StaffId = 2;
            TestItem.OrderId = 2;
            TestItem.DateAdded = DateTime.Now.Date;
            TestItem.CheckUpNo = 2;
            AllCheckUp.ThisCheckUp = TestItem;
            AllCheckUp.Update();
            AllCheckUp.ThisCheckUp.Find(PrimaryKey);
            Assert.AreEqual(AllCheckUp.ThisCheckUp, TestItem);


        }

    }

}
