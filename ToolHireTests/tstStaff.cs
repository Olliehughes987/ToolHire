using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;

namespace ToolHireTests
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsStaff AnStaff = new clsStaff();

            Assert.IsNotNull(AnStaff);


        }


        [TestMethod]
        public void AvailabilityOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnStaff.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Active, TestData);
        }

        [TestMethod]
        public void DateHiredOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            DateTime TestData = DateTime.Now.Date;
            //assign the data to the property
            AnStaff.DateAdded = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.DateAdded, TestData);
        }


        [TestMethod]
        public void StaffIdOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            Int32 TestData = 1;
            //assign the data to the property
            AnStaff.StaffId = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.StaffId, TestData);
        }



        [TestMethod]
        public void StaffPositionOK()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Manager";
            //assign the data to the property
            AnStaff.position = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.position, TestData);
        }

        [TestMethod]
        public void StaffName()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Name";
            //assign the data to the property
            AnStaff.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Name, TestData);
        }

        [TestMethod]
        public void StaffPostcode()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();
            //create some test data to assign to the property
            string TestData = "Some Postcode";
            //assign the data to the property
            AnStaff.Postcode = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnStaff.Postcode, TestData);


        }


       /* [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffId = 10;

            Found = AnStaff.Find(StaffId);
            if (AnStaff.DateAdded != Convert.ToDateTime("11/02/2019"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestDateAddedFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffId = 10;

            Found = AnStaff.Find(StaffId);
            if (AnStaff.DateAdded != Convert.ToDateTime("11/02/2019"))
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

        [TestMethod]
        public void TestStaffIdFound()
        {
            //create an instance of the class we want to create
            clsStaff AnStaff = new clsStaff();

            Boolean Found = false;

            Boolean OK = true;

            Int32 StaffId = 10;

            Found = AnStaff.Find(StaffId);
            if (AnStaff.StaffId != 1)
            {
                OK = false;
            }

            Assert.IsTrue(OK);

        }

    */

    }


    



    }

