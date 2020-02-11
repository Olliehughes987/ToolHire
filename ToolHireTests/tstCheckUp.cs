using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToolHireClasses;

namespace ToolHireTests
{
    [TestClass]
    public class tstCheckUp
    {
        [TestMethod]
        public void TestMethod1()
        {
            clsCheckUp AncheckUp = new clsCheckUp();
            Assert.IsNotNull(AncheckUp);

        }
    }
}
