﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;

namespace ToolHireTests
{
    [TestClass]
    public class tstCheckUp
    {
            [TestMethod]
            public void InstanceOK()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                //test to see that it exists
                Assert.IsNotNull(AnCheckUp);
            }

            [TestMethod]
            public void CheckUpIdOK()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();            
                Int32 TestData = 1;
                AnCheckUp.CheckUpId = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnCheckUp.CheckUpId, TestData);
            }

            [TestMethod]
            public void StaffIdOK()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();              
                Int32 TestData = 1;
                AnCheckUp.StaffId = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnCheckUp.StaffId, TestData);
            }

            [TestMethod]
            public void OrderIdOK()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                Int32 TestData = 1;
                AnCheckUp.OrderId = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnCheckUp.OrderId, TestData);
            }

        [TestMethod]
            public void ToolsReturnedOK()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                Boolean TestData = true;
                AnCheckUp.ToolReturn = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnCheckUp.ToolReturn, TestData);
            }

            [TestMethod]
            public void DateOfCheckUpOK()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                DateTime TestData = DateTime.Now.Date;
                AnCheckUp.DateAdded = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnCheckUp.DateAdded, TestData);
            }


            [TestMethod]
            public void NoOfCheckUpsOK()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                Int32 TestData = 1;
                //assign the data to the property
                AnCheckUp.CheckUpNo = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnCheckUp.CheckUpNo, TestData);
            }

            [TestMethod]
            public void CommentsOK()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                string TestData = "21b";
                //assign the data to the property
                AnCheckUp.comments = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnCheckUp.comments, TestData);
            }

            [TestMethod]
            public void FindMethodOK()
            {
                
                clsCheckUp AnCheckUp = new clsCheckUp();
                
                Boolean Found = false;
                
                Int32 StaffId = 1;
                Found = AnCheckUp.Find(StaffId);
                
                Assert.IsTrue(Found);
            }

            [TestMethod]
            public void TestStaffIdFound()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                Boolean Found = false;
                Boolean OK = true;
                Int32 StaffId = 12;
                Found = AnCheckUp.Find(StaffId);
                //test to see that the two values are the same
               if (AnCheckUp.StaffId != 12)
                {
                    OK = false;
                }
                    Assert.IsTrue(OK);
            }


            [TestMethod]
            public void TestCheckUpIdFound()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                Boolean Found = false;
                //assign the data to the property
                Boolean OK = true;
                Int32 StaffId = 12;
                Found = AnCheckUp.Find(StaffId);
                //test to see that the two values are the same
                if (AnCheckUp.StaffId != 12)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }

            [TestMethod]
            public void TestOrderIdFound()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                //create some test data to assign to the property
                Boolean Found = false;
                //assign the data to the property
                Boolean OK = true;
                Int32 StaffId = 12;
                Found = AnCheckUp.Find(StaffId);
                //test to see that the two values are the same
                if (AnCheckUp.StaffId != 12)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }


            [TestMethod]
            public void TestNoOfCheckUpsFound()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                //create some test data to assign to the property
                Boolean Found = false;
                //assign the data to the property
                Boolean OK = true;
                Int32 StaffId = 12;
                Found = AnCheckUp.Find(StaffId);
                //test to see that the two values are the same
                if (AnCheckUp.StaffId != 12)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }


            [TestMethod]
            public void TestCommentsFound()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                Boolean Found = false;
                //assign the data to the property
                Boolean OK = true;
                Int32 StaffId = 12;
                Found = AnCheckUp.Find(StaffId);
                //test to see that the two values are the same
                if (AnCheckUp.StaffId != 12)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }


            [TestMethod]
            public void TestToolsReturnedFound()
            {
                //create an instance of the class we want to create
                clsCheckUp AnCheckUp = new clsCheckUp();
                Boolean Found = false;
                //assign the data to the property
                Boolean OK = true;
                Int32 StaffId = 12;
                Found = AnCheckUp.Find(StaffId);
                //test to see that the two values are the same
                if (AnCheckUp.StaffId != 12)
                {
                    OK = false;
                }
                Assert.IsTrue(OK);
            }


        [TestMethod]
        public void TestDateOfCheckUpFound()
        {
            //create an instance of the class we want to create
            clsCheckUp AnCheckUp = new clsCheckUp();
            //create some test data to assign to the property
            Boolean Found = false;
            //assign the data to the property
            Boolean OK = true;
            Int32 StaffId = 12;
            Found = AnCheckUp.Find(StaffId);
            //test to see that the two values are the same
            if (AnCheckUp.StaffId != 12)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }







}
   
