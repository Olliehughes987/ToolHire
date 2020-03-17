using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;

namespace ToolHireTests
{
    [TestClass]
    public class tstTools
    {
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
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnTools.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTools.DateAdded, TestData);
        }


        [TestMethod]
        public void ReplacementCostOK()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnTools.Cost = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTools.Cost, TestData);
        }


        [TestMethod]
        public void ToolNameOK()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //create some test data to assign to the property
            string TestData = "21b";
            //assign the data to the property
            AnTools.ToolName = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTools.ToolName, TestData);
        }

        [TestMethod]
        public void GradeOfToolOK()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //create some test data to assign to the property
            string TestData = "LE1 4AB";
            //assign the data to the property
            AnTools.Grade = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTools.Grade, TestData);
        }

        [TestMethod]
        public void ToolIdOK()
        {
            //create an instance of the class we want to create
            clsTools AnTools = new clsTools();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnTools.ToolId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnTools.ToolId, TestData);
        }

      

        [TestMethod]
        public void FindMethodOk()
        {
            clsTools AnTools = new clsTools();
            Boolean Found = false;
            Int32 ToolId = 1;
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
            if (AnTools.ToolName != "Platinum")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }


    }
}


     
