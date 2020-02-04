using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;

namespace ToolHireTests
{
    [TestClass]
    public class tstTools
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsTools AnTools = new clsTools();
            Assert.IsNotNull(AnTools);

        }
    }

}
