using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;

namespace ToolHireTests
{
    [TestClass]
    public class tstOrders
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //test to check it isnt NULL
            Assert.IsNotNull(AnOrder);
        }

        [TestMethod]
        public void ProcessedOK()
        {
            //create an instance of the class we want to create
            clsOrders AnOrder = new clsOrders();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnOrder.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnOrder.Active, TestData);
        }

        [TestMethod]
        public void OrderIDOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestData = 1;
            AnOrder.OrderID = TestData;
            Assert.AreEqual(AnOrder.OrderID, TestData);
        }

        [TestMethod]
        public void OrderDateOK()
        {
            clsOrders AnOrder = new clsOrders();
            DateTime TestData = DateTime.Now.Date;
            AnOrder.DateAdded = TestData;
            Assert.AreEqual(AnOrder.DateAdded, TestData);
        }

        [TestMethod]
        public void ClientIDOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestClientID = 1;
            AnOrder.ClientID = TestClientID;
            Assert.AreEqual(AnOrder.ClientID, TestClientID);
        }

        [TestMethod]
        public void StaffIDOK()
        {
            clsOrders AnOrder = new clsOrders();
            Int32 TestStaffID = 1;
            AnOrder.StaffID = TestStaffID;
            Assert.AreEqual(AnOrder.StaffID, TestStaffID);
        }

        [TestMethod]
        public void TotalCostOK()
        {
            clsOrders AnOrder = new clsOrders();
            Double TestTotalCost = 1.0;
            AnOrder.TotalCost = TestTotalCost;
            Assert.AreEqual(AnOrder.TotalCost, TestTotalCost);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestOrderIDFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.OrderID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestDateAddedFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 OrderID = 1;
            Found = AnOrder.Find(OrderID);
            if (AnOrder.DateAdded != Convert.ToDateTime("18/02/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestStaffIDFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 StaffID = 1;
            Found = AnOrder.Find(StaffID);
            if (AnOrder.StaffID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestTotalCostFound()
        {
            clsOrders AnOrder = new clsOrders();
            Boolean Found = false;
            Boolean OK = true;
            Int32 TotalCost = 15;
            Found = AnOrder.Find(TotalCost);
            if (AnOrder.TotalCost != 15)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

    }
}
