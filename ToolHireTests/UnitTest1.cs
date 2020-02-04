using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToolHireTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InstanceOK()
        {

            clsOrders AnOrder = new cldOrders();
            Assert.IsNotNull(AnOrder);
        }
    }
}
