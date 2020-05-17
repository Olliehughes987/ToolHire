using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;


namespace ToolHireTests
{
    class tstOrderCollection
    {
        clsOrders mThisOrder = new clsOrders();



        [TestMethod]
        public void InstanceOK() {
            clsOrderCollection AllOrders = new clsOrderCollection();

        }
        [TestMethod]
        public void OrderListOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.ClientID = 1;
            TestItem.StaffID = 1;
            TestItem.TotalCost = 15;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.OrderList, TestList);
        }

        [TestMethod]
        public void ThisOrderPropertyOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.ClientID = 1;
            TestItem.StaffID = 1;
            TestItem.TotalCost = 15;
            AllOrders.ThisOrder = TestItem;
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            List<clsOrders> TestList = new List<clsOrders>();
            clsOrders TestItem = new clsOrders();
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.ClientID = 1;
            TestItem.StaffID = 1;
            TestItem.TotalCost = 15;
            TestList.Add(TestItem);
            AllOrders.OrderList = TestList;
            Assert.AreEqual(AllOrders.Count, TestList.Count);


        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.ClientID = 1;
            TestItem.StaffID = 1;
            TestItem.TotalCost = 15;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);

            Assert.AreEqual(AllOrders.ThisOrder, TestItem);
        }


        [TestMethod]
        public void DeleteMethodOK() {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.ClientID = 1;
            TestItem.StaffID = 1;
            TestItem.TotalCost = 15;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();
            TestItem.OrderID = PrimaryKey;
            AllOrders.ThisOrder.Find(PrimaryKey);
            AllOrders.Delete();
            Boolean Found = AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }

        [TestMethod]
        public void UpdateMethodOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrders TestItem = new clsOrders();
            Int32 PrimaryKey = 0;
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.ClientID = 1;
            TestItem.StaffID = 1;
            TestItem.TotalCost = 15;
            AllOrders.ThisOrder = TestItem;
            PrimaryKey = AllOrders.Add();

            TestItem.OrderID = PrimaryKey;
            TestItem.Active = true;
            TestItem.OrderID = 1;
            TestItem.ClientID = 1;
            TestItem.StaffID = 1;
            TestItem.TotalCost = 15;
            AllOrders.ThisOrder = TestItem;
            AllOrders.Update();
            AllOrders.ThisOrder.Find(PrimaryKey);
            Assert.AreEqual(AllOrders.ThisOrder, TestItem);

        }

        [TestMethod]
        public void ReportByClientIDOK()
        {
            clsOrderCollection AllOrders = new clsOrderCollection();
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByClientID("");
            Assert.AreEqual(AllOrders.Count, FilteredOrders.Count);     
        }

        [TestMethod]
        public void ReportByClientIDNoneFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            FilteredOrders.ReportByClientID("xx");
            Assert.AreEqual(0,FilteredOrders.Count);
        }

        [TestMethod]
        public void ReportByClientIDTestDataFound()
        {
            clsOrderCollection FilteredOrders = new clsOrderCollection();
            Boolean OK = true;
            FilteredOrders.ReportByClientID("yyy");
            if (FilteredOrders.Count == 2)
            {
                if (FilteredOrders.OrderList[0].OrderID != 36)
                {
                    OK = false;
                }
                if (FilteredOrders.OrderList[1].OrderID != 37)
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
