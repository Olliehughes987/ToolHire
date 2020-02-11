using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;

namespace ToolHireTests
{
    [TestClass]
    public class tstStaff
    {
        [TestMethod]
        public void TestMethod1() { 
            clsStaff AnStaff = new clsStaff();

            Assert.IsNotNull(AnStaff);

        
        }
    }
}
