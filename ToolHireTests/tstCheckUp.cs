using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;

namespace ToolHireTests
{
    [TestClass]
    public class tstCheckUp
    {

        string OrderId = "12";
        string StaffId = "12";
        string CheckUpNo = "12";
        string Comments = "ABC";
        string DateAdded = DateTime.Now.Date.ToString();


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
            public void DateAddedOK()
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
                AnCheckUp.Comments = TestData;
                //test to see that the two values are the same
                Assert.AreEqual(AnCheckUp.Comments, TestData);
            }

            [TestMethod]
            public void FindMethodOK()
            {
                
                clsCheckUp AnCheckUp = new clsCheckUp();
                
                Boolean Found = false;
                
                Int32 CheckUpId = 12;
                Found = AnCheckUp.Find(CheckUpId);
                
                Assert.IsTrue(Found);
            }

            [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsCheckUp AnCheckUp = new clsCheckUp();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CheckUpId = 12;
            Found = AnCheckUp.Find(CheckUpId);
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
                Int32 CheckUpId = 12;
                Found = AnCheckUp.Find(CheckUpId);
                //test to see that the two values are the same
                if (AnCheckUp.CheckUpId != 12)
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
                Int32 CheckUpId = 12;
                Found = AnCheckUp.Find(CheckUpId);
                //test to see that the two values are the same
                if (AnCheckUp.OrderId != 12)
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
                Int32 CheckUpId = 12;
                Found = AnCheckUp.Find(CheckUpId);
                //test to see that the two values are the same
                if (AnCheckUp.CheckUpNo != 12)
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
                int CheckUpId = 12;
                Found = AnCheckUp.Find(CheckUpId);
                //test to see that the two values are the same
                if (AnCheckUp.Comments != "ABC")
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
                Int32 CheckUpId = 12;
                Found = AnCheckUp.Find(CheckUpId);
                //test to see that the two values are the same
                if (AnCheckUp.ToolReturn != true)
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
            Int32 CheckUpId = 12;
            Found = AnCheckUp.Find(CheckUpId);
            //test to see that the two values are the same
            if (AnCheckUp.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void ValidMethodOK()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
         }

        [TestMethod]
        public void CheckUpNoMinLessOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string CheckUpNo = "";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CheckUpNoMin()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string CheckUpNo = "1";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CheckUpNoMinPlusOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string CheckUpNo = "11";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CheckUpNoMaxLessOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string CheckUpNo = "111";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CheckUpNoMax()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string CheckUpNo = "111";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CheckUpNoMid()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string CheckUpNo = "11";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CheckUpNoMaxPlusOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string CheckUpNo = "1111";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CheckUpNoExtremeMax()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string CheckUpNo = "";
            CheckUpNo = CheckUpNo.PadRight(500, 'a');
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-100);
            string DateAdded = TestDate.ToString();
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(-1);
            string DateAdded = TestDate.ToString();
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string DateAdded = TestDate.ToString();
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(1);
            string DateAdded = TestDate.ToString();
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string DateAdded = TestDate.ToString();
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvaliddata()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string DateAdded = "this is not a date!";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMinLessOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string OrderId = "";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");

        }

        [TestMethod]
        public void OrderIdMin()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string OrderId = "1";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void OrderIdMinPlusOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string OrderId = "11";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMaxLessOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string OrderId = "111111";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMax()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string OrderId = "1111";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMaxPlusOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string OrderId = "11111";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void OrderIdMid()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string OrderId = "11";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinLessOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string StaffId = "";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMin()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string StaffId = "1";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMinPlusOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string StaffId = "11";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMaxLessOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string StaffId = "";
            StaffId = StaffId.PadRight(4, 'a');
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMax()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string StaffId = "";
            StaffId = StaffId.PadRight(5, 'a');
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMaxPlusOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string StaffId = "";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void StaffIdMid()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string StaffId = "";
            StaffId = StaffId.PadRight(2, 'a');
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMinLessOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string Comments = "";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMin()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string Comments = "a";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMinPlusOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string Comments = "aa";
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMaxLessOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(49, 'a');
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMax()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(50, 'a');
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMaxPlusOne()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(51, 'a');
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CommentsMid()
        {
            clsCheckUp AnCheckUp = new clsCheckUp();
            String Error = "";
            string Comments = "";
            Comments = Comments.PadRight(25, 'a');
            Error = AnCheckUp.Valid(OrderId, StaffId, CheckUpNo, Comments, DateAdded);
            Assert.AreEqual(Error, "");
        }







    }







}
   
