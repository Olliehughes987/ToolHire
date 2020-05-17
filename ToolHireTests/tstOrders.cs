using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;

namespace ToolHireTests
{
    [TestClass]
    public class tstOrders
    {

        string ClientID = "1";
        string StaffID = "1";
        string TotalCost = "15";
        DateTime DateAdded = DateTime.Now.Date;


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
            Int32 TestTotalCost = 1;
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
            if (AnOrder.DateAdded != Convert.ToDateTime("17/05/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
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

        [TestMethod]
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

        [TestMethod]
        public void ValidMethodOK()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClientIDMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ClientID = "a";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClientIDMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ClientID = "aa";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ClientIDMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ClientID = "";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClientIDMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ClientID = "aaaaaa";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClientIDMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ClientID = "aaa";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ClientIDExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string ClientID = "";
            ClientID = ClientID.PadRight(500, 'a');
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            DateTime DateAdded = TestDate;
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            DateTime DateAdded = TestDate;
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            DateTime DateAdded = TestDate;
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne ()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            DateTime DateAdded = TestDate;
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            DateTime DateAdded = TestDate;
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidData()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TestDate = "aa";
            DateTime DateAdded = Convert.ToDateTime(TestDate);
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void StaffIDMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StaffID = "a";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StaffID = "aa";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StaffID = "";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StaffID = "aaaaaa";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StaffID = "aaa";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIDExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string StaffID = "";
            StaffID = StaffID.PadRight(500, 'a');
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        ////


        [TestMethod]
        public void TotalCostMin()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalCost = "a";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMinPlusOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalCost = "aa";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMinLessOne()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalCost = "";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalCost = "aaaaaa";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostMid()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalCost = "aaa";
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void TotalCostExtremeMax()
        {
            clsOrders AnOrder = new clsOrders();
            String Error = "";
            string TotalCost = "";
            StaffID = StaffID.PadRight(500, 'a');
            Error = AnOrder.Valid(ClientID, StaffID, DateAdded, TotalCost);
            Assert.AreNotEqual(Error, "");
        }





    }
}
