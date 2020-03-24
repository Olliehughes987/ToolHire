using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;

namespace ToolHireTests
{
    [TestClass]
    public class tstClient
    {
        [TestMethod]
        public void InstanceOk()
        {
            //create an instance of the class we want to create
            clsClient anCustomer = new clsClient();
            //test to see that it exists
            Assert.IsNotNull(anCustomer);
        }

        [TestMethod]
        public void SignUpDate()
        {
            //create an instance of the class we want to create
            clsClient AnClient = new clsClient();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnClient.SignUpDate = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnClient.SignUpDate, TestData);
        }


        [TestMethod]
        public void ClientId()
        {
            //create an instance of the class we want to create
            clsClient AnClient = new clsClient();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnClient.ClientId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnClient.ClientId, TestData);
        }

        [TestMethod]
        public void BillingInformation()
        {
            //create an instance of the class we want to create
            clsClient AnClient = new clsClient();
            //create some test data to assign to the property
            String TestData = "21b";
            //assign the data to the property
            AnClient.BillingInformation = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnClient.BillingInformation, TestData);
        }

        [TestMethod]
        public void ClientName()
        {
            //create an instance of the class we want to create
            clsClient AnClient = new clsClient();
            //create some test data to assign to the property
            String TestData = "Michael";
            //assign the data to the property
            AnClient.ClientName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnClient.ClientName, TestData);
        }

        [TestMethod]
        public void SubscriptionType()
        {
            //create an instance of the class we want to create
            clsClient AnClient = new clsClient();
            //create some test data to assign to the property
            String TestData = "TierOne";
            //assign the data to the property
            AnClient.SubscriptionType = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnClient.SubscriptionType, TestData);
        }

        [TestMethod]
        public void TestActiveClient()
        {
            //create an instance of the class we want to create
            clsClient AnClient = new clsClient();
            //boolean variable to store the result of the search
            Boolean TestData = true;
            //assign the data to the property
            AnClient.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnClient.Active, TestData);
        }

        //[TestMethod]
       // public void FindMethodOK()
        //{
            //Create an instance of the class we want to create
            //clsClient AnClient = new clsClient();
            //boolean variable to store the result of the validation
            //Boolean Found = false;
            //create some test data to use with the method
            
       // }

    }
}

