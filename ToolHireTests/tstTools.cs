using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;

namespace ToolHireTests
{

    [TestClass]
    public class tstTools
    {
        String ToolName = "Hammer";
        String Cost = "22";
        String Grade = "Platinum";
        String DateAdded = DateTime.Now.Date.ToString();

        [TestMethod]
        public void InstanceOK()
        {
            clsTools AnTools = new clsTools();
            Assert.IsNotNull(AnTools);
        }

        [TestMethod]
        public void DateManufacturedOK()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //create some t est data to assign to the tool
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the tool
            AnTools.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTools.DateAdded, TestData);
        }

        [TestMethod]
        public void AvailabilityOK()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //create some test data to assign to the tool
            Boolean TestData = true;
            //assign the data to the tool
            AnTools.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTools.Active, TestData);
        }


        [TestMethod]
        public void ReplacementCostOK()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //create some test data to assign to the tool
            Int32 TestData = 1;
            //assign the data to the tool
            AnTools.Cost = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTools.Cost, TestData);
        }


        [TestMethod]
        public void ToolNameOK()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //create some test data to assign to the tool
            string TestData = "hammer";
            //assign the data to the tool
            AnTools.ToolName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTools.ToolName, TestData);
        }

        [TestMethod]
        public void GradeOfToolOK()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //create some test data to assign to the tool
            string TestData = "platinum";
            //assign the data to the tool
            AnTools.Grade = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTools.Grade, TestData);
        }

        [TestMethod]
        public void ToolIdOK()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //create some test data to assign to the tool
            Int32 TestData = 1;
            //assign the data to the tool
            AnTools.ToolId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTools.ToolId, TestData);
        }



        [TestMethod]
        public void FindMethodOk()
        {
            clsTools AnTools = new clsTools();
            Boolean Found = false;
            Int32 ToolId = 21;
            Found = AnTools.Find(ToolId);
            Assert.IsTrue(Found);

        }
        [TestMethod]
        public void TestToolIdFound()
        {
            clsTools AnTools = new clsTools();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ToolId = 21;
            Found = AnTools.Find(ToolId);
            if (AnTools.ToolId != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestDateAddedFound()
        {
            clsTools AnTools = new clsTools();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ToolId = 21;
            Found = AnTools.Find(ToolId);
            if (AnTools.DateAdded != Convert.ToDateTime("16/09/2015"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestCostFound()
        {
            clsTools AnTools = new clsTools();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ToolId = 21;
            Found = AnTools.Find(ToolId);
            if (AnTools.Cost != 21)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestToolNameFound()
        {
            clsTools AnTools = new clsTools();
            Boolean Found = false;
            Boolean OK = true;
            int ToolId = 21;
            Found = AnTools.Find(ToolId);
            if (AnTools.ToolName != "Hammer")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]
        public void TestGradeFound()
        {
            clsTools AnTools = new clsTools();
            Boolean Found = false;
            Boolean OK = true;
            int ToolId = 21;
            Found = AnTools.Find(ToolId);
            if (AnTools.Grade != "Platinum")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestActiveFound()
        {
            clsTools Antool = new clsTools();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ToolId = 21;
            Found = Antool.Find(ToolId);
            if (Antool.Active != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);

        }
        [TestMethod]
        public void ValidMethodOK()
        {
            clsTools AnTools = new clsTools();
            String Error = "";
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ToolNameMin()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ToolName = "a"; //this should be ok
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ToolNameMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ToolName = "aa"; //this should be ok
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ToolNameMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ToolName = "aaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ToolNameMax()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ToolName = "aaaaaaaaaaaaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ToolNameMid()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ToolName = "aaaaaaaaaa"; //this should be ok
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ToolNameExtremeMax()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            string ToolName = "";
            ToolName = ToolName.PadRight(500, 'a');//this should be Fail
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");

        }

        [TestMethod]
        public void DateAddedExtremeMin()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 100 years
            TestDate = TestDate.AddYears(-100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMinLessOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is less 1 day
            TestDate = TestDate.AddDays(-1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedMin()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void DateAddedMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 1 day
            TestDate = TestDate.AddDays(1);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedExtremeMax()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //create a variable to store the test date data
            DateTime TestDate;
            //set the date totodays date
            TestDate = DateTime.Now.Date;
            //change the date to whatever the date is plus 100 years
            TestDate = TestDate.AddYears(100);
            //convert the date variable to a string variable
            string DateAdded = TestDate.ToString();
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void DateAddedInvalidDate()
        {
            clsTools AnTools = new clsTools();
            string Error = "";
            string DateAdded = "this is not a date";
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            Assert.AreNotEqual(Error, "");

        }
        [TestMethod]
        public void GradeMinLessOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Grade = "";
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void GradeMin()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Grade = "a";
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GradeMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Grade = "aa";
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void GradeMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Grade = "";
            Grade = Grade.PadRight(19, 'a');
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GradeMax()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Grade = "";
            Grade = Grade.PadRight(20, 'a');
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void GradeMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Grade = "";
            Grade = Grade.PadRight(21, 'a');
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void GradeMid()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Grade = "";
            Grade = Grade.PadRight(10, 'a');
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMinLessOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should fail
            string Cost = "";
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void CostMin()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "a";
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMinPlusOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "aa";
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void CostMaxLessOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "";
            Cost = Cost.PadRight(9, 'a');
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMax()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "";
            Cost = Cost.PadRight(10, 'a');
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void CostMaxPlusOne()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this shold fail
            string Cost = "";
            Cost = Cost.PadRight(11, 'a');
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void CostMid()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //string variable to store any error message
            String Error = "";
            //this should pass
            string Cost = "";
            Cost = Cost.PadRight(5, 'a');
            //invoke the method
            Error = AnTools.Valid(ToolName, Cost, Grade, DateAdded);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }






    }
}


     
