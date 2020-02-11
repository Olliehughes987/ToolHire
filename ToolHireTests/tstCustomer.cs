using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToolHireTests
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void TestMethod1()
        {
            //create an instance of the class we want to create
            clsCustomer anCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(anCustomer);
        }
    }
}
